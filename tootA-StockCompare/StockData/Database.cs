using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace StockData
{
    public class Database
    {
        public static SqlConnection Connect()
        {
            // Create and open the connection
            SqlConnection conn =
               new SqlConnection("Data Source=JCHAMPION-LT\\SQLEXPRESS2008;"
                  + "Initial Catalog=StockPrices;"
                  + "Persist Security Info=True;"
                  + "trusted_connection=True"
                  );

            conn.Open();
            return conn;
        }

        public static List<String> GetSymbolList(SqlConnection conn)
        {
            // create a SqlCommand object for this connection
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT DISTINCT Symbol FROM Prices";
            command.CommandType = System.Data.CommandType.Text;

            // execute the command that returns a SqlDataReader
            SqlDataReader reader = command.ExecuteReader();

            List<String> stockSymbols = new List<String>();
            // display the results
            while (reader.Read())
            {
                stockSymbols.Add(((String)reader["Symbol"]).Trim());
            }
            reader.Close();
            return stockSymbols;
        }
    }
}
