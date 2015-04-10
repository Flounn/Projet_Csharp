using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;
using System.Data;
using DataService.BSService;

namespace DataService.DAOService
{
    public class DAOClient
    {
        private const string tableName = "Client";
        private static readonly string[] champs = new string[] { "NOM", "PRENOM","DT_NAISS","EMAIL","ADRESSE_PRINC",
                "ADRESSE_TEMP","TEL_FIXE","TEL_PORTABLE"};
        private static readonly string[] champsWhere = new string[] { "ID_CLIENT" };

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
        public static IDataReader get(object id)
        {
            return Connexion.get(tableName, champsWhere, new object[] { id });
        }

        public static IDataReader get(CritereRechercheClient criteres)
        {
            IList<string> champsWhere = new List<string>();
            IList<object> valuesWhere = new List<object>();
            IList<string> operators = new List<string>();

            Utilities.addCritere(champsWhere,valuesWhere,operators,"EMAIL",criteres.Email,Connexion.LIKE);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "NOM", criteres.Nom, Connexion.LIKE);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "PRENOM", criteres.Prenom, Connexion.LIKE);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ADRESSE_PRINC", criteres.Adresse, Connexion.LIKE);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "DT_NAISS", criteres.DateNaissanceFin, Connexion.INF);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "DT_NAISS", criteres.DateNaissanceDebut, Connexion.SUP);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_CLIENT", criteres.IdClient, Connexion.EGAL);
            return Connexion.get(tableName, champsWhere, valuesWhere, operators);
        }

    }
}
