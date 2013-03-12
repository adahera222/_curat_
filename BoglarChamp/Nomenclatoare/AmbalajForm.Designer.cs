namespace BoglarChamp.Nomenclatoare
{
    partial class AmbalajForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.txtDenumire = new Gizmox.WebGUI.Forms.TextBox();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.txtGreutate = new Gizmox.WebGUI.Forms.NumericUpDown();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.ckAnulat = new Gizmox.WebGUI.Forms.CheckBox();
            this.errorProvider1 = new Gizmox.WebGUI.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtGreutate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenumire.Location = new System.Drawing.Point(98, 36);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(149, 24);
            this.txtDenumire.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Greutate";
            // 
            // txtGreutate
            // 
            this.txtGreutate.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtGreutate.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Fixed3D;
            this.txtGreutate.CurrentValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGreutate.CurrentValueChanged = false;
            this.txtGreutate.DecimalPlaces = 2;
            this.txtGreutate.Location = new System.Drawing.Point(98, 83);
            this.txtGreutate.Name = "txtGreutate";
            this.txtGreutate.Size = new System.Drawing.Size(61, 20);
            this.txtGreutate.TabIndex = 3;
            this.txtGreutate.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Left;
            this.txtGreutate.UpDownAlign = Gizmox.WebGUI.Forms.LeftRightAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "kg";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Salvare";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Renunta";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ckAnulat
            // 
            this.ckAnulat.AutoSize = true;
            this.ckAnulat.CheckState = Gizmox.WebGUI.Forms.CheckState.Unchecked;
            this.ckAnulat.Location = new System.Drawing.Point(98, 124);
            this.ckAnulat.Name = "ckAnulat";
            this.ckAnulat.Size = new System.Drawing.Size(57, 17);
            this.ckAnulat.TabIndex = 6;
            this.ckAnulat.Text = "Anulat";
            this.ckAnulat.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 3;
            this.errorProvider1.BlinkStyle = Gizmox.WebGUI.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            // 
            // AmbalajForm
            // 
            this.Controls.Add(this.ckAnulat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGreutate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.label1);
            this.Size = new System.Drawing.Size(304, 216);
            this.Text = "AmbalajForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtGreutate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Label label1;
        private Gizmox.WebGUI.Forms.TextBox txtDenumire;
        private Gizmox.WebGUI.Forms.Label label2;
        private Gizmox.WebGUI.Forms.NumericUpDown txtGreutate;
        private Gizmox.WebGUI.Forms.Label label3;
        private Gizmox.WebGUI.Forms.Button btnSave;
        private Gizmox.WebGUI.Forms.Button btnCancel;
        private Gizmox.WebGUI.Forms.CheckBox ckAnulat;
        private Gizmox.WebGUI.Forms.ErrorProvider errorProvider1;
    }
}