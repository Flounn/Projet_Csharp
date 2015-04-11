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
    public partial class FenRechercheContrat : Form
    {
        private CritereRechercheContrat crtRechercheContrat = null;
        private static string[] valuesDateSouscription = new string[] { "Choisissez", "Le", "Après le", "Avant le", "Entre le" };
        
        public FenRechercheContrat()
        {
            InitializeComponent();
            cbDateSouscription.Items.AddRange(valuesDateSouscription);
            cb_type.Items.Add("Choisissez");
            cb_type.Items.AddRange(Contrat.getTypesContrat());
            cbDateSouscription.SelectedIndex = 0;
            cb_type.SelectedIndex = 0;
        }
        
        private bool initCritereRecherche()
        {
            crtRechercheContrat = new CritereRechercheContrat();
            if (!string.IsNullOrEmpty(txtIdClient.Text))
                try
                {
                    crtRechercheContrat.IdClient = long.Parse(txtIdClient.Text);
                }
                catch
                {
                    Utilities.showErrorMessage("Veuillez saisir un id client valide", "Id client non valide");
                    return false;
                }
            if (!string.IsNullOrEmpty(txtId.Text))
                try
                {
                    crtRechercheContrat.IdContrat = long.Parse(txtId.Text);
                }
                catch
                {
                    Utilities.showErrorMessage("Veuillez saisir un id contrat valide", "Id contrat non valide");
                    return false;
                }
            if (!string.IsNullOrEmpty(txtIdCompte.Text))
                try
                {
                    crtRechercheContrat.IdCompte = long.Parse(txtIdCompte.Text);
                }
                catch
                {
                    Utilities.showErrorMessage("Veuillez saisir un id compte valide", "Id compte non valide");
                    return false;
                }
            if (!string.IsNullOrEmpty(txtIdProduit.Text))
                try
                {
                    crtRechercheContrat.IdProduit = long.Parse(txtIdProduit.Text);
                }
                catch
                {
                    Utilities.showErrorMessage("Veuillez saisir un id produit valide", "Id produit non valide");
                    return false;
                }
            
            crtRechercheContrat.Intitule = txtIntitule.Text;
            if (cb_type.SelectedIndex > 0)
                crtRechercheContrat.Type = (string)cb_type.SelectedItem;
            switch (cbDateSouscription.SelectedIndex)
            {
                case 0: break;
                case 1:
                    crtRechercheContrat.DateSouscriptionDebut = dtDateSouscriptionDebut.Value;
                    crtRechercheContrat.DateSouscriptionFin = dtDateSouscriptionDebut.Value;
                    break;
                case 2:
                    crtRechercheContrat.DateSouscriptionDebut = dtDateSouscriptionDebut.Value;
                    break;
                case 3:
                    crtRechercheContrat.DateSouscriptionFin = dtDateSouscriptionFin.Value;
                    break;
                case 4:
                    crtRechercheContrat.DateSouscriptionDebut = dtDateSouscriptionDebut.Value;
                    crtRechercheContrat.DateSouscriptionFin = dtDateSouscriptionFin.Value;
                    break;
            }
            return true;
        }


        private void InitData()
        {
            DataTable dtt = new DataTable();
            dtt.Load(BSGestionClient.RechercherContrats(crtRechercheContrat));
            dgwLstContrat.DataSource = dtt;
        }

        private void btRechercher_Click(object sender, EventArgs e)
        {

            if (cbDateSouscription.SelectedIndex <1 && string.IsNullOrEmpty(txtId.Text)
                   && string.IsNullOrEmpty(txtIdClient.Text) && string.IsNullOrEmpty(txtIdCompte.Text)
                   && string.IsNullOrEmpty(txtIdProduit.Text) && string.IsNullOrEmpty(txtIntitule.Text))
            {
                Utilities.showErrorMessage("Veuillez saisir un des critères", "Erreur");
                return;
            }
           
            if (initCritereRecherche())
                InitData();
            
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

        private void btVider_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtIdClient.Text = string.Empty;
            txtIdCompte.Text = string.Empty;
            txtIdProduit.Text = string.Empty;
            txtIntitule.Text = string.Empty;
            cbDateSouscription.SelectedIndex = 0;
            cb_type.SelectedIndex = 0;
        }

    }
}
