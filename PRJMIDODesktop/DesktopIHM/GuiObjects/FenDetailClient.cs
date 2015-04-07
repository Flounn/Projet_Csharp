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
            maPersonne = p;
            initData();
        }
    

        private void initData()
        {
            if(maPersonne!=null)
            {
                this.txtNom.text=maPersonne.nom;
                this.txtPrenom.text=maPersonne.Prenom;
                this.txtAxe.text=maPersonne.age.toString();
                this.txtEmail.text=maPersonne.email;
            }
        }
    }