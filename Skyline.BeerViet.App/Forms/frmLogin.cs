using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Skyline.BeerViet.App
{
    public partial class frmLogin : Form
    {
        private bool _isSuccess = false;
        public bool IsSuccess { get { return _isSuccess; }  }
        public frmLogin()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            txtPassword.Text = "Skyline@123";
            cboRegion.ValueMember = "Id";
            cboRegion.DisplayMember = "Name";
            List<MasterData> data = new List<MasterData>()
            {
                new MasterData{ Id = "SOUTH", Name = "Miền Nam" },
                new MasterData{ Id = "CENTRAL", Name = "Miền Trung" },
                new MasterData{ Id = "NORTH", Name = "Miền Bắc" }
            };
            cboRegion.DataSource = data;
            base.OnLoad(e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string region = CodeHelper.ConvertToString(cboRegion.SelectedValue);
            if (string.IsNullOrEmpty(region))
            {
                MessageBox.Show("Vui lòng chọn Vùng!");
                return;
            }

            if ("Skyline@123" == txtPassword.Text)
            {
                _isSuccess = true;
                UserConfigs.Region = region;
                this.Close();
            }
            else
            { 
                MessageBox.Show("Mật khẩu không đúng!");
            }
        }
    }
}
