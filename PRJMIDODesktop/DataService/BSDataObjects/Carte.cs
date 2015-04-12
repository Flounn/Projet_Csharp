using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.DAOService;

namespace DataService.BSDataObjects
{
    public class Carte : MoyenPaiement
    {
        private string numeroCarte;
        private DateTime dateDebValidite;
        private DateTime dateFinValidite;
        private TypeCarte typeCarte;
        public Carte() { }
        public Carte(long idMoyenPaiement, DateTime dateDebValidite, 
            DateTime dateFinValidite, string numeroCarte, TypeCarte typeCarte) 
        {
            this.IdMoyenPaiement = idMoyenPaiement;
            this.dateDebValidite = dateDebValidite;
            this.dateFinValidite = dateFinValidite;
            this.numeroCarte = numeroCarte;
            this.typeCarte = typeCarte;
        }

        public string NumeroCarte
        {
            get { return numeroCarte; }
            set { numeroCarte = value; }
        }
        

        public DateTime DateDebValidite
        {
            get { return dateDebValidite; }
            set { dateDebValidite = value; }
        }
        

        public DateTime DateFinValidite
        {
            get { return dateFinValidite; }
            set { dateFinValidite = value; }
        }
        
        public TypeCarte TypeCarte
        {
            get { return typeCarte; }
            set { typeCarte = value; }
        }

        public override bool Equals(object obj)
        {
            bool b = true;

            if (obj == null)
            {
                b = false;
            }
            else if (!(obj is Carte))
            {
                b = false;
            }
            else
            {
                if ((((Carte)obj).NumeroCarte == this.NumeroCarte))
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
            StringBuilder chaine = new StringBuilder("Détail carte ");
            chaine.Append("Référence : " + this.NumeroCarte);            

            return chaine.ToString();
        }

        #region DAO Carte

        private static DAOCarte dao = new DAOCarte();

        public bool persist()
        {
            return dao.insert(this);
        }
        public bool delete()
        {
            return dao.delete(this);
        }

        #endregion
    }
}
