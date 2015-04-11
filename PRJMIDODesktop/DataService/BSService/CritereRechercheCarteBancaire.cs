using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSService
{
    public class CritereRechercheClient
    {
        private int idTypeCarte;
        private string reseauCarte;
        private decimal plfGloPaiement;
        private int periodePlfPaiement;
        private decimal plfRetEtranger;
        private decimal plfGlobalRetraitInternes;//Sur les distributeurs de la banque
        private int periodePlfGlobalRetrait;

        public int IdTypeCarte
        {
            get { return idTypeCarte; }
            set { idTypeCarte = value; }
        }

        public string ReseauCarte
        {
            get { return reseauCarte; }
            set { reseauCarte = value; }
        }        

        public decimal PlfGloPaiement
        {
            get { return plfGloPaiement; }
            set { plfGloPaiement = value; }
        }        

        public int PeriodePlfPaiement
        {
            get { return periodePlfPaiement; }
            set { periodePlfPaiement = value; }
        }

        public decimal PlfRetEtranger
        {
            get { return plfRetEtranger; }
            set { plfRetEtranger = value; }
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
