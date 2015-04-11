using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopIHM.GuiObjects
{
    public partial class FenSaisirUtilisateur : Form
    {

        public FenSaisirUtilisateur()
        {
            InitializeComponent();
            cb_profil.DataSource = Utilisateur.profils;
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_login.Text))
            {
                Utilities.showErrorMessage("Veuillez saisir un login", "Login non valide");
                return;
            }
            if (string.IsNullOrEmpty(txt_password.Text))
            {
                Utilities.showErrorMessage("Veuillez saisir un mot de passe", "Mot de passe non valide");
                return;
            }
            if (!Utilities.isEmailValid(txt_email.Text))
            {
                Utilities.showErrorMessage("L'email saisie est non valide", "Email non valide");
                return;
            }

            GestionnaireUtilisateur.ajouterUtilisateur(new Utilisateur(txt_login.Text,txt_password.Text,txt_email.Text,(string)cb_profil.SelectedValue));
        }
    }
}
