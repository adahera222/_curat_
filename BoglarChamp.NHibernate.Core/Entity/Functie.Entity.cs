using System;


namespace BoglarChamp.NHibernate.Core.Entity
{
    /// <summary>
    /// An object representation of the Functie table
    /// </summary>
    [Serializable]
    public partial class Functie:_ItemBase
    {
        private bool anulat;
        private string denumire;

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

        public Functie(string denumire)
        {
            this.denumire = denumire;
            this.Id = 0;
        }

        public Functie()
        {
        }
    }
}
