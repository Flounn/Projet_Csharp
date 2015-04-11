using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;
using System.Data;
using DataService.BSService;

namespace DataService.DAOService
{
    public class DAOOperation
    {
        private const string tableName = "OPERATION";
        private static readonly string[] champs = new string[] { "ID_MOYEN_PAIEMENT", "LIBELLE","TYPE_OPERATION","MNT_DEBIT"
            ,"MNT_CREDIT","STATUT","ID_COMPTE"};
        private static readonly string[] champsWhere = new string[] { "ID_OPERATION" };

        public bool insert(Operation operation){
            object[] values = new object[] { operation.MoyenPaiement.IdMoyenPaiement, operation.Libelle, operation.TypeOperationStr
                ,operation.MontantDebit,operation.MontantCredit,operation.StatutStr,operation.Compte.IdCompte};
            return Connexion.insert(tableName, champs, values);
        }

        public bool delete(Operation operation)
        {
            return Connexion.delete(tableName, champsWhere, new object[] { operation.IdOperation });
        }

        public bool update(Operation operation)
        {
            object[] values = new object[] { operation.MoyenPaiement.IdMoyenPaiement, operation.Libelle, operation.TypeOperationStr
                ,operation.MontantDebit,operation.MontantCredit,operation.StatutStr,operation.Compte.IdCompte};
            object[] valuesWhere = new object[] { operation.IdOperation };
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

        public static IDataReader get(CritereRechercheOperation criteres)
        {
            IList<string> champsWhere = new List<string>();
            IList<object> valuesWhere = new List<object>();
            IList<string> operators = new List<string>();

            Utilities.addCritere(champsWhere,valuesWhere,operators,"LIBELLE",criteres.Libelle,Connexion.LIKE);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "TYPE_OPERATION", criteres.TypeOperation, Connexion.LIKE);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "STATUT", criteres.Statut, Connexion.LIKE);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "DT_OPERATION", criteres.DateOperationFin,Connexion.INFEGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "DT_OPERATION", criteres.DateOperationDebut,Connexion.SUPEGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_OPERATION", criteres.IdOperation, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_MOYEN_PAIEMENT", criteres.IdMoyenPaiement, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_COMPTE", criteres.IdMoyenPaiement, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, criteres.isCredit() ? "MNT_CREDIT" : "MNT_DEBIT", "NOT NULL" , Connexion.IS);
            return Connexion.get(tableName, champsWhere, valuesWhere, operators);
        }

    }
}
