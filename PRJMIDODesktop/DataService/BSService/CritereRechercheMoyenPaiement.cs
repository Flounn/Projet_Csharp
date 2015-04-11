using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;

namespace DataService.BSService
{
    public class CritereRechercheMoyenPaiement
    {
        private long idCompte;
        private long idMoyenPaiement;
        private string libelle;

        public long IdCompte
        {
            get { return idCompte; }
            set { idCompte = value; }
        }

        public long IdMoyenPaiement
        {
            get { return idMoyenPaiement; }
            set { idMoyenPaiement = value; }
        }       

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        
    }
}
