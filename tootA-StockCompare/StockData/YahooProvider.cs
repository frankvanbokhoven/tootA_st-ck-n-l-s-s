using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
namespace StockData
{//WWW.EODHISTORICALDATA.COM

    public class YahooProvider
    {
        public static List<StockInfo> GetHistoricalData(DateTime startDate, DateTime endDate, String ticker)
        {
            if (endDate < startDate)
            {
                return null;
            }
            string url = String.Format("http://ichart.finance.yahoo.com/table.csv?s={0}&a={4:00}&b={5:00}&c={6}&d={1:00}&e={2:00}&f={3}&g=d&ignore=.csv",
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
            string url = string.Format("http://finance.yahoo.com/d/quotes.csv?s={0}&f=snx&e=.csv", symbol);
            WebClient web = new WebClient();
            string data = web.DownloadString(url);
            data = data.Replace("\"", "");
            data = data.Replace(", Inc", " Inc");
            data = data.Replace(", Ltd", " Ltd");
            string[] pieces = data.Split(',');
            // Check for bad data.
            if (pieces.Length < 3)
            {
                return null;
            }
            if (pieces.Length == 4)
            {
                // Bad data, must have had a stray comma in the company name.
                pieces[2] = pieces[3];
            }
            else if (pieces.Length > 4)
            {
                return null;
            }
            pieces[1] = pieces[1].Replace("'", "''");
            pieces[2] = pieces[2].Replace("\n", "");
            pieces[2] = pieces[2].Replace("\r", "");

            SymbolData sym = new SymbolData();
            sym.Exchange = pieces[2];
            sym.CompanyName = pieces[1];
            sym.YahooSymbol = pieces[0].ToUpper();
            return sym;
        }

        public static List<DividendInfo> GetDividends(DateTime startDate, DateTime endDate, String ticker)
        {
            if (endDate < startDate)
            {
                return null;
            }
            // Example URL: http://table.finance.yahoo.com/table.csv?s=IBM&a=00&b=2&c=1800&d=04&e=8&f=2005&g=v&ignore=.csv
            string url = String.Format("http://table.finance.yahoo.com/table.csv?s={0}&a={1}&b={2}&c={3}&d={4}&e={5}&f={6}&g=v&ignore=.csv",
                ticker, (startDate.Month - 1), startDate.Day, startDate.Year,
                (endDate.Month - 1), endDate.Day, endDate.Year);
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
            List<DividendInfo> dividendInfo = StockData.DividendInfo.ParseData(stringreader, ticker);
            return dividendInfo;

            // Returns CSV data formatted like so:
            //
            // Date 	    Dividends
            // 5/6/2005	    0.2
            // 2/8/2005	    0.18
            // 11/8/2004	0.18
        }

        public static List<SplitInfo> GetSplits(DateTime startDate, DateTime endDate, String ticker)
        {
            if (endDate < startDate)
            {
                return null;
            }
            ticker = ticker.ToUpper();
            // Example URL: http://finance.yahoo.com/q/bc?s=IBM&t=my
            string url = String.Format("http://finance.yahoo.com/q/bc?s={0}&t=my", ticker);
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
            // Get the chunk of data we want.
            int i = data.IndexOf("Splits:");
            data = data.Substring(i+7);
            i = data.IndexOf("</table>");
            data = data.Substring(0, i);
            // Remove various HTML tags.
            data = data.Replace("</nobr>", "");
            data = data.Replace("<nobr>", "");
            data = data.Replace("</center>", "");
            data = data.Replace("</td>", "");
            data = data.Replace("</tr>", "");

            String[] pieces = data.Split(',');
            List<SplitInfo> splitInfo = new List<SplitInfo>();
            try
            {
                foreach (String str in pieces)
                {
                    String[] subPieces = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (subPieces.Length > 1)
                    {
                        SplitInfo info = new SplitInfo();
                        info.Date = DateTime.Parse(subPieces[0]);
                        info.Symbol = ticker;
                        info.Numerator = 1;
                        info.Denominator = 1;
                        subPieces[1] = subPieces[1].Replace("[", "");
                        subPieces[1] = subPieces[1].Replace("]", "");
                        string[] ratioPieces = subPieces[1].Split(':');
                        if (ratioPieces.Length > 1)
                        {
                            info.Numerator = Int32.Parse(ratioPieces[0]);
                            info.Denominator = Int32.Parse(ratioPieces[1]);
                        }
                        splitInfo.Add(info);
                    }
                }
            }
            catch (Exception)
            {
            }
            return splitInfo;
        }
    }
}
