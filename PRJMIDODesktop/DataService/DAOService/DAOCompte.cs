using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;

namespace DataService.DAOService
{
    public class DAOCompte
    {
        public bool insert(Compte compte){
            return Connexion.insert("Compte", new string[] { "MONTANT_INITIAL", "ID_CLIENT", "TYPE_COMPTE" },
                new object[] { compte.Client.IdClient, compte.MontantInitial, compte.TypeCompte.ToString() });
        }
    }
}
