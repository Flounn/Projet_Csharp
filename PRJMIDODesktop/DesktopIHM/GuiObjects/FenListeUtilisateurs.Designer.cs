namespace DesktopIHM.GuiObjects
{
    public partial class FenListeUtilisateurs
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
            this.dg_utilisateurs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_utilisateurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_utilisateurs
            // 
            this.dg_utilisateurs.AllowUserToAddRows = false;
            this.dg_utilisateurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_utilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_utilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_utilisateurs.Location = new System.Drawing.Point(22, 28);
            this.dg_utilisateurs.Name = "dg_utilisateurs";
            this.dg_utilisateurs.Size = new System.Drawing.Size(542, 265);
            this.dg_utilisateurs.TabIndex = 0;
            // 
            // FenListeUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 305);
            this.Controls.Add(this.dg_utilisateurs);
            this.Name = "FenListeUtilisateurs";
            this.Text = "Liste Utilisateurs";
            ((System.ComponentModel.ISupportInitialize)(this.dg_utilisateurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_utilisateurs;
    }
}