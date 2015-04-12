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
            this.rb_epargne = new System.Windows.Forms.RadioButton();
            this.rb_courant = new System.Windows.Forms.RadioButton();
            this.gb_type_compte = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_client = new System.Windows.Forms.TextBox();
            this.txt_compte = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_epargne = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_type_epargne = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_periodicite = new System.Windows.Forms.ComboBox();
            this.gb_versement = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rb_periodique = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_epargne_montant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_versement = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_duree = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_credit_montant = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_taux = new System.Windows.Forms.TextBox();
            this.gb_type_compte.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_epargne.SuspendLayout();
            this.gb_versement.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_creer
            // 
            this.bt_creer.Location = new System.Drawing.Point(258, 324);
            this.bt_creer.Name = "bt_creer";
            this.bt_creer.Size = new System.Drawing.Size(75, 23);
            this.bt_creer.TabIndex = 0;
            this.bt_creer.Text = "Créer";
            this.bt_creer.UseVisualStyleBackColor = true;
            this.bt_creer.Click += new System.EventHandler(this.bt_creer_Click);
            // 
            // rb_epargne
            // 
            this.rb_epargne.AutoSize = true;
            this.rb_epargne.Location = new System.Drawing.Point(111, 30);
            this.rb_epargne.Name = "rb_epargne";
            this.rb_epargne.Size = new System.Drawing.Size(65, 17);
            this.rb_epargne.TabIndex = 2;
            this.rb_epargne.Text = "Epargne";
            this.rb_epargne.UseVisualStyleBackColor = true;
            // 
            // rb_courant
            // 
            this.rb_courant.AutoSize = true;
            this.rb_courant.Checked = true;
            this.rb_courant.Location = new System.Drawing.Point(16, 30);
            this.rb_courant.Name = "rb_courant";
            this.rb_courant.Size = new System.Drawing.Size(52, 17);
            this.rb_courant.TabIndex = 3;
            this.rb_courant.TabStop = true;
            this.rb_courant.Text = "Credit";
            this.rb_courant.UseVisualStyleBackColor = true;
            // 
            // gb_type_compte
            // 
            this.gb_type_compte.Controls.Add(this.rb_courant);
            this.gb_type_compte.Controls.Add(this.rb_epargne);
            this.gb_type_compte.Location = new System.Drawing.Point(304, 9);
            this.gb_type_compte.Name = "gb_type_compte";
            this.gb_type_compte.Size = new System.Drawing.Size(188, 60);
            this.gb_type_compte.TabIndex = 4;
            this.gb_type_compte.TabStop = false;
            this.gb_type_compte.Text = "Type de Contrat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Client :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Compte :";
            // 
            // txt_client
            // 
            this.txt_client.Location = new System.Drawing.Point(138, 9);
            this.txt_client.Name = "txt_client";
            this.txt_client.Size = new System.Drawing.Size(121, 20);
            this.txt_client.TabIndex = 8;
            // 
            // txt_compte
            // 
            this.txt_compte.Location = new System.Drawing.Point(138, 39);
            this.txt_compte.Name = "txt_compte";
            this.txt_compte.Size = new System.Drawing.Size(121, 20);
            this.txt_compte.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_taux);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_credit_montant);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_duree);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(27, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 216);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrat : Crédit";
            // 
            // gb_epargne
            // 
            this.gb_epargne.Controls.Add(this.dt_versement);
            this.gb_epargne.Controls.Add(this.label6);
            this.gb_epargne.Controls.Add(this.txt_epargne_montant);
            this.gb_epargne.Controls.Add(this.label4);
            this.gb_epargne.Controls.Add(this.gb_versement);
            this.gb_epargne.Controls.Add(this.cb_periodicite);
            this.gb_epargne.Controls.Add(this.label5);
            this.gb_epargne.Controls.Add(this.cb_type_epargne);
            this.gb_epargne.Controls.Add(this.label1);
            this.gb_epargne.Location = new System.Drawing.Point(304, 92);
            this.gb_epargne.Name = "gb_epargne";
            this.gb_epargne.Size = new System.Drawing.Size(246, 216);
            this.gb_epargne.TabIndex = 11;
            this.gb_epargne.TabStop = false;
            this.gb_epargne.Text = "Contrat : Epargne";
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
            // cb_type_epargne
            // 
            this.cb_type_epargne.FormattingEnabled = true;
            this.cb_type_epargne.Location = new System.Drawing.Point(91, 28);
            this.cb_type_epargne.Name = "cb_type_epargne";
            this.cb_type_epargne.Size = new System.Drawing.Size(136, 21);
            this.cb_type_epargne.TabIndex = 1;
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
            // cb_periodicite
            // 
            this.cb_periodicite.FormattingEnabled = true;
            this.cb_periodicite.Location = new System.Drawing.Point(91, 126);
            this.cb_periodicite.Name = "cb_periodicite";
            this.cb_periodicite.Size = new System.Drawing.Size(136, 21);
            this.cb_periodicite.TabIndex = 5;
            // 
            // gb_versement
            // 
            this.gb_versement.Controls.Add(this.rb_periodique);
            this.gb_versement.Controls.Add(this.radioButton1);
            this.gb_versement.Location = new System.Drawing.Point(25, 55);
            this.gb_versement.Name = "gb_versement";
            this.gb_versement.Size = new System.Drawing.Size(202, 62);
            this.gb_versement.TabIndex = 6;
            this.gb_versement.TabStop = false;
            this.gb_versement.Text = "Versement";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(117, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Ponctuel";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rb_periodique
            // 
            this.rb_periodique.AutoSize = true;
            this.rb_periodique.Checked = true;
            this.rb_periodique.Location = new System.Drawing.Point(19, 28);
            this.rb_periodique.Name = "rb_periodique";
            this.rb_periodique.Size = new System.Drawing.Size(75, 17);
            this.rb_periodique.TabIndex = 1;
            this.rb_periodique.TabStop = true;
            this.rb_periodique.Text = "Périodique";
            this.rb_periodique.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Montant :";
            // 
            // txt_epargne_montant
            // 
            this.txt_epargne_montant.Location = new System.Drawing.Point(91, 183);
            this.txt_epargne_montant.Name = "txt_epargne_montant";
            this.txt_epargne_montant.Size = new System.Drawing.Size(136, 20);
            this.txt_epargne_montant.TabIndex = 8;
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
            // dt_versement
            // 
            this.dt_versement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_versement.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dt_versement.Location = new System.Drawing.Point(116, 153);
            this.dt_versement.Name = "dt_versement";
            this.dt_versement.Size = new System.Drawing.Size(111, 20);
            this.dt_versement.TabIndex = 10;
            this.dt_versement.Value = new System.DateTime(2015, 4, 12, 2, 4, 15, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Objet :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Durée :";
            // 
            // txt_duree
            // 
            this.txt_duree.Location = new System.Drawing.Point(71, 62);
            this.txt_duree.Name = "txt_duree";
            this.txt_duree.Size = new System.Drawing.Size(136, 20);
            this.txt_duree.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Montant :";
            // 
            // txt_credit_montant
            // 
            this.txt_credit_montant.Location = new System.Drawing.Point(71, 95);
            this.txt_credit_montant.Name = "txt_credit_montant";
            this.txt_credit_montant.Size = new System.Drawing.Size(136, 20);
            this.txt_credit_montant.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Taux :";
            // 
            // txt_taux
            // 
            this.txt_taux.Location = new System.Drawing.Point(71, 126);
            this.txt_taux.Name = "txt_taux";
            this.txt_taux.Size = new System.Drawing.Size(136, 20);
            this.txt_taux.TabIndex = 17;
            // 
            // FenSaisirContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 359);
            this.Controls.Add(this.gb_epargne);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_compte);
            this.Controls.Add(this.txt_client);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_type_compte);
            this.Controls.Add(this.bt_creer);
            this.Name = "FenSaisirContrat";
            this.Text = "Saisir Contrat";
            this.gb_type_compte.ResumeLayout(false);
            this.gb_type_compte.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_epargne.ResumeLayout(false);
            this.gb_epargne.PerformLayout();
            this.gb_versement.ResumeLayout(false);
            this.gb_versement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_creer;
        private System.Windows.Forms.RadioButton rb_epargne;
        private System.Windows.Forms.RadioButton rb_courant;
        private System.Windows.Forms.GroupBox gb_type_compte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_client;
        private System.Windows.Forms.TextBox txt_compte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_epargne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_type_epargne;
        private System.Windows.Forms.GroupBox gb_versement;
        private System.Windows.Forms.RadioButton rb_periodique;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cb_periodicite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_epargne_montant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_versement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_duree;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_taux;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_credit_montant;
        private System.Windows.Forms.Label label9;
    }
}