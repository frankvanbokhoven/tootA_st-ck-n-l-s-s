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
        public FetchDateRange DateRange = FetchDateRange.fdAll;
        public DateTime FromDate = DateTime.MinValue;
        public DateTime TillDate = DateTime.MaxValue;
        public List<String> SelectedStocks = new List<string>();
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

        private void btnYahoo_Click(object sender, EventArgs e)
        {
//            void DownloadDataFromWeb(string symbol)
//            {
//                DateTime startDate = DateTime.Parse("1900-01-01");

//                string baseURL = "http://ichart.finance.yahoo.com/table.csv?";
//                string queryText = BuildHistoricalDataRequest(symbol, startDate, DateTime.Today);
//                string url = string.Format("{0}{1}", baseURL, queryText);

//                //Get page showing the table with the chosen indices
//                HttpWebRequest request = null;
//                HttpWebResponse response = null;
//                StreamReader stReader = null;

//                //csv content
//                string docText = string.Empty;
//                string csvLine = null;
//                try
//                {
//                    request = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
//                    request.Timeout = 300000;

//                    response = (HttpWebResponse)request.GetResponse();

//                    stReader = new StreamReader(response.GetResponseStream(), true);

//                    stReader.ReadLine();//skip the first (header row)
//                    while ((csvLine = stReader.ReadLine()) != null)
//                    {
//                        string[] sa = csvLine.Split(new char[] { ',' });

//                        DateTime date = DateTime.Parse(sa[0].Trim('"'));
//                        Double open = double.Parse(sa[1]);
//                        Double high = double.Parse(sa[2]);
//                        Double low = double.Parse(sa[3]);
//                        Double close = double.Parse(sa[4]);
//                        Double volume = double.Parse(sa[5]);
//                        Double adjClose = double.Parse(sa[6]);
//                        // Process the data (e.g. insert into DB)
//                    }
//                }
//                catch (Exception e)
//                {
//                    throw e;
//                }
//            }

//            string BuildHistoricalDataRequest(string symbol, DateTime startDate, DateTime endDate)
//            {
//                // We're subtracting 1 from the month because yahoo
//                // counts the months from 0 to 11 not from 1 to 12.
//                StringBuilder request = new StringBuilder();
//                request.AppendFormat("s={0}", symbol);
//                request.AppendFormat("&a={0}", startDate.Month - 1);
//                request.AppendFormat("&b={0}", startDate.Day);
//                request.AppendFormat("&c={0}", startDate.Year);
//                request.AppendFormat("&d={0}", endDate.Month - 1);
//                request.AppendFormat("&e={0}", endDate.Day);
//                request.AppendFormat("&f={0}", endDate.Year);
//                request.AppendFormat("&g={0}", "d"); //daily

//                return request.ToString();
//            }

//        //    The code above will go through each data instance in the CSV file, so you just need to save the data instances to arrays.Calculating the return should be straight forward from then on.

//// Create your data lists
//            List<DateTime> date = new List<DateTime>();
//            List<Double> open = new List<Double>();
//            List<Double> high = new List<Double>();
//            List<Double> low = new List<Double>();
//            List<Double> close = new List<Double>();
//            List<Double> volume = new List<Double>();
//            List<Double> adjClose = new List<Double>();

//            //
//            // ...
//            //

//            // inside the DownloadDataFromWeb function:

//            // Add the data points as you're going through the loop
//            date.Add(DateTime.Parse(sa[0].Trim('"')));
//            open.Add(double.Parse(sa[1]));
//            high.Add(double.Parse(sa[2]));
//            low.Add(double.Parse(sa[3]));
//            close.Add(double.Parse(sa[4]));
//            volume.Add(double.Parse(sa[5]));
//            adjClose.Add(double.Parse(sa[6]));

            //
            // ...
            //

            // Calculate the return after you've downloaded all t
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
    }
}
