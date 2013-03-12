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

namespace BoglarChamp.Nomenclatoare
{
    public partial class HaleUC : UserControl
    {
        Hala halaCurenta = null;

        public HaleUC()
        {
            InitializeComponent();
        }

        internal void Init()
        {
            ManagerHala m = new ManagerHala();
            IList<Hala> hale = null;

            //hale = m.GetHaleIMO(true);
            hale = m.GetHale(rbToateHalele.Checked);

            bindingSource1.DataSource = hale;
            //dgrHale.Update(true);
            //bindingSource2_PositionChanged(this, null);
            bindingSource1_PositionChanged(this, null);

        }

        private void bindingSource2_PositionChanged(object sender, EventArgs e)
        {
            //if (bindingSource2.Current != null)
            //{
            //    halaCurenta = bindingSource2.Current as Hala;
            //}
            //else
            //{
            //    halaCurenta = null;
            //}
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current != null)
            {
                halaCurenta = bindingSource1.Current as Hala;
            }
            else
            {
                halaCurenta = null;
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            HalaForm frm = null;

            try
            {
                frm = new HalaForm("Adauga hala", 0, "", false);
                frm.ShowDialog();
                frm.FormClosed += new Form.FormClosedEventHandler(HalaForm_FormClosing);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void HalaForm_FormClosing(object sender, FormClosedEventArgs e)
        {
            if ((sender as HalaForm).IsOk)
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
            HalaForm frm = null;
            try
            {
                if (halaCurenta == null)
                {
                    btnAdauga_Click(sender, e);
                }
                else
                {
                    frm = new HalaForm("Editeaza hala " + halaCurenta.Denumire, halaCurenta.Id, halaCurenta.Denumire, halaCurenta.Anulat);
                    frm.ShowDialog();
                    frm.FormClosed += new Form.FormClosedEventHandler(HalaForm_FormClosing);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            if (halaCurenta == null) { return; }
            MessageBox.Show("Doriti sa anulati hala "+
                halaCurenta.Denumire, "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, new EventHandler(ConfirmareAnulareHala));
        }

        private void ConfirmareAnulareHala(object sender, EventArgs e)
        {
            ManagerHala m = null;

            try
            {
                if ((sender as Form).DialogResult != DialogResult.Yes)
                {
                    return;
                }
                m = new ManagerHala();
                halaCurenta.Anulat = true;
                m.SaveHala(halaCurenta);
                Init();
                bindingSource2_PositionChanged(sender, e);
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

        private void dgrHale_Click(object sender, EventArgs e)
        {

        }

        private void rbHaleActive_CheckedChanged(object sender, EventArgs e)
        {
            Init();
        }
    }
}
