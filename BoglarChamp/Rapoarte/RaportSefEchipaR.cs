using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BoglarChamp.NHibernate.Core;
using System.Collections.Generic;

namespace BoglarChamp.Rapoarte
{
    public partial class RaportSefEchipaR : DevExpress.XtraReports.UI.XtraReport
    {
        public static IList<RaportCumulatMuncitorIMO> SefEchipa { get; set; }

        public RaportSefEchipaR()
        {
            InitializeComponent();
            //this.bindingSource1.DataSource = CreateDataSource();
                this.bindingSource1.DataSource = SefEchipa;
            

        }

        
    }
}
