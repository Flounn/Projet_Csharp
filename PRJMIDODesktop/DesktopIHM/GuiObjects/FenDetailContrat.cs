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
    public partial class FenDetailContrat : Form
    {
        private Contrat contrat;
        private ContratCredit contratCredit;
        private ContratEpargne contratEpargne;

        public FenDetailContrat(Contrat contrat)
        {
            InitializeComponent();
            this.contrat = contrat;
            initData();
        }

        private void initData()
        {
            txt_intitule.Text = contrat.Intitule;
            cbStatut.Items.AddRange(Contrat.getStatutJuridique());
            cbStatut.SelectedItem = contrat.StatutJuridiqueStr;
            lbl_idClient.Text = contrat.Client.IdClient.ToString();
            lbl_idContrat.Text = contrat.IdContrat.ToString();
            lbl_idCompte.Text = contrat.Compte.IdCompte.ToString();
            lbl_dateSouscription.Text = contrat.DateSouscription.ToShortDateString();

            if (contrat.Type == Contrat.TypeContrat.Credit)
            {
                gb_credit.Visible = true;
                gb_epargne.Visible = false;
                contratCredit = BSGestionClient.getContratCredit(contrat.IdContrat);
                txtCreditMontant.Text = contratCredit.MontantCredit.ToString();
                txtObjet.Text = contratCredit.ObjectifCredit;
                txtTaux.Text = contratCredit.Taux.ToString();
                txtDuree.Text = contratCredit.Duree.ToString();
                txtCreditMontant.Text = contratCredit.MontantCredit.ToString();
            }
            else if (contrat.Type == Contrat.TypeContrat.Epargne)
            {
                gb_credit.Visible = true;
                gb_epargne.Visible = false;
                contratEpargne = BSGestionClient.getContratEpargne(contrat.IdContrat);
                txtEpargneMontant.Text = contratEpargne.MontantEpargne.ToString();
                dtVersement.Value = contratEpargne.DateVersement;
                cbTypeEpargne.Text = contratEpargne.TypeEpargne;
                if (contratEpargne.Periodicite.Equals("Mensuel"))
                {
                    cbPeriodicite.SelectedIndex = 1;
                }
                else cbPeriodicite.SelectedIndex = 0;
                if (contratEpargne.TypeVersement.Equals("Ponctuel"))
                {
                    rbPonctuel.Checked = true;
                }
                else rbPeriodique.Checked = true;
                    
            }
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            if (contratCredit != null)
            {
                if (BSGestionClient.supprimerContratCredit(contratCredit)){
                    Utilities.showInfoMessage("Contrat de crédit supprimé avec succès","Contrat de crédit spprimé");
                    Close();
                }
                else
                    Utilities.showErrorMessage("Erreur lors de la suppression du contrat de crédit","Erreur");
            }
            else if (contratEpargne != null)
            {
                if (BSGestionClient.supprimerContratEpargne(contratEpargne))
                {
                    Utilities.showInfoMessage("Contrat d'épargne supprimé avec succès","Contrat d'épargne spprimé");
                    Close();
                }
                else
                    Utilities.showErrorMessage("Erreur lors de la suppression du contrat d'épargne","Erreur");
            }

        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            
            if (contratEpargne != null)
            {
                if (!string.IsNullOrEmpty(txtEpargneMontant.Text) && cbPeriodicite.SelectedIndex != -1
                    && cbTypeEpargne.SelectedIndex != -1)
                {
                    MessageBox.Show("Tous les champs doivent être renseignés", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    contratEpargne.MontantEpargne = decimal.Parse(txtEpargneMontant.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Le montant n'a pas été renseigné correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                contratEpargne.Periodicite = cbPeriodicite.SelectedText;
                contratEpargne.DateVersement = dtVersement.Value;
                contratEpargne.TypeEpargne = cbTypeEpargne.SelectedText;
                if(rbPeriodique.Checked)                
                    contratEpargne.TypeVersement = "Peridodique";
                if (rbPonctuel.Checked)
                    contratEpargne.TypeVersement = "Ponctuel";
                BSGestionClient.CreerModifierContratEpargne(contratEpargne);
            }
            else if (contratCredit != null)
            {
                if (!string.IsNullOrEmpty(txtObjet.Text) && !string.IsNullOrEmpty(txtDuree.Text)
                    && !string.IsNullOrEmpty(txtTaux.Text) && !string.IsNullOrEmpty(txtCreditMontant.Text))
                {
                    MessageBox.Show("Tous les champs doivent être renseignés", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    contratCredit.Duree = int.Parse(txtDuree.Text);
                    contratCredit.Taux = decimal.Parse(txtTaux.Text);
                    contratCredit.MontantCredit = decimal.Parse(txtCreditMontant.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Le champs n'ont pas été renseignés correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                contratCredit.ObjectifCredit = txtObjet.Text;
                BSGestionClient.CreerModifierContratCredit(contratCredit);
            }
        }
    }
}
