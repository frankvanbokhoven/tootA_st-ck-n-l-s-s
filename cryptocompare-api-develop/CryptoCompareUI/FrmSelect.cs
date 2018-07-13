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


            for (int i = 0; i < clbStock.Items.Count; i++)
            {
                if (clbStock.GetItemCheckState(i) == CheckState.Checked)
                {
                   frmUIMain.SelectedStocks.Add(clbStock.Items[i].ToString());
                }

            }

            this.DialogResult = DialogResult.OK;

        }

        private void LoadStocks()
        {
            clbStock.Items.Clear();
            clbStock.Items.Add("AAPL", true);
        }

        private void FrmSelect_Shown(object sender, EventArgs e)
        {
            this.Width = gbxStock.Left + gbxStock.Width + 50;
            this.Height = gbxStock.Top + gbxStock.Height + 50;
        }
    }
}
