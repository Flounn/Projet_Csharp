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

        static Connexion(){
            singleton = new GestionBDD();
        }

        /// <param name="table_name">nom de la table</param>
        /// <summary>
        /// Exécute une requete de selection sur la table passée en argument
        /// </summary>
        /// <example>
        ///     <code>codeeeee</code>
        /// </example>
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

        private static bool insert(string query)
        {
            if (!query.Equals(string.Empty))
                return false;
            MySqlCommand comand = new MySqlCommand(query,singleton.Connection());
            return comand.ExecuteNonQuery()>0;
        }

        private static bool insert(string query, MySqlParameterCollection parameters)
        {
            if (!query.Equals(string.Empty))
                return false;
            MySqlCommand comand = new MySqlCommand(query, singleton.Connection());
            return comand.ExecuteNonQuery() > 0;
        }

        public static bool insert(string table_name, string[] champs,object[] values)
        {
            if (string.IsNullOrEmpty(table_name) || champs.Length != values.Length || champs.Length==0)
                return false;
            StringBuilder commandText = new StringBuilder("INSERT INTO " + table_name + " ('" + champs[0]+"'");
            StringBuilder commandValues = new StringBuilder(") VALUES('" + values[0]+"'");
            MySqlCommand cmd = new MySqlCommand();
            //MySqlParameterCollection parameters = new MySql.Data.MySqlClient.MySqlParameterCollection();
            int nbParameters = champs.Length;
            for(int i = 1; i<nbParameters;i++)
            {
                commandText.Append(",'"+champs[i]+"'");
                commandValues.Append(",?");
                //parameters.Add(values[i]);
            }

            commandText.Append(commandValues);
            commandText.Append(");");
            return insert(commandText.ToString());


        }

    }

     
}
