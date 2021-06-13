﻿namespace Skyline.BeerViet.App
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.dtpViewDate = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvCheckIn = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvinceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.colSaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhBeerVietNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvCheckIn
            // 
            this.dgvCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colWorkType,
            this.colUserName,
            this.colFullName,
            this.colProvinceName,
            this.colShopName,
            this.colAddress,
            this.colTeamName,
            this.colCheckInTime,
            this.colCheckOutTime});
            this.dgvCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheckIn.Location = new System.Drawing.Point(0, 0);
            this.dgvCheckIn.MultiSelect = false;
            this.dgvCheckIn.Name = "dgvCheckIn";
            this.dgvCheckIn.ReadOnly = true;
            this.dgvCheckIn.RowHeadersVisible = false;
            this.dgvCheckIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckIn.Size = new System.Drawing.Size(1008, 224);
            this.dgvCheckIn.TabIndex = 0;
            this.dgvCheckIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckIn_CellContentClick);
            this.dgvCheckIn.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckIn_CellContentDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colWorkType
            // 
            this.colWorkType.DataPropertyName = "WorkType";
            this.colWorkType.HeaderText = "Loại hình";
            this.colWorkType.Name = "colWorkType";
            this.colWorkType.ReadOnly = true;
            // 
            // colUserName
            // 
            this.colUserName.DataPropertyName = "UserName";
            this.colUserName.HeaderText = "Nhân viên";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "Tên nhân viên";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colProvinceName
            // 
            this.colProvinceName.DataPropertyName = "ProvinceName";
            this.colProvinceName.HeaderText = "Tỉnh";
            this.colProvinceName.Name = "colProvinceName";
            this.colProvinceName.ReadOnly = true;
            // 
            // colShopName
            // 
            this.colShopName.DataPropertyName = "ShopName";
            this.colShopName.HeaderText = "Chợ";
            this.colShopName.Name = "colShopName";
            this.colShopName.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Địa chỉ";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colTeamName
            // 
            this.colTeamName.DataPropertyName = "TeamName";
            this.colTeamName.HeaderText = "Team";
            this.colTeamName.Name = "colTeamName";
            this.colTeamName.ReadOnly = true;
            // 
            // colCheckInTime
            // 
            this.colCheckInTime.DataPropertyName = "CheckInTime";
            this.colCheckInTime.HeaderText = "Thời gian checkin";
            this.colCheckInTime.Name = "colCheckInTime";
            this.colCheckInTime.ReadOnly = true;
            // 
            // colCheckOutTime
            // 
            this.colCheckOutTime.DataPropertyName = "CheckOutTime";
            this.colCheckOutTime.HeaderText = "Thời gian checkout";
            this.colCheckOutTime.Name = "colCheckOutTime";
            this.colCheckOutTime.ReadOnly = true;
            // 
            // dgvSale
            // 
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSaleId,
            this.colhUserName,
            this.colhBeerVietNum,
            this.colGener,
            this.colCustomerName,
            this.colCustomerPhone,
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
            this.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSale.Size = new System.Drawing.Size(1008, 262);
            this.dgvSale.TabIndex = 0;
            this.dgvSale.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSale_CellContentDoubleClick);
            // 
            // colSaleId
            // 
            this.colSaleId.DataPropertyName = "SaleId";
            this.colSaleId.HeaderText = "";
            this.colSaleId.Name = "colSaleId";
            this.colSaleId.ReadOnly = true;
            this.colSaleId.Visible = false;
            // 
            // colhUserName
            // 
            this.colhUserName.DataPropertyName = "UserName";
            this.colhUserName.HeaderText = "Mã nhân viên";
            this.colhUserName.Name = "colhUserName";
            this.colhUserName.ReadOnly = true;
            // 
            // colhBeerVietNum
            // 
            this.colhBeerVietNum.DataPropertyName = "BeerVietNum";
            this.colhBeerVietNum.HeaderText = "Số lượng beer";
            this.colhBeerVietNum.Name = "colhBeerVietNum";
            this.colhBeerVietNum.ReadOnly = true;
            // 
            // colGener
            // 
            this.colGener.DataPropertyName = "Gener";
            this.colGener.HeaderText = "Giới tính";
            this.colGener.Name = "colGener";
            this.colGener.ReadOnly = true;
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "CustomerName";
            this.colCustomerName.HeaderText = "Tên khách hàng";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colCustomerPhone
            // 
            this.colCustomerPhone.DataPropertyName = "CustomerPhone";
            this.colCustomerPhone.HeaderText = "Số điện thoại";
            this.colCustomerPhone.Name = "colCustomerPhone";
            this.colCustomerPhone.ReadOnly = true;
            // 
            // colGif1
            // 
            this.colGif1.DataPropertyName = "Gif1";
            this.colGif1.HeaderText = "Nón bảo hiểm";
            this.colGif1.Name = "colGif1";
            this.colGif1.ReadOnly = true;
            // 
            // colGif2
            // 
            this.colGif2.DataPropertyName = "Gif2";
            this.colGif2.HeaderText = "Thùng đá 1.6l";
            this.colGif2.Name = "colGif2";
            this.colGif2.ReadOnly = true;
            // 
            // colGif3
            // 
            this.colGif3.DataPropertyName = "Gif3";
            this.colGif3.HeaderText = "Ly thuỷ tinh";
            this.colGif3.Name = "colGif3";
            this.colGif3.ReadOnly = true;
            // 
            // colGif4
            // 
            this.colGif4.DataPropertyName = "Gif4";
            this.colGif4.HeaderText = "Đồng hồ treo tường";
            this.colGif4.Name = "colGif4";
            this.colGif4.ReadOnly = true;
            // 
            // colGif5
            // 
            this.colGif5.DataPropertyName = "Gif5";
            this.colGif5.HeaderText = "Áo mưa bia việt";
            this.colGif5.Name = "colGif5";
            this.colGif5.ReadOnly = true;
            // 
            // colGif6
            // 
            this.colGif6.DataPropertyName = "Gif6";
            this.colGif6.HeaderText = "Thùng đá 9l";
            this.colGif6.Name = "colGif6";
            this.colGif6.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvCheckIn;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvinceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckOutTime;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DateTimePicker dtpViewDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhBeerVietNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGener;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif6;
        private System.Windows.Forms.Button btnAdd;
    }
}