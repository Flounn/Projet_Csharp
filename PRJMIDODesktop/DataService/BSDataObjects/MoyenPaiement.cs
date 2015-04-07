using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSDataObjects
{
    public class MoyenPaiement
    {
        protected long idMoyenPaiement;
        protected string libelleMoyenPaiement;

        public long IdMoyenPaiement
        {
            get { return idMoyenPaiement; }
            set { idMoyenPaiement = value; }
        }        

        public string LibelleMoyenPaiement
        {
            get { return libelleMoyenPaiement; }
            set { libelleMoyenPaiement = value; }
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
