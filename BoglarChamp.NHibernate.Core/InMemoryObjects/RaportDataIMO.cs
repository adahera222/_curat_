using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoglarChamp.NHibernate.Core
{
    [Serializable]
    public class RaportDataIMO
    {
        public IList<RaportDetaliiMuncitorIMO> Detalii { get; set; }
        public DateTime Data {get;set;}
        public decimal TotalGreutateZi { get; set; }

        public RaportDataIMO()
        {
            Detalii = new List<RaportDetaliiMuncitorIMO>();
        }

        public RaportDataIMO(DateTime data)
        {
            this.Data = data;
            Detalii = new List<RaportDetaliiMuncitorIMO>();
        }

    }
}
