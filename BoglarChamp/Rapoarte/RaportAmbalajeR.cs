using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BoglarChamp.NHibernate.Core;
using System.Collections.Generic;

namespace BoglarChamp.Rapoarte
{
    public partial class RaportAmbalajeR : DevExpress.XtraReports.UI.XtraReport
    {
        public static IList<ScanareIMO> Scanari { get; set; }

        public RaportAmbalajeR()
        {
            InitializeComponent();
            this.bindingSource1.DataSource = CreateDataSource();

        }

        private IList<RaportCumulatMuncitorIMO> CreateDataSource()
        {
            IList<RaportCumulatMuncitorIMO> list = new List<RaportCumulatMuncitorIMO>();
            decimal totalGreutatePerioada = 0;

            foreach (ScanareIMO i in Scanari)
            {
                totalGreutatePerioada += i.TotalGreutateZi;

                foreach (ScanareDetaliiIMO d in i.Detalii)
                {
                    list.Add(new RaportCumulatMuncitorIMO(i, d));
                    //totalGreutateZi += d.Greutate;
                }

            }
            this.lbFirma.Text = list[0].Firma;
         
            this.lbTotalGreutatePerioada.Text = totalGreutatePerioada.ToString();
            return list;
        }

    }
}
