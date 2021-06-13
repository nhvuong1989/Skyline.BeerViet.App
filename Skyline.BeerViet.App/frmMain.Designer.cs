namespace Skyline.BeerViet.App
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribtProvince = new System.Windows.Forms.RibbonTab();
            this.ribpProvince = new System.Windows.Forms.RibbonPanel();
            this.ribbProvince = new System.Windows.Forms.RibbonButton();
            this.ribbAction = new System.Windows.Forms.RibbonButton();
            this.ribbGif = new System.Windows.Forms.RibbonButton();
            this.ribStock = new System.Windows.Forms.RibbonButton();
            this.ribMain = new System.Windows.Forms.Ribbon();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ribtProvince
            // 
            this.ribtProvince.Name = "ribtProvince";
            this.ribtProvince.Panels.Add(this.ribpProvince);
            this.ribtProvince.Text = "";
            // 
            // ribpProvince
            // 
            this.ribpProvince.Items.Add(this.ribbProvince);
            this.ribpProvince.Items.Add(this.ribbAction);
            this.ribpProvince.Items.Add(this.ribbGif);
            this.ribpProvince.Items.Add(this.ribStock);
            this.ribpProvince.Name = "ribpProvince";
            this.ribpProvince.Text = "";
            // 
            // ribbProvince
            // 
            this.ribbProvince.CheckedGroup = "BeerViet";
            this.ribbProvince.CheckOnClick = true;
            this.ribbProvince.Image = ((System.Drawing.Image)(resources.GetObject("ribbProvince.Image")));
            this.ribbProvince.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbProvince.LargeImage")));
            this.ribbProvince.MinimumSize = new System.Drawing.Size(100, 0);
            this.ribbProvince.Name = "ribbProvince";
            this.ribbProvince.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbProvince.SmallImage")));
            this.ribbProvince.Text = "Danh sách tỉnh";
            this.ribbProvince.Click += new System.EventHandler(this.ribbProvince_Click);
            // 
            // ribbAction
            // 
            this.ribbAction.CheckedGroup = "BeerViet";
            this.ribbAction.CheckOnClick = true;
            this.ribbAction.Image = ((System.Drawing.Image)(resources.GetObject("ribbAction.Image")));
            this.ribbAction.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbAction.LargeImage")));
            this.ribbAction.MinimumSize = new System.Drawing.Size(100, 0);
            this.ribbAction.Name = "ribbAction";
            this.ribbAction.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbAction.SmallImage")));
            this.ribbAction.Text = "Danh sách hoạt động";
            this.ribbAction.Click += new System.EventHandler(this.ribbAction_Click);
            // 
            // ribbGif
            // 
            this.ribbGif.CheckedGroup = "BeerViet";
            this.ribbGif.CheckOnClick = true;
            this.ribbGif.Image = ((System.Drawing.Image)(resources.GetObject("ribbGif.Image")));
            this.ribbGif.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbGif.LargeImage")));
            this.ribbGif.MinimumSize = new System.Drawing.Size(100, 0);
            this.ribbGif.Name = "ribbGif";
            this.ribbGif.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbGif.SmallImage")));
            this.ribbGif.Text = "Quản lý quà";
            this.ribbGif.Click += new System.EventHandler(this.ribbGif_Click);
            // 
            // ribStock
            // 
            this.ribStock.CheckedGroup = "BeerViet";
            this.ribStock.CheckOnClick = true;
            this.ribStock.Image = ((System.Drawing.Image)(resources.GetObject("ribStock.Image")));
            this.ribStock.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribStock.LargeImage")));
            this.ribStock.MinimumSize = new System.Drawing.Size(100, 0);
            this.ribStock.Name = "ribStock";
            this.ribStock.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribStock.SmallImage")));
            this.ribStock.Text = "Quản lý kho";
            this.ribStock.Click += new System.EventHandler(this.ribStock_Click);
            // 
            // ribMain
            // 
            this.ribMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribMain.Location = new System.Drawing.Point(0, 0);
            this.ribMain.Margin = new System.Windows.Forms.Padding(4);
            this.ribMain.Minimized = false;
            this.ribMain.Name = "ribMain";
            // 
            // 
            // 
            this.ribMain.OrbDropDown.BorderRoundness = 8;
            this.ribMain.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribMain.OrbDropDown.Name = "";
            this.ribMain.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribMain.OrbDropDown.TabIndex = 0;
            this.ribMain.OrbVisible = false;
            // 
            // 
            // 
            this.ribMain.QuickAccessToolbar.DropDownButtonVisible = false;
            this.ribMain.QuickAccessToolbar.Enabled = false;
            this.ribMain.QuickAccessToolbar.Visible = false;
            this.ribMain.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribMain.Size = new System.Drawing.Size(1432, 166);
            this.ribMain.TabIndex = 0;
            this.ribMain.Tabs.Add(this.ribtProvince);
            this.ribMain.Text = "rubMain";
            this.ribMain.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 166);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1432, 563);
            this.panelMain.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 729);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ribMain);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RibbonTab ribtProvince;
        private System.Windows.Forms.Ribbon ribMain;
        private System.Windows.Forms.RibbonPanel ribpProvince;
        private System.Windows.Forms.RibbonButton ribbProvince;
        private System.Windows.Forms.RibbonButton ribbAction;
        private System.Windows.Forms.RibbonButton ribbGif;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.RibbonButton ribStock;
    }
}

