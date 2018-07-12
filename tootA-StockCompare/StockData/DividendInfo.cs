using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockData
{
    public class DividendInfo
    {
        string _symbol = String.Empty;
        Decimal _amount;
        DateTime _date;

        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        public Decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public static List<DividendInfo> ParseData(System.IO.TextReader file, String symbol)
        {
            // Yoink header info and validate.
            String header = file.ReadLine();
            String[] headerPieces = header.Split(',');
            if (headerPieces.Length < 2)
            {
                return null;
            }

            // Process file contents.
            String line = String.Empty;
            List<DividendInfo> dividendInfo = new List<DividendInfo>();
            while (line != null)
            {
                line = file.ReadLine();
                if (line != null)
                {
                    DividendInfo info = StockData.DividendInfo.ParseLine(line, symbol);
                    // We can get nulls back if the data is invalid, or if the volume is
                    // zero.  Google posts prices on non-trading days with a volume of
                    // zero and this is data we can safely discard.
                    if (info != null)
                    {
                        dividendInfo.Add(info);
                    }
                }
            }
            file.Close();
            return dividendInfo;
        }

        public static DividendInfo ParseLine(string line, string symbol)
        {
            string[] pieces = line.Split(',');
            if (pieces.Length > 1)
            {
                DividendInfo info = new DividendInfo();
                info.Date = DateTime.Parse(pieces[0]);
                info.Amount = Decimal.Parse(pieces[1]);
                info.Symbol = symbol;
                return info;
            }
            return null;
        }
    }
}
