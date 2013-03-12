using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;

namespace BoglarChamp.NHibernate.Core
{
    [Serializable]
    public class PersoanaIMO
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public bool Anulat { get; set; }
        public string Functie { get; set; }
        public string Cod { get; set; }
        public string CodPar { get; set; }
        public string CodImpar { get; set; }
        private int exemplarImpar;
        private int exemplarPar;
        public int Numar { get; set; }
        public string Firma { get; set; }
        public string NumeComplet { get; set; }

        public int ExemplarPar
        {
            get { return exemplarPar; }
            set { exemplarPar = value; }
        }

        public int ExemplarImpar
        {
            get { return exemplarImpar; }
            set { exemplarImpar = value; }
        }

        public PersoanaIMO()
        {
        }

        public PersoanaIMO(Persoana p)
        {
            this.Id = p.Id;
            this.Nume = p.Nume;
            this.Prenume = p.Prenume;
            this.Anulat = p.Anulat;
            this.Functie = p.Functie.Denumire;
            this.Cod = p.Cod;
            this.Numar = p.Numar;
            this.Firma = p.Firma.Denumire;
            this.NumeComplet = p.Nume + " " + p.Prenume;
        }

        public PersoanaIMO(string denumire)
        {
            this.Id = 0;
            this.NumeComplet = denumire;
        }
    }
}
