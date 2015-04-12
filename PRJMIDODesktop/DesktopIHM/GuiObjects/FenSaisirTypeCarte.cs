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
    public partial class FenSaisirTypeCarte : Form
    {
        
        private UpdateDataGridView callback;

        public FenSaisirTypeCarte(UpdateDataGridView callback)
        {
            InitializeComponent();
            this.callback = callback;
            initUi();
        }

        public FenSaisirTypeCarte()
        {
            InitializeComponent();
            initUi();
        }

        private void initUi(){
            cbReseau.Items.AddRange(TypeCarte.getReseauCarteBancaire());
            cbReseau.SelectedIndex = 0;
        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            TypeCarte typeCarte = new TypeCarte();           
            try{
                typeCarte.PlfGloPaiement = decimal.Parse(txtPlfGloPaiement.Text);
            } catch {
                MessageBox.Show("Le plafond global de paiment n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                typeCarte.PlfGloPaiementEtranger = decimal.Parse(txtPlfPaiementEtr.Text);
            } catch {
                MessageBox.Show("Le plafond de paiment à l'etranger n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                typeCarte.PeriodePlfPaiement = int.Parse(txtPeriodePlfPaiement.Text);
            } catch {
                MessageBox.Show("Le période du plafond de paiment n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                typeCarte.PlfGlobalRetraitExterne = decimal.Parse(txtPlfGloRetraitExt.Text);
            } catch {
                MessageBox.Show("Le plafond de retrait DAB externe n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                typeCarte.PlfGlobalRetraitInternes = decimal.Parse(txtPlfGloRetraitInt.Text);
            } catch {
                MessageBox.Show("Le plafond de retrait DAB interne n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                typeCarte.PlfRetEtranger = decimal.Parse(txtPlfRetraitEtr.Text);
            } catch {
                MessageBox.Show("Le plafond de retrait à l'étranger n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                typeCarte.PlfRetraitFrance = decimal.Parse(txtPlfRetraitFr.Text);
            } catch {
                MessageBox.Show("Le plafond de retrait en France n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                typeCarte.PeriodePlfGlobalRetrait = int.Parse(txtPeriodePlfRetrait.Text);
            } catch {
                MessageBox.Show("La période du plafond de retrait n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            typeCarte.ReseauCarteStr = cbReseau.SelectedText;
            if (BSGestionClient.InsertTypeCarte(typeCarte))
            {
                MessageBox.Show("Le type de carte vient d'être ajouté",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(callback!=null)
                    callback.refresh();
                this.Close();
            }
            else
                Utilities.showErrorMessage("Erreur lors de l'insertion du type de carte", "Erreur");
            
        }
    }
}
