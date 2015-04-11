using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopIHM.GuiObjects
{
    public partial class FenSaisirUtilisateur : Form
    {
        public FenSaisirUtilisateur()
        {
            InitializeComponent();
            cb_profil.DataSource = Utilisateur.profils;
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            if (!Utilities.isEmailValid(txt_email.Text))
            {
            }
        }
    }
}
