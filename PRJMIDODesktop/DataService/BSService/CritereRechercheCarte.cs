using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSService
{
    public class CritereRechercheCarte
    {
        private int idTypeCarte;
        private string numero;
        private long idMoyenPaiement;

        public long IdMoyenPaiement
        {
            get { return idMoyenPaiement; }
            set { idMoyenPaiement = value; }
        } 

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public int IdTypeCarte
        {
            get { return idTypeCarte; }
            set { idTypeCarte = value; }
        }

       
    }
}
