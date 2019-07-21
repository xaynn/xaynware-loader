using System;
using System.Net;
using System.Windows.Forms;

namespace xaynware.Admin.Forms
{
    public partial class Changelog : Form
    {
        public Changelog()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadString("https://yourlink.com/hwid/changelog.php?change=" + textBox1.Text);
            client.DownloadString("https://yourlink.com/hwid/log.php?ip=" + Main.GetIp() +
                                  "&action=info&extra=uploaded a new change log");
            MessageBox.Show(@"Successfully uploaded the changelog to the server",
                @"admin - xaynware", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}
