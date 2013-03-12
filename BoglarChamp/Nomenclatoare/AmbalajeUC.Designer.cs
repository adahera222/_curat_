namespace BoglarChamp.Nomenclatoare
{
    partial class AmbalajeUC
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
            this.rbAmbalajeleActive = new Gizmox.WebGUI.Forms.RadioButton();
            this.rbToateAmbalajele = new Gizmox.WebGUI.Forms.RadioButton();
            this.grdAmbalaje = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn();
            this.bindingSource1 = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.bindingSource2 = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn();
            this.btnAdauga = new Gizmox.WebGUI.Forms.Button();
            this.btnModifica = new Gizmox.WebGUI.Forms.Button();
            this.btnAnuleaza = new Gizmox.WebGUI.Forms.Button();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAmbalaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.rbAmbalajeleActive);
            this.gbFilter.Controls.Add(this.rbToateAmbalajele);
            this.gbFilter.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(601, 75);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filtru";
            // 
            // rbAmbalajeleActive
            // 
            this.rbAmbalajeleActive.AutoSize = true;
            this.rbAmbalajeleActive.Location = new System.Drawing.Point(184, 31);
            this.rbAmbalajeleActive.Name = "rbAmbalajeleActive";
            this.rbAmbalajeleActive.Size = new System.Drawing.Size(109, 17);
            this.rbAmbalajeleActive.TabIndex = 0;
            this.rbAmbalajeleActive.Text = "Ambalajele active";
            // 
            // rbToateAmbalajele
            // 
            this.rbToateAmbalajele.AutoSize = true;
            this.rbToateAmbalajele.Location = new System.Drawing.Point(16, 31);
            this.rbToateAmbalajele.Name = "rbToateAmbalajele";
            this.rbToateAmbalajele.Size = new System.Drawing.Size(107, 17);
            this.rbToateAmbalajele.TabIndex = 0;
            this.rbToateAmbalajele.Text = "Toate ambalajele";
            this.rbToateAmbalajele.UseVisualStyleBackColor = true;
            this.rbToateAmbalajele.CheckedChanged += new System.EventHandler(this.rbToateAmbalajele_CheckedChanged);
            // 
            // grdAmbalaje
            // 
            this.grdAmbalaje.AutoGenerateColumns = false;
            this.grdAmbalaje.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.grdAmbalaje.ColumnHeadersHeightSizeMode = Gizmox.WebGUI.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAmbalaje.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn4});
            this.grdAmbalaje.DataSource = this.bindingSource1;
            this.grdAmbalaje.Location = new System.Drawing.Point(0, 75);
            this.grdAmbalaje.Name = "grdAmbalaje";
            this.grdAmbalaje.RowTemplate.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-US");
            this.grdAmbalaje.Size = new System.Drawing.Size(598, 326);
            this.grdAmbalaje.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn8.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Greutate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Greutate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Anulat";
            this.dataGridViewCheckBoxColumn4.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Standard;
            this.dataGridViewCheckBoxColumn4.HeaderText = "Anulat";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.bindingSource2;
            this.bindingSource1.PositionChanged += new System.EventHandler(this.bindingSource1_PositionChanged);
            // 
            // bindingSource2
            // 
            this.bindingSource2.AllowNew = false;
            this.bindingSource2.DataSource = typeof(BoglarChamp.NHibernate.Core.Entity.Ambalaj);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn7.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Greutate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Greutate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Anulat";
            this.dataGridViewCheckBoxColumn3.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Standard;
            this.dataGridViewCheckBoxColumn3.HeaderText = "Anulat";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Greutate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Greutate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Anulat";
            this.dataGridViewCheckBoxColumn2.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Standard;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Anulat";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn4.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn2.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Greutate";
            this.dataGridViewTextBoxColumn1.HeaderText = "Greutate";
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
            // btnAdauga
            // 
            this.btnAdauga.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnAdauga.Enabled = false;
            this.btnAdauga.Location = new System.Drawing.Point(16, 459);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(83, 25);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnModifica.Enabled = false;
            this.btnModifica.Location = new System.Drawing.Point(115, 459);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(83, 25);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnAnuleaza.Enabled = false;
            this.btnAnuleaza.Location = new System.Drawing.Point(210, 459);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(83, 25);
            this.btnAnuleaza.TabIndex = 2;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // AmbalajeUC
            // 
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.grdAmbalaje);
            this.Controls.Add(this.gbFilter);
            this.Location = new System.Drawing.Point(0, -222);
            this.Size = new System.Drawing.Size(601, 497);
            this.gbFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAmbalaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.GroupBox gbFilter;
        private Gizmox.WebGUI.Forms.RadioButton rbAmbalajeleActive;
        private Gizmox.WebGUI.Forms.RadioButton rbToateAmbalajele;
        private Gizmox.WebGUI.Forms.DataGridView grdAmbalaje;
        private Gizmox.WebGUI.Forms.Button btnAdauga;
        private Gizmox.WebGUI.Forms.Button btnModifica;
        private Gizmox.WebGUI.Forms.Button btnAnuleaza;
        private Gizmox.WebGUI.Forms.BindingSource bindingSource1;
        private Gizmox.WebGUI.Forms.BindingSource bindingSource2;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Gizmox.WebGUI.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
    }
}
