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

namespace BoglarChamp.Rapoarte
{
    public partial class CentralizatorMuncitori : UserControl
    {
        IList<ScanareIMO> scanari=null;
        ScanareIMO scanareCurenta = new ScanareIMO();
        IList<ScanareDetaliiIMO> detalii = null;
        IList<RaportMuncitorIMO> raportMuncitori = null;
        IList<Firma> firme = null;
        IList<PersoanaIMO> sefi = null;

        //IList<RaportDetaliiMuncitorIMO> detaliiRaport = null;

        public CentralizatorMuncitori()
        {
            InitializeComponent();
        }

        internal void Init()
        {
            SetFirme();
            SetSefiEchipe();
            txtDataStart.Value = DateTime.Now.Date;
            txtDataEnd.Value = DateTime.Now.Date;
        }

        private void SetSefiEchipe()
        {
            ManagerPersoana m = null;
            try
            {
                m = new ManagerPersoana();

                sefi = m.GetPersoaneIMO("", "", "sefechipa", cmbFirme.Text == "Toate firmele" ? "ALL" : cmbFirme.Text, false, true);
                sefi.Add(new PersoanaIMO("Toti sefi echipa"));
                cmbSefiEchipa.DataSource = sefi;
                cmbSefiEchipa.DisplayMember = "NumeComplet";
                cmbSefiEchipa.Text = "Toti sefi echipa";
            }
            finally
            {
                m = null;
            }
        }

