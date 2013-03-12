namespace BoglarChamp.Nomenclatoare
{
    partial class PersoanaForm
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
            this.txtNume = new Gizmox.WebGUI.Forms.TextBox();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.txtPrenume = new Gizmox.WebGUI.Forms.TextBox();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.lbCod = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.cmbFunctii = new Gizmox.WebGUI.Forms.ComboBox();
            this.ckAnulat = new Gizmox.WebGUI.Forms.CheckBox();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.errorProvider1 = new Gizmox.WebGUI.Forms.ErrorProvider(this.components);
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.txtNumar = new Gizmox.WebGUI.Forms.NumericUpDown();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.cmbFirme = new Gizmox.WebGUI.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(73, 30);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 20);
            this.txtNume.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prenume";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(95, 60);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(100, 20);
            this.txtPrenume.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cod";
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Location = new System.Drawing.Point(70, 120);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(35, 13);
            this.lbCod.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Functie";
            // 
            // cmbFunctii
            // 
            this.cmbFunctii.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Fixed3D;
            this.cmbFunctii.FormattingEnabled = true;
            this.cmbFunctii.Location = new System.Drawing.Point(95, 150);
            this.cmbFunctii.MaxDropDownItems = 8;
            this.cmbFunctii.Name = "cmbFunctii";
            this.cmbFunctii.Size = new System.Drawing.Size(121, 21);
            this.cmbFunctii.TabIndex = 5;
            // 
            // ckAnulat
            // 
            this.ckAnulat.AutoSize = true;
            this.ckAnulat.CheckState = Gizmox.WebGUI.Forms.CheckState.Unchecked;
            this.ckAnulat.Location = new System.Drawing.Point(203, 208);
            this.ckAnulat.Name = "ckAnulat";
            this.ckAnulat.Size = new System.Drawing.Size(57, 17);
            this.ckAnulat.TabIndex = 6;
            this.ckAnulat.Text = "Anulat";
            this.ckAnulat.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Salvare";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Renunta";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 3;
            this.errorProvider1.BlinkStyle = Gizmox.WebGUI.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numar";
            // 
            // txtNumar
            // 
            this.txtNumar.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtNumar.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Fixed3D;
            this.txtNumar.CurrentValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNumar.CurrentValueChanged = false;
            this.txtNumar.Location = new System.Drawing.Point(86, 90);
            this.txtNumar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtNumar.Name = "txtNumar";
            this.txtNumar.Size = new System.Drawing.Size(66, 20);
            this.txtNumar.TabIndex = 9;
            this.txtNumar.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Left;
            this.txtNumar.UpDownAlign = Gizmox.WebGUI.Forms.LeftRightAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Firma";
            // 
            // cmbFirme
            // 
            this.cmbFirme.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Fixed3D;
            this.cmbFirme.FormattingEnabled = true;
            this.cmbFirme.Location = new System.Drawing.Point(95, 180);
            this.cmbFirme.MaxDropDownItems = 8;
            this.cmbFirme.Name = "cmbFirme";
            this.cmbFirme.Size = new System.Drawing.Size(121, 21);
            this.cmbFirme.TabIndex = 5;
            // 
            // PersoanaForm
            // 
            this.Controls.Add(this.cmbFirme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ckAnulat);
            this.Controls.Add(this.cmbFunctii);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label1);
            this.Size = new System.Drawing.Size(304, 269);
            this.Text = "PersoanaForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Label label1;
        private Gizmox.WebGUI.Forms.TextBox txtNume;
        private Gizmox.WebGUI.Forms.Label label2;
        private Gizmox.WebGUI.Forms.TextBox txtPrenume;
        private Gizmox.WebGUI.Forms.Label label3;
        private Gizmox.WebGUI.Forms.Label lbCod;
        private Gizmox.WebGUI.Forms.Label label4;
        private Gizmox.WebGUI.Forms.ComboBox cmbFunctii;
        private Gizmox.WebGUI.Forms.CheckBox ckAnulat;
        private Gizmox.WebGUI.Forms.Button btnSave;
        private Gizmox.WebGUI.Forms.Button btnCancel;
        private Gizmox.WebGUI.Forms.ErrorProvider errorProvider1;
        private Gizmox.WebGUI.Forms.Label label5;
        private Gizmox.WebGUI.Forms.NumericUpDown txtNumar;
        private Gizmox.WebGUI.Forms.Label label6;
        private Gizmox.WebGUI.Forms.ComboBox cmbFirme;
    }
}