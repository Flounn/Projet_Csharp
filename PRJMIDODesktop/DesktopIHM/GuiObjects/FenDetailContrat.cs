﻿using System;
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
        private UpdateDataGridView callback;
        private Updates callback2;

        public FenDetailContrat(Contrat contrat,UpdateDataGridView callback)
        {
            InitializeComponent();
            this.contrat = contrat;
            this.callback = callback;
            initData();
        }

        public FenDetailContrat(Contrat contrat, Updates callback)
        {
            InitializeComponent();
            this.contrat = contrat;
            this.callback2 = callback;
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
            cbPeriodicite.Items.AddRange(ContratEpargne.ValuesPeriodicite);
            if (contrat.Type == Contrat.TypeContrat.Credit)
            {
                gb_credit.Visible = true;
                gb_epargne.Visible = false;
                contratCredit = BSGestionClient.getContratCredit(contrat.IdContrat);
                contratCredit.Client = contrat.Client;
                contratCredit.Compte = contrat.Compte;
                txtCreditMontant.Text = contratCredit.MontantCredit.ToString();
                txtObjet.Text = contratCredit.ObjectifCredit;
                txtTaux.Text = contratCredit.Taux.ToString();
                txtDuree.Text = contratCredit.Duree.ToString();
                txtCreditMontant.Text = contratCredit.MontantCredit.ToString();
            }
            else if (contrat.Type == Contrat.TypeContrat.Epargne)
            {
                gb_credit.Visible = false;
                gb_epargne.Visible = true;
                contratEpargne = BSGestionClient.getContratEpargne(contrat.IdContrat);
                contratEpargne.Client = contrat.Client;
                contratEpargne.Compte = contrat.Compte;
                txtEpargneMontant.Text = contratEpargne.MontantEpargne.ToString();
                dtVersement.Value = contratEpargne.DateVersement;
                cbTypeEpargne.Text = contratEpargne.TypeEpargne;
                txtEpargneMontant.Text = contratEpargne.MontantEpargne.ToString();
                cbPeriodicite.SelectedItem = contratEpargne.Periodicite;
                cbTypeEpargne.Items.AddRange(ContratEpargne.ValuesTypeEpargne);
                cbTypeEpargne.SelectedItem = contratEpargne.TypeEpargne;
                if (contratEpargne.TypeVersement.Equals("Ponctuel"))
                    rbPonctuel.Checked = true;
                else rbPeriodique.Checked = true;
                    
            }
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            if (contratCredit != null)
            {
                if (BSGestionClient.supprimerContratCredit(contratCredit)){
                    Utilities.showInfoMessage("Contrat de crédit supprimé avec succès","Contrat de crédit spprimé");
                    if (callback != null)
                        callback.refresh();
                    if (callback2 != null)
                        callback2.UpdateContrats();
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
                    if (callback != null)
                        callback.refresh();
                    if (callback2 != null)
                        callback2.UpdateContrats();
                    Close();
                }
                else
                    Utilities.showErrorMessage("Erreur lors de la suppression du contrat d'épargne","Erreur");
            }

        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_intitule.Text))
            {
                Utilities.showErrorMessage("Veuillez saisir un intitulé", "Intitulé non valide");
                return;
            }
            
            if (contratEpargne != null)
            {
                contratEpargne.Intitule = txt_intitule.Text;
                contratEpargne.StatutJuridiqueStr = (string)cbStatut.SelectedItem;
                try
                {
                    contratEpargne.MontantEpargne = decimal.Parse(txtEpargneMontant.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Le montant n'a pas été renseigné correctement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                contratEpargne.Periodicite = (string)cbPeriodicite.SelectedItem;
                contratEpargne.DateVersement = dtVersement.Value;
                contratEpargne.TypeEpargne = (string)cbTypeEpargne.SelectedItem;
                if(rbPeriodique.Checked)                
                    contratEpargne.TypeVersement = "Peridodique";
                if (rbPonctuel.Checked)
                    contratEpargne.TypeVersement = "Ponctuel";

                if (BSGestionClient.CreerModifierContratEpargne(contratEpargne))
                {
                    Utilities.showInfoMessage("Contrat modifié avec succès", "Contrat modifié");
                    if (callback != null)
                        callback.refresh();
                    if (callback2 != null)
                        callback2.UpdateContrats();
                }
                else
                    Utilities.showErrorMessage("Erreur lors de la modification du contrat", "Erreur");
            }
            else if (contratCredit != null)
            {
                contratCredit.Intitule = txt_intitule.Text;
                contratCredit.StatutJuridiqueStr = (string)cbStatut.SelectedItem;
                if (string.IsNullOrEmpty(txtObjet.Text))
                {
                    MessageBox.Show("L'ojet du crédit doit être renseigné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Le champs n'ont pas été renseignés correctement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                contratCredit.ObjectifCredit = txtObjet.Text;
                if (BSGestionClient.CreerModifierContratCredit(contratCredit))
                {
                    Utilities.showInfoMessage("Contrat modifié avec succès", "Contrat modifié");
                    if (callback != null)
                        callback.refresh();
                    if (callback2 != null)
                        callback2.UpdateContrats();
                }
                else
                    Utilities.showErrorMessage("Erreur lors de la modification du contrat", "Erreur");
            }
        }
    }
}
