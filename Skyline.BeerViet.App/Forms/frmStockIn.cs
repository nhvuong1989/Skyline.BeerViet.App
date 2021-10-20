using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyline.BeerViet.App
{
    public partial class frmStockIn : Form
    {
        private int _stockId;


        public frmStockIn()
        {
            InitializeComponent();
        }

        public frmStockIn(int pStockId)
            :this()
        {
            _stockId = pStockId;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            StockInModel stockModel = new StockInModel
            {
                StockId = _stockId,
                Gif1 = (int)nudGif1.Value,
                Gif2 = (int)nudGif2.Value,
                Gif3 = (int)nudGif3.Value,
                Gif4 = (int)nudGif4.Value,
                Gif5 = (int)nudGif5.Value,
                Gif6 = (int)nudGif6.Value,
                StockInDate = dtpDateInput.Value
            };
            HttpHelper httpHelper = new HttpHelper();
            string url = UserConfigs.API_URL + $@"api/Stock/StockIn";
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
