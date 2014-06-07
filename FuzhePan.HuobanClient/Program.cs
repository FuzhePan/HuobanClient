using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzhePan.HuobanClient.Service;
using System.Configuration;

namespace FuzhePan.HuobanClient
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var needToInit = ConfigurationManager.AppSettings["NeetToInit"].ToString();
            if (needToInit == "true")
            {
                var settingDlg = new SettingForm("第一次运行，需要先配置一下哦！");
                if (settingDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    cfa.AppSettings.Settings["NeetToInit"].Value = "false";
                    cfa.Save();

                    Application.Restart();
                }
            }
            else
            {
                var baseUrl = ConfigurationManager.AppSettings["BaseUrl"].ToString();
                Service = new Service.Service(baseUrl);

                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                Application.Run(new MainForm());
            }
        }

        public static Service.Service Service = null;
    }
}
