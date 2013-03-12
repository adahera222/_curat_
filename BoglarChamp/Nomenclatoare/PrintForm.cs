using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using BoglarChamp.NHibernate.Core;
using BoglarChamp.NHibernate.Core.Entity;
using BoglarChamp.Rapoarte;
using DevExpress.XtraEditors;

namespace BoglarChamp.Nomenclatoare
{
    public partial class PrintForm : Form
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Cod { get; set; }
        public bool Anulat { get; set; }
        public bool IsOk { get; set; }
        public Functie Functie { get; set; }
        public PersoanaIMO muncitor { get; set; }

        public PrintForm()
        {
            InitializeComponent();
        }

        public PrintForm(string titlu, int id, string nume, string prenume, bool anulat, string functie, string cod, int numar, string firma)
        {
            InitializeComponent();
            muncitor = new PersoanaIMO();

            muncitor.Id = id;
            muncitor.Nume = nume;
            muncitor.Prenume = prenume;
            muncitor.Cod = cod;
            muncitor.Functie = functie;
            muncitor.Numar = numar;
            muncitor.Firma = firma;
            this.Id = id;
            this.Nume = nume;
            this.Prenume = prenume;
            this.Anulat = anulat;
            this.Cod = cod;

            this.Text = titlu;
            lbNume.Text = nume;
            lbPrenume.Text = prenume;
            lbCod.Text = cod;
            lbNumar.Text = numar.ToString();
           
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            long j = 0;
            long k = 0;
            IList<PersoanaIMO> muncitori = new List<PersoanaIMO>();
            try
            {
                if (txtMinInterval.Value>txtMaxInterval.Value)
                {
                    MessageBox.Show(" Valoare minima mai mare decat valoare maxima");
                    return;
                }

                for (decimal i = txtMinInterval.Value; i <= txtMaxInterval.Value; i=i+2)
                {
                    PersoanaIMO tmp = new PersoanaIMO();
                    
                    tmp.ExemplarImpar = Convert.ToInt32(i);
                    k = Convert.ToInt64(muncitor.Cod) * 1000;
                    j =  k+ tmp.ExemplarImpar;
                    tmp.CodImpar = j.ToString();

                        tmp.ExemplarPar = Convert.ToInt32(i + 1);

                        j = k + tmp.ExemplarPar;
                        tmp.CodPar = j.ToString();
                   
                    tmp.Nume = muncitor.Nume;
                    tmp.Prenume = muncitor.Prenume;
                    tmp.Numar = muncitor.Numar;
                    tmp.Firma = muncitor.Firma;
                    j++;
                    muncitori.Add(tmp);
                }
                BarCodeMuncitor.Muncitor = muncitori;
                

                ReportForm frm = new ReportForm("Rapoarte/GenerareBarCode.aspx", this.Text);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            IsOk = false;
            this.Close();
        }
    }
}