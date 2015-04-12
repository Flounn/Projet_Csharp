using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataService.BSService;
using DataService.BSDataObjects;

namespace DesktopIHM.GuiObjects
{
    public partial class FenRechercheTypeCarte : Form, UpdateDataGridView
    {

        private FenSaisirMoyenPaiement fenSaisirMoyenPaiement;
        private CritereRechercheTypeCarte crtRechercheTypeCarte = new CritereRechercheTypeCarte();

        public FenRechercheTypeCarte(FenSaisirMoyenPaiement fenSaisirMoyenPaiement)
        {
            InitializeComponent();
            this.fenSaisirMoyenPaiement = fenSaisirMoyenPaiement;
            cbReseau.Items.Add("Choisissez");
            cbReseau.Items.AddRange(TypeCarte.getReseauCarteBancaire());
            cbReseau.SelectedIndex = 0;
            initData();
            txtId.Focus();
        }

        private bool initCritereRecherche()
        {
            crtRechercheTypeCarte = new CritereRechercheTypeCarte();
            if (cbReseau.SelectedIndex >0)
                crtRechercheTypeCarte.ReseauCarte = (string)cbReseau.SelectedItem;
            
            if (!string.IsNullOrEmpty(txtPlfGloPaiement.Text))
                try{
                    decimal plfGloPaiement = decimal.Parse(txtPlfGloPaiement.Text);
                    crtRechercheTypeCarte.PlfGloPaiement = plfGloPaiement;
                }catch (Exception) {
                    MessageBox.Show("Le plafond global de paiement n'a pas été saisi correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (!string.IsNullOrEmpty(txtPeriodePlfGloPaiement.Text))
                try{
                    int periodePlfGloPaiement = int.Parse(txtPeriodePlfGloPaiement.Text);
                    crtRechercheTypeCarte.PeriodePlfPaiement = periodePlfGloPaiement;
                }catch(Exception) {
                    MessageBox.Show("La période du plafond global de paiement n'a pas été saisie correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (!string.IsNullOrEmpty(txtPlfGloRetrait.Text))
                try{
                    decimal plfGloRetrait = decimal.Parse(txtPlfGloRetrait.Text);
                    crtRechercheTypeCarte.PlfGlobalRetraitInternes = plfGloRetrait;
                }catch(Exception) {
                    MessageBox.Show("Le plafond global de retrait n'a pas été saisi correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (!string.IsNullOrEmpty(txtPeriodePlfGloRetrait.Text))
                try{
                    int periodePlfGloRetrait = int.Parse(txtPeriodePlfGloRetrait.Text);
                    crtRechercheTypeCarte.PeriodePlfGlobalRetrait = periodePlfGloRetrait;
                }catch(Exception) {
                    MessageBox.Show("La période du plafond global de retrait n'a pas été saisie correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (!string.IsNullOrEmpty(txtId.Text))
                try{
                    long id = long.Parse(txtId.Text);
                    crtRechercheTypeCarte.IdTypeCarte = id;
                }catch(Exception) {
                    MessageBox.Show("L'ID n'a pas été saisi correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            return true;
        }

        private void btRechercher_Click(object sender, EventArgs e)
        {
            if (initCritereRecherche())
                initData();            
        }

        private void initData()
        {
            dgvLstTypeCarte.DataSource = BSGestionClient.RechercherTypeCarte(crtRechercheTypeCarte);
            
        }

        void dgvLstTypeCarte_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fenSaisirMoyenPaiement.setTxtMoyenPaiement(dgvLstTypeCarte.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.Dispose();
        }

        private void btVider_Click(object sender, EventArgs e)
        {
            this.txtId.Text = string.Empty;
            this.txtPeriodePlfGloPaiement.Text = string.Empty;
            this.txtPeriodePlfGloRetrait.Text = string.Empty;
            this.txtPlfGloPaiement.Text = string.Empty;
            this.txtPlfGloRetrait.Text = string.Empty;
            this.cbReseau.SelectedIndex = 0;
            txtId.Focus();
        }

        private void btSelection_Click(object sender, EventArgs e)
        {
            fenSaisirMoyenPaiement.setTxtMoyenPaiement(dgvLstTypeCarte.SelectedRows[0].Cells[0].Value.ToString());
            this.Dispose();
        }

        private void btAjouterTypeCarte_Click(object sender, EventArgs e)
        {
            new FenSaisirTypeCarte(this).Show();
        }

        public void refresh()
        {
            initData();
        }
    }
}
