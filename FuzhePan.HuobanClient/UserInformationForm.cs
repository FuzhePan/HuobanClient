using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using FuzhePan.HuobanClient.Service;
using System.Diagnostics;

namespace FuzhePan.HuobanClient
{
    public partial class UserInformationForm : CCSkinMain
    {
        private ChatListSubItem item;
        private Point point;
        public UserInformationForm(ChatListSubItem Item, Point point)
        {
            InitializeComponent();
            this.Item = Item;
            this.point = point;
        }

        public ChatListSubItem Item
        {
            get
            {
                return item;
            }
            set
            {
                if (item != value)
                {
                    item = value;
                    lblName.Text = item.DisplayName;
                    lblPosition.Text = String.Format("职位：{0}", item.PersonalMsg);

                    var user = item.Tag as User;
                    if (user != null)
                    {
                        lblExtnum.Text = String.Format("分机：{0}", user.ExtNumber);
                        lblPhone.Text = String.Format("手机：{0}", user.PhoneNumber);
                        lblEmail.Text = String.Format("邮箱：{0}", user.Email);
                    }

                }
            }
        }

        private void lblChatName_MouseEnter(object sender, EventArgs e)
        {
            lblName.Font = new Font("微软雅黑", 16F, FontStyle.Underline);
        }

        private void lblChatName_MouseLeave(object sender, EventArgs e)
        {
            lblName.Font = new Font("微软雅黑", 16F);
        }

        private void FrmInformation_Load(object sender, EventArgs e)
        {
            //初始化窗口出现位置
            this.Location = point;
        }

        private void FrmUserInformation_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush sb = new SolidBrush(Color.FromArgb(100, 255, 255, 255));
            g.FillRectangle(sb, new Rectangle(new Point(1, Height - 103), new Size(Width - 2, 80)));
        }

        private bool flag = false;
        private void timShow_Tick(object sender, EventArgs e)
        {
            //鼠标不在窗体内时
            if (!this.Bounds.Contains(Cursor.Position) && flag)
            {
                this.Hide();
                flag = false;
            }
            else if (this.Bounds.Contains(Cursor.Position))
            {
                flag = true;
            }
        }

        /// <summary>
        /// 点击姓名，浏览器打开主页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblName_Click(object sender, EventArgs e)
        {
            Process.Start(Program.Service.GetUserSpaceLink(this.item.NicName));
        }
    }
}
