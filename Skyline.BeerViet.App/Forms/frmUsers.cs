using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Skyline.BeerViet.App
{
    public partial class frmUsers : Form
    {
        private int _provinceId;
        private string _provinceCode;

        public frmUsers()
        {
            InitializeComponent();
        }

        public frmUsers(int pProvinceId, string pProvinceCode, string pProvinceName)
            : this()
        {
            _provinceId = pProvinceId;
            _provinceCode = pProvinceCode;
            lblProvince.Text = $"Bạn đang thêm user cho tỉnh/thành phố {pProvinceName}";
        }

        protected override void OnLoad(EventArgs e)
        {

            List<MasterData> masters = new List<MasterData>()
            {
                new MasterData{ Id = "1", Name="Moblie"},
                new MasterData{ Id = "2", Name="Van"}
            };
            cboTeamType.ValueMember = "Id";
            cboTeamType.DisplayMember = "Name";
            cboTeamType.DataSource = masters;
            base.OnLoad(e);

        }

        private void btnCreateUser_Click(object sender, System.EventArgs e)
        {
            if (nudNumberTeam.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng team!");
                return;
            }
            int teamType = CodeHelper.ConvertToInt(cboTeamType.SelectedValue, 0);
            if (teamType == 0)
            {
                MessageBox.Show("Vui lòng chọn loại team!");
                return;
            }

            HttpHelper httpHelper = new HttpHelper();
            string url = UserConfigs.API_URL + @"api/User/CreateUserForProvince";
            CreateUserReq userModel = new CreateUserReq
            {
                ProvinceId = _provinceId,
                ProvinceCode = _provinceCode,
                Region = UserConfigs.Region,
                TeamNum = CodeHelper.ConvertToInt(nudNumberTeam.Value),
                TeamType = teamType
            };
            string request = JsonConvert.SerializeObject(userModel);
            string result = httpHelper.POSTRestService(url, request);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<ReturnMessage> apiRespone = JsonConvert.DeserializeObject<ApiRespone<ReturnMessage>>(result);
                if (apiRespone != null)
                {
                    MessageBox.Show(apiRespone.Message);
                }
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
