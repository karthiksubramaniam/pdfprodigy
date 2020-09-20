using MetroFramework.Forms;
using System;
using System.Diagnostics;

namespace PdfProdigy
{
    public partial class About : MetroForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAuthorMail_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("mailto:karthiksubramaniam@live.com");
            Process.Start(sInfo);
        }

        private void lblAuthorSite_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://beingdotnetgeeks.wordpress.com");
            Process.Start(sInfo);
        }

        private void lblAuthorTwt_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://twitter.com/hash_karthik");
            Process.Start(sInfo);
        }
    }
}