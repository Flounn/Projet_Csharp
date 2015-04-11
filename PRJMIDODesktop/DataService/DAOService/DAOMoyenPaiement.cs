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
            object[] values = new object[] { moyenPaiement.Compte.IdCompte, moyenPaiement.LibelleMoyenPaiementStr};
            return Connexion.insert(tableName, champs, values);
        }

        public bool delete(MoyenPaiement moyenPaiement)
        {
            return Connexion.delete(tableName, champsWhere, new object[] { moyenPaiement.IdMoyenPaiement });
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

        public static IDataReader get(object id)
        {
            return Connexion.get(tableName, champsWhere, new object[] { id });
        }

        public static IDataReader get(CritereRechercheMoyenPaiement criteres)
        {
            IList<string> champsWhere = new List<string>();
            IList<object> valuesWhere = new List<object>();
            IList<string> operators = new List<string>();

            Utilities.addCritere(champsWhere, valuesWhere, operators, "TYPE_COMPTE", criteres.TypeMoyenPaiement, Connexion.LIKE);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "DT_OUVERTURE", criteres.DateOuvertureFin, Connexion.INFEGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "DT_OUVERTURE", criteres.DateOuvertureDebut, Connexion.SUPEGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_CLIENT", criteres.IdClient, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_MOYEN_PAIEMENT", criteres.IdMoyenPaiement, Connexion.EGAL);
            return Connexion.get(tableName, champsWhere, valuesWhere, operators);
        }
    }
}

