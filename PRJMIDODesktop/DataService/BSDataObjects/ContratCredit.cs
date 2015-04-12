using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.DAOService;

namespace DataService.BSDataObjects
{
    public class ContratCredit: Contrat
    {

        private static readonly string[] valuesPeriodicite = { "Hebdomadaire", "Mensuel" };

        public static string[] ValuesPeriodicite
        {
            get { return ContratCredit.valuesPeriodicite; }
        } 


        private string objectifCredit;
        private DateTime dateEcheance;
        private int duree;
        private decimal taux;
        private decimal montantCredit;
        private DateTime dateProchaineEcheance;   
        private decimal montantEcheance;
        private decimal tauxNominal;
        private decimal encours;

        public ContratCredit() { }

        public ContratCredit(long idContrat, string objectifCredit,
            int duree, decimal taux, decimal montantCredit)
        {
            this.IdContrat = idContrat;
            this.dateEcheance = DateTime.Today.AddYears(duree);
            this.duree = duree;
            this.taux = taux;
            this.montantCredit = montantCredit;
        }

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

        /*#region DAO ContratCredit

        private static DAOContrat dao = new DAOContrat();

        public bool isPersist()
        {
            return idContrat != 0;
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
        #endregion*/

    }
}
