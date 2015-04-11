using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataService.DAOService;

namespace DesktopIHM.GuiObjects
{
    partial class FenListeUtilisateurs : Form, UpdateDataGridView
    {
        public FenListeUtilisateurs()
        {
            InitializeComponent();
            dg_utilisateurs.DataSource = GestionnaireUtilisateur.ListeUtilisateurs();
            dg_utilisateurs.CellDoubleClick += new DataGridViewCellEventHandler(dg_utilisateurs_CellDoubleClick);
        }

        void dg_utilisateurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            new FenModifierUtilisateur((Utilisateur)dg_utilisateurs.Rows[e.RowIndex].DataBoundItem,this).Show(this);
        }

        public void refresh(){
            dg_utilisateurs.Refresh();
        }

    }
}
