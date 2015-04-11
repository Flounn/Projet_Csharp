using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataService.BSService;

namespace DesktopIHM.GuiObjects
{
    public partial class FenRechercheTypeCarte : Form
    {
        private static string[] valuesReseau = { "Choisissez", "Visa", "MasterCard" };

        FenSaisirMoyenPaiement fenSaisirMoyenPaiement = null;
        CritereRechercheCarteBancaire crtRechercheCarteBancaire;

        public FenRechercheTypeCarte(FenSaisirMoyenPaiement fenSaisirMoyenPaiement)
        {
            InitializeComponent();
            this.fenSaisirMoyenPaiement = fenSaisirMoyenPaiement;
            cbReseau.Items.AddRange(valuesReseau);
            cbReseau.SelectedIndex = 1;
        }

        private bool initCritereRecherche()
        {
            crtRechercheCarteBancaire = new CritereRechercheCarteBancaire();
            if (cbReseau.SelectedIndex != 0 && cbReseau.SelectedIndex != -1)
                crtRechercheCarteBancaire.ReseauCarte = cbReseau.SelectedText;
            
            if (!string.IsNullOrEmpty(txtPlfGloPaiement.Text))
                try{
                    decimal plfGloPaiement = decimal.Parse(txtPlfGloPaiement.Text);
                    crtRechercheCarteBancaire.PlfGloPaiement = plfGloPaiement;
                }catch (Exception) {
                    MessageBox.Show("Le plafond global de paiement n'a pas été saisi correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (!string.IsNullOrEmpty(txtPeriodePlfGloPaiement.Text))
                try{
                    int periodePlfGloPaiement = int.Parse(txtPeriodePlfGloPaiement.Text);
                    crtRechercheCarteBancaire.PeriodePlfPaiement = periodePlfGloPaiement;
                }catch(Exception) {
                    MessageBox.Show("La période du plafond global de paiement n'a pas été saisie correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (!string.IsNullOrEmpty(txtPlfGloRetrait.Text))
                try{
                    decimal plfGloRetrait = decimal.Parse(txtPlfGloRetrait.Text);
                    crtRechercheCarteBancaire.PlfGlobalRetraitInternes = plfGloRetrait;
                }catch(Exception) {
                    MessageBox.Show("Le plafond global de retrait n'a pas été saisi correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (!string.IsNullOrEmpty(txtPeriodePlfGloRetrait.Text))
                try{
                    int periodePlfGloRetrait = int.Parse(txtPeriodePlfGloRetrait.Text);
                    crtRechercheCarteBancaire.PeriodePlfGlobalRetrait = periodePlfGloRetrait;
                }catch(Exception) {
                    MessageBox.Show("La période du plafond global de retrait n'a pas été saisie correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (!string.IsNullOrEmpty(txtId.Text))
                try{
                    long id = long.Parse(txtId.Text);
                    crtRechercheCarteBancaire.IdTypeCarte = id;
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
            DataTable dTypeCarte = new DataTable();
            //dTypeCarte.Load(BSGestionClient..get(crtRechercheCarteBancaire));
            dgvLstTypeCarte.DataSource = dTypeCarte;
            
        }

        void dgvLstTypeCarte_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fenSaisirMoyenPaiement.setTxtMoyenPaiement(dgvLstTypeCarte.Rows[e.RowIndex].Cells[0].Value.ToString());
        }


        

    }
}
