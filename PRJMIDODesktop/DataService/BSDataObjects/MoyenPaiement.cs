using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSDataObjects
{
    public enum TypeMoyenPaiement { Carte, Chequier };
   
    public class MoyenPaiement
    {
        
        public static string[] getTypesMoyenPaiement()
        {
            return Enum.GetNames(typeof(TypeMoyenPaiement));
        }

        private long idMoyenPaiement;
        private Compte compte;
        private TypeMoyenPaiement libelleMoyenPaiement;

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
    }
}
