using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Skyline.BeerViet.App
{
    public partial class ucStock : UserControl
    {
        public ucStock()
        {
            InitializeComponent();
        }

        internal void SetDataBinding()
        {
            HttpHelper httpHelper = new HttpHelper();
            string url = UserConfigs.API_URL + $@"api/Master/GetProvincesByRegion?pRegion={UserConfigs.Region}";
            string result = httpHelper.GETRestService(url);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<List<ProvinceModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<ProvinceModel>>>(result);
                if (apiRespone != null)
                {
                    cboProvince.ValueMember = "Id";
                    cboProvince.DisplayMember = "Name";
                    cboProvince.DataSource = apiRespone.Data;
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            HttpHelper httpHelper = new HttpHelper();
            int provinceId = CodeHelper.ConvertToInt(cboProvince.SelectedValue);
            string url = UserConfigs.API_URL + $@"api/Master/GetTeamActivityByProvince?pProvinceId={provinceId}";
            string result = httpHelper.GETRestService(url);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<List<ProvinceActiveModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<ProvinceActiveModel>>>(result);
                if (apiRespone != null)
                {
                    dgvTeam.DataSource = apiRespone.Data;
                }
            }
        }

        private void dgvTeam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HttpHelper httpHelper = new HttpHelper();
            int teamId = CodeHelper.ConvertToInt(dgvTeam.Rows[e.RowIndex].Cells[colTeamId.Name].Value);
            int teamType = CodeHelper.ConvertToInt(dgvTeam.Rows[e.RowIndex].Cells[colTeamTyep.Name].Value);

            string url = UserConfigs.API_URL + $@"api/Gif/GetTotalGiveGifsByTeam?pTeamId={teamId}";
            string result = httpHelper.GETRestService(url);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<TotalGiveGifModel> apiRespone = JsonConvert.DeserializeObject<ApiRespone<TotalGiveGifModel>>(result);
                if (apiRespone != null)
                {
                    txtActionNumber.Text = apiRespone.Data.ActiveNum.ToString();
                    txtStart.Text = apiRespone.Data.StartDate;
                    txtEnd.Text = apiRespone.Data.EndDate;
                    var GifPlan = new
                    {
                        Gif1 = apiRespone.Data.ActiveNum * 1,
                        Gif2 = apiRespone.Data.ActiveNum * 20,
                        Gif3 = apiRespone.Data.ActiveNum * 10,
                        Gif4 = apiRespone.Data.ActiveNum * 5,
                        Gif5 = apiRespone.Data.ActiveNum * 10,
                        Gif6 = apiRespone.Data.ActiveNum * 4
                    };
                    if (teamType == 2)
                    {
                        GifPlan = new
                        {
                            Gif1 = apiRespone.Data.ActiveNum * 2,
                            Gif2 = apiRespone.Data.ActiveNum * 25,
                            Gif3 = apiRespone.Data.ActiveNum * 18,
                            Gif4 = apiRespone.Data.ActiveNum * 10,
                            Gif5 = apiRespone.Data.ActiveNum * 15,
                            Gif6 = apiRespone.Data.ActiveNum * 10
                        };
                    }

                    //Kế hoạch
                    lblGif1.Text = GifPlan.Gif1.ToString();
                    lblGif2.Text = GifPlan.Gif2.ToString();
                    lblGif3.Text = GifPlan.Gif3.ToString();
                    lblGif4.Text = GifPlan.Gif4.ToString();
                    lblGif5.Text = GifPlan.Gif5.ToString();
                    lblGif6.Text = GifPlan.Gif6.ToString();

                    //Đã dùng
                    lblsGif1.Text = apiRespone.Data.Gif1.ToString();
                    lblsGif2.Text = apiRespone.Data.Gif2.ToString();
                    lblsGif3.Text = apiRespone.Data.Gif3.ToString();
                    lblsGif4.Text = apiRespone.Data.Gif4.ToString();
                    lblsGif5.Text = apiRespone.Data.Gif5.ToString();
                    lblsGif6.Text = apiRespone.Data.Gif6.ToString();

                    //Còn lại
                    lbliGif1.Text = (GifPlan.Gif1 - apiRespone.Data.Gif1).ToString();
                    lbliGif2.Text = (GifPlan.Gif2 - apiRespone.Data.Gif2).ToString();
                    lbliGif3.Text = (GifPlan.Gif3 - apiRespone.Data.Gif3).ToString();
                    lbliGif4.Text = (GifPlan.Gif4 - apiRespone.Data.Gif4).ToString();
                    lbliGif5.Text = (GifPlan.Gif5 - apiRespone.Data.Gif5).ToString();
                    lbliGif6.Text = (GifPlan.Gif6 - apiRespone.Data.Gif6).ToString();

                }
            }
        }
    }
}
