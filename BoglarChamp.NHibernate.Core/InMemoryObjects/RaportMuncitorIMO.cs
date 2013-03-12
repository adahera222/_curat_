using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;

namespace BoglarChamp.NHibernate.Core
{
    [Serializable]
    public class RaportMuncitorIMO
    {
        public int Numar { get; set; }
        public decimal Greutate { get; set; }
        public string Denumire { get; set; }
        public IList<RaportDetaliiMuncitorIMO> Detalii { get; set; }
        public IList<RaportDataIMO> DataScanare { get; set; }
        public Persoana persoana { get; set;}
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public decimal TotalGreutatePerioada { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataEnd { get; set; }

        public RaportMuncitorIMO()
        {
            DataScanare = new List<RaportDataIMO>();
        }

        public RaportMuncitorIMO(Persoana p, DateTime dataScanare, long numar, decimal greutate, string denumire)
        {
            this.Nume = p.Nume+" "+p.Prenume;
            this.Numar = Convert.ToInt32(numar);
            this.Greutate = greutate;
            this.Denumire = denumire;

        }

        public RaportMuncitorIMO( DateTime dataScanare, long numar, decimal greutate, string denumire)
        {
            this.Numar = Convert.ToInt32(numar);
            this.Greutate = greutate;
            this.Denumire = denumire;

        }
    }
}
