using System.Windows.Forms;
namespace DesktopIHM.GuiObjects
{
    partial class FenDetailClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDonneesPersonnelles = new System.Windows.Forms.GroupBox();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.txtAdresseTemp = new System.Windows.Forms.TextBox();
            this.txtTelPort = new System.Windows.Forms.TextBox();
            this.lbAdresseTemp = new System.Windows.Forms.Label();
            this.lbTelPort = new System.Windows.Forms.Label();
            this.txtAdressePrinc = new System.Windows.Forms.TextBox();
            this.txtTelFixe = new System.Windows.Forms.TextBox();
            this.lbAdressePrincipale = new System.Windows.Forms.Label();
            this.lbTelFixe = new System.Windows.Forms.Label();
            this.dtDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.lbDdn = new System.Windows.Forms.Label();
            this.lPrenom = new System.Windows.Forms.Label();
            this.lNom = new System.Windows.Forms.Label();
            this.gbListeContrats = new System.Windows.Forms.GroupBox();
            this.dgvLstContrats = new System.Windows.Forms.DataGridView();
            this.gbListeComptes = new System.Windows.Forms.GroupBox();
            this.dgvLstComptes = new System.Windows.Forms.DataGridView();
            this.gbListeTransactions = new System.Windows.Forms.GroupBox();
            this.dgvLstOperations = new System.Windows.Forms.DataGridView();
            this.btImprimer = new System.Windows.Forms.Button();
            this.gbDonneesPersonnelles.SuspendLayout();
            this.gbListeContrats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstContrats)).BeginInit();
            this.gbListeComptes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstComptes)).BeginInit();
            this.gbListeTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDonneesPersonnelles
            // 
            this.gbDonneesPersonnelles.Controls.Add(this.btSupprimer);
            this.gbDonneesPersonnelles.Controls.Add(this.btModifier);
            this.gbDonneesPersonnelles.Controls.Add(this.txtId);
            this.gbDonneesPersonnelles.Controls.Add(this.lbId);
            this.gbDonneesPersonnelles.Controls.Add(this.txtAdresseTemp);
            this.gbDonneesPersonnelles.Controls.Add(this.txtTelPort);
            this.gbDonneesPersonnelles.Controls.Add(this.lbAdresseTemp);
            this.gbDonneesPersonnelles.Controls.Add(this.lbTelPort);
            this.gbDonneesPersonnelles.Controls.Add(this.txtAdressePrinc);
            this.gbDonneesPersonnelles.Controls.Add(this.txtTelFixe);
            this.gbDonneesPersonnelles.Controls.Add(this.lbAdressePrincipale);
            this.gbDonneesPersonnelles.Controls.Add(this.lbTelFixe);
            this.gbDonneesPersonnelles.Controls.Add(this.dtDateNaissance);
            this.gbDonneesPersonnelles.Controls.Add(this.txtEmail);
            this.gbDonneesPersonnelles.Controls.Add(this.txtPrenom);
            this.gbDonneesPersonnelles.Controls.Add(this.txtNom);
            this.gbDonneesPersonnelles.Controls.Add(this.lEmail);
            this.gbDonneesPersonnelles.Controls.Add(this.lbDdn);
            this.gbDonneesPersonnelles.Controls.Add(this.lPrenom);
            this.gbDonneesPersonnelles.Controls.Add(this.lNom);
            this.gbDonneesPersonnelles.Location = new System.Drawing.Point(12, 12);
            this.gbDonneesPersonnelles.Name = "gbDonneesPersonnelles";
            this.gbDonneesPersonnelles.Size = new System.Drawing.Size(699, 157);
            this.gbDonneesPersonnelles.TabIndex = 0;
            this.gbDonneesPersonnelles.TabStop = false;
            this.gbDonneesPersonnelles.Text = "Données Personnelles";
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(399, 128);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(147, 20);
            this.btSupprimer.TabIndex = 18;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(552, 128);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(141, 20);
            this.btModifier.TabIndex = 5;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(82, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(141, 20);
            this.txtId.TabIndex = 17;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(14, 28);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 16;
            this.lbId.Text = "ID";
            // 
            // txtAdresseTemp
            // 
            this.txtAdresseTemp.Enabled = false;
            this.txtAdresseTemp.Location = new System.Drawing.Point(336, 102);
            this.txtAdresseTemp.Name = "txtAdresseTemp";
            this.txtAdresseTemp.Size = new System.Drawing.Size(141, 20);
            this.txtAdresseTemp.TabIndex = 15;
            // 
            // txtTelPort
            // 
            this.txtTelPort.Enabled = false;
            this.txtTelPort.Location = new System.Drawing.Point(552, 76);
            this.txtTelPort.Name = "txtTelPort";
            this.txtTelPort.Size = new System.Drawing.Size(141, 20);
            this.txtTelPort.TabIndex = 14;
            // 
            // lbAdresseTemp
            // 
            this.lbAdresseTemp.AutoSize = true;
            this.lbAdresseTemp.Location = new System.Drawing.Point(235, 106);
            this.lbAdresseTemp.Name = "lbAdresseTemp";
            this.lbAdresseTemp.Size = new System.Drawing.Size(101, 13);
            this.lbAdresseTemp.TabIndex = 13;
            this.lbAdresseTemp.Text = "Adresse Temporaire";
            // 
            // lbTelPort
            // 
            this.lbTelPort.AutoSize = true;
            this.lbTelPort.Location = new System.Drawing.Point(484, 80);
            this.lbTelPort.Name = "lbTelPort";
            this.lbTelPort.Size = new System.Drawing.Size(67, 13);
            this.lbTelPort.TabIndex = 12;
            this.lbTelPort.Text = "Tel. Portable";
            // 
            // txtAdressePrinc
            // 
            this.txtAdressePrinc.Enabled = false;
            this.txtAdressePrinc.Location = new System.Drawing.Point(336, 76);
            this.txtAdressePrinc.Name = "txtAdressePrinc";
            this.txtAdressePrinc.Size = new System.Drawing.Size(141, 20);
            this.txtAdressePrinc.TabIndex = 11;
            // 
            // txtTelFixe
            // 
            this.txtTelFixe.Enabled = false;
            this.txtTelFixe.Location = new System.Drawing.Point(552, 50);
            this.txtTelFixe.Name = "txtTelFixe";
            this.txtTelFixe.Size = new System.Drawing.Size(141, 20);
            this.txtTelFixe.TabIndex = 10;
            // 
            // lbAdressePrincipale
            // 
            this.lbAdressePrincipale.AutoSize = true;
            this.lbAdressePrincipale.Location = new System.Drawing.Point(235, 80);
            this.lbAdressePrincipale.Name = "lbAdressePrincipale";
            this.lbAdressePrincipale.Size = new System.Drawing.Size(94, 13);
            this.lbAdressePrincipale.TabIndex = 9;
            this.lbAdressePrincipale.Text = "Adresse Principale";
            // 
            // lbTelFixe
            // 
            this.lbTelFixe.AutoSize = true;
            this.lbTelFixe.Location = new System.Drawing.Point(484, 54);
            this.lbTelFixe.Name = "lbTelFixe";
            this.lbTelFixe.Size = new System.Drawing.Size(47, 13);
            this.lbTelFixe.TabIndex = 8;
            this.lbTelFixe.Text = "Tel. Fixe";
            // 
            // dtDateNaissance
            // 
            this.dtDateNaissance.Enabled = false;
            this.dtDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateNaissance.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtDateNaissance.Location = new System.Drawing.Point(336, 50);
            this.dtDateNaissance.MaxDate = new System.DateTime(2015, 12, 25, 23, 59, 59, 0);
            this.dtDateNaissance.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtDateNaissance.Name = "dtDateNaissance";
            this.dtDateNaissance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDateNaissance.Size = new System.Drawing.Size(141, 20);
            this.dtDateNaissance.TabIndex = 5;
            this.dtDateNaissance.Value = new System.DateTime(2015, 4, 10, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(82, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Enabled = false;
            this.txtPrenom.Location = new System.Drawing.Point(82, 76);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(141, 20);
            this.txtPrenom.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(82, 50);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(141, 20);
            this.txtNom.TabIndex = 4;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(14, 106);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(32, 13);
            this.lEmail.TabIndex = 3;
            this.lEmail.Text = "Email";
            // 
            // lbDdn
            // 
            this.lbDdn.AutoSize = true;
            this.lbDdn.Location = new System.Drawing.Point(235, 54);
            this.lbDdn.Name = "lbDdn";
            this.lbDdn.Size = new System.Drawing.Size(98, 13);
            this.lbDdn.TabIndex = 2;
            this.lbDdn.Text = "Date de Naissance";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.Location = new System.Drawing.Point(14, 80);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(43, 13);
            this.lPrenom.TabIndex = 1;
            this.lPrenom.Text = "Prenom";
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(14, 54);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(29, 13);
            this.lNom.TabIndex = 0;
            this.lNom.Text = "Nom";
            // 
            // gbListeContrats
            // 
            this.gbListeContrats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListeContrats.Controls.Add(this.dgvLstContrats);
            this.gbListeContrats.Location = new System.Drawing.Point(12, 175);
            this.gbListeContrats.Name = "gbListeContrats";
            this.gbListeContrats.Size = new System.Drawing.Size(699, 130);
            this.gbListeContrats.TabIndex = 1;
            this.gbListeContrats.TabStop = false;
            this.gbListeContrats.Text = "Liste des contrats";
            // 
            // dgvLstContrats
            // 
            this.dgvLstContrats.AllowUserToAddRows = false;
            this.dgvLstContrats.AllowUserToDeleteRows = false;
            this.dgvLstContrats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLstContrats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLstContrats.Location = new System.Drawing.Point(6, 17);
            this.dgvLstContrats.MultiSelect = false;
            this.dgvLstContrats.Name = "dgvLstContrats";
            this.dgvLstContrats.ReadOnly = true;
            this.dgvLstContrats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLstContrats.Size = new System.Drawing.Size(687, 107);
            this.dgvLstContrats.TabIndex = 10;
            // 
            // gbListeComptes
            // 
            this.gbListeComptes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListeComptes.Controls.Add(this.dgvLstComptes);
            this.gbListeComptes.Location = new System.Drawing.Point(12, 311);
            this.gbListeComptes.Name = "gbListeComptes";
            this.gbListeComptes.Size = new System.Drawing.Size(699, 130);
            this.gbListeComptes.TabIndex = 2;
            this.gbListeComptes.TabStop = false;
            this.gbListeComptes.Text = "Liste des comptes";
            // 
            // dgvLstComptes
            // 
            this.dgvLstComptes.AllowUserToAddRows = false;
            this.dgvLstComptes.AllowUserToDeleteRows = false;
            this.dgvLstComptes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLstComptes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLstComptes.Location = new System.Drawing.Point(6, 17);
            this.dgvLstComptes.MultiSelect = false;
            this.dgvLstComptes.Name = "dgvLstComptes";
            this.dgvLstComptes.ReadOnly = true;
            this.dgvLstComptes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLstComptes.Size = new System.Drawing.Size(687, 107);
            this.dgvLstComptes.TabIndex = 11;
            this.dgvLstComptes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLstComptes_CellContentClick);
            this.dgvLstComptes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLstComptes_CellContentDoubleClick);
            // 
            // gbListeTransactions
            // 
            this.gbListeTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListeTransactions.Controls.Add(this.dgvLstOperations);
            this.gbListeTransactions.Location = new System.Drawing.Point(12, 447);
            this.gbListeTransactions.Name = "gbListeTransactions";
            this.gbListeTransactions.Size = new System.Drawing.Size(699, 130);
            this.gbListeTransactions.TabIndex = 3;
            this.gbListeTransactions.TabStop = false;
            this.gbListeTransactions.Text = "Liste des transactions";
            // 
            // dgvLstOperations
            // 
            this.dgvLstOperations.AllowUserToAddRows = false;
            this.dgvLstOperations.AllowUserToDeleteRows = false;
            this.dgvLstOperations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLstOperations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLstOperations.Location = new System.Drawing.Point(6, 17);
            this.dgvLstOperations.MultiSelect = false;
            this.dgvLstOperations.Name = "dgvLstOperations";
            this.dgvLstOperations.ReadOnly = true;
            this.dgvLstOperations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLstOperations.Size = new System.Drawing.Size(687, 107);
            this.dgvLstOperations.TabIndex = 12;
            // 
            // btImprimer
            // 
            this.btImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btImprimer.Location = new System.Drawing.Point(290, 583);
            this.btImprimer.Name = "btImprimer";
            this.btImprimer.Size = new System.Drawing.Size(132, 30);
            this.btImprimer.TabIndex = 4;
            this.btImprimer.Text = "Imprimer";
            this.btImprimer.UseVisualStyleBackColor = true;
            // 
            // FenDetailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 620);
            this.Controls.Add(this.gbListeComptes);
            this.Controls.Add(this.btImprimer);
            this.Controls.Add(this.gbListeTransactions);
            this.Controls.Add(this.gbListeContrats);
            this.Controls.Add(this.gbDonneesPersonnelles);
            this.Name = "FenDetailClient";
            this.ShowIcon = false;
            this.Text = "Détail Client";
            this.gbDonneesPersonnelles.ResumeLayout(false);
            this.gbDonneesPersonnelles.PerformLayout();
            this.gbListeContrats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstContrats)).EndInit();
            this.gbListeComptes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstComptes)).EndInit();
            this.gbListeTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstOperations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDonneesPersonnelles;
        private System.Windows.Forms.GroupBox gbListeContrats;
        private System.Windows.Forms.GroupBox gbListeComptes;
        private System.Windows.Forms.GroupBox gbListeTransactions;
        private System.Windows.Forms.Button btImprimer;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lbDdn;
        private System.Windows.Forms.Label lPrenom;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DateTimePicker dtDateNaissance;
        private System.Windows.Forms.TextBox txtAdresseTemp;
        private System.Windows.Forms.TextBox txtTelPort;
        private System.Windows.Forms.Label lbAdresseTemp;
        private System.Windows.Forms.Label lbTelPort;
        private System.Windows.Forms.TextBox txtAdressePrinc;
        private System.Windows.Forms.TextBox txtTelFixe;
        private System.Windows.Forms.Label lbAdressePrincipale;
        private System.Windows.Forms.Label lbTelFixe;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.DataGridView dgvLstContrats;
        private System.Windows.Forms.DataGridView dgvLstComptes;
        private System.Windows.Forms.DataGridView dgvLstOperations;
    }
}