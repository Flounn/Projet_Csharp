using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;
using DataService.DAOService;

namespace DataService.BSService
{
    public static class BSGestionClient
    {
        private static DAOCompte dao = new DAOCompte();

        public static IList<Client> RechercherClient(CritereRechercheClient critere)
        {
            return null;
        }

        public static IList<Compte> RechercherCompteClient(CritereRechercheCompte critere)
        {
            return null;
        }

        public static IList<Operation> RechercherOperations(CritereRechercheOperation critere)
        {
            return null;
        }

        public static bool CreerModifierClient(Client c)
        {
            return false;
        }

        public static bool CreerModifierCompte(Compte compte)
        {
            return dao.update(compte);
        }

        public static IList<Contrat> RechercherContrat(CritereRechercheContrat contrat)
        {
            return null;
        }
    }
}
