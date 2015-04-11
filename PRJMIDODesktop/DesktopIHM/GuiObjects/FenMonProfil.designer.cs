namespace DesktopIHM.GuiObjects
{
    partial class FenMonProfil
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.monProfile = new System.Windows.Forms.Label();
            this.monEmail = new System.Windows.Forms.Label();
            this.monLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_profil = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_modifier);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_login);
            this.groupBox1.Controls.Add(this.monProfile);
            this.groupBox1.Controls.Add(this.monEmail);
            this.groupBox1.Controls.Add(this.monLogin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mes données personnelles";
            // 
            // bt_modifier
            // 
            this.bt_modifier.Location = new System.Drawing.Point(89, 119);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(75, 23);
            this.bt_modifier.TabIndex = 9;
            this.bt_modifier.Text = "Modifier";
            this.bt_modifier.UseVisualStyleBackColor = true;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(126, 54);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(126, 84);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 7;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(126, 28);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(100, 20);
            this.txt_login.TabIndex = 6;
            // 
            // monProfile
            // 
            this.monProfile.AutoSize = true;
            this.monProfile.Location = new System.Drawing.Point(112, 87);
            this.monProfile.Name = "monProfile";
            this.monProfile.Size = new System.Drawing.Size(0, 13);
            this.monProfile.TabIndex = 5;
            // 
            // monEmail
            // 
            this.monEmail.AutoSize = true;
            this.monEmail.Location = new System.Drawing.Point(112, 61);
            this.monEmail.Name = "monEmail";
            this.monEmail.Size = new System.Drawing.Size(0, 13);
            this.monEmail.TabIndex = 4;
            // 
            // monLogin
            // 
            this.monLogin.AutoSize = true;
            this.monLogin.Location = new System.Drawing.Point(112, 31);
            this.monLogin.Name = "monLogin";
            this.monLogin.Size = new System.Drawing.Size(0, 13);
            this.monLogin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mon password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mon email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mon login :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mon profil :";
            // 
            // lbl_profil
            // 
            this.lbl_profil.AutoSize = true;
            this.lbl_profil.Location = new System.Drawing.Point(123, 189);
            this.lbl_profil.Name = "lbl_profil";
            this.lbl_profil.Size = new System.Drawing.Size(0, 13);
            this.lbl_profil.TabIndex = 10;
            // 
            // FenMonProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 261);
            this.Controls.Add(this.lbl_profil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FenMonProfil";
            this.Text = "Mon profile Utilisateur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label monProfile;
        private System.Windows.Forms.Label monEmail;
        private System.Windows.Forms.Label monLogin;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_profil;
    }
}