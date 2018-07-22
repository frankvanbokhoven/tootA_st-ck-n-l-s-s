﻿using System;
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
      private  string connectionString = ConfigurationSettings.AppSettings["DBConnectionString"];
        public FrmUIMain frmuimain;

        public ucInsertData()
        {
            InitializeComponent();
        }

        private void btnInsertCSV_Click(object sender, EventArgs e)
        {
           ImportCSVData(1);
        }

        private void BulkImportCSVData(int _tickerID)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*csv file |*.csv";
            ofd.Title = "Select csv file";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sqlstring = string.Format(@" BULK INSERT tblTickerData FROM '{0}', Tickerid = {1}  WITH ( FirstRow = 2,  FIELDTERMINATOR = ',', ROWTERMINATOR = '\n',   ERRORFILE = 'C:\temp\ErrorRows.csv', TABLOCK );", ofd.FileName, _tickerID);

                SqlCommand command = null;
                SqlConnection _sqlcon = null;
                string result = string.Empty;
                try
                {
                    _sqlcon = new SqlConnection(connectionString);

         
           
                    command = new SqlCommand(sqlstring, _sqlcon);
                    _sqlcon.Open();
                    command.ExecuteNonQuery();
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
                    command.Dispose();
                    _sqlcon.Dispose();

                }


                using (SqlConnection openCon = new SqlConnection(connectionString))
                {

                    using (SqlCommand querySaveStaff = new SqlCommand(sqlstring))
                    {
                        querySaveStaff.Connection = openCon;
                        //     querySaveStaff.Parameters.Add("@staffName", SqlDbType.VarChar, 30).Value = name;
                        /// .....
                        openCon.Open();

                    }
                }
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
                       
                        foreach(string regel in csvdata)
                        {
                            if (i > 0 && i < csvdata.Count)
                            {
                                string[] splitstring = regel.Split(',');
                                string sqlstring = string.Format(@" INSERT  into tblTickerData (TickerId,[Date],OpenPrice, HighPrice,LowPrice,ClosePrice,Adjusted_ClosePrice,Volume) values({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7} );", _tickerID, splitstring[0], splitstring[1], splitstring[2], splitstring[3], splitstring[4], splitstring[5], splitstring[6]);
                                command = new SqlCommand(sqlstring, _sqlcon);
                                command.ExecuteNonQuery();
                                command.Dispose();
                            
                            }
                            i++;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        //throw;
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
                    MessageBox.Show("Imported successfully: " + i + "rows");
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
                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    cbxTicker.Items.Add(dataTable.Rows[j]["StockName"]);
                }
                openCon.Close();
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
         tbxStockName.Text.Trim(). ToString(), "','",
         tbxISIN.Text.Trim().ToUpper(), "', '",
         tbxType.Text.Trim(), "' , '",//todo: klopt éigenlijk niet, want eigenlijk de éérste startup tijd moet gelogd worden.
         tbxExchange.Text.Trim(), "', '",
         tbxIndustry.Text.Trim().ToString(),  "')");

                //string insertstring =
                //    string.Concat("DECLARE @DATUM DATETIME SET @DATUM = CONVERT(DATETIME, FLOOR(CONVERT(FLOAT, GETDATE()))) IF NOT EXISTS (SELECT * FROM [tblUsagesPerDate] WHERE [DATUM] = @DATUM AND (USERID = ", userid.ToString(), ")) INSERT INTO [tblUsagesPerDate] ([Datum],[MonitorTime],[UserID], [SavingsTime], [IdleTime], [KWH],[Carbon],[Euro],[SaveSetting],[KWHHardware],[KWHProcess],[KWHUserIdle],[KWHHardwareSaved],[KWHProcessSaved],[KWHUserIdleSaved])",
                //                  " VALUES(@DATUM, ",//  date.ToString(),
                //                  pueFields.MonitorTime.ToString(),
                //                  ",",
                //                  userid.ToString(),
                //                  ",",
                //                  pueFields.SavingsTime.ToString(),
                //                  ",",
                //                  pueFields.IdleTime.ToString(),
                //                  ",",
                //                  pueFields.KWH.ToString(),
                //                  ",",
                //                  pueFields.Carbon.ToString(),
                //                  ",",
                //                  pueFields.Euro.ToString(),
                //                  ",",
                //                  pueFields.SaveSetting.ToString(),
                //                  ",",
                //                  pueFields.KWHHardware.ToString(),
                //                  ",",
                //                  pueFields.KWHProcess.ToString(),
                //                  ",",
                //                  pueFields.KWHUserIdle.ToString(),
                //                  ",",
                //                  pueFields.KWHHardwareSaved.ToString(),
                //                  ",",
                //                  pueFields.KWHProcessSaved.ToString(),
                //                  ",",
                //                  pueFields.KWHUserIdleSaved.ToString(),
                //                  ")");
                //insertstring += string.Concat(" ELSE UPDATE [tblUsagesPerDate] SET [MONITORTIME] = [MONITORTIME] + '", pueFields.MonitorTime.ToString(),
                //    "', [SavingsTime] = [SavingsTime] + '", pueFields.SavingsTime.ToString(), "', userid = '", userid.ToString(), "' WHERE ([DATUM] = @DATUM) and (USERID = ", userid.ToString(), ")");


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
            LoadTickers();
        }
    }
}
