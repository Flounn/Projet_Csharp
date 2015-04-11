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
    public partial class FenDetailUtilisateur : Form
    {
        private Utilisateur utilisateur;
        private readonly UpdateDataGridView callback;

        public FenDetailUtilisateur(Utilisateur utilisateur, UpdateDataGridView callback)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
            this.callback = callback;
            txt_email.Text = utilisateur.Email;
            txt_login.Text = utilisateur.Login;
            txt_password.Text = utilisateur.Password;
            cb_profil.DataSource = Utilisateur.profils;
            cb_profil.SelectedItem = utilisateur.Profil;
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            utilisateur.Email = txt_email.Text;
            utilisateur.Login = txt_login.Text;
            utilisateur.Password = txt_password.Text;
            utilisateur.Profil = (string)cb_profil.SelectedItem;
            GestionnaireUtilisateur.modifierUtilisateur(utilisateur);
            callback.refresh();
            this.Close();
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            GestionnaireUtilisateur.supprimerUtilisateur(utilisateur);
            utilisateur = null;
            callback.refresh();
            this.Close();
        }

      
    }
}
