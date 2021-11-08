using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Skyline.BeerViet.App
{
    public partial class ucStockManagement : UserControl
    {
        public ucStockManagement()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            HttpHelper httpHelper = new HttpHelper();
            string url = UserConfigs.API_URL + $@"api/Stock/GetStocks?pRegion={UserConfigs.Region}";
            string result = httpHelper.GETRestService(url);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<List<StockModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<StockModel>>>(result);
                if (apiRespone != null)
                {
                    dgvStock.DataSource = apiRespone.Data;
                    dgvStock.AutoGenerateColumns = false;
                }
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            frmStock frm = new frmStock();
            frm.ShowDialog();

            HttpHelper httpHelper = new HttpHelper();
            string url = UserConfigs.API_URL + $@"api/Stock/GetStocks?pRegion={UserConfigs.Region}";
            string result = httpHelper.GETRestService(url);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<List<StockModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<StockModel>>>(result);
                if (apiRespone != null)
                {
                    dgvStock.DataSource = apiRespone.Data;
                    dgvStock.AutoGenerateColumns = false;
                }
            }
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows == null || dgvStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn kho cần nhập hàng!");
                return;
            }

            int stockId = CodeHelper.ConvertToInt(dgvStock.SelectedRows[0].Cells[colStockId.Name].Value);
            frmStockIn frm = new frmStockIn(stockId);
            frm.ShowDialog();

        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStock.SelectedRows == null || dgvStock.SelectedRows.Count == 0)
            {
                return;
            }

            int stockId = CodeHelper.ConvertToInt(dgvStock.SelectedRows[0].Cells[colStockId.Name].Value);
            HttpHelper httpHelper = new HttpHelper();
            string url = UserConfigs.API_URL + $@"api/Stock/GetStockIn?pStockId={stockId}";
            string result = httpHelper.GETRestService(url);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<List<StockInModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<StockInModel>>>(result);
                if (apiRespone != null)
                {
                    dgvStockIn.AutoGenerateColumns = false;
                    dgvStockIn.DataSource = apiRespone.Data;
                }
            }

            //ProvinceId
            StockModel selected = dgvStock.SelectedRows[0].DataBoundItem as StockModel;
            url = UserConfigs.API_URL + $@"api/Gif/GetGifByProvince?pProvinceId={selected.ProvinceId}";
            result = httpHelper.GETRestService(url);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<UseGifModel> apiRespone = JsonConvert.DeserializeObject<ApiRespone<UseGifModel>>(result);
                if (apiRespone != null)
                {
                    dgvSale.AutoGenerateColumns = false;
                    List<UseGifModel> list = new List<UseGifModel>();
                    list.Add(apiRespone.Data);

                    dgvSale.DataSource = list;
                }
            }
        }
    }
}
