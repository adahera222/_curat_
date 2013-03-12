namespace BoglarChamp.Nomenclatoare
{
    partial class CeluleUC
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
            this.gbFilter = new Gizmox.WebGUI.Forms.GroupBox();
            this.rbCeluleActive = new Gizmox.WebGUI.Forms.RadioButton();
            this.rbToateCelulele = new Gizmox.WebGUI.Forms.RadioButton();
            this.grdCelule = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn();
            this.bindingSource1 = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn();
            this.btnAdauga = new Gizmox.WebGUI.Forms.Button();
            this.btnModifica = new Gizmox.WebGUI.Forms.Button();
            this.btnAnuleaza = new Gizmox.WebGUI.Forms.Button();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCelule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.rbCeluleActive);
            this.gbFilter.Controls.Add(this.rbToateCelulele);
            this.gbFilter.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(602, 70);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filtru";
            // 
            // rbCeluleActive
            // 
            this.rbCeluleActive.AutoSize = true;
            this.rbCeluleActive.Location = new System.Drawing.Point(246, 28);
            this.rbCeluleActive.Name = "rbCeluleActive";
            this.rbCeluleActive.Size = new System.Drawing.Size(86, 17);
            this.rbCeluleActive.TabIndex = 0;
            this.rbCeluleActive.Text = "Celule active";
            // 
            // rbToateCelulele
            // 
            this.rbToateCelulele.AutoSize = true;
            this.rbToateCelulele.Location = new System.Drawing.Point(13, 28);
            this.rbToateCelulele.Name = "rbToateCelulele";
            this.rbToateCelulele.Size = new System.Drawing.Size(91, 17);
            this.rbToateCelulele.TabIndex = 0;
            this.rbToateCelulele.Text = "Toate celulele";
            this.rbToateCelulele.UseVisualStyleBackColor = true;
            this.rbToateCelulele.CheckedChanged += new System.EventHandler(this.rbToateCelulele_CheckedChanged);
            // 
            // grdCelule
            // 
            this.grdCelule.AutoGenerateColumns = false;
            this.grdCelule.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.grdCelule.ColumnHeadersHeightSizeMode = Gizmox.WebGUI.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCelule.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn4});
            this.grdCelule.DataSource = this.bindingSource1;
            this.grdCelule.Location = new System.Drawing.Point(0, 70);
            this.grdCelule.Name = "grdCelule";
            this.grdCelule.RowTemplate.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-US");
            this.grdCelule.Size = new System.Drawing.Size(599, 330);
            this.grdCelule.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn8.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Hala";
            this.dataGridViewTextBoxColumn9.HeaderText = "Hala";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Anulat";
            this.dataGridViewCheckBoxColumn4.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Standard;
            this.dataGridViewCheckBoxColumn4.HeaderText = "Anulat";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = false;
            this.bindingSource1.DataSource = typeof(BoglarChamp.NHibernate.Core.CelulaIMO);
            this.bindingSource1.PositionChanged += new System.EventHandler(this.bindingSource1_PositionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn3.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Anulat";
            this.dataGridViewCheckBoxColumn3.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Standard;
            this.dataGridViewCheckBoxColumn3.HeaderText = "Anulat";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Hala";
            this.dataGridViewTextBoxColumn6.HeaderText = "Hala";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn4.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Hala";
            this.dataGridViewTextBoxColumn5.HeaderText = "Hala";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Anulat";
            this.dataGridViewCheckBoxColumn2.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Standard;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Anulat";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn2.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Anulat";
            this.dataGridViewCheckBoxColumn1.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Standard;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Anulat";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnAdauga.Location = new System.Drawing.Point(13, 461);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(73, 24);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnModifica.Location = new System.Drawing.Point(135, 461);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(73, 24);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnAnuleaza.Location = new System.Drawing.Point(259, 461);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(73, 24);
            this.btnAnuleaza.TabIndex = 2;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // CeluleUC
            // 
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.grdCelule);
            this.Controls.Add(this.gbFilter);
            this.Size = new System.Drawing.Size(602, 500);
            this.gbFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCelule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.GroupBox gbFilter;
        private Gizmox.WebGUI.Forms.RadioButton rbCeluleActive;
        private Gizmox.WebGUI.Forms.RadioButton rbToateCelulele;
        private Gizmox.WebGUI.Forms.DataGridView grdCelule;
        private Gizmox.WebGUI.Forms.Button btnAdauga;
        private Gizmox.WebGUI.Forms.Button btnModifica;
        private Gizmox.WebGUI.Forms.Button btnAnuleaza;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Gizmox.WebGUI.Forms.BindingSource bindingSource1;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
