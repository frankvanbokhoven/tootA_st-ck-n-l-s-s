using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockData
{
    public class SplitInfo
    {
        string _symbol = String.Empty;
        Decimal _ratio; // Two for one would be 2.0.  3 for 2 would be 1.5.  2 for 1 reverse split would be 0.5.
        DateTime _date;
        int _numerator;
        int _denominator;

        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        public Decimal Ratio
        {
            get { return ((Decimal)_numerator / (Decimal)_denominator); }
        }

        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }

        public int Denominator
        {
            get { return _denominator; }
            set { _denominator = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}
