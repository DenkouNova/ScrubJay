using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScrubJay
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGoToUrl_Click(object sender, EventArgs e)
        {
            Uri uri;

            var urlString = tbUrl.Text;
            if (String.IsNullOrEmpty(urlString))
            {
                MessageBox.Show("empty URL");
                return;
            }

            try
            {
                if (urlString.IndexOf("http") == -1)
                {
                    urlString = "http://" + urlString;
                }
                uri = new Uri(urlString);
                this.webBrowser1.Navigate(uri);
            }
            catch (Exception)
            {
                MessageBox.Show("invalid URL: '" + urlString + "'");
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.tbUrl.Text = this.webBrowser1.Url.ToString();
        }

        private void btnScrub_Click(object sender, EventArgs e)
        {

        }
    }
}
