using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;

namespace CryptoCompareUI
{
    public partial class ucInsertData : UserControl
    {
        private string connectionString = ConfigurationSettings.AppSettings["DBConnectionString"];
        public MTOM_tootA.Service1Client service = new MTOM_tootA.Service1Client();

        public FrmUIMain frmuimain;

        public ucInsertData()
        {
            InitializeComponent();
        }

        private void btnInsertCSV_Click(object sender, EventArgs e)
        {
            ImportCSVData(1);
        }

        /// <summary>
        /// Adds a message to the list in the wcf service
        /// </summary>
        /// <param name="_message"></param>
        /// <param name="_severity"></param>
        private void AddMessage(string _message, string _severity)
        {
            try
            {
                if (service.State != System.ServiceModel.CommunicationState.Opened)
                {
                    service.Open();
                }
                service.SetMessage(_message, _severity, "Main UI");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add message probleem!" + ex.Message);
            }
        }


        private void ImportCSVData(int _tickerID)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*csv file |*.csv";
            ofd.Title = "Select csv file";
            int i = 0;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SqlCommand command = null;
                SqlConnection _sqlcon = null;
                string result = string.Empty;
                try
                {
                    _sqlcon = new SqlConnection(connectionString);
                    _sqlcon.Open();

                    //laad de csv
                    List<string> csvdata = new List<string>();
                    try
                    {
                        StreamReader listToRead = new StreamReader(ofd.FileName); //read file stream
                        string line;
                        while ((line = listToRead.ReadLine()) != null) //read each line until end of file
                            csvdata.Add(line); //insert to list

                        listToRead.Close(); //close the stream
                        progressBarImport.Visible = true;
                        progressBarImport.Minimum = 0;
                        progressBarImport.Maximum = csvdata.Count;
                        lblprogress.Visible = true;
                        string sqlstring;
                        int tickerid = -1;
                        string ticker = string.Empty;
                        foreach (string regel in csvdata)
                        {
                            if (i > 0 && i < csvdata.Count)
                            {
                                string[] splitstring = regel.Split(',');

                                //nu kijken we van welke databrond dit afkomstig is en passen de sql daarop aan.
                                if (cbxDataFormat.Text.ToLower().Contains("nasdaq"))
                                {
                                    if (ticker != splitstring[6].ToUpper().Trim())
                                    {
                                        tickerid = GetTickerID(splitstring[6].ToUpper().Trim());
                                        if (tickerid == -1)//indien -1, dan moet een nieuwe ticker gemaakt worden en die nieuwe id moet teruggegven worden
                                        {

                                        }

                                    }
                                    sqlstring = string.Format(@" INSERT  into tblTickerData (TickerId,[Date],OpenPrice, HighPrice,LowPrice,ClosePrice,Volume) values({0}, Convert(datetime, {1}), {2}, {3}, {4}, {5}, {6} );", tickerid, splitstring[0], splitstring[1], splitstring[2], splitstring[3], splitstring[4], splitstring[5]);
                                    ticker = splitstring[6].ToUpper().Trim();
                                }
                                else
                                {
                                    sqlstring = string.Format(@" INSERT  into tblTickerData (TickerId,[Date],OpenPrice, HighPrice,LowPrice,ClosePrice,Adjusted_ClosePrice,Volume) values({0}, Convert(datetime, {1}), {2}, {3}, {4}, {5}, {6}, {7} );", _tickerID, splitstring[0], splitstring[1], splitstring[2], splitstring[3], splitstring[4], splitstring[5], splitstring[6]);
                                }
                                command = new SqlCommand(sqlstring, _sqlcon);
                                command.ExecuteNonQuery();
                                command.Dispose();
                                progressBarImport.Value++;
                                lblprogress.Text = i.ToString() + "/" + csvdata.Count.ToString();
                                Application.DoEvents();
                            }
                            i++;
                        }
                        MessageBox.Show("Imported successfully: " + i + "rows");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        AddMessage("error inserting csvdata:" + ex.Message, "Error");

                        //throw;
                    }
                    finally
                    {
                        progressBarImport.Visible = false;
                        lblprogress.Visible = false;
                    }
                    _sqlcon.Close();
                    result = "Bulk Inserted OK";
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    AddMessage("error inserting csv data container:" + ex.Message, "Error");

                    result = ex.Message;
                }
                finally
                {
                    //       command.Dispose();]\
                    _sqlcon.Dispose();

                }
            }
        }


        private void ImportTickers()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*csv file |*.csv|txt file|*.txt";
            ofd.Title = "Select file";
            int i = 0;

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                SqlCommand command = null;
                SqlConnection _sqlcon = null;
                string result = string.Empty;
                try
                {
                    _sqlcon = new SqlConnection(connectionString);



                    _sqlcon.Open();

                    //laad de csv
                    List<string> csvdata = new List<string>();
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        StreamReader listToRead = new StreamReader(ofd.FileName); //read file stream
                        string line;
                        while ((line = listToRead.ReadLine()) != null) //read each line until end of file
                            csvdata.Add(line); //insert to list
                        listToRead.Close(); //close the stream
                        progressBarTickers.Visible = true;
                        lblimporttickers.Visible = true;
                        progressBarTickers.Minimum = 0;
                        progressBarTickers.Maximum = csvdata.Count;
                        lblprogress.Visible = true;
                        string[] splitnameandtype;
                        string sqlstring;
                        char decimalseparator = ',';
                        foreach (string regel in csvdata)
                        {
                            if (i > 0 && i < csvdata.Count)
                            {
                                if (cbxDataFormatTickers.SelectedIndex == 0)
                                    decimalseparator = ',';
                                else
                                    decimalseparator = '|';

                                string[] splitstring = regel.Replace("'", string.Empty).Split(decimalseparator);

                                if (splitstring[1].Contains('-'))
                                {
                                    splitnameandtype = splitstring[1].Split('-');
                                }
                                else
                                {
                                    splitnameandtype = (splitstring[1] + "- n/a").Split('-');
                                }
                                sqlstring = string.Format(@" INSERT  into tblTickerSymbols (StockName, ISIN, Type, Exchange, TestIssue, FinancialStatus, RoundLotSize, ETF, NextShares)" +
                                    "values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7}, '{8}' );", splitnameandtype[0].Trim(), splitstring[0], splitnameandtype[1].Trim(), tbxExchange.Text, splitstring[2], splitstring[3], splitstring[4], splitstring[5], splitstring[6], splitstring[7]);
                                command = new SqlCommand(sqlstring, _sqlcon);
                                command.ExecuteNonQuery();
                                command.Dispose();
                                progressBarTickers.Value++;
                                lblimporttickers.Text = i.ToString() + "/" + csvdata.Count.ToString();
                                Application.DoEvents();
                            }
                            i++;
                        }
                        MessageBox.Show("Imported successfully: " + i + "tickers");

                    }
                    catch (Exception ex)
                    {
                        AddMessage("error importing tickers:" + ex.Message, "Error");

                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        progressBarTickers.Visible = false;
                        this.Cursor = Cursors.Default;
                        lblimporttickers.Visible = false;
                    }
                    _sqlcon.Close();
                    result = "Ticker import successfull";
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    result = ex.Message;
                    AddMessage("error importing tickers container:" + ex.Message, "Error");

                }
                finally
                {
                    _sqlcon.Dispose();

                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTickers();
            LoadSelectedAutoUpdateTickers();
        }

        private void LoadTickers()
        {
            string sqlstring = "select * from tblTickerSymbols";


            using (SqlConnection openCon = new SqlConnection(connectionString))
            {
                openCon.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlstring, openCon);

                DataTable dataTable = new DataTable();

                dataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(dataTable);
                cbxTicker.Items.Clear();
                lbxAvailableTickers.Items.Clear();
                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    cbxTicker.Items.Add(dataTable.Rows[j]["ISIN"] + " - " + dataTable.Rows[j]["StockName"]);
                    lbxAvailableTickers.Items.Add(dataTable.Rows[j]["ISIN"] + " - " + dataTable.Rows[j]["StockName"]);
                }
                openCon.Close();
            }
        }

        private int GetTickerID(string _isin)
        {
            int result = -1;

            try
            {

                string sqlstring = string.Format("select [id] from tblTickerSymbols where isin = '{0}'", _isin.Trim().ToUpper());


                using (SqlConnection openCon = new SqlConnection(connectionString))
                {
                    openCon.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlstring, openCon);

                    DataTable dataTable = new DataTable();

                    dataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        for (int j = 0; j < dataTable.Rows.Count; j++)
                        {
                            result = Convert.ToInt16(dataTable.Rows[j]["id"]);
                        }
                    }
                    openCon.Close();
                }
            }
            catch (Exception ex)
            {
                result = -1;
            }
            return result;
        }





        private void LoadSelectedAutoUpdateTickers()
        {
            try
            {
                //    string sqlstring = "select * from [tblAutoUpdateTickers]";
                string sqlstring = "select aut.tickerid, aut.updatefrequency, aut.datasource, ts.isin, ts.stockname from  tblautoupdatetickers aut, tbltickersymbols ts where ts.id = aut.tickerid";
                lbxAddedTickers.Items.Clear();
                using (SqlConnection openCon = new SqlConnection(connectionString))
                {
                    openCon.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlstring, openCon);

                    DataTable dataTable = new DataTable();

                    dataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(dataTable);

                    for (int j = 0; j < dataTable.Rows.Count; j++)
                    {
                        lbxAddedTickers.Items.Add(dataTable.Rows[j]["tickerid"] + " " + dataTable.Rows[j]["ISIN"] + " " + dataTable.Rows[j]["StockName"]);
                    }
                    openCon.Close();

                }
            }
            catch (Exception ex)
            {
                AddMessage("error load autoupdateticker:" + ex.Message, "Error");

                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }

        private void btnNewTicker_Click_1(object sender, EventArgs e)
        {
            InsertNewTicker();
        }

        public string InsertNewTicker()
        {
            SqlCommand command = null;
            SqlConnection _sqlcon = null;
            string result = string.Empty;
            try
            {
                _sqlcon = new SqlConnection(connectionString);



                string commandText =
     string.Concat(
         "insert into tbltickersymbols(StockName, ISIN, TYPE, Exchange, Industry) Values('",
         tbxStockName.Text.Trim().ToString(), "','",
         tbxISIN.Text.Trim().ToUpper(), "', '",
         tbxType.Text.Trim(), "' , '",
         tbxExchange.Text.Trim(), "', '",
         tbxIndustry.Text.Trim().ToString(), "')");

                command = new SqlCommand(commandText, _sqlcon);
                _sqlcon.Open();
                command.ExecuteNonQuery();
                _sqlcon.Close();
                result = "Inserted OK";
            }
            catch (Exception ex)
            {
                AddMessage("error inserting new ticker:" + ex.Message, "Error");
                System.Diagnostics.Debug.WriteLine(ex.Message);
                result = ex.Message;
            }
            finally
            {
                command.Dispose();
                _sqlcon.Dispose();



            }
            return result;
        }



        /// <summary>
        /// voegt een record to in tblautoupdatetickers
        /// </summary>
        /// <returns></returns>
        public string AddAutoTicker()
        {
            SqlCommand command = null;
            SqlConnection _sqlcon = null;
            string result = string.Empty;
            try
            {
                string[] tickerdata = lbxAvailableTickers.Text.Split('-');

                int tickerID = GetTickerID(tickerdata[0]);
                _sqlcon = new SqlConnection(connectionString);
                string commandText =
     string.Concat(
         "insert into tblAutoUpdatetickers(tickerid, updatefrequency, datasource) Values(",
         tickerID,
               ", '", cbxUpdateInterval.Text.Trim().ToUpper(), "', '",
               tbxDataSource.Text.Trim(), "')");

                command = new SqlCommand(commandText, _sqlcon);
                _sqlcon.Open();
                command.ExecuteNonQuery();
                _sqlcon.Close();
                result = "Inserted OK";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                AddMessage("error adding auto ticker", "Error");

                result = ex.Message;
            }
            finally
            {
                command.Dispose();
                _sqlcon.Dispose();
            }
            return result;
        }


        private void ucInsertData_Load(object sender, EventArgs e)
        {
            cbxDataFormat.SelectedIndex = 0;
            cbxDataFormatTickers.SelectedIndex = 0;
            LoadTickers();
            LoadSelectedAutoUpdateTickers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAutoTicker();
        }

        private void btnInsertTickers_Click(object sender, EventArgs e)
        {

            ImportTickers();
        }

        private void ucInsertData_Enter(object sender, EventArgs e)
        {

        }

        private void ucInsertData_VisibleChanged(object sender, EventArgs e)
        {
            AddMessage("Entered InsertData tab", "Mededeling");

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
