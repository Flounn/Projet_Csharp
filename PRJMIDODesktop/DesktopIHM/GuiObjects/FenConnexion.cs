using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopIHM.GuiObjects;

namespace DesktopIHM
{
    public partial class FenConnexion : Form
    {
       
        public FenConnexion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Dispose();
            this.Close();
        }

        private void seconnecter_Click(object sender, EventArgs e)
        {
            string _login = txtLogin.Text;
            string _pwd = txtPassword.Text;

            if (String.IsNullOrEmpty(_login))
            {
                Utilities.showErrorMessage("Veuillez saisir votre login", "Echec de connexion");
                return;
            }
            if (String.IsNullOrEmpty(_pwd))
            {
                Utilities.showErrorMessage("Veuillez saisir votre mot de passe", "Echec de connexion");
                return;
            }
            
            if (Session.seConnecter(_login, _pwd))
                this.Close();
            else
                MessageBox.Show("Erreur d'identification. Reessayez", "Echec de connexion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

          
    }
}
