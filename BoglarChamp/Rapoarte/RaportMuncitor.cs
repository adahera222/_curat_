using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BoglarChamp.NHibernate.Core;
using System.Collections.Generic;

namespace BoglarChamp.Rapoarte
{
    public partial class RaportMuncitor : DevExpress.XtraReports.UI.XtraReport
    {
        public static IList<RaportMuncitorIMO> Muncitor { get; set; }

        public RaportMuncitor()
        {
            InitializeComponent();
            this.bindingSource1.DataSource = CreateDataSource();
            //this.bindingSource2.DataSource = ;

        }

        private IList<RaportCumulatMuncitorIMO> CreateDataSource()
        {
            IList<RaportCumulatMuncitorIMO> list = new List<RaportCumulatMuncitorIMO>();

            foreach (RaportMuncitorIMO i in Muncitor)
            {
                foreach (RaportDataIMO d in i.DataScanare)
                {
                    foreach (RaportDetaliiMuncitorIMO det in d.Detalii)
                    {
                        list.Add(new RaportCumulatMuncitorIMO(i, d, det));
                    }
                }
                
            }
            this.lbFirma.Text = list[0].Firma;
            return list;
        }

        

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
