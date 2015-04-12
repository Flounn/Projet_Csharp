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
        private Compte compte;
        private Statut_Juridique statutJuridique;
        private TypeContrat type;

        public Contrat(string intitule, Client client, Compte compte, string statutJuridique, string typeContrat)
        {
            this.intitule = intitule;
            this.dateSouscription = DateTime.Now;
            this.client = client;
            this.compte = compte;
            this.StatutJuridiqueStr = statutJuridique;
            this.TypeStr = typeContrat;
        }

        public Contrat(string intitule, Client client, Compte compte, string statutJuridique, TypeContrat typeContrat)
        {
            this.intitule = intitule;
            this.dateSouscription = DateTime.Now;
            this.client = client;
            this.compte = compte;
            this.StatutJuridiqueStr = statutJuridique;
            this.Type = typeContrat;
        }

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
                type = (TypeContrat)Enum.Parse(typeof(TypeContrat), value, true);
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
                statutJuridique = (Statut_Juridique)Enum.Parse(typeof(Statut_Juridique), value, true);
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
