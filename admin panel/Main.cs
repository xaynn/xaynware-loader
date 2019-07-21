using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

using xaynware.Admin.Forms;

namespace xaynware
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private static WebClient _client = new WebClient();

        public void D_Click(object sender, EventArgs e)
        {
            _client.DownloadString("https://yourlink.com/hwid/status.php?w=detected");
            MessageBox.Show(@"Changed status of the cheat (Detected)",
                @"admin - xaynware", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _client.DownloadString("https://yourlink.com/hwid/log.php?ip=" + GetIp() + "&action=info&extra=changed status to detected");
        }

        public void VL_Click(object sender, EventArgs e)
        {
            var fileName =  Path.GetTempPath() + $"{ToSafeName($"{DateTime.Now:G}")}.log";
            var data = _client.DownloadString("https://yourlink.com/hwid/get_logs.php");
            File.WriteAllText(fileName, data);
            Process.Start(fileName);
        }

        public static string ToSafeName(string fileName)
        {
            return fileName
                .Replace(":", "-")
                .Replace("/", ".")
                .Replace(" ", "_")
                .Replace("\\", ".")
                .Replace("|", "_")
                .Replace(";", "-")
                .Replace("'", ".")
                .Replace(",", ".");
        }

        public void Ud_Click(object sender, EventArgs e)
        {
            _client.DownloadString("https://yourlink.com/hwid/status.php?w=undetected");
            MessageBox.Show(@"Changed status of the cheat (Undetected)",
                @"admin - xaynware", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _client.DownloadString("https://yourlink.com/hwid/log.php?ip=" + GetIp() + "&action=info&extra=changed status to undetected");
        }

        public void Od_Click(object sender, EventArgs e)
        {
            _client.DownloadString("https://yourlink.com/hwid/status.php?w=outdated");
            MessageBox.Show(@"Changed status of the cheat (Outdated)",
                @"admin - xaynware", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _client.DownloadString("https://yourlink.com/hwid/log.php?ip=" + GetIp() + "&action=info&extra=changed status to outdated");
        }

        public void CV_Click(object sender, EventArgs e)
        {
            _client.DownloadString("https://yourlink.com/hwid/version.php?w=" + textBox1.Text);
            MessageBox.Show(@"Changed version of the cheat (" + textBox1.Text + @")",
                @"admin - xaynware", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _client.DownloadString("https://yourlink.com/hwid/log.php?ip=" + GetIp() + "&action=info&extra=changed version to " + textBox1.Text);
        }

        public void CBd_Click(object sender, EventArgs e)
        {
            _client.DownloadString("https://yourlink.com/hwid/builddate.php?w=" + textBox2.Text);
            MessageBox.Show(@"Changed version of the cheat (" + textBox2.Text + @")",
                @"admin - xaynware", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _client.DownloadString("https://yourlink.com/hwid/log.php?ip=" + GetIp() + "&action=info&extra=changed build date to " + textBox2.Text);
        }

        public void AH_Click(object sender, EventArgs e)
        {
            _client.DownloadString("https://yourlink.com/hwid/add_hwid.php?hwid=" + textBox3.Text);
            MessageBox.Show(@"Added new hwid (" + textBox3.Text + @")",
                @"admin - xaynware", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _client.DownloadString("https://yourlink.com/hwid/log.php?ip=" + GetIp() + "&action=info&extra=added " + textBox3.Text);
        }

        public void B_Click(object sender, EventArgs e)
        {
            var banned = Convert.ToInt16(condition.CheckState);
            _client.DownloadString("https://yourlink.com/hwid/ban.php?hwid=" + textBox4.Text + "&condition=" + banned);
            MessageBox.Show(@"Banned/unbanned hwid (" + textBox4.Text + @")",
                @"admin - xaynware", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _client.DownloadString("https://yourlink.com/hwid/log.php?ip=" + GetIp() + "&action=info&extra=banned/unbanned " + textBox4.Text);
        }

        public static string GetIp()
        {
            return _client.DownloadString("https://icanhazip.com");
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            var form = new Changelog();
            form.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}
