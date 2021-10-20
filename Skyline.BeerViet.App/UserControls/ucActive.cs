using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Skyline.BeerViet.App
{
    public partial class ucActive : UserControl
    {
        public ucActive()
        {
            InitializeComponent();
        }

        internal void SetDataBinding()
        {
            HttpHelper httpHelper = new HttpHelper();
            string url = UserConfigs.API_URL + $@"api/User/GetCheckInHistories?pRegion={UserConfigs.Region}&pViewDate={dtpViewDate.Value.ToString("yyyy-MM-dd")}";
            string result = httpHelper.GETRestService(url);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<List<CheckInHistoryModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<CheckInHistoryModel>>>(result);
                if (apiRespone != null)
                {
                    dgvCheckIn.AutoGenerateColumns = false;
                    dgvCheckIn.DataSource = apiRespone.Data;
                }
            }
            dgvSale.DataSource = null;
        }

        private void dgvCheckIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int saleId = 0;
                saleId = CodeHelper.ConvertToInt(dgvCheckIn.Rows[e.RowIndex].Cells[colId.Name].Value);
                HttpHelper httpHelper = new HttpHelper();
                string url = UserConfigs.API_URL + $@"api/Sale/GetSaleHistories?pHistoryId={saleId}";
                string result = httpHelper.GETRestService(url);
                if (!string.IsNullOrEmpty(result))
                {
                    ApiRespone<List<SaleHistoryModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<SaleHistoryModel>>>(result);
                    if (apiRespone != null)
                    {
                        dgvSale.AutoGenerateColumns = false;
                        dgvSale.DataSource = apiRespone.Data;
                    }
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SetDataBinding();
        }

        private void dgvSale_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                SaleHistoryModel saleHistory = dgvSale.SelectedRows[0].DataBoundItem as SaleHistoryModel;
                if (saleHistory != null)
                {
                    frmAction frm = new frmAction(saleHistory);
                    frm.ShowDialog();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvCheckIn.SelectedRows.Count > 0)
            {
                CheckInHistoryModel checkIn = dgvCheckIn.SelectedRows[0].DataBoundItem as CheckInHistoryModel;
                if (checkIn != null)
                {
                    frmAction frm = new frmAction(checkIn.UserName, checkIn.TeamId, checkIn.Id);
                    frm.ShowDialog();
                }
            }
        }

        private void uploadStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInHistoryModel row = this.dgvCheckIn.SelectedRows[0].DataBoundItem as CheckInHistoryModel;
            if (row != null)
            {
                string fileUpload;
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                    openFileDialog.Filter = "Pdf files (*.pdf)|*.pdf";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        fileUpload = openFileDialog.FileName;

                        HttpHelper httpHelper = new HttpHelper();
                        string url = UserConfigs.API_URL + $@"api/Sale/UploadAttachment?pCheckInPath={row.CheckInPath}";
                        string result = httpHelper.POSTRestService(url, null, fileUpload);
                        if (!string.IsNullOrEmpty(result))
                        {
                            ApiRespone<List<SaleHistoryModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<SaleHistoryModel>>>(result);
                            if (apiRespone != null)
                            {
                                MessageBox.Show(apiRespone.Message);
                            }
                        }
                    }
                }
            }
        }

        private void cMnuApplication_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.dgvCheckIn.SelectedRows.Count == 0)
            {
                e.Cancel = true;
            }


        }

        private void dgvCheckIn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CheckInHistoryModel checkInHistoryModel = dgvCheckIn.SelectedRows[0].DataBoundItem as CheckInHistoryModel;
                frmCheckIn frmCheckIn = new frmCheckIn(checkInHistoryModel);
                frmCheckIn.ShowDialog();
                SetDataBinding();
            }
        }
    }
}
