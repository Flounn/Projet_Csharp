using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopIHM.GuiObjects
{
    public class Utilisateur
    {
        private string login;
        private string password;
        private string email;
        private string profil;

        public static string[] profils = new string[] { "Administrateur", "Opératrice de saisie", "Consultation" };

        public string Email
        {
            get { return email; }
            set { email = value; }
        }        

        public string Profil
        {
            get { return profil; }
            set { profil = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Utilisateur(string _login, string _password, string _email, string _profile)
        {
            this.login = _login;
            this.password = _password;
            this.email = _email;
            this.profil = _profile;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                if (obj is Utilisateur)
                {
                    Utilisateur util = (Utilisateur)obj;
                    return (this.Login.Equals(util.Login) && this.Password.Equals(util.Password));
                }                
            }
            return false;
        }

        public override string ToString()
        {
            return "Utilisateur "+this.login+" / Password : "+this.Password;
        }
        public System.Xml.Linq.XElement ToXml()
        {
            return new System.Xml.Linq.XElement("user",
                new System.Xml.Linq.XElement("login",login),
                new System.Xml.Linq.XElement("password", password),
                new System.Xml.Linq.XElement("email", email),
                new System.Xml.Linq.XElement("profil", profil)
                );
        }
    }
}
