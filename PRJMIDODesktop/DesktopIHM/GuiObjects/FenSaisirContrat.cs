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
    public partial class FenSaisirContrat : Form
    {
        
        private Contrat contrat = new Contrat();
        private ContratCredit contratCredit;
        private ContratEpargne contratEpargne;

        public FenSaisirContrat()
        {
            InitializeComponent();
            initUI();
            txtIdClient.Focus();
        }

        public FenSaisirContrat(Client client, Compte compte)
        {
            InitializeComponent();
            contrat.Compte = compte;
            contrat.Client = client;
            initUI();
            txtIdClient.Text = client.IdClient.ToString();
            txtIdCompte.Text = compte.IdCompte.ToString();
            txtIntitule.Focus();
        }

        private FenDetailClient detailsClient;
        public FenSaisirContrat(Client client,FenDetailClient detailsClient)
        {
            InitializeComponent();
            contrat.Client = client;
            this.detailsClient = detailsClient;
            initUI();
            txtIdClient.Text = client.IdClient.ToString();
            txtIdCompte.Focus();
        }

        private void initUI()
        {
            cbStatut.Items.Add("Choisissez");
            cbTypeEpargne.Items.Add("Choisissez");
            cbPeriodicite.Items.Add("Choisissez");
            cbStatut.Items.AddRange(Contrat.getStatutJuridique());
            cbStatut.SelectedIndex = 0;
            cbTypeEpargne.Items.AddRange(ContratEpargne.ValuesTypeEpargne);
            cbTypeEpargne.SelectedIndex = 0;
            cbPeriodicite.Items.AddRange(ContratCredit.ValuesPeriodicite);
            cbPeriodicite.SelectedIndex = 0;
            dtVersement.MinDate = DateTime.Today;
            rbTypeContrat_Checked(rbCredit, null);
        }

        private void bt_creer_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtIntitule.Text))
            {
                Utilities.showErrorMessage("Veuillez renseigner l'intitulé du contrat", "Erreur");
                return;
            }

            if (cbStatut.SelectedIndex < 1)
            {
                Utilities.showErrorMessage("Veuillez renseigner le statut du souscripteur", "Erreur");
                return;
            }

            contrat.Client = new Client();
            try
            {
                contrat.Client.IdClient = int.Parse(txtIdClient.Text);
            }
            catch (Exception)
            {
                Utilities.showErrorMessage("L'ID Client n'a pas été saisies correctement", "Erreur");
                return;
            }

            contrat.Compte = new Compte();
            try{
                contrat.Compte.IdCompte = int.Parse(txtIdCompte.Text);
            } catch (Exception) {
                Utilities.showErrorMessage("L'ID Compte n'a pas été saisie correctement", "Erreur");
                return;
            }

            if (rbCredit.Checked)
                creerContratCredit();
            else
                creerContratEpargne();

            
        }

        private void creerContratEpargne()
        {
            if (!rbEpargne.Checked)
                return;

            if (cbTypeEpargne.SelectedIndex <1){
                MessageBox.Show("Veuillez saisir le type de l'épargne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbPeriodicite.SelectedIndex<1 && rbPeriodique.Checked)
            {
                MessageBox.Show("Veuillez saisir la périodicité du virement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            contratEpargne = new ContratEpargne();
            try
            {
                contratEpargne.MontantEpargne=  decimal.Parse(txtEpargneMontant.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Le montant de versement pour le contrat d'épargne n'a pas été saisi correctement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            contratEpargne.TypeVersement = rbPeriodique.Checked?rbPeriodique.Text:rbPonctuel.Text;
            contratEpargne.TypeEpargne = (string)cbTypeEpargne.SelectedItem;
            contratEpargne.Periodicite = (string)cbPeriodicite.SelectedItem;
            contratEpargne.DateVersement = dtVersement.Value;
            contratEpargne.Intitule = txtIntitule.Text;
            contratEpargne.StatutJuridiqueStr = (string)cbStatut.SelectedItem;
            contratEpargne.Compte = contrat.Compte;
            contratEpargne.Client = contrat.Client;
            contratEpargne.Type = Contrat.TypeContrat.Epargne;
            if (BSGestionClient.CreerModifierContratEpargne(contratEpargne))
            {
                MessageBox.Show("Le contrat d'épargne a été ajouté", "Contrat épargne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (detailsClient != null)
                {
                    detailsClient.initContrats();
                    Close();
                    return;
                }
                vider();
            }

            else
                Utilities.showErrorMessage("Erreur lors de l'ajout du contrat de crédit", "Erreur");
            
        }

        private void creerContratCredit()
        {
            if (rbCredit.Checked == false)
                return;

            if (string.IsNullOrEmpty(txtObjet.Text))
            {
                MessageBox.Show("Veuillez saisir l'objet du crédit", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            contratCredit = new ContratCredit();
            try
            {
                contratCredit.Duree = int.Parse(txtDuree.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("La durée du contrat de crédit n'a pas été saisie correctement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                contratCredit.Taux = decimal.Parse(txtTaux.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Le taux de contrat de crédit n'a pas été saisie correctement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                contratCredit.MontantCredit = decimal.Parse(txtCreditMontant.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Le montant du contrat de crédit n'a pas été saisie correctement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            contratCredit.Compte = contrat.Compte;
            contratCredit.Type = Contrat.TypeContrat.Credit;
            contratCredit.ObjectifCredit = txtObjet.Text;
            contratCredit.Intitule = txtIntitule.Text;
            contratCredit.StatutJuridiqueStr = (string)cbStatut.SelectedItem;
            contratCredit.Client = contrat.Client;
            if (BSGestionClient.CreerModifierContratCredit(contratCredit))
            {
                MessageBox.Show("Le contrat de crédit a été ajouté", "Contrat crédit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (detailsClient != null)
                {
                    detailsClient.initContrats();
                    Close();
                    return;
                }
                vider();
            }
            else
                Utilities.showErrorMessage("Erreur lors de l'ajout du contrat de crédit", "Erreur");
            
        }

        private void rbTypeContrat_Checked(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                gb_credit.Visible = true;
                gb_epargne.Visible = false;
            }
            else
            {
                gb_credit.Visible = false;
                gb_epargne.Visible = true;
            }
        }

        private void bt_vider_Click(object sender, EventArgs e)
        {
            vider();
        }

        private void vider()
        {
            txtIntitule.Text = string.Empty;
            cbStatut.SelectedIndex = 0;
            cbPeriodicite.SelectedIndex = 0;
            cbTypeEpargne.SelectedIndex = 0;
            txtCreditMontant.Text = string.Empty;
            txtDuree.Text = string.Empty;
            txtEpargneMontant.Text = string.Empty;
            txtObjet.Text = string.Empty;
            txtTaux.Text = string.Empty;
            rbPeriodique.Checked = true;
            txtIdClient.Focus();
        }

    }
}
