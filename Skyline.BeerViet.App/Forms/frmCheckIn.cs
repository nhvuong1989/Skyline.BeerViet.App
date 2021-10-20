using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace Skyline.BeerViet.App
{
    public partial class frmCheckIn : Form
    {
        private CheckInHistoryModel _checkInHistoryModel;
        public frmCheckIn()
        {
            InitializeComponent();
        }

        public frmCheckIn(CheckInHistoryModel checkInHistoryModel)
            : this()
        {
            _checkInHistoryModel = checkInHistoryModel;

        }

        protected override void OnLoad(EventArgs e)
        {
            txtFullName.Text = _checkInHistoryModel.FullName;
            txtShopName.Text = _checkInHistoryModel.ShopName;
            txtAddress.Text = _checkInHistoryModel.Address;
            base.OnLoad(e);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            HttpHelper httpHelper = new HttpHelper();
            string url = UserConfigs.API_URL + @"api/User/AddOrUpdateCheckIn";

            _checkInHistoryModel.FullName = txtFullName.Text;
            _checkInHistoryModel.ShopName = txtShopName.Text;
            _checkInHistoryModel.Address = txtAddress.Text;

            string result = httpHelper.POSTRestService(url, _checkInHistoryModel);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<ReturnMessage> apiRespone = JsonConvert.DeserializeObject<ApiRespone<ReturnMessage>>(result);
                if (apiRespone != null)
                {
                    MessageBox.Show(apiRespone.Message);
                    if (apiRespone.Id > 0)
                        this.Close();
                }
            }
        }
    }
}
