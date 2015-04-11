using System;
using System.Windows.Forms;
namespace DesktopIHM.GuiObjects
{
    partial class FenRechercheClient
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
            this.lbNom = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbDdn = new System.Windows.Forms.Label();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.dtDateNaissanceDebut = new System.Windows.Forms.DateTimePicker();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.dgvLstClient = new System.Windows.Forms.DataGridView();
            this.btRechercher = new System.Windows.Forms.Button();
            this.dtDateNaissanceFin = new System.Windows.Forms.DateTimePicker();
            this.cbDateNaissance = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.btDetail = new System.Windows.Forms.Button();
            this.btVider = new System.Windows.Forms.Button();
            this.gbDonneesRecherche = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstClient)).BeginInit();
            this.gbDonneesRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(10, 59);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(29, 13);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Location = new System.Drawing.Point(10, 103);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(43, 13);
            this.lbPrenom.TabIndex = 1;
            this.lbPrenom.Text = "Prénom";
            // 
            // lbDdn
            // 
            this.lbDdn.AutoSize = true;
            this.lbDdn.Location = new System.Drawing.Point(215, 59);
            this.lbDdn.Name = "lbDdn";
            this.lbDdn.Size = new System.Drawing.Size(83, 13);
            this.lbDdn.TabIndex = 2;
            this.lbDdn.Text = "Date Naissance";
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Location = new System.Drawing.Point(215, 103);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(45, 13);
            this.lbAdresse.TabIndex = 3;
            this.lbAdresse.Text = "Adresse";
            // 
            // dtDateNaissanceDebut
            // 
            this.dtDateNaissanceDebut.Enabled = false;
            this.dtDateNaissanceDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateNaissanceDebut.Location = new System.Drawing.Point(393, 57);
            this.dtDateNaissanceDebut.Name = "dtDateNaissanceDebut";
            this.dtDateNaissanceDebut.Size = new System.Drawing.Size(86, 20);
            this.dtDateNaissanceDebut.TabIndex = 4;
            this.dtDateNaissanceDebut.Value = new System.DateTime(2015, 4, 12, 0, 0, 0, 0);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(301, 99);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(178, 20);
            this.txtAdresse.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(57, 57);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(141, 20);
            this.txtNom.TabIndex = 6;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(57, 99);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(141, 20);
            this.txtPrenom.TabIndex = 7;
            // 
            // dgvLstClient
            // 
            this.dgvLstClient.AllowUserToAddRows = false;
            this.dgvLstClient.AllowUserToDeleteRows = false;
            this.dgvLstClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLstClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLstClient.Location = new System.Drawing.Point(37, 163);
            this.dgvLstClient.MultiSelect = false;
            this.dgvLstClient.Name = "dgvLstClient";
            this.dgvLstClient.ReadOnly = true;
            this.dgvLstClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLstClient.Size = new System.Drawing.Size(485, 237);
            this.dgvLstClient.TabIndex = 9;
            this.dgvLstClient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLstClient_CellDoubleClick);
            // 
            // btRechercher
            // 
            this.btRechercher.Location = new System.Drawing.Point(258, 136);
            this.btRechercher.Name = "btRechercher";
            this.btRechercher.Size = new System.Drawing.Size(264, 21);
            this.btRechercher.TabIndex = 10;
            this.btRechercher.Text = "Rechercher";
            this.btRechercher.UseVisualStyleBackColor = true;
            this.btRechercher.Click += new System.EventHandler(this.btRechercher_Click);
            // 
            // dtDateNaissanceFin
            // 
            this.dtDateNaissanceFin.Enabled = false;
            this.dtDateNaissanceFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateNaissanceFin.Location = new System.Drawing.Point(393, 77);
            this.dtDateNaissanceFin.Name = "dtDateNaissanceFin";
            this.dtDateNaissanceFin.Size = new System.Drawing.Size(86, 20);
            this.dtDateNaissanceFin.TabIndex = 11;
            this.dtDateNaissanceFin.Value = new System.DateTime(2015, 4, 12, 0, 0, 0, 0);
            this.dtDateNaissanceFin.Visible = false;
            // 
            // cbDateNaissance
            // 
            this.cbDateNaissance.FormattingEnabled = true;
            this.cbDateNaissance.Location = new System.Drawing.Point(301, 57);
            this.cbDateNaissance.Name = "cbDateNaissance";
            this.cbDateNaissance.Size = new System.Drawing.Size(86, 21);
            this.cbDateNaissance.TabIndex = 12;
            this.cbDateNaissance.SelectedIndexChanged += new System.EventHandler(this.cbDateNaissance_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(301, 18);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(215, 21);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 13;
            this.lbEmail.Text = "Email";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(57, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(141, 20);
            this.txtId.TabIndex = 16;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(10, 22);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 15;
            this.lbId.Text = "ID";
            // 
            // btDetail
            // 
            this.btDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDetail.Location = new System.Drawing.Point(148, 406);
            this.btDetail.Name = "btDetail";
            this.btDetail.Size = new System.Drawing.Size(264, 21);
            this.btDetail.TabIndex = 17;
            this.btDetail.Text = "Détail";
            this.btDetail.UseVisualStyleBackColor = true;
            this.btDetail.Click += new System.EventHandler(this.btDetail_Click);
            // 
            // btVider
            // 
            this.btVider.Location = new System.Drawing.Point(37, 136);
            this.btVider.Name = "btVider";
            this.btVider.Size = new System.Drawing.Size(128, 21);
            this.btVider.TabIndex = 18;
            this.btVider.Text = "Vider les champs";
            this.btVider.UseVisualStyleBackColor = true;
            this.btVider.Click += new System.EventHandler(this.btVider_Click);
            // 
            // gbDonneesRecherche
            // 
            this.gbDonneesRecherche.Controls.Add(this.txtId);
            this.gbDonneesRecherche.Controls.Add(this.lbId);
            this.gbDonneesRecherche.Controls.Add(this.txtEmail);
            this.gbDonneesRecherche.Controls.Add(this.lbEmail);
            this.gbDonneesRecherche.Controls.Add(this.cbDateNaissance);
            this.gbDonneesRecherche.Controls.Add(this.dtDateNaissanceFin);
            this.gbDonneesRecherche.Controls.Add(this.txtPrenom);
            this.gbDonneesRecherche.Controls.Add(this.txtNom);
            this.gbDonneesRecherche.Controls.Add(this.txtAdresse);
            this.gbDonneesRecherche.Controls.Add(this.dtDateNaissanceDebut);
            this.gbDonneesRecherche.Controls.Add(this.lbAdresse);
            this.gbDonneesRecherche.Controls.Add(this.lbDdn);
            this.gbDonneesRecherche.Controls.Add(this.lbPrenom);
            this.gbDonneesRecherche.Controls.Add(this.lbNom);
            this.gbDonneesRecherche.Location = new System.Drawing.Point(37, 3);
            this.gbDonneesRecherche.Name = "gbDonneesRecherche";
            this.gbDonneesRecherche.Size = new System.Drawing.Size(485, 127);
            this.gbDonneesRecherche.TabIndex = 19;
            this.gbDonneesRecherche.TabStop = false;
            this.gbDonneesRecherche.Text = "Données de recherche";
            // 
            // FenRechercheClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 429);
            this.Controls.Add(this.gbDonneesRecherche);
            this.Controls.Add(this.btVider);
            this.Controls.Add(this.btDetail);
            this.Controls.Add(this.btRechercher);
            this.Controls.Add(this.dgvLstClient);
            this.Name = "FenRechercheClient";
            this.ShowIcon = false;
            this.Text = "Rechercher Client";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstClient)).EndInit();
            this.gbDonneesRecherche.ResumeLayout(false);
            this.gbDonneesRecherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbDdn;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.DateTimePicker dtDateNaissanceDebut;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridView dgvLstClient;
        private System.Windows.Forms.Button btRechercher;
        private System.Windows.Forms.DateTimePicker dtDateNaissanceFin;
        private System.Windows.Forms.ComboBox cbDateNaissance;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btDetail;
        private Button btVider;
        private GroupBox gbDonneesRecherche;
    }
}