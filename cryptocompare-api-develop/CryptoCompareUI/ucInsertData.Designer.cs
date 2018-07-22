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
            this.btnInsertCSV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxTicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewTicker = new System.Windows.Forms.Button();
            this.tbxStockName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxISIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxExchange = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxIndustry = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertCSV
            // 
            this.btnInsertCSV.Location = new System.Drawing.Point(45, 264);
            this.btnInsertCSV.Name = "btnInsertCSV";
            this.btnInsertCSV.Size = new System.Drawing.Size(120, 23);
            this.btnInsertCSV.TabIndex = 0;
            this.btnInsertCSV.Text = "Insert CSV data";
            this.btnInsertCSV.UseVisualStyleBackColor = true;
            this.btnInsertCSV.Click += new System.EventHandler(this.btnInsertCSV_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxTicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 258);
            this.panel1.TabIndex = 1;
            // 
            // cbxTicker
            // 
            this.cbxTicker.FormattingEnabled = true;
            this.cbxTicker.Location = new System.Drawing.Point(70, 40);
            this.cbxTicker.Name = "cbxTicker";
            this.cbxTicker.Size = new System.Drawing.Size(165, 21);
            this.cbxTicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticker";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxIndustry);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxExchange);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxISIN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxStockName);
            this.groupBox1.Controls.Add(this.btnNewTicker);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(400, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 258);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Ticker";
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
            // tbxStockName
            // 
            this.tbxStockName.Location = new System.Drawing.Point(125, 19);
            this.tbxStockName.Name = "tbxStockName";
            this.tbxStockName.Size = new System.Drawing.Size(150, 20);
            this.tbxStockName.TabIndex = 4;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Exchange";
            // 
            // tbxExchange
            // 
            this.tbxExchange.Location = new System.Drawing.Point(125, 97);
            this.tbxExchange.Name = "tbxExchange";
            this.tbxExchange.Size = new System.Drawing.Size(150, 20);
            this.tbxExchange.TabIndex = 10;
            this.tbxExchange.Text = "NYSE";
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
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(294, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ucInsertData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInsertCSV);
            this.Name = "ucInsertData";
            this.Size = new System.Drawing.Size(697, 446);
            this.Load += new System.EventHandler(this.ucInsertData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertCSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxStockName;
        private System.Windows.Forms.Button btnNewTicker;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxIndustry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxExchange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxISIN;
    }
}
