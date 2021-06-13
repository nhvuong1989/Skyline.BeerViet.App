namespace Skyline.BeerViet.App
{
    partial class ucProvince
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
            this.splProvince = new System.Windows.Forms.SplitContainer();
            this.dgvProvince = new System.Windows.Forms.DataGridView();
            this.colsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpId = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colsProvinceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmtProvince = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmPActive = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPDeactive = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splDetail = new System.Windows.Forms.SplitContainer();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.ColUIsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.coluShiftWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmtUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmUActive = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUDeactive = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvOutLet = new System.Windows.Forms.DataGridView();
            this.cmtOutlet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmActive = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDesctive = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportData = new System.Windows.Forms.Button();
            this.btnImportOutLet = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.colsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colOutletId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkShopAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colwIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDateActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splProvince)).BeginInit();
            this.splProvince.Panel1.SuspendLayout();
            this.splProvince.Panel2.SuspendLayout();
            this.splProvince.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvince)).BeginInit();
            this.cmtProvince.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splDetail)).BeginInit();
            this.splDetail.Panel1.SuspendLayout();
            this.splDetail.Panel2.SuspendLayout();
            this.splDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmtUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutLet)).BeginInit();
            this.cmtOutlet.SuspendLayout();
            this.SuspendLayout();
            // 
            // splProvince
            // 
            this.splProvince.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splProvince.Location = new System.Drawing.Point(0, 0);
            this.splProvince.Name = "splProvince";
            this.splProvince.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splProvince.Panel1
            // 
            this.splProvince.Panel1.Controls.Add(this.dgvProvince);
            // 
            // splProvince.Panel2
            // 
            this.splProvince.Panel2.Controls.Add(this.splitContainer1);
            this.splProvince.Size = new System.Drawing.Size(1081, 607);
            this.splProvince.SplitterDistance = 278;
            this.splProvince.TabIndex = 0;
            // 
            // dgvProvince
            // 
            this.dgvProvince.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvince.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colsId,
            this.colpId,
            this.colsProvinceName,
            this.colsIsActive});
            this.dgvProvince.ContextMenuStrip = this.cmtProvince;
            this.dgvProvince.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProvince.Location = new System.Drawing.Point(0, 0);
            this.dgvProvince.Name = "dgvProvince";
            this.dgvProvince.RowHeadersVisible = false;
            this.dgvProvince.RowHeadersWidth = 51;
            this.dgvProvince.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvince.Size = new System.Drawing.Size(1081, 278);
            this.dgvProvince.TabIndex = 0;
            this.dgvProvince.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProvince_CellDoubleClick);
            this.dgvProvince.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvProvince_CurrentCellDirtyStateChanged);
            // 
            // colsId
            // 
            this.colsId.DataPropertyName = "Id";
            this.colsId.HeaderText = "Id";
            this.colsId.MinimumWidth = 6;
            this.colsId.Name = "colsId";
            this.colsId.Visible = false;
            this.colsId.Width = 125;
            // 
            // colpId
            // 
            this.colpId.DataPropertyName = "IsChecked";
            this.colpId.HeaderText = "";
            this.colpId.MinimumWidth = 6;
            this.colpId.Name = "colpId";
            this.colpId.Width = 30;
            // 
            // colsProvinceName
            // 
            this.colsProvinceName.DataPropertyName = "Name";
            this.colsProvinceName.HeaderText = "Tỉnh/TP";
            this.colsProvinceName.MinimumWidth = 6;
            this.colsProvinceName.Name = "colsProvinceName";
            this.colsProvinceName.Width = 300;
            // 
            // colsIsActive
            // 
            this.colsIsActive.DataPropertyName = "IsActive";
            this.colsIsActive.HeaderText = "Hoạt Động";
            this.colsIsActive.MinimumWidth = 6;
            this.colsIsActive.Name = "colsIsActive";
            this.colsIsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colsIsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colsIsActive.Width = 125;
            // 
            // cmtProvince
            // 
            this.cmtProvince.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmtProvince.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPActive,
            this.tsmPDeactive});
            this.cmtProvince.Name = "cmtOutlet";
            this.cmtProvince.Size = new System.Drawing.Size(120, 48);
            // 
            // tsmPActive
            // 
            this.tsmPActive.Name = "tsmPActive";
            this.tsmPActive.Size = new System.Drawing.Size(119, 22);
            this.tsmPActive.Text = "Active";
            this.tsmPActive.Click += new System.EventHandler(this.tsmPActive_Click);
            // 
            // tsmPDeactive
            // 
            this.tsmPDeactive.Name = "tsmPDeactive";
            this.tsmPDeactive.Size = new System.Drawing.Size(119, 22);
            this.tsmPDeactive.Text = "Deactive";
            this.tsmPDeactive.Click += new System.EventHandler(this.tsmPDeactive_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splDetail);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnExportData);
            this.splitContainer1.Panel2.Controls.Add(this.btnImportOutLet);
            this.splitContainer1.Panel2.Controls.Add(this.btnCreateUser);
            this.splitContainer1.Size = new System.Drawing.Size(1081, 325);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 2;
            // 
            // splDetail
            // 
            this.splDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splDetail.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splDetail.Location = new System.Drawing.Point(0, 0);
            this.splDetail.Name = "splDetail";
            // 
            // splDetail.Panel1
            // 
            this.splDetail.Panel1.Controls.Add(this.dgvUsers);
            // 
            // splDetail.Panel2
            // 
            this.splDetail.Panel2.Controls.Add(this.dgvOutLet);
            this.splDetail.Size = new System.Drawing.Size(1081, 264);
            this.splDetail.SplitterDistance = 469;
            this.splDetail.TabIndex = 1;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColUIsChecked,
            this.colUsername,
            this.colPassWord,
            this.colUIsActive,
            this.coluShiftWork});
            this.dgvUsers.ContextMenuStrip = this.cmtUser;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(469, 264);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvUsers_CurrentCellDirtyStateChanged);
            // 
            // ColUIsChecked
            // 
            this.ColUIsChecked.DataPropertyName = "IsChecked";
            this.ColUIsChecked.HeaderText = "";
            this.ColUIsChecked.MinimumWidth = 6;
            this.ColUIsChecked.Name = "ColUIsChecked";
            this.ColUIsChecked.Width = 35;
            // 
            // colUsername
            // 
            this.colUsername.DataPropertyName = "UserName";
            this.colUsername.HeaderText = "UserName";
            this.colUsername.MinimumWidth = 6;
            this.colUsername.Name = "colUsername";
            this.colUsername.Width = 125;
            // 
            // colPassWord
            // 
            this.colPassWord.DataPropertyName = "PassWord";
            this.colPassWord.HeaderText = "Mật khẩu";
            this.colPassWord.MinimumWidth = 6;
            this.colPassWord.Name = "colPassWord";
            this.colPassWord.Width = 125;
            // 
            // colUIsActive
            // 
            this.colUIsActive.DataPropertyName = "IsActive";
            this.colUIsActive.HeaderText = "Hoạt động";
            this.colUIsActive.MinimumWidth = 6;
            this.colUIsActive.Name = "colUIsActive";
            this.colUIsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUIsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colUIsActive.Width = 125;
            // 
            // coluShiftWork
            // 
            this.coluShiftWork.DataPropertyName = "ShiftWork";
            this.coluShiftWork.HeaderText = "Ca làm việc";
            this.coluShiftWork.MinimumWidth = 6;
            this.coluShiftWork.Name = "coluShiftWork";
            this.coluShiftWork.Width = 125;
            // 
            // cmtUser
            // 
            this.cmtUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmtUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUActive,
            this.tsmUDeactive});
            this.cmtUser.Name = "cmtOutlet";
            this.cmtUser.Size = new System.Drawing.Size(120, 48);
            // 
            // tsmUActive
            // 
            this.tsmUActive.Name = "tsmUActive";
            this.tsmUActive.Size = new System.Drawing.Size(119, 22);
            this.tsmUActive.Text = "Active";
            this.tsmUActive.Click += new System.EventHandler(this.tsmUActive_Click);
            // 
            // tsmUDeactive
            // 
            this.tsmUDeactive.Name = "tsmUDeactive";
            this.tsmUDeactive.Size = new System.Drawing.Size(119, 22);
            this.tsmUDeactive.Text = "Deactive";
            this.tsmUDeactive.Click += new System.EventHandler(this.tsmUDeactive_Click);
            // 
            // dgvOutLet
            // 
            this.dgvOutLet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutLet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colsSelected,
            this.colOutletId,
            this.colWorkShopName,
            this.colWorkShopAddress,
            this.colResultText,
            this.colwIsActive,
            this.colDateActive});
            this.dgvOutLet.ContextMenuStrip = this.cmtOutlet;
            this.dgvOutLet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOutLet.Location = new System.Drawing.Point(0, 0);
            this.dgvOutLet.Name = "dgvOutLet";
            this.dgvOutLet.RowHeadersVisible = false;
            this.dgvOutLet.RowHeadersWidth = 51;
            this.dgvOutLet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutLet.Size = new System.Drawing.Size(608, 264);
            this.dgvOutLet.TabIndex = 0;
            // 
            // cmtOutlet
            // 
            this.cmtOutlet.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmtOutlet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmActive,
            this.tsmDesctive});
            this.cmtOutlet.Name = "cmtOutlet";
            this.cmtOutlet.Size = new System.Drawing.Size(120, 48);
            // 
            // tsmActive
            // 
            this.tsmActive.Name = "tsmActive";
            this.tsmActive.Size = new System.Drawing.Size(119, 22);
            this.tsmActive.Text = "Active";
            this.tsmActive.Click += new System.EventHandler(this.tsmActive_Click);
            // 
            // tsmDesctive
            // 
            this.tsmDesctive.Name = "tsmDesctive";
            this.tsmDesctive.Size = new System.Drawing.Size(119, 22);
            this.tsmDesctive.Text = "Deactive";
            this.tsmDesctive.Click += new System.EventHandler(this.tsmDesctive_Click);
            // 
            // btnExportData
            // 
            this.btnExportData.Location = new System.Drawing.Point(181, 3);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(75, 23);
            this.btnExportData.TabIndex = 2;
            this.btnExportData.Text = "Export data";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // btnImportOutLet
            // 
            this.btnImportOutLet.Location = new System.Drawing.Point(93, 4);
            this.btnImportOutLet.Name = "btnImportOutLet";
            this.btnImportOutLet.Size = new System.Drawing.Size(75, 23);
            this.btnImportOutLet.TabIndex = 1;
            this.btnImportOutLet.Text = "Import Outlet";
            this.btnImportOutLet.UseVisualStyleBackColor = true;
            this.btnImportOutLet.Click += new System.EventHandler(this.btnImportOutLet_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(3, 3);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(75, 23);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Tạo User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // ofdExcel
            // 
            this.ofdExcel.FileName = "openFileDialog1";
            this.ofdExcel.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            // 
            // colsSelected
            // 
            this.colsSelected.DataPropertyName = "IsChecked";
            this.colsSelected.HeaderText = "";
            this.colsSelected.MinimumWidth = 6;
            this.colsSelected.Name = "colsSelected";
            this.colsSelected.Width = 30;
            // 
            // colOutletId
            // 
            this.colOutletId.DataPropertyName = "Id";
            this.colOutletId.HeaderText = "colOutletId";
            this.colOutletId.MinimumWidth = 6;
            this.colOutletId.Name = "colOutletId";
            this.colOutletId.Visible = false;
            this.colOutletId.Width = 125;
            // 
            // colWorkShopName
            // 
            this.colWorkShopName.DataPropertyName = "WorkShopName";
            this.colWorkShopName.HeaderText = "Tên Outlet";
            this.colWorkShopName.MinimumWidth = 6;
            this.colWorkShopName.Name = "colWorkShopName";
            this.colWorkShopName.Width = 150;
            // 
            // colWorkShopAddress
            // 
            this.colWorkShopAddress.DataPropertyName = "WorkShopAddress";
            this.colWorkShopAddress.HeaderText = "Địa chỉ";
            this.colWorkShopAddress.MinimumWidth = 6;
            this.colWorkShopAddress.Name = "colWorkShopAddress";
            this.colWorkShopAddress.Width = 250;
            // 
            // colResultText
            // 
            this.colResultText.DataPropertyName = "ResultText";
            this.colResultText.HeaderText = "Ca làm việc";
            this.colResultText.MinimumWidth = 6;
            this.colResultText.Name = "colResultText";
            this.colResultText.Width = 125;
            // 
            // colwIsActive
            // 
            this.colwIsActive.DataPropertyName = "IsActive";
            this.colwIsActive.HeaderText = "Hoạt động";
            this.colwIsActive.MinimumWidth = 6;
            this.colwIsActive.Name = "colwIsActive";
            this.colwIsActive.Width = 125;
            // 
            // colDateActive
            // 
            this.colDateActive.DataPropertyName = "ExecuteDate";
            this.colDateActive.HeaderText = "Ngày hoạt động";
            this.colDateActive.Name = "colDateActive";
            // 
            // ucProvince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splProvince);
            this.Name = "ucProvince";
            this.Size = new System.Drawing.Size(1081, 607);
            this.splProvince.Panel1.ResumeLayout(false);
            this.splProvince.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splProvince)).EndInit();
            this.splProvince.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvince)).EndInit();
            this.cmtProvince.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splDetail.Panel1.ResumeLayout(false);
            this.splDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splDetail)).EndInit();
            this.splDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmtUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutLet)).EndInit();
            this.cmtOutlet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splProvince;
        private System.Windows.Forms.DataGridView dgvProvince;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.SplitContainer splDetail;
        private System.Windows.Forms.DataGridView dgvOutLet;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnImportOutLet;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.Windows.Forms.ContextMenuStrip cmtOutlet;
        private System.Windows.Forms.ToolStripMenuItem tsmActive;
        private System.Windows.Forms.ToolStripMenuItem tsmDesctive;
        private System.Windows.Forms.ContextMenuStrip cmtProvince;
        private System.Windows.Forms.ToolStripMenuItem tsmPActive;
        private System.Windows.Forms.ToolStripMenuItem tsmPDeactive;
        private System.Windows.Forms.ContextMenuStrip cmtUser;
        private System.Windows.Forms.ToolStripMenuItem tsmUActive;
        private System.Windows.Forms.ToolStripMenuItem tsmUDeactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsProvinceName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colsIsActive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColUIsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassWord;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluShiftWork;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutletId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkShopAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultText;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colwIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateActive;
    }
}
