using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoCompareUI
{
    public partial class FrmSelect : Form
    {

        public FrmUIMain frmUIMain;
        public FrmSelect()
        {
            InitializeComponent();
            LoadStocks();
            dtpFrom.Value = DateTime.Now.AddYears(-25);
            dtpTill.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUIMain.FromDate = dtpFrom.Value;
            frmUIMain.TillDate = dtpTill.Value;
            if(rbAll.Checked)
            {
                frmUIMain.DateRange = FrmUIMain.FetchDateRange.fdAll;
            }
            else
            {
                frmUIMain.DateRange = FrmUIMain.FetchDateRange.fdDateRange;
            }
            
            this.DialogResult = DialogResult.OK;

        }

        private void LoadStocks()
        {
            clbStock.Items.Clear();
            clbStock.Items.Add("AAPL", true);
        }
    }
}
