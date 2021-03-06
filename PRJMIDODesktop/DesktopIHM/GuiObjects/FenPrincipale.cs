﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopIHM.GuiObjects;

namespace DesktopIHM
{
    public partial class FenPrincipale : Form, UpdateDataGridView
    {
       
        public FenPrincipale()
        {
            InitializeComponent();
            InitialisationReferentiel();
        }

        private void initRoles()
        {
            if (Session.isConsultation())
            {
                miAddUtilisateur.Enabled = false;
                miSaisir.Enabled = false;
            }
        }

        private void InitialisationReferentiel()
        {
            //A remplir
        }

        private void miQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FenPrincipale_Load(object sender, EventArgs e)
        {
            FenConnexion connexion = new FenConnexion(this);
            connexion.ShowDialog(this);
            //Session.seConnecter("midoif", "passw1");
            //refresh();
        }

        private void miVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LCP Gestionnaire Clientèle\nV1.0.0.2015\nRelease du 12/04/2015", "Version", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void monProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FenMonProfil monProfile = new FenMonProfil();
            monProfile.ShowDialog(this);
        }

        private void miSaisirCompte_Click(object sender, EventArgs e)
        {
            new FenSaisirCompte().Show(this);
        }

        private void miSaisirClient_Click(object sender, EventArgs e)
        {
            new FenSaisirClient().Show(this);
        }

        private void miRechercheClient_Click(object sender, EventArgs e)
        {
            new FenRechercheClient().Show(this);
        }

        private void miAuteurs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ce logiciel a été développé par l'équipe MIDO Paris Dauphine \nAvec la participation de M. Alexis ONGAGNA\nAu cours de l'année académique 2014 - 2015", "A propos des auteurs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void miLstUtilisateurs_Click(object sender, EventArgs e)
        {
            new FenListeUtilisateurs().Show(this);
        }

        private void miAddUtilisateur_Click(object sender, EventArgs e)
        {
            new FenSaisirUtilisateur().Show(this);
        }

        private void miRechercheContrat_Click(object sender, EventArgs e)
        {
            new FenRechercheContrat().Show(this);
        }

        private void miRechercheCompte_Click(object sender, EventArgs e)
        {
            new FenRechercheCompte().Show(this);
        }

        private void miSouscription_Click(object sender, EventArgs e)
        {
            new FenSaisirContrat().Show();
        }

        private void miRechercheOperation_Click(object sender, EventArgs e)
        {
            new FenRechercheOperation().Show();
        }


        public void refresh()
        {
            initRoles();
        }
    }
}
