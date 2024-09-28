using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTanslator
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startup();

            Application.Run(new TranslatorMainForm());
        }

        private static readonly string configFileName = "my_config.json";
        static void startup()
        {
            var programStarted = new EventWaitHandle(
                                    false,
                                    EventResetMode.AutoReset,
                                    "MyHelper",
                                    out var needNew);
            if (!needNew)
            {
                programStarted.Set();
                MyMessageDialog.ShowMessage("软件已经运行");
                return;
            }

            string fullPath = Path.Combine(Directory.GetCurrentDirectory(), configFileName);
            if (File.Exists(fullPath))
            {
                Config.GetInstance().ReadConfigFile(fullPath);
            }
            else
            {
                Config.GetInstance().WriteToFile(fullPath);
            }
        }
    }
}
