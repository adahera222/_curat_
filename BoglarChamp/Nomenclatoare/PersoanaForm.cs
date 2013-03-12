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
    public partial class PersoanaForm : Form
    {
        IList<Functie> functii = null;
        IList<Firma> firme = null;

        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Cod { get; set; }
        public bool Anulat { get; set; }
        public bool IsOk { get; set; }
        public Functie Functie { get; set; }
        public Firma Firma { get; set; }
        public int Numar { get; set; }
        //public string Firma { get; set; }

        public PersoanaForm()
        {
            InitializeComponent();
        }

        public PersoanaForm(string titlu, int id, string nume,string prenume, bool anulat, string functie,string cod, int numar,string firma)
        {
            ManagerFunctie m = new ManagerFunctie();
            ManagerFirma m1 = new ManagerFirma();
            Functie f = null;
            Firma f1 = null;
            InitializeComponent();

            this.Id = id;
            this.Nume = nume;
            this.Prenume = prenume;
            this.Anulat = anulat;
            this.Cod = cod;
            this.Numar = numar;
            //this.Firma = firma;

            this.Text = titlu;
            txtNume.Text = nume;
            txtPrenume.Text = prenume;
            lbCod.Text = cod;
            ckAnulat.Checked = anulat;
            txtNumar.Value = numar;
            functii = m.GetFunctii(false);
            firme = m1.GetFirme(false);

                if (id == 0)
                {
                    BindCombo();

                }
                else
                {
                    f = m.GetFunctieByDenumire(functie);
                    f1 = m1.GetFirmaByDenumire(firma);
                    BindCombo1(f,f1);
                }
            
        }

        private void BindCombo1(Functie f,Firma f1)
        {
            cmbFunctii.DataSource = functii;
            cmbFunctii.DisplayMember = "Denumire";
            cmbFunctii.Text = f.Denumire;
            cmbFirme.DataSource = firme;
            cmbFirme.DisplayMember = "Denumire";
            cmbFirme.Text = f1.Denumire;

        }

        private void BindCombo()
        {
            cmbFunctii.DataSource = functii;
            cmbFunctii.DisplayMember = "Denumire";
            cmbFirme.DataSource = firme;
            cmbFirme.DisplayMember = "Denumire";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ManagerPersoana m = null;

            try
            {
                m = new ManagerPersoana();

                Nume = txtNume.Text;
                Prenume = txtPrenume.Text;
                Functie=cmbFunctii.SelectedItem as Functie;
                Firma = cmbFirme.SelectedItem as Firma;
                Anulat = ckAnulat.Checked;
                Numar = Convert.ToInt32(txtNumar.Value);
                if (Cod == "")
                {
                    do
                    {
                        Cod = GetRandomCode();
                        if (m.VerificaUnicitateCod(Cod, this.Id))
                        {
                            break;
                        }
                    } while (true);
                }
                lbCod.Text = Cod;
                if (!VerifyInfo()) { return; }
                SavePersoana(m);
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

        private void SavePersoana(ManagerPersoana m)
        {
            Persoana p = new Persoana();
            p.Id = Id;
            p.Nume = Nume;
            p.Prenume = Prenume;
            p.Anulat = Anulat;
            p.Functie = Functie;
            p.Cod = Cod;
            p.Numar=Numar;
            p.Firma = Firma;
            m.SavePersoana(p);
        }

        private bool VerifyInfo()
        {
            bool ret = true;
            if (Nume == "" )
            {
                errorProvider1.SetError(txtNume, "Numele nu poate fi gol!");
            }
            else if (Prenume == "")
            {
                errorProvider1.SetError(txtPrenume, "Prenumele nu poate fi gol!");

            }
            else if (Numar == 0)
            {
                errorProvider1.SetError(txtNumar, "Numarul nu poate fi 0!");
            }
            else
            {
                errorProvider1.SetError(txtNume, "");
            }
            return ret;
        }

        public string GetRandomCode()
        {
            string ret = "";
            Random random = new Random();
            ret = random.Next(10000000, 99999999).ToString();

            return ret;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsOk = false;
            this.Close();
        } 
    }
}