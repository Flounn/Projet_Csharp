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
        private static string[] valuesStatut = { "Choisissez", "Titulaire", "Beneficiaire" };
        private static string[] valuesTypeEpargne = { "Choisissez", "Assurance vie", "Livret A", "Livret DD", "Epargne logement", "Epargne retraite"};
        private static string[] valuesPeriodicite = { "Choisissez", "Hebdomadaire", "Mensuel" };

        private Contrat contrat = new Contrat();

        public FenSaisirContrat()
        {
            InitializeComponent();
            cbStatut.Items.AddRange(valuesStatut);
            cbStatut.SelectedIndex = 0;
            cbTypeEpargne.Items.AddRange(valuesTypeEpargne);
            cbTypeEpargne.SelectedIndex = 0;
            cbPeriodicite.Items.AddRange(valuesPeriodicite);
            cbPeriodicite.SelectedIndex = 0;
            dtVersement.MinDate = DateTime.Today;

        }

        public FenSaisirContrat(Client client, Compte compte)
        {
            InitializeComponent();
            contrat.Client = client;
            cbStatut.Items.AddRange(valuesStatut);
            cbStatut.SelectedIndex = 0;
            cbTypeEpargne.Items.AddRange(valuesTypeEpargne);
            cbTypeEpargne.SelectedIndex = 0;
            cbPeriodicite.Items.AddRange(valuesPeriodicite);
            cbPeriodicite.SelectedIndex = 0;
            contrat = new Contrat();
            dtVersement.MinDate = DateTime.Today;
            contrat.Compte = compte;
            contrat.Client = client;
        }

        public FenSaisirContrat(Client client)
        {
            InitializeComponent();
            contrat.Client = client;
            cbStatut.Items.AddRange(valuesStatut);
            cbStatut.SelectedIndex = 0;
            cbTypeEpargne.Items.AddRange(valuesTypeEpargne);
            cbTypeEpargne.SelectedIndex = 0;
            cbPeriodicite.Items.AddRange(valuesPeriodicite);
            cbPeriodicite.SelectedIndex = 0;
            contrat = new Contrat();
            dtVersement.MinDate = DateTime.Today;
            contrat.Client = client;
        }

        private void bt_creer_Click(object sender, EventArgs e)
        {
            if (cbStatut.SelectedIndex == 0 || !string.IsNullOrEmpty(txtIntitule.Text))
            {
                MessageBox.Show("Tous les champs concernant le contrat doivent être renseignés!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(contrat.Compte == null)
            {
                contrat.Compte = new Compte();
                try{
                    contrat.Compte.IdCompte = int.Parse(txtIdCompte.Text);
                } catch (Exception) {
                    MessageBox.Show("Le ID Compte n'a pas été saisies correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            if(contrat.Client == null)
            {
                contrat.Client = new Client();
                try{
                    contrat.Client.IdClient = int.Parse(txtIdClient.Text);
                } catch (Exception) {
                    MessageBox.Show("Le ID Client n'a pas été saisies correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rbCredit.Checked == true)
            {
                if (!string.IsNullOrEmpty(txtObjet.SelectedText)
                    || !string.IsNullOrEmpty(txtDuree.Text)
                    || !string.IsNullOrEmpty(txtTaux.Text)
                    || !string.IsNullOrEmpty(txtCreditMontant.Text))
                {
                    MessageBox.Show("Tous les champs concernant le contrat de crédit doivent être renseignés!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    int.Parse(txtDuree.Text);
                    decimal.Parse(txtTaux.Text);
                    decimal.Parse(txtCreditMontant.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Les données concernant le contrat crédit n'ont pas été saisies correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                

                contrat = new Contrat(txtIntitule.Text, contrat.Client, contrat.Compte, cbStatut.SelectedText, "Credit");
                contrat.persist();
                contrat.IdContrat = DAOGenerique.lastId();
                ContratCredit ctrCredit = new ContratCredit(contrat.IdContrat, txtObjet.Text, int.Parse(txtDuree.Text), decimal.Parse(txtTaux.Text), decimal.Parse(txtCreditMontant.Text));
                //ctrCredit.persist();
                //MessageBox.Show("Le contrat a été ajouté à la base", "Ajout Contrat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                return;
            }

            if (rbEpargne.Checked == true)
            {
                if (!string.IsNullOrEmpty(txtEpargneMontant.Text) || cbPeriodicite.SelectedIndex == 0
                    || cbTypeEpargne.SelectedIndex ==0 || cbPeriodicite.SelectedIndex ==0)
                {
                    MessageBox.Show("Tous les champs concernant le contrat d'épargne doivent être renseignés", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    decimal.Parse(txtEpargneMontant.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Le montant de versement pour le contrat d'épargne n'a pas été saisi correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                contrat = new Contrat(txtIntitule.Text, contrat.Client, contrat.Compte, cbStatut.SelectedText, "Epargne");
                contrat.persist();
                contrat.IdContrat = DAOGenerique.lastId();
                string per;
                if(rbPeriodique.Checked == true){
                    per = rbPeriodique.Text;
                } else {
                    per = rbPonctuel.Text;
                }
                ContratEpargne ctrEpargne = new ContratEpargne(cbTypeEpargne.SelectedText, per, cbPeriodicite.SelectedText, dtVersement.Value, decimal.Parse(txtEpargneMontant.Text));
                //ctrEpargne.persist();
                //MessageBox.Show("Le contrat a été ajouté à la base", "Ajout moyen paiement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                return;
            }
        }

    }
}
