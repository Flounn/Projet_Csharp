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
                //TODO champ textes a remplir
            }
            else if (contrat.Type == Contrat.TypeContrat.Epargne)
            {
                gb_credit.Visible = true;
                gb_epargne.Visible = false;
                contratEpargne = BSGestionClient.getContratEpargne(contrat.IdContrat);
                txtEpargneMontant.Text = contratEpargne.MontantEpargne.ToString();
                //TODO champ textes a remplir
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
                //TODO champs a recup
                BSGestionClient.CreerModifierContratEpargne(contratEpargne);
            }
            else if (contratCredit != null)
            {
                //TODO champs a recup
                BSGestionClient.CreerModifierContratCredit(contratCredit);
            }
        }
    }
}
