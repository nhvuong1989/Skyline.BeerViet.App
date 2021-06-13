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
            string url = UserConfigs.API_URL + $@"api/Master/GetProvincesNotBelongStock";
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
            (clbProvinces as ListBox).DataSource = provinces;

            (clbProvinces as ListBox).ValueMember = "Id";
            (clbProvinces as ListBox).DisplayMember = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<int> provinceIds = new List<int>();
            for (int i = 0; i < clbProvinces.CheckedItems.Count; i++)
            {
                var selected = clbProvinces.CheckedItems[i] as ProvinceModel;
                provinceIds.Add(CodeHelper.ConvertToInt(selected?.Id));
            }
            StockModel stockModel = new StockModel
            {
                Id = 0,
                StockName = txtStockName.Text,
                ProvinceIds = JsonConvert.SerializeObject(provinceIds)
            };
            HttpHelper httpHelper = new HttpHelper();
            string url = UserConfigs.API_URL + $@"api/Master/CreateOrUpdateStock";
            string result = httpHelper.POSTRestService(url, JsonConvert.SerializeObject(stockModel));
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<List<ProvinceModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<ProvinceModel>>>(result);
                if (apiRespone != null)
                {
                }
            }
        }
    }
}
