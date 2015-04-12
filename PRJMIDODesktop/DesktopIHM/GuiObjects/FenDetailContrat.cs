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
    public partial class FenDetailContrat : Form
    {
        private Contrat contrat;

        public FenDetailContrat(Contrat contrat)
        {
            InitializeComponent();
            initData();
        }

        private void initData()
        {
            txt_intitule.Text = contrat.Intitule;
            cbStatut.Items.AddRange(Contrat.getStatutJuridique());
            cbStatut.SelectedItem = contrat.StatutJuridiqueStr;
            lbl_idClient.Text = contrat.Client.IdClient.ToString();
            lbl_idContrat.Text = contrat.IdContrat.ToString();
            lbl_idCompte.Text = contrat.Compte.ToString();
        }
    }
}
