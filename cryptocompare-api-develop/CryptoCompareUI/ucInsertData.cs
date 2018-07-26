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
        public FrmUIMain frmuimain;

        public ucInsertData()
        {
            InitializeComponent();
        }

        private void btnInsertCSV_Click(object sender, EventArgs e)
        {
            ImportCSVData(1);
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
                        foreach (string regel in csvdata)
                        {
                            if (i > 0 && i < csvdata.Count)
                            {
                                string[] splitstring = regel.Split(',');
                                sqlstring = string.Format(@" INSERT  into tblTickerData (TickerId,[Date],OpenPrice, HighPrice,LowPrice,ClosePrice,Adjusted_ClosePrice,Volume) values({0}, Convert(datetime, {1}), {2}, {3}, {4}, {5}, {6}, {7} );", _tickerID, splitstring[0], splitstring[1], splitstring[2], splitstring[3], splitstring[4], splitstring[5], splitstring[6]);
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
                        progressBarTickers.Minimum = 0;
                        progressBarTickers.Maximum = csvdata.Count;
                        lblprogress.Visible = true;
                        string[] splitnameandtype;
                        string sqlstring;
                        foreach (string regel in csvdata)
                        {
                            if (i > 0 && i < csvdata.Count)
                            {
                                string[] splitstring = regel.Split('|');

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
                                //   lblprogress.Text = i.ToString() + "/" + csvdata.Count.ToString();
                                Application.DoEvents();
                            }
                            i++;
                        }
                        MessageBox.Show("Imported successfully: " + i + "tickers");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        progressBarTickers.Visible = false;
                        this.Cursor = Cursors.Default;
                        //  lblprogress.Visible = false;
                    }
                    _sqlcon.Close();
                    result = "Ticker import successfull";
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    result = ex.Message;
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
                    cbxTicker.Items.Add(dataTable.Rows[j]["StockName"]);
                    lbxAvailableTickers.Items.Add(dataTable.Rows[j]["StockName"]);
                }
                openCon.Close();
            }
        }

        private void LoadSelectedAutoUpdateTickers()
        {
            try
            {
                //    string sqlstring = "select * from [tblAutoUpdateTickers]";
                string sqlstring = "select aut.tickerid, aut.updatefrequency, aut.datasource, ts.isin, ts.stockname from  tblautoupdatetickers aut, tbltickersymbols ts where ts.id = aut.tickerid";

                using (SqlConnection openCon = new SqlConnection(connectionString))
                {
                    openCon.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlstring, openCon);

                    DataTable dataTable = new DataTable();

                    dataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(dataTable);
                    lbxAddedTickers.Items.Clear();
                    for (int j = 0; j < dataTable.Rows.Count; j++)
                    {
                        lbxAddedTickers.Items.Add(dataTable.Rows[j]["tickerid"] + " " + dataTable.Rows[j]["ISIN"] + " " + dataTable.Rows[j]["StockName"]);


                    }
                    openCon.Close();

                }
            }
            catch (Exception ex)
            {
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
                _sqlcon = new SqlConnection(connectionString);
                string commandText =
     string.Concat(
         "insert into tblAutoUpdatetickers(tickerid, updatefrequency, datasource) Values('",
         lblTickerID.Text.Trim().ToString(), "','",
         cbxUpdateInterval.Text.Trim().ToUpper(), "', '",
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
    }
}
