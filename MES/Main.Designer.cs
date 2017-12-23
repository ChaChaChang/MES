namespace MES
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mODELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eQUIPMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shippingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.miCascad = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCurrentUserId = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWipCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.miLogin = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mODELToolStripMenuItem,
            this.wipToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.shippingToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.miWindows,
            this.systemToolStripMenuItem,
            this.miAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.miWindows;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mODELToolStripMenuItem
            // 
            this.mODELToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelsToolStripMenuItem});
            this.mODELToolStripMenuItem.Name = "mODELToolStripMenuItem";
            this.mODELToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.mODELToolStripMenuItem.Text = "File";
            // 
            // modelsToolStripMenuItem
            // 
            this.modelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOTToolStripMenuItem,
            this.eQUIPMENTToolStripMenuItem});
            this.modelsToolStripMenuItem.Name = "modelsToolStripMenuItem";
            this.modelsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.modelsToolStripMenuItem.Text = "Master Models";
            // 
            // lOTToolStripMenuItem
            // 
            this.lOTToolStripMenuItem.Name = "lOTToolStripMenuItem";
            this.lOTToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.lOTToolStripMenuItem.Text = "LOTS TABLE";
            // 
            // eQUIPMENTToolStripMenuItem
            // 
            this.eQUIPMENTToolStripMenuItem.Name = "eQUIPMENTToolStripMenuItem";
            this.eQUIPMENTToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.eQUIPMENTToolStripMenuItem.Text = "EQUIPMENTS TABLE";
            // 
            // wipToolStripMenuItem
            // 
            this.wipToolStripMenuItem.Name = "wipToolStripMenuItem";
            this.wipToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.wipToolStripMenuItem.Text = "Operator";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // shippingToolStripMenuItem
            // 
            this.shippingToolStripMenuItem.Name = "shippingToolStripMenuItem";
            this.shippingToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.shippingToolStripMenuItem.Text = "Shipping";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // miWindows
            // 
            this.miWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCascad});
            this.miWindows.Name = "miWindows";
            this.miWindows.Size = new System.Drawing.Size(72, 20);
            this.miWindows.Text = "Windows";
            // 
            // miCascad
            // 
            this.miCascad.Name = "miCascad";
            this.miCascad.Size = new System.Drawing.Size(152, 22);
            this.miCascad.Text = "Cascad";
            this.miCascad.Click += new System.EventHandler(this.miCascad_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miClose});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // miClose
            // 
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(152, 22);
            this.miClose.Text = "Exit";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(55, 20);
            this.miAbout.Text = "About";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblWipCount,
            this.lblCurrentUserId});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(610, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCurrentUserId
            // 
            this.lblCurrentUserId.Name = "lblCurrentUserId";
            this.lblCurrentUserId.Size = new System.Drawing.Size(129, 17);
            this.lblCurrentUserId.Text = "toolStripStatusLabel1";
            // 
            // lblWipCount
            // 
            this.lblWipCount.Name = "lblWipCount";
            this.lblWipCount.Size = new System.Drawing.Size(129, 17);
            this.lblWipCount.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(610, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // miLogin
            // 
            this.miLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.miLogin.Image = ((System.Drawing.Image)(resources.GetObject("miLogin.Image")));
            this.miLogin.ImageTransparentColor = System.Drawing.Color.LimeGreen;
            this.miLogin.Name = "miLogin";
            this.miLogin.Size = new System.Drawing.Size(23, 22);
            this.miLogin.Text = "toolStripButton1";
            this.miLogin.ToolTipText = "Login with your MES account please.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "MANUFACTURING EXECUTION SYSTEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mODELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shippingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miWindows;
        private System.Windows.Forms.ToolStripMenuItem miCascad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentUserId;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miClose;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem modelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQUIPMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblWipCount;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton miLogin;
    }
}

