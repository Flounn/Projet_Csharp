using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataService.BSDataObjects;
using DataService.BSService;
using DataService.DAOService;

namespace DesktopIHM.GuiObjects
{
    public partial class FenRechercheClient : Form, UpdateDataGridView
    {
        private CritereRechercheClient crtRechercheClient = new CritereRechercheClient();

        private static string[] valuesDateNaissance = new string[]{"Choisissez","Né le","Né après le"
            ,"Né avant le","Né entre le"};

        private bool initCritereRecherche()
        {
           
            crtRechercheClient = new CritereRechercheClient();
            crtRechercheClient.Adresse = txtAdresse.Text;
            crtRechercheClient.Email = txtEmail.Text;
            if (!string.IsNullOrEmpty(txtId.Text))
                try{
                crtRechercheClient.IdClient = long.Parse(txtId.Text);
                }
                catch {
                    Utilities.showErrorMessage("L'ID n'a pas été saisi correctement", "Erreur");
                    return false; 
                }
            crtRechercheClient.Nom = txtNom.Text;
            crtRechercheClient.Prenom = txtPrenom.Text;
            switch (cbDateNaissance.SelectedIndex){
                case 0: break;
                case 1:
                    crtRechercheClient.DateNaissanceDebut = dtDateNaissanceDebut.Value;
                    crtRechercheClient.DateNaissanceFin = dtDateNaissanceDebut.Value;
                    break;
                case 2:               
                    crtRechercheClient.DateNaissanceDebut = dtDateNaissanceDebut.Value;
                    break;
                case 3:
                    crtRechercheClient.DateNaissanceFin = dtDateNaissanceFin.Value;
                    break;
                case 4:
                    crtRechercheClient.DateNaissanceDebut = dtDateNaissanceDebut.Value;
                    crtRechercheClient.DateNaissanceFin = dtDateNaissanceFin.Value;
                    break;
            }
            return true;
            
        }

        public FenRechercheClient()
        {
            InitializeComponent();
            cbDateNaissance.Items.AddRange(valuesDateNaissance);
            cbDateNaissance.SelectedIndex = 0;
            txtId.Focus();
        }


        private void initData()
        {
            dgvLstClient.DataSource = BSGestionClient.RechercherClients(crtRechercheClient);
        }
        private void btRechercher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !Utilities.isEmailValid(txtEmail.Text))
            {
                Utilities.showErrorMessage("L'email n'a pas été saisi correctement", "Erreur");
                return;
            }
            if (cbDateNaissance.SelectedIndex==0 && string.IsNullOrEmpty(txtAdresse.Text)
                    && string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtId.Text)
                    && string.IsNullOrEmpty(txtNom.Text) && string.IsNullOrEmpty(txtPrenom.Text))
            {
                Utilities.showErrorMessage("Veuillez saisir un des critères", "Erreur");
                return;
            }

            if (initCritereRecherche())
                initData();
        }

        private void cbDateNaissance_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDateNaissance.SelectedIndex)
            {
                case 0:
                    dtDateNaissanceDebut.Enabled = false;
                    dtDateNaissanceFin.Visible = false;
                    break;
                case 4:
                    dtDateNaissanceDebut.Enabled = true;
                    dtDateNaissanceFin.Visible = true;
                    dtDateNaissanceFin.Enabled = true;
                    break;
                default:
                    dtDateNaissanceDebut.Enabled = true;
                    dtDateNaissanceFin.Visible = false;
                    break;
            }
        }

        private void btDetail_Click(object sender, EventArgs e)
        {
            new FenDetailClient(getClientRow(),this).Show();
        }

        private void dgvLstClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            new FenDetailClient(getClientRow(e.RowIndex),this).Show();
        }

        private Client getClientRow(int index)
        {
            DataGridViewRow row = dgvLstClient.Rows[index];
            Client client = new Client(long.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString()
                , DateTime.Parse(row.Cells[3].Value.ToString()), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(),
                row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString());
            return client;
        }

        private Client getClientRow()
        {
            return getClientRow(dgvLstClient.SelectedRows[0].Index);
        }

        private void btVider_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            cbDateNaissance.SelectedIndex = 0;
        }


        public void refresh()
        {
            initData();
        }
    }
}
