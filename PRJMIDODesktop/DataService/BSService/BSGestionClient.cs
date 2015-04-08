using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;

namespace DataService.BSService
{
    public static class BSGestionClient
    {

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

        public static long CreerModifierCompte(Compte compte)
        {
            return 1;
        }

        public static Contrat RechercherContrat(CritereRechercheContrat contrat)
        {
            return null;
        }
    }
}
