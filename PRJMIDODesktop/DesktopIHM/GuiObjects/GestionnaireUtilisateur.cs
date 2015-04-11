using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Collections;

namespace DesktopIHM.GuiObjects
{
    public class GestionnaireUtilisateur
    {
        private const string file = "XMLFile/Utilisateurs.xml";

        public static bool UtilisateurExtiste(string login, string password)
        {
            bool trouver = false;
            
            IList<Utilisateur> liste = new List<Utilisateur>();

            //Chargement du fichier clients.xml
            XDocument fic = XDocument.Load(file);

            //Sélection d'un utilisateur
            var util = from i in fic.Elements("users").Elements("user")
                       where (string)i.Element("login") == login
                          && (string)i.Element("password") == password
                       select new Utilisateur
                       (
                          (string)i.Element("login"),
                          (string)i.Element("password"),
                          (string)i.Element("email"),
                          (string)i.Element("profil")
                      );

            IEnumerator enumuser = util.GetEnumerator();

            while (enumuser.MoveNext())
                liste.Add((Utilisateur)enumuser.Current);

            if (liste.Count == 1)
            {
                trouver = true;
            }

            return trouver;
        }

        public static Utilisateur DetailCompte(string login, string password)
        {
            Utilisateur unCompte = null;

            //Chargement du fichier clients.xml
            XDocument fic = XDocument.Load(file);

            //Sélection d'un utilisateur
            var util = from i in fic.Elements("users").Elements("user")
                       where (string)i.Element("login") == login
                          && (string)i.Element("password") == password
                       select new Utilisateur
                       (
                          (string)i.Element("login"),
                          (string)i.Element("password"),
                          (string)i.Element("email"),
                          (string)i.Element("profil")
                      );

            IEnumerator enumuser = util.GetEnumerator();

            while (enumuser.MoveNext())
                unCompte = (Utilisateur)enumuser.Current;

            return unCompte;
        }

        public static IList<Utilisateur> ListeUtilisateurs()
        {
            IList<Utilisateur> maListe = new List<Utilisateur>();

            //Chargement du fichier clients.xml
            XDocument fic = XDocument.Load(file);

            //Sélection d'un utilisateur
            var util = from i in fic.Elements("users").Elements("user")                     
                       select new Utilisateur
                       (
                          (string)i.Element("login"),
                          (string)i.Element("password"),
                          (string)i.Element("email"),
                          (string)i.Element("profil")
                      );

            IEnumerator enumuser = util.GetEnumerator();

            while (enumuser.MoveNext())
                maListe.Add((Utilisateur)enumuser.Current);

            return maListe;
        }

        public static void addUtilisateur(Utilisateur utilisateur){
            XDocument fic = XDocument.Load(file);
             fic.Element("users").Add(utilisateur.ToXml());
             fic.Save(file);
        }

    }
}
