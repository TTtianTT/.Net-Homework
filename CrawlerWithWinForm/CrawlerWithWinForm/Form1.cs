using CrawlerWinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlerWithWinForm
{
    public partial class Form1 : Form
    {
        private Crawler crawler;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Crawler_PageDownloaded(string url)
        {
            if (this.lbxFinish.InvokeRequired)
            {
                Action<String> action = this.AddUrl;
                this.Invoke(action, new object[] { url });
            }
            else
            {
                AddUrl(url);
            }
        }
        private void Crawler_PageDownloadFailed(string message)
        {
            if (this.lbxError.InvokeRequired)
            {
                Action<String> action = this.Error;
                this.Invoke(action, new object[] { message });
            }
            else
            {
                Error(message);
            }
        }

        private void AddUrl(string url)
        {
            lbxFinish.Items.Add(url);
        }

        private void Error(string message)
        {
            lbxError.Items.Add(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbxFinish.Items.Clear();
            lbxError.Items.Clear();
            crawler = new Crawler(txtStartUrl.Text);
            crawler.PageDownloaded += Crawler_PageDownloaded;
            crawler.PageDownloadFailed += Crawler_PageDownloadFailed;
            new Thread(crawler.Crawl).Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crawler.Run = false;
        }
    }
}
