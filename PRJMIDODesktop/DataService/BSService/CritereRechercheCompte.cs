using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;

namespace DataService.BSService
{
    public class CritereRechercheCompte
    {
        private long idCompte;
        private DataService.BSDataObjects.Compte.Type typeCompte;
        private DateTime dateOuvertureDebut;
        private DateTime dateOuvertureFin;
        private long idClient;
        private long idMoyenPaiement;

        public long IdCompte
        {
            get { return idCompte; }
            set { idCompte = value; }
        }

        public string TypeCompte
        {
            get { return typeCompte.ToString(); }
            set
            {
                if (value.Equals("Courant"))
                    typeCompte = DataService.BSDataObjects.Compte.Type.Courant;
                else if (value.Equals("Epargne"))
                    typeCompte = DataService.BSDataObjects.Compte.Type.Epargne;
            }
        }      

        public DateTime DateOuvertureDebut
        {
            get { return dateOuvertureDebut; }
            set { dateOuvertureDebut = value; }
        }        

        public DateTime DateOuvertureFin
        {
            get { return dateOuvertureFin; }
            set { dateOuvertureFin = value; }
        }        

        public long Client
        {
            get { return idClient; }
            set { idClient = value; }
        }        

        public long IdMoyenPaiement
        {
            get { return idMoyenPaiement; }
            set { idMoyenPaiement = value; }
        }
    }
}
