using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSDataObjects
{
    public class ContratEpargne: Contrat
    {

        private string typeEpargne;
        private string typeVersement;
        private string periodicite;
        private DateTime dateVersement;
        private decimal montantVerse;

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
    }
}
