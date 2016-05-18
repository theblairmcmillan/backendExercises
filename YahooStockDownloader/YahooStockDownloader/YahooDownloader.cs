using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahooStockDownloader
{
    public partial class YahooDownloader : Form
    {
        string folder = "";
        string interval = "";

        public YahooDownloader()
        {
            InitializeComponent();
            InitializeComponent();
            folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            txtSavePath.Text = folder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboFromMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
