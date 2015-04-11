using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.DAOService;

namespace DataService.BSDataObjects
{
    public class Client
    {
        private long idClient;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string email;
        private string adressePrincipale;
        private string adresseTemporaire;
        private string telFixe;
        private string telPortable;
        private IList<HistoriqueEtudiant> historique;
        private IList<Contrat> listeContrats;
        private IList<Compte> listeComptes;

        public Client()
        {
            historique = new List<HistoriqueEtudiant>();
            listeContrats = new List<Contrat>();
            listeComptes = new List<Compte>();
        }

        public Client(long id, string nom, string prenom, DateTime ddn, string email, string adr_princ, string adr_temp, string tel_fixe, string tel_port)
        {
            this.idClient = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = ddn;
            this.email = email;
            this.adressePrincipale = adr_princ;
            this.adresseTemporaire = adr_temp;
            this.telFixe = tel_fixe;
            this.telPortable = tel_port;
        }

        public Client(string nom, string prenom, DateTime ddn, string email, string adr_princ, string adr_temp, string tel_fixe, string tel_port)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = ddn;
            this.email = email;
            this.adressePrincipale = adr_princ;
            this.adresseTemporaire = adr_temp;
            this.telFixe = tel_fixe;
            this.telPortable = tel_port;
        }

        
        public IList<HistoriqueEtudiant> Historique
        {
            get { return historique; }
            set { historique = value; }
        }

        public long IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }
        

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }
        

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        

        public string AdressePrincipale
        {
            get { return adressePrincipale; }
            set { adressePrincipale = value; }
        }
        

        public string AdresseTemporaire
        {
            get { return adresseTemporaire; }
            set { adresseTemporaire = value; }
        }
        

        public string TelFixe
        {
            get { return telFixe; }
            set { telFixe = value; }
        }
        

        public string TelPortable
        {
            get { return telPortable; }
            set { telPortable = value; }
        }

        public override bool Equals(object obj)
        {
            bool b = true;

            if(obj == null)
            {
                b = false ;
            }
            else if (!(obj is Client))
            {
                b = false;
            }
            else
            {
                if((((Client)obj).IdClient == this.IdClient) &&
                    (((Client)obj).Nom == this.Nom) &&
                    (((Client)obj).Prenom == this.Prenom) &&
                    (((Client)obj).Email == this.Email)
                )
                {
                    b = true ;
                }
                else
                {
                    b = false ;
                }              
            }
            return b;
        }

        public override string ToString()
        {
            StringBuilder chaine = new StringBuilder("Détail du client ");
            chaine.Append("Numéro du client : " + this.IdClient);
            chaine.Append("Nom : "+this.Nom);
            chaine.Append("Prénom : "+this.Prenom);
            chaine.Append("Date de Naissance : "+this.DateNaissance);
            chaine.Append("Email : "+this.Email);
            chaine.Append("Adresse Principale : "+this.AdressePrincipale);
            chaine.Append("Adresse Temporaire : "+this.AdressePrincipale);
            chaine.Append("Tel Fixe : "+this.TelFixe);
            chaine.Append("Tel Portable : "+this.TelFixe);

            return chaine.ToString();
        }

        #region DAO Client

        private static DAOClient dao = new DAOClient();

        public bool isPersist()
        {
            return idClient != 0;
        }

        public bool persist()
        {
            if (isPersist())
                return dao.update(this);
            else return dao.insert(this);
        }
        public bool delete()
        {
            if (!isPersist())
                return false;
            return dao.delete(this);
        }
       
        #endregion
    }
}
