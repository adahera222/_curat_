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
    public partial class CeluleUC : UserControl
    {
        CelulaIMO celulaCurenta = null;

        public CeluleUC()
        {
            InitializeComponent();
        }

        internal void Init()
        {
            ManagerCelula m = new ManagerCelula();
            IList<CelulaIMO> celule = null;

            //hale = m.GetHaleIMO(true);
            celule = m.GetCeluleIMO(rbToateCelulele.Checked);

            bindingSource1.DataSource = celule;
            //dgrHale.Update(true);
            //bindingSource2_PositionChanged(this, null);
            bindingSource1_PositionChanged(this, null);
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current != null)
            {
                celulaCurenta = bindingSource1.Current as CelulaIMO;
            }
            else
            {
                celulaCurenta = null;
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            CelulaForm frm = null;

            try
            {
                frm = new CelulaForm("Adauga celula", 0, "", false,"");
                frm.ShowDialog();
                frm.FormClosed += new Form.FormClosedEventHandler(CelulaForm_FormClosing);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void CelulaForm_FormClosing(object sender, FormClosedEventArgs e)
        {
            if ((sender as CelulaForm).IsOk)
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
            CelulaForm frm = null;
            try
            {
                if (celulaCurenta == null)
                {
                    btnAdauga_Click(sender, e);
                }
                else
                {
                    frm = new CelulaForm("Editeaza celula " + celulaCurenta.Denumire, celulaCurenta.Id, celulaCurenta.Denumire, celulaCurenta.Anulat,celulaCurenta.Hala);
                    frm.ShowDialog();
                    frm.FormClosed += new Form.FormClosedEventHandler(CelulaForm_FormClosing);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            if (celulaCurenta == null) { return; }
            MessageBox.Show("Doriti sa anulati celula " +
                celulaCurenta.Denumire, "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, new EventHandler(ConfirmareAnulareCelula));
        }

        private void ConfirmareAnulareCelula(object sender, EventArgs e)
        {
            ManagerCelula m = null;
            ManagerHala m1 = null;
            Celula c = null;

            try
            {
                if ((sender as Form).DialogResult != DialogResult.Yes)
                {
                    return;
                }
                m = new ManagerCelula();
                m1 = new ManagerHala();
                c = new Celula();
                celulaCurenta.Anulat = true;
                c.Id = celulaCurenta.Id;
                c.Denumire = celulaCurenta.Denumire;
                c.Anulat = celulaCurenta.Anulat;
                c.Hala = m1.GetHalaByDenumire(celulaCurenta.Hala);
                m.SaveCelula(c);
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

        private void rbToateCelulele_CheckedChanged(object sender, EventArgs e)
        {
            Init();
        }



    }
}
