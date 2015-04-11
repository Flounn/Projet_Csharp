﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;
using System.Data;
using DataService.BSService;

namespace DataService.DAOService
{
    public class DAOCarte
    {
        private const string tableName = "CARTE_BANCAIRE";
        private readonly string[] champs = new string[] { "DT_DEB_VALIDITE", "DT_FIN_VALIDITE", "ID_TYPE_CARTE", "NUMERO_CARTE" };
        private static readonly string[] champsWhere = new string[] { "ID_MOYEN_PAIEMENT" };

        public bool insert(Carte carte){
            object[] values = new object[] { carte.DateDebValidite, carte.DateFinValidite, carte.TypeCarte, carte.NumeroCarte};
            return Connexion.insert(tableName, champs, values);
        }

        public bool delete(Carte carte)
        {
            return Connexion.delete(tableName, champsWhere, new object[] { carte.IdMoyenPaiement });
        }

        public bool update(Carte carte)
        {
           object[] values = new object[] { carte.MontantInitial, carte.Client.IdClient, carte.TypeCarteStr};
           object[] valuesWhere = new object[] { carte.IdMoyenPaiement };
           return Connexion.update(tableName, champs, values, champsWhere, valuesWhere);
        }

        public static IDataReader getAll()
        {
            return Connexion.getAll(tableName);
        }

        public static IDataReader get(object id)
        {
            return Connexion.get(tableName, champsWhere, new object[] { id });
        }

        public static IDataReader get(CritereRechercheCarte criteres)
        {
            IList<string> champsWhere = new List<string>();
            IList<object> valuesWhere = new List<object>();
            IList<string> operators = new List<string>();

            Utilities.addCritere(champsWhere, valuesWhere, operators, "TYPE_COMPTE", criteres.TypeCarte, Connexion.LIKE);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "DT_OUVERTURE", criteres.DateOuvertureFin, Connexion.INFEGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "DT_OUVERTURE", criteres.DateOuvertureDebut, Connexion.SUPEGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_CLIENT", criteres.IdClient, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_MOYEN_PAIEMENT", criteres.IdMoyenPaiement, Connexion.EGAL);
            return Connexion.get(tableName, champsWhere, valuesWhere, operators);
        }
    }
}

