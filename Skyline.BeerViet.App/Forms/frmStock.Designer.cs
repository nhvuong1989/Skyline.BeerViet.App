namespace Skyline.BeerViet.App
{
    partial class frmStock
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
            this.lblStockName = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.lblProvinces = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblStockName
            // 
            this.lblStockName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblStockName.Location = new System.Drawing.Point(12, 67);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(136, 25);
            this.lblStockName.TabIndex = 0;
            this.lblStockName.Text = "Tên kho";
            this.lblStockName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(154, 68);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(329, 22);
            this.txtStockName.TabIndex = 1;
            // 
            // lblProvinces
            // 
            this.lblProvinces.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblProvinces.Location = new System.Drawing.Point(12, 110);
            this.lblProvinces.Name = "lblProvinces";
            this.lblProvinces.Size = new System.Drawing.Size(136, 25);
            this.lblProvinces.TabIndex = 3;
            this.lblProvinces.Text = "Danh sách tỉnh";
            this.lblProvinces.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(222, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboProvince
            // 
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Location = new System.Drawing.Point(154, 110);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(329, 24);
            this.cboProvince.TabIndex = 5;
            // 
            // frmStock
            // 
            this.ClientSize = new System.Drawing.Size(500, 184);
            this.Controls.Add(this.cboProvince);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblProvinces);
            this.Controls.Add(this.txtStockName);
            this.Controls.Add(this.lblStockName);
            this.Name = "frmStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.Label lblProvinces;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboProvince;
    }
}