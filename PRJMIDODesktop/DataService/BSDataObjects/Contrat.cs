using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSDataObjects
{
    public class Contrat
    {
        public enum Statut_Juridique { Titulaire, Beneficiaire };
        public enum TypeContrat { Credit, Epargne }

        protected long idContrat;
        protected DateTime dateSouscription;
        protected string intitule;
        protected Client client;
        protected Produit produit;
        protected Compte compte;
        protected Statut_Juridique statutJuridique;
        protected TypeContrat type;

        public long IdContrat
        {
            get { return idContrat; }
            set { idContrat = value; }
        }

        public TypeContrat Type
        {
            get { return type; }
            set { type = value; }
        }        

        public string Intitule
        {
            get { return intitule; }
            set { intitule = value; }
        }

        public Statut_Juridique StatutJuridique
        {
            get { return statutJuridique; }
            set { statutJuridique = value; }
        }
        
        public DateTime DateSouscription
        {
            get { return dateSouscription; }
            set { dateSouscription = value; }
        }
        
        public Client Client
        {
            get { return client; }
            set { client = value; }
        }
        
        public Produit Produit
        {
            get { return produit; }
            set { produit = value; }
        }
        

        public Compte Compte
        {
            get { return compte; }
            set { compte = value; }
        }

        public Contrat() { }

        public override bool Equals(object obj)
        {
            bool b = true;

            if (obj == null)
            {
                b = false;
            }
            else if (!(obj is Contrat))
            {
                b = false;
            }
            else
            {
                if ((((Contrat)obj).IdContrat == this.IdContrat) &&
                    (((Compte)obj).Client.Equals(this.Client))
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
            StringBuilder chaine = new StringBuilder("Détail contrat ");
            chaine.Append("Id Contrat : " + this.IdContrat);
            chaine.Append("Id Client : " + this.Client.IdClient);

            return chaine.ToString();
        }
    }
}
