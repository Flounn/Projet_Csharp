﻿using System;
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

    public partial class FenSaisirCompte : Form
    {
        private Compte compte = new Compte();

        public FenSaisirCompte()
        {
            InitializeComponent();
        }

        private void bt_creer_Click(object sender, EventArgs e)
        {
            compte.MontantInitial = decimal.Parse(txt_montant_initial.Text);
            compte.TypeCompte = rb_courant.Checked ? Compte.Type.Courant : Compte.Type.Epargne;
            //compte.Client=
                //Connexion.insert
        }

    }
}