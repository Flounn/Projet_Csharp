using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;
using System.Data;
using DataService.BSService;

namespace DataService.DAOService
{
    public class DAOCompte
    {
         private const string tableName = "Compte";
        private readonly string[] champs = new string[] { "MONTANT_INITIAL", "ID_CLIENT","ID_MOYEN_PAIEMENT","TYPE_COMPTE"};
        private static readonly string[] champsWhere = new string[] { "ID_COMPTE" };

        public bool insert(Compte compte){
            object[] values = new object[] { compte.MontantInitial, compte.Client.IdClient, compte.MoyenPaiement.IdMoyenPaiement,compte.TypeCompteStr};
            return Connexion.insert(tableName, champs, values);
        }

        public bool delete(Compte compte)
        {
            return Connexion.delete(tableName, champsWhere, new object[] { compte.IdCompte });
        }

        public bool update(Compte compte)
        {
           object[] values = new object[] { compte.MontantInitial, compte.Client.IdClient, compte.MoyenPaiement.IdMoyenPaiement,compte.TypeCompteStr};
           object[] valuesWhere = new object[] { compte.IdCompte };
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

        public static IDataReader get(CritereRechercheCompte criteres)
        {
            IList<string> champsWhere = new List<string>();
            IList<object> valuesWhere = new List<object>();
            IList<string> operators = new List<string>();

            Utilities.addCritere(champsWhere, valuesWhere, operators, "TYPE_COMPTE", criteres.TypeCompte, Connexion.LIKE);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "DT_OUVERTURE", criteres.DateOuvertureFin, Connexion.INFEGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "DT_OUVERTURE", criteres.DateOuvertureDebut, Connexion.SUPEGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_CLIENT", criteres.IdClient, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_MOYEN_PAIEMENT", criteres.IdMoyenPaiement, Connexion.EGAL);
            return Connexion.get(tableName, champsWhere, valuesWhere, operators);
        }
    }
}

