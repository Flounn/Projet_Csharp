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

    public partial class FenSaisirCompte : Form
    {
        private Compte compte = new Compte();
        private FenDetailClient detailsClient;

        public FenSaisirCompte(Client client, FenDetailClient detailsClient)
        {
            InitializeComponent();
            compte.Client = client;
            txt_client.Text = client.IdClient.ToString();
            this.detailsClient = detailsClient;
        }

        public FenSaisirCompte()
        {
            InitializeComponent();
            compte.Client = new Client();
        }

        private void bt_creer_Click(object sender, EventArgs e)
        {
            try
            {
                compte.MontantInitial = decimal.Parse(txt_montant_initial.Text);
            }
            catch {
                Utilities.showErrorMessage("Veuillez saisir un montant initial valide", "Erreur");
                return; 
            }
            try
            {
                compte.Client.IdClient = int.Parse(txt_client.Text);
            }
            catch
            {
                Utilities.showErrorMessage("Veuillez saisir un id client valide", "Erreur");
                return;
            }
            compte.TypeCompte = rb_courant.Checked ? Compte.Type.Courant : Compte.Type.Epargne;
            if (BSGestionClient.CreerModifierCompte(compte))
            {
                Utilities.showInfoMessage("Le compte vient d'être ajouté", "Compte ajouté");
                if (detailsClient != null)
                {
                    detailsClient.initComptes();
                    Close();
                    return;
                }
                this.vider();
            }
            else
                Utilities.showErrorMessage("Veuillez saisir un id client valide", "Erreur");

        }

        private void vider()
        {
            txt_montant_initial.Text = txt_client.Text = string.Empty;
            rb_courant.Checked = true;
        }

        private void bt_vider_Click(object sender, EventArgs e)
        {
            vider();
        }

    }
}
