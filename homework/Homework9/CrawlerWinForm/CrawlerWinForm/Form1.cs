using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlerWinForm
{
    public partial class Form1: Form 
    {
         CrawlerWinForm.Crawler MyCrawler { get; set; } = new CrawlerWinForm.Crawler("http://www.cnblogs.com/dstang2000/");


        public Form1()
        {
            InitializeComponent();
            bindingSource1.Add(MyCrawler);
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MyCrawler.start();
        }

        private void txtError_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
