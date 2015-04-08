using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;

namespace DataService.DAOService
{
    public class DAOClient
    {
        public bool insert(Client client){
            string[] champs = new string[] { "NOM", "PRENOM","DT_NAISS","EMAIL","ADRESSE_PRINC",
                "ADRESSE_TEMP","TEL_FIXE","TEL_PORTABLE"};
            object[] values = new object[] { client.Nom, client.Prenom, client.DateNaissance,client.Email,
                client.AdressePrincipale,client.AdresseTemporaire,client.TelFixe,client.TelPortable};
            return Connexion.insert("Client",champs,values);
        }
    }
}
