using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataService.BSDataObjects;
using DataService.DAOService;
using DataService.BSService;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace DesktopIHM.GuiObjects
{
    public partial class FenDetailClient : Form,Updates
    {
        private Client client;
        private UpdateDataGridView callback;

        public FenDetailClient(Client client,UpdateDataGridView callback)
        {
            InitializeComponent();
            this.client = client;
            this.callback = callback;
            initUi();
        }

        private void initRoles()
        {
            if (Session.isConsultation())
            {
                bt_ajouter_compte.Visible = false;
                bt_ajouter_contrat.Visible = false;
                btModifier.Visible = false;
                btSupprimer.Visible = false;
            }
            if (Session.isOperateurDeSaisie())
                btSupprimer.Visible = false;
        }

        public FenDetailClient(Client client)
        {
            InitializeComponent();
            this.client = client;
            initUi();
        }

        private void initUi(){
            initData();
            dtDateNaissance.MaxDate = DateTime.Today;
            initRoles();
        }

        public void initContrats()
        {
            CritereRechercheContrat crtRechercheContrat = new CritereRechercheContrat();
            crtRechercheContrat.IdClient = client.IdClient;
            dgvLstContrats.DataSource = BSGestionClient.RechercherContrats(crtRechercheContrat);
        }

        public void initComptes()
        {
            CritereRechercheCompte crtRechercheCompte = new CritereRechercheCompte();
            crtRechercheCompte.IdClient = client.IdClient;
            dgvLstComptes.DataSource = BSGestionClient.RechercherComptes(crtRechercheCompte);
        }

        private void initData()
        {
            if (client != null)
            {
                this.txtId.Text = client.IdClient.ToString();
                this.txtNom.Text= client.Nom;
                this.txtPrenom.Text = client.Prenom;
                this.dtDateNaissance.Value = client.DateNaissance;
                this.txtEmail.Text = client.Email;
                this.txtAdressePrinc.Text = client.AdressePrincipale;
                this.txtAdresseTemp.Text = client.AdresseTemporaire;
                this.txtTelFixe.Text = client.TelFixe;
                this.txtTelPort.Text = client.TelPortable;

                initContrats();
                initComptes();
                
            }
        }

        void dgvLstComptes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            new FenDetailCompte(getCompteSelected(e.RowIndex),this).Show(this);
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            if (this.txtNom.Enabled == true)
            {
                if (string.IsNullOrEmpty(txtNom.Text))
                {
                    Utilities.showErrorMessage("Le nom du client n'a pas été renseigné","Modification des données");
                    return;
                }
                if (string.IsNullOrEmpty(txtPrenom.Text))
                {
                    Utilities.showErrorMessage("Le prenom du client n'a pas été renseigné","Modification des données");
                    return;
                }
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    Utilities.showErrorMessage("L' email du client n'a pas été renseigné","Modification des données");
                    return;
                }
                if (!Utilities.isEmailValid(txtEmail.Text))
                {
                    Utilities.showErrorMessage("L' email du client n'a pas été renseigné correctement","Modification des données");
                    return;
                }
                client.Nom = this.txtNom.Text;
                client.Prenom = this.txtPrenom.Text;
                client.DateNaissance = this.dtDateNaissance.Value;
                client.Email = this.txtEmail.Text;
                client.AdressePrincipale = this.txtAdressePrinc.Text;
                client.AdresseTemporaire = this.txtAdresseTemp.Text;
                client.TelFixe = this.txtTelFixe.Text;
                client.TelPortable = this.txtTelPort.Text;
                if(MessageBox.Show("Etes-vous sûr de vouloir modifier les données du client?", 
                    "Modification des données", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                {
                    if (BSGestionClient.CreerModifierClient(client))
                    {
                        Utilities.showInfoMessage("Client modifié avec succès", "Client modification");
                        this.txtNom.Enabled = false;
                        this.txtPrenom.Enabled = false;
                        this.dtDateNaissance.Enabled = false;
                        this.txtEmail.Enabled = false;
                        this.txtAdressePrinc.Enabled = false;
                        this.txtAdresseTemp.Enabled = false;
                        this.txtTelFixe.Enabled = false;
                        this.txtTelPort.Enabled = false;
                        if (callback != null)
                            callback.refresh();
                    }
                    else
                        Utilities.showErrorMessage("Erreur lors de la modification du client", "Erreur");
                }
            }
            else
            {
                this.txtNom.Enabled = true;
                this.txtPrenom.Enabled = true;
                this.dtDateNaissance.Enabled = true;
                this.txtEmail.Enabled = true;
                this.txtAdressePrinc.Enabled = true;
                this.txtAdresseTemp.Enabled = true;
                this.txtTelFixe.Enabled = true;
                this.txtTelPort.Enabled = true;
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer le client?",
                    "Supprimer un client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
            {
                if (BSGestionClient.SupprimerClient(client))
                {
                    Utilities.showInfoMessage("Le client vient d'être supprimé", "Supprimer un client");
                    if (callback != null)
                        callback.refresh();
                    this.Close();
                }
                else
                    Utilities.showErrorMessage("Erreur lors de la suppression du client","Erreur");
            }
        }

        void dgvLstContrats_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            new FenDetailContrat(getContratRow(e.RowIndex), this).Show(this);
        }

        private Contrat getContratRow(int index)
        {
            if (index < 0)
                return null;
            Client client = new Client();
            client.IdClient = (int)dgvLstContrats.Rows[index].Cells[3].Value;
            Compte compte = new Compte();
            compte.IdCompte = (int)dgvLstContrats.Rows[index].Cells[4].Value;
            compte.Client = client;
            return new Contrat((int)dgvLstContrats.Rows[index].Cells[0].Value, (DateTime)dgvLstContrats.Rows[index].Cells[1].Value,
                (string)dgvLstContrats.Rows[index].Cells[2].Value, client, compte, (string)dgvLstContrats.Rows[index].Cells[5].Value,
                (string)dgvLstContrats.Rows[index].Cells[6].Value);
        }

        void dgvLstComptes_SelectionChanged(object sender, System.EventArgs e)
        {
            if (dgvLstComptes.SelectedRows.Count==0){
                dgvLstOperations.DataSource=null;
                return;
            }

            CritereRechercheOperation crtRechercheOperation = new CritereRechercheOperation();
            crtRechercheOperation.IdCompte = (int)dgvLstComptes.SelectedRows[0].Cells[0].Value;
            dgvLstOperations.DataSource = BSGestionClient.RechercherOperations(crtRechercheOperation);
        }

        private void bt_ajouter_compte_Click(object sender, EventArgs e)
        {
            new FenSaisirCompte(client, this).Show(this);
        }

        private void bt_ajouter_contrat_Click(object sender, EventArgs e)
        {
            new FenSaisirContrat(client,this).Show(this);
        }

        private void btImprimer_Click(object sender, EventArgs e)
        {

            //Exporting to PDF
            string folderPath = Path.GetTempPath();
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Releve.pdf", FileMode.Create))
            {
                PdfPTable pdfTable = pdfIntitule();
                Paragraph p1 = new Paragraph("Informations sur le compte: ", FontFactory.GetFont(FontFactory.TIMES, 12));
                p1.SpacingAfter = 10;
                p1.SpacingBefore = 10;
                p1.Alignment = Element.ALIGN_CENTER;
                Paragraph p2 = new Paragraph("Relevé du compte: ", FontFactory.GetFont(FontFactory.TIMES, 12));
                p2.SpacingAfter = 10;
                p2.SpacingBefore = 10;
                p2.Alignment = Element.ALIGN_CENTER;
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfTable = pdfDetailClient();
                pdfDoc.Add(pdfTable);
                pdfTable = pdfCompteTable(dgvLstComptes);
                pdfDoc.Add(p1);
                pdfDoc.Add(pdfTable);
                pdfTable = pdfOperationTable(dgvLstOperations);
                pdfDoc.Add(p2);
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();

                System.Diagnostics.Process.Start(folderPath + "Releve.pdf");
                
            }
        }

        private PdfPTable pdfIntitule()
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(1);
            pdfTable.DefaultCell.Padding = 10;
            pdfTable.WidthPercentage = 20;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding DataRow
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(DesktopIHM.Properties.Resources.forPdf, System.Drawing.Imaging.ImageFormat.Png);
            image.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            image.ScaleAbsolute(120f, 120f);
            pdfTable.AddCell(new PdfPCell(image));

            pdfTable.SpacingAfter = 25;
            return pdfTable;
        }
        
        private PdfPTable pdfDetailClient()
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(1);
            pdfTable.DefaultCell.Padding = 10;
            pdfTable.WidthPercentage = 35;
            pdfTable.HorizontalAlignment = Element.ALIGN_RIGHT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding DataRow
            PdfPCell myCell = new PdfPCell(new Phrase(txtNom.Text + " " + txtPrenom.Text + 
                "\n" + txtAdressePrinc.Text + 
                "\nTel: " + txtTelPort.Text + 
                "\nNumero Client:" + txtId.Text + 
                "\n\n\n\n", iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES, 12)));
            myCell.HorizontalAlignment = Element.ALIGN_LEFT;
            myCell.BorderColor = BaseColor.WHITE;
            pdfTable.AddCell(myCell);

            pdfTable.SpacingBefore = 10;
            pdfTable.SpacingAfter = 25;
            return pdfTable;
        }

        private PdfPTable pdfCompteTable(DataGridView dgv)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 80;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;
            float[] widths = new float[] { 30f, 40f, 40f, 30f, 40f };
            pdfTable.SetWidths(widths);

            //Adding Header row
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_BOLD, 8)));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewCell cell in dgv.SelectedRows[0].Cells)
            {
                PdfPCell myCell = new PdfPCell(new Phrase(cell.Value.ToString(), iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES, 8)));
                myCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfTable.AddCell(myCell);
            }
            pdfTable.SpacingAfter = 5;
            pdfTable.SpacingAfter = 10;
            return pdfTable;
        }

        private PdfPTable pdfOperationTable(DataGridView dgv)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount - 4);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 80;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;
            float[] widths = new float[] { 30f, 40f, 40f, 30f, 40f, 30f};
            pdfTable.SetWidths(widths);

            //Adding Header row
            for (int i = 0; i < dgv.Columns.Count; i++ )
            {
                if (i != 1 && i != 2 && i != 4 && i != 6)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dgv.Columns[i].HeaderText, iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_BOLD, 8)));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    pdfTable.AddCell(cell);
                }
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    
                }
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (i != 1 && i != 2 && i != 4 && i != 6)
                    {
                        PdfPCell myCell = new PdfPCell(new Phrase(row.Cells[i].Value.ToString(), iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES, 8)));
                        myCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        pdfTable.AddCell(myCell);
                    }
                }
            }
            pdfTable.SpacingAfter = 5;
            pdfTable.SpacingAfter = 10;
            return pdfTable;
        }

        private Compte getCompteSelected(int index)
        {
            if (index<0)
                return null;
            return new Compte((int)dgvLstComptes.Rows[index].Cells[0].Value, (string)dgvLstComptes.Rows[index].Cells[4].Value,
                (DateTime)dgvLstComptes.Rows[index].Cells[1].Value,(decimal)dgvLstComptes.Rows[index].Cells[2].Value, this.client);
        }

        public void UpdateContrats()
        {
            initContrats();
        }

        public void UpdateComptes()
        {
            initComptes();
        }
    }
}