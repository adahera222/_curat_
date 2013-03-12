namespace BoglarChamp.Nomenclatoare
{
    partial class HalaForm
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
            this.ckAnulat = new Gizmox.WebGUI.Forms.CheckBox();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.errorProvider1 = new Gizmox.WebGUI.Forms.ErrorProvider(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(93, 28);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(164, 22);
            this.txtDenumire.TabIndex = 1;
            // 
            // ckAnulat
            // 
            this.ckAnulat.AutoSize = true;
            this.ckAnulat.CheckState = Gizmox.WebGUI.Forms.CheckState.Unchecked;
            this.ckAnulat.Location = new System.Drawing.Point(93, 66);
            this.ckAnulat.Name = "ckAnulat";
            this.ckAnulat.Size = new System.Drawing.Size(57, 17);
            this.ckAnulat.TabIndex = 2;
            this.ckAnulat.Text = "Anulat";
            this.ckAnulat.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvare";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(182, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Renunta";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 3;
            this.errorProvider1.BlinkStyle = Gizmox.WebGUI.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            // 
            // HalaForm
            // 
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ckAnulat);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.label1);
            this.Size = new System.Drawing.Size(325, 151);
            this.Text = "HalaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Label label1;
        private Gizmox.WebGUI.Forms.TextBox txtDenumire;
        private Gizmox.WebGUI.Forms.CheckBox ckAnulat;
        private Gizmox.WebGUI.Forms.Button btnSave;
        private Gizmox.WebGUI.Forms.Button btnCancel;
        private Gizmox.WebGUI.Forms.ErrorProvider errorProvider1;
    }
}