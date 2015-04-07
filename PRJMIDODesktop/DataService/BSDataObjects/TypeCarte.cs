using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSDataObjects
{
    public class TypeCarte
    {
        private int idTypeCarte;
        private decimal plfGloPaiement;
        private decimal plfGloPaiementEtranger;
        private int periodePlfPaiement;
        private decimal plfGlobalRetraitExterne; //Sur les tous les distributeurs
        private decimal plfRetEtranger;
        private decimal plfRetraitFrance;
        private decimal plfGlobalRetraitInternes; //Sur les distributeurs de la banque
        private int periodePlfGlobalRetrait;
        private IList<MoyenPaiement> moyensPaiements;

        public int IdTypeCarte
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
    }
}
