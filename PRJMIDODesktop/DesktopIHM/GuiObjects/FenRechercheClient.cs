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
    public partial class fen_recherche_client : Form
    {
        private CritereRechercheClient crtRecherche = null;

        public CritereRechercheClient CrtRecherche
        {
            get { return crtRecherche; }
            set { crtRecherche = value; }
        }

        private void initCritereRecherche()
        {
            if (!(cb_date_naissance.SelectedText.Equals("Choisissez")
                && txt_adresse.Text.Equals("")
                && txt_email.Text.Equals("")
                && txt_id.Text.Equals("")
                && txt_nom.Text.Equals("")
                && txt_prenom.Text.Equals("")))
            {
                crtRecherche = new CritereRechercheClient();
                crtRecherche.Adresse = txt_adresse.Text;
                crtRecherche.Email = txt_email.Text;
                crtRecherche.IdClient = long.Parse(txt_id.Text);
                crtRecherche.Nom = txt_nom.Text;
                crtRecherche.Prenom = txt_prenom.Text;
                if(cb_date_naissance.SelectedText.Equals("Né le")
                    || cb_date_naissance.SelectedText.Equals("Né entre le"))
                {
                    crtRecherche.DateNaissanceDebut = dt_data_naissance_debut.Value;
                    crtRecherche.DateNaissanceFin = dt_date_naissance_fin.Value;
                } else if(cb_date_naissance.SelectedText.Equals("Né après le")){
                    crtRecherche.DateNaissanceDebut = dt_data_naissance_debut.Value;
                } else if(cb_date_naissance.SelectedText.Equals("Né avant le")){
                    crtRecherche.DateNaissanceFin = dt_date_naissance_fin.Value;
                }
            }
        }

        public fen_recherche_client()
        {
            InitializeComponent();
            cb_date_naissance.Items.Add("Choisissez");
            cb_date_naissance.Items.Add("Né le");
            cb_date_naissance.Items.Add("Né après le");
            cb_date_naissance.Items.Add("Né avant le");
            cb_date_naissance.Items.Add("Né entre le");
        }


        private void InitData()
        {
            BindingList<Client> listeClient = new BindingList<Client>();

            IList<Client> lstC = BSGestionClient.RechercherClient(CrtRecherche);

            foreach (Client c in lstC)
                listeClient.Add(c);

            this.dgw_lst_client.DataSource = listeClient;
            dgw_lst_client.Refresh();
        }

        private void fen_recherche_client_Load(object sender, EventArgs e)
        {

        }

        private void bt_rechercher_Click(object sender, EventArgs e)
        {
            if (crtRecherche != null)
            {
                initCritereRecherche();
                InitData();
            }
        }
    }
}
