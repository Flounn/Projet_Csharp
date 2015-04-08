namespace DesktopIHM.GuiObjects
{
    partial class FenSaisirCompte
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
            this.label1 = new System.Windows.Forms.Label();
            this.rb_epargne = new System.Windows.Forms.RadioButton();
            this.rb_courant = new System.Windows.Forms.RadioButton();
            this.gb_type_compte = new System.Windows.Forms.GroupBox();
            this.txt_montant_initial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_moyen_paiement = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_client = new System.Windows.Forms.ComboBox();
            this.bt_ajouter_client = new System.Windows.Forms.Button();
            this.gb_type_compte.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_creer
            // 
            this.bt_creer.Location = new System.Drawing.Point(171, 241);
            this.bt_creer.Name = "bt_creer";
            this.bt_creer.Size = new System.Drawing.Size(75, 23);
            this.bt_creer.TabIndex = 0;
            this.bt_creer.Text = "Créer";
            this.bt_creer.UseVisualStyleBackColor = true;
            this.bt_creer.Click += new System.EventHandler(this.bt_creer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Montant initial :";
            // 
            // rb_epargne
            // 
            this.rb_epargne.AutoSize = true;
            this.rb_epargne.Location = new System.Drawing.Point(16, 66);
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
            this.rb_courant.Size = new System.Drawing.Size(62, 17);
            this.rb_courant.TabIndex = 3;
            this.rb_courant.TabStop = true;
            this.rb_courant.Text = "Courant";
            this.rb_courant.UseVisualStyleBackColor = true;
            // 
            // gb_type_compte
            // 
            this.gb_type_compte.Controls.Add(this.rb_courant);
            this.gb_type_compte.Controls.Add(this.rb_epargne);
            this.gb_type_compte.Location = new System.Drawing.Point(70, 41);
            this.gb_type_compte.Name = "gb_type_compte";
            this.gb_type_compte.Size = new System.Drawing.Size(249, 100);
            this.gb_type_compte.TabIndex = 4;
            this.gb_type_compte.TabStop = false;
            this.gb_type_compte.Text = "Type de Compte";
            // 
            // txt_montant_initial
            // 
            this.txt_montant_initial.Location = new System.Drawing.Point(198, 203);
            this.txt_montant_initial.Name = "txt_montant_initial";
            this.txt_montant_initial.Size = new System.Drawing.Size(121, 20);
            this.txt_montant_initial.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Moyen de paiement :";
            // 
            // cb_moyen_paiement
            // 
            this.cb_moyen_paiement.FormattingEnabled = true;
            this.cb_moyen_paiement.Location = new System.Drawing.Point(198, 159);
            this.cb_moyen_paiement.Name = "cb_moyen_paiement";
            this.cb_moyen_paiement.Size = new System.Drawing.Size(121, 21);
            this.cb_moyen_paiement.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client :";
            // 
            // cb_client
            // 
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(198, 6);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(121, 21);
            this.cb_client.TabIndex = 9;
            // 
            // bt_ajouter_client
            // 
            this.bt_ajouter_client.Location = new System.Drawing.Point(336, 6);
            this.bt_ajouter_client.Name = "bt_ajouter_client";
            this.bt_ajouter_client.Size = new System.Drawing.Size(29, 21);
            this.bt_ajouter_client.TabIndex = 10;
            this.bt_ajouter_client.Text = "+";
            this.bt_ajouter_client.UseVisualStyleBackColor = true;
            // 
            // FenSaisirCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 276);
            this.Controls.Add(this.bt_ajouter_client);
            this.Controls.Add(this.cb_client);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_moyen_paiement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_montant_initial);
            this.Controls.Add(this.gb_type_compte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_creer);
            this.Name = "FenSaisirCompte";
            this.Text = "Form1";
            this.gb_type_compte.ResumeLayout(false);
            this.gb_type_compte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_creer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_epargne;
        private System.Windows.Forms.RadioButton rb_courant;
        private System.Windows.Forms.GroupBox gb_type_compte;
        private System.Windows.Forms.TextBox txt_montant_initial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_moyen_paiement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.Button bt_ajouter_client;
    }
}