namespace MES
{
    partial class frmSplashScreen
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
            this.lbApp = new System.Windows.Forms.Label();
            this.lbAppVer = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbApp
            // 
            this.lbApp.AutoSize = true;
            this.lbApp.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbApp.Location = new System.Drawing.Point(12, 9);
            this.lbApp.Name = "lbApp";
            this.lbApp.Size = new System.Drawing.Size(0, 32);
            this.lbApp.TabIndex = 0;
            // 
            // lbAppVer
            // 
            this.lbAppVer.AutoSize = true;
            this.lbAppVer.Location = new System.Drawing.Point(614, 369);
            this.lbAppVer.Name = "lbAppVer";
            this.lbAppVer.Size = new System.Drawing.Size(33, 12);
            this.lbAppVer.TabIndex = 1;
            this.lbAppVer.Text = "label1";
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbCompany.Location = new System.Drawing.Point(614, 341);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(33, 12);
            this.lbCompany.TabIndex = 2;
            this.lbCompany.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MES.Properties.Resources.Splash;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 391);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 390);
            this.ControlBox = false;
            this.Controls.Add(this.lbCompany);
            this.Controls.Add(this.lbAppVer);
            this.Controls.Add(this.lbApp);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbApp;
        private System.Windows.Forms.Label lbAppVer;
        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}