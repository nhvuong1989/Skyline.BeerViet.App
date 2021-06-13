namespace Skyline.BeerViet.App
{
    partial class ucStock
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
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvTeam = new System.Windows.Forms.DataGridView();
            this.colTeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamTyep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtActionNumber = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lbliGif1 = new System.Windows.Forms.Label();
            this.lbliGif2 = new System.Windows.Forms.Label();
            this.lbliGif3 = new System.Windows.Forms.Label();
            this.lbliGif4 = new System.Windows.Forms.Label();
            this.lbliGif5 = new System.Windows.Forms.Label();
            this.lbliGif6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblsGif1 = new System.Windows.Forms.Label();
            this.lblsGif2 = new System.Windows.Forms.Label();
            this.lblsGif3 = new System.Windows.Forms.Label();
            this.lblsGif4 = new System.Windows.Forms.Label();
            this.lblsGif5 = new System.Windows.Forms.Label();
            this.lblsGif6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGif1 = new System.Windows.Forms.Label();
            this.lblGif2 = new System.Windows.Forms.Label();
            this.lblGif3 = new System.Windows.Forms.Label();
            this.lblGif4 = new System.Windows.Forms.Label();
            this.lblGif5 = new System.Windows.Forms.Label();
            this.lblGif6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboProvince);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 42);
            this.panel1.TabIndex = 3;
            // 
            // cboProvince
            // 
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Location = new System.Drawing.Point(6, 15);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(121, 21);
            this.cboProvince.TabIndex = 2;
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvTeam);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtEnd);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txtStart);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.txtActionNumber);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(820, 562);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvTeam
            // 
            this.dgvTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTeamId,
            this.colTeamName,
            this.colTeamTyep});
            this.dgvTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeam.Location = new System.Drawing.Point(0, 0);
            this.dgvTeam.MultiSelect = false;
            this.dgvTeam.Name = "dgvTeam";
            this.dgvTeam.RowHeadersVisible = false;
            this.dgvTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeam.Size = new System.Drawing.Size(224, 562);
            this.dgvTeam.TabIndex = 0;
            this.dgvTeam.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeam_CellDoubleClick);
            // 
            // colTeamId
            // 
            this.colTeamId.DataPropertyName = "TeamId";
            this.colTeamId.HeaderText = "Team Id";
            this.colTeamId.Name = "colTeamId";
            // 
            // colTeamName
            // 
            this.colTeamName.DataPropertyName = "TeamName";
            this.colTeamName.HeaderText = "Team Name";
            this.colTeamName.Name = "colTeamName";
            // 
            // colTeamTyep
            // 
            this.colTeamTyep.DataPropertyName = "TeamType";
            this.colTeamTyep.HeaderText = "TeamType";
            this.colTeamTyep.Name = "colTeamTyep";
            this.colTeamTyep.Visible = false;
            // 
            // txtActionNumber
            // 
            this.txtActionNumber.Location = new System.Drawing.Point(139, 11);
            this.txtActionNumber.Name = "txtActionNumber";
            this.txtActionNumber.ReadOnly = true;
            this.txtActionNumber.Size = new System.Drawing.Size(64, 20);
            this.txtActionNumber.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(3, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 166);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Số lượng quà còn lại";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label26, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label27, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label28, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label29, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label30, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label31, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lbliGif1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbliGif2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbliGif3, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbliGif4, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbliGif5, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbliGif6, 1, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(580, 147);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Location = new System.Drawing.Point(3, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(284, 25);
            this.label26.TabIndex = 0;
            this.label26.Text = "Nón bảo hiểm";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Location = new System.Drawing.Point(3, 25);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(284, 25);
            this.label27.TabIndex = 1;
            this.label27.Text = "Thùng đá 1.6l";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Location = new System.Drawing.Point(3, 50);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(284, 25);
            this.label28.TabIndex = 2;
            this.label28.Text = "Ly thuỷ tinh";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Location = new System.Drawing.Point(3, 75);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(284, 25);
            this.label29.TabIndex = 3;
            this.label29.Text = "Đồng hồ treo tường";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Location = new System.Drawing.Point(3, 100);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(284, 25);
            this.label30.TabIndex = 4;
            this.label30.Text = "Áo mưa bia việt";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Location = new System.Drawing.Point(3, 125);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(284, 25);
            this.label31.TabIndex = 5;
            this.label31.Text = "Thùng đá 9l";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbliGif1
            // 
            this.lbliGif1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbliGif1.Location = new System.Drawing.Point(293, 0);
            this.lbliGif1.Name = "lbliGif1";
            this.lbliGif1.Size = new System.Drawing.Size(284, 25);
            this.lbliGif1.TabIndex = 6;
            this.lbliGif1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbliGif2
            // 
            this.lbliGif2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbliGif2.Location = new System.Drawing.Point(293, 25);
            this.lbliGif2.Name = "lbliGif2";
            this.lbliGif2.Size = new System.Drawing.Size(284, 25);
            this.lbliGif2.TabIndex = 7;
            this.lbliGif2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbliGif3
            // 
            this.lbliGif3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbliGif3.Location = new System.Drawing.Point(293, 50);
            this.lbliGif3.Name = "lbliGif3";
            this.lbliGif3.Size = new System.Drawing.Size(284, 25);
            this.lbliGif3.TabIndex = 8;
            this.lbliGif3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbliGif4
            // 
            this.lbliGif4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbliGif4.Location = new System.Drawing.Point(293, 75);
            this.lbliGif4.Name = "lbliGif4";
            this.lbliGif4.Size = new System.Drawing.Size(284, 25);
            this.lbliGif4.TabIndex = 9;
            this.lbliGif4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbliGif5
            // 
            this.lbliGif5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbliGif5.Location = new System.Drawing.Point(293, 100);
            this.lbliGif5.Name = "lbliGif5";
            this.lbliGif5.Size = new System.Drawing.Size(284, 25);
            this.lbliGif5.TabIndex = 10;
            this.lbliGif5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbliGif6
            // 
            this.lbliGif6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbliGif6.Location = new System.Drawing.Point(293, 125);
            this.lbliGif6.Name = "lbliGif6";
            this.lbliGif6.Size = new System.Drawing.Size(284, 25);
            this.lbliGif6.TabIndex = 11;
            this.lbliGif6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(299, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 166);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số lượng quà đã trao";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblsGif1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblsGif2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblsGif3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblsGif4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblsGif5, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblsGif6, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 147);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nón bảo hiểm";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "Thùng đá 1.6l";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Ly thuỷ tinh";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 25);
            this.label17.TabIndex = 3;
            this.label17.Text = "Đồng hồ treo tường";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(3, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 25);
            this.label18.TabIndex = 4;
            this.label18.Text = "Áo mưa bia việt";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(3, 125);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(136, 25);
            this.label19.TabIndex = 5;
            this.label19.Text = "Thùng đá 9l";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblsGif1
            // 
            this.lblsGif1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblsGif1.Location = new System.Drawing.Point(145, 0);
            this.lblsGif1.Name = "lblsGif1";
            this.lblsGif1.Size = new System.Drawing.Size(136, 25);
            this.lblsGif1.TabIndex = 6;
            this.lblsGif1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsGif2
            // 
            this.lblsGif2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblsGif2.Location = new System.Drawing.Point(145, 25);
            this.lblsGif2.Name = "lblsGif2";
            this.lblsGif2.Size = new System.Drawing.Size(136, 25);
            this.lblsGif2.TabIndex = 7;
            this.lblsGif2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsGif3
            // 
            this.lblsGif3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblsGif3.Location = new System.Drawing.Point(145, 50);
            this.lblsGif3.Name = "lblsGif3";
            this.lblsGif3.Size = new System.Drawing.Size(136, 25);
            this.lblsGif3.TabIndex = 8;
            this.lblsGif3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsGif4
            // 
            this.lblsGif4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblsGif4.Location = new System.Drawing.Point(145, 75);
            this.lblsGif4.Name = "lblsGif4";
            this.lblsGif4.Size = new System.Drawing.Size(136, 25);
            this.lblsGif4.TabIndex = 9;
            this.lblsGif4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsGif5
            // 
            this.lblsGif5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblsGif5.Location = new System.Drawing.Point(145, 100);
            this.lblsGif5.Name = "lblsGif5";
            this.lblsGif5.Size = new System.Drawing.Size(136, 25);
            this.lblsGif5.TabIndex = 10;
            this.lblsGif5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsGif6
            // 
            this.lblsGif6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblsGif6.Location = new System.Drawing.Point(145, 125);
            this.lblsGif6.Name = "lblsGif6";
            this.lblsGif6.Size = new System.Drawing.Size(136, 25);
            this.lblsGif6.TabIndex = 11;
            this.lblsGif6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số lượng quà theo kế hoạch";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblGif1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGif2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGif3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGif4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGif5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGif6, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 147);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nón bảo hiểm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thùng đá 1.6l";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ly thuỷ tinh";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đồng hồ treo tường";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Áo mưa bia việt";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Thùng đá 9l";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGif1
            // 
            this.lblGif1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGif1.Location = new System.Drawing.Point(145, 0);
            this.lblGif1.Name = "lblGif1";
            this.lblGif1.Size = new System.Drawing.Size(136, 25);
            this.lblGif1.TabIndex = 6;
            this.lblGif1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGif2
            // 
            this.lblGif2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGif2.Location = new System.Drawing.Point(145, 25);
            this.lblGif2.Name = "lblGif2";
            this.lblGif2.Size = new System.Drawing.Size(136, 25);
            this.lblGif2.TabIndex = 7;
            this.lblGif2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGif3
            // 
            this.lblGif3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGif3.Location = new System.Drawing.Point(145, 50);
            this.lblGif3.Name = "lblGif3";
            this.lblGif3.Size = new System.Drawing.Size(136, 25);
            this.lblGif3.TabIndex = 8;
            this.lblGif3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGif4
            // 
            this.lblGif4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGif4.Location = new System.Drawing.Point(145, 75);
            this.lblGif4.Name = "lblGif4";
            this.lblGif4.Size = new System.Drawing.Size(136, 25);
            this.lblGif4.TabIndex = 9;
            this.lblGif4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGif5
            // 
            this.lblGif5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGif5.Location = new System.Drawing.Point(145, 100);
            this.lblGif5.Name = "lblGif5";
            this.lblGif5.Size = new System.Drawing.Size(136, 25);
            this.lblGif5.TabIndex = 10;
            this.lblGif5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGif6
            // 
            this.lblGif6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGif6.Location = new System.Drawing.Point(145, 125);
            this.lblGif6.Name = "lblGif6";
            this.lblGif6.Size = new System.Drawing.Size(136, 25);
            this.lblGif6.TabIndex = 11;
            this.lblGif6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng outet đã chạy";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(297, 11);
            this.txtStart.Name = "txtStart";
            this.txtStart.ReadOnly = true;
            this.txtStart.Size = new System.Drawing.Size(101, 20);
            this.txtStart.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ngày bắt đầu";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(464, 14);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.ReadOnly = true;
            this.txtEnd.Size = new System.Drawing.Size(101, 20);
            this.txtEnd.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ngày cuối";
            // 
            // ucStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "ucStock";
            this.Size = new System.Drawing.Size(820, 604);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvTeam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGif1;
        private System.Windows.Forms.Label lblGif2;
        private System.Windows.Forms.Label lblGif3;
        private System.Windows.Forms.Label lblGif4;
        private System.Windows.Forms.Label lblGif5;
        private System.Windows.Forms.Label lblGif6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lbliGif1;
        private System.Windows.Forms.Label lbliGif2;
        private System.Windows.Forms.Label lbliGif3;
        private System.Windows.Forms.Label lbliGif4;
        private System.Windows.Forms.Label lbliGif5;
        private System.Windows.Forms.Label lbliGif6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblsGif1;
        private System.Windows.Forms.Label lblsGif2;
        private System.Windows.Forms.Label lblsGif3;
        private System.Windows.Forms.Label lblsGif4;
        private System.Windows.Forms.Label lblsGif5;
        private System.Windows.Forms.Label lblsGif6;
        private System.Windows.Forms.TextBox txtActionNumber;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamTyep;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label8;
    }
}
