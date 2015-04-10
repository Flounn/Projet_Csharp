using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;

namespace DataService.BSService
{
	public class CritereRechercheOperation
	{
        private long idOperation;
        private string libelle;
        private DateTime dateOperationDebut;
        private DateTime dateOperationFin;
        private decimal montantDebit;
        private decimal montantCredit;
        private DataService.BSDataObjects.Operation.StatutOperation statut;
        private long idCompte;
        private DataService.BSDataObjects.Operation.Type_Operation typeOperation;

        public long IdOperation
        {
            get { return idOperation; }
            set { idOperation = value; }
        }       

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }         

        public decimal MontantDebit
        {
            get { return montantDebit; }
            set { montantDebit = value; }
        }       

        public decimal MontantCredit
        {
            get { return montantCredit; }
            set { montantCredit = value; }
        }       

        public long IdCompte
        {
            get { return idCompte; }
            set { idCompte = value; }
        }

        public string TypeOperation
        {
            get { return typeOperation.ToString(); }
            set
            {
                if (value.Equals("Credit"))
                    typeOperation = DataService.BSDataObjects.Operation.Type_Operation.Credit;
                else if (value.Equals("Debit"))
                    typeOperation = DataService.BSDataObjects.Operation.Type_Operation.Debit;
            }
        }

        public string Statut
        {
            get { return statut.ToString(); }
            set
            {
                if (value.Equals("EnCours"))
                    statut = DataService.BSDataObjects.Operation.StatutOperation.EnCours;
                else if (value.Equals("Realise"))
                    statut = DataService.BSDataObjects.Operation.StatutOperation.Realise;
            }
        } 
	}
}
