using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSDataObjects
{
    public class ContratCredit: Contrat
    {
        private string objectifCredit;
        private DateTime dateEcheance;
        private int duree;
        private decimal taux;
        private decimal montantCredit;
        private DateTime dateProchaineEcheance;   
        private decimal montantEcheance;
        private decimal tauxNominal;
        private decimal encours;

        public string ObjectifCredit
        {
            get { return objectifCredit; }
            set { objectifCredit = value; }
        }

        public DateTime DateEcheance
        {
            get { return dateEcheance; }
            set { dateEcheance = value; }
        }

        public int Duree
        {
            get { return duree; }
            set { duree = value; }
        }

        public decimal Taux
        {
            get { return taux; }
            set { taux = value; }
        }

        public decimal MontantCredit
        {
            get { return montantCredit; }
            set { montantCredit = value; }
        }

        public decimal MontantEcheance
        {
            get { return montantEcheance; }
            set { montantEcheance = value; }
        }
        public decimal TauxNominal
        {
            get { return tauxNominal; }
            set { tauxNominal = value; }
        }
        public decimal Encours
        {
            get { return encours; }
            set { encours = value; }
        }

    }
}
