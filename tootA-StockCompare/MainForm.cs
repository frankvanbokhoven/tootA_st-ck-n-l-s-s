using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockData;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;

namespace ChampionCharts
{
    public partial class MainForm : Form
    {
        private Settings _settings;
        List<StockInfo> _stockData = new List<StockInfo>();
        List<DividendInfo> _dividendData = new List<DividendInfo>();
        List<SplitInfo> _splitData = new List<SplitInfo>();
        private PageSettings _pageSettings = new PageSettings();

        public MainForm()
        {
            InitializeComponent();

            // Perform any necessary control setup.
            foreach (String type in Enum.GetNames(typeof(ChartType)))
            {
                cbChartType.Items.Add(type);
            }

            Margins margins = new Margins(75, 75, 75, 75);
            _pageSettings.Margins = margins;

            // Initialize dialog settings.
            _settings = Settings.Load();
            if (_settings == null)
            {
                _settings = new Settings();
            }
            hideWeekendsToolStripMenuItem.Checked = _settings.HideWeekends;
            showVolumeToolStripMenuItem.Checked = _settings.HideWeekends;
            showDividendsToolStripMenuItem.Checked = _settings.ShowDividends;
            showSplitsToolStripMenuItem.Checked = _settings.ShowSplits;
            roundScalingToolStripMenuItem.Checked = _settings.RoundScaling;
            antiAliasingToolStripMenuItem.Checked = _settings.AntiAliasing;
            cbChartType.SelectedIndex = 0;
            lblLength.Text = _settings.NumDays.ToString() + " Days";
            tbTimeSlider.Value = Math.Min(tbTimeSlider.Maximum, _settings.NumDays);
            btnDatabase.Visible = false;
            pnlGraph.BackColor = _settings.BackgroundColor;
            pnlVolume.BackColor = _settings.BackgroundColor;
            if (_settings.MovingAverageDays == 10)
                tenDayToolStripMenuItem.Checked = true;
            else if (_settings.MovingAverageDays == 20)
                twentyDayToolStripMenuItem.Checked = true;
            else if (_settings.MovingAverageDays == 30)
                thirtyDayToolStripMenuItem.Checked = true;
            else if (_settings.MovingAverageDays == 50)
                fiftyDayToolStripMenuItem.Checked = true;
            else if (_settings.MovingAverageDays == 100)
                hundredDayToolStripMenuItem.Checked = true;
            else if (_settings.ExponentialMovingAverageDays == 10)
                tenDayEMAToolStripMenuItem.Checked = true;
            else if (_settings.ExponentialMovingAverageDays == 20)
                twentyDayToolStripMenuItem.Checked = true;
            else if (_settings.ExponentialMovingAverageDays == 50)
                fiftyDayEMAToolStripMenuItem.Checked = true;
            else
                hideMovingAverageToolStripMenuItem.Checked = true;

            // Add size handler.
            this.SizeChanged += new EventHandler(OnSizeChanged);
        }

