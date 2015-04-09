using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;
using System.Data;

namespace DataService.DAOService
{
    public class DAOClient
    {
        private const string tableName = "Client";
        private readonly string[] champs = new string[] { "NOM", "PRENOM","DT_NAISS","EMAIL","ADRESSE_PRINC",
                "ADRESSE_TEMP","TEL_FIXE","TEL_PORTABLE"};
        private readonly string[] champsWhere = new string[] { "ID_CLIENT" };

        public bool insert(Client client){
            object[] values = new object[] { client.Nom, client.Prenom, client.DateNaissance,client.Email,
                client.AdressePrincipale,client.AdresseTemporaire,client.TelFixe,client.TelPortable};
            return Connexion.insert(tableName, champs, values);
        }

        public bool delete(Client client)
        {
            return Connexion.delete(tableName, champsWhere, new object[] { client.IdClient });
        }

        public bool update(Client client)
        {
            object[] values = new object[] { client.Nom, client.Prenom, client.DateNaissance,client.Email,
                client.AdressePrincipale,client.AdresseTemporaire,client.TelFixe,client.TelPortable};
            object[] valuesWhere = new object[] { client.IdClient };
            return Connexion.update(tableName, champs, values, champsWhere, valuesWhere);
        }

        public static IDataReader getAll()
        {
            return Connexion.getAll(tableName);
        }
    }
}
