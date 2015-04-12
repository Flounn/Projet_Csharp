using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;
using System.Data;
using DataService.BSService;

namespace DataService.DAOService
{
    public class DAOContratCredit
    {
        private const string tableName = "CONTRAT_CREDIT";
        private static readonly string[] champs = new string[] { "OBJ_CREDIT", "DT_ECHEANCE","DUREE","TAUX","MNT_CREDIT",
                "DT_PROC_ECHANCE","MNT_ECHEANCE","TAUX_NOMINAL","ENCOURS"};
        private static readonly string[] champsWhere = new string[] { "ID_CONTRAT" };

        public bool insert(ContratCredit contratCredit){
            object[] values = new object[] { contratCredit.Intitule, contratCredit.Client.IdClient,contratCredit.Compte.IdCompte,
                contratCredit.StatutJuridiqueStr, contratCredit.TypeStr,contratCredit.ObjectifCredit,contratCredit.DateEcheance,
                contratCredit.Duree,contratCredit.Taux,contratCredit.MontantCredit,contratCredit.DateEcheance,
                contratCredit.MontantEcheance,contratCredit.TauxNominal,contratCredit.Encours};
            string[] parametersName = new string[]{"INTITULE","ID_CLIENT","ID_COMPTE","STATUT_JUR","TYPE"
                                                    ,"OBJ_CREDIT", "DT_ECHEANCE","DUREE","TAUX","MNT_CREDIT",
                                                    "DT_PROC_ECHANCE","MNT_ECHEANCE","TAUX_NOMINAL","ENCOURS"};

            return Connexion.callProcedureNonQuery("addContratCredit", parametersName, values);
        }

        public bool delete(ContratCredit contratCredit)
        {
            return Connexion.callProcedureNonQuery("delContratCredit", champsWhere, new object[] { contratCredit.IdContrat });
        }

        public bool update(ContratCredit contratCredit)
        {
            object[] values = new object[] { contratCredit.ObjectifCredit, contratCredit.DateEcheance,
                contratCredit.Duree, contratCredit.Taux,contratCredit.MontantCredit,contratCredit.DateEcheance
                ,contratCredit.MontantEcheance,contratCredit.TauxNominal,contratCredit.Encours};
            object[] valuesWhere = new object[] { contratCredit.IdContrat };
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

        

    }
}
