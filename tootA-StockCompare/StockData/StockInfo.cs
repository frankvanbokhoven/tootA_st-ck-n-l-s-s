using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockData
{
    public class StockInfo : IComparable
    {
        public String Symbol;
        public DateTime Date;
        public Decimal OpeningPrice;
        public Decimal ClosingPrice;
        public Decimal DailyHigh;
        public Decimal DailyLow;
        public Decimal AdjustedClose;
        public Int64 Volume;

        public int CompareTo(object obj)
        {
            if (obj is StockInfo)
            {
                StockInfo other = (StockInfo)obj;
                return this.Date.CompareTo(other.Date);
            }
            else
            {
                throw new ArgumentException("Object is not a StockInfo");
            }
        }

        public static List<StockInfo> ParseData(System.IO.TextReader file, String symbol)
        {
            // Yoink header info and validate.
            String header = file.ReadLine();
            String[] headerPieces = header.Split(',');
            if (headerPieces.Length < 5)
            {
                return null;
            }

            // Process file contents.
            String line = String.Empty;
            List<StockInfo> stockInfo = new List<StockInfo>();
            while (line != null)
            {
                line = file.ReadLine();
                if (line != null)
                {
                    StockInfo info = StockData.StockInfo.ParseLine(line, symbol);
                    // We can get nulls back if the data is invalid, or if the volume is
                    // zero.  Google posts prices on non-trading days with a volume of
                    // zero and this is data we can safely discard.
                    if (info != null)
                    {
                        stockInfo.Add(info);
                    }
                }
            }
            file.Close();
            return stockInfo;
        }


        public static StockInfo ParseLine(string line, string symbol)
        {
            string[] pieces = line.Split(',');
            if (pieces.Length > 5)
            {
                StockInfo info = new StockInfo();
                info.Date = DateTime.Parse(pieces[0]);
                info.OpeningPrice = Decimal.Parse(pieces[1]);
                info.DailyHigh = Decimal.Parse(pieces[2]);
                info.DailyLow = Decimal.Parse(pieces[3]);
                info.ClosingPrice = Decimal.Parse(pieces[4]);
                info.Volume = Int64.Parse(pieces[5]);
                if (info.Volume == 0)
                {
                    // Google includes data for days when trading didn't occur.
                    // We discard that as an invalid entry -- when the markets are
                    // closed we don't care what happened.
                    return null;
                }
                // Adjusted close is optional.  Yahoo data has it and Google doesn't.
                if (pieces.Length > 6)
                {
                    info.AdjustedClose = Decimal.Parse(pieces[6]);
                }
                info.Symbol = symbol;
                return info;
            }
            return null;
        }

    }
}