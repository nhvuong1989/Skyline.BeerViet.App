using Newtonsoft.Json;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Skyline.BeerViet.App
{
    public partial class ucProvince : UserControl
    {
        int TotalCheckBoxes = 0;
        int TotalCheckedCheckBoxes = 0;
        CheckBox HeaderCheckBox = null;
        bool IsHeaderCheckBoxClicked = false;

        public ucProvince()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            AddHeaderCheckBox();
            HeaderCheckBox.KeyUp += new KeyEventHandler(HeaderCheckBox_KeyUp);
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            dgvOutLet.CellValueChanged += DgvOutLet_CellValueChanged; ;
            dgvOutLet.CurrentCellDirtyStateChanged += DgvOutLet_CurrentCellDirtyStateChanged; ;

            base.OnLoad(e);
        }

        private void DgvOutLet_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvOutLet.CurrentCell is DataGridViewCheckBoxCell)
                dgvOutLet.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void DgvOutLet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsHeaderCheckBoxClicked)
                RowCheckBoxClick((DataGridViewCheckBoxCell)dgvOutLet[colsSelected.Name, e.RowIndex]);
        }

        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            IsHeaderCheckBoxClicked = true;

            foreach (DataGridViewRow Row in dgvOutLet.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells[colsSelected.Name]).Value = HCheckBox.Checked;

            dgvOutLet.RefreshEdit();

            TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;

            IsHeaderCheckBoxClicked = false;
        }

        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }

        private void HeaderCheckBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                HeaderCheckBoxClick((CheckBox)sender);
        }

        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();

            HeaderCheckBox.Size = new Size(15, 15);
            HeaderCheckBox.Location = new Point(this.dgvOutLet.Location.X + 10, this.dgvOutLet.Location.Y + 5);
            //Add the CheckBox into the DataGridView
            this.dgvOutLet.Controls.Add(HeaderCheckBox);
        }

        private void RowCheckBoxClick(DataGridViewCheckBoxCell RCheckBox)
        {
            if (RCheckBox != null)
            {
                //Modifiy Counter;            
                if ((bool)RCheckBox.Value && TotalCheckedCheckBoxes < TotalCheckBoxes)
                    TotalCheckedCheckBoxes++;
                else if (TotalCheckedCheckBoxes > 0)
                    TotalCheckedCheckBoxes--;

                //Change state of the header CheckBox.
                if (TotalCheckedCheckBoxes < TotalCheckBoxes)
                    HeaderCheckBox.Checked = false;
                else if (TotalCheckedCheckBoxes == TotalCheckBoxes)
                    HeaderCheckBox.Checked = true;
            }
        }

        public void SetDataBinding()
        {
            HttpHelper httpHelper = new HttpHelper();
            string url = UserConfigs.API_URL + $@"api/Master/GetProvincesByRegion?pRegion={UserConfigs.Region}";
            string result = httpHelper.GETRestService(url);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<List<ProvinceModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<ProvinceModel>>>(result);
                if (apiRespone != null)
                {
                    dgvProvince.DataSource = apiRespone.Data;
                }
            }
        }

        private void dgvProvince_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int provinceId = 0;
            if (e.RowIndex >= 0)
            {
                provinceId = CodeHelper.ConvertToInt(dgvProvince.SelectedRows[0].Cells[colsId.Name].Value);
                HttpHelper httpHelper = new HttpHelper();
                string url = UserConfigs.API_URL + $@"api/User/GetUsersByProvince?pProvinceId={provinceId}";
                string result = httpHelper.GETRestService(url);
                if (!string.IsNullOrEmpty(result))
                {
                    ApiRespone<List<UserModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<UserModel>>>(result);
                    if (apiRespone != null)
                    {
                        dgvUsers.AutoGenerateColumns = false;
                        dgvUsers.DataSource = apiRespone.Data;
                    }
                }

                url = UserConfigs.API_URL + $@"api/Master/GetWorkShopsByProvince?pProvinceId={provinceId}";
                result = httpHelper.GETRestService(url);
                if (!string.IsNullOrEmpty(result))
                {
                    ApiRespone<List<WorkShopModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<WorkShopModel>>>(result);
                    if (apiRespone != null)
                    {
                        dgvOutLet.AutoGenerateColumns = false;
                        dgvOutLet.DataSource = apiRespone.Data;
                    }
                }
            }
        }

        private void btnCreateUser_Click(object sender, System.EventArgs e)
        {
            int provinceId = CodeHelper.ConvertToInt(dgvProvince.SelectedRows[0].Cells[colsId.Name].Value);
            string provinceName = dgvProvince.SelectedRows[0].Cells[colsProvinceName.Name].Value.ToString();
            string provinceCode = "";
            string[] names = provinceName.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (names.Length == 1)
            {
                provinceCode = names[0].Substring(0, 3).ToUpper();
            }
            else if (names.Length == 2)
            {
                provinceCode = names[0].Substring(0, 2).ToUpper() + names[1].Substring(0, 1).ToUpper();
            }
            else
            {
                provinceCode = names[0].Substring(0, 1).ToUpper() + names[1].Substring(0, 1).ToUpper()
                    + names[2].Substring(0, 1).ToUpper();
            }

            provinceCode = CodeHelper.ConvertToUnsign(provinceCode);

            frmUsers frm = new frmUsers(provinceId, provinceCode, provinceName);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                HttpHelper httpHelper = new HttpHelper();
                string url = UserConfigs.API_URL + $@"api/User/GetUsersByProvince?pProvinceId={provinceId}";
                string result = httpHelper.GETRestService(url);
                if (!string.IsNullOrEmpty(result))
                {
                    ApiRespone<List<UserModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<UserModel>>>(result);
                    if (apiRespone != null)
                    {
                        dgvUsers.AutoGenerateColumns = false;
                        dgvUsers.DataSource = apiRespone.Data;
                    }
                }
            }
        }

        private void btnImportOutLet_Click(object sender, System.EventArgs e)
        {
            if (dgvProvince.SelectedRows == null || dgvProvince.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tỉnh cần import!");
                return;
            }

            int provinceId = CodeHelper.ConvertToInt(dgvProvince.SelectedRows[0].Cells[colsId.Name].Value);
            string provinceName = dgvProvince.SelectedRows[0].Cells[colsProvinceName.Name].Value.ToString();
            if (MessageBox.Show($"Bạn muốn import cho tỉnh {provinceName} phải không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ofdExcel.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofdExcel.FileName;

                    using (ExcelEngine excelEngine = new ExcelEngine())
                    {
                        try
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            //Initialize Application
                            IApplication application = excelEngine.Excel;
                            //Set default version for application
                            application.DefaultVersion = ExcelVersion.Excel2013;
                            //Create a new workbook
                            IWorkbook workbook = application.Workbooks.Open(fileName);
                            //Accessing first worksheet in the workbook
                            IWorksheet worksheet = workbook.Worksheets[0];

                            int idx = 2;
                            List<WorkShop> workShops = new List<WorkShop>();
                            while (true)
                            {
                                if (string.IsNullOrEmpty(worksheet.Range[$"C{idx}"].Value))
                                {
                                    break;
                                }
                                workShops.Add(
                                    new WorkShop
                                    {
                                        ProvinceId = provinceId,
                                        WorkShopName = worksheet.Range[$"A{idx}"].Value,
                                        WorkShopAddress = worksheet.Range[$"B{idx}"].Value,
                                        ResultText = worksheet.Range[$"C{idx}"].Value,
                                        ExecuteDate = CodeHelper.ConvertToString(worksheet.Range[$"D{idx}"].Value2),
                                        UniqueCode = worksheet.Range[$"E{idx}"].Value
                                    });

                                idx++;
                            }
                            //string request = JsonConvert.SerializeObject(workShops);

                            HttpHelper httpHelper = new HttpHelper();
                            string url = UserConfigs.API_URL + $@"api/Master/ImportWorkShop";

                            string result = httpHelper.POSTRestService(url, workShops);
                            if (!string.IsNullOrEmpty(result))
                            {
                                ApiRespone<ReturnMessage> apiRespone = JsonConvert.DeserializeObject<ApiRespone<ReturnMessage>>(result);
                                if (apiRespone != null)
                                {
                                    url = UserConfigs.API_URL + $@"api/Master/GetWorkShopsByProvince?pProvinceId={provinceId}";
                                    result = httpHelper.GETRestService(url);
                                    if (!string.IsNullOrEmpty(result))
                                    {
                                        ApiRespone<List<WorkShopModel>> apiGetShop = JsonConvert.DeserializeObject<ApiRespone<List<WorkShopModel>>>(result);
                                        if (apiGetShop != null)
                                        {
                                            dgvOutLet.AutoGenerateColumns = false;
                                            dgvOutLet.DataSource = apiGetShop.Data;
                                        }
                                    }

                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }
                        finally
                        {
                            Cursor.Current = Cursors.Default;
                        }
                    }
                }
            }

        }

        private void tsmActive_Click(object sender, EventArgs e)
        {
            var rowSelected = dgvOutLet.Rows.OfType<DataGridViewRow>().Where(p => CodeHelper.ConvertToBool(p.Cells[colsSelected.Name].Value) == true);
            if (rowSelected != null)
            {
                int[] Ids = rowSelected.Select(p => CodeHelper.ConvertToInt(p.Cells[colOutletId.Name].Value)).ToArray();
                if (Ids.Length > 0)
                {
                    HttpHelper httpHelper = new HttpHelper();
                    string strIds = JsonConvert.SerializeObject(Ids);
                    string url = UserConfigs.API_URL + $@"api/Master/ActiveOrDeactiveWorkShop?pStrJsonIds={strIds}&pIsActive=true";
                    string result = httpHelper.GETRestService(url);
                    if (!string.IsNullOrEmpty(result))
                    {
                        ApiRespone<ReturnMessage> apiRespone = JsonConvert.DeserializeObject<ApiRespone<ReturnMessage>>(result);
                        if (apiRespone != null)
                        {
                            MessageBox.Show(apiRespone.Data.Message);
                        }
                    }
                }
            }
        }

        private void tsmDesctive_Click(object sender, EventArgs e)
        {
            var rowSelected = dgvOutLet.Rows.OfType<DataGridViewRow>().Where(p => CodeHelper.ConvertToBool(p.Cells[colsSelected.Name].Value) == true);
            if (rowSelected != null)
            {
                int[] Ids = rowSelected.Select(p => CodeHelper.ConvertToInt(p.Cells[colOutletId.Name].Value)).ToArray();
                if (Ids.Length > 0)
                {
                    HttpHelper httpHelper = new HttpHelper();
                    string strIds = JsonConvert.SerializeObject(Ids);
                    string url = UserConfigs.API_URL + $@"api/Master/ActiveOrDeactiveWorkShop?pStrJsonIds={strIds}&pIsActive=false";
                    string result = httpHelper.GETRestService(url);
                    if (!string.IsNullOrEmpty(result))
                    {
                        ApiRespone<ReturnMessage> apiRespone = JsonConvert.DeserializeObject<ApiRespone<ReturnMessage>>(result);
                        if (apiRespone != null)
                        {
                            MessageBox.Show(apiRespone.Data.Message);
                        }
                    }
                }
            }
        }

        private void tsmPActive_Click(object sender, EventArgs e)
        {
            var rowSelected = dgvProvince.Rows.OfType<DataGridViewRow>().Where(p => CodeHelper.ConvertToBool(p.Cells[colpId.Name].Value) == true);
            if (rowSelected != null)
            {
                int[] Ids = rowSelected.Select(p => CodeHelper.ConvertToInt(p.Cells[colsId.Name].Value)).ToArray();
                if (Ids.Length > 0)
                {
                    HttpHelper httpHelper = new HttpHelper();
                    string strIds = JsonConvert.SerializeObject(Ids);
                    string url = UserConfigs.API_URL + $@"api/Master/ActiveOrDeactiveProvince?pStrJsonIds={strIds}&pIsActive=true";
                    string result = httpHelper.GETRestService(url);
                    if (!string.IsNullOrEmpty(result))
                    {
                        ApiRespone<ReturnMessage> apiRespone = JsonConvert.DeserializeObject<ApiRespone<ReturnMessage>>(result);
                        if (apiRespone != null)
                        {
                            MessageBox.Show(apiRespone.Data.Message);
                        }
                    }
                }
            }
        }

        private void tsmPDeactive_Click(object sender, EventArgs e)
        {
            var rowSelected = dgvProvince.Rows.OfType<DataGridViewRow>().Where(p => CodeHelper.ConvertToBool(p.Cells[colpId.Name].Value) == true);
            if (rowSelected != null)
            {
                int[] Ids = rowSelected.Select(p => CodeHelper.ConvertToInt(p.Cells[colsId.Name].Value)).ToArray();
                if (Ids.Length > 0)
                {
                    HttpHelper httpHelper = new HttpHelper();
                    string strIds = JsonConvert.SerializeObject(Ids);
                    string url = UserConfigs.API_URL + $@"api/Master/ActiveOrDeactiveProvince?pStrJsonIds={strIds}&pIsActive=false";
                    string result = httpHelper.GETRestService(url);
                    if (!string.IsNullOrEmpty(result))
                    {
                        ApiRespone<ReturnMessage> apiRespone = JsonConvert.DeserializeObject<ApiRespone<ReturnMessage>>(result);
                        if (apiRespone != null)
                        {
                            MessageBox.Show(apiRespone.Data.Message);
                        }
                    }
                }
            }
        }

        private void tsmUActive_Click(object sender, EventArgs e)
        {
            var rowSelected = dgvUsers.Rows.OfType<DataGridViewRow>().Where(p => CodeHelper.ConvertToBool(p.Cells[ColUIsChecked.Name].Value) == true);
            if (rowSelected != null)
            {
                string[] Ids = rowSelected.Select(p => CodeHelper.ConvertToString(p.Cells[colUsername.Name].Value)).ToArray();
                if (Ids.Length > 0)
                {
                    HttpHelper httpHelper = new HttpHelper();
                    string strIds = JsonConvert.SerializeObject(Ids);
                    string url = UserConfigs.API_URL + $@"api/User/ActiveOrDeactiveUsers?pStrJsonIds={strIds}&pIsActive=true";
                    string result = httpHelper.GETRestService(url);
                    if (!string.IsNullOrEmpty(result))
                    {
                        ApiRespone<ReturnMessage> apiRespone = JsonConvert.DeserializeObject<ApiRespone<ReturnMessage>>(result);
                        if (apiRespone != null)
                        {
                            MessageBox.Show(apiRespone.Data.Message);
                        }
                    }
                }
            }
        }

        private void tsmUDeactive_Click(object sender, EventArgs e)
        {
            var rowSelected = dgvUsers.Rows.OfType<DataGridViewRow>().Where(p => CodeHelper.ConvertToBool(p.Cells[ColUIsChecked.Name].Value) == true);
            if (rowSelected != null)
            {
                string[] Ids = rowSelected.Select(p => CodeHelper.ConvertToString(p.Cells[colUsername.Name].Value)).ToArray();
                if (Ids.Length > 0)
                {
                    HttpHelper httpHelper = new HttpHelper();
                    string strIds = JsonConvert.SerializeObject(Ids);
                    string url = UserConfigs.API_URL + $@"api/User/ActiveOrDeactiveUsers?pStrJsonIds={strIds}&pIsActive=false";
                    string result = httpHelper.GETRestService(url);
                    if (!string.IsNullOrEmpty(result))
                    {
                        ApiRespone<ReturnMessage> apiRespone = JsonConvert.DeserializeObject<ApiRespone<ReturnMessage>>(result);
                        if (apiRespone != null)
                        {
                            MessageBox.Show(apiRespone.Data.Message);
                        }
                    }
                }
            }
        }

        private void dgvProvince_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProvince.CurrentCell is DataGridViewCheckBoxCell)
                dgvProvince.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvUsers_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentCell is DataGridViewCheckBoxCell)
                dgvUsers.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            if (dgvProvince.SelectedRows == null || dgvProvince.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tỉnh cần import!");
                return;
            }

            int provinceId = CodeHelper.ConvertToInt(dgvProvince.SelectedRows[0].Cells[colsId.Name].Value);

            HttpHelper httpHelper = new HttpHelper();

            string url = UserConfigs.API_URL + $@"api/Sale/GetSaleHistoriesByProvince?pProvinceId={provinceId}";
            string result = httpHelper.GETRestService(url);
            if (!string.IsNullOrEmpty(result))
            {
                ApiRespone<List<SaleHistoryModel>> apiRespone = JsonConvert.DeserializeObject<ApiRespone<List<SaleHistoryModel>>>(result);
                if (apiRespone != null && apiRespone.Data.Count > 0)
                {
                    //xu ly xuat excel
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        using (ExcelEngine excelEngine = new ExcelEngine())
                        {
                            //Initialize Application
                            IApplication application = excelEngine.Excel;

                            //Set default version for application
                            application.DefaultVersion = ExcelVersion.Excel2013;

                            //Create a new workbook
                            IWorkbook workbook = application.Workbooks.Create(1);

                            //Accessing first worksheet in the workbook
                            IWorksheet worksheet = workbook.Worksheets[0];
                            workbook.Worksheets.AddCopy(0);
                            workbook.Worksheets.AddCopy(0);
                            workbook.Worksheets.AddCopy(0);
                            workbook.Worksheets.AddCopy(0);
                            workbook.Worksheets.AddCopy(0);
                            workbook.Worksheets.AddCopy(0);

                            string[] header = typeof(SaleHistoryModel).GetProperties()
                                .Select(p => Attribute.IsDefined(p, typeof(DescriptionAttribute)) ?
                                            (Attribute.GetCustomAttribute(p, typeof(DescriptionAttribute)) as DescriptionAttribute).Description : p.Name
                                ).ToArray();

                            header = header.Where((p, idx) => idx >= 0).ToArray();
                            //Import data from DataGridView control
                            worksheet.ImportArray(header, 1, 1, false);
                            worksheet.ImportData(apiRespone.Data, 2, 1, false);

                            worksheet = workbook.Worksheets[1];
                            worksheet.Name = "Nón bảo hiểm";
                            worksheet.ImportArray(header, 1, 1, false);
                            worksheet.ImportData(apiRespone.Data.Where(p => p.Gif1 > 0), 2, 1, false);

                            worksheet = workbook.Worksheets[2];
                            worksheet.Name = "Thùng đá 1.6l";
                            worksheet.ImportArray(header, 1, 1, false);
                            worksheet.ImportData(apiRespone.Data.Where(p => p.Gif2 > 0), 2, 1, false);

                            worksheet = workbook.Worksheets[3];
                            worksheet.Name = "Ly thủy tinh";
                            worksheet.ImportArray(header, 1, 1, false);
                            worksheet.ImportData(apiRespone.Data.Where(p => p.Gif3 > 0), 2, 1, false);

                            worksheet = workbook.Worksheets[4];
                            worksheet.Name = "Đồng hồ treo tường";
                            worksheet.ImportArray(header, 1, 1, false);
                            worksheet.ImportData(apiRespone.Data.Where(p => p.Gif4 > 0), 2, 1, false);

                            worksheet = workbook.Worksheets[5];
                            worksheet.Name = "Áo mưa bia việt";
                            worksheet.ImportArray(header, 1, 1, false);
                            worksheet.ImportData(apiRespone.Data.Where(p => p.Gif5 > 0), 2, 1, false);

                            worksheet = workbook.Worksheets[6];
                            worksheet.Name = "Thùng đá 9l";
                            worksheet.ImportArray(header, 1, 1, false);
                            worksheet.ImportData(apiRespone.Data.Where(p => p.Gif6 > 0), 2, 1, false);

                            workbook.Worksheets.AddCopy(1);
                            //Save the workbook
                            workbook.SaveAs(saveFile.FileName);
                        }
                    }
                }
            }
        }
    }
}
