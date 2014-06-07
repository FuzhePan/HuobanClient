using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.Win32;
using CCWin.Win32.Const;
using System.Diagnostics;

namespace Fuzhepan.HuobanClient
{
    public partial class InformationForm : CCSkinMain
    {
        private string link = String.Empty;
        public InformationForm(string msg, string link)
        {
            InitializeComponent();

            this.slbMessage.Text = msg;
            this.link = link;
        }

        //窗口加载时
        private void FrmInformation_Load(object sender, EventArgs e)
        {
            //初始化窗口出现位置
            Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            this.PointToScreen(p);
            this.Location = p;
            NativeMethods.AnimateWindow(this.Handle, 130, AW.AW_SLIDE + AW.AW_VER_NEGATIVE);//开始窗体动画
        }


        private void linkShowDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(String.IsNullOrEmpty(link))
            {
                return;
            }
            Process.Start(this.link);

            this.Close();
        }
    }
}
