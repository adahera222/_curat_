using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;

namespace BoglarChamp.NHibernate.Core
{
    [Serializable]
    public class HalaIMO
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public bool Anulat { get; set; }

        public HalaIMO()
        {
        }

        public HalaIMO(Hala h)
        {
            this.Denumire = h.Denumire;
            this.Anulat = h.Anulat;
        }
    }
}
