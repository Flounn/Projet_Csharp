using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.DAOService;

namespace DataService.BSDataObjects
{
    public class Compte
    {
        public enum Type { Courant, Epargne };

        private long numeroCompte;
        private Type typeCompte;        
        private DateTime dateOuverture;
        private decimal montantInitial;
        private Client client;
        private MoyenPaiement moyenPaiement;

        public long NumeroCompte
        {
            get { return numeroCompte; }
            set { numeroCompte = value; }
        }

        public Type TypeCompte
        {
            get { return typeCompte; }
            set { typeCompte = value; }
        }

        public DateTime DateOuverture
        {
            get { return dateOuverture; }
            set { dateOuverture = value; }
        }
        

        public decimal MontantInitial
        {
            get { return montantInitial; }
            set { montantInitial = value; }
        }


        public MoyenPaiement MoyenPaiement
        {
            get { return moyenPaiement; }
            set { moyenPaiement = value; }
        }

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public override bool Equals(object obj)
        {
            bool b = true;

            if (obj == null)
            {
                b = false;
            }
            else if (!(obj is Compte))
            {
                b = false;
            }
            else
            {
                if ((((Compte)obj).NumeroCompte == this.NumeroCompte) &&
                    (((Compte)obj).Client.Equals(this.Client))
                )
                {
                    b = true;
                }
                else
                {
                    b = false;
                }
            }
            return b;
        }

        public override string ToString()
        {
            StringBuilder chaine = new StringBuilder("Détail compte ");
            chaine.Append("Numéro compte : " + this.NumeroCompte);
            chaine.Append("Numéro Client : " + this.Client.NumeroClient);
           
            return chaine.ToString();
        }


        #region DAO Compte

        private static DAOCompte dao = new DAOCompte();

        public bool insert()
        {
            return dao.insert(this);
        }

        #endregion


    }
}