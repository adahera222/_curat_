using System;


namespace BoglarChamp.NHibernate.Core.Entity
{
    /// <summary>
    /// An object representation of the Persoana table
    /// </summary>
    [Serializable]
    public partial class Persoana:_ItemBase
    {
        private bool anulat;
        private string nume;
        private string prenume;
        private string cod;
        private Functie functie;
        private Firma firma;
        private int numar;

        public virtual Firma Firma
        {
            get { return firma; }
            set { firma = value; }
        }

        public virtual int Numar
        {
            get { return numar; }
            set { numar = value; }
        }

        

        public virtual Functie Functie
        {
            get { return functie; }
            set { functie = value; }
        }

        public virtual bool Anulat
        {
            get
            {
                return anulat;
            }
            set
            {
                anulat = value;
            }
        }

        public virtual string Nume
        {
            get
            {
                return nume;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Nume must not be null.");
                }
                nume = value;
            }
        }

        public virtual string Prenume
        {
            get
            {
                return prenume;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Prenume must not be null.");
                }
                prenume = value;
            }
        }

        public virtual string Cod
        {
            get
            {
                return cod;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Cod must not be null.");
                }
                cod = value;
            }
        }
    }
}
