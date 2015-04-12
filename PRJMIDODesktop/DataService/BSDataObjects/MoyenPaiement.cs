using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.DAOService;

namespace DataService.BSDataObjects
{
    
   
    public class MoyenPaiement
    {

        public enum TypeMoyenPaiement { Carte, Chequier };

        public static string[] getTypesMoyenPaiement()
        {
            return Enum.GetNames(typeof(TypeMoyenPaiement));
        }

        private long idMoyenPaiement;
        private Compte compte;
        private TypeMoyenPaiement libelleMoyenPaiement;

        public MoyenPaiement(Compte compte, string typeMoyenPaiement)
        {
            this.compte = compte;
            LibelleMoyenPaiementStr = typeMoyenPaiement;
        }

        public long IdMoyenPaiement
        {
            get { return idMoyenPaiement; }
            set { idMoyenPaiement = value; }
        }

        public Compte Compte
        {
            get { return compte; }
            set { compte = value; }
        }

        public TypeMoyenPaiement LibelleMoyenPaiement
        {
            get { return libelleMoyenPaiement; }
            set { libelleMoyenPaiement = value; }
        }

        public string LibelleMoyenPaiementStr
        {
            get { return libelleMoyenPaiement.ToString(); }
            set
            {
                if (value.Equals("Carte"))
                    libelleMoyenPaiement = TypeMoyenPaiement.Carte;
                else if (value.Equals("Chequier"))
                    libelleMoyenPaiement = TypeMoyenPaiement.Chequier;
            }
        }

        public MoyenPaiement() { }

        public override bool Equals(object obj)
        {
            bool b = true;

            if (obj == null)
            {
                b = false;
            }
            else if (!(obj is MoyenPaiement))
            {
                b = false;
            }
            else
            {
                if ((((MoyenPaiement)obj).idMoyenPaiement == this.idMoyenPaiement) &&
                    (((MoyenPaiement)obj).LibelleMoyenPaiement.Equals(this.LibelleMoyenPaiement))
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
            StringBuilder chaine = new StringBuilder("Détail moyen paiement ");
            chaine.Append("Code : " + this.idMoyenPaiement);
            chaine.Append("Libellé : " + this.LibelleMoyenPaiement);

            return chaine.ToString();
        }

        #region DAO MoyenPaiement

        private static DAOMoyenPaiement dao = new DAOMoyenPaiement();

        public bool isPersist()
        {
            return idMoyenPaiement != 0;
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
