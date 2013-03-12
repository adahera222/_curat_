namespace BoglarChamp.Rapoarte
{
    partial class ReportForm
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

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.aspPageBox1 = new Gizmox.WebGUI.Forms.Hosts.AspPageBox();
            this.btnExit = new Gizmox.WebGUI.Forms.Button();
            this.SuspendLayout();
            // 
            // aspPageBox1
            // 
            this.aspPageBox1.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom)
                        | Gizmox.WebGUI.Forms.AnchorStyles.Left)
                        | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.aspPageBox1.BackColor = System.Drawing.Color.White;
            this.aspPageBox1.BackgroundImage = null;
            resources.ApplyResources(this.aspPageBox1, "aspPageBox1");
            this.aspPageBox1.Location = new System.Drawing.Point(2, 2);
            this.aspPageBox1.Name = "aspPageBox1";
            this.aspPageBox1.Path = null;
            this.aspPageBox1.Size = new System.Drawing.Size(415, 434);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackgroundImage = null;
            this.btnExit.Location = new System.Drawing.Point(341, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ReportForm
            // 
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = null;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.aspPageBox1);
            this.FormBorderStyle = Gizmox.WebGUI.Forms.FormBorderStyle.FixedDialog;
            this.FormStyle = Gizmox.WebGUI.Forms.FormStyle.Application;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(419, 466);
            this.WindowState = Gizmox.WebGUI.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Hosts.AspPageBox aspPageBox1;
        private Gizmox.WebGUI.Forms.Button btnExit;


    }
}