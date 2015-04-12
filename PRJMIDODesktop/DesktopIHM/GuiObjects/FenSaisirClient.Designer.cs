namespace DesktopIHM.GuiObjects
{
    partial class FenSaisirClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenSaisirClient));
            this.btCreer = new System.Windows.Forms.Button();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbDdn = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAdressePrinc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdressePrinc = new System.Windows.Forms.TextBox();
            this.txtAdresseTemp = new System.Windows.Forms.TextBox();
            this.txtTelFixe = new System.Windows.Forms.TextBox();
            this.txtTelPort = new System.Windows.Forms.TextBox();
            this.dtDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.bt_vider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCreer
            // 
            this.btCreer.Location = new System.Drawing.Point(165, 244);
            this.btCreer.Name = "btCreer";
            this.btCreer.Size = new System.Drawing.Size(75, 23);
            this.btCreer.TabIndex = 0;
            this.btCreer.Text = "Créer";
            this.btCreer.UseVisualStyleBackColor = true;
            this.btCreer.Click += new System.EventHandler(this.btCreer_Click);
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(36, 27);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(39, 13);
            this.lbNom.TabIndex = 1;
            this.lbNom.Text = "Nom* :";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Location = new System.Drawing.Point(36, 53);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(53, 13);
            this.lbPrenom.TabIndex = 2;
            this.lbPrenom.Text = "Prénom* :";
            // 
            // lbDdn
            // 
            this.lbDdn.AutoSize = true;
            this.lbDdn.Location = new System.Drawing.Point(36, 79);
            this.lbDdn.Name = "lbDdn";
            this.lbDdn.Size = new System.Drawing.Size(106, 13);
            this.lbDdn.TabIndex = 3;
            this.lbDdn.Text = "Date de naissance* :";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(36, 105);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 13);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email* :";
            // 
            // lbAdressePrinc
            // 
            this.lbAdressePrinc.AutoSize = true;
            this.lbAdressePrinc.Location = new System.Drawing.Point(36, 131);
            this.lbAdressePrinc.Name = "lbAdressePrinc";
            this.lbAdressePrinc.Size = new System.Drawing.Size(99, 13);
            this.lbAdressePrinc.TabIndex = 5;
            this.lbAdressePrinc.Text = "Adresse principale :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adresse temporaire :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Téléphone portable :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Téléphone fixe :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(165, 24);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 9;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(165, 50);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(165, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtAdressePrinc
            // 
            this.txtAdressePrinc.Location = new System.Drawing.Point(165, 128);
            this.txtAdressePrinc.Name = "txtAdressePrinc";
            this.txtAdressePrinc.Size = new System.Drawing.Size(100, 20);
            this.txtAdressePrinc.TabIndex = 13;
            // 
            // txtAdresseTemp
            // 
            this.txtAdresseTemp.Location = new System.Drawing.Point(165, 154);
            this.txtAdresseTemp.Name = "txtAdresseTemp";
            this.txtAdresseTemp.Size = new System.Drawing.Size(100, 20);
            this.txtAdresseTemp.TabIndex = 14;
            // 
            // txtTelFixe
            // 
            this.txtTelFixe.Location = new System.Drawing.Point(165, 180);
            this.txtTelFixe.Name = "txtTelFixe";
            this.txtTelFixe.Size = new System.Drawing.Size(100, 20);
            this.txtTelFixe.TabIndex = 15;
            // 
            // txtTelPort
            // 
            this.txtTelPort.Location = new System.Drawing.Point(165, 206);
            this.txtTelPort.Name = "txtTelPort";
            this.txtTelPort.Size = new System.Drawing.Size(100, 20);
            this.txtTelPort.TabIndex = 16;
            // 
            // dtDateNaissance
            // 
            this.dtDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateNaissance.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtDateNaissance.Location = new System.Drawing.Point(165, 76);
            this.dtDateNaissance.MaxDate = new System.DateTime(2015, 12, 25, 23, 59, 59, 0);
            this.dtDateNaissance.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtDateNaissance.Name = "dtDateNaissance";
            this.dtDateNaissance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDateNaissance.Size = new System.Drawing.Size(100, 20);
            this.dtDateNaissance.TabIndex = 17;
            this.dtDateNaissance.Value = new System.DateTime(2015, 4, 10, 0, 0, 0, 0);
            // 
            // bt_vider
            // 
            this.bt_vider.Location = new System.Drawing.Point(60, 244);
            this.bt_vider.Name = "bt_vider";
            this.bt_vider.Size = new System.Drawing.Size(75, 23);
            this.bt_vider.TabIndex = 18;
            this.bt_vider.Text = "Vider";
            this.bt_vider.UseVisualStyleBackColor = true;
            this.bt_vider.Click += new System.EventHandler(this.bt_vider_Click);
            // 
            // FenSaisirClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 285);
            this.Controls.Add(this.bt_vider);
            this.Controls.Add(this.dtDateNaissance);
            this.Controls.Add(this.txtTelPort);
            this.Controls.Add(this.txtTelFixe);
            this.Controls.Add(this.txtAdresseTemp);
            this.Controls.Add(this.txtAdressePrinc);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbAdressePrinc);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbDdn);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.btCreer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FenSaisirClient";
            this.Text = "Saisir Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCreer;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbDdn;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAdressePrinc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdressePrinc;
        private System.Windows.Forms.TextBox txtAdresseTemp;
        private System.Windows.Forms.TextBox txtTelFixe;
        private System.Windows.Forms.TextBox txtTelPort;
        private System.Windows.Forms.DateTimePicker dtDateNaissance;
        private System.Windows.Forms.Button bt_vider;
    }
}