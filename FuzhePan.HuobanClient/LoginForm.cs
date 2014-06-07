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
using System.Diagnostics;

namespace FuzhePan.HuobanClient
{
    public partial class LoginForm : CCSkinMain
    {
        public LoginForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            textBoxId.SkinTxt.Text = ConfigurationManager.AppSettings["UserName"].ToString();
            textBoxPwd.SkinTxt.Text = ConfigurationManager.AppSettings["Password"].ToString();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            lbShowMessage.Text = "正在登录，请稍等...";
            buttonLogin.Text = "正在登录";
            buttonLogin.Enabled = false ;

            string userName = this.textBoxId.SkinTxt.Text.Trim();
            string password = this.textBoxPwd.SkinTxt.Text.Trim();
            if (userName.Length == 0 || password.Length == 0) { return; }

            Thread tr = new Thread(() => 
            {
                var loginResult =false;
                try 
	            {	        
                     loginResult= Program.Service.Login(userName, password);
	            }
	            catch (Exception ex)
	            {
                    Trace.Write(ex.Message);
	            }

                if (loginResult)
                {
                    lbShowMessage.Text = "正在加载数据...";
                    buttonLogin.Text = "加载数据";

                    //预加载数据
                    Program.Service.GetAllOrganizations();

                    if (cbRemenberPwd.Checked)
                    {
                        //todo by FuzhePan: 密码应该加密后保存
                        Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        cfa.AppSettings.Settings["UserName"].Value = userName;
                        cfa.AppSettings.Settings["Password"].Value = password;
                        cfa.Save();
                    }

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    lbShowMessage.Text = "登录失败！"; 
                }

                buttonLogin.Text = "登   录";
                buttonLogin.Enabled = true;
            });

            tr.Start();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="sender"></param>
        private void LoginForm_SysBottomClick(object sender)
        {
            var settingForm = new SettingForm();
            if (settingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Application.Restart();
            }
        }
    }
}
