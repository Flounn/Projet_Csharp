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
    public partial class FenSaisirMoyenPaiement : Form
    {

        private Compte compte;
        private UpdateDataGridView callabck;

        public FenSaisirMoyenPaiement(Compte compte,UpdateDataGridView callabck)
        {
            InitializeComponent();
            txtIdCompte.Text = compte.IdCompte.ToString();
            cbNbCheques.Items.AddRange(Chequier.ValuesNbCheques);
            cbNbCheques.SelectedIndex = 0;
            rbChequier_CheckedChanged(rbChequier, null);
            this.compte = compte;
            this.callabck = callabck;
            txtNbPremierCheque.Focus();
        }

        private void btTypeCarte_Click(object sender, EventArgs e)
        {
            new FenRechercheTypeCarte(this).Show();
        }

        private void rbChequier_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChequier.Checked == true)
            {
                gbCheque.Visible = true;
                gbCarteBancaire.Visible = false;
            }
            if (rbChequier.Checked == false)
            {
                gbCheque.Visible = false;
                gbCarteBancaire.Visible = true;
            }
        }

        public void setTxtMoyenPaiement(string idMoyenPaiement)
        {
            this.txtIdTypeCarte.Text = idMoyenPaiement;
        }

        private void btAjoutMoyenPaiement_Click(object sender, EventArgs e)
        {
            if (rbChequier.Checked == true)
            {
                Chequier chequier = new Chequier();
                try
                {
                    chequier.DernierCheque = int.Parse(txtNbDernierCheque.Text);
                    chequier.Numero1Cheque = int.Parse(txtNbPremierCheque.Text);
                    chequier.NombreCheque = (int)cbNbCheques.SelectedItem;
                }
                catch (Exception)
                {
                    MessageBox.Show("Les données saisies doivent être des nombres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                chequier.LibelleMoyenPaiement = MoyenPaiement.TypeMoyenPaiement.Chequier;
                chequier.Compte = compte;
                if (BSGestionClient.creerModifierChequier(chequier))
                {
                    MessageBox.Show("Le chequier a été ajouté à la base", "Ajout moyen paiement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (callabck != null)
                        callabck.refresh();
                    this.Close();
                }
                else
                    Utilities.showErrorMessage("Erreur lors de l'ajout du chequier", "Erreur");
            }

            else if (rbCarteBancaire.Checked == true)
            {
                if (string.IsNullOrEmpty(txtNoCarte.Text))
                {
                    Utilities.showErrorMessage("Veuillez saisir le numéro de carte", "Numéro de carte");
                    return;
                }

                Carte carte = new Carte();
                TypeCarte typeCarte = new TypeCarte();
                try
                {
                     typeCarte.IdTypeCarte = int.Parse(txtIdTypeCarte.Text);
                }
                catch (Exception)
                {
                    Utilities.showErrorMessage("Le type de carte doit être correctement saisie", "Type de carte");
                    return;
                }

                carte.NumeroCarte = txtNoCarte.Text;
                carte.DateDebValidite = dtDateDebut.Value;
                carte.DateFinValidite = dtDateFin.Value;
                carte.Compte = compte;
                carte.LibelleMoyenPaiement = MoyenPaiement.TypeMoyenPaiement.Carte;
                carte.TypeCarte = typeCarte;

                if (BSGestionClient.creerModifierCarte(carte))
                {
                    MessageBox.Show("Le moyen de paiement à été ajouté à la base", "Ajout moyen paiement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (callabck != null)
                        callabck.refresh();
                    this.Close();
                }
                else
                    Utilities.showErrorMessage("Erreur lors de la création de la carte", "Erreur");

            }
        }

    }
}
