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
    public partial class fenRechercheClient : Form
    {
        private CritereRechercheClient crtRecherche = null;

        public CritereRechercheClient CrtRecherche
        {
            get { return crtRecherche; }
            set { crtRecherche = value; }
        }

        private void initCritereRecherche()
        {
            //if(cbDateNaissance
        }

        public fenRechercheClient()
        {
            InitializeComponent();
        }

        private void lbNom_Click(object sender, EventArgs e)
        {

        }

        private void btRechercher_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            BindingList<Client> listeClient = new BindingList<Client>();

            IList<Client> lstC = BSGestionClient.RechercherClient(CrtRecherche);

            foreach (Client c in lstC)
                listeClient.Add(c);

            this.dgwLstClient.DataSource = listeClient;
            dgwLstClient.Refresh();
        }

        private void dgwLstClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fenRechercheClient_Load(object sender, EventArgs e)
        {

        }

    }
}
