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
    public partial class FenDetailCompte : Form,UpdateDataGridView
    {
        private Compte monCompte;
        private Updates callback;

        public FenDetailCompte(Compte compte)
        {
            InitializeComponent();
            monCompte = compte;
            if (string.IsNullOrEmpty(monCompte.Client.Email))
                monCompte.Client = BSGestionClient.getClient(monCompte.Client.IdClient);
            initUi();
        }

        public FenDetailCompte(Compte compte, Updates callback)
        {
            InitializeComponent();
            monCompte = compte;
            this.callback = callback;
            if (string.IsNullOrEmpty(monCompte.Client.Email))
                monCompte.Client = BSGestionClient.getClient(monCompte.Client.IdClient);
            initUi();
        }

        private void initRoles()
        {
            if (Session.isConsultation())
            {
                btAjouterMoyenPaiement.Visible = false;
                btSupprimer.Visible = false;
            }
            if(Session.isOperateurDeSaisie())
                btSupprimer.Visible = false;
        }


        private void initUi()
        {
            initRoles();
            this.txtId.Text = monCompte.IdCompte.ToString();
            this.txtIdClient.Text = monCompte.Client.IdClient.ToString();
            this.txtNomClient.Text = monCompte.Client.Nom;
            this.txtPrenomClient.Text = monCompte.Client.Prenom;
            this.dtDateOuverture.Value = monCompte.DateOuverture;
            this.txtMontantInitial.Text = monCompte.MontantInitial.ToString();
            this.txtTypeCompte.Text = monCompte.TypeCompte.ToString();
            initMoyensPaiement();
        }

        private void initMoyensPaiement()
        {
            CritereRechercheMoyenPaiement crtRechercheMoyenPaiement = new CritereRechercheMoyenPaiement();
            crtRechercheMoyenPaiement.IdCompte = monCompte.IdCompte;
            dgvLstMoyenPaiements.DataSource = BSGestionClient.RechercherMoyensPaiement(crtRechercheMoyenPaiement);
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer le compte?",
                    "Supprimer un compte", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
            {
                if (BSGestionClient.SupprimerCompte(monCompte))
                {
                    MessageBox.Show("Le compte vient d'être supprimé",
                        "Supprimer un compte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (callback != null)
                        callback.UpdateComptes();
                    this.Close();
                }
                else
                    Utilities.showErrorMessage("Erreur lors de la suppression du compte","Erreur");
            }
        }

        private void btDetailClient_Click(object sender, EventArgs e)
        {
            new FenDetailClient(monCompte.Client).Show();
        }

        private void btAjouterMoyenPaiement_Click(object sender, EventArgs e)
        {
            new FenSaisirMoyenPaiement(monCompte,this).Show(this);
        }

        public void refresh()
        {
            initMoyensPaiement();
        }

    }
}