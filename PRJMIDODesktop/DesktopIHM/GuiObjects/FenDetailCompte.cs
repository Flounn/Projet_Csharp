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
    public partial class FenDetailCompte : Form
    {
        private Compte monCompte;
        private Client monClient;

        public FenDetailCompte(Compte compte)
        {
            InitializeComponent();
            monCompte = compte;
            monClient = (Client) DAOClient.get(monCompte.Client.IdClient);
            initData();
        }


        private void initData()
        {
            if (monCompte != null)
            {
                this.txtId.Text = monCompte.IdCompte.ToString();
                this.txtIdClient.Text = monClient.IdClient.ToString();
                this.txtNomClient.Text = monClient.Nom;
                this.txtPrenomClient.Text = monClient.Prenom;
                this.dtDateOuverture.Value = monCompte.DateOuverture;
                this.txtMontantInitial.Text = monCompte.MontantInitial.ToString();
                this.txtTypeCompte.Text = monCompte.TypeCompte.ToString();

                CritereRechercheMoyenPaiement crtRechercheMoyenPaiement = new CritereRechercheMoyenPaiement();
                crtRechercheMoyenPaiement.IdCompte = monCompte.IdCompte;
                DataTable dtMoyenPaiement = new DataTable();
                //dtMoyenPaiement.Load(DAOMoyenPaiement.get(crtRechercheMoyenPaiement));
                dgvLstMoyenPaiements.DataSource = dtMoyenPaiement;
            }
        }

        void dgvLstComptes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CritereRechercheClient crtRechercheOperation = new CritereRechercheClient();
            crtRechercheOperation.IdClient = monClient.IdClient;
            DataTable dtCompte = new DataTable();
            dtCompte.Load(DAOClient.get(crtRechercheOperation));
            dgvLstMoyenPaiements.DataSource = dtCompte;
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
    }
}