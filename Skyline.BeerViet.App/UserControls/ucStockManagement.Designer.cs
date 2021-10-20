namespace Skyline.BeerViet.App
{
    partial class ucStockManagement
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colStockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvinces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStockIn = new System.Windows.Forms.DataGridView();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGif1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGif2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGif3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGif4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGif5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGif6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSale);
            this.splitContainer1.Size = new System.Drawing.Size(838, 594);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvStock);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvStockIn);
            this.splitContainer2.Size = new System.Drawing.Size(838, 355);
            this.splitContainer2.SplitterDistance = 170;
            this.splitContainer2.TabIndex = 1;
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStockId,
            this.colStockName,
            this.colProvinces});
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(0, 0);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(838, 170);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
            // 
            // colStockId
            // 
            this.colStockId.DataPropertyName = "Id";
            this.colStockId.HeaderText = "Stock Id";
            this.colStockId.MinimumWidth = 6;
            this.colStockId.Name = "colStockId";
            this.colStockId.Width = 125;
            // 
            // colStockName
            // 
            this.colStockName.DataPropertyName = "StockName";
            this.colStockName.HeaderText = "Stock Name";
            this.colStockName.MinimumWidth = 6;
            this.colStockName.Name = "colStockName";
            this.colStockName.Width = 125;
            // 
            // colProvinces
            // 
            this.colProvinces.DataPropertyName = "ProvinceName";
            this.colProvinces.HeaderText = "Tỉnh";
            this.colProvinces.MinimumWidth = 6;
            this.colProvinces.Name = "colProvinces";
            this.colProvinces.Width = 500;
            // 
            // dgvStockIn
            // 
            this.dgvStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvStockIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockIn.Location = new System.Drawing.Point(0, 0);
            this.dgvStockIn.MultiSelect = false;
            this.dgvStockIn.Name = "dgvStockIn";
            this.dgvStockIn.ReadOnly = true;
            this.dgvStockIn.RowHeadersVisible = false;
            this.dgvStockIn.RowHeadersWidth = 51;
            this.dgvStockIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockIn.Size = new System.Drawing.Size(838, 181);
            this.dgvStockIn.TabIndex = 2;
            // 
            // dgvSale
            // 
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvSale.RowHeadersWidth = 51;
            this.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSale.Size = new System.Drawing.Size(838, 235);
            this.dgvSale.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStockIn);
            this.panel1.Controls.Add(this.btnAddStock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 42);
            this.panel1.TabIndex = 5;
            // 
            // btnStockIn
            // 
            this.btnStockIn.Location = new System.Drawing.Point(84, 13);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(75, 23);
            this.btnStockIn.TabIndex = 3;
            this.btnStockIn.Text = "Nhập kho";
            this.btnStockIn.UseVisualStyleBackColor = true;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(3, 13);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(75, 23);
            this.btnAddStock.TabIndex = 2;
            this.btnAddStock.Text = "Thêm kho";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SaleId";
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StockInDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày Nhập";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gif1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nón bảo hiểm";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gif2";
            this.dataGridViewTextBoxColumn4.HeaderText = "Thùng đá 1.6l";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Gif3";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ly thuỷ tinh";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Gif4";
            this.dataGridViewTextBoxColumn6.HeaderText = "Đồng hồ treo tường";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Gif5";
            this.dataGridViewTextBoxColumn7.HeaderText = "Áo mưa bia việt";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Gif6";
            this.dataGridViewTextBoxColumn8.HeaderText = "Thùng đá 9l";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // colCustomerPhone
            // 
            this.colCustomerPhone.DataPropertyName = "ProvinceName";
            this.colCustomerPhone.HeaderText = "Tỉnh Thành";
            this.colCustomerPhone.MinimumWidth = 6;
            this.colCustomerPhone.Name = "colCustomerPhone";
            this.colCustomerPhone.ReadOnly = true;
            this.colCustomerPhone.Width = 125;
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
            // ucStockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucStockManagement";
            this.Size = new System.Drawing.Size(838, 636);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvStockIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvinces;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGif6;
    }
}
