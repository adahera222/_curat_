using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoglarChamp.NHibernate.Core
{
    [Serializable]
    public class AmbalajIMO
    {
        public string Denumire {get; set;}
        public int Numar { get; set; }
        public decimal Greutate { get; set; }
        public decimal GreutateTotala { get; set; }
    }
}
