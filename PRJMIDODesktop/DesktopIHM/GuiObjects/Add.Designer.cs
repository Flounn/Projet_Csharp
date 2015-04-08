namespace DesktopIHM.GuiObjects
{
    partial class fenRechercheClient
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
            this.lbDateNaissance = new System.Windows.Forms.Label();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.dtDataNaissance = new System.Windows.Forms.DateTimePicker();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.dgwLstClient = new System.Windows.Forms.DataGridView();
            this.btRechercher = new System.Windows.Forms.Button();
            this.dtDateNaissanceAux = new System.Windows.Forms.DateTimePicker();
            this.cbDateNaissance = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.btDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLstClient)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(34, 71);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(29, 13);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom";
            this.lbNom.Click += new System.EventHandler(this.lbNom_Click);
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Location = new System.Drawing.Point(34, 111);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(43, 13);
            this.lbPrenom.TabIndex = 1;
            this.lbPrenom.Text = "Prénom";
            // 
            // lbDateNaissance
            // 
            this.lbDateNaissance.AutoSize = true;
            this.lbDateNaissance.Location = new System.Drawing.Point(255, 70);
            this.lbDateNaissance.Name = "lbDateNaissance";
            this.lbDateNaissance.Size = new System.Drawing.Size(83, 13);
            this.lbDateNaissance.TabIndex = 2;
            this.lbDateNaissance.Text = "Date Naissance";
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Location = new System.Drawing.Point(255, 111);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(45, 13);
            this.lbAdresse.TabIndex = 3;
            this.lbAdresse.Text = "Adresse";
            // 
            // dtDataNaissance
            // 
            this.dtDataNaissance.Enabled = false;
            this.dtDataNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNaissance.Location = new System.Drawing.Point(436, 66);
            this.dtDataNaissance.Name = "dtDataNaissance";
            this.dtDataNaissance.Size = new System.Drawing.Size(86, 20);
            this.dtDataNaissance.TabIndex = 4;
            this.dtDataNaissance.Value = new System.DateTime(2015, 4, 8, 18, 8, 0, 0);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(344, 108);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(178, 20);
            this.txtAdresse.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(81, 67);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(141, 20);
            this.txtNom.TabIndex = 6;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(81, 108);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(141, 20);
            this.txtPrenom.TabIndex = 7;
            // 
            // dgwLstClient
            // 
            this.dgwLstClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLstClient.Location = new System.Drawing.Point(37, 186);
            this.dgwLstClient.Name = "dgwLstClient";
            this.dgwLstClient.Size = new System.Drawing.Size(485, 207);
            this.dgwLstClient.TabIndex = 9;
            this.dgwLstClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwLstClient_CellContentClick);
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
            // dtDateNaissanceAux
            // 
            this.dtDateNaissanceAux.Enabled = false;
            this.dtDateNaissanceAux.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateNaissanceAux.Location = new System.Drawing.Point(436, 86);
            this.dtDateNaissanceAux.Name = "dtDateNaissanceAux";
            this.dtDateNaissanceAux.Size = new System.Drawing.Size(86, 20);
            this.dtDateNaissanceAux.TabIndex = 11;
            this.dtDateNaissanceAux.Value = new System.DateTime(2015, 4, 8, 18, 8, 0, 0);
            this.dtDateNaissanceAux.Visible = false;
            // 
            // cbDateNaissance
            // 
            this.cbDateNaissance.FormattingEnabled = true;
            this.cbDateNaissance.Location = new System.Drawing.Point(344, 66);
            this.cbDateNaissance.Name = "cbDateNaissance";
            this.cbDateNaissance.Size = new System.Drawing.Size(86, 21);
            this.cbDateNaissance.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 14;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(255, 30);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(32, 13);
            this.lbMail.TabIndex = 13;
            this.lbMail.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 16;
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
            // fenRechercheClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 429);
            this.Controls.Add(this.btDetail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.cbDateNaissance);
            this.Controls.Add(this.dtDateNaissanceAux);
            this.Controls.Add(this.btRechercher);
            this.Controls.Add(this.dgwLstClient);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.dtDataNaissance);
            this.Controls.Add(this.lbAdresse);
            this.Controls.Add(this.lbDateNaissance);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.lbNom);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "fenRechercheClient";
            this.Text = "Rechercher un client";
            this.Load += new System.EventHandler(this.fenRechercheClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLstClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbDateNaissance;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.DateTimePicker dtDataNaissance;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.DataGridView dgwLstClient;
        private System.Windows.Forms.Button btRechercher;
        private System.Windows.Forms.DateTimePicker dtDateNaissanceAux;
        private System.Windows.Forms.ComboBox cbDateNaissance;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btDetail;
    }
}