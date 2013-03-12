using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using BoglarChamp.Nomenclatoare;
using BoglarChamp.Rapoarte;

namespace BoglarChamp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnHale_Click(object sender, EventArgs e)
        {
            try
            {
                HaleUC uc = new HaleUC();
                uc.Dock = DockStyle.Fill;
                //pnlCentral.Text = btnHale.Text + " - " + utilizator.Firma;
                pnlCentral.Text = btnHale.Text + " - BOGLAR CHAMP";
                pnlCentral.Controls.Clear();
                pnlCentral.Controls.Add(uc);
                uc.Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCelule_Click(object sender, EventArgs e)
        {
            try
            {
                CeluleUC uc = new CeluleUC();
                uc.Dock = DockStyle.Fill;
                //pnlCentral.Text = btnHale.Text + " - " + utilizator.Firma;
                pnlCentral.Text = btnCelule.Text + " - BOGLAR CHAMP";
                pnlCentral.Controls.Clear();
                pnlCentral.Controls.Add(uc);
                uc.Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAmbalaje_Click(object sender, EventArgs e)
        {
            try
            {
                AmbalajeUC uc = new AmbalajeUC();
                uc.Dock = DockStyle.Fill;
                //pnlCentral.Text = btnHale.Text + " - " + utilizator.Firma;
                pnlCentral.Text = btnAmbalaje.Text + " - BOGLAR CHAMP";
                pnlCentral.Controls.Clear();
                pnlCentral.Controls.Add(uc);
                uc.Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPersoane_Click(object sender, EventArgs e)
        {
            try
            {
                PersoaneUC uc = new PersoaneUC();
                uc.Dock = DockStyle.Fill;
                //pnlCentral.Text = btnHale.Text + " - " + utilizator.Firma;
                pnlCentral.Text = btnPersoane.Text + " - BOGLAR CHAMP";
                pnlCentral.Controls.Clear();
                pnlCentral.Controls.Add(uc);
                uc.Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlCentral_Click(object sender, EventArgs e)
        {

        }

        private void btnTotalCules_Click(object sender, EventArgs e)
        {
            try
            {
                CentralizatorMuncitori uc = new CentralizatorMuncitori();
                uc.Dock = DockStyle.Fill;
                pnlCentral.Text = btnCentralizatorMuncitori.Text + " - BOGLAR CHAMP";
                pnlCentral.Controls.Clear();
                pnlCentral.Controls.Add(uc);
                uc.Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCentralizatorAmbalaje_Click(object sender, EventArgs e)
        {
            try
            {
                CentralizatorAmbalaje uc = new CentralizatorAmbalaje();
                uc.Dock = DockStyle.Fill;
                pnlCentral.Text = btnCentralizatorAmbalaje.Text + " - BOGLAR CHAMP";
                pnlCentral.Controls.Clear();
                pnlCentral.Controls.Add(uc);
                uc.Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}