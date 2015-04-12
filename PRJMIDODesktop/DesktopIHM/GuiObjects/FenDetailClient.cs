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
        private Client client;

        public FenDetailClient(Client client)
        {
            InitializeComponent();
            this.client = client;
            initData();
            dtDateNaissance.MaxDate = DateTime.Today;
        }


        private void initData()
        {
            if (client != null)
            {
                this.txtId.Text = client.IdClient.ToString();
                this.txtNom.Text= client.Nom;
                this.txtPrenom.Text = client.Prenom;
                this.dtDateNaissance.Value = client.DateNaissance;
                this.txtEmail.Text = client.Email;
                this.txtAdressePrinc.Text = client.AdressePrincipale;
                this.txtAdresseTemp.Text = client.AdresseTemporaire;
                this.txtTelFixe.Text = client.TelFixe;
                this.txtTelPort.Text = client.TelPortable;

                CritereRechercheContrat crtRechercheContrat = new CritereRechercheContrat();
                crtRechercheContrat.IdClient = client.IdClient;
                dgvLstContrats.DataSource = BSGestionClient.RechercherContrats(crtRechercheContrat);

                CritereRechercheCompte crtRechercheCompte = new CritereRechercheCompte();
                crtRechercheCompte.IdClient = client.IdClient;
                dgvLstComptes.DataSource = BSGestionClient.RechercherComptes(crtRechercheCompte);
                
            }
        }

        void dgvLstComptes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            new FenDetailCompte(getCompteSelected(e.RowIndex)).Show(this);
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            if (this.txtNom.Enabled == true)
            {
                if (string.IsNullOrEmpty(txtNom.Text))
                {
                    Utilities.showErrorMessage("Le nom du client n'a pas été renseigné","Modification des données");
                    return;
                }
                if (string.IsNullOrEmpty(txtPrenom.Text))
                {
                    Utilities.showErrorMessage("Le prenom du client n'a pas été renseigné","Modification des données");
                    return;
                }
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    Utilities.showErrorMessage("L' email du client n'a pas été renseigné","Modification des données");
                    return;
                }
                if (!Utilities.isEmailValid(txtEmail.Text))
                {
                    Utilities.showErrorMessage("L' email du client n'a pas été renseigné correctement","Modification des données");
                    return;
                }
                client.Nom = this.txtNom.Text;
                client.Prenom = this.txtPrenom.Text;
                client.DateNaissance = this.dtDateNaissance.Value;
                client.Email = this.txtEmail.Text;
                client.AdressePrincipale = this.txtAdressePrinc.Text;
                client.AdresseTemporaire = this.txtAdresseTemp.Text;
                client.TelFixe = this.txtTelFixe.Text;
                client.TelPortable = this.txtTelPort.Text;
                if(MessageBox.Show("Etes-vous sûr de vouloir modifier les données du client?", 
                    "Modification des données", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                {
                    BSGestionClient.CreerModifierClient(client);
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
                BSGestionClient.SupprimerClient(client);
                MessageBox.Show("Le client vient d'être supprimé",
                    "Supprimer un client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        void dgvLstComptes_SelectionChanged(object sender, System.EventArgs e)
        {
            CritereRechercheOperation crtRechercheOperation = new CritereRechercheOperation();
            crtRechercheOperation.IdCompte = (int)dgvLstComptes.SelectedRows[0].Cells[0].Value;
            dgvLstOperations.DataSource = BSGestionClient.RechercherOperations(crtRechercheOperation);
        }

        private void bt_ajouter_compte_Click(object sender, EventArgs e)
        {
            new FenSaisirCompte(client/*, updateCompte*/).Show(this);
        }

        private static UpdateCompte updateCompte = new UpdateCompte();

        private class UpdateCompte : UpdateDataGridView {
            public void refresh() {
                /**/
            }
        }

        private void bt_ajouter_contrat_Click(object sender, EventArgs e)
        {
            new FenSaisirContrat(client).Show(this);
        }

        private void btImprimer_Click(object sender, EventArgs e)
        {

        }

        private Compte getCompteSelected(int index)
        {
            if (index<0)
                return null;
            return new Compte((int)dgvLstComptes.Rows[index].Cells[0].Value, (string)dgvLstComptes.Rows[index].Cells[4].Value,
                (DateTime)dgvLstComptes.Rows[index].Cells[1].Value,(decimal)dgvLstComptes.Rows[index].Cells[2].Value, this.client);
        }


    }
}