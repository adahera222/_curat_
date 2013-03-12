using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;

namespace BoglarChamp.NHibernate.Core
{
    [Serializable]
    public class RaportCumulatMuncitorIMO
    {
        public string Nume { get; set; }
        public DateTime DataScanare { get; set; }
        public string Ambalaj { get; set; }
        public int Buc { get; set; }
        public decimal Greutate { get; set; }
        public decimal TotalGreutateZi { get; set; }
        public decimal TotalGreutatePerioada { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataEnd { get; set; }
        public int Numar { get; set; }
        public string Firma { get; set; }
        public string SefEchipa { get; set; }

        public RaportCumulatMuncitorIMO(RaportMuncitorIMO r,RaportDataIMO d, RaportDetaliiMuncitorIMO det)
        {
            this.Nume = r.persoana.Nume + " " + r.persoana.Prenume;
            this.DataStart = r.DataStart;
            this.DataEnd = r.DataEnd;
            this.Numar = r.persoana.Numar;
            this.TotalGreutatePerioada = r.TotalGreutatePerioada;
            this.DataScanare = d.Data.Date;
            this.TotalGreutateZi = d.TotalGreutateZi;
            this.Ambalaj=det.Denumire;
            this.Buc=det.Buc;
            this.Greutate = det.Greutate;
            this.Firma = r.persoana.Firma.Denumire;
        }

        public RaportCumulatMuncitorIMO(ScanareIMO s, ScanareDetaliiIMO det)
        {
            this.Firma = s.Firma;
            this.DataScanare = s.DataScanare;
            this.Ambalaj = det.Ambalaj;
            this.Numar = Convert.ToInt32(det.Numar);
            this.Greutate = det.Greutate;
            this.TotalGreutateZi = s.TotalGreutateZi;
            this.TotalGreutatePerioada += s.TotalGreutateZi;
            this.DataStart = s.DataStart;
            this.DataEnd = s.DataEnd;
            this.SefEchipa = s.SefEchipa;
        }

        public RaportCumulatMuncitorIMO(Scanare s, Ambalaj a, long nr, decimal greutate)
        {
            this.SefEchipa = s.Sef.Nume + " " + s.Sef.Prenume;
            this.Ambalaj = a.Denumire;
            this.Buc = Convert.ToInt32(nr);
            this.Greutate = greutate;
            this.DataScanare = s.DataScanare.Date;
        }
    }


}
