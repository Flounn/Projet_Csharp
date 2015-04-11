using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.DAOService;

namespace DataService.BSDataObjects
{
    public enum ReseauCarteBancaire {Visa, MasterCard}
    
    public class TypeCarte
    {
        private long idTypeCarte;
        private ReseauCarteBancaire reseauCarte;
        private decimal plfGloPaiement;
        private decimal plfGloPaiementEtranger;
        private int periodePlfPaiement;
        private decimal plfGlobalRetraitExterne; //Sur tous les distributeurs
        private decimal plfRetEtranger;
        private decimal plfRetraitFrance;
        private decimal plfGlobalRetraitInternes; //Sur les distributeurs de la banque
        private int periodePlfGlobalRetrait;

        public ReseauCarteBancaire ReseauCarte
        {
            get { return reseauCarte; }
            set { reseauCarte = value; }
        }

        public string ReseauCarteStr
        {
            get { return reseauCarte.ToString(); }
            set
            {
                if (value.Equals("Visa"))
                    reseauCarte = ReseauCarteBancaire.Visa;
                else if (value.Equals("MasterCard"))
                    reseauCarte = ReseauCarteBancaire.MasterCard;
            }
        }

        public long IdTypeCarte
        {
            get { return idTypeCarte; }
            set { idTypeCarte = value; }
        }        

        public decimal PlfGloPaiement
        {
            get { return plfGloPaiement; }
            set { plfGloPaiement = value; }
        }        

        public decimal PlfGloPaiementEtranger
        {
            get { return plfGloPaiementEtranger; }
            set { plfGloPaiementEtranger = value; }
        }        

        public int PeriodePlfPaiement
        {
            get { return periodePlfPaiement; }
            set { periodePlfPaiement = value; }
        }       

        public decimal PlfGlobalRetraitExterne
        {
            get { return plfGlobalRetraitExterne; }
            set { plfGlobalRetraitExterne = value; }
        }        

        public decimal PlfRetEtranger
        {
            get { return plfRetEtranger; }
            set { plfRetEtranger = value; }
        }        

        public decimal PlfRetraitFrance
        {
            get { return plfRetraitFrance; }
            set { plfRetraitFrance = value; }
        }        

        public decimal PlfGlobalRetraitInternes
        {
            get { return plfGlobalRetraitInternes; }
            set { plfGlobalRetraitInternes = value; }
        }        

        public int PeriodePlfGlobalRetrait
        {
            get { return periodePlfGlobalRetrait; }
            set { periodePlfGlobalRetrait = value; }
        }

        #region DAO TypeCarte

        private static DAOTypeCarte dao = new DAOTypeCarte();

        public bool isPersist()
        {
            return idTypeCarte != 0;
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
