using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using BoglarChamp.NHibernate.Core;
using BoglarChamp.NHibernate.Core.Entity;
using log4net;
using System.Reflection;

namespace BoglarChamp.Nomenclatoare
{
    public partial class AmbalajeUC : UserControl
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        Ambalaj ambalajCurent = null;

        public AmbalajeUC()
        {
            InitializeComponent();
        }

        internal void Init()
        {
            ManagerAmbalaj m = new ManagerAmbalaj();
            IList<Ambalaj> ambalaje = null;
            
            ambalaje = m.GetAmbalaje(rbToateAmbalajele.Checked);
            //log.Error("Multe anbalaje: " + ambalaje.Count);
            bindingSource1.DataSource = ambalaje;
            //dgrHale.Update(true);
            //bindingSource2_PositionChanged(this, null);
            bindingSource1_PositionChanged(this, null);
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current != null)
            {
                ambalajCurent = bindingSource1.Current as Ambalaj;
            }
            else
            {
                ambalajCurent = null;
            }
        }

        private void rbToateAmbalajele_CheckedChanged(object sender, EventArgs e)
        {
            Init();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            AmbalajForm frm = null;

            try
            {
                frm = new AmbalajForm("Adauga ambalaj", 0, "", false, 0);
                frm.ShowDialog();
                frm.FormClosed += new Form.FormClosedEventHandler(AmbalajForm_FormClosing);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void AmbalajForm_FormClosing(object sender, FormClosedEventArgs e)
        {
            if ((sender as AmbalajForm).IsOk)
            {
                try
                {
                    Init();
                    //searchTextBox1_Search(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            AmbalajForm frm = null;
            try
            {
                if (ambalajCurent == null)
                {
                    btnAdauga_Click(sender, e);
                }
                else
                {
                    frm = new AmbalajForm("Editeaza ambalajul " + ambalajCurent.Denumire, ambalajCurent.Id,ambalajCurent.Denumire, ambalajCurent.Anulat, ambalajCurent.Greutate);
                    frm.ShowDialog();
                    frm.FormClosed += new Form.FormClosedEventHandler(AmbalajForm_FormClosing);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            if (ambalajCurent == null) { return; }
            MessageBox.Show("Doriti sa anulati ambalajul " +
                ambalajCurent.Denumire, "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, new EventHandler(ConfirmareAnulareAmbalaj));
        }

        private void ConfirmareAnulareAmbalaj(object sender, EventArgs e)
        {
            ManagerAmbalaj m = null;

            try
            {
                if ((sender as Form).DialogResult != DialogResult.Yes)
                {
                    return;
                }
                m = new ManagerAmbalaj();
                ambalajCurent.Anulat = true;
                m.SaveAmbalaj(ambalajCurent);
                Init();
                bindingSource1_PositionChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                m = null;
            }
        }
    }
}
