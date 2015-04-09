﻿namespace DesktopIHM.GuiObjects
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
            this.lbIdClient = new System.Windows.Forms.Label();
            this.lbIdProduit = new System.Windows.Forms.Label();
            this.lbDateSouscription = new System.Windows.Forms.Label();
            this.lbIntitule = new System.Windows.Forms.Label();
            this.dtDateSouscriptionDebut = new System.Windows.Forms.DateTimePicker();
            this.txtIntitule = new System.Windows.Forms.TextBox();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.txtIdProduit = new System.Windows.Forms.TextBox();
            this.dgwLstContrat = new System.Windows.Forms.DataGridView();
            this.btRechercher = new System.Windows.Forms.Button();
            this.dtDateSouscriptionFin = new System.Windows.Forms.DateTimePicker();
            this.cbDateSouscription = new System.Windows.Forms.ComboBox();
            this.txtIdCompte = new System.Windows.Forms.TextBox();
            this.lbIdCompte = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.btDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLstContrat)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdClient
            // 
            this.lbIdClient.AutoSize = true;
            this.lbIdClient.Location = new System.Drawing.Point(34, 71);
            this.lbIdClient.Name = "lbIdClient";
            this.lbIdClient.Size = new System.Drawing.Size(29, 13);
            this.lbIdClient.TabIndex = 0;
            this.lbIdClient.Text = "Nom";
            // 
            // lbIdProduit
            // 
            this.lbIdProduit.AutoSize = true;
            this.lbIdProduit.Location = new System.Drawing.Point(34, 111);
            this.lbIdProduit.Name = "lbIdProduit";
            this.lbIdProduit.Size = new System.Drawing.Size(43, 13);
            this.lbIdProduit.TabIndex = 1;
            this.lbIdProduit.Text = "Prénom";
            // 
            // lbDateSouscription
            // 
            this.lbDateSouscription.AutoSize = true;
            this.lbDateSouscription.Location = new System.Drawing.Point(255, 70);
            this.lbDateSouscription.Name = "lbDateSouscription";
            this.lbDateSouscription.Size = new System.Drawing.Size(83, 13);
            this.lbDateSouscription.TabIndex = 2;
            this.lbDateSouscription.Text = "Date Naissance";
            // 
            // lbIntitule
            // 
            this.lbIntitule.AutoSize = true;
            this.lbIntitule.Location = new System.Drawing.Point(255, 111);
            this.lbIntitule.Name = "lbIntitule";
            this.lbIntitule.Size = new System.Drawing.Size(45, 13);
            this.lbIntitule.TabIndex = 3;
            this.lbIntitule.Text = "Adresse";
            // 
            // dtDateSouscriptionDebut
            // 
            this.dtDateSouscriptionDebut.Enabled = false;
            this.dtDateSouscriptionDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateSouscriptionDebut.Location = new System.Drawing.Point(436, 66);
            this.dtDateSouscriptionDebut.Name = "dtDateSouscriptionDebut";
            this.dtDateSouscriptionDebut.Size = new System.Drawing.Size(86, 20);
            this.dtDateSouscriptionDebut.TabIndex = 4;
            this.dtDateSouscriptionDebut.Value = new System.DateTime(2015, 4, 8, 18, 8, 0, 0);
            // 
            // txtIntitule
            // 
            this.txtIntitule.Location = new System.Drawing.Point(344, 108);
            this.txtIntitule.Name = "txtIntitule";
            this.txtIntitule.Size = new System.Drawing.Size(178, 20);
            this.txtIntitule.TabIndex = 5;
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(81, 67);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(141, 20);
            this.txtIdClient.TabIndex = 6;
            // 
            // txtIdProduit
            // 
            this.txtIdProduit.Location = new System.Drawing.Point(81, 108);
            this.txtIdProduit.Name = "txtIdProduit";
            this.txtIdProduit.Size = new System.Drawing.Size(141, 20);
            this.txtIdProduit.TabIndex = 7;
            // 
            // dgwLstContrat
            // 
            this.dgwLstContrat.AllowUserToAddRows = false;
            this.dgwLstContrat.AllowUserToDeleteRows = false;
            this.dgwLstContrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLstContrat.Location = new System.Drawing.Point(37, 186);
            this.dgwLstContrat.MultiSelect = false;
            this.dgwLstContrat.Name = "dgwLstContrat";
            this.dgwLstContrat.ReadOnly = true;
            this.dgwLstContrat.Size = new System.Drawing.Size(485, 207);
            this.dgwLstContrat.TabIndex = 9;
            // 
            // btRechercher
            // 
            this.btRechercher.Location = new System.Drawing.Point(258, 145);
            this.btRechercher.Name = "btRechercher";
            this.btRechercher.Size = new System.Drawing.Size(264, 21);
            this.btRechercher.TabIndex = 10;
            this.btRechercher.Text = "Rechercher";
            this.btRechercher.UseVisualStyleBackColor = true;
            this.btRechercher.Click += new System.EventHandler(this.btRechercher_Click);
            // 
            // dtDateSouscriptionFin
            // 
            this.dtDateSouscriptionFin.Enabled = false;
            this.dtDateSouscriptionFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateSouscriptionFin.Location = new System.Drawing.Point(436, 86);
            this.dtDateSouscriptionFin.Name = "dtDateSouscriptionFin";
            this.dtDateSouscriptionFin.Size = new System.Drawing.Size(86, 20);
            this.dtDateSouscriptionFin.TabIndex = 11;
            this.dtDateSouscriptionFin.Value = new System.DateTime(2015, 4, 8, 18, 8, 0, 0);
            this.dtDateSouscriptionFin.Visible = false;
            // 
            // cbDateSouscription
            // 
            this.cbDateSouscription.FormattingEnabled = true;
            this.cbDateSouscription.Location = new System.Drawing.Point(344, 66);
            this.cbDateSouscription.Name = "cbDateSouscription";
            this.cbDateSouscription.Size = new System.Drawing.Size(86, 21);
            this.cbDateSouscription.TabIndex = 12;
            this.cbDateSouscription.SelectedIndexChanged += new System.EventHandler(this.cbDateSouscription_SelectedIndexChanged);
            // 
            // txtIdCompte
            // 
            this.txtIdCompte.Location = new System.Drawing.Point(344, 26);
            this.txtIdCompte.Name = "txtIdCompte";
            this.txtIdCompte.Size = new System.Drawing.Size(178, 20);
            this.txtIdCompte.TabIndex = 14;
            // 
            // lbIdCompte
            // 
            this.lbIdCompte.AutoSize = true;
            this.lbIdCompte.Location = new System.Drawing.Point(255, 30);
            this.lbIdCompte.Name = "lbIdCompte";
            this.lbIdCompte.Size = new System.Drawing.Size(32, 13);
            this.lbIdCompte.TabIndex = 13;
            this.lbIdCompte.Text = "Email";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(81, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(141, 20);
            this.txtId.TabIndex = 16;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(34, 31);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 15;
            this.lbId.Text = "ID";
            // 
            // btDetail
            // 
            this.btDetail.Location = new System.Drawing.Point(148, 399);
            this.btDetail.Name = "btDetail";
            this.btDetail.Size = new System.Drawing.Size(264, 21);
            this.btDetail.TabIndex = 17;
            this.btDetail.Text = "Détail";
            this.btDetail.UseVisualStyleBackColor = true;
            // 
            // FenRechercheClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 429);
            this.Controls.Add(this.btDetail);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txtIdCompte);
            this.Controls.Add(this.lbIdCompte);
            this.Controls.Add(this.cbDateSouscription);
            this.Controls.Add(this.dtDateSouscriptionFin);
            this.Controls.Add(this.btRechercher);
            this.Controls.Add(this.dgwLstContrat);
            this.Controls.Add(this.txtIdProduit);
            this.Controls.Add(this.txtIdClient);
            this.Controls.Add(this.txtIntitule);
            this.Controls.Add(this.dtDateSouscriptionDebut);
            this.Controls.Add(this.lbIntitule);
            this.Controls.Add(this.lbDateSouscription);
            this.Controls.Add(this.lbIdProduit);
            this.Controls.Add(this.lbIdClient);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FenRechercheClient";
            this.Text = "Rechercher un client";
            ((System.ComponentModel.ISupportInitialize)(this.dgwLstContrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdProduit;
        private System.Windows.Forms.Label lbIdClient;
        private System.Windows.Forms.Label lbDateSouscription;
        private System.Windows.Forms.Label lbIntitule;
        private System.Windows.Forms.DateTimePicker dtDateSouscriptionDebut;
        private System.Windows.Forms.TextBox txtIntitule;
        private System.Windows.Forms.TextBox txtIdProduit;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.DataGridView dgwLstContrat;
        private System.Windows.Forms.Button btRechercher;
        private System.Windows.Forms.DateTimePicker dtDateSouscriptionFin;
        private System.Windows.Forms.ComboBox cbDateSouscription;
        private System.Windows.Forms.TextBox txtIdCompte;
        private System.Windows.Forms.Label lbIdCompte;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btDetail;
    }
}