        private void SetFirme()
        {
            ManagerFirma m = null;
            try
            {
                m = new ManagerFirma();

                firme = m.GetFirme(false);
                //firme.Add(new Firma("Toate firmele"));
                cmbFirme.DataSource = firme;
                cmbFirme.DisplayMember = "Denumire";
                //cmbFirme.Text = "Toate firmele";
            }
            finally
            {
                m = null;
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            ManagerRaport m = null;

            try
            {
                m = new ManagerRaport();
                scanari = m.GetScanari(stxtNume.Text, stxtPrenume.Text,cmbFirme.Text == "Toate firmele" ? "ALL" : cmbFirme.Text,
                   cmbSefiEchipa.Text == "Toti sefi echipa" ? 0 : (cmbSefiEchipa.SelectedItem as PersoanaIMO).Id, txtDataStart.Value, txtDataEnd.Value);
                bindingSource1.DataSource = scanari;
                bindingSource3.DataSource = null;
                grdScanari_SelectionChanged(sender, e);
                PopulateScanari();
                grdScanari.Update(true);
                grdDetalii.Update(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private void PopulateScanari()
        {
            if (scanari == null || scanari.Count == 0)
            {
                lbNrMuncitori.Text = "0 muncitori filtrati";
                lbAmbalaj1.Text="";
                lbAmbalaj2.Text="";
                lbAmbalaj3.Text="";
                lbAmbalaj4.Text="";
                lbAmbalaj5.Text="";
            }
            else
            {
            }
        }

        private void grdScanari_SelectionChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current != null)
            {
                scanareCurenta = bindingSource1.Current as ScanareIMO;
            }
            else
            {
                //scanareCurenta = new ScanareIMO();
                MessageBox.Show("Criteriile specificate nu au returnat vreun rezultat");
                return;
            }
            detalii = scanareCurenta.Detalii;
            bindingSource3.DataSource = detalii;
            grdDetalii.Update(true);
            PopulateScanariDetalii();
        }

        private void PopulateScanariDetalii()
        {
            string ambalaj1 = "";
            string ambalaj2 = "";
            string ambalaj3 = "";
            string ambalaj4 = "";
            string ambalaj5 = "";
            int nrAmbalaj1=0;
            int nrAmbalaj2=0;
            int nrAmbalaj3=0;
            int nrAmbalaj4=0;
            int nrAmbalaj5=0;
            decimal greutateAmbalaj1=0;
            decimal greutateAmbalaj2=0;
            decimal greutateAmbalaj3=0;
            decimal greutateAmbalaj4=0;
            decimal greutateAmbalaj5=0;
            //if (scanareCurenta == null)
            //{
                lbAmbalaj1.Text = "";
                lbAmbalaj2.Text = "";
                lbAmbalaj3.Text="";
                lbAmbalaj4.Text = "";
                lbAmbalaj5.Text = "";
            //}
            //else
            //{
                lbNrMuncitori.Text = scanareCurenta.Nume + " " + scanareCurenta.Prenume;
                foreach (ScanareDetaliiIMO det in scanareCurenta.Detalii)
                {
                    switch ((det.AmbalajId))
                    {
                        case 1:
                            nrAmbalaj1++;
                            greutateAmbalaj1 += det.Greutate;
                            ambalaj1 = det.Ambalaj;
                            break;
                        case 2:
                            nrAmbalaj2++;
                            greutateAmbalaj2 += det.Greutate;
                            ambalaj2 = det.Ambalaj;

                            break;
                        case 3:
                            nrAmbalaj3++;
                            greutateAmbalaj3 += det.Greutate;
                            ambalaj3 = det.Ambalaj;

                            break;
                        case 4:
                            nrAmbalaj4++;
                            greutateAmbalaj4 += det.Greutate;
                            ambalaj4 = det.Ambalaj;

                            break;
                        case 5:
                            nrAmbalaj5++;
                            greutateAmbalaj5 += det.Greutate;
                            ambalaj5 = det.Ambalaj;

                            break;
                    }
                //}
                if (nrAmbalaj1!=0) lbAmbalaj1.Text = nrAmbalaj1 +" "+ ambalaj1+" , Greutate: " + greutateAmbalaj1;
                if (nrAmbalaj2 != 0) lbAmbalaj2.Text = nrAmbalaj2 +" "+ ambalaj2+", Greutate: " + greutateAmbalaj2;
                if (nrAmbalaj3 != 0) lbAmbalaj3.Text = nrAmbalaj3 +" "+ ambalaj3+", Greutate: " + greutateAmbalaj3;
                if (nrAmbalaj4 != 0) lbAmbalaj4.Text = nrAmbalaj4 +" "+ ambalaj4+", Greutate: " + greutateAmbalaj4;
                if (nrAmbalaj5 != 0) lbAmbalaj5.Text = nrAmbalaj5 +" "+ ambalaj5+", Greutate: " + greutateAmbalaj5;

            }
        }

        private void grdScanari_Click(object sender, EventArgs e)
        {

        }

        private void lbAmbalaj1_Click(object sender, EventArgs e)
        {

        }

        private void btnRaportMuncitor_Click(object sender, EventArgs e)
        {
            ManagerRaport m = null;

            try
            {
                m = new ManagerRaport();
                if (scanareCurenta == null)
                {
                    return;
                }
                else
                {
                    raportMuncitori = m.RaportMuncitori(scanareCurenta.Nume, scanareCurenta.Prenume, txtDataStart.Value, txtDataEnd.Value);
                }
                RaportMuncitor.Muncitor = raportMuncitori;
                //IList<RaportCumulatMuncitorIMO> list = new List<RaportCumulatMuncitorIMO>();

                //foreach (RaportMuncitorIMO i in raportMuncitori)
                //{
                //    foreach (RaportDataIMO d in i.DataScanare)
                //    {
                //        foreach (RaportDetaliiMuncitorIMO det in d.Detalii)
                //        {
                //            list.Add(new RaportCumulatMuncitorIMO(i, d, det));
                //        }
                //    }

                //}
               

                ReportForm frm = new ReportForm("Rapoarte/RaportCules.aspx", this.Text);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            stxtNume.ResetText();
            //stxtZona.ResetText();
            stxtPrenume.ResetText();
            txtDataStart.ResetText();

            txtDataEnd.ResetText();
            

            Init();

            bindingSource1.DataSource = null;
            bindingSource3.DataSource = null;
            //PopuleazaTotal(clienti);

            grdScanari.Update();
            grdDetalii.Update();
            //bindingSource1_PositionChanged(this, null);
            lbNrMuncitori.Text = "";
        }

        private void btnRaportTotal_Click(object sender, EventArgs e)
        {
            ManagerRaport m = null;

            try
            {
                m = new ManagerRaport();
                if (scanareCurenta == null)
                {
                    return;
                }
                else
                {
                    raportMuncitori = m.RaportTotalMuncitori(txtDataStart.Value, txtDataEnd.Value);
                }
                RaportTotalMuncitori.Muncitor = raportMuncitori;

                IList<RaportCumulatMuncitorIMO> list = new List<RaportCumulatMuncitorIMO>();

                //foreach (RaportMuncitorIMO i in raportMuncitori)
                //{
                //    foreach (RaportDataIMO d in i.DataScanare)
                //    {
                //        foreach (RaportDetaliiMuncitorIMO det in d.Detalii)
                //        {
                //            list.Add(new RaportCumulatMuncitorIMO(i, d, det));
                //        }
                //    }

                //}

                ReportForm frm = new ReportForm("Rapoarte/RaportTotalCules.aspx", this.Text);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnRaportSefEchipa_Click(object sender, EventArgs e)
        {
            ManagerRaport m = null;
            IList<RaportCumulatMuncitorIMO> list = null;

            try
            {
                m = new ManagerRaport();
                if (scanareCurenta == null)
                {
                    return;
                }
                if ((cmbSefiEchipa.SelectedItem as PersoanaIMO).Id == 0)
                {
                    MessageBox.Show("Selectati seful de echipa pe care doriti raportul!");
                    return;
                }
                else
                {
                    list = m.RaportSefEchipa((cmbFirme.SelectedItem as Firma).Id, cmbSefiEchipa.Text == "Toti sefi echipa" ? 0 : (cmbSefiEchipa.SelectedItem as PersoanaIMO).Id, txtDataStart.Value, txtDataEnd.Value);
                    //raportMuncitori = m.RaportTotalMuncitori(txtDataStart.Value, txtDataEnd.Value);
                }
                RaportSefEchipaR.SefEchipa = list;


                //foreach (ScanareIMO i in scanari)
                //{
                //    foreach (ScanareDetaliiIMO d in i.Detalii)
                //    {
                //        //foreach (RaportDetaliiMuncitorIMO det in d.Detalii)
                //        //{
                //        list.Add(new RaportCumulatMuncitorIMO(i, d));
                //        //}
                //    }

                //}

                ReportForm frm = new ReportForm("Rapoarte/RaportSefiEchipa.aspx", this.Text);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnRaportSefiEchipa_Click(object sender, EventArgs e)
        {
            ManagerRaport m = null;
            IList<RaportCumulatMuncitorIMO> list = null;

            try
            {
                m = new ManagerRaport();
                if (scanareCurenta == null)
                {
                    return;
                }
                
                else
                {
                    list = m.RaportSefiEchipa((cmbFirme.SelectedItem as Firma).Id, cmbSefiEchipa.Text == "Toti sefi echipa" ? 0 : (cmbSefiEchipa.SelectedItem as PersoanaIMO).Id, txtDataStart.Value, txtDataEnd.Value);
                    //raportMuncitori = m.RaportTotalMuncitori(txtDataStart.Value, txtDataEnd.Value);
                }
                RaportSefiEchipaR.SefiEchipa = list;


                //foreach (ScanareIMO i in scanari)
                //{
                //    foreach (ScanareDetaliiIMO d in i.Detalii)
                //    {
                //        //foreach (RaportDetaliiMuncitorIMO det in d.Detalii)
                //        //{
                //        list.Add(new RaportCumulatMuncitorIMO(i, d));
                //        //}
                //    }

                //}

                ReportForm frm = new ReportForm("Rapoarte/RaportSefiEchipa.aspx", this.Text);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
