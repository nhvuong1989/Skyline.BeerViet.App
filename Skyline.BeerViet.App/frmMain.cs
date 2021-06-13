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
    public partial class frmMain : Form
    {
        ucProvince ucProvince = null;
        ucActive ucActive = null;
        ucStock ucStock = null;
        ucStockManagement ucStockMn= null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ribbProvince_Click(object sender, EventArgs e)
        {
            if (ucProvince == null)
            {
                ucProvince = new ucProvince();
            }
            ucProvince.SetDataBinding();
            ucProvince.BringToFront();
            ucProvince.Dock = DockStyle.Fill;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(ucProvince);
        }

        private void ribbAction_Click(object sender, EventArgs e)
        {
            if (ucActive == null)
            {
                ucActive = new ucActive();
            }
            ucActive.SetDataBinding();
            ucActive.BringToFront();
            ucActive.Dock = DockStyle.Fill;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(ucActive);
        }

        private void ribbGif_Click(object sender, EventArgs e)
        {
            if (ucStock == null)
            {
                ucStock = new ucStock();
            }
            ucStock.SetDataBinding();
            ucStock.BringToFront();
            ucStock.Dock = DockStyle.Fill;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(ucStock);
        }

        private void ribStock_Click(object sender, EventArgs e)
        {
            if (ucStockMn == null)
            {
                ucStockMn = new ucStockManagement();
            }
            //ucStockMn.SetDataBinding();
            ucStockMn.BringToFront();
            ucStockMn.Dock = DockStyle.Fill;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(ucStockMn);
        }
    }
}
