namespace DesktopIHM.GuiObjects
{
    partial class FenSaisirMoyenPaiement
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
            this.lbIdCompte = new System.Windows.Forms.Label();
            this.gbCheque = new System.Windows.Forms.GroupBox();
            this.cbNbCheques = new System.Windows.Forms.ComboBox();
            this.txtNbDernierCheque = new System.Windows.Forms.TextBox();
            this.txtNbPremierCheque = new System.Windows.Forms.TextBox();
            this.nbDrnCheque = new System.Windows.Forms.Label();
            this.lbNbPrCheque = new System.Windows.Forms.Label();
            this.lbNbCheque = new System.Windows.Forms.Label();
            this.gbCarteBancaire = new System.Windows.Forms.GroupBox();
            this.txtNoCarte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdTypeCarte = new System.Windows.Forms.TextBox();
            this.btTypeCarte = new System.Windows.Forms.Button();
            this.lbTypeCarte = new System.Windows.Forms.Label();
            this.dtDateFin = new System.Windows.Forms.DateTimePicker();
            this.lbDateFin = new System.Windows.Forms.Label();
            this.dtDateDebut = new System.Windows.Forms.DateTimePicker();
            this.lbDateDebut = new System.Windows.Forms.Label();
            this.rbChequier = new System.Windows.Forms.RadioButton();
            this.rbCarteBancaire = new System.Windows.Forms.RadioButton();
            this.txtIdCompte = new System.Windows.Forms.TextBox();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.btAjoutMoyenPaiement = new System.Windows.Forms.Button();
            this.gbCheque.SuspendLayout();
            this.gbCarteBancaire.SuspendLayout();
            this.gbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIdCompte
            // 
            this.lbIdCompte.AutoSize = true;
            this.lbIdCompte.Location = new System.Drawing.Point(29, 18);
            this.lbIdCompte.Name = "lbIdCompte";
            this.lbIdCompte.Size = new System.Drawing.Size(52, 13);
            this.lbIdCompte.TabIndex = 1;
            this.lbIdCompte.Text = "IdCompte";
            // 
            // gbCheque
            // 
            this.gbCheque.Controls.Add(this.cbNbCheques);
            this.gbCheque.Controls.Add(this.txtNbDernierCheque);
            this.gbCheque.Controls.Add(this.txtNbPremierCheque);
            this.gbCheque.Controls.Add(this.nbDrnCheque);
            this.gbCheque.Controls.Add(this.lbNbPrCheque);
            this.gbCheque.Controls.Add(this.lbNbCheque);
            this.gbCheque.Location = new System.Drawing.Point(26, 96);
            this.gbCheque.Name = "gbCheque";
            this.gbCheque.Size = new System.Drawing.Size(256, 137);
            this.gbCheque.TabIndex = 2;
            this.gbCheque.TabStop = false;
            this.gbCheque.Text = "Chequier";
            // 
            // cbNbCheques
            // 
            this.cbNbCheques.FormattingEnabled = true;
            this.cbNbCheques.Location = new System.Drawing.Point(137, 33);
            this.cbNbCheques.Name = "cbNbCheques";
            this.cbNbCheques.Size = new System.Drawing.Size(98, 21);
            this.cbNbCheques.TabIndex = 9;
            // 
            // txtNbDernierCheque
            // 
            this.txtNbDernierCheque.Enabled = false;
            this.txtNbDernierCheque.Location = new System.Drawing.Point(137, 86);
            this.txtNbDernierCheque.Name = "txtNbDernierCheque";
            this.txtNbDernierCheque.Size = new System.Drawing.Size(98, 20);
            this.txtNbDernierCheque.TabIndex = 6;
            // 
            // txtNbPremierCheque
            // 
            this.txtNbPremierCheque.Enabled = false;
            this.txtNbPremierCheque.Location = new System.Drawing.Point(137, 60);
            this.txtNbPremierCheque.Name = "txtNbPremierCheque";
            this.txtNbPremierCheque.Size = new System.Drawing.Size(98, 20);
            this.txtNbPremierCheque.TabIndex = 5;
            // 
            // nbDrnCheque
            // 
            this.nbDrnCheque.AutoSize = true;
            this.nbDrnCheque.Location = new System.Drawing.Point(25, 89);
            this.nbDrnCheque.Name = "nbDrnCheque";
            this.nbDrnCheque.Size = new System.Drawing.Size(98, 13);
            this.nbDrnCheque.TabIndex = 3;
            this.nbDrnCheque.Text = "Nb Dernier Cheque";
            // 
            // lbNbPrCheque
            // 
            this.lbNbPrCheque.AutoSize = true;
            this.lbNbPrCheque.Location = new System.Drawing.Point(25, 64);
            this.lbNbPrCheque.Name = "lbNbPrCheque";
            this.lbNbPrCheque.Size = new System.Drawing.Size(99, 13);
            this.lbNbPrCheque.TabIndex = 2;
            this.lbNbPrCheque.Text = "Nb Premier Cheque";
            // 
            // lbNbCheque
            // 
            this.lbNbCheque.AutoSize = true;
            this.lbNbCheque.Location = new System.Drawing.Point(25, 38);
            this.lbNbCheque.Name = "lbNbCheque";
            this.lbNbCheque.Size = new System.Drawing.Size(66, 13);
            this.lbNbCheque.TabIndex = 1;
            this.lbNbCheque.Text = "Nb Cheques";
            // 
            // gbCarteBancaire
            // 
            this.gbCarteBancaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCarteBancaire.Controls.Add(this.txtNoCarte);
            this.gbCarteBancaire.Controls.Add(this.label1);
            this.gbCarteBancaire.Controls.Add(this.txtIdTypeCarte);
            this.gbCarteBancaire.Controls.Add(this.btTypeCarte);
            this.gbCarteBancaire.Controls.Add(this.lbTypeCarte);
            this.gbCarteBancaire.Controls.Add(this.dtDateFin);
            this.gbCarteBancaire.Controls.Add(this.lbDateFin);
            this.gbCarteBancaire.Controls.Add(this.dtDateDebut);
            this.gbCarteBancaire.Controls.Add(this.lbDateDebut);
            this.gbCarteBancaire.Enabled = false;
            this.gbCarteBancaire.Location = new System.Drawing.Point(286, 96);
            this.gbCarteBancaire.Name = "gbCarteBancaire";
            this.gbCarteBancaire.Size = new System.Drawing.Size(275, 137);
            this.gbCarteBancaire.TabIndex = 3;
            this.gbCarteBancaire.TabStop = false;
            this.gbCarteBancaire.Text = "Carte bancaire";
            // 
            // txtNoCarte
            // 
            this.txtNoCarte.Location = new System.Drawing.Point(120, 84);
            this.txtNoCarte.Name = "txtNoCarte";
            this.txtNoCarte.Size = new System.Drawing.Size(121, 20);
            this.txtNoCarte.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "No Carte";
            // 
            // txtIdTypeCarte
            // 
            this.txtIdTypeCarte.Location = new System.Drawing.Point(120, 110);
            this.txtIdTypeCarte.Name = "txtIdTypeCarte";
            this.txtIdTypeCarte.Size = new System.Drawing.Size(121, 20);
            this.txtIdTypeCarte.TabIndex = 10;
            // 
            // btTypeCarte
            // 
            this.btTypeCarte.Location = new System.Drawing.Point(241, 109);
            this.btTypeCarte.Name = "btTypeCarte";
            this.btTypeCarte.Size = new System.Drawing.Size(28, 22);
            this.btTypeCarte.TabIndex = 9;
            this.btTypeCarte.Text = "+";
            this.btTypeCarte.UseVisualStyleBackColor = true;
            this.btTypeCarte.Click += new System.EventHandler(this.btTypeCarte_Click);
            // 
            // lbTypeCarte
            // 
            this.lbTypeCarte.AutoSize = true;
            this.lbTypeCarte.Location = new System.Drawing.Point(33, 113);
            this.lbTypeCarte.Name = "lbTypeCarte";
            this.lbTypeCarte.Size = new System.Drawing.Size(59, 13);
            this.lbTypeCarte.TabIndex = 4;
            this.lbTypeCarte.Text = "Type Carte";
            // 
            // dtDateFin
            // 
            this.dtDateFin.Enabled = false;
            this.dtDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateFin.Location = new System.Drawing.Point(120, 58);
            this.dtDateFin.Name = "dtDateFin";
            this.dtDateFin.Size = new System.Drawing.Size(121, 20);
            this.dtDateFin.TabIndex = 7;
            this.dtDateFin.Value = new System.DateTime(2015, 4, 10, 0, 0, 0, 0);
            // 
            // lbDateFin
            // 
            this.lbDateFin.AutoSize = true;
            this.lbDateFin.Location = new System.Drawing.Point(34, 61);
            this.lbDateFin.Name = "lbDateFin";
            this.lbDateFin.Size = new System.Drawing.Size(44, 13);
            this.lbDateFin.TabIndex = 6;
            this.lbDateFin.Text = "Date fin";
            // 
            // dtDateDebut
            // 
            this.dtDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateDebut.Location = new System.Drawing.Point(120, 32);
            this.dtDateDebut.Name = "dtDateDebut";
            this.dtDateDebut.Size = new System.Drawing.Size(121, 20);
            this.dtDateDebut.TabIndex = 5;
            this.dtDateDebut.Value = new System.DateTime(2015, 4, 10, 0, 0, 0, 0);
            // 
            // lbDateDebut
            // 
            this.lbDateDebut.AutoSize = true;
            this.lbDateDebut.Location = new System.Drawing.Point(34, 35);
            this.lbDateDebut.Name = "lbDateDebut";
            this.lbDateDebut.Size = new System.Drawing.Size(60, 13);
            this.lbDateDebut.TabIndex = 2;
            this.lbDateDebut.Text = "Date début";
            // 
            // rbChequier
            // 
            this.rbChequier.AutoSize = true;
            this.rbChequier.Location = new System.Drawing.Point(28, 19);
            this.rbChequier.Name = "rbChequier";
            this.rbChequier.Size = new System.Drawing.Size(67, 17);
            this.rbChequier.TabIndex = 4;
            this.rbChequier.TabStop = true;
            this.rbChequier.Text = "Chequier";
            this.rbChequier.UseVisualStyleBackColor = true;
            this.rbChequier.CheckedChanged += new System.EventHandler(this.rbChequier_CheckedChanged);
            // 
            // rbCarteBancaire
            // 
            this.rbCarteBancaire.AutoSize = true;
            this.rbCarteBancaire.Location = new System.Drawing.Point(137, 19);
            this.rbCarteBancaire.Name = "rbCarteBancaire";
            this.rbCarteBancaire.Size = new System.Drawing.Size(95, 17);
            this.rbCarteBancaire.TabIndex = 5;
            this.rbCarteBancaire.TabStop = true;
            this.rbCarteBancaire.Text = "Carte Bancaire";
            this.rbCarteBancaire.UseVisualStyleBackColor = true;
            // 
            // txtIdCompte
            // 
            this.txtIdCompte.Enabled = false;
            this.txtIdCompte.Location = new System.Drawing.Point(114, 15);
            this.txtIdCompte.Name = "txtIdCompte";
            this.txtIdCompte.Size = new System.Drawing.Size(168, 20);
            this.txtIdCompte.TabIndex = 10;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbChequier);
            this.gbType.Controls.Add(this.rbCarteBancaire);
            this.gbType.Location = new System.Drawing.Point(26, 44);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(256, 46);
            this.gbType.TabIndex = 11;
            this.gbType.TabStop = false;
            this.gbType.Text = "Type";
            // 
            // btAjoutMoyenPaiement
            // 
            this.btAjoutMoyenPaiement.Location = new System.Drawing.Point(406, 53);
            this.btAjoutMoyenPaiement.Name = "btAjoutMoyenPaiement";
            this.btAjoutMoyenPaiement.Size = new System.Drawing.Size(155, 27);
            this.btAjoutMoyenPaiement.TabIndex = 12;
            this.btAjoutMoyenPaiement.Text = "Ajouter le moyen de paiement";
            this.btAjoutMoyenPaiement.UseVisualStyleBackColor = true;
            this.btAjoutMoyenPaiement.Click += new System.EventHandler(this.btAjoutMoyenPaiement_Click);
            // 
            // FenSaisirMoyenPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 245);
            this.Controls.Add(this.btAjoutMoyenPaiement);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.txtIdCompte);
            this.Controls.Add(this.gbCarteBancaire);
            this.Controls.Add(this.gbCheque);
            this.Controls.Add(this.lbIdCompte);
            this.Name = "FenSaisirMoyenPaiement";
            this.ShowIcon = false;
            this.Text = "Ajouter Moyen Paiement";
            this.gbCheque.ResumeLayout(false);
            this.gbCheque.PerformLayout();
            this.gbCarteBancaire.ResumeLayout(false);
            this.gbCarteBancaire.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdCompte;
        private System.Windows.Forms.GroupBox gbCheque;
        private System.Windows.Forms.GroupBox gbCarteBancaire;
        private System.Windows.Forms.Label nbDrnCheque;
        private System.Windows.Forms.Label lbNbPrCheque;
        private System.Windows.Forms.Label lbNbCheque;
        private System.Windows.Forms.Label lbDateDebut;
        private System.Windows.Forms.ComboBox cbNbCheques;
        private System.Windows.Forms.TextBox txtNbDernierCheque;
        private System.Windows.Forms.TextBox txtNbPremierCheque;
        private System.Windows.Forms.Label lbTypeCarte;
        private System.Windows.Forms.DateTimePicker dtDateFin;
        private System.Windows.Forms.Label lbDateFin;
        private System.Windows.Forms.DateTimePicker dtDateDebut;
        private System.Windows.Forms.RadioButton rbChequier;
        private System.Windows.Forms.RadioButton rbCarteBancaire;
        private System.Windows.Forms.TextBox txtIdCompte;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.Button btTypeCarte;
        private System.Windows.Forms.TextBox txtIdTypeCarte;
        private System.Windows.Forms.TextBox txtNoCarte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAjoutMoyenPaiement;
    }
}