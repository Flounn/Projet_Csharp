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
    public partial class FenMonProfil : Form
    {
        
        public FenMonProfil()
        {
            InitializeComponent();
            InitProfile();
        }

        public void InitProfile()
        {

            this.monLogin.Text = Session.Utilisateur.Login;
            this.monEmail.Text = Session.Utilisateur.Email;
            this.monProfile.Text = Session.Utilisateur.Profil;          

        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            
        }
    }
}
