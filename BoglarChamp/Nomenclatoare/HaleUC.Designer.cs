namespace BoglarChamp.Nomenclatoare
{
    partial class HaleUC
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
            this.rbToateHalele = new Gizmox.WebGUI.Forms.RadioButton();
            this.rbHaleActive = new Gizmox.WebGUI.Forms.RadioButton();
            this.dgrHale = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn();
            this.bindingSource1 = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.btnAdauga = new Gizmox.WebGUI.Forms.Button();
            this.btnModifica = new Gizmox.WebGUI.Forms.Button();
            this.btnAnuleaza = new Gizmox.WebGUI.Forms.Button();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrHale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.rbToateHalele);
            this.gbFilter.Controls.Add(this.rbHaleActive);
            this.gbFilter.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(600, 64);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filtru";
            // 
            // rbToateHalele
            // 
            this.rbToateHalele.AutoSize = true;
            this.rbToateHalele.Location = new System.Drawing.Point(173, 30);
            this.rbToateHalele.Name = "rbToateHalele";
            this.rbToateHalele.Size = new System.Drawing.Size(84, 17);
            this.rbToateHalele.TabIndex = 0;
            this.rbToateHalele.Text = "Toate halele";
            // 
            // rbHaleActive
            // 
            this.rbHaleActive.AutoSize = true;
            this.rbHaleActive.Location = new System.Drawing.Point(3, 30);
            this.rbHaleActive.Name = "rbHaleActive";
            this.rbHaleActive.Size = new System.Drawing.Size(78, 17);
            this.rbHaleActive.TabIndex = 0;
            this.rbHaleActive.Text = "Hale active";
            this.rbHaleActive.UseVisualStyleBackColor = true;
            this.rbHaleActive.CheckedChanged += new System.EventHandler(this.rbHaleActive_CheckedChanged);
            // 
            // dgrHale
            // 
            this.dgrHale.AutoGenerateColumns = false;
            this.dgrHale.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.dgrHale.ColumnHeadersHeightSizeMode = Gizmox.WebGUI.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrHale.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1});
            this.dgrHale.DataSource = this.bindingSource1;
            this.dgrHale.Location = new System.Drawing.Point(0, 64);
            this.dgrHale.Name = "dgrHale";
            this.dgrHale.RowTemplate.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-US");
            this.dgrHale.Size = new System.Drawing.Size(597, 336);
            this.dgrHale.TabIndex = 1;
            this.dgrHale.Click += new System.EventHandler(this.dgrHale_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn1.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Anulat";
            this.dataGridViewCheckBoxColumn1.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Standard;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Anulat";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = false;
            this.bindingSource1.DataSource = typeof(BoglarChamp.NHibernate.Core.Entity.Hala);
            this.bindingSource1.PositionChanged += new System.EventHandler(this.bindingSource1_PositionChanged);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnAdauga.Location = new System.Drawing.Point(16, 457);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(86, 24);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnModifica.Location = new System.Drawing.Point(126, 457);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(86, 24);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnAnuleaza.Location = new System.Drawing.Point(240, 457);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(86, 24);
            this.btnAnuleaza.TabIndex = 2;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // HaleUC
            // 
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dgrHale);
            this.Controls.Add(this.gbFilter);
            this.Size = new System.Drawing.Size(600, 499);
            this.gbFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrHale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.GroupBox gbFilter;
        private Gizmox.WebGUI.Forms.DataGridView dgrHale;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Gizmox.WebGUI.Forms.Button btnAdauga;
        private Gizmox.WebGUI.Forms.Button btnModifica;
        private Gizmox.WebGUI.Forms.Button btnAnuleaza;
        private Gizmox.WebGUI.Forms.BindingSource bindingSource1;
        private Gizmox.WebGUI.Forms.RadioButton rbHaleActive;
        private Gizmox.WebGUI.Forms.RadioButton rbToateHalele;
    }
}
