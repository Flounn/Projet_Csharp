namespace DesktopIHM.GuiObjects
{
    partial class FenRechercheOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenRechercheOperation));
            this.btVider = new System.Windows.Forms.Button();
            this.btRechercher = new System.Windows.Forms.Button();
            this.dgvLstClient = new System.Windows.Forms.DataGridView();
            this.dtDateDebut = new System.Windows.Forms.DateTimePicker();
            this.dtDateFin = new System.Windows.Forms.DateTimePicker();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.lbId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gbDonneesRecherche = new System.Windows.Forms.GroupBox();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStatut = new System.Windows.Forms.Label();
            this.cbStatut = new System.Windows.Forms.ComboBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.txtIdCompte = new System.Windows.Forms.TextBox();
            this.IdCompte = new System.Windows.Forms.Label();
            this.txtIdMoyenPaiement = new System.Windows.Forms.TextBox();
            this.lbIdMoyenPaiement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstClient)).BeginInit();
            this.gbDonneesRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // btVider
            // 
            this.btVider.Location = new System.Drawing.Point(40, 156);
            this.btVider.Name = "btVider";
            this.btVider.Size = new System.Drawing.Size(128, 21);
            this.btVider.TabIndex = 22;
            this.btVider.Text = "Vider les champs";
            this.btVider.UseVisualStyleBackColor = true;
            // 
            // btRechercher
            // 
            this.btRechercher.Location = new System.Drawing.Point(288, 156);
            this.btRechercher.Name = "btRechercher";
            this.btRechercher.Size = new System.Drawing.Size(264, 21);
            this.btRechercher.TabIndex = 21;
            this.btRechercher.Text = "Rechercher";
            this.btRechercher.UseVisualStyleBackColor = true;
            this.btRechercher.Click += new System.EventHandler(this.btRechercher_Click);
            // 
            // dgvLstClient
            // 
            this.dgvLstClient.AllowUserToAddRows = false;
            this.dgvLstClient.AllowUserToDeleteRows = false;
            this.dgvLstClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLstClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLstClient.Location = new System.Drawing.Point(40, 183);
            this.dgvLstClient.MultiSelect = false;
            this.dgvLstClient.Name = "dgvLstClient";
            this.dgvLstClient.ReadOnly = true;
            this.dgvLstClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLstClient.Size = new System.Drawing.Size(513, 237);
            this.dgvLstClient.TabIndex = 20;
            // 
            // dtDateDebut
            // 
            this.dtDateDebut.Enabled = false;
            this.dtDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateDebut.Location = new System.Drawing.Point(131, 39);
            this.dtDateDebut.Name = "dtDateDebut";
            this.dtDateDebut.Size = new System.Drawing.Size(86, 20);
            this.dtDateDebut.TabIndex = 4;
            this.dtDateDebut.Value = new System.DateTime(2015, 4, 12, 0, 0, 0, 0);
            // 
            // dtDateFin
            // 
            this.dtDateFin.Enabled = false;
            this.dtDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateFin.Location = new System.Drawing.Point(131, 60);
            this.dtDateFin.Name = "dtDateFin";
            this.dtDateFin.Size = new System.Drawing.Size(86, 20);
            this.dtDateFin.TabIndex = 11;
            this.dtDateFin.Value = new System.DateTime(2015, 4, 12, 0, 0, 0, 0);
            // 
            // cbDate
            // 
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(51, 42);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(74, 21);
            this.cbDate.TabIndex = 12;
            this.cbDate.SelectedIndexChanged += new System.EventHandler(this.cbDate_SelectedIndexChanged);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(6, 23);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 15;
            this.lbId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(51, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(166, 20);
            this.txtId.TabIndex = 16;
            // 
            // gbDonneesRecherche
            // 
            this.gbDonneesRecherche.Controls.Add(this.txtLibelle);
            this.gbDonneesRecherche.Controls.Add(this.label1);
            this.gbDonneesRecherche.Controls.Add(this.lbStatut);
            this.gbDonneesRecherche.Controls.Add(this.cbStatut);
            this.gbDonneesRecherche.Controls.Add(this.lbDate);
            this.gbDonneesRecherche.Controls.Add(this.txtIdCompte);
            this.gbDonneesRecherche.Controls.Add(this.IdCompte);
            this.gbDonneesRecherche.Controls.Add(this.txtIdMoyenPaiement);
            this.gbDonneesRecherche.Controls.Add(this.lbIdMoyenPaiement);
            this.gbDonneesRecherche.Controls.Add(this.txtId);
            this.gbDonneesRecherche.Controls.Add(this.lbId);
            this.gbDonneesRecherche.Controls.Add(this.cbDate);
            this.gbDonneesRecherche.Controls.Add(this.dtDateFin);
            this.gbDonneesRecherche.Controls.Add(this.dtDateDebut);
            this.gbDonneesRecherche.Location = new System.Drawing.Point(40, 21);
            this.gbDonneesRecherche.Name = "gbDonneesRecherche";
            this.gbDonneesRecherche.Size = new System.Drawing.Size(513, 127);
            this.gbDonneesRecherche.TabIndex = 23;
            this.gbDonneesRecherche.TabStop = false;
            this.gbDonneesRecherche.Text = "Données de recherche";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(353, 82);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(141, 20);
            this.txtLibelle.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Libelle";
            // 
            // lbStatut
            // 
            this.lbStatut.AutoSize = true;
            this.lbStatut.Location = new System.Drawing.Point(6, 89);
            this.lbStatut.Name = "lbStatut";
            this.lbStatut.Size = new System.Drawing.Size(35, 13);
            this.lbStatut.TabIndex = 23;
            this.lbStatut.Text = "Statut";
            // 
            // cbStatut
            // 
            this.cbStatut.FormattingEnabled = true;
            this.cbStatut.Location = new System.Drawing.Point(51, 86);
            this.cbStatut.Name = "cbStatut";
            this.cbStatut.Size = new System.Drawing.Size(166, 21);
            this.cbStatut.TabIndex = 22;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(6, 48);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(30, 13);
            this.lbDate.TabIndex = 21;
            this.lbDate.Text = "Date";
            // 
            // txtIdCompte
            // 
            this.txtIdCompte.Location = new System.Drawing.Point(353, 51);
            this.txtIdCompte.Name = "txtIdCompte";
            this.txtIdCompte.Size = new System.Drawing.Size(141, 20);
            this.txtIdCompte.TabIndex = 20;
            // 
            // IdCompte
            // 
            this.IdCompte.AutoSize = true;
            this.IdCompte.Location = new System.Drawing.Point(235, 54);
            this.IdCompte.Name = "IdCompte";
            this.IdCompte.Size = new System.Drawing.Size(57, 13);
            this.IdCompte.TabIndex = 19;
            this.IdCompte.Text = "ID Compte";
            // 
            // txtIdMoyenPaiement
            // 
            this.txtIdMoyenPaiement.Location = new System.Drawing.Point(353, 17);
            this.txtIdMoyenPaiement.Name = "txtIdMoyenPaiement";
            this.txtIdMoyenPaiement.Size = new System.Drawing.Size(141, 20);
            this.txtIdMoyenPaiement.TabIndex = 18;
            // 
            // lbIdMoyenPaiement
            // 
            this.lbIdMoyenPaiement.AutoSize = true;
            this.lbIdMoyenPaiement.Location = new System.Drawing.Point(235, 23);
            this.lbIdMoyenPaiement.Name = "lbIdMoyenPaiement";
            this.lbIdMoyenPaiement.Size = new System.Drawing.Size(100, 13);
            this.lbIdMoyenPaiement.TabIndex = 17;
            this.lbIdMoyenPaiement.Text = "ID Moyen Paiement";
            // 
            // FenRechercheOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 468);
            this.Controls.Add(this.gbDonneesRecherche);
            this.Controls.Add(this.btVider);
            this.Controls.Add(this.btRechercher);
            this.Controls.Add(this.dgvLstClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FenRechercheOperation";
            this.Text = "Recherche Operation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstClient)).EndInit();
            this.gbDonneesRecherche.ResumeLayout(false);
            this.gbDonneesRecherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btVider;
        private System.Windows.Forms.Button btRechercher;
        private System.Windows.Forms.DataGridView dgvLstClient;
        private System.Windows.Forms.DateTimePicker dtDateDebut;
        private System.Windows.Forms.DateTimePicker dtDateFin;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox gbDonneesRecherche;
        private System.Windows.Forms.TextBox txtIdCompte;
        private System.Windows.Forms.Label IdCompte;
        private System.Windows.Forms.TextBox txtIdMoyenPaiement;
        private System.Windows.Forms.Label lbIdMoyenPaiement;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStatut;
        private System.Windows.Forms.ComboBox cbStatut;
    }
}