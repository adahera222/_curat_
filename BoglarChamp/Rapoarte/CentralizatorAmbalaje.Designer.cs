namespace BoglarChamp.Rapoarte
{
    partial class CentralizatorAmbalaje
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Filtru = new Gizmox.WebGUI.Forms.GroupBox();
            this.btnCauta = new Gizmox.WebGUI.Forms.Button();
            this.btnClear = new Gizmox.WebGUI.Forms.Button();
            this.txtDataStart = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.txtDataEnd = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.cmbAmbalaje = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbFirme = new Gizmox.WebGUI.Forms.ComboBox();
            this.grdDetalii = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.bindingSource4 = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn15 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.grdScanari = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.bindingSource3 = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn29 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.btnRaportAmbalaje = new Gizmox.WebGUI.Forms.Button();
            this.lbNrScanari = new Gizmox.WebGUI.Forms.Label();
            this.lbTotalGreutate = new Gizmox.WebGUI.Forms.Label();
            this.Filtru.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdScanari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // Filtru
            // 
            this.Filtru.Controls.Add(this.btnCauta);
            this.Filtru.Controls.Add(this.btnClear);
            this.Filtru.Controls.Add(this.txtDataStart);
            this.Filtru.Controls.Add(this.label1);
            this.Filtru.Controls.Add(this.label2);
            this.Filtru.Controls.Add(this.txtDataEnd);
            this.Filtru.Controls.Add(this.cmbAmbalaje);
            this.Filtru.Controls.Add(this.cmbFirme);
            this.Filtru.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.Filtru.Location = new System.Drawing.Point(0, 0);
            this.Filtru.Name = "Filtru";
            this.Filtru.Size = new System.Drawing.Size(800, 106);
            this.Filtru.TabIndex = 0;
            this.Filtru.TabStop = false;
            this.Filtru.Text = "Filtru";
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(397, 17);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 23);
            this.btnCauta.TabIndex = 3;
            this.btnCauta.Text = "Aplica filtru";
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(397, 58);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Sterge filtru";
            // 
            // txtDataStart
            // 
            this.txtDataStart.CalendarFirstDayOfWeek = Gizmox.WebGUI.Forms.Day.Default;
            this.txtDataStart.CustomFormat = "dd/MM/yyyy";
            this.txtDataStart.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Custom;
            this.txtDataStart.Location = new System.Drawing.Point(3, 67);
            this.txtDataStart.Name = "txtDataStart";
            this.txtDataStart.Size = new System.Drawing.Size(103, 21);
            this.txtDataStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "De la data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "pana la data:";
            // 
            // txtDataEnd
            // 
            this.txtDataEnd.CalendarFirstDayOfWeek = Gizmox.WebGUI.Forms.Day.Default;
            this.txtDataEnd.CustomFormat = "dd/MM/yyyy";
            this.txtDataEnd.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Custom;
            this.txtDataEnd.Location = new System.Drawing.Point(112, 67);
            this.txtDataEnd.Name = "txtDataEnd";
            this.txtDataEnd.Size = new System.Drawing.Size(103, 21);
            this.txtDataEnd.TabIndex = 1;
            // 
            // cmbAmbalaje
            // 
            this.cmbAmbalaje.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Fixed3D;
            this.cmbAmbalaje.FormattingEnabled = true;
            this.cmbAmbalaje.Location = new System.Drawing.Point(133, 17);
            this.cmbAmbalaje.MaxDropDownItems = 8;
            this.cmbAmbalaje.Name = "cmbAmbalaje";
            this.cmbAmbalaje.Size = new System.Drawing.Size(121, 21);
            this.cmbAmbalaje.TabIndex = 4;
            // 
            // cmbFirme
            // 
            this.cmbFirme.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Fixed3D;
            this.cmbFirme.FormattingEnabled = true;
            this.cmbFirme.Location = new System.Drawing.Point(3, 17);
            this.cmbFirme.MaxDropDownItems = 8;
            this.cmbFirme.Name = "cmbFirme";
            this.cmbFirme.Size = new System.Drawing.Size(121, 21);
            this.cmbFirme.TabIndex = 4;
            // 
            // grdDetalii
            // 
            this.grdDetalii.AutoGenerateColumns = false;
            this.grdDetalii.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.grdDetalii.ColumnHeadersHeightSizeMode = Gizmox.WebGUI.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalii.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn11});
            this.grdDetalii.DataSource = this.bindingSource2;
            this.grdDetalii.Location = new System.Drawing.Point(350, 94);
            this.grdDetalii.Name = "grdDetalii";
            this.grdDetalii.RowTemplate.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-US");
            this.grdDetalii.Size = new System.Drawing.Size(445, 313);
            this.grdDetalii.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Ambalaj";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ambalaj";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Numar";
            this.dataGridViewTextBoxColumn13.HeaderText = "Numar";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Greutate";
            this.dataGridViewTextBoxColumn11.HeaderText = "Greutate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.AllowNew = false;
            this.bindingSource2.DataSource = this.bindingSource4;
            // 
            // bindingSource4
            // 
            this.bindingSource4.AllowNew = false;
            this.bindingSource4.DataSource = typeof(BoglarChamp.NHibernate.Core.ScanareDetaliiIMO);
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "DataScanare";
            this.dataGridViewTextBoxColumn15.HeaderText = "Data scanare";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Ambalaj";
            this.dataGridViewTextBoxColumn23.HeaderText = "Ambalaj";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "AmbalajId";
            this.dataGridViewTextBoxColumn24.HeaderText = "AmbalajId";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Celula";
            this.dataGridViewTextBoxColumn25.HeaderText = "Celula";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Hala";
            this.dataGridViewTextBoxColumn26.HeaderText = "Hala";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Greutate";
            this.dataGridViewTextBoxColumn27.HeaderText = "Greutate";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Sef";
            this.dataGridViewTextBoxColumn28.HeaderText = "Sef";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // grdScanari
            // 
            this.grdScanari.AutoGenerateColumns = false;
            this.grdScanari.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.grdScanari.ColumnHeadersHeightSizeMode = Gizmox.WebGUI.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdScanari.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.grdScanari.DataSource = this.bindingSource1;
            this.grdScanari.Location = new System.Drawing.Point(6, 94);
            this.grdScanari.Name = "grdScanari";
            this.grdScanari.RowTemplate.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-US");
            this.grdScanari.Size = new System.Drawing.Size(344, 313);
            this.grdScanari.TabIndex = 1;
            this.grdScanari.SelectionChanged += new System.EventHandler(this.grdScanari_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataScanare";
            this.dataGridViewTextBoxColumn3.HeaderText = "DataScanare";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = false;
            this.bindingSource1.DataSource = this.bindingSource3;
            // 
            // bindingSource3
            // 
            this.bindingSource3.AllowNew = false;
            this.bindingSource3.DataSource = typeof(BoglarChamp.NHibernate.Core.ScanareIMO);
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn29.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Prenume";
            this.dataGridViewTextBoxColumn30.HeaderText = "Prenume";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "DataScanare";
            this.dataGridViewTextBoxColumn31.HeaderText = "DataScanare";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Firma";
            this.dataGridViewTextBoxColumn33.HeaderText = "Firma";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // btnRaportAmbalaje
            // 
            this.btnRaportAmbalaje.Location = new System.Drawing.Point(6, 447);
            this.btnRaportAmbalaje.Name = "btnRaportAmbalaje";
            this.btnRaportAmbalaje.Size = new System.Drawing.Size(100, 23);
            this.btnRaportAmbalaje.TabIndex = 5;
            this.btnRaportAmbalaje.Text = "Raport ambalaje";
            this.btnRaportAmbalaje.Click += new System.EventHandler(this.btnRaportAmbalaje_Click);
            // 
            // lbNrScanari
            // 
            this.lbNrScanari.AutoSize = true;
            this.lbNrScanari.Location = new System.Drawing.Point(3, 418);
            this.lbNrScanari.Name = "lbNrScanari";
            this.lbNrScanari.Size = new System.Drawing.Size(35, 13);
            this.lbNrScanari.TabIndex = 6;
            this.lbNrScanari.Text = "0 scanari filtrate";
            // 
            // lbTotalGreutate
            // 
            this.lbTotalGreutate.AutoSize = true;
            this.lbTotalGreutate.Location = new System.Drawing.Point(357, 418);
            this.lbTotalGreutate.Name = "lbTotalGreutate";
            this.lbTotalGreutate.Size = new System.Drawing.Size(35, 13);
            this.lbTotalGreutate.TabIndex = 7;
            this.lbTotalGreutate.Text = "Total greutate: 0";
            // 
            // CentralizatorAmbalaje
            // 
            this.Controls.Add(this.lbTotalGreutate);
            this.Controls.Add(this.lbNrScanari);
            this.Controls.Add(this.btnRaportAmbalaje);
            this.Controls.Add(this.grdScanari);
            this.Controls.Add(this.grdDetalii);
            this.Controls.Add(this.Filtru);
            this.Size = new System.Drawing.Size(800, 500);
            this.Filtru.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdScanari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.GroupBox Filtru;
        private Gizmox.WebGUI.Forms.ComboBox cmbAmbalaje;
        private Gizmox.WebGUI.Forms.ComboBox cmbFirme;
        private Gizmox.WebGUI.Forms.DateTimePicker txtDataStart;
        private Gizmox.WebGUI.Forms.Label label1;
        private Gizmox.WebGUI.Forms.Label label2;
        private Gizmox.WebGUI.Forms.DateTimePicker txtDataEnd;
        private Gizmox.WebGUI.Forms.Button btnCauta;
        private Gizmox.WebGUI.Forms.Button btnClear;
        private Gizmox.WebGUI.Forms.DataGridView grdDetalii;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private Gizmox.WebGUI.Forms.DataGridView grdScanari;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private Gizmox.WebGUI.Forms.Button btnRaportAmbalaje;
        private Gizmox.WebGUI.Forms.BindingSource bindingSource1;
        private Gizmox.WebGUI.Forms.BindingSource bindingSource2;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private Gizmox.WebGUI.Forms.BindingSource bindingSource4;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Gizmox.WebGUI.Forms.BindingSource bindingSource3;
        private Gizmox.WebGUI.Forms.Label lbNrScanari;
        private Gizmox.WebGUI.Forms.Label lbTotalGreutate;
    }
}
