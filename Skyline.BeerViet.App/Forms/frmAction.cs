using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace Skyline.BeerViet.App
{
    public partial class frmAction : Form
    {
        private SaleHistoryModel _saleDetail;
        private string _userId;
        private int _teamId;
        private int _historyId;

        public frmAction()
        {
            InitializeComponent();
        }

        public frmAction(SaleHistoryModel saleHistory) : this()
        {
            _saleDetail = saleHistory;
        }

        public frmAction(string userId, int TeamId, int historyId) : this()
        {
            _userId = userId;
            _teamId = TeamId;
            _historyId = historyId;
        }

        protected override void OnLoad(EventArgs e)
        {
            if(_saleDetail!=null)
            {
                txtCustomer.Text = _saleDetail.CustomerName;
                txtPhoneNumber.Text = _saleDetail.CustomerPhone;
                txtGener.Text = _saleDetail.Gener;

                nudBeerVietNum.Value = _saleDetail.BeerVietNum;
                nudGif1.Value = _saleDetail.Gif1;
                nudGif2.Value = _saleDetail.Gif2;
                nudGif3.Value = _saleDetail.Gif3;
                nudGif4.Value = _saleDetail.Gif4;
                nudGif5.Value = _saleDetail.Gif5;
                nudGif6.Value = _saleDetail.Gif6;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nudBeerVietNum.Value !=
                (nudGif1.Value + nudGif2.Value + nudGif3.Value + nudGif4.Value + nudGif5.Value + nudGif6.Value))
            {
                MessageBox.Show("Số lượng thùng bia phải bằng tổng số phần quà!");
                return;
            }

            if (_saleDetail != null)
            {
                HttpHelper httpHelper = new HttpHelper();
                string url = UserConfigs.API_URL + @"api/Gif/UpdateActionGif";
                SaleHistoryModel saleHistory = new SaleHistoryModel
                {
                    SaleId = _saleDetail.SaleId,
                    CustomerName = txtCustomer.Text,
                    CustomerPhone = txtPhoneNumber.Text,
                    Gener = txtGener.Text,
                    UserName = "sys",
                    BeerVietNum = (int)nudBeerVietNum.Value,
                    Gif1 = (int)nudGif1.Value,
                    Gif2 = (int)nudGif2.Value,
                    Gif3 = (int)nudGif3.Value,
                    Gif4 = (int)nudGif4.Value,
                    Gif5 = (int)nudGif5.Value,
                    Gif6 = (int)nudGif6.Value
                };
                string request = JsonConvert.SerializeObject(saleHistory);
                string result = httpHelper.POSTRestService(url, request);
                if (!string.IsNullOrEmpty(result))
                {
                    ApiRespone<ReturnMessage> apiRespone = JsonConvert.DeserializeObject<ApiRespone<ReturnMessage>>(result);
                    if (apiRespone != null)
                    {
                        MessageBox.Show(apiRespone.Message);
                    }
                }
            }
            else
            {
                HttpHelper httpHelper = new HttpHelper();
                string url = UserConfigs.API_URL + @"api/Sale/AddAction";
                SaleHistoryModel saleHistory = new SaleHistoryModel
                {
                    CustomerName = txtCustomer.Text,
                    CustomerPhone = txtPhoneNumber.Text,
                    Gener = txtGener.Text,
                    UserName = _userId,
                    TeamId = _teamId,
                    HistoryId = _historyId,
                    BeerVietNum = (int)nudBeerVietNum.Value,
                    Gif1 = (int)nudGif1.Value,
                    Gif2 = (int)nudGif2.Value,
                    Gif3 = (int)nudGif3.Value,
                    Gif4 = (int)nudGif4.Value,
                    Gif5 = (int)nudGif5.Value,
                    Gif6 = (int)nudGif6.Value

                };
                string request = JsonConvert.SerializeObject(saleHistory);
                string result = httpHelper.POSTRestService(url, request);
                if (!string.IsNullOrEmpty(result))
                {
                    ApiRespone<ReturnMessage> apiRespone = JsonConvert.DeserializeObject<ApiRespone<ReturnMessage>>(result);
                    if (apiRespone != null)
                    {
                        MessageBox.Show(apiRespone.Message);
                    }
                }
            }
        }
    }
}
