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

        public FenDetailCompte(Compte compte)
        {
            InitializeComponent();
            monCompte = compte;
            initUi();
        }


        private void initUi()
        {
            
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

        void dgvLstComptes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer le compte?",
                    "Supprimer un compte", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
            {
                //monCompte.delete();
                MessageBox.Show("Le compte vient d'être supprimé",
                    "Supprimer un compte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
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