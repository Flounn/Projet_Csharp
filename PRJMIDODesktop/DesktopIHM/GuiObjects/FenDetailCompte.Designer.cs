namespace DesktopIHM.GuiObjects
{
    partial class FenDetailCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenDetailCompte));
            this.gbDonneesCompte = new System.Windows.Forms.GroupBox();
            this.btDetailClient = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.txtTypeCompte = new System.Windows.Forms.TextBox();
            this.lbTypeCompte = new System.Windows.Forms.Label();
            this.txtMontantInitial = new System.Windows.Forms.TextBox();
            this.lbMontantInitial = new System.Windows.Forms.Label();
            this.dtDateOuverture = new System.Windows.Forms.DateTimePicker();
            this.txtPrenomClient = new System.Windows.Forms.TextBox();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.lbPrenomClient = new System.Windows.Forms.Label();
            this.lbDtOuverture = new System.Windows.Forms.Label();
            this.lbNomClient = new System.Windows.Forms.Label();
            this.lbIdClient = new System.Windows.Forms.Label();
            this.dgvLstMoyenPaiements = new System.Windows.Forms.DataGridView();
            this.gbListeMoyensPaiement = new System.Windows.Forms.GroupBox();
            this.btAjouterMoyenPaiement = new System.Windows.Forms.Button();
            this.gbDonneesCompte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstMoyenPaiements)).BeginInit();
            this.gbListeMoyensPaiement.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDonneesCompte
            // 
            this.gbDonneesCompte.Controls.Add(this.btDetailClient);
            this.gbDonneesCompte.Controls.Add(this.btSupprimer);
            this.gbDonneesCompte.Controls.Add(this.txtId);
            this.gbDonneesCompte.Controls.Add(this.lbId);
            this.gbDonneesCompte.Controls.Add(this.txtTypeCompte);
            this.gbDonneesCompte.Controls.Add(this.lbTypeCompte);
            this.gbDonneesCompte.Controls.Add(this.txtMontantInitial);
            this.gbDonneesCompte.Controls.Add(this.lbMontantInitial);
            this.gbDonneesCompte.Controls.Add(this.dtDateOuverture);
            this.gbDonneesCompte.Controls.Add(this.txtPrenomClient);
            this.gbDonneesCompte.Controls.Add(this.txtNomClient);
            this.gbDonneesCompte.Controls.Add(this.txtIdClient);
            this.gbDonneesCompte.Controls.Add(this.lbPrenomClient);
            this.gbDonneesCompte.Controls.Add(this.lbDtOuverture);
            this.gbDonneesCompte.Controls.Add(this.lbNomClient);
            this.gbDonneesCompte.Controls.Add(this.lbIdClient);
            this.gbDonneesCompte.Location = new System.Drawing.Point(4, 17);
            this.gbDonneesCompte.Name = "gbDonneesCompte";
            this.gbDonneesCompte.Size = new System.Drawing.Size(483, 157);
            this.gbDonneesCompte.TabIndex = 2;
            this.gbDonneesCompte.TabStop = false;
            this.gbDonneesCompte.Text = "Données du compte";
            // 
            // btDetailClient
            // 
            this.btDetailClient.Location = new System.Drawing.Point(11, 131);
            this.btDetailClient.Name = "btDetailClient";
            this.btDetailClient.Size = new System.Drawing.Size(147, 20);
            this.btDetailClient.TabIndex = 19;
            this.btDetailClient.Text = "Détail Client";
            this.btDetailClient.UseVisualStyleBackColor = true;
            this.btDetailClient.Click += new System.EventHandler(this.btDetailClient_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(329, 131);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(148, 20);
            this.btSupprimer.TabIndex = 18;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(88, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(129, 20);
            this.txtId.TabIndex = 17;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(8, 28);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 16;
            this.lbId.Text = "ID";
            // 
            // txtTypeCompte
            // 
            this.txtTypeCompte.Enabled = false;
            this.txtTypeCompte.Location = new System.Drawing.Point(336, 102);
            this.txtTypeCompte.Name = "txtTypeCompte";
            this.txtTypeCompte.Size = new System.Drawing.Size(141, 20);
            this.txtTypeCompte.TabIndex = 15;
            // 
            // lbTypeCompte
            // 
            this.lbTypeCompte.AutoSize = true;
            this.lbTypeCompte.Location = new System.Drawing.Point(235, 106);
            this.lbTypeCompte.Name = "lbTypeCompte";
            this.lbTypeCompte.Size = new System.Drawing.Size(70, 13);
            this.lbTypeCompte.TabIndex = 13;
            this.lbTypeCompte.Text = "Type Compte";
            // 
            // txtMontantInitial
            // 
            this.txtMontantInitial.Enabled = false;
            this.txtMontantInitial.Location = new System.Drawing.Point(336, 76);
            this.txtMontantInitial.Name = "txtMontantInitial";
            this.txtMontantInitial.Size = new System.Drawing.Size(141, 20);
            this.txtMontantInitial.TabIndex = 11;
            // 
            // lbMontantInitial
            // 
            this.lbMontantInitial.AutoSize = true;
            this.lbMontantInitial.Location = new System.Drawing.Point(235, 80);
            this.lbMontantInitial.Name = "lbMontantInitial";
            this.lbMontantInitial.Size = new System.Drawing.Size(73, 13);
            this.lbMontantInitial.TabIndex = 9;
            this.lbMontantInitial.Text = "Montant Initial";
            // 
            // dtDateOuverture
            // 
            this.dtDateOuverture.Enabled = false;
            this.dtDateOuverture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOuverture.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtDateOuverture.Location = new System.Drawing.Point(336, 50);
            this.dtDateOuverture.MaxDate = new System.DateTime(2015, 12, 25, 23, 59, 59, 0);
            this.dtDateOuverture.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtDateOuverture.Name = "dtDateOuverture";
            this.dtDateOuverture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDateOuverture.Size = new System.Drawing.Size(141, 20);
            this.dtDateOuverture.TabIndex = 5;
            this.dtDateOuverture.Value = new System.DateTime(2015, 4, 10, 0, 0, 0, 0);
            // 
            // txtPrenomClient
            // 
            this.txtPrenomClient.Enabled = false;
            this.txtPrenomClient.Location = new System.Drawing.Point(88, 102);
            this.txtPrenomClient.Name = "txtPrenomClient";
            this.txtPrenomClient.Size = new System.Drawing.Size(129, 20);
            this.txtPrenomClient.TabIndex = 7;
            // 
            // txtNomClient
            // 
            this.txtNomClient.Enabled = false;
            this.txtNomClient.Location = new System.Drawing.Point(88, 76);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(129, 20);
            this.txtNomClient.TabIndex = 5;
            // 
            // txtIdClient
            // 
            this.txtIdClient.Enabled = false;
            this.txtIdClient.Location = new System.Drawing.Point(88, 50);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(129, 20);
            this.txtIdClient.TabIndex = 4;
            // 
            // lbPrenomClient
            // 
            this.lbPrenomClient.AutoSize = true;
            this.lbPrenomClient.Location = new System.Drawing.Point(8, 106);
            this.lbPrenomClient.Name = "lbPrenomClient";
            this.lbPrenomClient.Size = new System.Drawing.Size(72, 13);
            this.lbPrenomClient.TabIndex = 3;
            this.lbPrenomClient.Text = "Prenom Client";
            // 
            // lbDtOuverture
            // 
            this.lbDtOuverture.AutoSize = true;
            this.lbDtOuverture.Location = new System.Drawing.Point(235, 54);
            this.lbDtOuverture.Name = "lbDtOuverture";
            this.lbDtOuverture.Size = new System.Drawing.Size(80, 13);
            this.lbDtOuverture.TabIndex = 2;
            this.lbDtOuverture.Text = "Date Ouverture";
            // 
            // lbNomClient
            // 
            this.lbNomClient.AutoSize = true;
            this.lbNomClient.Location = new System.Drawing.Point(8, 80);
            this.lbNomClient.Name = "lbNomClient";
            this.lbNomClient.Size = new System.Drawing.Size(58, 13);
            this.lbNomClient.TabIndex = 1;
            this.lbNomClient.Text = "Nom Client";
            // 
            // lbIdClient
            // 
            this.lbIdClient.AutoSize = true;
            this.lbIdClient.Location = new System.Drawing.Point(8, 54);
            this.lbIdClient.Name = "lbIdClient";
            this.lbIdClient.Size = new System.Drawing.Size(47, 13);
            this.lbIdClient.TabIndex = 0;
            this.lbIdClient.Text = "ID Client";
            // 
            // dgvLstMoyenPaiements
            // 
            this.dgvLstMoyenPaiements.AllowUserToAddRows = false;
            this.dgvLstMoyenPaiements.AllowUserToDeleteRows = false;
            this.dgvLstMoyenPaiements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLstMoyenPaiements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLstMoyenPaiements.Location = new System.Drawing.Point(6, 17);
            this.dgvLstMoyenPaiements.MultiSelect = false;
            this.dgvLstMoyenPaiements.Name = "dgvLstMoyenPaiements";
            this.dgvLstMoyenPaiements.ReadOnly = true;
            this.dgvLstMoyenPaiements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLstMoyenPaiements.Size = new System.Drawing.Size(471, 107);
            this.dgvLstMoyenPaiements.TabIndex = 10;
            // 
            // gbListeMoyensPaiement
            // 
            this.gbListeMoyensPaiement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListeMoyensPaiement.Controls.Add(this.dgvLstMoyenPaiements);
            this.gbListeMoyensPaiement.Location = new System.Drawing.Point(4, 180);
            this.gbListeMoyensPaiement.Name = "gbListeMoyensPaiement";
            this.gbListeMoyensPaiement.Size = new System.Drawing.Size(483, 130);
            this.gbListeMoyensPaiement.TabIndex = 3;
            this.gbListeMoyensPaiement.TabStop = false;
            this.gbListeMoyensPaiement.Text = "Liste des moyens de paiement";
            // 
            // btAjouterMoyenPaiement
            // 
            this.btAjouterMoyenPaiement.Location = new System.Drawing.Point(183, 316);
            this.btAjouterMoyenPaiement.Name = "btAjouterMoyenPaiement";
            this.btAjouterMoyenPaiement.Size = new System.Drawing.Size(147, 20);
            this.btAjouterMoyenPaiement.TabIndex = 20;
            this.btAjouterMoyenPaiement.Text = "Ajouter Moyen Paiement";
            this.btAjouterMoyenPaiement.UseVisualStyleBackColor = true;
            this.btAjouterMoyenPaiement.Click += new System.EventHandler(this.btAjouterMoyenPaiement_Click);
            // 
            // FenDetailCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 349);
            this.Controls.Add(this.btAjouterMoyenPaiement);
            this.Controls.Add(this.gbDonneesCompte);
            this.Controls.Add(this.gbListeMoyensPaiement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FenDetailCompte";
            this.Text = "Détail Compte";
            this.gbDonneesCompte.ResumeLayout(false);
            this.gbDonneesCompte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstMoyenPaiements)).EndInit();
            this.gbListeMoyensPaiement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDonneesCompte;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtTypeCompte;
        private System.Windows.Forms.Label lbTypeCompte;
        private System.Windows.Forms.TextBox txtMontantInitial;
        private System.Windows.Forms.Label lbMontantInitial;
        private System.Windows.Forms.DateTimePicker dtDateOuverture;
        private System.Windows.Forms.TextBox txtPrenomClient;
        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.Label lbPrenomClient;
        private System.Windows.Forms.Label lbDtOuverture;
        private System.Windows.Forms.Label lbNomClient;
        private System.Windows.Forms.Label lbIdClient;
        private System.Windows.Forms.DataGridView dgvLstMoyenPaiements;
        private System.Windows.Forms.GroupBox gbListeMoyensPaiement;
        private System.Windows.Forms.Button btDetailClient;
        private System.Windows.Forms.Button btAjouterMoyenPaiement;
    }
}