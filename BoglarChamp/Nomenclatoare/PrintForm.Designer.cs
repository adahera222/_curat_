namespace BoglarChamp.Nomenclatoare
{
    partial class PrintForm
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
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.btnPrint = new Gizmox.WebGUI.Forms.Button();
            this.txtMinInterval = new Gizmox.WebGUI.Forms.NumericUpDown();
            this.txtMaxInterval = new Gizmox.WebGUI.Forms.NumericUpDown();
            this.lbNume = new Gizmox.WebGUI.Forms.Label();
            this.lbPrenume = new Gizmox.WebGUI.Forms.Label();
            this.lbCod = new Gizmox.WebGUI.Forms.Label();
            this.btnExit = new Gizmox.WebGUI.Forms.Button();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.lbNumar = new Gizmox.WebGUI.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prenume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cod:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Interval nr. exemplar";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(34, 182);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Imprima";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtMinInterval
            // 
            this.txtMinInterval.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtMinInterval.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Fixed3D;
            this.txtMinInterval.CurrentValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMinInterval.CurrentValueChanged = false;
            this.txtMinInterval.Location = new System.Drawing.Point(159, 134);
            this.txtMinInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMinInterval.Name = "txtMinInterval";
            this.txtMinInterval.Size = new System.Drawing.Size(64, 20);
            this.txtMinInterval.TabIndex = 2;
            this.txtMinInterval.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Left;
            this.txtMinInterval.UpDownAlign = Gizmox.WebGUI.Forms.LeftRightAlignment.Right;
            this.txtMinInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMaxInterval
            // 
            this.txtMaxInterval.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtMaxInterval.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.Fixed3D;
            this.txtMaxInterval.CurrentValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMaxInterval.CurrentValueChanged = false;
            this.txtMaxInterval.Location = new System.Drawing.Point(249, 134);
            this.txtMaxInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMaxInterval.Name = "txtMaxInterval";
            this.txtMaxInterval.Size = new System.Drawing.Size(64, 20);
            this.txtMaxInterval.TabIndex = 2;
            this.txtMaxInterval.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Left;
            this.txtMaxInterval.UpDownAlign = Gizmox.WebGUI.Forms.LeftRightAlignment.Right;
            this.txtMaxInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNume.Location = new System.Drawing.Point(82, 9);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(35, 13);
            this.lbNume.TabIndex = 0;
            // 
            // lbPrenume
            // 
            this.lbPrenume.AutoSize = true;
            this.lbPrenume.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenume.Location = new System.Drawing.Point(103, 39);
            this.lbPrenume.Name = "lbPrenume";
            this.lbPrenume.Size = new System.Drawing.Size(35, 13);
            this.lbPrenume.TabIndex = 3;
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCod.Location = new System.Drawing.Point(77, 68);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(35, 13);
            this.lbCod.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(285, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Renunta";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Numar:";
            // 
            // lbNumar
            // 
            this.lbNumar.AutoSize = true;
            this.lbNumar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumar.Location = new System.Drawing.Point(82, 99);
            this.lbNumar.Name = "lbNumar";
            this.lbNumar.Size = new System.Drawing.Size(35, 13);
            this.lbNumar.TabIndex = 5;
            // 
            // PrintForm
            // 
            this.Controls.Add(this.lbNumar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbCod);
            this.Controls.Add(this.lbPrenume);
            this.Controls.Add(this.lbNume);
            this.Controls.Add(this.txtMaxInterval);
            this.Controls.Add(this.txtMinInterval);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Size = new System.Drawing.Size(402, 236);
            this.Text = "PrintForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtMinInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Label label1;
        private Gizmox.WebGUI.Forms.Label label2;
        private Gizmox.WebGUI.Forms.Label label3;
        private Gizmox.WebGUI.Forms.Label label4;
        private Gizmox.WebGUI.Forms.Button btnPrint;
        private Gizmox.WebGUI.Forms.NumericUpDown txtMinInterval;
        private Gizmox.WebGUI.Forms.NumericUpDown txtMaxInterval;
        private Gizmox.WebGUI.Forms.Label lbNume;
        private Gizmox.WebGUI.Forms.Label lbPrenume;
        private Gizmox.WebGUI.Forms.Label lbCod;
        private Gizmox.WebGUI.Forms.Button btnExit;
        private Gizmox.WebGUI.Forms.Label label5;
        private Gizmox.WebGUI.Forms.Label lbNumar;
    }
}