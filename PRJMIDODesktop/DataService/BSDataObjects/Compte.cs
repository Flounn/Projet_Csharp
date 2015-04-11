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

        private long idCompte;
        private Type typeCompte;        
        private DateTime dateOuverture;
        private decimal montantInitial;
        private Client client;
        private IList<Contrat> listeContrats;

        public long IdCompte
        {
            get { return idCompte; }
            set { idCompte = value; }
        }

        public Type TypeCompte
        {
            get { return typeCompte; }
            set { typeCompte = value; }
        }
        public string TypeCompteStr
        {
            get { return typeCompte.ToString(); }
            set
            {
                if (value.Equals("Courant"))
                    typeCompte = Type.Courant;
                else if (value.Equals("Epargne"))
                    typeCompte = Type.Epargne;
            }
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

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public IList<Contrat> ListeContrats
        {
            get { return listeContrats; }
            set { listeContrats = value; }
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
                if ((((Compte)obj).IdCompte == this.IdCompte) &&
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
            chaine.Append("Id compte : " + this.IdCompte);
            chaine.Append("Id Client : " + this.Client.IdClient);
           
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