using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;

namespace BoglarChamp.NHibernate.Core
{
    [Serializable]
    public class CelulaIMO
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public bool Anulat { get; set; }
        public string Hala {get; set; }

        public CelulaIMO()
        {
        }

        public CelulaIMO(Celula c)
        {
            this.Id = c.Id;
            this.Denumire = c.Denumire;
            this.Anulat = c.Anulat;
            this.Hala = c.Hala.Denumire;
        }
    }
}
