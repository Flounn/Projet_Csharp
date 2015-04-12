namespace DesktopIHM.GuiObjects
{
    partial class FenSaisirContrat
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
            this.bt_creer = new System.Windows.Forms.Button();
            this.rbEpargne = new System.Windows.Forms.RadioButton();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.gb_type_compte = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.txtIdCompte = new System.Windows.Forms.TextBox();
            this.gb_credit = new System.Windows.Forms.GroupBox();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTaux = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCreditMontant = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObjet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gb_epargne = new System.Windows.Forms.GroupBox();
            this.dtVersement = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEpargneMontant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbVersement = new System.Windows.Forms.GroupBox();
            this.rbPeriodique = new System.Windows.Forms.RadioButton();
            this.rbPonctuel = new System.Windows.Forms.RadioButton();
            this.cbPeriodicite = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTypeEpargne = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbContrat = new System.Windows.Forms.GroupBox();
            this.cbStatut = new System.Windows.Forms.ComboBox();
            this.txtIntitule = new System.Windows.Forms.TextBox();
            this.lbIntitule = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_vider = new System.Windows.Forms.Button();
            this.gb_type_compte.SuspendLayout();
            this.gb_credit.SuspendLayout();
            this.gb_epargne.SuspendLayout();
            this.gbVersement.SuspendLayout();
            this.gbContrat.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_creer
            // 
            this.bt_creer.Location = new System.Drawing.Point(285, 368);
            this.bt_creer.Name = "bt_creer";
            this.bt_creer.Size = new System.Drawing.Size(101, 23);
            this.bt_creer.TabIndex = 0;
            this.bt_creer.Text = "Créer";
            this.bt_creer.UseVisualStyleBackColor = true;
            this.bt_creer.Click += new System.EventHandler(this.bt_creer_Click);
            // 
            // rbEpargne
            // 
            this.rbEpargne.AutoSize = true;
            this.rbEpargne.Location = new System.Drawing.Point(132, 30);
            this.rbEpargne.Name = "rbEpargne";
            this.rbEpargne.Size = new System.Drawing.Size(65, 17);
            this.rbEpargne.TabIndex = 2;
            this.rbEpargne.Text = "Epargne";
            this.rbEpargne.UseVisualStyleBackColor = true;
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Checked = true;
            this.rbCredit.Location = new System.Drawing.Point(31, 30);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(52, 17);
            this.rbCredit.TabIndex = 3;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "Credit";
            this.rbCredit.UseVisualStyleBackColor = true;
            this.rbCredit.CheckedChanged += new System.EventHandler(this.rbTypeContrat_Checked);
            // 
            // gb_type_compte
            // 
            this.gb_type_compte.Controls.Add(this.rbCredit);
            this.gb_type_compte.Controls.Add(this.rbEpargne);
            this.gb_type_compte.Location = new System.Drawing.Point(33, 80);
            this.gb_type_compte.Name = "gb_type_compte";
            this.gb_type_compte.Size = new System.Drawing.Size(223, 60);
            this.gb_type_compte.TabIndex = 4;
            this.gb_type_compte.TabStop = false;
            this.gb_type_compte.Text = "Type de Contrat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Client :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Compte :";
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(101, 16);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(133, 20);
            this.txtIdClient.TabIndex = 8;
            // 
            // txtIdCompte
            // 
            this.txtIdCompte.Location = new System.Drawing.Point(101, 46);
            this.txtIdCompte.Name = "txtIdCompte";
            this.txtIdCompte.Size = new System.Drawing.Size(133, 20);
            this.txtIdCompte.TabIndex = 9;
            // 
            // gb_credit
            // 
            this.gb_credit.Controls.Add(this.txtDuree);
            this.gb_credit.Controls.Add(this.label8);
            this.gb_credit.Controls.Add(this.txtTaux);
            this.gb_credit.Controls.Add(this.label10);
            this.gb_credit.Controls.Add(this.txtCreditMontant);
            this.gb_credit.Controls.Add(this.label9);
            this.gb_credit.Controls.Add(this.txtObjet);
            this.gb_credit.Controls.Add(this.label7);
            this.gb_credit.Location = new System.Drawing.Point(33, 146);
            this.gb_credit.Name = "gb_credit";
            this.gb_credit.Size = new System.Drawing.Size(223, 216);
            this.gb_credit.TabIndex = 10;
            this.gb_credit.TabStop = false;
            this.gb_credit.Text = "Contrat : Crédit";
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(74, 64);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(133, 20);
            this.txtDuree.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Durée :";
            // 
            // txtTaux
            // 
            this.txtTaux.Location = new System.Drawing.Point(74, 90);
            this.txtTaux.Name = "txtTaux";
            this.txtTaux.Size = new System.Drawing.Size(133, 20);
            this.txtTaux.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Taux :";
            // 
            // txtCreditMontant
            // 
            this.txtCreditMontant.Location = new System.Drawing.Point(74, 116);
            this.txtCreditMontant.Name = "txtCreditMontant";
            this.txtCreditMontant.Size = new System.Drawing.Size(133, 20);
            this.txtCreditMontant.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Montant :";
            // 
            // txtObjet
            // 
            this.txtObjet.Location = new System.Drawing.Point(74, 38);
            this.txtObjet.Name = "txtObjet";
            this.txtObjet.Size = new System.Drawing.Size(133, 20);
            this.txtObjet.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Objet :";
            // 
            // gb_epargne
            // 
            this.gb_epargne.Controls.Add(this.dtVersement);
            this.gb_epargne.Controls.Add(this.label6);
            this.gb_epargne.Controls.Add(this.txtEpargneMontant);
            this.gb_epargne.Controls.Add(this.label4);
            this.gb_epargne.Controls.Add(this.gbVersement);
            this.gb_epargne.Controls.Add(this.cbPeriodicite);
            this.gb_epargne.Controls.Add(this.label5);
            this.gb_epargne.Controls.Add(this.cbTypeEpargne);
            this.gb_epargne.Controls.Add(this.label1);
            this.gb_epargne.Location = new System.Drawing.Point(260, 146);
            this.gb_epargne.Name = "gb_epargne";
            this.gb_epargne.Size = new System.Drawing.Size(246, 216);
            this.gb_epargne.TabIndex = 11;
            this.gb_epargne.TabStop = false;
            this.gb_epargne.Text = "Contrat : Epargne";
            // 
            // dtVersement
            // 
            this.dtVersement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVersement.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtVersement.Location = new System.Drawing.Point(116, 153);
            this.dtVersement.Name = "dtVersement";
            this.dtVersement.Size = new System.Drawing.Size(111, 20);
            this.dtVersement.TabIndex = 10;
            this.dtVersement.Value = new System.DateTime(2015, 4, 12, 2, 4, 15, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date versement :";
            // 
            // txtEpargneMontant
            // 
            this.txtEpargneMontant.Location = new System.Drawing.Point(91, 179);
            this.txtEpargneMontant.Name = "txtEpargneMontant";
            this.txtEpargneMontant.Size = new System.Drawing.Size(136, 20);
            this.txtEpargneMontant.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Montant :";
            // 
            // gbVersement
            // 
            this.gbVersement.Controls.Add(this.rbPeriodique);
            this.gbVersement.Controls.Add(this.rbPonctuel);
            this.gbVersement.Location = new System.Drawing.Point(25, 55);
            this.gbVersement.Name = "gbVersement";
            this.gbVersement.Size = new System.Drawing.Size(202, 62);
            this.gbVersement.TabIndex = 6;
            this.gbVersement.TabStop = false;
            this.gbVersement.Text = "Versement";
            // 
            // rbPeriodique
            // 
            this.rbPeriodique.AutoSize = true;
            this.rbPeriodique.Checked = true;
            this.rbPeriodique.Location = new System.Drawing.Point(19, 28);
            this.rbPeriodique.Name = "rbPeriodique";
            this.rbPeriodique.Size = new System.Drawing.Size(75, 17);
            this.rbPeriodique.TabIndex = 1;
            this.rbPeriodique.TabStop = true;
            this.rbPeriodique.Text = "Périodique";
            this.rbPeriodique.UseVisualStyleBackColor = true;
            // 
            // rbPonctuel
            // 
            this.rbPonctuel.AutoSize = true;
            this.rbPonctuel.Location = new System.Drawing.Point(117, 28);
            this.rbPonctuel.Name = "rbPonctuel";
            this.rbPonctuel.Size = new System.Drawing.Size(67, 17);
            this.rbPonctuel.TabIndex = 0;
            this.rbPonctuel.Text = "Ponctuel";
            this.rbPonctuel.UseVisualStyleBackColor = true;
            // 
            // cbPeriodicite
            // 
            this.cbPeriodicite.FormattingEnabled = true;
            this.cbPeriodicite.Location = new System.Drawing.Point(91, 126);
            this.cbPeriodicite.Name = "cbPeriodicite";
            this.cbPeriodicite.Size = new System.Drawing.Size(136, 21);
            this.cbPeriodicite.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Périodicité :";
            // 
            // cbTypeEpargne
            // 
            this.cbTypeEpargne.FormattingEnabled = true;
            this.cbTypeEpargne.Location = new System.Drawing.Point(91, 28);
            this.cbTypeEpargne.Name = "cbTypeEpargne";
            this.cbTypeEpargne.Size = new System.Drawing.Size(136, 21);
            this.cbTypeEpargne.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type :";
            // 
            // gbContrat
            // 
            this.gbContrat.Controls.Add(this.cbStatut);
            this.gbContrat.Controls.Add(this.txtIntitule);
            this.gbContrat.Controls.Add(this.lbIntitule);
            this.gbContrat.Controls.Add(this.label12);
            this.gbContrat.Location = new System.Drawing.Point(260, 12);
            this.gbContrat.Name = "gbContrat";
            this.gbContrat.Size = new System.Drawing.Size(245, 128);
            this.gbContrat.TabIndex = 12;
            this.gbContrat.TabStop = false;
            this.gbContrat.Text = "Généralités";
            // 
            // cbStatut
            // 
            this.cbStatut.FormattingEnabled = true;
            this.cbStatut.Location = new System.Drawing.Point(91, 68);
            this.cbStatut.Name = "cbStatut";
            this.cbStatut.Size = new System.Drawing.Size(136, 21);
            this.cbStatut.TabIndex = 25;
            // 
            // txtIntitule
            // 
            this.txtIntitule.Location = new System.Drawing.Point(91, 42);
            this.txtIntitule.Name = "txtIntitule";
            this.txtIntitule.Size = new System.Drawing.Size(136, 20);
            this.txtIntitule.TabIndex = 20;
            // 
            // lbIntitule
            // 
            this.lbIntitule.AutoSize = true;
            this.lbIntitule.Location = new System.Drawing.Point(22, 45);
            this.lbIntitule.Name = "lbIntitule";
            this.lbIntitule.Size = new System.Drawing.Size(44, 13);
            this.lbIntitule.TabIndex = 21;
            this.lbIntitule.Text = "Intitulé :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Statut :";
            // 
            // bt_vider
            // 
            this.bt_vider.Location = new System.Drawing.Point(133, 368);
            this.bt_vider.Name = "bt_vider";
            this.bt_vider.Size = new System.Drawing.Size(101, 23);
            this.bt_vider.TabIndex = 13;
            this.bt_vider.Text = "Vider";
            this.bt_vider.UseVisualStyleBackColor = true;
            this.bt_vider.Click += new System.EventHandler(this.bt_vider_Click);
            // 
            // FenSaisirContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 406);
            this.Controls.Add(this.bt_vider);
            this.Controls.Add(this.gbContrat);
            this.Controls.Add(this.gb_epargne);
            this.Controls.Add(this.gb_credit);
            this.Controls.Add(this.txtIdCompte);
            this.Controls.Add(this.txtIdClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_type_compte);
            this.Controls.Add(this.bt_creer);
            this.Name = "FenSaisirContrat";
            this.Text = "Saisir Contrat";
            this.gb_type_compte.ResumeLayout(false);
            this.gb_type_compte.PerformLayout();
            this.gb_credit.ResumeLayout(false);
            this.gb_credit.PerformLayout();
            this.gb_epargne.ResumeLayout(false);
            this.gb_epargne.PerformLayout();
            this.gbVersement.ResumeLayout(false);
            this.gbVersement.PerformLayout();
            this.gbContrat.ResumeLayout(false);
            this.gbContrat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_creer;
        private System.Windows.Forms.RadioButton rbEpargne;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.GroupBox gb_type_compte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.TextBox txtIdCompte;
        private System.Windows.Forms.GroupBox gb_credit;
        private System.Windows.Forms.GroupBox gb_epargne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTypeEpargne;
        private System.Windows.Forms.GroupBox gbVersement;
        private System.Windows.Forms.RadioButton rbPeriodique;
        private System.Windows.Forms.RadioButton rbPonctuel;
        private System.Windows.Forms.ComboBox cbPeriodicite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEpargneMontant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtVersement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObjet;
        private System.Windows.Forms.TextBox txtTaux;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCreditMontant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbContrat;
        private System.Windows.Forms.ComboBox cbStatut;
        private System.Windows.Forms.TextBox txtIntitule;
        private System.Windows.Forms.Label lbIntitule;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_vider;
    }
}