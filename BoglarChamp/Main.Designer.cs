namespace BoglarChamp
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navigationTabs1 = new Gizmox.WebGUI.Forms.NavigationTabs();
            this.ntNomenclatoare = new Gizmox.WebGUI.Forms.NavigationTab();
            this.btnPersoane = new Gizmox.WebGUI.Forms.Button();
            this.btnHale = new Gizmox.WebGUI.Forms.Button();
            this.btnAmbalaje = new Gizmox.WebGUI.Forms.Button();
            this.btnCelule = new Gizmox.WebGUI.Forms.Button();
            this.ntRapoarte = new Gizmox.WebGUI.Forms.NavigationTab();
            this.btnCentralizatorAmbalaje = new Gizmox.WebGUI.Forms.Button();
            this.btnCentralizatorMuncitori = new Gizmox.WebGUI.Forms.Button();
            this.pnlCentral = new Gizmox.WebGUI.Forms.HeaderedPanel();
            this.navigationTabs1.SuspendLayout();
            this.ntNomenclatoare.SuspendLayout();
            this.ntRapoarte.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationTabs1
            // 
            this.navigationTabs1.Controls.Add(this.ntNomenclatoare);
            this.navigationTabs1.Controls.Add(this.ntRapoarte);
            this.navigationTabs1.CustomStyle = "Navigation";
            this.navigationTabs1.IsCollapsable = false;
            this.navigationTabs1.Location = new System.Drawing.Point(9, 9);
            this.navigationTabs1.Name = "navigationTabs1";
            this.navigationTabs1.SelectedIndex = 0;
            this.navigationTabs1.Size = new System.Drawing.Size(140, 500);
            this.navigationTabs1.TabIndex = 1;
            // 
            // ntNomenclatoare
            // 
            this.ntNomenclatoare.Controls.Add(this.btnPersoane);
            this.ntNomenclatoare.Controls.Add(this.btnHale);
            this.ntNomenclatoare.Controls.Add(this.btnAmbalaje);
            this.ntNomenclatoare.Controls.Add(this.btnCelule);
            this.ntNomenclatoare.CustomStyle = "Navigation";
            this.ntNomenclatoare.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.ntNomenclatoare.Extra = false;
            this.ntNomenclatoare.Label = "Nomenclatoare";
            this.ntNomenclatoare.Location = new System.Drawing.Point(0, 0);
            this.ntNomenclatoare.Name = "ntNomenclatoare";
            this.ntNomenclatoare.Size = new System.Drawing.Size(132, 471);
            this.ntNomenclatoare.TabIndex = 0;
            this.ntNomenclatoare.Text = "Nomenclatoare";
            // 
            // btnPersoane
            // 
            this.btnPersoane.CustomStyle = "F";
            this.btnPersoane.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnPersoane.Location = new System.Drawing.Point(0, 84);
            this.btnPersoane.Name = "btnPersoane";
            this.btnPersoane.Size = new System.Drawing.Size(132, 28);
            this.btnPersoane.TabIndex = 0;
            this.btnPersoane.Text = "Persoane";
            this.btnPersoane.Click += new System.EventHandler(this.btnPersoane_Click);
            // 
            // btnHale
            // 
            this.btnHale.CustomStyle = "F";
            this.btnHale.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnHale.Location = new System.Drawing.Point(0, 0);
            this.btnHale.Name = "btnHale";
            this.btnHale.Size = new System.Drawing.Size(132, 28);
            this.btnHale.TabIndex = 0;
            this.btnHale.Text = "Hale";
            this.btnHale.UseVisualStyleBackColor = true;
            this.btnHale.Click += new System.EventHandler(this.btnHale_Click);
            // 
            // btnAmbalaje
            // 
            this.btnAmbalaje.CustomStyle = "F";
            this.btnAmbalaje.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnAmbalaje.Location = new System.Drawing.Point(0, 56);
            this.btnAmbalaje.Name = "btnAmbalaje";
            this.btnAmbalaje.Size = new System.Drawing.Size(132, 28);
            this.btnAmbalaje.TabIndex = 0;
            this.btnAmbalaje.Text = "Ambalaje";
            this.btnAmbalaje.Click += new System.EventHandler(this.btnAmbalaje_Click);
            // 
            // btnCelule
            // 
            this.btnCelule.CustomStyle = "F";
            this.btnCelule.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCelule.Location = new System.Drawing.Point(0, 28);
            this.btnCelule.Name = "btnCelule";
            this.btnCelule.Size = new System.Drawing.Size(132, 28);
            this.btnCelule.TabIndex = 0;
            this.btnCelule.Text = "Celule";
            this.btnCelule.Click += new System.EventHandler(this.btnCelule_Click);
            // 
            // ntRapoarte
            // 
            this.ntRapoarte.Controls.Add(this.btnCentralizatorAmbalaje);
            this.ntRapoarte.Controls.Add(this.btnCentralizatorMuncitori);
            this.ntRapoarte.CustomStyle = "Navigation";
            this.ntRapoarte.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.ntRapoarte.Extra = false;
            this.ntRapoarte.Label = "Rapoarte";
            this.ntRapoarte.Location = new System.Drawing.Point(0, 0);
            this.ntRapoarte.Name = "ntRapoarte";
            this.ntRapoarte.Size = new System.Drawing.Size(132, 471);
            this.ntRapoarte.TabIndex = 1;
            this.ntRapoarte.Text = "Rapoarte";
            // 
            // btnCentralizatorAmbalaje
            // 
            this.btnCentralizatorAmbalaje.CustomStyle = "F";
            this.btnCentralizatorAmbalaje.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCentralizatorAmbalaje.Location = new System.Drawing.Point(0, 28);
            this.btnCentralizatorAmbalaje.Name = "btnCentralizatorAmbalaje";
            this.btnCentralizatorAmbalaje.Size = new System.Drawing.Size(132, 28);
            this.btnCentralizatorAmbalaje.TabIndex = 0;
            this.btnCentralizatorAmbalaje.Text = "Centralizator ambalaje";
            this.btnCentralizatorAmbalaje.Click += new System.EventHandler(this.btnCentralizatorAmbalaje_Click);
            // 
            // btnCentralizatorMuncitori
            // 
            this.btnCentralizatorMuncitori.CustomStyle = "F";
            this.btnCentralizatorMuncitori.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCentralizatorMuncitori.Location = new System.Drawing.Point(0, 0);
            this.btnCentralizatorMuncitori.Name = "btnCentralizatorMuncitori";
            this.btnCentralizatorMuncitori.Size = new System.Drawing.Size(132, 28);
            this.btnCentralizatorMuncitori.TabIndex = 0;
            this.btnCentralizatorMuncitori.Text = "Centralizator muncitori";
            this.btnCentralizatorMuncitori.UseVisualStyleBackColor = true;
            this.btnCentralizatorMuncitori.Click += new System.EventHandler(this.btnTotalCules_Click);
            // 
            // pnlCentral
            // 
            this.pnlCentral.CustomStyle = "HeaderedPanel";
            this.pnlCentral.Location = new System.Drawing.Point(149, 9);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(800, 500);
            this.pnlCentral.TabIndex = 2;
            this.pnlCentral.Click += new System.EventHandler(this.pnlCentral_Click);
            // 
            // Main
            // 
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.navigationTabs1);
            this.Size = new System.Drawing.Size(950, 505);
            this.Text = "Main";
            this.navigationTabs1.ResumeLayout(false);
            this.ntNomenclatoare.ResumeLayout(false);
            this.ntRapoarte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.NavigationTabs navigationTabs1;
        private Gizmox.WebGUI.Forms.NavigationTab ntNomenclatoare;
        private Gizmox.WebGUI.Forms.NavigationTab ntRapoarte;
        private Gizmox.WebGUI.Forms.Button btnPersoane;
        private Gizmox.WebGUI.Forms.Button btnAmbalaje;
        private Gizmox.WebGUI.Forms.Button btnCelule;
        private Gizmox.WebGUI.Forms.Button btnHale;
        private Gizmox.WebGUI.Forms.HeaderedPanel pnlCentral;
        private Gizmox.WebGUI.Forms.Button btnCentralizatorMuncitori;
        private Gizmox.WebGUI.Forms.Button btnCentralizatorAmbalaje;
    }
}