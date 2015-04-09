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
    public partial class fenRechercheContrat : Form
    {
        private CritereRechercheContrat crtRechercheContrat = null;

        public CritereRechercheContrat CrtRechercheContrat
        {
            get { return crtRechercheContrat; }
            set { crtRechercheContrat = value; }
        }


        private void initCritereRecherche()
        {
            if (!(cbDateSouscription.SelectedText.Equals("Choisissez")
                && txtIntitule.Text.Equals("")
                && txtIdCompte.Text.Equals("")
                && txtId.Text.Equals("")
                && txtIdClient.Text.Equals("")
                && txtIdProduit.Text.Equals("")))
            {
                crtRechercheContrat = new CritereRechercheContrat();
                crtRechercheContrat.Intitule = txtIntitule.Text;
                crtRechercheContrat.IdCompte =  long.Parse(txtIdCompte.Text);
                crtRechercheContrat.IdContrat = long.Parse(txtId.Text);
                crtRechercheContrat.IdClient =  long.Parse(txtIdClient.Text);
                crtRechercheContrat.IdProduit =  long.Parse(txtIdProduit.Text);
                if (cbDateSouscription.SelectedText.Equals("Le")
                    || cbDateSouscription.SelectedText.Equals("Entre le"))
                {
                    crtRechercheContrat.DateSouscriptionDebut = dtDateSouscriptionDebut.Value;
                    crtRechercheContrat.DateSouscriptionFin = dtDateSouscriptionFin.Value;
                }
                else if (cbDateSouscription.SelectedText.Equals("Après le"))
                {
                    crtRechercheContrat.DateSouscriptionDebut = dtDateSouscriptionDebut.Value;
                }
                else if (cbDateSouscription.SelectedText.Equals("Né avant le"))
                {
                    crtRechercheContrat.DateSouscriptionFin = dtDateSouscriptionFin.Value;
                }
            }
        }

        public fenRechercheContrat()
        {
            InitializeComponent();
            cbDateSouscription.Items.Add("Choisissez");
            cbDateSouscription.Items.Add("Le");
            cbDateSouscription.Items.Add("Après le");
            cbDateSouscription.Items.Add("Avant le");
            cbDateSouscription.Items.Add("Entre le");
        }


        private void InitData()
        {
            BindingList<Contrat> listeContrat = new BindingList<Contrat>();

            IList<Contrat> lstC = BSGestionClient.RechercherContrat(crtRechercheContrat);

            foreach (Contrat c in lstC)
                listeContrat.Add(c);

            this.dgwLstContrat.DataSource = listeContrat;
            dgwLstContrat.Refresh();
        }



        private void btDetail_Click(object sender, EventArgs e)
        {
            //new FenDetailContrat(dgwLstContrat.SelectedRows.Cast<Client>());
        }

        private void fenRechercheClient_Load(object sender, EventArgs e)
        {

        }

        private void btRechercher_Click(object sender, EventArgs e)
        {
            if (crtRechercheContrat != null)
            {
                initCritereRecherche();
                InitData();
            }
        }
    }
}
