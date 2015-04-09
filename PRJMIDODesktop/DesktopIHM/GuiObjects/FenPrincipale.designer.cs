namespace DesktopIHM
{
    partial class FenPrincipale
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
            this.menuGeneral = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_saisir_client = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_saisir_compte = new System.Windows.Forms.ToolStripMenuItem();
            this.universitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.détailsAcadémieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déytailsEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uneOpérationSurUnCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sécuritéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisationDeLapplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGeneral
            // 
            this.menuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.sécuritéToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuGeneral.Location = new System.Drawing.Point(0, 0);
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(1213, 24);
            this.menuGeneral.TabIndex = 1;
            this.menuGeneral.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisirToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.monProfileToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // saisirToolStripMenuItem
            // 
            this.saisirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_saisir_client,
            this.mi_saisir_compte,
            this.universitéToolStripMenuItem,
            this.etudiantToolStripMenuItem});
            this.saisirToolStripMenuItem.Name = "saisirToolStripMenuItem";
            this.saisirToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saisirToolStripMenuItem.Text = "Saisir";
            // 
            // mi_saisir_client
            // 
            this.mi_saisir_client.Name = "mi_saisir_client";
            this.mi_saisir_client.Size = new System.Drawing.Size(188, 22);
            this.mi_saisir_client.Text = "Un client";
            this.mi_saisir_client.Click += new System.EventHandler(this.mi_saisir_client_Click);
            // 
            // mi_saisir_compte
            // 
            this.mi_saisir_compte.Name = "mi_saisir_compte";
            this.mi_saisir_compte.Size = new System.Drawing.Size(188, 22);
            this.mi_saisir_compte.Text = "Un compte client";
            // 
            // universitéToolStripMenuItem
            // 
            this.universitéToolStripMenuItem.Name = "universitéToolStripMenuItem";
            this.universitéToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.universitéToolStripMenuItem.Text = "Une souscription";
            // 
            // etudiantToolStripMenuItem
            // 
            this.etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            this.etudiantToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.etudiantToolStripMenuItem.Text = "Donnée du référentiel";
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.détailsAcadémieToolStripMenuItem,
            this.déytailsEtudiantToolStripMenuItem,
            this.unCompteToolStripMenuItem,
            this.uneOpérationSurUnCompteToolStripMenuItem});
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            // 
            // détailsAcadémieToolStripMenuItem
            // 
            this.détailsAcadémieToolStripMenuItem.Name = "détailsAcadémieToolStripMenuItem";
            this.détailsAcadémieToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.détailsAcadémieToolStripMenuItem.Text = "Un client";
            // 
            // déytailsEtudiantToolStripMenuItem
            // 
            this.déytailsEtudiantToolStripMenuItem.Name = "déytailsEtudiantToolStripMenuItem";
            this.déytailsEtudiantToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.déytailsEtudiantToolStripMenuItem.Text = "Un contrat";
            // 
            // unCompteToolStripMenuItem
            // 
            this.unCompteToolStripMenuItem.Name = "unCompteToolStripMenuItem";
            this.unCompteToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.unCompteToolStripMenuItem.Text = "Un compte";
            // 
            // uneOpérationSurUnCompteToolStripMenuItem
            // 
            this.uneOpérationSurUnCompteToolStripMenuItem.Name = "uneOpérationSurUnCompteToolStripMenuItem";
            this.uneOpérationSurUnCompteToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.uneOpérationSurUnCompteToolStripMenuItem.Text = "Une opération sur un compte";
            // 
            // monProfileToolStripMenuItem
            // 
            this.monProfileToolStripMenuItem.Name = "monProfileToolStripMenuItem";
            this.monProfileToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.monProfileToolStripMenuItem.Text = "Mon profile";
            this.monProfileToolStripMenuItem.Click += new System.EventHandler(this.monProfileToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // sécuritéToolStripMenuItem
            // 
            this.sécuritéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesUtilisateursToolStripMenuItem,
            this.ajouterUnUtilisateurToolStripMenuItem});
            this.sécuritéToolStripMenuItem.Name = "sécuritéToolStripMenuItem";
            this.sécuritéToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.sécuritéToolStripMenuItem.Text = "Sécurité";
            // 
            // listeDesUtilisateursToolStripMenuItem
            // 
            this.listeDesUtilisateursToolStripMenuItem.Name = "listeDesUtilisateursToolStripMenuItem";
            this.listeDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listeDesUtilisateursToolStripMenuItem.Text = "Liste des utilisateurs";
            this.listeDesUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.listeDesUtilisateursToolStripMenuItem_Click);
            // 
            // ajouterUnUtilisateurToolStripMenuItem
            // 
            this.ajouterUnUtilisateurToolStripMenuItem.Name = "ajouterUnUtilisateurToolStripMenuItem";
            this.ajouterUnUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ajouterUnUtilisateurToolStripMenuItem.Text = "Ajouter un utilisateur";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisationDeLapplicationToolStripMenuItem,
            this.auteursToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // utilisationDeLapplicationToolStripMenuItem
            // 
            this.utilisationDeLapplicationToolStripMenuItem.Name = "utilisationDeLapplicationToolStripMenuItem";
            this.utilisationDeLapplicationToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.utilisationDeLapplicationToolStripMenuItem.Text = "Utilisation de l\'application";
            // 
            // auteursToolStripMenuItem
            // 
            this.auteursToolStripMenuItem.Name = "auteursToolStripMenuItem";
            this.auteursToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.auteursToolStripMenuItem.Text = "A propos des auteurs";
            this.auteursToolStripMenuItem.Click += new System.EventHandler(this.auteursToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // FenPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 386);
            this.Controls.Add(this.menuGeneral);
            this.MainMenuStrip = this.menuGeneral;
            this.Name = "FenPrincipale";
            this.Text = "LCP : Le Crédit Parisien";
            this.Load += new System.EventHandler(this.FenPrincipale_Load);
            this.menuGeneral.ResumeLayout(false);
            this.menuGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuGeneral;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_saisir_compte;
        private System.Windows.Forms.ToolStripMenuItem universitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem détailsAcadémieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déytailsEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sécuritéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisationDeLapplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uneOpérationSurUnCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_saisir_client;
    }
}

