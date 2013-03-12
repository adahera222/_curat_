using System;


namespace BoglarChamp.NHibernate.Core.Entity
{
    /// <summary>
    /// An object representation of the Hala table
    /// </summary>
    [Serializable]
    public partial class Hala:_ItemBase
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
    }
}
