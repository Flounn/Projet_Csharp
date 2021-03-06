﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;
using System.Data;
using DataService.BSService;

namespace DataService.DAOService
{
    public class DAOContrat
    {
        private const string tableName = "Contrat";
        private static readonly string[] champs = new string[] { "INTITULE", "ID_CLIENT","ID_COMPTE","STATUT_JUR",
                "TYPE"};
        private static readonly string[] champsWhere = new string[] { "ID_CONTRAT" };

        public bool insert(Contrat contrat){
            if (contrat is ContratCredit)
                return ((ContratCredit)contrat).persist();
            else if (contrat is ContratEpargne)
                return ((ContratEpargne)contrat).persist();
            else
                throw new NotImplementedException();
        }

        public bool delete(Contrat contrat)
        {
            return Connexion.callProcedureNonQuery("delContrat", new string[] { "P_ID_CONTRAT" }, new object[] { contrat.IdContrat }, false);
        }

        public bool update(Contrat contrat)
        {
            object[] values = new object[] { contrat.Intitule, contrat.Client.IdClient,
                contrat.Compte.IdCompte, contrat.StatutJuridiqueStr,contrat.TypeStr};
            object[] valuesWhere = new object[] { contrat.IdContrat };
            return Connexion.update(tableName, champs, values, champsWhere, valuesWhere);
        }

        public static IDataReader getAll()
        {
            return Connexion.getAll(tableName);
        }
        public static IDataReader get(long id)
        {
            return Connexion.get(tableName, champsWhere, new object[] { id });
        }

        private static IDataReader get(CritereRechercheContrat criteres)
        {
            IList<string> champsWhere = new List<string>();
            IList<object> valuesWhere = new List<object>();
            IList<string> operators = new List<string>();

            Utilities.addCritere(champsWhere, valuesWhere, operators, "INTITULE", criteres.Intitule, Connexion.LIKE);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "TYPE", criteres.Type, Connexion.LIKE);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "DT_SOUS", criteres.DateSouscriptionFin,Connexion.INFEGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "DT_SOUS", criteres.DateSouscriptionDebut,Connexion.SUPEGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_CONTRAT", criteres.IdContrat, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_CLIENT", criteres.IdClient, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_PRODUIT", criteres.IdProduit, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_COMPTE", criteres.IdCompte, Connexion.EGAL);
            return Connexion.get(tableName, champsWhere, valuesWhere, operators);
        }

        public static DataTable getDataTable(CritereRechercheContrat criteres)
        {
            IDataReader reader = get(criteres);
            DataTable dt = new DataTable();
            if (reader != null)
            {
                dt.Load(reader);
                reader.Close();
            }
            return dt;
        }

    }
}
