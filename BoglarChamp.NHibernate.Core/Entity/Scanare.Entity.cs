using System;


namespace BoglarChamp.NHibernate.Core.Entity
{
    /// <summary>
    /// An object representation of the Scanare table
    /// </summary>
    [Serializable]
    public partial class Scanare:_ItemBase
    {
        private DateTime dataScanare;
        private int cantitate;
        private decimal greutate;
        private Persoana sef;
        private Persoana muncitor;
        private Hala hala;
        private Celula celula;
        private Ambalaj ambalaj;

        public virtual decimal Greutate
        {
            get { return greutate; }
            set { greutate = value; }
        }

        public virtual DateTime DataScanare
        {
            get
            {
                return dataScanare;
            }
            set
            {
                dataScanare = value;
            }
        }

        public virtual int Cantitate
        {
            get
            {
                return cantitate;
            }
            set
            {
                cantitate = value;
            }
        }

        public virtual Persoana Sef
        {
            get { return sef; }
            set { sef = value; }
        }

        public virtual Persoana Muncitor
        {
            get { return muncitor; }
            set { muncitor = value; }
        }

        public virtual Hala Hala
        {
            get { return hala; }
            set { hala = value; }
        }

        public virtual Celula Celula
        {
            get { return celula; }
            set { celula = value; }
        }

        public virtual Ambalaj Ambalaj
        {
            get { return ambalaj; }
            set { ambalaj = value; }
        }

    }
}
