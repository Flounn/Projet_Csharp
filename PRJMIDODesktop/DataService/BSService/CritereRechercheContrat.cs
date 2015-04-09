using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSService
{
    public class CritereRechercheContrat
    {
        private long idContrat;
        private DateTime dateSouscriptionDebut;
        private DateTime dateSouscriptionFin;
        private string intitule;
        private long idClient;
        private long idProduit;
        private long idCompte;

        public long IdContrat
        {
            get { return idContrat; }
            set { idContrat = value; }
        }        

        public DateTime DateSouscriptionDebut
        {
            get { return dateSouscriptionDebut; }
            set { dateSouscriptionDebut = value; }
        }        

        public DateTime DateSouscriptionFin
        {
            get { return dateSouscriptionFin; }
            set { dateSouscriptionFin = value; }
        }        

        public string Intitule
        {
            get { return intitule; }
            set { intitule = value; }
        }        

        public long IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }       

        public long IdProduit
        {
            get { return idProduit; }
            set { idProduit = value; }
        }        

        public long IdCompte
        {
            get { return idCompte; }
            set { idCompte = value; }
        }
    }
}
