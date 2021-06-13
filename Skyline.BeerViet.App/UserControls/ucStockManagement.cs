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
            string url = UserConfigs.API_URL + $@"api/Master/GetStocks";
            string result = httpHelper.GETRestService(url);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<List<StockModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<StockModel>>>(result);
                if (apiRespone != null)
                {
                    dgvStock.DataSource = apiRespone.Data;
                }
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            frmStock frm = new frmStock();
            frm.ShowDialog();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows == null || dgvStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn kho cần nhập hàng!");
                return;
            }

            int stockId = CodeHelper.ConvertToInt(dgvStock.SelectedRows[0].Cells[colStockId.Name].Value);

        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
