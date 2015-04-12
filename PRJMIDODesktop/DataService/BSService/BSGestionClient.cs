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

        public static DataTable RechercherClients(CritereRechercheClient criteres)
        {
            return DAOClient.getDataTable(criteres);
        }

        public static DataTable RechercherComptes(CritereRechercheCompte criteres)
        {
            return DAOCompte.getDataTable(criteres);
        }

        public static DataTable RechercherOperations(CritereRechercheOperation criteres)
        {
            return DAOOperation.getDataTable(criteres);
        }

        public static DataTable RechercherContrats(CritereRechercheContrat criteres)
        {
            return DAOContrat.getDataTable(criteres);
        }

        public static DataTable RechercherMoyensPaiement(CritereRechercheMoyenPaiement criteres)
        {
            return DAOMoyenPaiement.getDataTable(criteres);
        }
        
        public static bool CreerModifierClient(Client client)
        {
            return client.persist();
        }

        public static bool SupprimerClient(Client client)
        {
            return client.delete();
        }

        public static bool CreerModifierCompte(Compte compte)
        {
            return compte.persist();
        }

        public static bool SupprimerCompte(Compte compte)
        {
            return compte.delete();
        }

        public static bool CreerModifierOperation(Operation operation)
        {
            return operation.persist();
        }

        public static bool SupprimerOperation(Operation operation)
        {
            return operation.delete();
        }

        public static bool CreerModifierContrat(Contrat contrat)
        {
            return contrat.persist();
        }

        public static bool SupprimerContrat(Contrat contrat)
        {
            return contrat.delete();
        }

        public static bool InsertTypeCarte(TypeCarte typeCarte)
        {
            return typeCarte.persist();
        }

        public static DataTable RechercherTypeCarte(CritereRechercheTypeCarte criteres)
        {
            return DAOTypeCarte.getDataTable(criteres);
        }
    }
}
