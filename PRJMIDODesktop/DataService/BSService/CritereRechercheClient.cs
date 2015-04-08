using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSService
{
    public class CritereRechercheClient
    {
        private long idClient;
        private string nom;
        private string prenom;
        private DateTime dateNaissanceDebut;
        private DateTime dateNaissanceFin;
        private string email;
        private string adresse;

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

        public DateTime DateNaissanceDebut
        {
            get { return dateNaissanceDebut; }
            set { dateNaissanceDebut = value; }
        }        

        public DateTime DateNaissanceFin
        {
            get { return dateNaissanceFin; }
            set { dateNaissanceFin = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
    }
}
