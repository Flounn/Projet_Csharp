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
    public partial class FenDetailClient : Form
    {
        private Client monClient;

        public Client MonClient
        {
            get { return monClient; }
            set { monClient = value; }
        }

        public FenDetailClient()
        {
            InitializeComponent();
            //monClient = cli;
            //initData();
        }


        private void initData()
        {
            if (monClient != null)
            {
                this.txtNom.Text= monClient.Nom;
                this.txtPrenom.Text = monClient.Prenom;
                this.txtAge.Text = monClient.DateNaissance.ToString();
                this.txtEmail.Text = monClient.Email;
            }
        }
    }
}