        void OnSizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width > 67 && this.Size.Height > 241)
            {
                pnlGraph.Size = new Size(this.Size.Width - 67, this.Size.Height - 241);
                pnlVolume.Location = new Point(5, this.Size.Height - 109);
                pnlVolume.Size = new Size(this.Size.Width - 67, 60 );
                lblEarliest.Location = new Point(5, this.Size.Height - 127);
                lblMidpoint.Location = new Point((this.Size.Width / 2) - 45, this.Size.Height - 127);
                lblLatest.Location = new Point(this.Size.Width - 108, this.Size.Height - 127);
                lblVolMin.Location = new Point(this.Size.Width - 55, this.Size.Height - 61);
                lblVolMax.Location = new Point(this.Size.Width - 55, this.Size.Height - 111);
                tbTimeSlider.Location = new Point(465, 23);
                tbTimeSlider.Width = (this.Size.Width - 485);
            }
            Invalidate();
            Refresh();
        }

        private void btn5D_Click(object sender, EventArgs e)
        {
            _settings.NumDays = 7;
            tbTimeSlider.Value = 7;
            lblLength.Text = "1 Week";
            Invalidate();
            Refresh();
        }

        private void btn1M_Click(object sender, EventArgs e)
        {
            _settings.NumDays = 30;
            tbTimeSlider.Value = 30;
            lblLength.Text = "1 Month";
            Invalidate();
            Refresh();
        }

        private void btn2M_Click(object sender, EventArgs e)
        {
            _settings.NumDays = 60;
            tbTimeSlider.Value = 60;
            lblLength.Text = "2 Months";
            Invalidate();
            Refresh();
        }

        private void btn3M_Click(object sender, EventArgs e)
        {
            _settings.NumDays = 90;
            tbTimeSlider.Value = 90;
            lblLength.Text = "3 Months";
            Invalidate();
            Refresh();
        }

        private void btn6M_Click(object sender, EventArgs e)
        {
            _settings.NumDays = 180;
            tbTimeSlider.Value = 180;
            lblLength.Text = "6 Months";
            Invalidate();
            Refresh();
        }

        private void btn1Y_Click(object sender, EventArgs e)
        {
            _settings.NumDays = 365;
            tbTimeSlider.Value = 365;
            lblLength.Text = "1 Year";
            Invalidate();
            Refresh();
        }

        private void btn2Y_Click(object sender, EventArgs e)
        {
            _settings.NumDays = 730;
            tbTimeSlider.Value = tbTimeSlider.Maximum;
            lblLength.Text = "2 Years";
            Invalidate();
            Refresh();
        }

        private void btn3Y_Click(object sender, EventArgs e)
        {
            _settings.NumDays = 1095;
            tbTimeSlider.Value = tbTimeSlider.Maximum;
            lblLength.Text = "3 Years";
            Invalidate();
            Refresh();
        }

        private void btn5Y_Click(object sender, EventArgs e)
        {
            _settings.NumDays = 1825;
            tbTimeSlider.Value = tbTimeSlider.Maximum;
            lblLength.Text = "5 Years";
            Invalidate();
            Refresh();
        }

        private void btn10Y_Click(object sender, EventArgs e)
        {
            _settings.NumDays = 3650;
            tbTimeSlider.Value = tbTimeSlider.Maximum;
            lblLength.Text = "10 Years";
            Invalidate();
            Refresh();
        }

        private void pnlGraph_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Bitmap bitmap = new Bitmap(pnlGraph.Width, pnlGraph.Height);
            Graphics g = Graphics.FromImage(bitmap);
            if (_settings.AntiAliasing)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
            else
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            }
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            RenderGraphics(g, false);
            e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
            g.Dispose();
            bitmap.Dispose();
        }

        private void RenderDividends(Graphics dc, DateTime earliest, Decimal xScale)
        {
            if (_dividendData == null || _dividendData.Count == 0 || _settings.ShowDividends == false)
            {
                return;
            }

            int current;
            SolidBrush brush = new SolidBrush(_settings.ForegroundColor);
            Pen pen = new Pen(_settings.ForegroundColor);
            foreach (DividendInfo info in _dividendData)
            {
                if (info.Date >= earliest)
                {
                    if (hideWeekendsToolStripMenuItem.Checked == true)
                    {
                        current = (int)(GetNumberOfWeekdays(earliest, info.Date) * xScale);
                    }
                    else
                    {
                        current = (int)((info.Date - earliest).Days * xScale);
                    }
                    dc.DrawString(String.Format("${0:0.00}", info.Amount), new Font("Arial", 8), brush, new Point((current - 14), (int)dc.VisibleClipBounds.Height - 15));
                    dc.DrawEllipse(pen, current, ((int)dc.VisibleClipBounds.Height - 20), 3, 3);
                }
            }
            pen.Dispose();
            brush.Dispose();
        }


        private void RenderSplits(Graphics dc, DateTime earliest, Decimal xScale)
        {
            if (_splitData == null || _splitData.Count == 0 || _settings.ShowSplits == false)
            {
                return;
            }

            int current;
            SolidBrush pen = new SolidBrush(_settings.IndicatorColor);
            foreach (SplitInfo info in _splitData)
            {
                if (info.Date >= earliest)
                {
                    if (hideWeekendsToolStripMenuItem.Checked == true)
                    {
                        current = (int)(GetNumberOfWeekdays(earliest, info.Date) * xScale);
                    }
                    else
                    {
                        current = (int)((info.Date - earliest).Days * xScale);
                    }
                    int triangleSize = 4;
                    if (info.Ratio > 1.0M)
                    {
                        dc.FillPolygon(pen, new Point[] { new Point(current, (triangleSize * 2)), new Point(current - triangleSize, (triangleSize)), new Point(current + triangleSize, (triangleSize)) });
                    }
                    else
                    {
                        dc.FillPolygon(pen, new Point[] { new Point(current, (triangleSize)), new Point(current - triangleSize, (triangleSize * 2)), new Point(current + triangleSize, (triangleSize * 2)) });
                    }

                    //System.Drawing.Drawing2D.GraphicsPath textPath = new System.Drawing.Drawing2D.GraphicsPath();

                    //textPath.AddString(string.Format("{0}:{1}", info.Numerator, info.Denominator), 
                    //    new FontFamily("Arial"), (int)FontStyle.Regular, 10,
                    //    new Point(current - 14, triangleSize * 3), StringFormat.GenericDefault);

                    //dc.FillPath(pen, textPath);

                    dc.DrawString(string.Format("{0}:{1}", info.Numerator, info.Denominator), new Font("Arial", 10), pen, new Point(current - 14, triangleSize * 3));
                }
            }
        }

        private void RenderVolume(Graphics dc, bool printing)
        {
            if (_stockData == null || _stockData.Count < 1)
            {
                return;
            }
            Decimal xScale = CalculateXScale(dc);
            DateTime earliest = DateTime.Now - TimeSpan.FromDays(_settings.NumDays);
            decimal volMin = Int32.MaxValue;
            decimal volMax = Int32.MinValue;
            foreach (StockInfo stock in _stockData)
            {
                if (stock.Date >= earliest)
                {
                    if (stock.Volume < volMin)
                    {
                        volMin = stock.Volume;
                    }
                    if (stock.Volume > volMax)
                    {
                        volMax = stock.Volume;
                    }
                }
            }
            decimal volScale = CalculateYScale(dc, volMax, volMin);
            int current;
            Pen foregroundPen = new Pen(_settings.ForegroundColor, 2);
            foreach (StockInfo stock in _stockData)
            {
                if (stock.Date >= earliest)
                {
                    if (hideWeekendsToolStripMenuItem.Checked == true)
                    {
                        current = (int)((Decimal)(GetNumberOfWeekdays(earliest, stock.Date)) * xScale);
                    }
                    else
                    {
                        current = (int)((Decimal)((stock.Date - earliest).Days) * xScale);
                    }
                    dc.DrawLine(foregroundPen, current, (int)((Decimal)dc.VisibleClipBounds.Height - ((decimal)stock.Volume - (Decimal)volMin) * volScale), current, (int)dc.VisibleClipBounds.Height);
                }
            }
            foregroundPen.Dispose();
            lblVolMin.Text = FormatVolume(volMin);
            lblVolMax.Text = FormatVolume(volMax);
        }

        private string FormatVolume(decimal value)
        {
            if (value < 1000.0M)
            {
                return ((int)value).ToString();
            }
            if (value < 1000000.0M)
            {
                return (((int)value) / 1000).ToString() + "K";
            }
            return (((int)value) / 1000000).ToString() + "M";
        }

        private int CalculateCandleWidth()
        {
            int candleWidth = 3;
            if (_settings.NumDays >= 180)
            {
                candleWidth = 1;
            }
            else if (_settings.NumDays >= 90)
            {
                candleWidth = 2;
            }
            return candleWidth;
        }

        private Decimal CalculateXScale(Graphics dc)
        {
            decimal xScale;
            DateTime earliest = DateTime.Now - TimeSpan.FromDays(_settings.NumDays);
            if (hideWeekendsToolStripMenuItem.Checked == true)
            {
                xScale = (((decimal)dc.VisibleClipBounds.Width - 5.0M) / (decimal)(GetNumberOfWeekdays(earliest, DateTime.Now)));
            }
            else
            {
                xScale = (((decimal)dc.VisibleClipBounds.Width - 5.0M) / (decimal)_settings.NumDays);
            }
            return xScale;
        }

        private Decimal CalculateYScale(Graphics dc, Decimal yMax, Decimal yMin)
        {
            Decimal yScale = (((decimal)dc.VisibleClipBounds.Height - 4.0M) / (decimal)(yMax - yMin));
            return yScale;
        }

        private void RenderDates()
        {
            DateTime earliest = DateTime.Now - TimeSpan.FromDays(_settings.NumDays);
            lblEarliest.Text = earliest.ToShortDateString();
            lblLatest.Text = DateTime.Now.ToShortDateString();
            lblMidpoint.Text = (DateTime.Now - TimeSpan.FromDays(_settings.NumDays / 2)).ToShortDateString();
        }

        private void RenderGraphics(Graphics dc, bool printing)
        {
            if (_stockData == null || _stockData.Count < 1)
            {
                return;
            }
            DateTime earliest = DateTime.Now - TimeSpan.FromDays(_settings.NumDays);
            decimal yMin = Int32.MaxValue;
            decimal yMax = Int32.MinValue;

            // Restrict to data we're actually going to render.
            List<StockInfo> renderedData = new List<StockInfo>();

            foreach (StockInfo stock in _stockData)
            {
                if (stock.Date >= earliest)
                {
                    renderedData.Add(stock);
                    if (_settings.ChartTypeSetting == ChartType.Line)
                    {
                        // Line chart, X-Y uses closing price for day.
                        if (stock.ClosingPrice < yMin)
                        {
                            yMin = stock.ClosingPrice;
                        }
                        else if (stock.ClosingPrice > yMax)
                        {
                            yMax = stock.ClosingPrice;
                        }
                    }
                    else
                    {
                        // Bar or candlestick chart, X-Y uses min/max for day.
                        if (stock.DailyLow < yMin)
                        {
                            yMin = stock.DailyLow;
                        }
                        else if (stock.DailyHigh > yMax)
                        {
                            yMax = stock.DailyHigh;
                        }
                    }
                }
            }
            // If the stock doesn't have enough volume or hasn't changed in a week, we won't be
            // able to render the graph.
            if (yMin >= yMax || renderedData.Count < 1)
            {
                return;
            }
            renderedData.Sort();
            decimal xScale = CalculateXScale(dc);
            decimal yScale = CalculateYScale(dc, yMax, yMin);
            RenderGuidelines(dc, yMin, yMax, printing);
            RenderDividends(dc, earliest, xScale);
            RenderSplits(dc, earliest, xScale);
            RenderDates();
            Point previous = new Point(-1, -1);
            Point previousAverage = new Point(-1, -1);
            Point current;
            Point currentAverage;
            Pen foregroundPen = new Pen(_settings.ForegroundColor, 2);
            SolidBrush foregroundBrush = new SolidBrush(_settings.ForegroundColor);

            foreach (StockInfo stock in renderedData)
            {
                int maxHeight = (int)dc.VisibleClipBounds.Height - 2;
                if (_settings.ChartTypeSetting == ChartType.Line)
                {
                    if (hideWeekendsToolStripMenuItem.Checked == true)
                    {
                        current = new Point((int)(GetNumberOfWeekdays(earliest, stock.Date) * xScale), (int)(maxHeight - ((stock.ClosingPrice - yMin) * yScale)));
                    }
                    else
                    {
                        current = new Point((int)((stock.Date - earliest).Days * xScale), (int)(maxHeight - ((stock.ClosingPrice - yMin) * yScale)));
                    }
                    if (previous.Y != -1 && previous.X != -1)
                    {
                        dc.DrawLine(foregroundPen, previous, current);
                    }
                    previous = current;
                }
                else if (_settings.ChartTypeSetting == ChartType.Bar)
                {
                    int numDays;
                    if (hideWeekendsToolStripMenuItem.Checked == true)
                    {
                        numDays = GetNumberOfWeekdays(earliest, stock.Date);
                    }
                    else
                    {
                        numDays = (stock.Date - earliest).Days;
                    }
                    dc.DrawLine(foregroundPen, new Point((int)(numDays * xScale), (int)(maxHeight - ((stock.DailyHigh - yMin) * yScale))),
                        new Point((int)(numDays * xScale), (int)(maxHeight - ((stock.DailyLow - yMin) * yScale))));
                    dc.DrawLine(foregroundPen, new Point((int)(numDays * xScale - 3), (int)(maxHeight - ((stock.OpeningPrice - yMin) * yScale))),
                        new Point((int)(numDays * xScale), (int)(maxHeight - ((stock.OpeningPrice - yMin) * yScale))));
                    dc.DrawLine(foregroundPen, new Point((int)(numDays * xScale), (int)(maxHeight - ((stock.ClosingPrice - yMin) * yScale))),
                        new Point((int)(numDays * xScale + 3), (int)(maxHeight - ((stock.ClosingPrice - yMin) * yScale))));
                }
                else if (_settings.ChartTypeSetting == ChartType.Candlestick)
                {
                    int candleWidth = CalculateCandleWidth();
                    int numDays;
                    if (hideWeekendsToolStripMenuItem.Checked == true)
                    {
                        numDays = GetNumberOfWeekdays(earliest, stock.Date);
                    }
                    else
                    {
                        numDays = (stock.Date - earliest).Days;
                    }
                    dc.DrawLine(foregroundPen, new Point((int)(numDays * xScale), (int)(maxHeight - ((stock.DailyHigh - yMin) * yScale))),
                        new Point((int)(numDays * xScale), (int)(maxHeight - ((stock.ClosingPrice - yMin) * yScale))));
                    dc.DrawLine(foregroundPen, new Point((int)(numDays * xScale), (int)(maxHeight - ((stock.DailyLow - yMin) * yScale))),
                        new Point((int)(numDays * xScale), (int)(maxHeight - ((stock.OpeningPrice - yMin) * yScale))));
                    // Handle the special case of a Doji, where the box would have a height of 0.
                    if ((Math.Abs(stock.ClosingPrice - stock.OpeningPrice) * yScale) < 1)
                    {
                        dc.DrawLine(foregroundPen, (int)(numDays * xScale - candleWidth - 1), (int)(maxHeight - ((stock.ClosingPrice - yMin) * yScale)),
                            (int)(numDays * xScale + candleWidth), (int)(maxHeight - ((stock.OpeningPrice - yMin) * yScale)));
                    }
                    // Open candle.
                    else if (stock.ClosingPrice > stock.OpeningPrice)
                    {
                        dc.DrawRectangle(foregroundPen, (int)(numDays * xScale - candleWidth - 1), (int)(maxHeight - ((stock.ClosingPrice - yMin) * yScale)), (candleWidth * 2 + 2),
                            (int)(((stock.ClosingPrice - stock.OpeningPrice) * yScale)));
                    }
                    // Shaded candle.
                    else
                    {
                        dc.FillRectangle(foregroundBrush, (int)(numDays * xScale - candleWidth - 1), (int)(maxHeight - ((stock.OpeningPrice - yMin) * yScale)), (candleWidth * 2 + 2),
                            (int)(((stock.OpeningPrice - stock.ClosingPrice) * yScale)));
                    }
                }
                // Draw moving average if enabled.
                if (_settings.MovingAverageDays > 0 || _settings.ExponentialMovingAverageDays > 0)
                {
                    Pen indicatorPen = new Pen(_settings.IndicatorColor, 2);
                    Decimal movingAverage;
                    if (_settings.MovingAverageDays > 0)
                    {
                        movingAverage = CalculateMovingAverage(stock.Date, _settings.MovingAverageDays);
                    }
                    else
                    {
                        movingAverage = CalculateExponentialMovingAverage(stock.Date, _settings.ExponentialMovingAverageDays);
                    }
                    if (hideWeekendsToolStripMenuItem.Checked == true)
                    {
                        currentAverage = new Point((int)(GetNumberOfWeekdays(earliest, stock.Date) * xScale), (int)(maxHeight - ((movingAverage - yMin) * yScale)));
                    }
                    else
                    {
                        currentAverage = new Point((int)((stock.Date - earliest).Days * xScale), (int)(maxHeight - ((movingAverage - yMin) * yScale)));
                    }
                    if (previousAverage.Y != -1 && previousAverage.Y != -1)
                    {
                        dc.DrawLine(indicatorPen, previousAverage, currentAverage);
                    }
                    previousAverage = currentAverage;
                }
            }
            foregroundBrush.Dispose();
            foregroundPen.Dispose();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            _stockData.Clear();

            SqlConnection conn = StockData.Database.Connect();

            // create a SqlCommand object for this connection
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM PRICES WHERE Symbol='" + txtSymbol.Text.ToUpper() + "'";
            command.CommandType = CommandType.Text;

            // execute the command that returns a SqlDataReader
            SqlDataReader reader = command.ExecuteReader();

            // display the results
            while (reader.Read())
            {
                StockInfo info = new StockInfo();
                info.Symbol = ((String)reader["Symbol"]);
                info.DailyHigh = ((Decimal)reader["DailyHigh"]);
                info.DailyLow = ((Decimal)reader["DailyLow"]);
                info.Date = ((DateTime)reader["Date"]);
                info.ClosingPrice = ((Decimal)reader["ClosingPrice"]);
                info.AdjustedClose = ((Decimal)reader["AdjustedClose"]);
                info.OpeningPrice = ((Decimal)reader["OpeningPrice"]);
                info.Volume = ((Int64)reader["Volume"]);
                _stockData.Add(info);
            }

            Invalidate();
            Refresh();
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            // Browse for a file and enter it in the dialog box.
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult result = dlg.ShowDialog();
            string filename = String.Empty;
            if (result == DialogResult.OK)
            {
                filename = dlg.FileName;
            }
            // Load the file, parse the data, and move on.
            if (String.IsNullOrEmpty(filename))
            {
                return;
            }
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(filename);
                ImportData(file);
                Invalidate();
                Refresh();
            }
            catch (Exception ex)
            {
                return;
            }
        }


        private void ImportData(System.IO.TextReader file)
        {
            _stockData.Clear();

            // Yoink header info and validate.
            String header = file.ReadLine();
            String[] headerPieces = header.Split(',');
            if (headerPieces.Length < 5)
            {
                MessageBox.Show("Unrecognized file format.  Cannot import.");
                return;
            }

            // Process file contents.
            String line = String.Empty;
            while (line != null)
            {
                line = file.ReadLine();
                if (line != null)
                {
                    StockInfo info = ParseLine(line, "AAA");
                    // We can get nulls back if the data is invalid, or if the volume is
                    // zero.  Google posts prices on non-trading days with a volume of
                    // zero and this is data we can safely discard.
                    if (info != null)
                    {
                        _stockData.Add(info);
                    }
                }
            }
            file.Close();
        }

        StockInfo ParseLine(string line, string symbol)
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

        private void tbTimeSlider_Scroll(object sender, EventArgs e)
        {
            _settings.NumDays = tbTimeSlider.Value;
            lblLength.Text = _settings.NumDays.ToString() + " Days";
            Invalidate();
            Refresh();
        }

        private void pnlVolume_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Bitmap bitmap = new Bitmap(pnlVolume.Width, pnlVolume.Height);
            Graphics g = Graphics.FromImage(bitmap);
            if (_settings.AntiAliasing)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
            else
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            }
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            RenderVolume(g, false);
            e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
            g.Dispose();
            bitmap.Dispose();
        }

        private void showVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showVolumeToolStripMenuItem.Checked == true)
            {
                showVolumeToolStripMenuItem.Checked = false;
                pnlGraph.Height += pnlVolume.Height;
                lblEarliest.Location = new Point(lblEarliest.Location.X, (lblEarliest.Location.Y + pnlVolume.Height));
                lblMidpoint.Location = new Point(lblMidpoint.Location.X, (lblMidpoint.Location.Y + pnlVolume.Height));
                lblLatest.Location = new Point(lblLatest.Location.X, (lblLatest.Location.Y + pnlVolume.Height));
                pnlVolume.Visible = false;
                lblVolMax.Visible = false;
                lblVolMin.Visible = false;
            }
            else
            {
                showVolumeToolStripMenuItem.Checked = true;
                pnlVolume.Visible = true;
                lblVolMax.Visible = true;
                lblVolMin.Visible = true;
                pnlGraph.Height -= pnlVolume.Height;
                lblEarliest.Location = new Point(lblEarliest.Location.X, (lblEarliest.Location.Y - pnlVolume.Height));
                lblMidpoint.Location = new Point(lblMidpoint.Location.X, (lblMidpoint.Location.Y - pnlVolume.Height));
                lblLatest.Location = new Point(lblLatest.Location.X, (lblLatest.Location.Y - pnlVolume.Height));
            }
            _settings.ShowVolume = showVolumeToolStripMenuItem.Checked;
            Invalidate();
            Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (_settings != null)
            {
                _settings.Save();
            }
            base.OnClosing(e);
        }

        private void btnYahoo_Click(object sender, EventArgs e)
        {
            _stockData = YahooProvider.GetHistoricalData(DateTime.Now - TimeSpan.FromDays(15000), DateTime.Now, txtSymbol.Text.Trim());
            _dividendData = YahooProvider.GetDividends(DateTime.Now - TimeSpan.FromDays(15000), DateTime.Now, txtSymbol.Text.Trim());
            _splitData = YahooProvider.GetSplits(DateTime.Now - TimeSpan.FromDays(15000), DateTime.Now, txtSymbol.Text.Trim());
            Invalidate();
            Refresh();
        }

        private void hideWeekendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hideWeekendsToolStripMenuItem.Checked == true)
            {
                hideWeekendsToolStripMenuItem.Checked = false;
            }
            else
            {
                hideWeekendsToolStripMenuItem.Checked = true;
            }
            _settings.HideWeekends = hideWeekendsToolStripMenuItem.Checked;
            Invalidate();
            Refresh();

        }

        public int GetNumberOfWeekdays(DateTime start, DateTime end)
        {
            int count = 0;
            TimeSpan oneDay = TimeSpan.FromDays(1);
            while (start < end)
            {
                start += oneDay;
                if (start.DayOfWeek == DayOfWeek.Saturday ||
                    start.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }
                count++;
            }
            return count;
        }

        public DateTime GetDateXPeriodsAgo(DateTime endDate, int numPeriods)
        {
            if (_settings.HideWeekends == false)
            {
                return endDate - TimeSpan.FromDays(numPeriods);
            }
            int i = 1;
            int validDays = 0;
            DateTime testDay = endDate;
            while (validDays < numPeriods)
            {
                testDay = endDate - TimeSpan.FromDays(i);
                if (testDay.DayOfWeek != DayOfWeek.Saturday && testDay.DayOfWeek != DayOfWeek.Sunday)
                {
                    validDays++;
                }
                i++;
            }
            return testDay;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings = _pageSettings;
            pd.PrintPage += new PrintPageEventHandler(PrintPage);
            try
            {
                pd.Print();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not print document.  Reason: " + ex.ToString());
            }
        }

        void PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle printArea = e.MarginBounds;
            printArea.Offset((int)-e.PageSettings.HardMarginX, (int)-e.PageSettings.HardMarginY);

            // Render graph first.
            Bitmap graphBitmap;
            if (showVolumeToolStripMenuItem.Checked == true)
            {
                graphBitmap = new Bitmap((int)printArea.Width, (int)((Decimal)printArea.Height * 0.74M));
            }
            else
            {
                graphBitmap = new Bitmap((int)printArea.Width, (int)printArea.Height - 40);
            }
            Graphics g = Graphics.FromImage(graphBitmap);
            if (_settings.AntiAliasing)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
            else
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            }
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            RenderGraphics(g, true);
            e.Graphics.DrawImageUnscaled(graphBitmap, printArea.X, printArea.Y);
            g.Dispose();
            graphBitmap.Dispose();

            // Render volume chart if necessary.
            if (showVolumeToolStripMenuItem.Checked == true)
            {
                Bitmap volumeBitmap = new Bitmap((int)printArea.Width, (int)((Decimal)printArea.Height * 0.22M));
                Graphics p = Graphics.FromImage(volumeBitmap);
                if (_settings.AntiAliasing)
                {
                    p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                }
                else
                {
                    p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                }
                p.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                RenderVolume(p, true);
                e.Graphics.DrawImageUnscaled(volumeBitmap, printArea.X, printArea.Y + (int)((Decimal)printArea.Height * 0.78M));
                p.Dispose();
                volumeBitmap.Dispose();
            }

            int textY = printArea.Y + (int)(printArea.Height * 0.98M);
            if (_settings.ShowVolume == true)
            {
                textY = printArea.Y + (int)(printArea.Height * 0.77M);
            }
            SolidBrush brush = new SolidBrush(Color.Black);
            e.Graphics.DrawString(lblEarliest.Text, new Font("Arial", 12), brush, new Point(printArea.X, textY));
            e.Graphics.DrawString(lblMidpoint.Text, new Font("Arial", 12), brush, new Point((printArea.X + (printArea.Width / 2) - 24), textY));
            e.Graphics.DrawString(lblLatest.Text, new Font("Arial", 12), brush, new Point((printArea.X + printArea.Width - 48), textY));

            e.HasMorePages = false;
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings = _pageSettings;
            pd.PrintPage += new PrintPageEventHandler(PrintPage);
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int borderWidth = (this.Width - this.ClientSize.Width) / 2;
            int titlebarHeight = (this.Height - this.ClientSize.Height - 2 * borderWidth);
            Bitmap bitmap = new Bitmap((this.Right - this.Left - borderWidth * 2), (this.Bottom - this.Top - pnlGraph.Location.Y - titlebarHeight - borderWidth));
            Graphics dc = Graphics.FromImage(bitmap);
            Refresh();
            dc.CopyFromScreen(new Point((this.Left + borderWidth), (this.Top + pnlGraph.Location.Y + titlebarHeight)),
                new Point(0, 0), new Size((this.Right - this.Left - borderWidth * 2), (this.Bottom - this.Top - pnlGraph.Location.Y - titlebarHeight - borderWidth)));
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "chart.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(dlg.FileName);
            }
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int borderWidth = (this.Width - this.ClientSize.Width) / 2;
            int titlebarHeight = (this.Height - this.ClientSize.Height - 2*borderWidth);
            Bitmap bitmap = new Bitmap((this.Right - this.Left - borderWidth * 2), (this.Bottom - this.Top - pnlGraph.Location.Y - titlebarHeight - borderWidth));
            Graphics dc = Graphics.FromImage(bitmap);
            Refresh();
            dc.CopyFromScreen(new Point((this.Left + borderWidth), (this.Top + pnlGraph.Location.Y + titlebarHeight)),
                new Point(0, 0), new Size((this.Right - this.Left - borderWidth * 2), (this.Bottom - this.Top - pnlGraph.Location.Y - titlebarHeight - borderWidth)));
            Clipboard.SetImage(bitmap);
        }

        private void cbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChartType.SelectedIndex != -1)
            {
                _settings.ChartTypeSetting = (ChartType)Enum.Parse(typeof(ChartType), cbChartType.Text);
                Invalidate();
                Refresh();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Champion Stock Chart Viewer 1.01\nCopyright (c) 2009-2013 Zeta Centauri, Inc.\nThis program is released under the MIT License.\nhttp://zetacentauri.com");
        }

        private void setForegroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _settings.ForegroundColor = dlg.Color;
                Invalidate();
                Refresh();
            }
        }

        private void setBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _settings.BackgroundColor = dlg.Color;
                pnlGraph.BackColor = _settings.BackgroundColor;
                pnlVolume.BackColor = _settings.BackgroundColor;
            }
        }

        private void setGuidelineColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _settings.GuidelineColor = dlg.Color;
                Invalidate();
                Refresh();
            }
        }

        private void roundScalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (roundScalingToolStripMenuItem.Checked == true)
            {
                roundScalingToolStripMenuItem.Checked = false;
                _settings.RoundScaling = false;
            }
            else
            {
                roundScalingToolStripMenuItem.Checked = true;
                _settings.RoundScaling = true;
            }
            Invalidate();
            Refresh();
        }

        private Decimal CalculateGuideIncrement(Decimal min, Decimal max)
        {
            if (max < min)
            {
                return 0.0M;
            }

            Decimal diff = max - min;
            Decimal incrementalDiff = diff / 5;
            if (incrementalDiff > 800)
            {
                return 1000.0M;
            }
            if (incrementalDiff > 400)
            {
                return 500.0M;
            }
            if (incrementalDiff > 160)
            {
                return 200.0M;
            }
            if (incrementalDiff > 80)
            {
                return 100.0M;
            }
            if (incrementalDiff > 40)
            {
                return 50.0M;
            }
            if (incrementalDiff > 16)
            {
                return 20.0M;
            }
            if (incrementalDiff > 8)
            {
                return 10.0M;
            }
            if (incrementalDiff > 4M)
            {
                return 5.0M;
            }
            if (incrementalDiff > 1.6M)
            {
                return 2.0M;
            }
            if (incrementalDiff > 0.8M)
            {
                return 1.0M;
            }
            if (incrementalDiff > 0.4M)
            {
                return 0.5M;
            }
            if (incrementalDiff > 0.16M)
            {
                return 0.2M;
            }
            if (incrementalDiff > 0.08M)
            {
                return 0.1M;
            }
            if (incrementalDiff > 0.04M)
            {
                return 0.05M;
            }
            if (incrementalDiff > 0.016M)
            {
                return 0.02M;
            }
            return 0.01M;
        }

        private void RenderGuidelines(Graphics dc, Decimal yMin, Decimal yMax, bool printing)
        {
            Pen guidelinePen = new Pen(_settings.GuidelineColor, 1);
            if (!_settings.RoundScaling)
            {
                labels[4].Location = new Point(this.Size.Width - 56, pnlGraph.Location.Y);
                labels[3].Location = new Point(this.Size.Width - 56, (pnlGraph.Location.Y + (pnlGraph.Height / 4) - 5));
                labels[2].Location = new Point(this.Size.Width - 56, (pnlGraph.Location.Y + (pnlGraph.Height / 2) - 6));
                labels[1].Location = new Point(this.Size.Width - 56, (pnlGraph.Location.Y + (pnlGraph.Height * 3 / 4) - 7));
                labels[0].Location = new Point(this.Size.Width - 56, ((pnlGraph.Location.Y + pnlGraph.Height - 12)));
                for (int i = 5; i < 10; i++)
                {
                    labels[i].Text = String.Empty;
                }
                labels[4].Text = String.Format("{0:00.00}", yMax);
                labels[0].Text = String.Format("{0:00.00}", yMin);
                labels[2].Text = String.Format("{0:00.00}", ((yMax + yMin) / 2));
                labels[1].Text = String.Format("{0:00.00}", ((yMax - yMin) / 4) + yMin);
                labels[3].Text = String.Format("{0:00.00}", ((yMax - yMin) * 3 / 4) + yMin);
                dc.DrawLine(guidelinePen, new Point(0, ((int)dc.VisibleClipBounds.Height / 2)), new Point((int)dc.VisibleClipBounds.Width, ((int)dc.VisibleClipBounds.Height / 2)));
                dc.DrawLine(guidelinePen, new Point(0, ((int)dc.VisibleClipBounds.Height / 4)), new Point((int)dc.VisibleClipBounds.Width, ((int)dc.VisibleClipBounds.Height / 4)));
                dc.DrawLine(guidelinePen, new Point(0, ((int)dc.VisibleClipBounds.Height * 3 / 4)), new Point((int)dc.VisibleClipBounds.Width, ((int)dc.VisibleClipBounds.Height * 3 / 4)));
                if (printing)
                {
                    SolidBrush guidelineBrush = new SolidBrush(_settings.GuidelineColor);
                    Font drawFont = new Font("Arial", 16);
                    dc.DrawString(lblMid.Text, drawFont, guidelineBrush, new Point(((int)dc.VisibleClipBounds.Width - 24), ((int)dc.VisibleClipBounds.Height / 2)));
                    dc.DrawString(lbl14Max.Text, drawFont, guidelineBrush, new Point(((int)dc.VisibleClipBounds.Width - 24), ((int)dc.VisibleClipBounds.Height / 4)));
                    dc.DrawString(lbl34Max.Text, drawFont, guidelineBrush, new Point(((int)dc.VisibleClipBounds.Width - 24), ((int)dc.VisibleClipBounds.Height * 3 / 4)));
                }
            }
            else
            {
                Decimal increment = CalculateGuideIncrement(yMin, yMax);
                int i = 1;
                Decimal guidelineValue = yMin - (yMin % increment) + increment;
                Decimal percent = 0.0M;
                while (guidelineValue < yMax)
                {
                    percent = (guidelineValue - yMin) / (yMax - yMin);
                    dc.DrawLine(guidelinePen, new Point(0, (int)((int)dc.VisibleClipBounds.Height - (percent * (int)dc.VisibleClipBounds.Height))), new Point((int)dc.VisibleClipBounds.Width, (int)((int)dc.VisibleClipBounds.Height - (percent * (int)dc.VisibleClipBounds.Height))));
                    Point txtLocation = new Point((this.Size.Width - 56), (int)(pnlGraph.Location.Y + ((int)pnlGraph.Height - (percent * (int)pnlGraph.Height)) - 6));
                    Point prnLocation = new Point(((int)dc.VisibleClipBounds.Width - 72), (int)(((1.0M - percent) * (int)dc.VisibleClipBounds.Height)));
                    labels[i-1].Text = String.Format("{0:00.00}", guidelineValue);
                    labels[i-1].Location = txtLocation;
                    if (printing)
                    {
                        SolidBrush guidelineBrush = new SolidBrush(_settings.GuidelineColor);
                        Font drawFont = new Font("Arial", 14);
                        dc.DrawString(String.Format("{0:00.00}", guidelineValue), drawFont, guidelineBrush, prnLocation);
                    }
                    i++;
                    guidelineValue += increment;
                }
                // Blank out remaining labels.
                for (; i <= 10; i++)
                {
                    labels[i-1].Text = "";
                }
            }
            guidelinePen.Dispose();
        }

        Decimal CalculateMovingAverage(DateTime day, int numDays)
        {
            int quantity = 0;
            Decimal total = 0.0M;
            DateTime firstDay = GetDateXPeriodsAgo(day, numDays);
            foreach (StockInfo data in _stockData)
            {
                if (data.Date >= firstDay && data.Date <= day)
                {
                    total += data.ClosingPrice;
                    quantity++;
                }
            }
            return total / quantity;
        }

        Decimal CalculateExponentialMovingAverage(DateTime day, int numDays)
        {
            Decimal factor = 2.0M / (1.0M + (Decimal)numDays);
            DateTime firstDay = GetDateXPeriodsAgo(day, numDays);
            Decimal total = CalculateMovingAverage(firstDay, numDays);

            DateTime workingDay;
            for (int i = numDays; i >= 0; i--)
            {
                workingDay = GetDateXPeriodsAgo(day, i);
                foreach (StockInfo data in _stockData)
                {
                    if (data.Date == workingDay)
                    {
                        total = (total * (1.0M - factor)) + (data.ClosingPrice * factor);
                    }
                }
            }
            return total;
        }

        private void setIndicatorColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _settings.IndicatorColor = dlg.Color;
                Invalidate();
                Refresh();
            }
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideMovingAverageToolStripMenuItem.Checked = true;
            tenDayToolStripMenuItem.Checked = false;
            twentyDayToolStripMenuItem.Checked = false;
            fiftyDayToolStripMenuItem.Checked = false;
            thirtyDayToolStripMenuItem.Checked = false;
            hundredDayToolStripMenuItem.Checked = false;
            twentyDayEMAToolStripMenuItem.Checked = false;
            tenDayEMAToolStripMenuItem.Checked = false;
            fiftyDayEMAToolStripMenuItem.Checked = false;
            _settings.MovingAverageDays = 0;
            _settings.ExponentialMovingAverageDays = 0;
            Invalidate();
            Refresh();
        }

        private void tenDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideMovingAverageToolStripMenuItem.Checked = false;
            tenDayToolStripMenuItem.Checked = true;
            twentyDayToolStripMenuItem.Checked = false;
            fiftyDayToolStripMenuItem.Checked = false;
            thirtyDayToolStripMenuItem.Checked = false;
            hundredDayToolStripMenuItem.Checked = false;
            twentyDayEMAToolStripMenuItem.Checked = false;
            tenDayEMAToolStripMenuItem.Checked = false;
            fiftyDayEMAToolStripMenuItem.Checked = false;
            _settings.MovingAverageDays = 10;
            _settings.ExponentialMovingAverageDays = 0;
            Invalidate();
            Refresh();
        }

        private void twentyDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideMovingAverageToolStripMenuItem.Checked = false;
            tenDayToolStripMenuItem.Checked = false;
            twentyDayToolStripMenuItem.Checked = true;
            fiftyDayToolStripMenuItem.Checked = false;
            thirtyDayToolStripMenuItem.Checked = false;
            hundredDayToolStripMenuItem.Checked = false;
            twentyDayEMAToolStripMenuItem.Checked = false;
            tenDayEMAToolStripMenuItem.Checked = false;
            fiftyDayEMAToolStripMenuItem.Checked = false;
            _settings.MovingAverageDays = 20;
            _settings.ExponentialMovingAverageDays = 0;
            Invalidate();
            Refresh();
        }

        private void fiftyDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideMovingAverageToolStripMenuItem.Checked = false;
            tenDayToolStripMenuItem.Checked = false;
            twentyDayToolStripMenuItem.Checked = false;
            fiftyDayToolStripMenuItem.Checked = true;
            thirtyDayToolStripMenuItem.Checked = false;
            hundredDayToolStripMenuItem.Checked = false;
            twentyDayEMAToolStripMenuItem.Checked = false;
            tenDayEMAToolStripMenuItem.Checked = false;
            fiftyDayEMAToolStripMenuItem.Checked = false;
            _settings.MovingAverageDays = 50;
            _settings.ExponentialMovingAverageDays = 0;
            Invalidate();
            Refresh();
        }

        private void thirtyDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideMovingAverageToolStripMenuItem.Checked = false;
            tenDayToolStripMenuItem.Checked = false;
            twentyDayToolStripMenuItem.Checked = false;
            fiftyDayToolStripMenuItem.Checked = false;
            thirtyDayToolStripMenuItem.Checked = true;
            hundredDayToolStripMenuItem.Checked = false;
            twentyDayEMAToolStripMenuItem.Checked = false;
            tenDayEMAToolStripMenuItem.Checked = false;
            fiftyDayEMAToolStripMenuItem.Checked = false;
            _settings.MovingAverageDays = 30;
            _settings.ExponentialMovingAverageDays = 0;
            Invalidate();
            Refresh();
        }

        private void hundredDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideMovingAverageToolStripMenuItem.Checked = false;
            tenDayToolStripMenuItem.Checked = false;
            twentyDayToolStripMenuItem.Checked = false;
            fiftyDayToolStripMenuItem.Checked = false;
            thirtyDayToolStripMenuItem.Checked = false;
            hundredDayToolStripMenuItem.Checked = true;
            twentyDayEMAToolStripMenuItem.Checked = false;
            tenDayEMAToolStripMenuItem.Checked = false;
            fiftyDayEMAToolStripMenuItem.Checked = false;
            _settings.MovingAverageDays = 100;
            _settings.ExponentialMovingAverageDays = 0;
            Invalidate();
            Refresh();
        }

        private void dayEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideMovingAverageToolStripMenuItem.Checked = false;
            tenDayToolStripMenuItem.Checked = false;
            twentyDayToolStripMenuItem.Checked = false;
            fiftyDayToolStripMenuItem.Checked = false;
            thirtyDayToolStripMenuItem.Checked = false;
            hundredDayToolStripMenuItem.Checked = false;
            twentyDayEMAToolStripMenuItem.Checked = false;
            tenDayEMAToolStripMenuItem.Checked = true;
            fiftyDayEMAToolStripMenuItem.Checked = false;
            _settings.MovingAverageDays = 0;
            _settings.ExponentialMovingAverageDays = 10;
            Invalidate();
            Refresh();
        }

        private void dayEMAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hideMovingAverageToolStripMenuItem.Checked = false;
            tenDayToolStripMenuItem.Checked = false;
            twentyDayToolStripMenuItem.Checked = false;
            fiftyDayToolStripMenuItem.Checked = false;
            thirtyDayToolStripMenuItem.Checked = false;
            hundredDayToolStripMenuItem.Checked = false;
            twentyDayEMAToolStripMenuItem.Checked = true;
            tenDayEMAToolStripMenuItem.Checked = false;
            fiftyDayEMAToolStripMenuItem.Checked = false;
            _settings.MovingAverageDays = 0;
            _settings.ExponentialMovingAverageDays = 20;
            Invalidate();
            Refresh();

        }

        private void dayEMAToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            hideMovingAverageToolStripMenuItem.Checked = false;
            tenDayToolStripMenuItem.Checked = false;
            twentyDayToolStripMenuItem.Checked = false;
            fiftyDayToolStripMenuItem.Checked = false;
            thirtyDayToolStripMenuItem.Checked = false;
            hundredDayToolStripMenuItem.Checked = false;
            twentyDayEMAToolStripMenuItem.Checked = false;
            tenDayEMAToolStripMenuItem.Checked = false;
            fiftyDayEMAToolStripMenuItem.Checked = true;
            _settings.MovingAverageDays = 0;
            _settings.ExponentialMovingAverageDays = 50;
            Invalidate();
            Refresh();
        }

        private void exportAsCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "data.csv";
            if (txtSymbol.Text.Length > 0)
            {
                dlg.FileName = txtSymbol.Text + ".csv";
            }
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file;
                file = File.CreateText(dlg.FileName);
                file.WriteLine("Date,Open,High,Low,Close,Volume,Adj Close");
                foreach (StockInfo stock in _stockData)
                {
                    file.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6}", stock.Date, stock.OpeningPrice,
                        stock.DailyHigh, stock.DailyLow, stock.ClosingPrice, stock.Volume, stock.AdjustedClose ));
                }
                file.Close();
            }
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            _stockData = GoogleProvider.GetHistoricalData(DateTime.Now - TimeSpan.FromDays(15000), DateTime.Now, txtSymbol.Text.Trim());
            Invalidate();
            Refresh();
        }

        private void quickStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Champion Stock Chart Viewer Quick Start\n\nThe viewer has three ways to load stock data:  Google Finance, Yahoo Finance, and .CSV files.  To load Google or Yahoo data, type the stock symbol in the 'Symbol' box and click either the Yahoo or Google button.  For CSV files, click the '.CSV File' button and browse for the file.  Downloaded Google and Yahoo format CSV files are supported.\n\nThe time period buttons and the slider will let you change the time period to display and the chart type selector will let you select whether to view a line, bar, or candlestick chart.\n\nStock splits will be shown at the top of the chart, while dividends will be shown at the bottom.\n\nTo change other chart settings, use the 'View' menu.  You can change colors, enable/disable settings, and change the type of moving average that is displayed from these menus.\n\nYou can use the file menu to save the chart to disk, copy it to the clipboard for pasting into other applications such as Microsoft Word, or to print out the chart.");
        }

        private void showDividendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showDividendsToolStripMenuItem.Checked == true)
            {
                showDividendsToolStripMenuItem.Checked = false;
            }
            else
            {
                showDividendsToolStripMenuItem.Checked = true;
            }
            _settings.ShowDividends = showDividendsToolStripMenuItem.Checked;
            Invalidate();
            Refresh();
        }

        private void showSplitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showSplitsToolStripMenuItem.Checked == true)
            {
                showSplitsToolStripMenuItem.Checked = false;
            }
            else
            {
                showSplitsToolStripMenuItem.Checked = true;
            }
            _settings.ShowSplits = showSplitsToolStripMenuItem.Checked;
            Invalidate();
            Refresh();
        }

        private void antiAliasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (antiAliasingToolStripMenuItem.Checked == true)
            {
                antiAliasingToolStripMenuItem.Checked = false;
            }
            else
            {
                antiAliasingToolStripMenuItem.Checked = true;
            }
            _settings.AntiAliasing = antiAliasingToolStripMenuItem.Checked;
            Invalidate();
            Refresh();
        }

        private void importCSVFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCSV_Click(sender, e);
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog dlg = new PageSetupDialog();
            dlg.PageSettings = _pageSettings;
            dlg.AllowMargins = true;
            dlg.AllowOrientation = true;
            dlg.AllowPrinter = true;
            dlg.AllowPaper = true;
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                _pageSettings = dlg.PageSettings;
            }
        }
    }
}
