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
    public partial class FenMonProfil : Form
    {
        
        public FenMonProfil()
        {
            InitializeComponent();
            InitProfile();
        }

        private void InitProfile()
        {

            txt_login.Text = Session.Utilisateur.Login;
            txt_email.Text = Session.Utilisateur.Email;
            lbl_profil.Text = Session.Utilisateur.Profil;
            txt_password.Text = Session.Utilisateur.Password;
            txt_login.Focus();
        }

        private void bt_modifier_Click(object sender, EventArgs e)
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
            Session.modifierUtilisateur(txt_login.Text, txt_password.Text);
            Utilities.showInfoMessage("Votre profil a été modifié avec succès", "Mon profil");
        }

    }
}
