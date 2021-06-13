using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyline.BeerViet.App.Forms
{
    public partial class frmStockIn : Form
    {
        private int _hisId;
        private int _stockId;

        public frmStockIn()
        {
            InitializeComponent();
        }

        public frmStockIn(int pHisId, int pStockId)
            :this()
        {
            _hisId = pHisId;
            _stockId = pStockId;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (_hisId > 0)
            { 
               //getstockId

            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
