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
    public partial class FenRechercheOperation : Form
    {
        private CritereRechercheOperation crtRechercheOperation = new CritereRechercheOperation();

        private static string[] valuesDate = new string[] { "Choisissez", "Le", "Après le", "Avant le", "Entre le" };
        private static string[] valuesStatut = new string[]{"Choisissez","En Cours","Réalisé"};
        private static string[] valuesType = new string[]{"Choisissez","Débit","Crédit"};

        private bool initCritereRecherche()
        {

            crtRechercheOperation = new CritereRechercheOperation();
            crtRechercheOperation.Libelle = txtLibelle.Text;
            if (!string.IsNullOrEmpty(txtId.Text))
                try
                {
                    crtRechercheOperation.IdOperation = long.Parse(txtId.Text);
                }
                catch
                {
                    Utilities.showErrorMessage("L'ID de l'operation n'a pas été saisi correctement", "Erreur");
                    return false;
                }

            if (!string.IsNullOrEmpty(txtIdCompte.Text))
                try
                {
                    crtRechercheOperation.IdCompte = long.Parse(txtIdCompte.Text);
                }
                catch
                {
                    Utilities.showErrorMessage("L'ID du compte n'a pas été saisi correctement", "Erreur");
                    return false;
                }
            if (!string.IsNullOrEmpty(txtIdMoyenPaiement.Text))
                try
                {
                    crtRechercheOperation.IdMoyenPaiement = long.Parse(txtIdMoyenPaiement.Text);
                }
                catch
                {
                    Utilities.showErrorMessage("L'ID du compte n'a pas été saisi correctement", "Erreur");
                    return false;
                }


            if(cbStatut.SelectedIndex == 1) 
                crtRechercheOperation.Statut = "EnCours";
            if(cbStatut.SelectedIndex == 2) 
                crtRechercheOperation.Statut = "Realise";

            switch (cbDate.SelectedIndex)
            {
                case 0: break;
                case 1:
                    crtRechercheOperation.DateOperationDebut = dtDateDebut.Value;
                    crtRechercheOperation.DateOperationFin = dtDateDebut.Value;
                    break;
                case 2:
                    crtRechercheOperation.DateOperationDebut = dtDateDebut.Value;
                    break;
                case 3:
                    crtRechercheOperation.DateOperationFin = dtDateFin.Value;
                    break;
                case 4:
                    crtRechercheOperation.DateOperationDebut = dtDateDebut.Value;
                    crtRechercheOperation.DateOperationFin = dtDateFin.Value;
                    break;
            }
            return true;

        }

        public FenRechercheOperation()
        {
            InitializeComponent();
            cbDate.Items.AddRange(valuesDate);
            cbDate.SelectedIndex = 0;
            dtDateDebut.MaxDate = DateTime.Today;
            dtDateFin.MaxDate = DateTime.Today;
            txtId.Focus();
        }


        private void initData()
        {
            dgvLstClient.DataSource = BSGestionClient.RechercherOperations(crtRechercheOperation);
        }

        private void btRechercher_Click(object sender, EventArgs e)
        {
            if (cbDate.SelectedIndex == 0 && string.IsNullOrEmpty(txtLibelle.Text)
                    && string.IsNullOrEmpty(txtId.Text) && string.IsNullOrEmpty(txtIdCompte.Text)
                    && string.IsNullOrEmpty(txtIdMoyenPaiement.Text) && cbStatut.SelectedIndex ==0)
            {
                Utilities.showErrorMessage("Veuillez saisir un des critères", "Erreur");
                return;
            }

            if (initCritereRecherche())
                initData();
        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDate.SelectedIndex)
            {
                case 0:
                    dtDateDebut.Enabled = false;
                    dtDateFin.Enabled = false;
                    break;
                case 4:
                    dtDateDebut.Enabled = true;
                    dtDateFin.Enabled = true;
                    break;
                default:
                    dtDateDebut.Enabled = true;
                    dtDateFin.Enabled = false;
                    break;
            }
        }

        private void btVider_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtIdCompte.Text = string.Empty;
            txtIdMoyenPaiement.Text = string.Empty;
            txtLibelle.Text = string.Empty;
            cbStatut.SelectedIndex = 0;
            cbDate.SelectedIndex = 0;
            txtId.Focus();
        }

    }
}
