namespace CryptoCompareUI
{
    partial class FrmUIMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCharts = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.financialChartType1 = new CryptoCompareUI.FinancialChartType();
            this.tbxSelection = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.clbSelectedIndicators = new System.Windows.Forms.CheckedListBox();
            this.cbxIndicator = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.clbStocks = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoadSelected = new System.Windows.Forms.Button();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.ucInsertData1 = new CryptoCompareUI.ucInsertData();
            this.tabPageAnalyze = new System.Windows.Forms.TabPage();
            this.tabPageTrade = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnConsole = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageCharts.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPageData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPageCharts);
            this.tabControl1.Controls.Add(this.tabPageData);
            this.tabControl1.Controls.Add(this.tabPageAnalyze);
            this.tabControl1.Controls.Add(this.tabPageTrade);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 165);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1192, 619);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageCharts
            // 
            this.tabPageCharts.Controls.Add(this.panel5);
            this.tabPageCharts.Controls.Add(this.splitter1);
            this.tabPageCharts.Controls.Add(this.panel4);
            this.tabPageCharts.Controls.Add(this.panel2);
            this.tabPageCharts.Location = new System.Drawing.Point(4, 32);
            this.tabPageCharts.Name = "tabPageCharts";
            this.tabPageCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCharts.Size = new System.Drawing.Size(1184, 583);
            this.tabPageCharts.TabIndex = 0;
            this.tabPageCharts.Text = "Charts";
            this.tabPageCharts.UseVisualStyleBackColor = true;
            this.tabPageCharts.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.financialChartType1);
            this.panel5.Controls.Add(this.tbxSelection);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(143, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1038, 540);
            this.panel5.TabIndex = 4;
            // 
            // financialChartType1
            // 
            this.financialChartType1.BackColor = System.Drawing.Color.White;
            this.financialChartType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialChartType1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialChartType1.Location = new System.Drawing.Point(0, 26);
            this.financialChartType1.Name = "financialChartType1";
            this.financialChartType1.Size = new System.Drawing.Size(1038, 514);
            this.financialChartType1.TabIndex = 1;
            // 
            // tbxSelection
            // 
            this.tbxSelection.BackColor = System.Drawing.Color.Black;
            this.tbxSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxSelection.ForeColor = System.Drawing.Color.Lime;
            this.tbxSelection.Location = new System.Drawing.Point(0, 0);
            this.tbxSelection.Name = "tbxSelection";
            this.tbxSelection.Size = new System.Drawing.Size(1038, 26);
            this.tbxSelection.TabIndex = 0;
            this.tbxSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(140, 40);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 540);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.clbSelectedIndicators);
            this.panel4.Controls.Add(this.cbxIndicator);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.clbStocks);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(137, 540);
            this.panel4.TabIndex = 2;
            // 
            // clbSelectedIndicators
            // 
            this.clbSelectedIndicators.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbSelectedIndicators.FormattingEnabled = true;
            this.clbSelectedIndicators.Location = new System.Drawing.Point(3, 57);
            this.clbSelectedIndicators.Name = "clbSelectedIndicators";
            this.clbSelectedIndicators.Size = new System.Drawing.Size(128, 109);
            this.clbSelectedIndicators.TabIndex = 4;
            // 
            // cbxIndicator
            // 
            this.cbxIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxIndicator.FormattingEnabled = true;
            this.cbxIndicator.Items.AddRange(new object[] {
            "Choose indicator..",
            "Moving average 5",
            "Moving average 10",
            "Moving average 20",
            "Moving average 50",
            "Moving average 100",
            "Moving average 200",
            "Bollinger Bands",
            "Slow Stoch",
            "Fast Stoch",
            "MACD",
            "MFI",
            "Parabolic SAR",
            "ROC",
            "RSI",
            "Splits",
            "Vol",
            "Vol MA",
            "Volume",
            "WR"});
            this.cbxIndicator.Location = new System.Drawing.Point(3, 30);
            this.cbxIndicator.MaxDropDownItems = 12;
            this.cbxIndicator.Name = "cbxIndicator";
            this.cbxIndicator.Size = new System.Drawing.Size(128, 28);
            this.cbxIndicator.TabIndex = 3;
            this.cbxIndicator.SelectedValueChanged += new System.EventHandler(this.cbxIndicator_SelectedValueChanged);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 490);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(137, 50);
            this.panel6.TabIndex = 2;
            // 
            // clbStocks
            // 
            this.clbStocks.BackColor = System.Drawing.Color.DarkGray;
            this.clbStocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbStocks.FormattingEnabled = true;
            this.clbStocks.Location = new System.Drawing.Point(0, 0);
            this.clbStocks.Name = "clbStocks";
            this.clbStocks.Size = new System.Drawing.Size(137, 540);
            this.clbStocks.TabIndex = 1;
            this.clbStocks.SelectedIndexChanged += new System.EventHandler(this.clbStocks_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 37);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnConsole);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnLoadSelected);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 37);
            this.panel3.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Location = new System.Drawing.Point(110, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 37);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnYahoo_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1103, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoadSelected
            // 
            this.btnLoadSelected.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoadSelected.Location = new System.Drawing.Point(0, 0);
            this.btnLoadSelected.Name = "btnLoadSelected";
            this.btnLoadSelected.Size = new System.Drawing.Size(110, 37);
            this.btnLoadSelected.TabIndex = 1;
            this.btnLoadSelected.Text = "Selection";
            this.btnLoadSelected.UseVisualStyleBackColor = true;
            this.btnLoadSelected.Click += new System.EventHandler(this.btnLoadSelected_Click);
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.ucInsertData1);
            this.tabPageData.Location = new System.Drawing.Point(4, 32);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(1184, 583);
            this.tabPageData.TabIndex = 1;
            this.tabPageData.Text = "Data";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // ucInsertData1
            // 
            this.ucInsertData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInsertData1.Location = new System.Drawing.Point(3, 3);
            this.ucInsertData1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucInsertData1.Name = "ucInsertData1";
            this.ucInsertData1.Size = new System.Drawing.Size(1178, 584);
            this.ucInsertData1.TabIndex = 0;
            // 
            // tabPageAnalyze
            // 
            this.tabPageAnalyze.Location = new System.Drawing.Point(4, 32);
            this.tabPageAnalyze.Name = "tabPageAnalyze";
            this.tabPageAnalyze.Size = new System.Drawing.Size(1184, 583);
            this.tabPageAnalyze.TabIndex = 2;
            this.tabPageAnalyze.Text = "Analize";
            this.tabPageAnalyze.UseVisualStyleBackColor = true;
            // 
            // tabPageTrade
            // 
            this.tabPageTrade.Location = new System.Drawing.Point(4, 32);
            this.tabPageTrade.Name = "tabPageTrade";
            this.tabPageTrade.Size = new System.Drawing.Size(1184, 583);
            this.tabPageTrade.TabIndex = 3;
            this.tabPageTrade.Text = "Traderobots";
            this.tabPageTrade.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 143);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1192, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnConsole
            // 
            this.btnConsole.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsole.Location = new System.Drawing.Point(185, 0);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(75, 37);
            this.btnConsole.TabIndex = 4;
            this.btnConsole.Text = "Console";
            this.btnConsole.UseVisualStyleBackColor = true;
            this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
            // 
            // FrmUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 784);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmUIMain";
            this.Text = "tootA Crypto UI";
            this.Load += new System.EventHandler(this.FrmUIMain_Load);
            this.Shown += new System.EventHandler(this.FrmUIMain_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCharts.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPageData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCharts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLoadSelected;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckedListBox clbStocks;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbxSelection;
        private System.Windows.Forms.TabPage tabPageAnalyze;
        private System.Windows.Forms.TabPage tabPageTrade;
        private System.Windows.Forms.ComboBox cbxIndicator;
        private System.Windows.Forms.CheckedListBox clbSelectedIndicators;
        private FinancialChartType financialChartType1;
        private ucInsertData ucInsertData1;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

