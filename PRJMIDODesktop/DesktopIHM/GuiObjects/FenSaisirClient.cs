using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataService.DAOService;
using DataService.BSDataObjects;
using System.Globalization;


namespace DesktopIHM.GuiObjects
{
    public partial class FenSaisirClient : Form
    {
        public FenSaisirClient()
        {
            InitializeComponent();
            label9.Text = "(" + DateTimeFormatInfo.CurrentInfo.ShortDatePattern + ")";
        }

        private void bt_creer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nom.Text)){
                return;
            }
            if (string.IsNullOrEmpty(txt_prenom.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txt_ddn.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                return;
            }
            DateTime ddn;
            try
            {
                ddn = DateTime.Parse(txt_ddn.Text);
            }
            catch (FormatException) { return; }

            if (!Utilities.isEmailValid(txt_email.Text))
            {
                return;
            }

            Client client = new Client(txt_nom.Text, txt_prenom.Text, ddn,txt_email.Text, txt_adresse_princ.Text, txt_adresse_temp.Text, txt_tel_fixe.Text, txt_tel_port.Text);
            client.insert();
        }
    }
}
