using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;

namespace DesktopIHM.GuiObjects
{
    public static class Session
    {
        private static Utilisateur utilisateur;

        public static Utilisateur Utilisateur
        {
            get { return utilisateur; }
        }

        public static bool estConnecter()
        {
            return utilisateur != null;
        }
        public static bool seConnecter(string login, string password)
        {
            utilisateur = GestionnaireUtilisateur.DetailCompte(login, password);
            return estConnecter();
        }

        public static void modifierUtilisateur(string login, string password)
        {
            utilisateur.Login = login;
            utilisateur.Password = password;
            GestionnaireUtilisateur.modifierUtilisateur(utilisateur);
        }
    }
}
