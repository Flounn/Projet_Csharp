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
        }

        public FenSaisirContrat(Client client, Compte compte)
        {
            InitializeComponent();
            contrat.Compte = compte;
            contrat.Client = client;
            initUI();
            txtIdClient.Text = client.IdClient.ToString();
            txtIdCompte.Text = compte.IdCompte.ToString();
        }

        public FenSaisirContrat(Client client)
        {
            InitializeComponent();
            contrat.Client = client;
            initUI();
            txtIdClient.Text = client.IdClient.ToString();
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

            creerContrat();

            string per;
            if (rbPeriodique.Checked == true)
            {
                per = rbPeriodique.Text;
            }
            else
            {
                per = rbPonctuel.Text;
            }
            ContratEpargne ctrEpargne = new ContratEpargne(cbTypeEpargne.SelectedText, per, cbPeriodicite.SelectedText, dtVersement.Value, decimal.Parse(txtEpargneMontant.Text));
            //ctrEpargne.persist();
            //MessageBox.Show("Le contrat a été ajouté à la base", "Ajout moyen paiement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
            
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

            creerContrat();
            ContratCredit ctrCredit = new ContratCredit(contrat.IdContrat, txtObjet.Text, int.Parse(txtDuree.Text), decimal.Parse(txtTaux.Text), decimal.Parse(txtCreditMontant.Text));
            //ctrCredit.persist();
            //MessageBox.Show("Le contrat a été ajouté à la base", "Ajout Contrat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
            
        }

        private void creerContrat()
        {
            contrat.Intitule = txtIntitule.Text;
            contrat.StatutJuridiqueStr = (string)cbStatut.SelectedItem;
            contrat.Type = Contrat.TypeContrat.Epargne;
            /*contrat.persist();
            contrat.IdContrat = DAOGenerique.lastId();*/
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

    }
}
