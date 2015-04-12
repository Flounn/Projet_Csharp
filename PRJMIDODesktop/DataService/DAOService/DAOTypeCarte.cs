using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;
using System.Data;
using DataService.BSService;

namespace DataService.DAOService
{
    public class DAOTypeCarte
    {
        private const string tableName = "TYPE_CARTE";
        private readonly string[] champs = new string[] { "RESEAU", "PLF_GLO_PAIE","PLF_GLO_PAIE_ETRG","PERI_PLF_PAIE"
            ,"PLF_GLO_RET_EXT","PLF_RET_ETRG","PLF_RET_FCE","PERI_PLF_GLO_RET","PLF_GLO_RET_INT"};
        private static readonly string[] champsWhere = new string[] { "ID_TYPE_CARTE" };

        public bool insert(TypeCarte typeCarte){
            object[] values = new object[] { typeCarte.ReseauCarteStr, typeCarte.PlfGloPaiement, typeCarte.PlfGloPaiement
                , typeCarte.PeriodePlfPaiement, typeCarte.PlfGlobalRetraitExterne,typeCarte.PlfRetEtranger,typeCarte.PlfRetraitFrance
                ,typeCarte.PeriodePlfGlobalRetrait,typeCarte.PlfGlobalRetraitInternes};
            return Connexion.insert(tableName, champs, values);
        }

        public bool delete(TypeCarte typeCarte)
        {
            return Connexion.delete(tableName, champsWhere, new object[] { typeCarte.IdTypeCarte });
        }

        public bool update(TypeCarte typeCarte)
        {
            object[] values = new object[] { typeCarte.ReseauCarteStr, typeCarte.PlfGloPaiement, typeCarte.PlfGloPaiement
                , typeCarte.PeriodePlfPaiement, typeCarte.PlfGlobalRetraitExterne,typeCarte.PlfRetEtranger,typeCarte.PlfRetraitFrance
                ,typeCarte.PeriodePlfGlobalRetrait,typeCarte.PlfGlobalRetraitInternes };
           object[] valuesWhere = new object[] { typeCarte.IdTypeCarte };
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

        private static IDataReader get(CritereRechercheTypeCarte criteres)
        {
            IList<string> champsWhere = new List<string>();
            IList<object> valuesWhere = new List<object>();
            IList<string> operators = new List<string>();

            Utilities.addCritere(champsWhere, valuesWhere, operators, "ID_TYPE_CARTE", criteres.IdTypeCarte, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "RESEAU", criteres.ReseauCarte, Connexion.LIKE);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "PLF_GLO_PAIE", criteres.PlfGloPaiement, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "PERI_PLF_PAIE", criteres.PeriodePlfPaiement, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "PERI_PLF_GLO_RET", criteres.PeriodePlfGlobalRetrait, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "PLF_GLO_RET_INT", criteres.PlfGlobalRetraitInternes, Connexion.EGAL);
            Utilities.addCritere(champsWhere, valuesWhere, operators, "PLF_RET_ETRG", criteres.PlfRetEtranger, Connexion.EGAL);
            return Connexion.get(tableName, champsWhere, valuesWhere, operators);
        }

        public static DataTable getDataTable(CritereRechercheTypeCarte criteres)
        {
            IDataReader reader = get(criteres);
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            return dt;
        }

    }
}

