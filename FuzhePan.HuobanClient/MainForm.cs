using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using CCWin;
using CCWin.SkinControl;
using System.Runtime.InteropServices;
using CCWin.Win32;
using FuzhePan.HuobanClient.Service;
using System.Timers;
using Fuzhepan.HuobanClient;
using System.IO;

namespace FuzhePan.HuobanClient
{
    public partial class MainForm : CCSkinMain
    {
        private UnHandledLetter lastUnHandledLetter;
        System.Timers.Timer timer = new System.Timers.Timer(10000);

        public MainForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            lastUnHandledLetter = new UnHandledLetter
            {
                NoticeCount = 0,
                MessageCount = 0,
                ReminderCount = 0
            };

            if (Program.Service.CurrentUser != null)
            {
                labelName.Text = Program.Service.CurrentUser.TrueName;
            }

            timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            timer.Start();
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            timer.Enabled = false;

            var unHandledLetter = Program.Service.GetUnhandledLetter();

            if (unHandledLetter.NoticeCount != lastUnHandledLetter.NoticeCount)
            {
                lbNotice.Text = String.Format("通知（{0}）", unHandledLetter.NoticeCount.ToString());
            }
            if (unHandledLetter.MessageCount != lastUnHandledLetter.MessageCount)
            {
                lbMessage.Text = String.Format("私信（{0}）", unHandledLetter.MessageCount.ToString());
            }
            if (unHandledLetter.ReminderCount != lastUnHandledLetter.ReminderCount)
            {
                lbReminder.Text = String.Format("提醒（{0}）", unHandledLetter.ReminderCount.ToString());
            }

            //todo: 需要考虑小于的情况
            if (unHandledLetter.NoticeCount > lastUnHandledLetter.NoticeCount)
            {
                var infoForm = new InformationForm(String.Format("您有{0}条未处理的通知。",
                    (unHandledLetter.NoticeCount).ToString()),
                    Program.Service.NoticeLink);
                new Thread(() =>
                {
                    Application.Run(infoForm);
                }).Start();
            }
            if (unHandledLetter.MessageCount > lastUnHandledLetter.MessageCount)
            {
                var infoForm = new InformationForm(String.Format("您有{0}条未处理的私信。",
                    (unHandledLetter.MessageCount).ToString()),
                    Program.Service.MessageLink);
                new Thread(() =>
                {
                    Application.Run(infoForm);
                }).Start();
            }
            if (unHandledLetter.ReminderCount > lastUnHandledLetter.ReminderCount)
            {
                var infoForm = new InformationForm(String.Format("您有{0}条到期提醒。",
                    (unHandledLetter.ReminderCount).ToString()),
                    Program.Service.ReminderLink);
                new Thread(() =>
                {
                    Application.Run(infoForm);
                }).Start();
            }

            lastUnHandledLetter = unHandledLetter;

            timer.Enabled = true;
        }

        private void linkNotice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Program.Service.NoticeLink);
        }

        private void linckMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Program.Service.MessageLink);
        }

        private void linkReminder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Program.Service.ReminderLink);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!this.Visible)
            {
                this.Visible = true;
            }
            else
            {
                this.Focus();
            }
        }

        private void toolQQShow_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.Focus();
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Organization> orgs = null;
        /// <summary>
        /// 同事按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {
            toolStripSplitButton3.Enabled = false;
            toolStripSplitButton4.Enabled = true ;

            if (orgs == null)
            {
                ShowMessagePanel.Visible = true;
                MessageCenter.Visible = false;
                ColleagePanel.Visible = false;

                    orgs = Program.Service.GetAllOrganizations();
                    var orgItems = new List<CCWin.SkinControl.ChatListItem>();
                    for (int i = 0; i < orgs.Count; i++)
                    {
                        var orgItem = BuildOrganizationItem(orgs[i], 1 + 26 * i);
                        orgItems.Add(orgItem);
                    }
                    ColleagePanel.Items.AddRange(orgItems.ToArray());

                    this.toolStripSplitButton3.PerformButtonClick();
            }
            
            ShowColleagePanel();
        }

        private void ShowColleagePanel()
        {
            ShowMessagePanel.Visible = false;
            MessageCenter.Visible = false;
            ColleagePanel.Visible = true;
        }

        private ChatListItem BuildOrganizationItem(Organization org,int positionY)
        {
            var chatListItem = new ChatListItem();
            chatListItem.Bounds = new System.Drawing.Rectangle(0, 1, positionY, 25);
            chatListItem.IsTwinkleHide = false;
            chatListItem.OwnerChatListBox = this.ColleagePanel;
            chatListItem.Text = org.name;
            chatListItem.TwinkleSubItemNumber = 0;

            foreach (var u in org.Members)
            {
                ChatListSubItem subItem = new ChatListSubItem(u.Id, u.TrueName, u.Position, ChatListSubItem.UserStatus.Online);
                var headFilePath = System.AppDomain.CurrentDomain.BaseDirectory + @"head\1.png";
                if (File.Exists(headFilePath))
                {
                    subItem.HeadImage = Image.FromFile(headFilePath); 
                }
                subItem.Tag = u;
                chatListItem.SubItems.AddAccordingToStatus(subItem);
            }

            return chatListItem;
        }

        private void toolStripSplitButton4_ButtonClick(object sender, EventArgs e)
        {
            toolStripSplitButton3.Enabled = true ;
            toolStripSplitButton4.Enabled = false ;

            ShowMessagePanel.Visible = false;
            MessageCenter.Visible = true;
            ColleagePanel.Visible = false;
        }

        private void ColleagePanel_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {

        }

        private UserInformationForm userInformationForm;
        private void ColleagePanel_MouseEnterHead(object sender, ChatListEventArgs e)
        {
            int top = this.Top + this.ColleagePanel.Top + (e.MouseOnSubItem.HeadRect.Y - this.ColleagePanel.chatVScroll.Value);
            int left = this.Left - 279 - 5;
            int ph = Screen.GetWorkingArea(this).Height;

            if (top + 181 > ph)
            {
                top = ph - 181 - 5;
            }

            if (left < 0)
            {
                left = this.Right + 5;
            }

            if (userInformationForm != null)
            {
                this.userInformationForm.Item = e.MouseOnSubItem;
                this.userInformationForm.Location = new Point(left, top);
                this.userInformationForm.Show();
            }
            else
            {
                this.userInformationForm = new UserInformationForm(e.MouseOnSubItem, new Point(left, top));
                this.userInformationForm.Show();
            }
        }

        private void ColleagePanel_MouseLeaveHead(object sender, ChatListEventArgs e)
        {
            Thread.Sleep(100);
            if (this.userInformationForm != null && !this.userInformationForm.Bounds.Contains(Cursor.Position))
            {
                this.userInformationForm.Hide();
            }
        }

        /// <summary>
        /// 我的空间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Process.Start(Program.Service.BaseUrl);
        }
    }
}