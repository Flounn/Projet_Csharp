using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.DAOService;

namespace DataService.BSDataObjects
{
    public class Chequier : MoyenPaiement
    {
        private int nombreCheque;
        private int numero1Cheque;
        private int dernierCheque;
        private static readonly object[] valuesNbCheques = new object[] { 20, 50, 100 };

        public static object[] ValuesNbCheques
        {
            get { return Chequier.valuesNbCheques; }
        }

        public Chequier() { }
        public Chequier(long idMoyenPaiement, int nombreCheque, int numero1Cheque, int dernierCheque)
        {
            this.IdMoyenPaiement = idMoyenPaiement;
            this.nombreCheque = nombreCheque;
            this.numero1Cheque = numero1Cheque;
            this.dernierCheque = dernierCheque;
        }

        public int NombreCheque
        {
            get { return nombreCheque; }
            set { nombreCheque = value; }
        }
        

        public int Numero1Cheque
        {
            get { return numero1Cheque; }
            set { numero1Cheque = value; }
        }
        

        public int DernierCheque
        {
            get { return dernierCheque; }
            set { dernierCheque = value; }
        }

        #region DAO Chequier

        private static DAOChequier dao = new DAOChequier();

        public bool persist()
        {
            return dao.insert(this);
        }
        public bool delete()
        {
            return dao.delete(this);
        }

        #endregion
    }
}