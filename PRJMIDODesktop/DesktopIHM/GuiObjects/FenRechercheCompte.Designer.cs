namespace DesktopIHM.GuiObjects
{
    partial class FenRechercheCompte
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
            this.lbDateSouscription = new System.Windows.Forms.Label();
            this.lbIntitule = new System.Windows.Forms.Label();
            this.dtDateOuvertureDebut = new System.Windows.Forms.DateTimePicker();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.dgwLstCompte = new System.Windows.Forms.DataGridView();
            this.btRechercher = new System.Windows.Forms.Button();
            this.dtDateOuvertureFin = new System.Windows.Forms.DateTimePicker();
            this.cbDateOuverture = new System.Windows.Forms.ComboBox();
            this.txtIdCompte = new System.Windows.Forms.TextBox();
            this.IdCompte = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.btVider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLstCompte)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdClient
            // 
            this.lbIdClient.AutoSize = true;
            this.lbIdClient.Location = new System.Drawing.Point(320, 29);
            this.lbIdClient.Name = "lbIdClient";
            this.lbIdClient.Size = new System.Drawing.Size(47, 13);
            this.lbIdClient.TabIndex = 0;
            this.lbIdClient.Text = "ID Client";
            // 
            // lbDateSouscription
            // 
            this.lbDateSouscription.AutoSize = true;
            this.lbDateSouscription.Location = new System.Drawing.Point(258, 70);
            this.lbDateSouscription.Name = "lbDateSouscription";
            this.lbDateSouscription.Size = new System.Drawing.Size(80, 13);
            this.lbDateSouscription.TabIndex = 2;
            this.lbDateSouscription.Text = "Date Ouverture";
            // 
            // lbIntitule
            // 
            this.lbIntitule.AutoSize = true;
            this.lbIntitule.Location = new System.Drawing.Point(34, 69);
            this.lbIntitule.Name = "lbIntitule";
            this.lbIntitule.Size = new System.Drawing.Size(31, 13);
            this.lbIntitule.TabIndex = 3;
            this.lbIntitule.Text = "Type";
            // 
            // dtDateOuvertureDebut
            // 
            this.dtDateOuvertureDebut.Enabled = false;
            this.dtDateOuvertureDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOuvertureDebut.Location = new System.Drawing.Point(436, 66);
            this.dtDateOuvertureDebut.Name = "dtDateOuvertureDebut";
            this.dtDateOuvertureDebut.Size = new System.Drawing.Size(86, 20);
            this.dtDateOuvertureDebut.TabIndex = 4;
            this.dtDateOuvertureDebut.Value = new System.DateTime(2015, 4, 12, 0, 0, 0, 0);
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(381, 26);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(141, 20);
            this.txtIdClient.TabIndex = 6;
            // 
            // dgwLstCompte
            // 
            this.dgwLstCompte.AllowUserToAddRows = false;
            this.dgwLstCompte.AllowUserToDeleteRows = false;
            this.dgwLstCompte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwLstCompte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLstCompte.Location = new System.Drawing.Point(37, 167);
            this.dgwLstCompte.MultiSelect = false;
            this.dgwLstCompte.Name = "dgwLstCompte";
            this.dgwLstCompte.ReadOnly = true;
            this.dgwLstCompte.Size = new System.Drawing.Size(485, 233);
            this.dgwLstCompte.TabIndex = 9;
            // 
            // btRechercher
            // 
            this.btRechercher.Location = new System.Drawing.Point(258, 119);
            this.btRechercher.Name = "btRechercher";
            this.btRechercher.Size = new System.Drawing.Size(264, 21);
            this.btRechercher.TabIndex = 10;
            this.btRechercher.Text = "Rechercher";
            this.btRechercher.UseVisualStyleBackColor = true;
            this.btRechercher.Click += new System.EventHandler(this.btRechercher_Click);
            // 
            // dtDateOuvertureFin
            // 
            this.dtDateOuvertureFin.Enabled = false;
            this.dtDateOuvertureFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOuvertureFin.Location = new System.Drawing.Point(436, 86);
            this.dtDateOuvertureFin.Name = "dtDateOuvertureFin";
            this.dtDateOuvertureFin.Size = new System.Drawing.Size(86, 20);
            this.dtDateOuvertureFin.TabIndex = 11;
            this.dtDateOuvertureFin.Value = new System.DateTime(2015, 4, 12, 0, 0, 0, 0);
            this.dtDateOuvertureFin.Visible = false;
            // 
            // cbDateOuverture
            // 
            this.cbDateOuverture.FormattingEnabled = true;
            this.cbDateOuverture.Location = new System.Drawing.Point(344, 66);
            this.cbDateOuverture.Name = "cbDateOuverture";
            this.cbDateOuverture.Size = new System.Drawing.Size(86, 21);
            this.cbDateOuverture.TabIndex = 12;
            this.cbDateOuverture.SelectedIndexChanged += new System.EventHandler(this.cbDateOuverture_SelectedIndexChanged);
            // 
            // txtIdCompte
            // 
            this.txtIdCompte.Location = new System.Drawing.Point(97, 26);
            this.txtIdCompte.Name = "txtIdCompte";
            this.txtIdCompte.Size = new System.Drawing.Size(135, 20);
            this.txtIdCompte.TabIndex = 14;
            // 
            // IdCompte
            // 
            this.IdCompte.AutoSize = true;
            this.IdCompte.Location = new System.Drawing.Point(34, 29);
            this.IdCompte.Name = "IdCompte";
            this.IdCompte.Size = new System.Drawing.Size(57, 13);
            this.IdCompte.TabIndex = 13;
            this.IdCompte.Text = "ID Compte";
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(97, 66);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(135, 21);
            this.cb_type.TabIndex = 18;
            // 
            // btVider
            // 
            this.btVider.Location = new System.Drawing.Point(37, 119);
            this.btVider.Name = "btVider";
            this.btVider.Size = new System.Drawing.Size(128, 21);
            this.btVider.TabIndex = 20;
            this.btVider.Text = "Vider les champs";
            this.btVider.UseVisualStyleBackColor = true;
            this.btVider.Click += new System.EventHandler(this.btVider_Click);
            // 
            // FenRechercheCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 429);
            this.Controls.Add(this.btVider);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.txtIdCompte);
            this.Controls.Add(this.IdCompte);
            this.Controls.Add(this.cbDateOuverture);
            this.Controls.Add(this.dtDateOuvertureFin);
            this.Controls.Add(this.btRechercher);
            this.Controls.Add(this.dgwLstCompte);
            this.Controls.Add(this.txtIdClient);
            this.Controls.Add(this.dtDateOuvertureDebut);
            this.Controls.Add(this.lbIntitule);
            this.Controls.Add(this.lbDateSouscription);
            this.Controls.Add(this.lbIdClient);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FenRechercheCompte";
            this.Text = "Rechercher Compte";
            ((System.ComponentModel.ISupportInitialize)(this.dgwLstCompte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdClient;
        private System.Windows.Forms.Label lbDateSouscription;
        private System.Windows.Forms.Label lbIntitule;
        private System.Windows.Forms.DateTimePicker dtDateOuvertureDebut;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.DataGridView dgwLstCompte;
        private System.Windows.Forms.Button btRechercher;
        private System.Windows.Forms.DateTimePicker dtDateOuvertureFin;
        private System.Windows.Forms.ComboBox cbDateOuverture;
        private System.Windows.Forms.TextBox txtIdCompte;
        private System.Windows.Forms.Label IdCompte;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button btVider;
    }
}