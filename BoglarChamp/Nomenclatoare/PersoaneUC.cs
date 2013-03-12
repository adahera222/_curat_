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
    public partial class PersoaneUC : UserControl
    {
        IList<Functie> functii = null;
        IList<Firma> firme = null;
        PersoanaIMO persoanaCurenta = null;

        public PersoaneUC()
        {
            InitializeComponent();
        }

        internal void Init()
        {
            SetFirme();
            SetFunctii();
            SetFilterColor();
            rbOrdoneazaNume.Checked = true;
            searchTextBox1_Search(this, null);
        }

        private void SetFirme()
        {
            ManagerFirma m = null;
            try
            {
                m = new ManagerFirma();

                firme = m.GetFirme(false);
                firme.Add(new Firma("Toate firmele"));
                cmbFirme.DataSource = firme;
                cmbFirme.DisplayMember = "Denumire";
                cmbFirme.Text = "Toate firmele";
            }
            finally
            {
                m = null;
            }
        }

        private void searchTextBox1_Search(object sender, EventArgs e)
        {
            ManagerPersoana m = new ManagerPersoana();
            IList<PersoanaIMO> persoane = null;

            try
            {
                SetFilterColor();

                persoane = m.GetPersoaneIMO(stxtNume.Text,stxtPrenume.Text,
                    cmbFunctii.Text == "Toate functiile" ? "ALL" : cmbFunctii.Text,
                    cmbFirme.Text == "Toate firmele" ? "ALL" : cmbFirme.Text,
                    ckAnulate.Checked,rbOrdoneazaNume.Checked);

                bindingSource1.DataSource = persoane;
                PopuleazaTotal(persoane);

                grdPersoane.Update();
                
                bindingSource1_PositionChanged(this, null);

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

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current != null)
            {
                persoanaCurenta = bindingSource1.Current as PersoanaIMO;
            }
            else
            {
                persoanaCurenta = null;
            }
        }

        private void PopuleazaTotal(IList<PersoanaIMO> lista)
        {
            
            if (lista == null)
            {
                lbNumarClienti.Text = "";
            }
            else
            {
                lbNumarClienti.Text = lista.Count.ToString()+ " persoane filtrate";
            }
        }

        private void SetFilterColor()
        {
            System.Drawing.Color selected = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            stxtNume.BackColor = stxtNume.Text == "" ? Color.White : selected;
            stxtPrenume.BackColor = stxtPrenume.Text == "" ? Color.White : selected;
            
        }

        private void SetFunctii()
        {
            ManagerFunctie m = null;
            try
            {
                m = new ManagerFunctie();

                functii = m.GetFunctii(false);
                functii.Add(new Functie("Toate functiile"));
                cmbFunctii.DataSource = functii;
                cmbFunctii.DisplayMember = "Denumire";
                cmbFunctii.Text = "Toate functiile";
            }
            finally
            {
                m = null;
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            PersoanaForm frm = null;

            try
            {
                frm = new PersoanaForm("Adauga persoana", 0, "","", false, "","",0,"");
                frm.ShowDialog();
                frm.FormClosed += new Form.FormClosedEventHandler(PersoanaForm_FormClosing);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void PersoanaForm_FormClosing(object sender, FormClosedEventArgs e)
        {
            if ((sender as PersoanaForm).IsOk)
            {
                try
                {
                    Init();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            PersoanaForm frm = null;
            try
            {
                if (persoanaCurenta == null)
                {
                    btnAdauga_Click(sender, e);
                }
                else
                {
                    frm = new PersoanaForm("Editeaza persoana " + persoanaCurenta.Nume + " "+persoanaCurenta.Prenume,
                        persoanaCurenta.Id, persoanaCurenta.Nume, persoanaCurenta.Prenume, persoanaCurenta.Anulat,
                        persoanaCurenta.Functie,persoanaCurenta.Cod,persoanaCurenta.Numar,persoanaCurenta.Firma);
                    frm.ShowDialog();
                    frm.FormClosed += new Form.FormClosedEventHandler(PersoanaForm_FormClosing);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnanuleaza_Click(object sender, EventArgs e)
        {
            if (persoanaCurenta == null) { return; }
            MessageBox.Show("Doriti sa anulati persoana " +
                persoanaCurenta.Nume+" "+persoanaCurenta.Prenume, "?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, new EventHandler(ConfirmareAnularePeroana));
        }

        private void ConfirmareAnularePeroana(object sender, EventArgs e)
        {
            ManagerPersoana m = null;
            ManagerFunctie m1 = null;
            ManagerFirma m2 = null;
            Persoana p = null;

            try
            {
                if ((sender as Form).DialogResult != DialogResult.Yes)
                {
                    return;
                }
                m = new ManagerPersoana();
                m1 = new ManagerFunctie();

                p = new Persoana();
                persoanaCurenta.Anulat = true;
                p.Id = persoanaCurenta.Id;
                p.Nume = persoanaCurenta.Nume;
                p.Prenume = persoanaCurenta.Prenume;
                p.Cod = persoanaCurenta.Cod;
                p.Anulat = persoanaCurenta.Anulat;
                p.Numar = persoanaCurenta.Numar;
                p.Functie = m1.GetFunctieByDenumire(persoanaCurenta.Functie);
                p.Firma = m2.GetFirmaByDenumire(persoanaCurenta.Firma);
                m.SavePersoana(p);
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

        private void btnCauta_Click(object sender, EventArgs e)
        {
            searchTextBox1_Search(sender, e);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            stxtNume.ResetText();
            stxtPrenume.ResetText();

            Init();

           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintForm frm = null;
            try
            {
                if (persoanaCurenta == null)
                {
                    return ;
                }
                else
                {
                    frm = new PrintForm("Listeaza ecuson persoana " + persoanaCurenta.Nume + " " + persoanaCurenta.Prenume,
                        persoanaCurenta.Id, persoanaCurenta.Nume, persoanaCurenta.Prenume, persoanaCurenta.Anulat,
                        persoanaCurenta.Functie, persoanaCurenta.Cod,persoanaCurenta.Numar,persoanaCurenta.Firma);
                    frm.ShowDialog();
                    frm.FormClosed += new Form.FormClosedEventHandler(PrintForm_FormClosing);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void PrintForm_FormClosing(object sender, FormClosedEventArgs e)
        {
            if ((sender as PrintForm).IsOk)
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
    }
}
