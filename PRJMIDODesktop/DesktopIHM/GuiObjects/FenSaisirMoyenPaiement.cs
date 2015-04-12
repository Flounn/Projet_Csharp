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

namespace DesktopIHM.GuiObjects
{
    public partial class FenSaisirMoyenPaiement : Form
    {

        private static string[] valuesNbCheques = new string[] { "20", "50", "100" };
        private Compte compte;
        private UpdateDataGridView callabck;

        public FenSaisirMoyenPaiement(Compte compte,UpdateDataGridView callabck)
        {
            InitializeComponent();
            txtIdCompte.Text = compte.IdCompte.ToString();
            cbNbCheques.Items.AddRange(valuesNbCheques);
            cbNbCheques.SelectedIndex = 0;
            this.compte = compte;
            this.callabck = callabck;
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
                if (!string.IsNullOrEmpty(cbNbCheques.SelectedText) 
                    || !string.IsNullOrEmpty(txtNbPremierCheque.Text) 
                    || !string.IsNullOrEmpty(txtNbDernierCheque.Text))
                {
                    MessageBox.Show("Tous les champs concernant le chequier doivent être remplis", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    int.Parse(txtNbDernierCheque.Text);
                    int.Parse(txtNbPremierCheque.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Les données saisies doivent être des nombres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MoyenPaiement moyenPaiement = new MoyenPaiement(compte, "Chequier");
                moyenPaiement.persist();
                moyenPaiement.IdMoyenPaiement=DAOGenerique.lastId();
                Chequier chequier = new Chequier(moyenPaiement.IdMoyenPaiement, int.Parse(cbNbCheques.SelectedText), int.Parse(txtNbDernierCheque.Text), int.Parse(txtNbPremierCheque.Text));
                chequier.persist();
                MessageBox.Show("Le moyen de paiement à été ajouté à la base", "Ajout moyen paiement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                return;
            }

            if (rbCarteBancaire.Checked == true)
            {
                if (!string.IsNullOrEmpty(txtNoCarte.Text)
                    || !string.IsNullOrEmpty(txtIdTypeCarte.Text))
                {
                    MessageBox.Show("Tous les champs concernant la carte bancaire doivent être remplis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    long.Parse(txtNoCarte.Text);
                    int.Parse(txtIdTypeCarte.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Les données saisies doivent être des nombres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MoyenPaiement moyenPaiement = new MoyenPaiement(compte, "Carte");
                moyenPaiement.persist();
                moyenPaiement.IdMoyenPaiement = DAOGenerique.lastId();
                TypeCarte typeCarte = new TypeCarte();
                typeCarte.IdTypeCarte = moyenPaiement.IdMoyenPaiement;
                Carte carte = new Carte(moyenPaiement.IdMoyenPaiement, dtDateDebut.Value, dtDateFin.Value, txtNoCarte.Text, typeCarte);
                carte.persist();
                MessageBox.Show("Le moyen de paiement à été ajouté à la base", "Ajout moyen paiement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                return;
            }
        }

    }
}
