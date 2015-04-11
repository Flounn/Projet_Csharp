using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataService.BSDataObjects;
using DataService.DAOService;
using DataService.BSService;

namespace DesktopIHM.GuiObjects
{
    public partial class FenDetailClient : Form
    {
        private Client monClient;

        public FenDetailClient(Client client)
        {
            InitializeComponent();
            monClient = client;
            initData();
            dtDateNaissance.MaxDate = DateTime.Today;
        }


        private void initData()
        {
            if (monClient != null)
            {
                this.txtId.Text = monClient.IdClient.ToString();
                this.txtNom.Text= monClient.Nom;
                this.txtPrenom.Text = monClient.Prenom;
                this.dtDateNaissance.Value = monClient.DateNaissance;
                this.txtEmail.Text = monClient.Email;
                this.txtAdressePrinc.Text = monClient.AdressePrincipale;
                this.txtAdresseTemp.Text = monClient.AdresseTemporaire;
                this.txtTelFixe.Text = monClient.TelFixe;
                this.txtTelPort.Text = monClient.TelPortable;
                
                CritereRechercheClient crtRechercheContrat = new CritereRechercheClient();
                crtRechercheContrat.IdClient = monClient.IdClient;
                DataTable dtContrat = new DataTable();
                dtContrat.Load(DAOClient.get(crtRechercheContrat));
                dgvLstContrats.DataSource = dtContrat;

                CritereRechercheClient crtRechercheCompte = new CritereRechercheClient();
                crtRechercheCompte.IdClient = monClient.IdClient;
                DataTable dtCompte = new DataTable();
                dtCompte.Load(DAOClient.get(crtRechercheCompte));
                dgvLstComptes.DataSource = dtCompte;
            }
        }

        void dgvLstComptes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CritereRechercheClient crtRechercheOperation = new CritereRechercheClient();
            crtRechercheOperation.IdClient = monClient.IdClient;
            DataTable dtCompte = new DataTable();
            dtCompte.Load(DAOClient.get(crtRechercheOperation));
            dgvLstComptes.DataSource = dtCompte;
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            if (this.txtNom.Enabled == true)
            {
                if (string.IsNullOrEmpty(txtNom.Text))
                {
                    MessageBox.Show("Le nom du client n'a pas été renseigné",
                    "Modification des données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txtPrenom.Text))
                {
                    MessageBox.Show("Le prenom du client n'a pas été renseigné",
                    "Modification des données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Le email du client n'a pas été renseigné",
                    "Modification des données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Utilities.isEmailValid(txtEmail.Text))
                {
                    MessageBox.Show("Le email du client n'a pas été renseigné correctement",
                    "Modification des données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                monClient.Nom = this.txtNom.Text;
                monClient.Prenom = this.txtPrenom.Text;
                monClient.DateNaissance = this.dtDateNaissance.Value;
                monClient.Email = this.txtEmail.Text;
                monClient.AdressePrincipale = this.txtAdressePrinc.Text;
                monClient.AdresseTemporaire = this.txtAdresseTemp.Text;
                monClient.TelFixe = this.txtTelFixe.Text;
                monClient.TelPortable = this.txtTelPort.Text;
                if(MessageBox.Show("Etes-vous sûr de vouloir modifier les données du client?", 
                    "Modification des données", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                {
                    monClient.update();
                    this.txtNom.Enabled = false;
                    this.txtPrenom.Enabled = false;
                    this.dtDateNaissance.Enabled = false;
                    this.txtEmail.Enabled = false;
                    this.txtAdressePrinc.Enabled = false;
                    this.txtAdresseTemp.Enabled = false;
                    this.txtTelFixe.Enabled = false;
                    this.txtTelPort.Enabled = false;
                }
            }
            else
            {
                this.txtNom.Enabled = true;
                this.txtPrenom.Enabled = true;
                this.dtDateNaissance.Enabled = true;
                this.txtEmail.Enabled = true;
                this.txtAdressePrinc.Enabled = true;
                this.txtAdresseTemp.Enabled = true;
                this.txtTelFixe.Enabled = true;
                this.txtTelPort.Enabled = true;
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer le client?",
                    "Supprimer un client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
            {
                monClient.delete();
                MessageBox.Show("Le client vient d'être supprimé",
                    "Supprimer un client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private void dgvLstComptes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CritereRechercheClient crtRechercheOperation = new CritereRechercheClient();
            crtRechercheOperation.IdClient = monClient.IdClient;
            DataTable dtCompte = new DataTable();
            dtCompte.Load(DAOClient.get(crtRechercheOperation));
            dgvLstComptes.DataSource = dtCompte;
        }
    }
}