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

namespace BoglarChamp.Nomenclatoare
{
    public partial class CelulaForm : Form
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public bool Anulat { get; set; }
        public bool IsOk { get; set; }
        public Hala Hala { get; set; }
        IList<Hala> hale = null;


        public CelulaForm()
        {
            InitializeComponent();
        }

        public CelulaForm(string titlu, int id, string denumire, bool anulat, string hala)
        {
            ManagerHala m=new ManagerHala();
            Hala h = null;
            InitializeComponent();

            this.Id = id;
            this.Denumire = denumire;
            this.Anulat = anulat;

            this.Text = titlu;
            txtDenumire.Text = Denumire;
            ckAnulat.Checked = Anulat;
            hale = m.GetHale(false);

                if (id == 0)
                {
                    BindCombo();

                }
                else
                {
                    h = m.GetHalaByDenumire(hala);
                    BindCombo1(h);
                }
            
        }

        private void BindCombo1(Hala h)
        {
            cmbHale.DataSource = hale;

            cmbHale.DisplayMember = "Denumire";
            cmbHale.Text = h.Denumire;

        }

        private void BindCombo()
        {
            cmbHale.DataSource = hale;
            cmbHale.DisplayMember = "Denumire";
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ManagerCelula m = null;

            try
            {
                m = new ManagerCelula();

                Denumire = txtDenumire.Text;
                Anulat = ckAnulat.Checked;
                Hala = cmbHale.SelectedItem as Hala;

                if (!VerifyInfo()) { return; }
                SaveCelula(m);
                IsOk = true;
                this.Close();
            }
            catch (Exception ex)
            {
                IsOk = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                m = null;
            }
        }

        private void SaveCelula(ManagerCelula m)
        {
            Celula c = new Celula();
            c.Id = Id;
            c.Denumire = Denumire;
            c.Anulat = Anulat;
            c.Hala = Hala;
            m.SaveCelula(c);
        }

        private bool VerifyInfo()
        {
            bool ret = true;
            if (Denumire == "")
            {
                errorProvider1.SetError(txtDenumire, "Denumirea nu poate fi goala!");
            }
            else
            {
                errorProvider1.SetError(txtDenumire, "");
            }
            return ret;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsOk = false;
            this.Close();
        }
    }
}