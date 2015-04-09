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
            if (!(cbDateSouscription.SelectedIndex==0
                && txtIntitule.Text.Equals("")
                && txtIdCompte.Text.Equals("")
                && txtId.Text.Equals("")
                && txtIdClient.Text.Equals("")
                && txtIdProduit.Text.Equals("")))
            {
                crtRechercheClient = new CritereRechercheClient();
                crtRechercheClient.Adresse = txtIntitule.Text;
                crtRechercheClient.Email = txtIdCompte.Text;
                crtRechercheClient.IdClient = long.Parse(txtId.Text);
                crtRechercheClient.Nom = txtIdClient.Text;
                crtRechercheClient.Prenom = txtIdProduit.Text;
                switch (cbDateSouscription.SelectedIndex){
                    default:
                        crtRechercheClient.DateNaissanceDebut = dtDateSouscriptionDebut.Value;
                        crtRechercheClient.DateNaissanceFin = dtDateSouscriptionFin.Value;
                        break;
                    case 2:               
                        crtRechercheClient.DateNaissanceDebut = dtDateSouscriptionDebut.Value;
                        break;
                    case 3:
                        crtRechercheClient.DateNaissanceFin = dtDateSouscriptionFin.Value;
                        break;
                }
            }
        }

        public FenRechercheClient()
        {
            InitializeComponent();
            cbDateSouscription.Text = "Choisissez";
            cbDateSouscription.Items.Add("");
            cbDateSouscription.Items.Add("Né le");
            cbDateSouscription.Items.Add("Né après le");
            cbDateSouscription.Items.Add("Né avant le");
            cbDateSouscription.Items.Add("Né entre le");
        }


        private void InitData()
        {
            BindingList<Client> listeClient = new BindingList<Client>();

            IList<Client> lstC = BSGestionClient.RechercherClient(crtRechercheClient);

            foreach (Client c in lstC)
                listeClient.Add(c);

            this.dgwLstContrat.DataSource = listeClient;
            dgwLstContrat.Refresh();
        }

        private void fenRechercheClient_Load(object sender, EventArgs e)
        {

        }

        private void btDetail_Click(object sender, EventArgs e)
        {
            //new FenDetailClient(dgwLstContrat.SelectedRows.Cast<Client>().);
        }

        private void btRechercher_Click(object sender, EventArgs e)
        {
            if (crtRechercheClient != null)
            {
                initCritereRecherche();
                InitData();
            }
        }

        private void cbDateSouscription_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDateSouscription.SelectedIndex)
            {
                case 0:
                    dtDateSouscriptionDebut.Enabled = false;
                    dtDateSouscriptionFin.Visible = false;
                    break;
                case 4:
                    dtDateSouscriptionDebut.Enabled = true;
                    dtDateSouscriptionFin.Visible = true;
                    dtDateSouscriptionFin.Enabled = true;
                    break;
                default:
                    dtDateSouscriptionDebut.Enabled = true;
                    dtDateSouscriptionFin.Visible = false;
                    break;
            }
        }
    }
}
