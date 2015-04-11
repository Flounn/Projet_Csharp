using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSDataObjects
{
    public class Operation
    {
        public enum StatutOperation {Realise,EnCours};
        public enum Type_Operation { Debit, Credit };

        private long idOperation;
        private string libelle;
        private DateTime dateComptable;
        private DateTime dateOperation;
        private DateTime dateValeur;
        private decimal montantDebit;
        private decimal montantCredit;
        private StatutOperation statut;
        private Compte compte;
        private Type_Operation typeOperation;
        private MoyenPaiement moyenPaiement;

        public Type_Operation TypeOperation
        {
            get { return typeOperation; }
            set { typeOperation = value; }
        }

        public string TypeOperationStr
        {
            get { return typeOperation.ToString(); }
            set
            {
                if (value.Equals("Credit"))
                    typeOperation = Type_Operation.Credit;
                else if (value.Equals("Debit"))
                    typeOperation = Type_Operation.Debit;
            }
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
        

        public DateTime DateComptable
        {
            get { return dateComptable; }
            set { dateComptable = value; }
        }
        

        public DateTime DateOperation
        {
            get { return dateOperation; }
            set { dateOperation = value; }
        }
        

        public DateTime DateValeur
        {
            get { return dateValeur; }
            set { dateValeur = value; }
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

        public string StatutStr
        {
            get { return statut.ToString(); }
            set
            {
                if (value.Equals("EnCours"))
                    statut = StatutOperation.EnCours;
                else if (value.Equals("Realise"))
                    statut = StatutOperation.Realise;
            }
        }   

        

        public Compte Compte
        {
            get { return compte; }
            set { compte = value; }
        }

        public MoyenPaiement MoyenPaiements
        {
            get { return moyenPaiement; }
            set { moyenPaiement = value; }
        }

        public Operation() { }

        public override bool Equals(object obj)
        {
            bool b = true;

            if (obj == null)
            {
                b = false;
            }
            else if (!(obj is Operation))
            {
                b = false;
            }
            else
            {
                if ((((Operation)obj).IdOperation == this.IdOperation) &&
                    (((Operation)obj).Compte.IdCompte.Equals(this.Compte.IdCompte))
                )
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
            StringBuilder chaine = new StringBuilder("Détail opération ");
            chaine.Append("Id : " + this.IdOperation);
            chaine.Append("Compte concerné : " + this.Compte.IdCompte);

            return chaine.ToString();
        }
    }
}