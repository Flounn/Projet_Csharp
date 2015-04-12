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
    public partial class FenRechercheCompte : Form
    {
        private CritereRechercheCompte crtRechercheCompte = new CritereRechercheCompte();
        private static string[] valuesDateOuverture = new string[] { "Choisissez", "Le", "Après le", "Avant le", "Entre le" };
        
        public FenRechercheCompte()
        {
            InitializeComponent();
            cbDateOuverture.Items.AddRange(valuesDateOuverture);
            cb_type.Items.Add("Choisissez");
            cb_type.Items.AddRange(Compte.getTypes());
            cbDateOuverture.SelectedIndex = 0;
            cb_type.SelectedIndex = 0;
            //InitData();
        }
        
        private bool initCritereRecherche()
        {
            crtRechercheCompte = new CritereRechercheCompte();
            if (!string.IsNullOrEmpty(txtIdClient.Text))
                try
                {
                    crtRechercheCompte.IdClient = long.Parse(txtIdClient.Text);
                }
                catch
                {
                    Utilities.showErrorMessage("Veuillez saisir un id client valide", "Id client non valide");
                    return false;
                }
            if (!string.IsNullOrEmpty(txtIdCompte.Text))
                try
                {
                    crtRechercheCompte.IdCompte = long.Parse(txtIdCompte.Text);
                }
                catch
                {
                    Utilities.showErrorMessage("Veuillez saisir un id compte valide", "Id compte non valide");
                    return false;
                }

            if (cb_type.SelectedIndex>0)
                crtRechercheCompte.TypeCompte = (string)cb_type.SelectedItem;
            
            switch (cbDateOuverture.SelectedIndex)
            {
                case 0: break;
                case 1:
                    crtRechercheCompte.DateOuvertureDebut = dtDateOuvertureDebut.Value;
                    crtRechercheCompte.DateOuvertureFin = dtDateOuvertureDebut.Value;
                    break;
                case 2:
                    crtRechercheCompte.DateOuvertureDebut = dtDateOuvertureDebut.Value;
                    break;
                case 3:
                    crtRechercheCompte.DateOuvertureFin = dtDateOuvertureFin.Value;
                    break;
                case 4:
                    crtRechercheCompte.DateOuvertureDebut = dtDateOuvertureDebut.Value;
                    crtRechercheCompte.DateOuvertureFin = dtDateOuvertureFin.Value;
                    break;
            }
            return true;
        }


        private void InitData()
        {
            dgwLstCompte.DataSource = BSGestionClient.RechercherComptes(crtRechercheCompte);
        }

        private void btRechercher_Click(object sender, EventArgs e)
        {

            /*if (cbDateOuverture.SelectedIndex <1 && string.IsNullOrEmpty(txtIdClient.Text)
                   && string.IsNullOrEmpty(txtIdCompte.Text) && cb_type.SelectedIndex<1)
            {
                Utilities.showErrorMessage("Veuillez saisir un des critères", "Erreur");
                return;
            }*/
           
            if (initCritereRecherche())
                InitData();
            
        }


        private void cbDateOuverture_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDateOuverture.SelectedIndex)
            {
                case 0:
                    dtDateOuvertureDebut.Enabled = false;
                    dtDateOuvertureFin.Visible = false;
                    break;
                case 4:
                    dtDateOuvertureDebut.Enabled = true;
                    dtDateOuvertureFin.Visible = true;
                    dtDateOuvertureFin.Enabled = true;
                    break;
                default:
                    dtDateOuvertureDebut.Enabled = true;
                    dtDateOuvertureFin.Visible = false;
                    break;
            }
        }

        private void btVider_Click(object sender, EventArgs e)
        {
            txtIdClient.Text = string.Empty;
            txtIdCompte.Text = string.Empty;
            cbDateOuverture.SelectedIndex = 0;
            cb_type.SelectedIndex = 0;
        }

        private void dgwLstCompte_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            new FenDetailCompte(getCompteSelected(e.RowIndex)).Show(this);
        }

        private Compte getCompteSelected(int index)
        {
            if (index < 0)
                return null;
            return new Compte((int)dgwLstCompte.Rows[index].Cells[0].Value, (string)dgwLstCompte.Rows[index].Cells[4].Value,
                (DateTime)dgwLstCompte.Rows[index].Cells[1].Value, (decimal)dgwLstCompte.Rows[index].Cells[2].Value
                , (int)dgwLstCompte.Rows[index].Cells[3].Value);
        }
    }
}
