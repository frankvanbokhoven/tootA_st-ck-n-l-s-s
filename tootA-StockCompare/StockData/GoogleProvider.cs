using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace StockData
{
    public class GoogleProvider
    {
        public static List<StockInfo> GetHistoricalData(DateTime startDate, DateTime endDate, String ticker)
        {
            if (endDate < startDate)
            {
                return null;
            }
            string url = String.Format("http://finance.google.com/finance/historical?q=NASDAQ:MSFT&output=csv",
                ticker, (endDate.Month - 1), endDate.Day, endDate.Year,
                (startDate.Month - 1), startDate.Day, startDate.Year);
            WebClient web = new WebClient();
            string data;
            try
            {
                data = web.DownloadString(url);
            }
            catch (WebException ex)
            {
                // Ignore invalid ticker symbols.
                return null;
            }

            System.IO.StringReader stringreader = new System.IO.StringReader(data);
            List<StockInfo> stockInfo = StockData.StockInfo.ParseData(stringreader, ticker);
            return stockInfo;
        }

        public static SymbolData GetSymbolData(String symbol)
        {
            throw new NotSupportedException("The Google stock provider does not support symbol data lookup.");
        }

        public static List<DividendInfo> GetDividends(DateTime startDate, DateTime endDate, String ticker)
        {
            throw new NotSupportedException("The Google stock provider does not historical dividend data.");
        }

        public static List<SplitInfo> GetSplits(DateTime startDate, DateTime endDate, String ticker)
        {
            throw new NotSupportedException("The Google stock provider does not support historical split data.");
        }
    }
}
