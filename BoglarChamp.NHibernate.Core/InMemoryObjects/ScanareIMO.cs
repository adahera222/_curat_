using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;


namespace BoglarChamp.NHibernate.Core
{
    [Serializable]
    public class ScanareIMO
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime DataScanare { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataEnd { get; set; }
        string Ambalaj { get; set; }
        string Celula { get; set; }
        string Hala { get; set; }
        public string Firma { get; set; }
        public IList<ScanareDetaliiIMO> Detalii { get; set; }
        public string SefEchipa { get; set; }
        public decimal TotalGreutateZi { get; set; }

        public ScanareIMO()
        {
            Detalii = new List<ScanareDetaliiIMO>();
        }

        public ScanareIMO(Persoana p, Scanare s)
        {
            this.Nume = p.Nume;
            this.Prenume = p.Prenume;
            this.DataScanare = s.DataScanare;
            this.Ambalaj = s.Ambalaj.Denumire;
            this.Celula = s.Celula.Denumire;
            this.Firma = p.Firma.Denumire;
            this.Hala = s.Hala.Denumire;
            this.SefEchipa = s.Sef.Nume + " " + s.Sef.Prenume;
        }
    }
}
