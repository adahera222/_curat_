using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BoglarChamp.NHibernate.Core;
using System.Collections.Generic;


namespace BoglarChamp.Rapoarte
{
    public partial class BarCodeMuncitor : DevExpress.XtraReports.UI.XtraReport
    {
        public static IList<PersoanaIMO> Muncitor { get; set; }
        public static List<int> Exemplar { get; set; }

        public BarCodeMuncitor()
        {
            InitializeComponent();
            this.bindingSource1.DataSource = CreateDataSource();

            lbFirma.Text = Muncitor[0].Firma;

            lbMuncitor.Text = Muncitor[0].Nume + " " + Muncitor[0].Prenume;
            lb2Firma.Text = Muncitor[0].Firma;
            lb2Muncitor.Text = Muncitor[0].Nume + " " + Muncitor[0].Prenume;
        }

        private IList<PersoanaIMO> CreateDataSource()
        {
            IList<PersoanaIMO> list = new List<PersoanaIMO>();

            foreach (PersoanaIMO i in Muncitor)
            {
                    list.Add(i);
            }
            
            return list;
        }

        public BarCodeMuncitor(PersoanaIMO muncitor)
        {
            InitializeComponent();
            bindingSource1.DataSource = muncitor;
        }

    }
}
