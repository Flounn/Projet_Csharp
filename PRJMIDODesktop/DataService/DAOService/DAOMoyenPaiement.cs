using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;
using System.Data;
using DataService.BSService;

namespace DataService.DAOService
{
    public class DAOMoyenPaiement
    {
        private const string tableName = "MOYEN_PAIEMENT";
        private readonly string[] champs = new string[] { "ID_COMPTE", "LIBELLE_MOYEN_PAIEMENT" };
        private static readonly string[] champsWhere = new string[] { "ID_MOYEN_PAIEMENT" };

        public bool insert(MoyenPaiement moyenPaiement){
            if (moyenPaiement is Carte)
                return ((Carte)moyenPaiement).persist();
            else if (moyenPaiement is Chequier)
                return ((Chequier)moyenPaiement).persist();
            else
                throw new NotImplementedException();
        }

        public bool delete(MoyenPaiement moyenPaiement)
        {
            return Connexion.callProcedureNonQuery("delMoyenPaiement", champsWhere, new object[] { moyenPaiement.IdMoyenPaiement });
        }

        public bool update(MoyenPaiement moyenPaiement)
        {
            object[] values = new object[] { moyenPaiement.Compte.IdCompte, moyenPaiement.LibelleMoyenPaiementStr };
           object[] valuesWhere = new object[] { moyenPaiement.IdMoyenPaiement };
           return Connexion.update(tableName, champs, values, champsWhere, valuesWhere);
        }

        public static IDataReader getAll()
        {
            return Connexion.getAll(tableName);
        }

        public static IDataReader get(long id)
        {
            return Connexion.get(tableName, champsWhere, new object[] { id });
        }

        private static IDataReader get(CritereRechercheMoyenPaiement criteres)
        {
            IList<string> champsWhere = new List<string>();
            IList<object> valuesWhere = new List<object>();
            IList<string> operators = new List<string>();

            Utilities.addCritere(champsWhere, valuesWhere, operators, "LIBELLE_MOYEN_PAIEMENT", criteres.IdMoyenPaiement, Connexion.LIKE);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_COMPTE", criteres.IdCompte, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_MOYEN_PAIEMENT", criteres.IdMoyenPaiement, Connexion.EGAL);
            return Connexion.get(tableName, champsWhere, valuesWhere, operators);
        }
        public static DataTable getDataTable(CritereRechercheMoyenPaiement criteres)
        {
            IDataReader reader = get(criteres);
            DataTable dt = new DataTable();
            if (reader != null)
            {
                dt.Load(reader);
                reader.Close();
            }
            return dt;
        }
    }
}

