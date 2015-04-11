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
            BSGestionClient.CreerModifierClient(client); 
            MessageBox.Show("Le client vient d'être rajouté",
                "Ajout d'un client", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
