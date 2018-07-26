using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CryptoCompareUI
{
    public partial class FrmUIMain : MaterialForm
    {
       private FrmSelect frmSelect = null;
       public enum FetchDateRange {fdAll, fdDateRange};
        private FetchDateRange dateRange = FetchDateRange.fdAll;
        private DateTime fromDate = DateTime.MinValue;
        private DateTime tillDate = DateTime.MaxValue;
        private List<String> selectedStocks = new List<string>();
        public FrmConsole frmConsole;

        public FetchDateRange DateRange { get => this.dateRange; set => this.dateRange = value; }
        public DateTime FromDate { get => this.fromDate; set => this.fromDate = value; }
        public DateTime TillDate { get => this.tillDate; set => this.tillDate = value; }
        public List<string> SelectedStocks { get => this.selectedStocks; set => this.selectedStocks = value; }

        public FrmUIMain()
        {
            InitializeComponent();
            //materialskin. zie: https://github.com/bezzad/PersianMaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.Dark;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.White);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FrmUIMain_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Height = this.Height - 62;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmUIMain_Load(object sender, EventArgs e)
        {

            LoadAvailableStocks();
            cbxIndicator.SelectedIndex = 0;
        }

        #region init lists
        private void LoadAvailableStocks()
        {
            clbStocks.Items.Clear();
            
         //   clbStocks.Items.Add()
        }
        #endregion

        private void btnLoadSelected_Click(object sender, EventArgs e)
        {

            //  var client = CryptoCompareClient.Instance;
            //  var ticker = client.Prices.HistoricalAsync("BTC", new[] { "USD", "XLM" }, DateTimeOffset.Now.AddDays(-1));
            // Assert.IsNotNull(ticker);
            //Assert.Greater(ticker.Count, 0);
          //  if (frmSelect is null)
          //  {
                frmSelect = new FrmSelect();
         //   }
                frmSelect.Width = 400;
                frmSelect.Height = 300;
                frmSelect.Top = this.Top + btnLoadSelected.Top + btnLoadSelected.Height;
                frmSelect.Left = this.Left + btnLoadSelected.Left + btnLoadSelected.Width;
            frmSelect.frmUIMain = this;
              if(frmSelect.ShowDialog() == DialogResult.OK)
            {
                tbxSelection.Text = string.Format("Stocks: {0}, Daterange: {1}", string.Concat(SelectedStocks.ToArray()), "All");
            }
            
        }

        private void clbStocks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxIndicator_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbxIndicator.SelectedIndex != 0)
            {
                if (clbSelectedIndicators.Items.IndexOf(cbxIndicator.Text) == -1)
                {
                    clbSelectedIndicators.Items.Add(cbxIndicator.Text, true);
                    cbxIndicator.SelectedIndex = 0;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsole_Click(object sender, EventArgs e)
        {
            if(frmConsole == null)
            {
                frmConsole = new FrmConsole();
                frmConsole.Show();
            }
        }
    }
}
