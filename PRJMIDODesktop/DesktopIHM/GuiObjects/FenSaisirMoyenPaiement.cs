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
    public partial class FenSaisirMoyenPaiement : Form
    {

        private static string[] valuesNbCheques = new string[] { "20", "50", "100" };

        public FenSaisirMoyenPaiement(Compte compte)
        {
            InitializeComponent();
            txtIdCompte.Text = compte.IdCompte.ToString();
            cbNbCheques.Items.AddRange(valuesNbCheques);
            cbNbCheques.SelectedIndex = 1;
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

    }
}
