﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopIHM.GuiObjects
{
    public partial class FenDetailUtilisateur : Form
    {
        private Utilisateur utilisateur;
        private readonly UpdateDataGridView callback;

        public FenDetailUtilisateur(Utilisateur utilisateur, UpdateDataGridView callback)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
            this.callback = callback;
            txt_email.Text = utilisateur.Email;
            txt_login.Text = utilisateur.Login;
            txt_password.Text = utilisateur.Password;
            cb_profil.DataSource = Utilisateur.Profils;
            cb_profil.SelectedItem = utilisateur.Profil;
            initRoles();
        }

        private void initRoles()
        {
            if (Session.isConsultation())
            {
                bt_modifier.Visible = false;
                bt_supprimer.Visible = false;
            }
            if (Session.isOperateurDeSaisie())
                bt_supprimer.Visible = false;
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            utilisateur.Email = txt_email.Text;
            utilisateur.Login = txt_login.Text;
            utilisateur.Password = txt_password.Text;
            utilisateur.Profil = (string)cb_profil.SelectedItem;
            GestionnaireUtilisateur.modifierUtilisateur(utilisateur);
            callback.refresh();
            this.Close();
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            GestionnaireUtilisateur.supprimerUtilisateur(utilisateur);
            callback.refresh();
            this.Close();
        }

      
    }
}
