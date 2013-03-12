using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BoglarChamp.NHibernate.Core;
using System.Collections.Generic;

namespace BoglarChamp.Rapoarte
{
    public partial class RaportSefiEchipaR : DevExpress.XtraReports.UI.XtraReport
    {
        public static IList<RaportCumulatMuncitorIMO> SefiEchipa { get; set; }

        public RaportSefiEchipaR()
        {
            InitializeComponent();
            this.bindingSource1.DataSource = SefiEchipa;

        }

    }
}
