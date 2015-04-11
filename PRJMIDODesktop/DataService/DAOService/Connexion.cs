using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;

namespace DataService.DAOService
{
    public static class Connexion
    {
        private readonly static GestionBDD singleton;

        public const string EGAL = "=";
        public const string SUP = ">";
        public const string SUPEGAL = SUP + EGAL;
        public const string INF = "<";
        public const string INFEGAL = INF+EGAL;
        public const string LIKE = " LIKE ";
        public const string IS = " IS ";

        static Connexion()
        {
            singleton = new GestionBDD();
        }

        /// <param name="table_name">nom de la table</param>
        /// <summary>
        /// Exécute une requete de selection sur la table passée en argument
        /// </summary>
        public static void ExecuteSelectQuery(string table_name)
        {
            if (!table_name.Equals(string.Empty))
                return;

            //string nom_fichier = table_name + ".xml";
            using (MySqlConnection myConn = singleton.Connection())
            {

                //Déclaration de la DataSet
                DataSet ds = new DataSet();

                //Exécution de la requête
                string stm = "SELECT * FROM " + table_name;
                MySqlDataAdapter da = new MySqlDataAdapter(stm, myConn);

                //Remplissage de la dataset avec le résultat de la 1ère requête
                da.Fill(ds, table_name);

                DataTable dt = ds.Tables[table_name];
                //dt.WriteXml(nom_fichier);

            }
        }


        public static bool insert(string table_name, string[] champs, object[] values)
        {
            if (string.IsNullOrEmpty(table_name) || champs.Length != values.Length || champs.Length == 0)
                return false;
            StringBuilder commandText = new StringBuilder("INSERT INTO " + table_name.ToUpper() + " (" + champs[0] + "");
            StringBuilder commandValues = new StringBuilder(") VALUES(@0");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Parameters.AddWithValue("@0", values[0]);
            int nbParameters = champs.Length;
            for (int i = 1; i < nbParameters; i++)
            {
                commandText.Append("," + champs[i]);
                commandValues.Append(",@" + i);
                cmd.Parameters.AddWithValue("@" + i, values[i]);
            }

            commandText.Append(commandValues + ");");
            cmd.CommandText = commandText.ToString();
            Console.WriteLine(cmd.CommandText);
            cmd.Connection = singleton.Connection();
            bool result = cmd.ExecuteNonQuery() > 0;
            cmd.Connection.Close();
            return result;
        }
        public static bool delete(string table_name, string[] champs, object[] values)
        {
            if (string.IsNullOrEmpty(table_name) || champs.Length != values.Length || champs.Length == 0)
                return false;
            StringBuilder commandText = new StringBuilder("DELETE FROM " + table_name.ToUpper() + " WHERE " + champs[0] + "=@0");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Parameters.AddWithValue("@0", values[0]);
            int nbParameters = champs.Length;
            for (int i = 1; i < nbParameters; i++)
            {
                commandText.Append(" AND " + champs[i] + "=@" + i);
                cmd.Parameters.AddWithValue("@" + i, values[i]);
            }

            commandText.Append(";");
            cmd.CommandText = commandText.ToString();
            Console.WriteLine(cmd.CommandText);
            cmd.Connection = singleton.Connection();
            bool result = cmd.ExecuteNonQuery() > 0;
            cmd.Connection.Close();
            return result;
        }

        public static bool update(string table_name, string[] champs, object[] values, string[] champsWhere, object[] valuesWhere)
        {
            if (string.IsNullOrEmpty(table_name) || champs.Length != values.Length || champs.Length == 0 || champsWhere.Length != valuesWhere.Length || champsWhere.Length == 0)
                return false;
            StringBuilder commandText = new StringBuilder("UPDATE " + table_name.ToUpper() + " SET " + champs[0] + "=@0");

            MySqlCommand cmd = new MySqlCommand();
            cmd.Parameters.AddWithValue("@0", values[0]);
            int nbParameters = champs.Length + champsWhere.Length;
            int i = 1;
            while (i < champs.Length)
            {
                commandText.Append("," + champs[i] + "=@" + i);
                cmd.Parameters.AddWithValue("@" + i, values[i]);
                i++;
            }
            commandText.Append(" WHERE " + champsWhere[0] + "=@" + i);
            cmd.Parameters.AddWithValue("@" + i, valuesWhere[0]);
            i++;
            while (i < nbParameters)
            {
                commandText.Append(" AND " + champsWhere[i - champs.Length] + "=@" + i);
                cmd.Parameters.AddWithValue("@" + i, valuesWhere[i - champs.Length]);
                i++;
            }

            commandText.Append(";");
            cmd.CommandText = commandText.ToString();
            Console.WriteLine(cmd.CommandText);
            cmd.Connection = singleton.Connection();
            bool result = cmd.ExecuteNonQuery() > 0;
            cmd.Connection.Close();
            return result;
        }

        public static IDataReader getAll(string table_name)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + table_name.ToUpper() + ";");
            Console.WriteLine(cmd.CommandText);
            cmd.Connection = singleton.Connection();
            IDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static IDataReader get(string table_name, string[] champsWhere, object[] valuesWhere)
        {
            string[] operators = new string[champsWhere.Length];
            for (int i = 0; i < operators.Length; i++)
                operators[i] = EGAL;
            return get(table_name, champsWhere, valuesWhere, operators);
        }

        public static IDataReader get(string table_name, IList<string> champsWhere, IList<object> valuesWhere)
        {
            return get(table_name, champsWhere.ToArray(), valuesWhere.ToArray());
        }

        public static IDataReader get(string table_name, IList<string> champsWhere, IList<object> valuesWhere, IList<string> operators)
        {
            return get(table_name, champsWhere.ToArray(), valuesWhere.ToArray(), operators.ToArray());
        }

        public static IDataReader get(string table_name, string[] champsWhere, object[] valuesWhere, string[] operators)
        {
            if (string.IsNullOrEmpty(table_name) || champsWhere.Length != valuesWhere.Length || champsWhere.Length == 0 || operators.Length != champsWhere.Length)
                return null;
            StringBuilder commandText = new StringBuilder("SELECT * FROM " + table_name.ToUpper() + " WHERE " + champsWhere[0] + operators[0]+ "@0");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Parameters.AddWithValue("@0", operators[0].Equals(LIKE) ? "%" + valuesWhere[0] + "%" : valuesWhere[0]);
            int nbParameters = champsWhere.Length;
            for (int i = 1; i < nbParameters; i++)
            {
                commandText.Append(" AND " + champsWhere[i] + operators[i]+ "@" + i);
                cmd.Parameters.AddWithValue("@" + i, operators[i].Equals(LIKE) ? "%" + valuesWhere[i] + "%" : valuesWhere[i]);
            }

            commandText.Append(";");
            cmd.CommandText = commandText.ToString();
            Console.WriteLine(cmd.CommandText);
            cmd.Connection = singleton.Connection();
            return cmd.ExecuteReader();
        }

    }
     
}
