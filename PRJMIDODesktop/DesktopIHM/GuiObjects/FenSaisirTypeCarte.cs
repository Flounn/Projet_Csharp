using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopIHM.GuiObjects
{
    public partial class FenSaisirTypeCarte : Form
    {
        public FenSaisirTypeCarte()
        {
            InitializeComponent();
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
                MessageBox.Show("Le plafond de retrait DAB extern n'a pas été renseigné correctement",
                    "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*txtPlfGloRetraitExt;
            txtPlfGloRetraitInt;
            txtPlfGloRetraitExt;
            txtPlfGloRetraitInt;
            txtPlfRetraitEtr;
            txtPlfRetraitFr;
            txtPeriodePlfRetrait

            TypeCarte typeCarte = new Client(txtNom.Text, txtPlfGloPaiement.Text, dtDateNaissance.Value ,txtPeriodePlfPaiement.Text, txtPlfGloRetraitExt.Text, txtPlfRetraitEtr.Text, txtPlfRetraitFr.Text, txtPlfGloRetraitInt.Text);
            BSGestionClient.CreerModifierClient(client); 
            MessageBox.Show("Le client vient d'être rajouté",
                "Ajout d'une type de carte bancaire", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }
    }
}
