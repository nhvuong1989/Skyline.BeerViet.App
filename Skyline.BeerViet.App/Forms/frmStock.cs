using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Skyline.BeerViet.App
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private List<ProvinceModel> GetProvinces()
        {
            HttpHelper httpHelper = new HttpHelper();
            
            string url = UserConfigs.API_URL + $@"api/Stock/GetProvincesNotBelongStock?pRegion={UserConfigs.Region}";
            string result = httpHelper.GETRestService(url);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<List<ProvinceModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<ProvinceModel>>>(result);
                if (apiRespone != null)
                {
                    return apiRespone.Data;
                }
            }
            return null;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            List<ProvinceModel> provinces = GetProvinces();
            cboProvince.DataSource = provinces;

            cboProvince.ValueMember = "Id";
            cboProvince.DisplayMember = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StockModel stockModel = new StockModel
            {
                Id = 0,
                StockName = txtStockName.Text,
                ProvinceId = CodeHelper.ConvertToString(cboProvince.SelectedValue),
                ProvinceName = cboProvince.Text
            };
            HttpHelper httpHelper = new HttpHelper();
            string url = UserConfigs.API_URL + $@"api/Stock/CreateOrUpdateStock";
            string result = httpHelper.POSTRestService(url, stockModel);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<ReturnMessage> apiRespone = JsonConvert.DeserializeObject<ApiRespone<ReturnMessage>>(result);
                if (apiRespone != null)
                {
                    MessageBox.Show(apiRespone.Message);
                    if (apiRespone.Id > 0)
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
