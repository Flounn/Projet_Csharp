namespace DesktopIHM.GuiObjects
{
    partial class fen_recherche_client
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
            this.lb_nom = new System.Windows.Forms.Label();
            this.lb_prenom = new System.Windows.Forms.Label();
            this.lb_date_naissance = new System.Windows.Forms.Label();
            this.lb_adresse = new System.Windows.Forms.Label();
            this.dt_data_naissance_debut = new System.Windows.Forms.DateTimePicker();
            this.txt_adresse = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.dgw_lst_client = new System.Windows.Forms.DataGridView();
            this.bt_rechercher = new System.Windows.Forms.Button();
            this.dt_date_naissance_fin = new System.Windows.Forms.DateTimePicker();
            this.cb_date_naissance = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lb_mail = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.bt_detail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_lst_client)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Location = new System.Drawing.Point(34, 71);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(29, 13);
            this.lb_nom.TabIndex = 0;
            this.lb_nom.Text = "Nom";
            // 
            // lb_prenom
            // 
            this.lb_prenom.AutoSize = true;
            this.lb_prenom.Location = new System.Drawing.Point(34, 111);
            this.lb_prenom.Name = "lb_prenom";
            this.lb_prenom.Size = new System.Drawing.Size(43, 13);
            this.lb_prenom.TabIndex = 1;
            this.lb_prenom.Text = "Prénom";
            // 
            // lb_date_naissance
            // 
            this.lb_date_naissance.AutoSize = true;
            this.lb_date_naissance.Location = new System.Drawing.Point(255, 70);
            this.lb_date_naissance.Name = "lb_date_naissance";
            this.lb_date_naissance.Size = new System.Drawing.Size(83, 13);
            this.lb_date_naissance.TabIndex = 2;
            this.lb_date_naissance.Text = "Date Naissance";
            // 
            // lb_adresse
            // 
            this.lb_adresse.AutoSize = true;
            this.lb_adresse.Location = new System.Drawing.Point(255, 111);
            this.lb_adresse.Name = "lb_adresse";
            this.lb_adresse.Size = new System.Drawing.Size(45, 13);
            this.lb_adresse.TabIndex = 3;
            this.lb_adresse.Text = "Adresse";
            // 
            // dt_data_naissance_debut
            // 
            this.dt_data_naissance_debut.Enabled = false;
            this.dt_data_naissance_debut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_data_naissance_debut.Location = new System.Drawing.Point(436, 66);
            this.dt_data_naissance_debut.Name = "dt_data_naissance_debut";
            this.dt_data_naissance_debut.Size = new System.Drawing.Size(86, 20);
            this.dt_data_naissance_debut.TabIndex = 4;
            this.dt_data_naissance_debut.Value = new System.DateTime(2015, 4, 8, 18, 8, 0, 0);
            // 
            // txt_adresse
            // 
            this.txt_adresse.Location = new System.Drawing.Point(344, 108);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(178, 20);
            this.txt_adresse.TabIndex = 5;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(81, 67);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(141, 20);
            this.txt_nom.TabIndex = 6;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(81, 108);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(141, 20);
            this.txt_prenom.TabIndex = 7;
            // 
            // dgw_lst_client
            // 
            this.dgw_lst_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_lst_client.Location = new System.Drawing.Point(37, 186);
            this.dgw_lst_client.Name = "dgw_lst_client";
            this.dgw_lst_client.Size = new System.Drawing.Size(485, 207);
            this.dgw_lst_client.TabIndex = 9;
            // 
            // bt_rechercher
            // 
            this.bt_rechercher.Location = new System.Drawing.Point(258, 145);
            this.bt_rechercher.Name = "bt_rechercher";
            this.bt_rechercher.Size = new System.Drawing.Size(264, 21);
            this.bt_rechercher.TabIndex = 10;
            this.bt_rechercher.Text = "Rechercher";
            this.bt_rechercher.UseVisualStyleBackColor = true;
            this.bt_rechercher.Click += new System.EventHandler(this.bt_rechercher_Click);
            // 
            // dt_date_naissance_fin
            // 
            this.dt_date_naissance_fin.Enabled = false;
            this.dt_date_naissance_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_date_naissance_fin.Location = new System.Drawing.Point(436, 86);
            this.dt_date_naissance_fin.Name = "dt_date_naissance_fin";
            this.dt_date_naissance_fin.Size = new System.Drawing.Size(86, 20);
            this.dt_date_naissance_fin.TabIndex = 11;
            this.dt_date_naissance_fin.Value = new System.DateTime(2015, 4, 8, 18, 8, 0, 0);
            this.dt_date_naissance_fin.Visible = false;
            // 
            // cb_date_naissance
            // 
            this.cb_date_naissance.FormattingEnabled = true;
            this.cb_date_naissance.Location = new System.Drawing.Point(344, 66);
            this.cb_date_naissance.Name = "cb_date_naissance";
            this.cb_date_naissance.Size = new System.Drawing.Size(86, 21);
            this.cb_date_naissance.TabIndex = 12;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(344, 26);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(178, 20);
            this.txt_email.TabIndex = 14;
            // 
            // lb_mail
            // 
            this.lb_mail.AutoSize = true;
            this.lb_mail.Location = new System.Drawing.Point(255, 30);
            this.lb_mail.Name = "lb_mail";
            this.lb_mail.Size = new System.Drawing.Size(32, 13);
            this.lb_mail.TabIndex = 13;
            this.lb_mail.Text = "Email";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(81, 27);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(141, 20);
            this.txt_id.TabIndex = 16;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(34, 31);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(18, 13);
            this.lb_id.TabIndex = 15;
            this.lb_id.Text = "ID";
            // 
            // bt_detail
            // 
            this.bt_detail.Location = new System.Drawing.Point(148, 399);
            this.bt_detail.Name = "bt_detail";
            this.bt_detail.Size = new System.Drawing.Size(264, 21);
            this.bt_detail.TabIndex = 17;
            this.bt_detail.Text = "Détail";
            this.bt_detail.UseVisualStyleBackColor = true;
            // 
            // fen_recherche_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 429);
            this.Controls.Add(this.bt_detail);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lb_mail);
            this.Controls.Add(this.cb_date_naissance);
            this.Controls.Add(this.dt_date_naissance_fin);
            this.Controls.Add(this.bt_rechercher);
            this.Controls.Add(this.dgw_lst_client);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_adresse);
            this.Controls.Add(this.dt_data_naissance_debut);
            this.Controls.Add(this.lb_adresse);
            this.Controls.Add(this.lb_date_naissance);
            this.Controls.Add(this.lb_prenom);
            this.Controls.Add(this.lb_nom);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "fen_recherche_client";
            this.Text = "Rechercher un client";
            this.Load += new System.EventHandler(this.fen_recherche_client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_lst_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.Label lb_prenom;
        private System.Windows.Forms.Label lb_date_naissance;
        private System.Windows.Forms.Label lb_adresse;
        private System.Windows.Forms.DateTimePicker dt_data_naissance_debut;
        private System.Windows.Forms.TextBox txt_adresse;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.DataGridView dgw_lst_client;
        private System.Windows.Forms.Button bt_rechercher;
        private System.Windows.Forms.DateTimePicker dt_date_naissance_fin;
        private System.Windows.Forms.ComboBox cb_date_naissance;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_mail;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Button bt_detail;
    }
}