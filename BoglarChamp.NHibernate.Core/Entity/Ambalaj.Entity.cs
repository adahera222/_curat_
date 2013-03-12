using System;


namespace BoglarChamp.NHibernate.Core.Entity
{
    /// <summary>
    /// An object representation of the Ambalaj table
    /// </summary>
    [Serializable]
    public partial class Ambalaj:_ItemBase
    {
        private bool anulat;
        private string denumire;
        private decimal greutate;

        public virtual decimal Greutate
        {
            get { return greutate; }
            set { greutate = value; }
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

        public virtual string Denumire
        {
            get
            {
                return denumire;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Denumire must not be null.");
                }
                denumire = value;
            }
        }

        public Ambalaj()
        {
        }

        public Ambalaj(string denumire)
        {
            this.Denumire = denumire;
            this.Id = 0;
        }
    }
}
