using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;


namespace BoglarChamp.NHibernate.Core
{
    [Serializable]
    public class RaportDetaliiMuncitorIMO
    {
        public IList<AmbalajIMO> AmbalajIMO { get; set; }
        public Ambalaj Ambalaj { get; set; }
        public DateTime DataScanare { get; set; }
        public int Buc { get; set; }
        public decimal Greutate { get; set; }
        public string Denumire { get; set; }

        public RaportDetaliiMuncitorIMO()
        {
            AmbalajIMO = new List<AmbalajIMO>();
        }

        public RaportDetaliiMuncitorIMO(DateTime dataScanare, long buc, decimal greutate, string denumire)
        {
            this.DataScanare = dataScanare;
            this.Buc = Convert.ToInt32(buc);
            this.Greutate = greutate;
            this.Denumire = denumire;

        }
        public RaportDetaliiMuncitorIMO( long buc, decimal greutate, string denumire)
        {
            this.Buc = Convert.ToInt32(buc);
            this.Greutate = greutate;
            this.Denumire = denumire;

        }
        
    }
}
