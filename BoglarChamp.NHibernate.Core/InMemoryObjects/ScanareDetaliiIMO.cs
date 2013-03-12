using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;


namespace BoglarChamp.NHibernate.Core
{
    [Serializable]
    public class ScanareDetaliiIMO
    {
        string Nume { get; set; }
        string Prenume { get; set; }
        public DateTime DataScanare { get; set; }
        public string Ambalaj { get; set; }
        public int AmbalajId { get; set; }
        public string Celula { get; set; }
        public string Hala { get; set; }
        public decimal Greutate { get; set; }
        public string Sef { get; set; }
        public long Numar { get; set; }

        public ScanareDetaliiIMO()
        {
        }

        public ScanareDetaliiIMO(Persoana p, Scanare s)
        {
            this.Nume = p.Nume;
            this.Prenume = p.Prenume;
            this.DataScanare = s.DataScanare;
            this.Ambalaj = s.Ambalaj.Denumire;
            this.Celula = s.Celula.Denumire;
            this.Hala = s.Hala.Denumire;
            this.Greutate = s.Ambalaj.Greutate;
            this.AmbalajId = s.Ambalaj.Id;
            this.Sef = s.Sef.Nume + " " + s.Sef.Prenume;
        }

        public ScanareDetaliiIMO(Ambalaj a, long numar, decimal greutate)
        {
            this.Ambalaj = a.Denumire;
            this.Greutate = greutate;
            this.Numar = numar;
        }
    }
}
