using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;
using System.Data;
using DataService.BSService;

namespace DataService.DAOService
{
    public class DAOContratEpargne
    {
        private const string tableName = "CONTRAT_EPARGNE";
        private static readonly string[] champs = new string[] { "TYPE_EPARGNE", "TYPE_VERSEMENT","PERIODICITE","DT_VERSEMENT"
            ,"MNT_VERSE"};
        private static readonly string[] champsWhere = new string[] { "ID_CONTRAT" };

        public bool insert(ContratEpargne contratEpargne){
            object[] values = new object[] { contratEpargne.Intitule, contratEpargne.Client.IdClient, contratEpargne.Compte.IdCompte,
                    contratEpargne.StatutJuridiqueStr,contratEpargne.TypeStr,contratEpargne.TypeEpargne,contratEpargne.TypeVersement,
                       contratEpargne.Periodicite,contratEpargne.DateVersement,contratEpargne.MontantVerse};
            string[] parametersName = new string[]{"INTITULE","ID_CLIENT","ID_COMPTE","STATUT_JUR","TYPE"
                                                    ,"TYPE_EPARGNE", "TYPE_VERSEMENT","PERIODICITE","DT_VERSEMENT"
                                                    ,"MNT_VERSE"};

            return Connexion.callProcedureNonQuery("addContratEpargne", parametersName, values,true);
        }

        public bool delete(ContratEpargne contratEpargne)
        {
            return Connexion.callProcedureNonQuery("delContratEpargne", new string[] { "P_ID_CONTRAT" }, new object[] { contratEpargne.IdContrat }, false);
        }

        public bool update(ContratEpargne contratEpargne)
        {
            object[] values = new object[] { contratEpargne.TypeEpargne,contratEpargne.TypeVersement,
                       contratEpargne.Periodicite,contratEpargne.DateVersement,contratEpargne.MontantVerse};
            object[] valuesWhere = new object[] { contratEpargne.IdContrat };
            if (((Contrat)contratEpargne).persist())
                return Connexion.update(tableName, champs, values, champsWhere, valuesWhere);
            else return false;
        }

        public static IDataReader getAll()
        {
            return Connexion.getAll(tableName);
        }
        public static IDataReader get(long id)
        {
            return Connexion.get(tableName, champsWhere, new object[] { id });
        }

    }
}
