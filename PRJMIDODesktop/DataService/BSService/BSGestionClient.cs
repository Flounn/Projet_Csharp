using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;
using DataService.DAOService;
using System.Data;

namespace DataService.BSService
{
    public static class BSGestionClient
    {

        public static IDataReader RechercherClients(CritereRechercheClient criteres)
        {
            return DAOClient.get(criteres);
        }

        public static IDataReader RechercherComptes(CritereRechercheCompte criteres)
        {
            return DAOCompte.get(criteres);
        }

        public static IDataReader RechercherOperations(CritereRechercheOperation criteres)
        {
            return DAOOperation.get(criteres);
        }

        public static IDataReader RechercherContrats(CritereRechercheContrat criteres)
        {
            return DAOContrat.get(criteres);
        }

        public static bool CreerModifierClient(Client client)
        {
            return client.persist();
        }

        public static bool CreerModifierCompte(Compte compte)
        {
            return compte.persist();
        }

        public static bool CreerModifierOperation(Operation operation)
        {
            return operation.persist();
        }

        public static bool CreerModifierContrat(Contrat contrat)
        {
            return contrat.persist();
        }

    }
}
