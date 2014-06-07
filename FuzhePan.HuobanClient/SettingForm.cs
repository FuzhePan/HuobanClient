using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using CCWin.SkinClass;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;
using Microsoft.Win32;

namespace FuzhePan.HuobanClient
{
    public partial class SettingForm : CCSkinMain
    {
        public SettingForm(string msg = "")
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            var runWhenStart = ConfigurationManager.AppSettings["RunWhenStart"].ToString();
            cbRunWhenStart.Checked = (runWhenStart == "true");

            tbBaseUrl.Text = ConfigurationManager.AppSettings["BaseUrl"].ToString();

            lbMessage.Text = msg;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            cfa.AppSettings.Settings["BaseUrl"].Value = tbBaseUrl.Text.Trim().TrimEnd(new[] { '/' });
            cfa.AppSettings.Settings["RunWhenStart"].Value = cbRunWhenStart.Checked ? "true" : "false";
            cfa.Save();

            RunWhenStart(Application.ExecutablePath, cbRunWhenStart.Checked);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public void RunWhenStart(string fileName, bool isAutoRun)
        {
            RegistryKey reg = null;
            try
            {
                if(!System.IO.File.Exists(fileName))
                    throw new Exception("文件不存在");
                string name = fileName.Substring(fileName.LastIndexOf("\\") + 1);
                reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (reg == null)
                    reg = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                if (isAutoRun)
                    reg.SetValue(name, fileName);
                else
                    reg.SetValue(name, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (reg != null) reg.Close();
            }
        }
    }
}
