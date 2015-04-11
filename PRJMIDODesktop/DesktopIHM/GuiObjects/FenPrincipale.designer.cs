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
            this.miFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaisir = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaisirClient = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaisirCompte = new System.Windows.Forms.ToolStripMenuItem();
            this.miSouscription = new System.Windows.Forms.ToolStripMenuItem();
            this.miDonneesReferentiel = new System.Windows.Forms.ToolStripMenuItem();
            this.miRechercher = new System.Windows.Forms.ToolStripMenuItem();
            this.miRechercheClient = new System.Windows.Forms.ToolStripMenuItem();
            this.miRechercheContrat = new System.Windows.Forms.ToolStripMenuItem();
            this.miRechercheCompte = new System.Windows.Forms.ToolStripMenuItem();
            this.miRechercheOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.miProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.miSecurite = new System.Windows.Forms.ToolStripMenuItem();
            this.miLstUtilisateurs = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddUtilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miUtilisation = new System.Windows.Forms.ToolStripMenuItem();
            this.miAuteurs = new System.Windows.Forms.ToolStripMenuItem();
            this.miVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGeneral
            // 
            this.menuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFichier,
            this.miSecurite,
            this.miHelp});
            this.menuGeneral.Location = new System.Drawing.Point(0, 0);
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(1213, 24);
            this.menuGeneral.TabIndex = 1;
            this.menuGeneral.Text = "menuStrip1";
            // 
            // miFichier
            // 
            this.miFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSaisir,
            this.miRechercher,
            this.miProfile,
            this.miQuit});
            this.miFichier.Name = "miFichier";
            this.miFichier.Size = new System.Drawing.Size(54, 20);
            this.miFichier.Text = "Fichier";
            // 
            // miSaisir
            // 
            this.miSaisir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSaisirClient,
            this.miSaisirCompte,
            this.miSouscription,
            this.miDonneesReferentiel});
            this.miSaisir.Name = "miSaisir";
            this.miSaisir.Size = new System.Drawing.Size(152, 22);
            this.miSaisir.Text = "Saisir";
            // 
            // miSaisirClient
            // 
            this.miSaisirClient.Name = "miSaisirClient";
            this.miSaisirClient.Size = new System.Drawing.Size(188, 22);
            this.miSaisirClient.Text = "Un client";
            this.miSaisirClient.Click += new System.EventHandler(this.miSaisirClient_Click);
            // 
            // miSaisirCompte
            // 
            this.miSaisirCompte.Name = "miSaisirCompte";
            this.miSaisirCompte.Size = new System.Drawing.Size(188, 22);
            this.miSaisirCompte.Text = "Un compte client";
            this.miSaisirCompte.Click += new System.EventHandler(this.miSaisirCompte_Click);
            // 
            // miSouscription
            // 
            this.miSouscription.Name = "miSouscription";
            this.miSouscription.Size = new System.Drawing.Size(188, 22);
            this.miSouscription.Text = "Une souscription";
            this.miSouscription.Click += new System.EventHandler(this.miSouscription_Click);
            // 
            // miDonneesReferentiel
            // 
            this.miDonneesReferentiel.Name = "miDonneesReferentiel";
            this.miDonneesReferentiel.Size = new System.Drawing.Size(188, 22);
            this.miDonneesReferentiel.Text = "Donnée du référentiel";
            // 
            // miRechercher
            // 
            this.miRechercher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRechercheClient,
            this.miRechercheContrat,
            this.miRechercheCompte,
            this.miRechercheOperation});
            this.miRechercher.Name = "miRechercher";
            this.miRechercher.Size = new System.Drawing.Size(152, 22);
            this.miRechercher.Text = "Rechercher";
            // 
            // miRechercheClient
            // 
            this.miRechercheClient.Name = "miRechercheClient";
            this.miRechercheClient.Size = new System.Drawing.Size(229, 22);
            this.miRechercheClient.Text = "Un client";
            this.miRechercheClient.Click += new System.EventHandler(this.miRechercheClient_Click);
            // 
            // miRechercheContrat
            // 
            this.miRechercheContrat.Name = "miRechercheContrat";
            this.miRechercheContrat.Size = new System.Drawing.Size(229, 22);
            this.miRechercheContrat.Text = "Un contrat";
            this.miRechercheContrat.Click += new System.EventHandler(this.miRechercheContrat_Click);
            // 
            // miRechercheCompte
            // 
            this.miRechercheCompte.Name = "miRechercheCompte";
            this.miRechercheCompte.Size = new System.Drawing.Size(229, 22);
            this.miRechercheCompte.Text = "Un compte";
            this.miRechercheCompte.Click += new System.EventHandler(this.miRechercheCompte_Click);
            // 
            // miRechercheOperation
            // 
            this.miRechercheOperation.Name = "miRechercheOperation";
            this.miRechercheOperation.Size = new System.Drawing.Size(229, 22);
            this.miRechercheOperation.Text = "Une opération sur un compte";
            // 
            // miProfile
            // 
            this.miProfile.Name = "miProfile";
            this.miProfile.Size = new System.Drawing.Size(152, 22);
            this.miProfile.Text = "Mon profile";
            this.miProfile.Click += new System.EventHandler(this.monProfileToolStripMenuItem_Click);
            // 
            // miQuit
            // 
            this.miQuit.Name = "miQuit";
            this.miQuit.Size = new System.Drawing.Size(152, 22);
            this.miQuit.Text = "Quitter";
            this.miQuit.Click += new System.EventHandler(this.miQuit_Click);
            // 
            // miSecurite
            // 
            this.miSecurite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLstUtilisateurs,
            this.miAddUtilisateur});
            this.miSecurite.Name = "miSecurite";
            this.miSecurite.Size = new System.Drawing.Size(61, 20);
            this.miSecurite.Text = "Sécurité";
            // 
            // miLstUtilisateurs
            // 
            this.miLstUtilisateurs.Name = "miLstUtilisateurs";
            this.miLstUtilisateurs.Size = new System.Drawing.Size(185, 22);
            this.miLstUtilisateurs.Text = "Liste des utilisateurs";
            this.miLstUtilisateurs.Click += new System.EventHandler(this.miLstUtilisateurs_Click);
            // 
            // miAddUtilisateur
            // 
            this.miAddUtilisateur.Name = "miAddUtilisateur";
            this.miAddUtilisateur.Size = new System.Drawing.Size(185, 22);
            this.miAddUtilisateur.Text = "Ajouter un utilisateur";
            this.miAddUtilisateur.Click += new System.EventHandler(this.miAddUtilisateur_Click);
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUtilisation,
            this.miAuteurs,
            this.miVersion});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(44, 20);
            this.miHelp.Text = "Help";
            // 
            // miUtilisation
            // 
            this.miUtilisation.Name = "miUtilisation";
            this.miUtilisation.Size = new System.Drawing.Size(211, 22);
            this.miUtilisation.Text = "Utilisation de l\'application";
            // 
            // miAuteurs
            // 
            this.miAuteurs.Name = "miAuteurs";
            this.miAuteurs.Size = new System.Drawing.Size(211, 22);
            this.miAuteurs.Text = "A propos des auteurs";
            this.miAuteurs.Click += new System.EventHandler(this.miAuteurs_Click);
            // 
            // miVersion
            // 
            this.miVersion.Name = "miVersion";
            this.miVersion.Size = new System.Drawing.Size(211, 22);
            this.miVersion.Text = "Version";
            this.miVersion.Click += new System.EventHandler(this.miVersion_Click);
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
        private System.Windows.Forms.ToolStripMenuItem miFichier;
        private System.Windows.Forms.ToolStripMenuItem miSaisir;
        private System.Windows.Forms.ToolStripMenuItem miRechercher;
        private System.Windows.Forms.ToolStripMenuItem miQuit;
        private System.Windows.Forms.ToolStripMenuItem miSaisirCompte;
        private System.Windows.Forms.ToolStripMenuItem miSouscription;
        private System.Windows.Forms.ToolStripMenuItem miDonneesReferentiel;
        private System.Windows.Forms.ToolStripMenuItem miRechercheClient;
        private System.Windows.Forms.ToolStripMenuItem miRechercheContrat;
        private System.Windows.Forms.ToolStripMenuItem miSecurite;
        private System.Windows.Forms.ToolStripMenuItem miLstUtilisateurs;
        private System.Windows.Forms.ToolStripMenuItem miAddUtilisateur;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miUtilisation;
        private System.Windows.Forms.ToolStripMenuItem miAuteurs;
        private System.Windows.Forms.ToolStripMenuItem miVersion;
        private System.Windows.Forms.ToolStripMenuItem miRechercheCompte;
        private System.Windows.Forms.ToolStripMenuItem miRechercheOperation;
        private System.Windows.Forms.ToolStripMenuItem miProfile;
        private System.Windows.Forms.ToolStripMenuItem miSaisirClient;
    }
}

