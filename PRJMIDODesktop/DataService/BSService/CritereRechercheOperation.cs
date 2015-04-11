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
        private string statut;
        private long idCompte;
        private string typeOperation;
        private long idMoyenPaiement;
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public bool isCredit()
        {
            return type.Equals(DataService.BSDataObjects.Operation.Type_Operation.Credit.ToString());
        }
        public bool isDebit()
        {
            return type.Equals(DataService.BSDataObjects.Operation.Type_Operation.Debit.ToString());
        }

        public DateTime DateOperationDebut
        {
            get { return dateOperationDebut; }
            set { dateOperationDebut = value; }
        }

        public DateTime DateOperationFin
        {
            get { return dateOperationFin; }
            set { dateOperationFin = value; }
        }

        public long IdMoyenPaiement
        {
            get { return idMoyenPaiement; }
            set { idMoyenPaiement = value; }
        }

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

        public long IdCompte
        {
            get { return idCompte; }
            set { idCompte = value; }
        }

        public string TypeOperation
        {
            get { return typeOperation; }
            set { typeOperation = value; }
        }

        public string Statut
        {
            get { return statut.ToString(); }
            set { statut = value; }
        }
    }
}
