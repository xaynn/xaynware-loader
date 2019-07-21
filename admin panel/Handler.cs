using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

using xaynware.Library;
using xaynware.Admin.Forms;

namespace xaynware.Admin
{
    public partial class Handler : Form
    {
        public Handler(string[] argsd)
        {
            InitializeComponent();
            Hide();

            try
            {
                var arg = argsd[1].Split(';');

                var form = new Main();
                form.Closed += (s, args) => Close();

                // ReSharper disable once PossibleNullReferenceException
                switch (arg[0])
                {
                    case "xaynware:status":
                        // ReSharper disable once SwitchStatementMissingSomeCases
                        RequestAction("status", arg[1]);
                        Application.Exit();
                        Application.ExitThread();
                        Environment.Exit(0);
                        break;
                    case "xaynware:ban":
                        RequestAction("ban", arg[1], Convert.ToBoolean(arg[2]));
                        Application.Exit();
                        Application.ExitThread();
                        Environment.Exit(0);
                        break;
                    case "xaynware:add":
                        RequestAction("add", arg[1]);
                        Application.Exit();
                        Application.ExitThread();
                        Environment.Exit(0);
                        break;
                    case "xaynware:build":
                        RequestAction("build", arg[1]);
                        Application.Exit();
                        Application.ExitThread();
                        Environment.Exit(0);
                        break;
                    case "xaynware:version":
                        RequestAction("version", arg[1]);
                        Application.Exit();
                        Application.ExitThread();
                        Environment.Exit(0);
                        break;
                    case "xaynware:log":
                        RequestAction("log", null);
                        form.Closed += (s, args) => Close();
                        break;
                    case "xaynware:changelog":
                        RequestAction("changelog", null);
                        form.Closed += (s, args) => Close();
                        break;
                    case "xaynware:disable":
                        // ReSharper disable once InconsistentNaming
                        var form_ = new Main();
                        form_.Closed += (s, args) => Close();
                        form_.Show();
                        break;
                    default:
                        MessageBox.Show(@"Incorrect argument(s) specified. " + arg[1], @"xaynware - error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        Application.ExitThread();
                        Environment.Exit(0);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"There were no arguments specified. " + ex, @"xaynware - error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Application.Exit();
                Application.ExitThread();
                Environment.Exit(0);
            }
        }

        public static void RequestAction(string action, string arg, bool state = true)
        {
            var client = new WebClient();
            switch (action)
            {
                case "ban":
                    Networking.BanHwid(arg, state);
                    MessageBox.Show(@"Banned/unbanned (" + arg + @")", 
                        @"admin - xaynware", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "add":
                    Networking.AddHwid(arg);
                    MessageBox.Show(@"Added hwid (" + arg + @")",
                        @"admin - xaynware", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "version":
                    Networking.ChangeVersion(arg);
                    MessageBox.Show(@"Changed version of the cheat to " + arg,
                        @"admin - xaynware", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "build":
                    Networking.ChangeBuildDate(arg);
                    MessageBox.Show(@"Changed build date of the cheat to " + arg,
                        @"admin - xaynware", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "log":
                    var fileName = Path.GetTempPath() + $"{ToSafeName($"{DateTime.Now:G}")}.log";
                    var data = client.DownloadString("https://yourlink.com/hwid/get_logs.php");
                    File.WriteAllText(fileName, data);
                    Process.Start(fileName);
                    break;
                case "changelog":
                    new Changelog().Show();
                    break;
                case "status":
                    Networking.ChangeStatus(arg);
                    break;
            }
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

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}
