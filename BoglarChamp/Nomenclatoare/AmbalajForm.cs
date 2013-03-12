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
    public partial class AmbalajForm : Form
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public bool Anulat { get; set; }
        public bool IsOk { get; set; }
        public decimal Greutate { get; set; }

        public AmbalajForm()
        {
            InitializeComponent();
        }

        public AmbalajForm(string titlu, int id, string denumire, bool anulat, decimal greutate)
        {
            InitializeComponent();

            this.Id = id;
            this.Denumire = denumire;
            this.Anulat = anulat;
            this.Greutate = greutate;

            this.Text = titlu;
            txtDenumire.Text = Denumire;
            ckAnulat.Checked = Anulat;
            txtGreutate.Value = greutate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ManagerAmbalaj m = null;

            try
            {
                m = new ManagerAmbalaj();

                Denumire = txtDenumire.Text;
                Anulat = ckAnulat.Checked;
                Greutate = txtGreutate.Value;
                if (!VerifyInfo()) { return; }
                SaveAmbalaj(m);
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

        private void SaveAmbalaj(ManagerAmbalaj m)
        {
            Ambalaj a = new Ambalaj();
            a.Id = Id;
            a.Denumire = Denumire;
            a.Anulat = Anulat;
            a.Greutate = Greutate;
            m.SaveAmbalaj(a);
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