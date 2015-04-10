﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataService.BSDataObjects;
using DataService.BSService;
using DataService.DAOService;

namespace DesktopIHM.GuiObjects
{
    public partial class FenRechercheClient : Form
    {
        private CritereRechercheClient crtRechercheClient = null;

        private static string[] valuesDateNaissance = new string[]{"Choisissez","Né le","Né après le"
            ,"Né avant le","Né entre le"};

        public CritereRechercheClient CrtRechercheClient
        {
            get { return crtRechercheClient; }
            set { crtRechercheClient = value; }
        }

        private bool initCritereRecherche()
        {
           
            crtRechercheClient = new CritereRechercheClient();
            crtRechercheClient.Adresse = txtAdresse.Text;
            crtRechercheClient.Email = txtEmail.Text;
            if (!string.IsNullOrEmpty(txtId.Text))
                try{
                crtRechercheClient.IdClient = long.Parse(txtId.Text);
                }
                catch (Exception) {
                    MessageBox.Show("L'ID n'a pas été saisi correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; }
            crtRechercheClient.Nom = txtNom.Text;
            crtRechercheClient.Prenom = txtPrenom.Text;
            switch (cbDateNaissance.SelectedIndex){
                case 0: break;
                default:
                    crtRechercheClient.DateNaissanceDebut = dtDateNaissanceDebut.Value;
                    crtRechercheClient.DateNaissanceFin = dtDateNaissanceFin.Value;
                    break;
                case 2:               
                    crtRechercheClient.DateNaissanceDebut = dtDateNaissanceDebut.Value;
                    break;
                case 3:
                    crtRechercheClient.DateNaissanceFin = dtDateNaissanceFin.Value;
                    break;
            }
            return true;
            
        }

        public FenRechercheClient()
        {
            InitializeComponent();
            cbDateNaissance.Items.AddRange(valuesDateNaissance);
            cbDateNaissance.SelectedIndex = 0;
            dgvLstClient.SelectionChanged += new EventHandler(dgvLstClient_SelectionChanged);
        }

        void dgvLstClient_SelectionChanged(object sender, EventArgs e)
        {
            Console.WriteLine("dgvLstClient_SelectionChanged");
        }


        private void InitData()
        {
            DataTable dtt = new DataTable();
            dtt.Load(DAOClient.get(crtRechercheClient));
            dgvLstClient.DataSource = dtt;
            
            /*BindingList<Client> listeClient = new BindingList<Client>();

            IList<Client> lstC = BSGestionClient.RechercherClient(crtRechercheClient);

            foreach (Client c in lstC)
                listeClient.Add(c);

            this.dgwLstClient.DataSource = listeClient;*/
            dgvLstClient.Refresh();
        }

        private void btDetail_Click(object sender, EventArgs e)
        {
            //new FenDetailClient(dgwLstContrat.SelectedRows.Cast<Client>().);
        }

        private void btRechercher_Click(object sender, EventArgs e)
        {
            if (!Utilities.isEmailValid(txtEmail.Text) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("L'email n'a pas été saisi correctement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbDateNaissance.SelectedIndex==0 && string.IsNullOrEmpty(txtAdresse.Text)
                    && string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtId.Text)
                    && string.IsNullOrEmpty(txtNom.Text) && string.IsNullOrEmpty(txtPrenom.Text))
            {
                 MessageBox.Show("Veuillez saisir un des critères", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (initCritereRecherche())
                InitData();
        }

        private void cbDateSouscription_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDateNaissance.SelectedIndex)
            {
                case 0:
                    dtDateNaissanceDebut.Enabled = false;
                    dtDateNaissanceFin.Visible = false;
                    break;
                case 4:
                    dtDateNaissanceDebut.Enabled = true;
                    dtDateNaissanceFin.Visible = true;
                    dtDateNaissanceFin.Enabled = true;
                    break;
                default:
                    dtDateNaissanceDebut.Enabled = true;
                    dtDateNaissanceFin.Visible = false;
                    break;
            }
        }
    }
}
