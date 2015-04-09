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
            dtt.ColumnChanged+=new DataColumnChangeEventHandler(dtt_ColumnChanged);
            dtt.Load(DAOClient.getAll());
            dg_utilisateurs.DataSource = dtt;
            dtt.TableNewRow+=new DataTableNewRowEventHandler(dtt_TableNewRow);

        }

        void dtt_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            int ID_CLIENT = (int)e.Row.ItemArray[0];
            Console.WriteLine(sender);
        }

        void dtt_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {

            //throw new NotImplementedException();
        }

    }
}
