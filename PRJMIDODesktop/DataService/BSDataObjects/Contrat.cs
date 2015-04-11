using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.DAOService;

namespace DataService.BSDataObjects
{
    public class Contrat
    {
        public enum Statut_Juridique { Titulaire, Beneficiaire };
        public static string[] getStatutJuridique()
        {
            return Enum.GetNames(typeof(Statut_Juridique));
        }
        public enum TypeContrat { Credit, Epargne }
        public static string[] getTypesContrat()
        {
            return Enum.GetNames(typeof(TypeContrat));
        }

        private long idContrat;
        private DateTime dateSouscription;
        private string intitule;
        private Client client;
        private Produit produit;
        private Compte compte;
        private Statut_Juridique statutJuridique;
        private TypeContrat type;

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

        public string TypeStr
        {
            get { return type.ToString(); }
            set
            {
                if (value.Equals("Credit"))
                    type = TypeContrat.Credit;
                else if (value.Equals("Epargne"))
                    type = TypeContrat.Epargne;
            }
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

        public string StatutJuridiqueStr
        {
            get { return statutJuridique.ToString(); }
            set { 
                if(value.Equals("Beneficiaire"))
                    statutJuridique = Statut_Juridique.Beneficiaire;
                else if(value.Equals("Titulaire"))
                    statutJuridique = Statut_Juridique.Titulaire;
            }
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

        #region DAO Contrat

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
        #endregion
    }
}
