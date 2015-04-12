using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.DAOService;

namespace DataService.BSDataObjects
{
    public class ContratEpargne: Contrat
    {
        private static readonly string[] valuesTypeEpargne = { "Assurance vie", "Livret A", "Livret DD", "Epargne logement", "Epargne retraite" };

        public static string[] ValuesTypeEpargne
        {
            get { return ContratEpargne.valuesTypeEpargne; }
        } 

        private string typeEpargne;
        private string typeVersement;
        private string periodicite;
        private DateTime dateVersement;
        private decimal montantVerse;
        private decimal montantEpargne;

        public decimal MontantEpargne
        {
            get { return montantEpargne; }
            set { montantEpargne = value; }
        }

        public ContratEpargne() { }

        public ContratEpargne(string typeEpargne, string typeVersement, string periodicite,
            DateTime dateVersement, decimal montantVerse)
        {
            this.typeEpargne = typeEpargne;
            this.typeVersement = typeVersement;
            this.periodicite = periodicite;
            this.dateVersement = dateVersement;
            this.montantVerse = montantVerse;
        }

        public string TypeEpargne
        {
            get { return typeEpargne; }
            set { typeEpargne = value; }
        }        

        public string TypeVersement
        {
            get { return typeVersement; }
            set { typeVersement = value; }
        }       

        public string Periodicite
        {
            get { return periodicite; }
            set { periodicite = value; }
        }        

        public DateTime DateVersement
        {
            get { return dateVersement; }
            set { dateVersement = value; }
        }        

        public decimal MontantVerse
        {
            get { return montantVerse; }
            set { montantVerse = value; }
        }

        #region DAO ContratEpargne

        private static DAOContratEpargne dao = new DAOContratEpargne();

        public bool isPersist()
        {
            return IdContrat != 0;
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
