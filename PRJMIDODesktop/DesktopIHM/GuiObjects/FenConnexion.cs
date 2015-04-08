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
                MessageBox.Show("Veuillez saisir votre login", "Echec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(_pwd))
            {
                MessageBox.Show("Veuillez saisir votre mot de passe", "Echec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (Session.seConnecter(_login, _pwd))
                this.Close();
            else
                MessageBox.Show("Erreur d'identification. Reessayez", "Echec de connexion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

          
    }
}
