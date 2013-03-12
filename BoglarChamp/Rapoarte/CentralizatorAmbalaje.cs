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
    public partial class CentralizatorAmbalaje : UserControl
    {
        IList<Firma> firme = null;
        IList<Ambalaj> ambalaje = null;
        IList<ScanareIMO> scanari = null;
        ScanareIMO scanareCurenta = new ScanareIMO();
        IList<ScanareDetaliiIMO> detalii = null;

        public CentralizatorAmbalaje()
        {
            InitializeComponent();
        }

        internal void Init()
        {
            SetFirme();
            SetAmbalaje();
            txtDataStart.Value = DateTime.Now.Date;
            txtDataEnd.Value = DateTime.Now.Date;
        }

        private void SetAmbalaje()
        {
            ManagerAmbalaj m = null;
            try
            {
                m = new ManagerAmbalaj();

                ambalaje = m.GetAmbalaje(false);
                ambalaje.Add(new Ambalaj("Toate ambalajele"));
                cmbAmbalaje.DataSource = ambalaje;
                cmbAmbalaje.DisplayMember = "Denumire";
                cmbAmbalaje.Text = "Toate ambalajele";
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
                scanari = m.GetScanariAmbalaje(cmbFirme.Text == "Toate firmele" ? "ALL" : cmbFirme.Text,
                    cmbAmbalaje.Text == "Toate ambalajele" ? "ALL" : cmbAmbalaje.Text,
                    txtDataStart.Value, txtDataEnd.Value);
                bindingSource1.DataSource = scanari;
                bindingSource2.DataSource = null;

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
                return;
            }
            else
            {
                lbNrScanari.Text = scanari.Count + " scanari filtrate";
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
            bindingSource2.DataSource = detalii;
            grdDetalii.Update(true);
            PopulateScanariDetalii();
        }

        private void PopulateScanariDetalii()
        {
            decimal totalGreutate=0;
            if (detalii == null || detalii.Count == 0)
            {
                return;
            }
            else
            {
                foreach (ScanareDetaliiIMO det in detalii)
                {
                    totalGreutate += det.Greutate;
                }
                lbTotalGreutate.Text = "Total greutate: "+totalGreutate.ToString();
            }
            
        }

        private void btnRaportAmbalaje_Click(object sender, EventArgs e)
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
                    //raportAmbalaje = scanari;
                }
                RaportAmbalajeR.Scanari = scanari;
                IList<RaportCumulatMuncitorIMO> list = new List<RaportCumulatMuncitorIMO>();

                foreach (ScanareIMO i in scanari)
                {
                    foreach (ScanareDetaliiIMO d in i.Detalii)
                    {
                        //foreach (RaportDetaliiMuncitorIMO det in d.Detalii)
                        //{
                            list.Add(new RaportCumulatMuncitorIMO(i, d));
                        //}
                    }

                }


                ReportForm frm = new ReportForm("Rapoarte/RaportAmbalaje.aspx", this.Text);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
