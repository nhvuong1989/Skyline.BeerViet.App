namespace Skyline.BeerViet.App
{
    partial class ucActive
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.dtpViewDate = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvCheckIn = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUniqueCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvinceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMnuApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uploadStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.colSaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhBeerVietNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGif7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGif1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGif2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGif3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGif4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGif5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGif6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).BeginInit();
            this.cMnuApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.dtpViewDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(214, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm action";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(133, 16);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dtpViewDate
            // 
            this.dtpViewDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpViewDate.Location = new System.Drawing.Point(34, 16);
            this.dtpViewDate.Name = "dtpViewDate";
            this.dtpViewDate.Size = new System.Drawing.Size(93, 20);
            this.dtpViewDate.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvCheckIn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSale);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 490);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvCheckIn
            // 
            this.dgvCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colUniqueCode,
            this.colWorkType,
            this.colUserName,
            this.colFullName,
            this.colProvinceName,
            this.colShopName,
            this.colAddress,
            this.colTeamName,
            this.colCheckInTime,
            this.colCheckOutTime});
            this.dgvCheckIn.ContextMenuStrip = this.cMnuApplication;
            this.dgvCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheckIn.Location = new System.Drawing.Point(0, 0);
            this.dgvCheckIn.MultiSelect = false;
            this.dgvCheckIn.Name = "dgvCheckIn";
            this.dgvCheckIn.ReadOnly = true;
            this.dgvCheckIn.RowHeadersVisible = false;
            this.dgvCheckIn.RowHeadersWidth = 51;
            this.dgvCheckIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckIn.Size = new System.Drawing.Size(1008, 223);
            this.dgvCheckIn.TabIndex = 0;
            this.dgvCheckIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckIn_CellContentClick);
            this.dgvCheckIn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckIn_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 125;
            // 
            // colUniqueCode
            // 
            this.colUniqueCode.DataPropertyName = "UniqueCode";
            this.colUniqueCode.HeaderText = "Mã code";
            this.colUniqueCode.MinimumWidth = 6;
            this.colUniqueCode.Name = "colUniqueCode";
            this.colUniqueCode.ReadOnly = true;
            this.colUniqueCode.Width = 150;
            // 
            // colWorkType
            // 
            this.colWorkType.DataPropertyName = "WorkType";
            this.colWorkType.HeaderText = "Loại hình";
            this.colWorkType.MinimumWidth = 6;
            this.colWorkType.Name = "colWorkType";
            this.colWorkType.ReadOnly = true;
            this.colWorkType.Width = 125;
            // 
            // colUserName
            // 
            this.colUserName.DataPropertyName = "UserName";
            this.colUserName.HeaderText = "Nhân viên";
            this.colUserName.MinimumWidth = 6;
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            this.colUserName.Width = 125;
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "Tên nhân viên";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Width = 150;
            // 
            // colProvinceName
            // 
            this.colProvinceName.DataPropertyName = "ProvinceName";
            this.colProvinceName.HeaderText = "Tỉnh";
            this.colProvinceName.MinimumWidth = 6;
            this.colProvinceName.Name = "colProvinceName";
            this.colProvinceName.ReadOnly = true;
            this.colProvinceName.Width = 125;
            // 
            // colShopName
            // 
            this.colShopName.DataPropertyName = "ShopName";
            this.colShopName.HeaderText = "Chợ";
            this.colShopName.MinimumWidth = 6;
            this.colShopName.Name = "colShopName";
            this.colShopName.ReadOnly = true;
            this.colShopName.Width = 125;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Địa chỉ";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 150;
            // 
            // colTeamName
            // 
            this.colTeamName.DataPropertyName = "TeamName";
            this.colTeamName.HeaderText = "Team";
            this.colTeamName.MinimumWidth = 6;
            this.colTeamName.Name = "colTeamName";
            this.colTeamName.ReadOnly = true;
            this.colTeamName.Width = 125;
            // 
            // colCheckInTime
            // 
            this.colCheckInTime.DataPropertyName = "CheckInTime";
            this.colCheckInTime.HeaderText = "Checkin";
            this.colCheckInTime.MinimumWidth = 6;
            this.colCheckInTime.Name = "colCheckInTime";
            this.colCheckInTime.ReadOnly = true;
            this.colCheckInTime.Width = 125;
            // 
            // colCheckOutTime
            // 
            this.colCheckOutTime.DataPropertyName = "CheckOutTime";
            this.colCheckOutTime.HeaderText = "Checkout";
            this.colCheckOutTime.MinimumWidth = 6;
            this.colCheckOutTime.Name = "colCheckOutTime";
            this.colCheckOutTime.ReadOnly = true;
            this.colCheckOutTime.Width = 125;
            // 
            // cMnuApplication
            // 
            this.cMnuApplication.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMnuApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadStripMenuItem});
            this.cMnuApplication.Name = "cMnuApplication";
            this.cMnuApplication.Size = new System.Drawing.Size(145, 26);
            this.cMnuApplication.Opening += new System.ComponentModel.CancelEventHandler(this.cMnuApplication_Opening);
            // 
            // uploadStripMenuItem
            // 
            this.uploadStripMenuItem.Name = "uploadStripMenuItem";
            this.uploadStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.uploadStripMenuItem.Text = "Upload BBNT";
            this.uploadStripMenuItem.Click += new System.EventHandler(this.uploadStripMenuItem_Click);
            // 
            // dgvSale
            // 
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSaleId,
            this.colhUserName,
            this.colhBeerVietNum,
            this.colUnit,
            this.colGener,
            this.colCustomerName,
            this.colCustomerPhone,
            this.colGif7,
            this.colGif1,
            this.colGif2,
            this.colGif3,
            this.colGif4,
            this.colGif5,
            this.colGif6});
            this.dgvSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSale.Location = new System.Drawing.Point(0, 0);
            this.dgvSale.MultiSelect = false;
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.ReadOnly = true;
            this.dgvSale.RowHeadersVisible = false;
            this.dgvSale.RowHeadersWidth = 51;
            this.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSale.Size = new System.Drawing.Size(1008, 263);
            this.dgvSale.TabIndex = 0;
            this.dgvSale.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSale_CellContentDoubleClick);
            // 
            // colSaleId
            // 
            this.colSaleId.DataPropertyName = "SaleId";
            this.colSaleId.HeaderText = "";
            this.colSaleId.MinimumWidth = 6;
            this.colSaleId.Name = "colSaleId";
            this.colSaleId.ReadOnly = true;
            this.colSaleId.Visible = false;
            this.colSaleId.Width = 125;
            // 
            // colhUserName
            // 
            this.colhUserName.DataPropertyName = "UserName";
            this.colhUserName.HeaderText = "Mã nhân viên";
            this.colhUserName.MinimumWidth = 6;
            this.colhUserName.Name = "colhUserName";
            this.colhUserName.ReadOnly = true;
            this.colhUserName.Width = 125;
            // 
            // colhBeerVietNum
            // 
            this.colhBeerVietNum.DataPropertyName = "BeerVietNum";
            this.colhBeerVietNum.HeaderText = "Số lượng beer";
            this.colhBeerVietNum.MinimumWidth = 6;
            this.colhBeerVietNum.Name = "colhBeerVietNum";
            this.colhBeerVietNum.ReadOnly = true;
            this.colhBeerVietNum.Width = 125;
            // 
            // colUnit
            // 
            this.colUnit.DataPropertyName = "Unit";
            this.colUnit.HeaderText = "Loại thùng bia";
            this.colUnit.MinimumWidth = 6;
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Width = 125;
            // 
            // colGener
            // 
            this.colGener.DataPropertyName = "Gener";
            this.colGener.HeaderText = "Giới tính";
            this.colGener.MinimumWidth = 6;
            this.colGener.Name = "colGener";
            this.colGener.ReadOnly = true;
            this.colGener.Width = 125;
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "CustomerName";
            this.colCustomerName.HeaderText = "Tên khách hàng";
            this.colCustomerName.MinimumWidth = 6;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            this.colCustomerName.Width = 125;
            // 
            // colCustomerPhone
            // 
            this.colCustomerPhone.DataPropertyName = "CustomerPhone";
            this.colCustomerPhone.HeaderText = "Số điện thoại";
            this.colCustomerPhone.MinimumWidth = 6;
            this.colCustomerPhone.Name = "colCustomerPhone";
            this.colCustomerPhone.ReadOnly = true;
            this.colCustomerPhone.Width = 125;
            // 
            // colGif7
            // 
            this.colGif7.DataPropertyName = "Gif7";
            this.colGif7.HeaderText = "Lon bia";
            this.colGif7.MinimumWidth = 6;
            this.colGif7.Name = "colGif7";
            this.colGif7.ReadOnly = true;
            this.colGif7.Width = 125;
            // 
            // colGif1
            // 
            this.colGif1.DataPropertyName = "Gif1";
            this.colGif1.HeaderText = "Nón bảo hiểm";
            this.colGif1.MinimumWidth = 6;
            this.colGif1.Name = "colGif1";
            this.colGif1.ReadOnly = true;
            this.colGif1.Width = 125;
            // 
            // colGif2
            // 
            this.colGif2.DataPropertyName = "Gif2";
            this.colGif2.HeaderText = "Thùng đá 1.6l";
            this.colGif2.MinimumWidth = 6;
            this.colGif2.Name = "colGif2";
            this.colGif2.ReadOnly = true;
            this.colGif2.Width = 125;
            // 
            // colGif3
            // 
            this.colGif3.DataPropertyName = "Gif3";
            this.colGif3.HeaderText = "Ly thuỷ tinh";
            this.colGif3.MinimumWidth = 6;
            this.colGif3.Name = "colGif3";
            this.colGif3.ReadOnly = true;
            this.colGif3.Width = 125;
            // 
            // colGif4
            // 
            this.colGif4.DataPropertyName = "Gif4";
            this.colGif4.HeaderText = "Đồng hồ treo tường";
            this.colGif4.MinimumWidth = 6;
            this.colGif4.Name = "colGif4";
            this.colGif4.ReadOnly = true;
            this.colGif4.Width = 125;
            // 
            // colGif5
            // 
            this.colGif5.DataPropertyName = "Gif5";
            this.colGif5.HeaderText = "Áo mưa bia việt";
            this.colGif5.MinimumWidth = 6;
            this.colGif5.Name = "colGif5";
            this.colGif5.ReadOnly = true;
            this.colGif5.Width = 125;
            // 
            // colGif6
            // 
            this.colGif6.DataPropertyName = "Gif6";
            this.colGif6.HeaderText = "Thùng đá 9l";
            this.colGif6.MinimumWidth = 6;
            this.colGif6.Name = "colGif6";
            this.colGif6.ReadOnly = true;
            this.colGif6.Width = 125;
            // 
            // ucActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "ucActive";
            this.Size = new System.Drawing.Size(1008, 532);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).EndInit();
            this.cMnuApplication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvCheckIn;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DateTimePicker dtpViewDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip cMnuApplication;
        private System.Windows.Forms.ToolStripMenuItem uploadStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUniqueCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvinceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckOutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhBeerVietNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGener;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif6;
    }
}
