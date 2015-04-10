using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;
using System.Data;

namespace DataService.DAOService
{
    public class DAOCompte
    {
         private const string tableName = "Compte";
        private readonly string[] champs = new string[] { "MONTANT_INITIAL", "ID_CLIENT","ID_MOYEN_PAIEMENT","TYPE_COMPTE"};
        private readonly string[] champsWhere = new string[] { "ID_COMPTE" };

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
    }
}

    }
}
