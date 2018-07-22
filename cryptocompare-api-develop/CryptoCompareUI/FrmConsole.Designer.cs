namespace CryptoCompareUI
{
    partial class FrmConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsole));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lvw = new System.Windows.Forms.ListView();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(797, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lvw
            // 
            this.lvw.BackColor = System.Drawing.Color.Black;
            this.lvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw.ForeColor = System.Drawing.Color.Lime;
            this.lvw.Location = new System.Drawing.Point(0, 0);
            this.lvw.Name = "lvw";
            this.lvw.Size = new System.Drawing.Size(797, 648);
            this.lvw.TabIndex = 2;
            this.lvw.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(45, 28);
            this.toolStripSplitButton1.Text = "Clear list";
            // 
            // FrmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 678);
            this.Controls.Add(this.lvw);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Output";
            this.TopMost = true;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView lvw;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
    }
}