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
    public partial class FenRechercheClient : Form
    {
        private CritereRechercheClient crtRechercheClient = null;

        public CritereRechercheClient CrtRechercheClient
        {
            get { return crtRechercheClient; }
            set { crtRechercheClient = value; }
        }

        private void initCritereRecherche()
        {
            if (!(cbDateNaissance.SelectedIndex==-1
                && txtAdresse.Text.Equals("")
                && txtEmail.Text.Equals("")
                && string.IsNullOrEmpty(txtId.Text);
                && txtNom.Text.Equals("")
                && txtPrenom.Text.Equals("")))
            {
                crtRechercheClient = new CritereRechercheClient();
                crtRechercheClient.Adresse = txtAdresse.Text;
                crtRechercheClient.Email = txtEmail.Text;
                if(Utilities.isNumber(txtId.Text))
                    crtRechercheClient.IdClient = long.Parse(txtId.Text);
                crtRechercheClient.Nom = txtNom.Text;
                crtRechercheClient.Prenom = txtPrenom.Text;
                switch (cbDateNaissance.SelectedIndex){
                    default:
                        crtRechercheClient.DateNaissanceDebut = dtDateNaissanceDebut.Value;
                        crtRechercheClient.DateNaissanceFin = dtDateNaissanceFin.Value;
                        break;
                    case 2:               
                        crtRechercheClient.DateNaissanceDebut = dtDateNaissanceDebut.Value;
                        break;
                    case 3:
                        crtRechercheClient.DateNaissanceFin = dtDateNaissanceFin.Value;
                        break;
                }
            }
        }

        public FenRechercheClient()
        {
            InitializeComponent();
            cbDateNaissance.Text = "Choisissez";
            cbDateNaissance.Items.Add("");
            cbDateNaissance.Items.Add("Né le");
            cbDateNaissance.Items.Add("Né après le");
            cbDateNaissance.Items.Add("Né avant le");
            cbDateNaissance.Items.Add("Né entre le");
        }


        private void InitData()
        {
            DataTable dtt = new DataTable();
            dtt.Load(DAOClient.getAll());
            dgvLstClient.DataSource = dtt;
            
            /*BindingList<Client> listeClient = new BindingList<Client>();

            IList<Client> lstC = BSGestionClient.RechercherClient(crtRechercheClient);

            foreach (Client c in lstC)
                listeClient.Add(c);

            this.dgwLstClient.DataSource = listeClient;*/
            dgvLstClient.Refresh();
        }

        private void btDetail_Click(object sender, EventArgs e)
        {
            //new FenDetailClient(dgwLstContrat.SelectedRows.Cast<Client>().);
        }

        private void btRechercher_Click(object sender, EventArgs e)
        {
            if (!Utilities.isEmailValid(txtEmail.Text) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("L'email n'a pas été saisi correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Utilities.isNumber(txtId.Text) && !string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("L'ID n'a pas été saisi correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            initCritereRecherche();
            if (crtRechercheClient != null)
                InitData();
        }

        private void cbDateSouscription_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dgwLstClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Client client = (Client)dgvLstClient.SelectedRows[e.RowIndex].DataBoundItem;
            //new FenDetailClient(client).Show();
        }
    }
}
