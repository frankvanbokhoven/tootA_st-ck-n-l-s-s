namespace ChampionCharts
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.btn5D = new System.Windows.Forms.Button();
            this.btn1M = new System.Windows.Forms.Button();
            this.btn3M = new System.Windows.Forms.Button();
            this.btn2M = new System.Windows.Forms.Button();
            this.btn1Y = new System.Windows.Forms.Button();
            this.btn6M = new System.Windows.Forms.Button();
            this.btn5Y = new System.Windows.Forms.Button();
            this.btn3Y = new System.Windows.Forms.Button();
            this.btn2Y = new System.Windows.Forms.Button();
            this.btn10Y = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.tbTimeSlider = new System.Windows.Forms.TrackBar();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.btnYahoo = new System.Windows.Forms.Button();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.lblEarliest = new System.Windows.Forms.Label();
            this.lblMidpoint = new System.Windows.Forms.Label();
            this.lblLatest = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnlVolume = new System.Windows.Forms.Panel();
            this.lblVolMax = new System.Windows.Forms.Label();
            this.lblVolMin = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showVolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDividendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSplitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideWeekendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movingAverageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideMovingAverageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twentyDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirtyDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiftyDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hundredDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenDayEMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twentyDayEMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiftyDayEMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setForegroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGuidelineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setIndicatorColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiAliasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundScalingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChartType = new System.Windows.Forms.ComboBox();
            this.labels = new System.Windows.Forms.Label[10];
            for (int i = 0; i < 10; i++)
            {
                this.labels[i] = new System.Windows.Forms.Label();
            }
            ////   this.Icon = new System.Drawing.Icon("CSCVLargeIcon.ico");
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCSVFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeSlider)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Symbol:";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(63, 27);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(70, 20);
            this.txtSymbol.TabIndex = 1;
            // 
            // btn5D
            // 
            this.btn5D.Location = new System.Drawing.Point(16, 63);
            this.btn5D.Name = "btn5D";
            this.btn5D.Size = new System.Drawing.Size(41, 23);
            this.btn5D.TabIndex = 2;
            this.btn5D.Text = "1W";
            this.btn5D.UseVisualStyleBackColor = true;
            this.btn5D.Click += new System.EventHandler(this.btn5D_Click);
            // 
            // btn1M
            // 
            this.btn1M.Location = new System.Drawing.Point(63, 63);
            this.btn1M.Name = "btn1M";
            this.btn1M.Size = new System.Drawing.Size(41, 23);
            this.btn1M.TabIndex = 3;
            this.btn1M.Text = "1M";
            this.btn1M.UseVisualStyleBackColor = true;
            this.btn1M.Click += new System.EventHandler(this.btn1M_Click);
            // 
            // btn3M
            // 
            this.btn3M.Location = new System.Drawing.Point(155, 63);
            this.btn3M.Name = "btn3M";
            this.btn3M.Size = new System.Drawing.Size(41, 23);
            this.btn3M.TabIndex = 5;
            this.btn3M.Text = "3M";
            this.btn3M.UseVisualStyleBackColor = true;
            this.btn3M.Click += new System.EventHandler(this.btn3M_Click);
            // 
            // btn2M
            // 
            this.btn2M.Location = new System.Drawing.Point(108, 63);
            this.btn2M.Name = "btn2M";
            this.btn2M.Size = new System.Drawing.Size(41, 23);
            this.btn2M.TabIndex = 4;
            this.btn2M.Text = "2M";
            this.btn2M.UseVisualStyleBackColor = true;
            this.btn2M.Click += new System.EventHandler(this.btn2M_Click);
            // 
            // btn1Y
            // 
            this.btn1Y.Location = new System.Drawing.Point(249, 63);
            this.btn1Y.Name = "btn1Y";
            this.btn1Y.Size = new System.Drawing.Size(41, 23);
            this.btn1Y.TabIndex = 7;
            this.btn1Y.Text = "1Y";
            this.btn1Y.UseVisualStyleBackColor = true;
            this.btn1Y.Click += new System.EventHandler(this.btn1Y_Click);
            // 
            // btn6M
            // 
            this.btn6M.Location = new System.Drawing.Point(202, 63);
            this.btn6M.Name = "btn6M";
            this.btn6M.Size = new System.Drawing.Size(41, 23);
            this.btn6M.TabIndex = 6;
            this.btn6M.Text = "6M";
            this.btn6M.UseVisualStyleBackColor = true;
            this.btn6M.Click += new System.EventHandler(this.btn6M_Click);
            // 
            // btn5Y
            // 
            this.btn5Y.Location = new System.Drawing.Point(389, 63);
            this.btn5Y.Name = "btn5Y";
            this.btn5Y.Size = new System.Drawing.Size(41, 23);
            this.btn5Y.TabIndex = 10;
            this.btn5Y.Text = "5Y";
            this.btn5Y.UseVisualStyleBackColor = true;
            this.btn5Y.Click += new System.EventHandler(this.btn5Y_Click);
            // 
            // btn3Y
            // 
            this.btn3Y.Location = new System.Drawing.Point(342, 63);
            this.btn3Y.Name = "btn3Y";
            this.btn3Y.Size = new System.Drawing.Size(41, 23);
            this.btn3Y.TabIndex = 9;
            this.btn3Y.Text = "3Y";
            this.btn3Y.UseVisualStyleBackColor = true;
            this.btn3Y.Click += new System.EventHandler(this.btn3Y_Click);
            // 
            // btn2Y
            // 
            this.btn2Y.Location = new System.Drawing.Point(295, 63);
            this.btn2Y.Name = "btn2Y";
            this.btn2Y.Size = new System.Drawing.Size(41, 23);
            this.btn2Y.TabIndex = 8;
            this.btn2Y.Text = "2Y";
            this.btn2Y.UseVisualStyleBackColor = true;
            this.btn2Y.Click += new System.EventHandler(this.btn2Y_Click);
            // 
            // btn10Y
            // 
            this.btn10Y.Location = new System.Drawing.Point(436, 63);
            this.btn10Y.Name = "btn10Y";
            this.btn10Y.Size = new System.Drawing.Size(41, 23);
            this.btn10Y.TabIndex = 11;
            this.btn10Y.Text = "10Y";
            this.btn10Y.UseVisualStyleBackColor = true;
            this.btn10Y.Click += new System.EventHandler(this.btn10Y_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(483, 68);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(51, 13);
            this.lblLength.TabIndex = 12;
            this.lblLength.Text = "3 Months";
            // 
            // tbTimeSlider
            // 
            this.tbTimeSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTimeSlider.AutoSize = false;
            this.tbTimeSlider.Location = new System.Drawing.Point(465, 23);
            this.tbTimeSlider.Maximum = 600;
            this.tbTimeSlider.Minimum = 7;
            this.tbTimeSlider.Name = "tbTimeSlider";
            this.tbTimeSlider.Size = new System.Drawing.Size(296, 27);
            this.tbTimeSlider.TabIndex = 13;
            this.tbTimeSlider.TickFrequency = 250;
            this.tbTimeSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbTimeSlider.Value = 90;
            this.tbTimeSlider.Scroll += new System.EventHandler(this.tbTimeSlider_Scroll);
            // 
            // btnDatabase
            // 
            this.btnDatabase.Location = new System.Drawing.Point(140, 27);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(75, 23);
            this.btnDatabase.TabIndex = 14;
            this.btnDatabase.Text = "Database";
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // btnYahoo
            // 
            this.btnYahoo.Location = new System.Drawing.Point(221, 27);
            this.btnYahoo.Name = "btnYahoo";
            this.btnYahoo.Size = new System.Drawing.Size(75, 23);
            this.btnYahoo.TabIndex = 15;
            this.btnYahoo.Text = "Yahoo";
            this.btnYahoo.UseVisualStyleBackColor = true;
            this.btnYahoo.Click += new System.EventHandler(this.btnYahoo_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.Location = new System.Drawing.Point(302, 27);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(75, 23);
            this.btnGoogle.TabIndex = 16;
            this.btnGoogle.Text = "Google";
            this.btnGoogle.UseVisualStyleBackColor = true;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(383, 27);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(75, 23);
            this.btnCSV.TabIndex = 17;
            this.btnCSV.Text = ".CSV File";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // pnlGraph
            // 
            this.pnlGraph.BackColor = System.Drawing.Color.White;
            this.pnlGraph.Location = new System.Drawing.Point(5, 106);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(714, 384);
            this.pnlGraph.TabIndex = 18;
            this.pnlGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraph_Paint);
            // 
            // lblEarliest
            // 
            this.lblEarliest.AutoSize = true;
            this.lblEarliest.Location = new System.Drawing.Point(5, 500);
            this.lblEarliest.Name = "lblEarliest";
            this.lblEarliest.Size = new System.Drawing.Size(49, 13);
            this.lblEarliest.TabIndex = 22;
            this.lblEarliest.Text = "10-12-08";
            // 
            // lblMidpoint
            // 
            this.lblMidpoint.AutoSize = true;
            this.lblMidpoint.Location = new System.Drawing.Point(348, 500);
            this.lblMidpoint.Name = "lblMidpoint";
            this.lblMidpoint.Size = new System.Drawing.Size(49, 13);
            this.lblMidpoint.TabIndex = 23;
            this.lblMidpoint.Text = "11-12-08";
            // 
            // lblLatest
            // 
            this.lblLatest.AutoSize = true;
            this.lblLatest.Location = new System.Drawing.Point(670, 500);
            this.lblLatest.Name = "lblLatest";
            this.lblLatest.Size = new System.Drawing.Size(49, 13);
            this.lblLatest.TabIndex = 24;
            this.lblLatest.Text = "12-12-08";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pnlVolume
            // 
            this.pnlVolume.BackColor = System.Drawing.Color.White;
            this.pnlVolume.Location = new System.Drawing.Point(5, 520);
            this.pnlVolume.Name = "pnlVolume";
            this.pnlVolume.Size = new System.Drawing.Size(714, 60);
            this.pnlVolume.TabIndex = 26;
            this.pnlVolume.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVolume_Paint);
            // 
            // lblVolMax
            // 
            this.lblVolMax.AutoSize = true;
            this.lblVolMax.Location = new System.Drawing.Point(726, 520);
            this.lblVolMax.Name = "lblVolMax";
            this.lblVolMax.Size = new System.Drawing.Size(25, 13);
            this.lblVolMax.TabIndex = 27;
            this.lblVolMax.Text = "100";
            // 
            // lblVolMin
            // 
            this.lblVolMin.AutoSize = true;
            this.lblVolMin.Location = new System.Drawing.Point(726, 564);
            this.lblVolMin.Name = "lblVolMin";
            this.lblVolMin.Size = new System.Drawing.Size(13, 13);
            this.lblVolMin.TabIndex = 28;
            this.lblVolMin.Text = "0";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(765, 24);
            this.menuStrip2.TabIndex = 29;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importCSVFileToolStripMenuItem,
            this.pageSetupToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem,
            this.saveAsImageToolStripMenuItem,
            this.exportAsCSVToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveAsImageToolStripMenuItem.Text = "&Save as Image";
            this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
            // 
            // exportAsCSVToolStripMenuItem
            // 
            this.exportAsCSVToolStripMenuItem.Name = "exportAsCSVToolStripMenuItem";
            this.exportAsCSVToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exportAsCSVToolStripMenuItem.Text = "Export as CSV";
            this.exportAsCSVToolStripMenuItem.Click += new System.EventHandler(this.exportAsCSVToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showVolumeToolStripMenuItem,
            this.showDividendsToolStripMenuItem,
            this.showSplitsToolStripMenuItem,
            this.hideWeekendsToolStripMenuItem,
            this.movingAverageToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.antiAliasingToolStripMenuItem,
            this.roundScalingToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // showVolumeToolStripMenuItem
            // 
            this.showVolumeToolStripMenuItem.Checked = true;
            this.showVolumeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showVolumeToolStripMenuItem.Name = "showVolumeToolStripMenuItem";
            this.showVolumeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.showVolumeToolStripMenuItem.Text = "Show Volume";
            this.showVolumeToolStripMenuItem.Click += new System.EventHandler(this.showVolumeToolStripMenuItem_Click);
            // 
            // showDividendsToolStripMenuItem
            // 
            this.showDividendsToolStripMenuItem.Checked = true;
            this.showDividendsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showDividendsToolStripMenuItem.Name = "showDividendsToolStripMenuItem";
            this.showDividendsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.showDividendsToolStripMenuItem.Text = "Show Dividends";
            this.showDividendsToolStripMenuItem.Click += new System.EventHandler(this.showDividendsToolStripMenuItem_Click);
            // 
            // showSplitsToolStripMenuItem
            // 
            this.showSplitsToolStripMenuItem.Checked = true;
            this.showSplitsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showSplitsToolStripMenuItem.Name = "showSplitsToolStripMenuItem";
            this.showSplitsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.showSplitsToolStripMenuItem.Text = "Show Splits";
            this.showSplitsToolStripMenuItem.Click += new System.EventHandler(this.showSplitsToolStripMenuItem_Click);
            // 
            // hideWeekendsToolStripMenuItem
            // 
            this.hideWeekendsToolStripMenuItem.Checked = true;
            this.hideWeekendsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideWeekendsToolStripMenuItem.Name = "hideWeekendsToolStripMenuItem";
            this.hideWeekendsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.hideWeekendsToolStripMenuItem.Text = "Hide Weekends";
            this.hideWeekendsToolStripMenuItem.Click += new System.EventHandler(this.hideWeekendsToolStripMenuItem_Click);
            // 
            // movingAverageToolStripMenuItem
            // 
            this.movingAverageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideMovingAverageToolStripMenuItem,
            this.tenDayToolStripMenuItem,
            this.twentyDayToolStripMenuItem,
            this.thirtyDayToolStripMenuItem,
            this.fiftyDayToolStripMenuItem,
            this.hundredDayToolStripMenuItem,
            this.tenDayEMAToolStripMenuItem,
            this.twentyDayEMAToolStripMenuItem,
            this.fiftyDayEMAToolStripMenuItem});
            this.movingAverageToolStripMenuItem.Name = "movingAverageToolStripMenuItem";
            this.movingAverageToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.movingAverageToolStripMenuItem.Text = "Moving Average";
            // 
            // hideMovingAverageToolStripMenuItem
            // 
            this.hideMovingAverageToolStripMenuItem.Name = "hideMovingAverageToolStripMenuItem";
            this.hideMovingAverageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hideMovingAverageToolStripMenuItem.Text = "Hide";
            this.hideMovingAverageToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // tenDayToolStripMenuItem
            // 
            this.tenDayToolStripMenuItem.Name = "tenDayToolStripMenuItem";
            this.tenDayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tenDayToolStripMenuItem.Text = "10 Day";
            this.tenDayToolStripMenuItem.Click += new System.EventHandler(this.tenDayToolStripMenuItem_Click);
            // 
            // twentyDayToolStripMenuItem
            // 
            this.twentyDayToolStripMenuItem.Name = "twentyDayToolStripMenuItem";
            this.twentyDayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.twentyDayToolStripMenuItem.Text = "20 Day";
            this.twentyDayToolStripMenuItem.Click += new System.EventHandler(this.twentyDayToolStripMenuItem_Click);
            // 
            // thirtyDayToolStripMenuItem
            // 
            this.thirtyDayToolStripMenuItem.Name = "thirtyDayToolStripMenuItem";
            this.thirtyDayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thirtyDayToolStripMenuItem.Text = "30 Day";
            this.thirtyDayToolStripMenuItem.Click += new System.EventHandler(this.thirtyDayToolStripMenuItem_Click);
            // 
            // fiftyDayToolStripMenuItem
            // 
            this.fiftyDayToolStripMenuItem.Name = "fiftyDayToolStripMenuItem";
            this.fiftyDayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fiftyDayToolStripMenuItem.Text = "50 Day";
            this.fiftyDayToolStripMenuItem.Click += new System.EventHandler(this.fiftyDayToolStripMenuItem_Click);
            // 
            // hundredDayToolStripMenuItem
            // 
            this.hundredDayToolStripMenuItem.Name = "hundredDayToolStripMenuItem";
            this.hundredDayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hundredDayToolStripMenuItem.Text = "100 Day";
            this.hundredDayToolStripMenuItem.Click += new System.EventHandler(this.hundredDayToolStripMenuItem_Click);
            // 
            // tenDayEMAToolStripMenuItem
            // 
            this.tenDayEMAToolStripMenuItem.Name = "tenDayEMAToolStripMenuItem";
            this.tenDayEMAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tenDayEMAToolStripMenuItem.Text = "10 Day EMA";
            this.tenDayEMAToolStripMenuItem.Click += new System.EventHandler(this.dayEMAToolStripMenuItem_Click);
            // 
            // twentyDayEMAToolStripMenuItem
            // 
            this.twentyDayEMAToolStripMenuItem.Name = "twentyDayEMAToolStripMenuItem";
            this.twentyDayEMAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.twentyDayEMAToolStripMenuItem.Text = "20 Day EMA";
            this.twentyDayEMAToolStripMenuItem.Click += new System.EventHandler(this.dayEMAToolStripMenuItem1_Click);
            // 
            // fiftyDayEMAToolStripMenuItem
            // 
            this.fiftyDayEMAToolStripMenuItem.Name = "fiftyDayEMAToolStripMenuItem";
            this.fiftyDayEMAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fiftyDayEMAToolStripMenuItem.Text = "50 Day EMA";
            this.fiftyDayEMAToolStripMenuItem.Click += new System.EventHandler(this.dayEMAToolStripMenuItem2_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setForegroundColorToolStripMenuItem,
            this.setBackgroundColorToolStripMenuItem,
            this.setGuidelineColorToolStripMenuItem,
            this.setIndicatorColorToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // setForegroundColorToolStripMenuItem
            // 
            this.setForegroundColorToolStripMenuItem.Name = "setForegroundColorToolStripMenuItem";
            this.setForegroundColorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.setForegroundColorToolStripMenuItem.Text = "Set Foreground Color";
            this.setForegroundColorToolStripMenuItem.Click += new System.EventHandler(this.setForegroundColorToolStripMenuItem_Click);
            // 
            // setBackgroundColorToolStripMenuItem
            // 
            this.setBackgroundColorToolStripMenuItem.Name = "setBackgroundColorToolStripMenuItem";
            this.setBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.setBackgroundColorToolStripMenuItem.Text = "Set Background Color";
            this.setBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.setBackgroundColorToolStripMenuItem_Click);
            // 
            // setGuidelineColorToolStripMenuItem
            // 
            this.setGuidelineColorToolStripMenuItem.Name = "setGuidelineColorToolStripMenuItem";
            this.setGuidelineColorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.setGuidelineColorToolStripMenuItem.Text = "Set Guideline Color";
            this.setGuidelineColorToolStripMenuItem.Click += new System.EventHandler(this.setGuidelineColorToolStripMenuItem_Click);
            // 
            // setIndicatorColorToolStripMenuItem
            // 
            this.setIndicatorColorToolStripMenuItem.Name = "setIndicatorColorToolStripMenuItem";
            this.setIndicatorColorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.setIndicatorColorToolStripMenuItem.Text = "Set Indicator Color";
            this.setIndicatorColorToolStripMenuItem.Click += new System.EventHandler(this.setIndicatorColorToolStripMenuItem_Click);
            // 
            // antiAliasingToolStripMenuItem
            // 
            this.antiAliasingToolStripMenuItem.Name = "antiAliasingToolStripMenuItem";
            this.antiAliasingToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.antiAliasingToolStripMenuItem.Text = "Anti-Aliasing";
            this.antiAliasingToolStripMenuItem.Click += new System.EventHandler(this.antiAliasingToolStripMenuItem_Click);
            // 
            // roundScalingToolStripMenuItem
            // 
            this.roundScalingToolStripMenuItem.Checked = true;
            this.roundScalingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.roundScalingToolStripMenuItem.Name = "roundScalingToolStripMenuItem";
            this.roundScalingToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.roundScalingToolStripMenuItem.Text = "Rounded Scaling";
            this.roundScalingToolStripMenuItem.Click += new System.EventHandler(this.roundScalingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickStartToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // quickStartToolStripMenuItem
            // 
            this.quickStartToolStripMenuItem.Name = "quickStartToolStripMenuItem";
            this.quickStartToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.quickStartToolStripMenuItem.Text = "Quick Start";
            this.quickStartToolStripMenuItem.Click += new System.EventHandler(this.quickStartToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Type:";
            // 
            // cbChartType
            // 
            this.cbChartType.FormattingEnabled = true;
            this.cbChartType.Location = new System.Drawing.Point(591, 64);
            this.cbChartType.Name = "cbChartType";
            this.cbChartType.Size = new System.Drawing.Size(121, 21);
            this.cbChartType.TabIndex = 31;
            this.cbChartType.SelectedIndexChanged += new System.EventHandler(this.cbChartType_SelectedIndexChanged);

            for (int i = 0; i < 10; i++)
            {
                this.labels[i].AutoSize = true;
                this.labels[i].Name = "label" + i.ToString();
                this.labels[i].Size = new System.Drawing.Size(0, 13);
            }
            this.labels[0].Location = new System.Drawing.Point(725, 476);
            this.labels[0].TabIndex = 20;
            this.labels[1].Location = new System.Drawing.Point(725, 379);
            this.labels[1].TabIndex = 33;
            this.labels[2].Location = new System.Drawing.Point(725, 286);
            this.labels[2].TabIndex = 21;
            this.labels[3].Location = new System.Drawing.Point(725, 193);
            this.labels[3].TabIndex = 32;
            this.labels[4].Location = new System.Drawing.Point(725, 106);
            this.labels[4].TabIndex = 19;
            this.labels[5].Location = new System.Drawing.Point(548, 497);
            this.labels[5].TabIndex = 34;
            this.labels[6].Location = new System.Drawing.Point(554, 497);
            this.labels[6].TabIndex = 35;
            this.labels[7].Location = new System.Drawing.Point(542, 500);
            this.labels[7].TabIndex = 36;
            this.labels[8].Location = new System.Drawing.Point(548, 497);
            this.labels[8].TabIndex = 37;
            this.labels[9].Location = new System.Drawing.Point(548, 497);
            this.labels[9].TabIndex = 38;
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.pageSetupToolStripMenuItem.Text = "Page Setup";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
            // 
            // importCSVFileToolStripMenuItem
            // 
            this.importCSVFileToolStripMenuItem.Name = "importCSVFileToolStripMenuItem";
            this.importCSVFileToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.importCSVFileToolStripMenuItem.Text = "Open CSV File";
            this.importCSVFileToolStripMenuItem.Click += new System.EventHandler(this.importCSVFileToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 589);
            for (int i = 0; i < 10; i++)
            {
                this.Controls.Add(this.labels[i]);
            };
            this.Controls.Add(this.lbl14Max);
            this.Controls.Add(this.lbl34Max);
            this.Controls.Add(this.cbChartType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVolMin);
            this.Controls.Add(this.lblVolMax);
            this.Controls.Add(this.pnlVolume);
            this.Controls.Add(this.lblLatest);
            this.Controls.Add(this.lblMidpoint);
            this.Controls.Add(this.lblEarliest);
            this.Controls.Add(this.lblMid);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.pnlGraph);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.btnGoogle);
            this.Controls.Add(this.btnYahoo);
            this.Controls.Add(this.btnDatabase);
            this.Controls.Add(this.tbTimeSlider);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.btn10Y);
            this.Controls.Add(this.btn5Y);
            this.Controls.Add(this.btn3Y);
            this.Controls.Add(this.btn2Y);
            this.Controls.Add(this.btn1Y);
            this.Controls.Add(this.btn6M);
            this.Controls.Add(this.btn3M);
            this.Controls.Add(this.btn2M);
            this.Controls.Add(this.btn1M);
            this.Controls.Add(this.btn5D);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Champion Stock Chart Viewer 1.01";
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeSlider)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Button btn5D;
        private System.Windows.Forms.Button btn1M;
        private System.Windows.Forms.Button btn3M;
        private System.Windows.Forms.Button btn2M;
        private System.Windows.Forms.Button btn1Y;
        private System.Windows.Forms.Button btn6M;
        private System.Windows.Forms.Button btn5Y;
        private System.Windows.Forms.Button btn3Y;
        private System.Windows.Forms.Button btn2Y;
        private System.Windows.Forms.Button btn10Y;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TrackBar tbTimeSlider;
        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.Button btnYahoo;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMid;
        private System.Windows.Forms.Label lblEarliest;
        private System.Windows.Forms.Label lblMidpoint;
        private System.Windows.Forms.Label lblLatest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlVolume;
        private System.Windows.Forms.Label lblVolMax;
        private System.Windows.Forms.Label lblVolMin;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showVolumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setForegroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setGuidelineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideWeekendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChartType;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbl34Max;
        private System.Windows.Forms.Label lbl14Max;
        private System.Windows.Forms.ToolStripMenuItem roundScalingToolStripMenuItem;
        private System.Windows.Forms.Label[] labels;
        private System.Windows.Forms.ToolStripMenuItem setIndicatorColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movingAverageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideMovingAverageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twentyDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiftyDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thirtyDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hundredDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenDayEMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twentyDayEMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiftyDayEMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDividendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSplitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antiAliasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCSVFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
    }
}

