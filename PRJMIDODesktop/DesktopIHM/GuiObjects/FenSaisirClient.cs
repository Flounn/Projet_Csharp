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

        private void btCreer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNom.Text)){
                return;
            }
            if (string.IsNullOrEmpty(txtPrenom.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtDdn.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                return;
            }
            DateTime ddn;
            try
            {
                ddn = DateTime.Parse(txtDdn.Text);
            }
            catch (FormatException) { return; }

            if (!Utilities.isEmailValid(txtEmail.Text))
            {
                return;
            }

            Client client = new Client(txtNom.Text, txtPrenom.Text, ddn,txtEmail.Text, txtAdressePrinc.Text, txtAdresseTemp.Text, txtTelFixe.Text, txtTelPort.Text);
            client.insert();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
