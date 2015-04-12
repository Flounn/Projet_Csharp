using System.Windows.Forms;
namespace DesktopIHM.GuiObjects
{
    partial class FenRechercheTypeCarte
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
            this.gbDonneesRecherche = new System.Windows.Forms.GroupBox();
            this.txtPeriodePlfGloRetrait = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlfGloRetrait = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeriodePlfGloPaiement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlfGloPaiement = new System.Windows.Forms.TextBox();
            this.lbPlfGloPaiement = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.cbReseau = new System.Windows.Forms.ComboBox();
            this.lbReseau = new System.Windows.Forms.Label();
            this.btVider = new System.Windows.Forms.Button();
            this.btRechercher = new System.Windows.Forms.Button();
            this.dgvLstTypeCarte = new System.Windows.Forms.DataGridView();
            this.btSelection = new System.Windows.Forms.Button();
            this.btAjouterTypeCarte = new System.Windows.Forms.Button();
            this.gbDonneesRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstTypeCarte)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDonneesRecherche
            // 
            this.gbDonneesRecherche.Controls.Add(this.txtPeriodePlfGloRetrait);
            this.gbDonneesRecherche.Controls.Add(this.label4);
            this.gbDonneesRecherche.Controls.Add(this.txtPlfGloRetrait);
            this.gbDonneesRecherche.Controls.Add(this.label2);
            this.gbDonneesRecherche.Controls.Add(this.txtPeriodePlfGloPaiement);
            this.gbDonneesRecherche.Controls.Add(this.label1);
            this.gbDonneesRecherche.Controls.Add(this.txtPlfGloPaiement);
            this.gbDonneesRecherche.Controls.Add(this.lbPlfGloPaiement);
            this.gbDonneesRecherche.Controls.Add(this.txtId);
            this.gbDonneesRecherche.Controls.Add(this.lbId);
            this.gbDonneesRecherche.Controls.Add(this.cbReseau);
            this.gbDonneesRecherche.Controls.Add(this.lbReseau);
            this.gbDonneesRecherche.Location = new System.Drawing.Point(12, 12);
            this.gbDonneesRecherche.Name = "gbDonneesRecherche";
            this.gbDonneesRecherche.Size = new System.Drawing.Size(523, 134);
            this.gbDonneesRecherche.TabIndex = 22;
            this.gbDonneesRecherche.TabStop = false;
            this.gbDonneesRecherche.Text = "Données de recherche";
            // 
            // txtPeriodePlfGloRetrait
            // 
            this.txtPeriodePlfGloRetrait.Location = new System.Drawing.Point(392, 100);
            this.txtPeriodePlfGloRetrait.Name = "txtPeriodePlfGloRetrait";
            this.txtPeriodePlfGloRetrait.Size = new System.Drawing.Size(116, 20);
            this.txtPeriodePlfGloRetrait.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Periode plafond global de retrait";
            // 
            // txtPlfGloRetrait
            // 
            this.txtPlfGloRetrait.Location = new System.Drawing.Point(392, 74);
            this.txtPlfGloRetrait.Name = "txtPlfGloRetrait";
            this.txtPlfGloRetrait.Size = new System.Drawing.Size(116, 20);
            this.txtPlfGloRetrait.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Plafond global de retrait";
            // 
            // txtPeriodePlfGloPaiement
            // 
            this.txtPeriodePlfGloPaiement.Location = new System.Drawing.Point(392, 48);
            this.txtPeriodePlfGloPaiement.Name = "txtPeriodePlfGloPaiement";
            this.txtPeriodePlfGloPaiement.Size = new System.Drawing.Size(116, 20);
            this.txtPeriodePlfGloPaiement.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Periode plafond global de paiement";
            // 
            // txtPlfGloPaiement
            // 
            this.txtPlfGloPaiement.Location = new System.Drawing.Point(392, 22);
            this.txtPlfGloPaiement.Name = "txtPlfGloPaiement";
            this.txtPlfGloPaiement.Size = new System.Drawing.Size(116, 20);
            this.txtPlfGloPaiement.TabIndex = 18;
            // 
            // lbPlfGloPaiement
            // 
            this.lbPlfGloPaiement.AutoSize = true;
            this.lbPlfGloPaiement.Location = new System.Drawing.Point(215, 25);
            this.lbPlfGloPaiement.Name = "lbPlfGloPaiement";
            this.lbPlfGloPaiement.Size = new System.Drawing.Size(135, 13);
            this.lbPlfGloPaiement.TabIndex = 17;
            this.lbPlfGloPaiement.Text = "Plafond global de paiement";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(93, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(116, 20);
            this.txtId.TabIndex = 16;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(3, 25);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(73, 13);
            this.lbId.TabIndex = 15;
            this.lbId.Text = "ID Type Carte";
            // 
            // cbReseau
            // 
            this.cbReseau.FormattingEnabled = true;
            this.cbReseau.Location = new System.Drawing.Point(93, 48);
            this.cbReseau.Name = "cbReseau";
            this.cbReseau.Size = new System.Drawing.Size(116, 21);
            this.cbReseau.TabIndex = 12;
            // 
            // lbReseau
            // 
            this.lbReseau.AutoSize = true;
            this.lbReseau.Location = new System.Drawing.Point(3, 51);
            this.lbReseau.Name = "lbReseau";
            this.lbReseau.Size = new System.Drawing.Size(44, 13);
            this.lbReseau.TabIndex = 2;
            this.lbReseau.Text = "Reseau";
            // 
            // btVider
            // 
            this.btVider.Location = new System.Drawing.Point(12, 152);
            this.btVider.Name = "btVider";
            this.btVider.Size = new System.Drawing.Size(128, 21);
            this.btVider.TabIndex = 21;
            this.btVider.Text = "Vider les champs";
            this.btVider.UseVisualStyleBackColor = true;
            this.btVider.Click += new System.EventHandler(this.btVider_Click);
            // 
            // btRechercher
            // 
            this.btRechercher.Location = new System.Drawing.Point(271, 152);
            this.btRechercher.Name = "btRechercher";
            this.btRechercher.Size = new System.Drawing.Size(264, 21);
            this.btRechercher.TabIndex = 20;
            this.btRechercher.Text = "Rechercher";
            this.btRechercher.UseVisualStyleBackColor = true;
            this.btRechercher.Click += new System.EventHandler(this.btRechercher_Click);
            // 
            // dgvLstTypeCarte
            // 
            this.dgvLstTypeCarte.AllowUserToAddRows = false;
            this.dgvLstTypeCarte.AllowUserToDeleteRows = false;
            this.dgvLstTypeCarte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLstTypeCarte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLstTypeCarte.Location = new System.Drawing.Point(12, 179);
            this.dgvLstTypeCarte.MultiSelect = false;
            this.dgvLstTypeCarte.Name = "dgvLstTypeCarte";
            this.dgvLstTypeCarte.ReadOnly = true;
            this.dgvLstTypeCarte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLstTypeCarte.Size = new System.Drawing.Size(523, 154);
            this.dgvLstTypeCarte.TabIndex = 23;
            this.dgvLstTypeCarte.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLstTypeCarte_CellContentDoubleClick);
            // 
            // btSelection
            // 
            this.btSelection.Location = new System.Drawing.Point(12, 339);
            this.btSelection.Name = "btSelection";
            this.btSelection.Size = new System.Drawing.Size(128, 21);
            this.btSelection.TabIndex = 24;
            this.btSelection.Text = "Choisir";
            this.btSelection.UseVisualStyleBackColor = true;
            this.btSelection.Click += new System.EventHandler(this.btSelection_Click);
            // 
            // btAjouterTypeCarte
            // 
            this.btAjouterTypeCarte.Location = new System.Drawing.Point(271, 339);
            this.btAjouterTypeCarte.Name = "btAjouterTypeCarte";
            this.btAjouterTypeCarte.Size = new System.Drawing.Size(264, 21);
            this.btAjouterTypeCarte.TabIndex = 25;
            this.btAjouterTypeCarte.Text = "Ajouter un Type Carte";
            this.btAjouterTypeCarte.UseVisualStyleBackColor = true;
            this.btAjouterTypeCarte.Click += new System.EventHandler(this.btAjouterTypeCarte_Click);
            // 
            // FenRechercheTypeCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 368);
            this.Controls.Add(this.btAjouterTypeCarte);
            this.Controls.Add(this.btSelection);
            this.Controls.Add(this.dgvLstTypeCarte);
            this.Controls.Add(this.gbDonneesRecherche);
            this.Controls.Add(this.btVider);
            this.Controls.Add(this.btRechercher);
            this.Name = "FenRechercheTypeCarte";
            this.ShowIcon = false;
            this.Text = "Rechercher Type Carte";
            this.gbDonneesRecherche.ResumeLayout(false);
            this.gbDonneesRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstTypeCarte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDonneesRecherche;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.ComboBox cbReseau;
        private System.Windows.Forms.Label lbReseau;
        private System.Windows.Forms.Button btVider;
        private System.Windows.Forms.Button btRechercher;
        private System.Windows.Forms.TextBox txtPeriodePlfGloPaiement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlfGloPaiement;
        private System.Windows.Forms.Label lbPlfGloPaiement;
        private System.Windows.Forms.TextBox txtPeriodePlfGloRetrait;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlfGloRetrait;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLstTypeCarte;
        private System.Windows.Forms.Button btSelection;
        private System.Windows.Forms.Button btAjouterTypeCarte;
    }
}