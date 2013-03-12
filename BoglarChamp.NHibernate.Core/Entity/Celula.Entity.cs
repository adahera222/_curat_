using System;


namespace BoglarChamp.NHibernate.Core.Entity
{
    /// <summary>
    /// An object representation of the Celula table
    /// </summary>
    [Serializable]
    public partial class Celula:_ItemBase
    {
        private bool anulat;
        private string denumire;
        private Hala hala;

        public virtual Hala Hala
        {
            get { return hala; }
            set { hala = value; }
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
    }
}
