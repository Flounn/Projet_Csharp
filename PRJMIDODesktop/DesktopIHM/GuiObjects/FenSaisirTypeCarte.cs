using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataService.BSDataObjects;

namespace DesktopIHM.GuiObjects
{
    public partial class FenSaisirTypeCarte : Form
    {
        private static string[] valuesReseau = {"Visa", "MasterCard"};

        public FenSaisirTypeCarte()
        {
            InitializeComponent();
            cbReseau.Items.AddRange(valuesReseau);
            cbReseau.SelectedIndex = 1;
        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPeriodePlfPaiement.Text))
            {
                MessageBox.Show("La période du plafond de paiement n'a pas été renseignée",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPlfGloPaiement.Text))
            {
                MessageBox.Show("Le plafond global de paiement n'a pas été rensigné",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPlfPaiementEtr.Text))
            {
                MessageBox.Show("Le plafond global à l'Etranger n'a pas été renseigné",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPlfGloRetraitExt.Text))
            {
                MessageBox.Show("Le plafond de retrait global sur des distributeurs Externes n'a pas été renseigné",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPlfGloRetraitInt.Text))
            {
                MessageBox.Show("Le plafond de retrait global sur des distributeurs LCP n'a pas été renseigné",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPlfRetraitEtr.Text))
            {
                MessageBox.Show("Le plafond de retrait à l'étranger n'a pas été renseigné",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPlfRetraitFr.Text))
            {
                MessageBox.Show("Le plafond de retrait en France n'a pas été renseigné",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPeriodePlfRetrait.Text))
            {
                MessageBox.Show("La période du plafond de retrait n'a pas été renseigné",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try{
                decimal vPlfGloPaiement = decimal.Parse(txtPlfGloPaiement.Text);
            } catch {
                MessageBox.Show("Le plafond global de paiment n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                decimal vPlfPaiementEtr = decimal.Parse(txtPlfPaiementEtr.Text);
            } catch {
                MessageBox.Show("Le plafond de paiment à l'etranger n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                int vPeriodePlfPaiement = int.Parse(txtPeriodePlfPaiement.Text);
            } catch {
                MessageBox.Show("Le période du plafond de paiment n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                decimal vPlfGloRetraitExt = decimal.Parse(txtPlfGloRetraitExt.Text);
            } catch {
                MessageBox.Show("Le plafond de retrait DAB externe n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                decimal vPlfGloRetraitInt = decimal.Parse(txtPlfGloRetraitInt.Text);
            } catch {
                MessageBox.Show("Le plafond de retrait DAB interne n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                decimal vPlfRetraitEtr = decimal.Parse(txtPlfRetraitEtr.Text);
            } catch {
                MessageBox.Show("Le plafond de retrait à l'étranger n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                decimal vPlfRetraitFr = decimal.Parse(txtPlfRetraitFr.Text);
            } catch {
                MessageBox.Show("Le plafond de retrait en France n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                int vPeriodePlfRetrait = int.Parse(txtPeriodePlfRetrait.Text);
            } catch {
                MessageBox.Show("La période du plafond de retrait n'a pas été rensigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cbReseau.SelectedIndex ==0)
            {
                MessageBox.Show("Le reseau n'as pas été renseigné",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TypeCarte typeCarte = new TypeCarte(decimal vPlfGloPaiement, );
            //BSGestionClient.CreerModifierClient(client); 
            MessageBox.Show("Le type de carte vient d'être ajouté",
                "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FenSaisirTypeCarte_Load(object sender, EventArgs e)
        {
        
        }
    }
}
