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
    public partial class HalaForm : Form
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public bool Anulat { get; set; }
        public bool IsOk { get; set; }

        public HalaForm()
        {
            InitializeComponent();
        }

        public HalaForm(string titlu, int id, string denumire, bool anulat)
        {
            InitializeComponent();

            this.Id = id;
            this.Denumire = denumire;
            this.Anulat = anulat;

            this.Text = titlu;
            txtDenumire.Text = Denumire;
            ckAnulat.Checked = Anulat;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ManagerHala m = null;

            try
            {
                m = new ManagerHala();

                Denumire = txtDenumire.Text;
                Anulat = ckAnulat.Checked;
                if (!VerifyInfo()) { return; }
                SaveHala(m);
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

        private void SaveHala(ManagerHala m)
        {
            Hala h = new Hala();
            h.Id = Id;
            h.Denumire = Denumire;
            h.Anulat = Anulat;
            m.SaveHala(h);
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