using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace xaynware.Admin
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var args = Environment.GetCommandLineArgs();
            RegisterUrlProtocol();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Handler(args));
        }

        public static void RegisterUrlProtocol()
        {
            var key = Registry.ClassesRoot.OpenSubKey("xaynware");
            var path = @"""" + Application.ExecutablePath + @""" """ + @"%1""";
            if (key == null)
            {
                key = Registry.ClassesRoot.CreateSubKey("xaynware");
                // ReSharper disable once PossibleNullReferenceException
                key.SetValue(string.Empty, "URL:xaynware Protocol");
                key.SetValue("URL Protocol", string.Empty);

                key = key.CreateSubKey(@"shell\open\command");
                // ReSharper disable once PossibleNullReferenceException
                key.SetValue(string.Empty, path);
            }

            key.Close();
        }
    }
}
