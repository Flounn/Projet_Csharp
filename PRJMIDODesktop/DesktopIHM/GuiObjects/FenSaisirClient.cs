using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataService.DAOService;
using DataService.BSDataObjects;
using System.Globalization;
using DataService.BSService;

namespace DesktopIHM.GuiObjects
{
    public partial class FenSaisirClient : Form
    {
        public FenSaisirClient()
        {
            InitializeComponent();
            dtDateNaissance.Value = DateTime.Today;
            txtNom.Focus();
        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show("Le nom du client n'a pas été renseigné",
                    "Ajout d'un client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPrenom.Text))
            {
                MessageBox.Show("Le prenom du client n'a pas été renseigné",
                    "Ajout d'un client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Le email du client n'a pas été renseigné",
                    "Ajout d'un client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Utilities.isEmailValid(txtEmail.Text))
            {
                MessageBox.Show("Le email du client n'a pas été renseigné correctement",
                    "Ajout d'un client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client client = new Client(txtNom.Text, txtPrenom.Text, dtDateNaissance.Value ,txtEmail.Text, txtAdressePrinc.Text, txtAdresseTemp.Text, txtTelFixe.Text, txtTelPort.Text);
            if (BSGestionClient.CreerModifierClient(client))
                Utilities.showInfoMessage("Le client vient d'être rajouté", "Ajout d'un client");
            else
                Utilities.showErrorMessage("Erreur lors de l'ajout du client","Erreur");
        }

        private void bt_vider_Click(object sender, EventArgs e)
        {
            dtDateNaissance.Value = DateTime.Today;
            txtAdressePrinc.Text = string.Empty;
            txtAdresseTemp.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtTelFixe.Text = string.Empty;
            txtTelPort.Text = string.Empty;
            txtNom.Focus();
        }

    }
}
