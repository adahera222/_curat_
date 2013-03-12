#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

#endregion

namespace BoglarChamp.Rapoarte
{
    public partial class ReportForm : Form
    {
        public ReportForm(string caleRaport, string titlu)
        {
            InitializeComponent();
            //this.Text = titlu;
            aspPageBox1.Path = caleRaport;
            aspPageBox1.Update();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}