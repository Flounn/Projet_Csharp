﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;
using System.Data;
using DataService.BSService;

namespace DataService.DAOService
{
    public class DAOChequier
    {
        private const string tableName = "CHEQUIER";
        private readonly string[] champs = new string[] { "ID_MOYEN_PAIEMENT","NOMBRE_CHQ", "NUMERO_1_CHQ", "NUMERO_D_CHQ" };
        private static readonly string[] champsWhere = new string[] { "ID_MOYEN_PAIEMENT" };

        public bool insert(Chequier chequier){
            object[] values = new object[] { chequier.Compte.IdCompte,chequier.LibelleMoyenPaiementStr, chequier.NombreCheque
                            , chequier.Numero1Cheque, chequier.DernierCheque };
            string[] parameters = new string[] {"ID_COMPTE","LIBELLE_MOYEN_PAIEMENT", "NOMBRE_CHQ"
							,"NUMERO_1_CHQ","NUMERO_D_CHQ"};
            return Connexion.callProcedureNonQuery("addChequier", parameters, values,true);
        }

        public bool delete(Chequier chequier)
        {
            return Connexion.callProcedureNonQuery("delChequier", new string[] { "P_ID_MOYEN_PAIEMENT" }, new object[] { chequier.IdMoyenPaiement }, false);
        }

        public bool update(Chequier chequier)
        {
            object[] values = new object[] { chequier.IdMoyenPaiement, chequier.NombreCheque, chequier.Numero1Cheque, chequier.DernierCheque };
           object[] valuesWhere = new object[] { chequier.IdMoyenPaiement };
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

