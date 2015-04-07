﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSDataObjects
{
    public class Produit
    {
        private long idProduit;
        private string libelle;
        private IList<Contrat> listeContrats;    

        public long IdProduit
        {
            get { return idProduit; }
            set { idProduit = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public Produit() { }

        public override bool Equals(object obj)
        {
            bool b = true;

            if (obj == null)
            {
                b = false;
            }
            else if (!(obj is Produit))
            {
                b = false;
            }
            else
            {
                if ((((Produit)obj).CodeProduit == this.CodeProduit) &&
                    (((Produit)obj).Libelle.Equals(this.Libelle))
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
            StringBuilder chaine = new StringBuilder("Détail produit ");
            chaine.Append("Code  : " + this.CodeProduit);
            chaine.Append("Libelle : " + this.Libelle);

            return chaine.ToString();
        }
    }
}
