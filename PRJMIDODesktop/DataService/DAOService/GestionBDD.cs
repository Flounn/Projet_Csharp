using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using MySql.Data.MySqlClient;

namespace DataService.DAOService
{
    public class GestionBDD
    {
       
        //Attributs de la classe
        private string hostname;
        private string user;
        private string password;
        private string databasename;

        //String de la connection
        private string connexionString;

        //Constructeur par defaut
        public GestionBDD()
        {
            hostname = "mysql-etrade.alwaysdata.net";
            user = "etrade";
            password = "azerty123";
            databasename =  "etrade_csharp";
            majConnexionUrl();
        }

        //Constructeur
        public GestionBDD(string host, string user, string pwd, string database)
        {
            hostname = host;
            this.user = user;
            password = pwd;
            databasename = database;
            majConnexionUrl();
        }

        private void majConnexionUrl()
        {
            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
            connectionString.Server = Hostname;
            connectionString.UserID = User;
            connectionString.Password = Password;
            connectionString.Database = Databasename;
            this.connexionString = connectionString.ToString();
        }

        //Getter et Setter
        public string Hostname
        {
            get { return hostname; }
            set { hostname = value; majConnexionUrl(); }
        }    

        public string User
        {
            get { return user; }
            set { user = value; majConnexionUrl(); }
        }    

        public string Password
        {
            get { return password; }
            set { password = value; majConnexionUrl(); }
        }    

        public string Databasename
        {
            get { return databasename; }
            set { databasename = value; majConnexionUrl(); }
        }


        //1 - Renvoie une connexion à partir des attributs de la classe
        public MySqlConnection Connection()
        {
            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(connexionString);
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return conn;
        }

        //2 - Affiche la version courante du SGBD MySQL
        public void VersionCouranteSGBD()
        {
            using(MySqlConnection myConn = this.Connection())
            {
                Console.WriteLine("La version du SGBD MySQL est : {0}", myConn.ServerVersion);
            }
        }

        //3 - Affiche la date et l'heure courante du serveur de base de données
        public void DateCouranteSGBD()
        {
            using (MySqlConnection myConn = this.Connection())
            {
                string statement = "SELECT NOW()";
                MySqlCommand cmd = new MySqlCommand(statement, myConn);
                string dateCourante = Convert.ToString(cmd.ExecuteScalar());
                Console.WriteLine("La date et heure courante est : {0}", dateCourante);
            }
        }

        //4 - Affiche la version, la date et l'heure courante et l'utilisateur connecté
        public void InfosCompletesSGBD()
        {
            using (MySqlConnection myConn = this.Connection())
            {
                string statement = "SELECT version(), now(), user()";
                MySqlCommand cmd = new MySqlCommand(statement, myConn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr.GetString(0) + "\t"
                        + rdr.GetString(1) + "\t"
                        + rdr.GetString(2));
                }
            }
        }

        //5 - Affiche la liste des utilisateurs (les schémas) de la base de données
        public void ListeUtilisateurBDD()
        {
            using (MySqlConnection myConn = this.Connection())
            {
                string statement = "SELECT host, user FROM mysql.user";
                MySqlCommand cmd = new MySqlCommand(statement, myConn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                    Console.WriteLine(rdr.GetString(0) + "\t"+ rdr.GetString(1));                               
            }
        }
    
        //6 - Création d'un compte avec attribution des privilèges sur la base de données courante
        public void CreerUtilisateur(string user_name, string password)
        {
            using (MySqlConnection myConn = this.Connection())
            {
                //Création du compte
                StringBuilder statement = new StringBuilder("CREATE USER ");
                statement.Append(user_name);
                statement.Append(" IDENTIFIED BY '");
                statement.Append(password);
                statement.Append("'");
                MySqlCommand cmd = new MySqlCommand(statement.ToString(), myConn);
                cmd.ExecuteNonQuery();

                //Attribution de tous les privilèges sur la base de données
                statement = new StringBuilder("GRANT ALL PRIVILEGES ON ");
                statement.Append(this.Databasename);
                statement.Append(" TO ");
                statement.Append(user_name);
                statement.Append("@");
                statement.Append(this.Hostname);
                statement.Append(" IDENTIFIED BY '");
                statement.Append(password);
                statement.Append("'");
                cmd = new MySqlCommand(statement.ToString(), myConn);
                cmd.ExecuteNonQuery();
            }
        }

        //7 - Affiche la liste des tables disponibles sur la base de données courante
        public void ListeTablesBDD()
        {
            using (MySqlConnection myConn = this.Connection())
            {
                string statement = "SHOW TABLES IN "+this.Databasename;
                MySqlCommand cmd = new MySqlCommand(statement, myConn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr.GetString(0));
                }
            }
        }

        //8 - Exécute une requete d'insertion non paramétrée. La requête est passée en argument
        public int ExecuteNonParamInsertQuery(string statement)
        {
            int nbLignes = -1;

            using (MySqlConnection myConn = this.Connection())
            {
                if (!statement.Equals(string.Empty))
                {
                    MySqlCommand cmd = new MySqlCommand(statement, myConn);

                    nbLignes = cmd.ExecuteNonQuery();
                }           
            }
            return nbLignes;
        }   


    }
}
