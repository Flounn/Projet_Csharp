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

    public partial class FenSaisirCompte : Form
    {
        private Compte compte = new Compte();

        public FenSaisirCompte(Client client)
        {
            InitializeComponent();
            compte.Client = client;
        }

        public FenSaisirCompte()
        {
            InitializeComponent();
        }

        private void bt_creer_Click(object sender, EventArgs e)
        {
            try
            {
                compte.MontantInitial = decimal.Parse(txt_montant_initial.Text);
            }
            catch (FormatException) { return; }
            compte.TypeCompte = rb_courant.Checked ? Compte.Type.Courant : Compte.Type.Epargne;
            BSGestionClient.CreerModifierCompte(compte);
        }

    }
}
