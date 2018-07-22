using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoCompareUI
{
    public partial class FrmConsole : Form
    {
        public FrmConsole()
        {
            InitializeComponent();

            lvw.Items.Clear();
        }

        public void AddMessage(string _amessage, Color _color)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = string.Format("{0} - {1}", DateTime.Now.ToString(), _amessage);
            lvi.ForeColor = _color;

            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            lvw.Items.Clear();
        }
    }
}
