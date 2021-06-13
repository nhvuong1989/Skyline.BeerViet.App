namespace Skyline.BeerViet.App
{
    partial class frmUsers
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
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblTeamNumber = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.nudNumberTeam = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTeamType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProvince
            // 
            this.lblProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(16, 11);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(325, 69);
            this.lblProvince.TabIndex = 0;
            this.lblProvince.Text = "";
            this.lblProvince.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamNumber
            // 
            this.lblTeamNumber.AutoSize = true;
            this.lblTeamNumber.Location = new System.Drawing.Point(48, 86);
            this.lblTeamNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamNumber.Name = "lblTeamNumber";
            this.lblTeamNumber.Size = new System.Drawing.Size(104, 17);
            this.lblTeamNumber.TabIndex = 1;
            this.lblTeamNumber.Text = "Số lượng Team";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(125, 157);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(100, 28);
            this.btnCreateUser.TabIndex = 3;
            this.btnCreateUser.Text = "Tạo User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // nudNumberTeam
            // 
            this.nudNumberTeam.Location = new System.Drawing.Point(169, 84);
            this.nudNumberTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudNumberTeam.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumberTeam.Name = "nudNumberTeam";
            this.nudNumberTeam.Size = new System.Drawing.Size(73, 22);
            this.nudNumberTeam.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loại User";
            // 
            // cboTeamType
            // 
            this.cboTeamType.FormattingEnabled = true;
            this.cboTeamType.Location = new System.Drawing.Point(169, 115);
            this.cboTeamType.Name = "cboTeamType";
            this.cboTeamType.Size = new System.Drawing.Size(73, 24);
            this.cboTeamType.TabIndex = 6;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 198);
            this.Controls.Add(this.cboTeamType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNumberTeam);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.lblTeamNumber);
            this.Controls.Add(this.lblProvince);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblTeamNumber;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.NumericUpDown nudNumberTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTeamType;
    }
}