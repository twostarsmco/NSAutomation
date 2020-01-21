using System;
using System.Windows.Forms;
using System.IO;

using Common;
using WindowsBackend;

namespace NSAutomationWin
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
            Config config;
            try { config = Config.FromFile(configFilePath); }
            catch (IOException ex)
            {
                if (ex is FileNotFoundException || ex is DirectoryNotFoundException)
                {
                    config = new Config();
                    config.ConfigFilePath = configFilePath;
                    config.Save();
                }
                else
                { 
                    throw ex;
                }
            }

            IOutputPort port;
            try
            {
                port = new OutputPort(config.COMPort);
            }
            catch (Exception)
            {
                config.Online = false;
                port = new MockPort();
            }

            WindowsBackend.MacroRunner runner = new WindowsBackend.MacroRunner(port);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(config, port, runner));
        }
    }
}
