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

        public static bool CreerModifierContratEpargne(ContratEpargne contratEpargne)
        {
            return contratEpargne.persist();
        }
        public static bool CreerModifierContratCredit(ContratCredit contratCredit)
        {
            return contratCredit.persist();
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

        public static bool creerModifierCarte(Carte carte)
        {
            return carte.persist();
        }

        public static bool creerModifierChequier(Chequier chequier)
        {
            return chequier.persist();
        }

        public static Client getClient(long idClient)
        {
            Client client = null;
            IDataReader reader = DAOClient.get(idClient);
            if (reader.Read())
            {
                client = new Client();
                if (!reader.IsDBNull(0))
                    client.IdClient=(int)reader.GetValue(0);
                if (!reader.IsDBNull(1))
                    client.Nom=(string)reader.GetValue(1);
                if (!reader.IsDBNull(2))
                    client.Prenom = (string)reader.GetValue(2);
                if (!reader.IsDBNull(3))
                    client.DateNaissance = (DateTime)reader.GetValue(3);
                if (!reader.IsDBNull(4))
                    client.Email = (string)reader.GetValue(4);
                if (!reader.IsDBNull(5))
                    client.AdressePrincipale = (string)reader.GetValue(5);
                if (!reader.IsDBNull(6))
                    client.AdresseTemporaire = (string)reader.GetValue(6);
                if (!reader.IsDBNull(7))
                    client.TelFixe = (string)reader.GetValue(7);
                if (!reader.IsDBNull(8))
                    client.TelPortable = (string)reader.GetValue(8);
            }
            reader.Close();
            return client;
        }

        public static bool supprimerContratEpargne(ContratEpargne contratEpargne)
        {
            return contratEpargne.delete();
        }
        public static bool supprimerContratCredit(ContratCredit contratCredit)
        {
            return contratCredit.delete();
        }
        public static ContratEpargne getContratEpargne(long idContrat)
        {
            ContratEpargne contrat = null;
            IDataReader reader = DAOContratEpargne.get(idContrat);
            if (reader.Read())
            {
                contrat = new ContratEpargne();
                if (!reader.IsDBNull(0))
                    contrat.IdContrat = (int)reader.GetValue(0);
                if (!reader.IsDBNull(1))
                    contrat.TypeEpargne = (string)reader.GetValue(1);
                if (!reader.IsDBNull(2))
                    contrat.TypeVersement = (string)reader.GetValue(2);
                if (!reader.IsDBNull(3))
                    contrat.Periodicite = (string)reader.GetValue(3);
                if (!reader.IsDBNull(4))
                    contrat.DateVersement = (DateTime)reader.GetValue(4);
                if (!reader.IsDBNull(5))
                    contrat.MontantVerse = (decimal)reader.GetValue(5);
            }
            reader.Close();
            return contrat;
        }

        public static ContratCredit getContratCredit(long idContrat)
        {
            ContratCredit contrat = null;
            IDataReader reader = DAOContratCredit.get(idContrat);
            if (reader.Read())
            {
                contrat = new ContratCredit();
                if (!reader.IsDBNull(0))
                    contrat.IdContrat = (int)reader.GetValue(0);
                if (!reader.IsDBNull(1))
                    contrat.ObjectifCredit = (string)reader.GetValue(1);
                if (!reader.IsDBNull(2))
                    contrat.DateEcheance = (DateTime)reader.GetValue(2);
                if (!reader.IsDBNull(3))
                    contrat.Duree = (int)reader.GetValue(3);
                if (!reader.IsDBNull(4))
                    contrat.Taux = (decimal)reader.GetValue(4);
                if (!reader.IsDBNull(5))
                    contrat.MontantCredit = (decimal)reader.GetValue(5);
                if (!reader.IsDBNull(6))
                    contrat.DateProchaineEcheance = (DateTime)reader.GetValue(6);
                if (!reader.IsDBNull(7))
                    contrat.MontantEcheance = (decimal)reader.GetValue(7);
                if (!reader.IsDBNull(8))
                    contrat.TauxNominal = (decimal)reader.GetValue(8);
                if (!reader.IsDBNull(8))
                    contrat.Encours = (decimal)reader.GetValue(8);
            }
            reader.Close();
            return contrat;
        }
    }
}
