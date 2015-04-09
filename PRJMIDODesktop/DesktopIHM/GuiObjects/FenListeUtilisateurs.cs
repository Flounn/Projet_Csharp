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
    public partial class FenListeUtilisateurs : Form
    {
        public FenListeUtilisateurs()
        {
            InitializeComponent();
            DataTable dtt = new DataTable();
            dtt.Load(DAOClient.getAll());
            DataColumn column = new DataColumn();
            column.Caption = "ID";
            column.ColumnName = "ID_CLIENT";
            dtt.Columns.Add(column);
            dg_utilisateurs.DataSource = dtt;
        }

    }
}
