namespace CryptoCompareUI
{
    partial class ucInsertData
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxUpdateInterval = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxDataSource = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTickerID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxAddedTickers = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbxAvailableTickers = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxIndustry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxISIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxStockName = new System.Windows.Forms.TextBox();
            this.btnNewTicker = new System.Windows.Forms.Button();
            this.lblprogress = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBarImport = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxDataFormat = new System.Windows.Forms.ComboBox();
            this.btnInsertCSV = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTicker = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.progressBarTickers = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxDataFormatTickers = new System.Windows.Forms.ComboBox();
            this.btnInsertTickers = new System.Windows.Forms.Button();
            this.tbxExchange = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitter1);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 322);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(984, 216);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Auto update ticker data";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(348, 15);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 199);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.lbxAddedTickers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(348, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 199);
            this.panel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxUpdateInterval);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbxDataSource);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblTickerID);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(339, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(295, 199);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auto update details";
            // 
            // cbxUpdateInterval
            // 
            this.cbxUpdateInterval.FormattingEnabled = true;
            this.cbxUpdateInterval.Items.AddRange(new object[] {
            "60 seconds",
            "120 seconds",
            "600 seconds",
            "Hourly",
            "Daily",
            "Weekly"});
            this.cbxUpdateInterval.Location = new System.Drawing.Point(125, 57);
            this.cbxUpdateInterval.Name = "cbxUpdateInterval";
            this.cbxUpdateInterval.Size = new System.Drawing.Size(150, 21);
            this.cbxUpdateInterval.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Data source";
            // 
            // tbxDataSource
            // 
            this.tbxDataSource.Location = new System.Drawing.Point(125, 85);
            this.tbxDataSource.Name = "tbxDataSource";
            this.tbxDataSource.Size = new System.Drawing.Size(150, 20);
            this.tbxDataSource.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Update interval";
            // 
            // lblTickerID
            // 
            this.lblTickerID.AutoSize = true;
            this.lblTickerID.Location = new System.Drawing.Point(123, 39);
            this.lblTickerID.Name = "lblTickerID";
            this.lblTickerID.Size = new System.Drawing.Size(10, 13);
            this.lblTickerID.TabIndex = 7;
            this.lblTickerID.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ticker ID";
            // 
            // lbxAddedTickers
            // 
            this.lbxAddedTickers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxAddedTickers.FormattingEnabled = true;
            this.lbxAddedTickers.Location = new System.Drawing.Point(0, 0);
            this.lbxAddedTickers.Margin = new System.Windows.Forms.Padding(2);
            this.lbxAddedTickers.Name = "lbxAddedTickers";
            this.lbxAddedTickers.Size = new System.Drawing.Size(634, 199);
            this.lbxAddedTickers.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbxAvailableTickers);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(2, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 199);
            this.panel2.TabIndex = 0;
            // 
            // lbxAvailableTickers
            // 
            this.lbxAvailableTickers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxAvailableTickers.FormattingEnabled = true;
            this.lbxAvailableTickers.Location = new System.Drawing.Point(0, 0);
            this.lbxAvailableTickers.Margin = new System.Windows.Forms.Padding(2);
            this.lbxAvailableTickers.Name = "lbxAvailableTickers";
            this.lbxAvailableTickers.Size = new System.Drawing.Size(292, 199);
            this.lbxAvailableTickers.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRemove);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(292, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 199);
            this.panel4.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(13, 94);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(32, 30);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 54);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxExchange);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxIndustry);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxISIN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxStockName);
            this.groupBox1.Controls.Add(this.btnNewTicker);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(687, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 322);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Ticker";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Industry";
            // 
            // tbxIndustry
            // 
            this.tbxIndustry.Location = new System.Drawing.Point(125, 123);
            this.tbxIndustry.Name = "tbxIndustry";
            this.tbxIndustry.Size = new System.Drawing.Size(150, 20);
            this.tbxIndustry.TabIndex = 12;
            this.tbxIndustry.Text = "Global";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Exchange";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type";
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(125, 71);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(150, 20);
            this.tbxType.TabIndex = 8;
            this.tbxType.Text = "CTF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ISIN";
            // 
            // tbxISIN
            // 
            this.tbxISIN.Location = new System.Drawing.Point(125, 45);
            this.tbxISIN.Name = "tbxISIN";
            this.tbxISIN.Size = new System.Drawing.Size(150, 20);
            this.tbxISIN.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stock Name";
            // 
            // tbxStockName
            // 
            this.tbxStockName.Location = new System.Drawing.Point(125, 19);
            this.tbxStockName.Name = "tbxStockName";
            this.tbxStockName.Size = new System.Drawing.Size(150, 20);
            this.tbxStockName.TabIndex = 4;
            // 
            // btnNewTicker
            // 
            this.btnNewTicker.Location = new System.Drawing.Point(24, 160);
            this.btnNewTicker.Name = "btnNewTicker";
            this.btnNewTicker.Size = new System.Drawing.Size(125, 23);
            this.btnNewTicker.TabIndex = 3;
            this.btnNewTicker.Text = "Save New Ticker";
            this.btnNewTicker.UseVisualStyleBackColor = true;
            this.btnNewTicker.Click += new System.EventHandler(this.btnNewTicker_Click_1);
            // 
            // lblprogress
            // 
            this.lblprogress.AutoSize = true;
            this.lblprogress.Location = new System.Drawing.Point(421, 107);
            this.lblprogress.Name = "lblprogress";
            this.lblprogress.Size = new System.Drawing.Size(10, 13);
            this.lblprogress.TabIndex = 9;
            this.lblprogress.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBarImport);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cbxDataFormat);
            this.groupBox4.Controls.Add(this.btnInsertCSV);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cbxTicker);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(481, 148);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Import ticker data";
            // 
            // progressBarImport
            // 
            this.progressBarImport.Location = new System.Drawing.Point(118, 89);
            this.progressBarImport.Name = "progressBarImport";
            this.progressBarImport.Size = new System.Drawing.Size(313, 13);
            this.progressBarImport.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Data format";
            // 
            // cbxDataFormat
            // 
            this.cbxDataFormat.FormattingEnabled = true;
            this.cbxDataFormat.Items.AddRange(new object[] {
            "Date,Open,High,Low,Close,Adjusted_close,Volume",
            "date,open,high,low,close,volume,Name"});
            this.cbxDataFormat.Location = new System.Drawing.Point(118, 59);
            this.cbxDataFormat.Name = "cbxDataFormat";
            this.cbxDataFormat.Size = new System.Drawing.Size(313, 21);
            this.cbxDataFormat.TabIndex = 13;
            // 
            // btnInsertCSV
            // 
            this.btnInsertCSV.Location = new System.Drawing.Point(118, 106);
            this.btnInsertCSV.Name = "btnInsertCSV";
            this.btnInsertCSV.Size = new System.Drawing.Size(120, 23);
            this.btnInsertCSV.TabIndex = 12;
            this.btnInsertCSV.Text = "Insert CSV data";
            this.btnInsertCSV.UseVisualStyleBackColor = true;
            this.btnInsertCSV.Click += new System.EventHandler(this.btnInsertCSV_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(296, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ticker";
            // 
            // cbxTicker
            // 
            this.cbxTicker.FormattingEnabled = true;
            this.cbxTicker.Location = new System.Drawing.Point(118, 28);
            this.cbxTicker.Name = "cbxTicker";
            this.cbxTicker.Size = new System.Drawing.Size(165, 21);
            this.cbxTicker.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.lblprogress);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 322);
            this.panel1.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.progressBarTickers);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.cbxDataFormatTickers);
            this.groupBox5.Controls.Add(this.btnInsertTickers);
            this.groupBox5.Location = new System.Drawing.Point(3, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(481, 148);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Import tickers";
            // 
            // progressBarTickers
            // 
            this.progressBarTickers.Location = new System.Drawing.Point(74, 55);
            this.progressBarTickers.Name = "progressBarTickers";
            this.progressBarTickers.Size = new System.Drawing.Size(357, 13);
            this.progressBarTickers.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Data format";
            // 
            // cbxDataFormatTickers
            // 
            this.cbxDataFormatTickers.FormattingEnabled = true;
            this.cbxDataFormatTickers.Items.AddRange(new object[] {
            "Symbol|Security Name|Market Category|Test Issue|Financial Status|Round Lot Size|E" +
                "TF|NextShares"});
            this.cbxDataFormatTickers.Location = new System.Drawing.Point(74, 28);
            this.cbxDataFormatTickers.Name = "cbxDataFormatTickers";
            this.cbxDataFormatTickers.Size = new System.Drawing.Size(401, 21);
            this.cbxDataFormatTickers.TabIndex = 13;
            // 
            // btnInsertTickers
            // 
            this.btnInsertTickers.Location = new System.Drawing.Point(74, 74);
            this.btnInsertTickers.Name = "btnInsertTickers";
            this.btnInsertTickers.Size = new System.Drawing.Size(120, 23);
            this.btnInsertTickers.TabIndex = 12;
            this.btnInsertTickers.Text = "Select and insert ";
            this.btnInsertTickers.UseVisualStyleBackColor = true;
            this.btnInsertTickers.Click += new System.EventHandler(this.btnInsertTickers_Click);
            // 
            // tbxExchange
            // 
            this.tbxExchange.FormattingEnabled = true;
            this.tbxExchange.Items.AddRange(new object[] {
            "NYSE",
            "NASDAQ",
            "AEX"});
            this.tbxExchange.Location = new System.Drawing.Point(126, 97);
            this.tbxExchange.Name = "tbxExchange";
            this.tbxExchange.Size = new System.Drawing.Size(150, 21);
            this.tbxExchange.TabIndex = 14;
            // 
            // ucInsertData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "ucInsertData";
            this.Size = new System.Drawing.Size(984, 538);
            this.Load += new System.EventHandler(this.ucInsertData_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lbxAddedTickers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbxAvailableTickers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxDataSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTickerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxUpdateInterval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxIndustry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxISIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxStockName;
        private System.Windows.Forms.Button btnNewTicker;
        private System.Windows.Forms.Label lblprogress;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar progressBarImport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxDataFormat;
        private System.Windows.Forms.Button btnInsertCSV;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ProgressBar progressBarTickers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxDataFormatTickers;
        private System.Windows.Forms.Button btnInsertTickers;
        private System.Windows.Forms.ComboBox tbxExchange;
    }
}
