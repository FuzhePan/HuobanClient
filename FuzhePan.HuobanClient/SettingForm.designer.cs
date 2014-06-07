namespace FuzhePan.HuobanClient
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.toolShow = new System.Windows.Forms.ToolTip(this.components);
            this.buttonLogin = new CCWin.SkinControl.SkinButton();
            this.btnMima = new CCWin.SkinControl.SkinButton();
            this.btnZc = new CCWin.SkinControl.SkinButton();
            this.menuStripId = new CCWin.SkinControl.SkinContextMenuStrip();
            this.imgLoadding = new System.Windows.Forms.PictureBox();
            this.ItemImonline = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemQme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemAway = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemBusy = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMute = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemInVisble = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripState = new CCWin.SkinControl.SkinContextMenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBaseUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRunWhenStart = new System.Windows.Forms.CheckBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadding)).BeginInit();
            this.menuStripState.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolShow
            // 
            this.toolShow.IsBalloon = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogin.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.buttonLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(118)))), ((int)(((byte)(156)))));
            this.buttonLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonLogin.Create = true;
            this.buttonLogin.DownBack = global::FuzhePan.HuobanClient.Properties.Resources.button_login_down;
            this.buttonLogin.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.buttonLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Location = new System.Drawing.Point(99, 244);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogin.MouseBack = global::FuzhePan.HuobanClient.Properties.Resources.button_login_hover;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.NormlBack = global::FuzhePan.HuobanClient.Properties.Resources.button_login_normal;
            this.buttonLogin.Palace = true;
            this.buttonLogin.Size = new System.Drawing.Size(185, 49);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "确       定";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // btnMima
            // 
            this.btnMima.BackColor = System.Drawing.Color.Transparent;
            this.btnMima.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(118)))), ((int)(((byte)(156)))));
            this.btnMima.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnMima.Create = true;
            this.btnMima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMima.DownBack = null;
            this.btnMima.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnMima.Location = new System.Drawing.Point(308, 180);
            this.btnMima.Margin = new System.Windows.Forms.Padding(0);
            this.btnMima.MouseBack = null;
            this.btnMima.Name = "btnMima";
            this.btnMima.NormlBack = null;
            this.btnMima.Size = new System.Drawing.Size(51, 16);
            this.btnMima.TabIndex = 9;
            this.btnMima.UseVisualStyleBackColor = false;
            // 
            // btnZc
            // 
            this.btnZc.BackColor = System.Drawing.Color.Transparent;
            this.btnZc.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(118)))), ((int)(((byte)(156)))));
            this.btnZc.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnZc.Create = true;
            this.btnZc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZc.DownBack = null;
            this.btnZc.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnZc.Location = new System.Drawing.Point(309, 145);
            this.btnZc.Margin = new System.Windows.Forms.Padding(0);
            this.btnZc.MouseBack = null;
            this.btnZc.Name = "btnZc";
            this.btnZc.NormlBack = null;
            this.btnZc.Size = new System.Drawing.Size(51, 16);
            this.btnZc.TabIndex = 8;
            this.btnZc.UseVisualStyleBackColor = false;
            // 
            // menuStripId
            // 
            this.menuStripId.Arrow = System.Drawing.Color.Black;
            this.menuStripId.AutoSize = false;
            this.menuStripId.Back = System.Drawing.Color.White;
            this.menuStripId.BackColor = System.Drawing.Color.White;
            this.menuStripId.BackRadius = 4;
            this.menuStripId.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.menuStripId.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(209)))));
            this.menuStripId.Fore = System.Drawing.Color.Black;
            this.menuStripId.HoverFore = System.Drawing.Color.White;
            this.menuStripId.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStripId.ItemAnamorphosis = false;
            this.menuStripId.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStripId.ItemBorderShow = false;
            this.menuStripId.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStripId.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStripId.ItemRadius = 4;
            this.menuStripId.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.menuStripId.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.menuStripId.Name = "MenuId";
            this.menuStripId.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.menuStripId.Size = new System.Drawing.Size(183, 4);
            this.menuStripId.TitleAnamorphosis = false;
            this.menuStripId.TitleColor = System.Drawing.Color.White;
            this.menuStripId.TitleRadius = 4;
            this.menuStripId.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            // 
            // imgLoadding
            // 
            this.imgLoadding.Image = ((System.Drawing.Image)(resources.GetObject("imgLoadding.Image")));
            this.imgLoadding.Location = new System.Drawing.Point(1, 242);
            this.imgLoadding.Margin = new System.Windows.Forms.Padding(0);
            this.imgLoadding.Name = "imgLoadding";
            this.imgLoadding.Size = new System.Drawing.Size(377, 2);
            this.imgLoadding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoadding.TabIndex = 17;
            this.imgLoadding.TabStop = false;
            this.imgLoadding.Visible = false;
            // 
            // ItemImonline
            // 
            this.ItemImonline.AutoSize = false;
            this.ItemImonline.Name = "ItemImonline";
            this.ItemImonline.Size = new System.Drawing.Size(105, 22);
            this.ItemImonline.Tag = "2";
            this.ItemImonline.Text = "我在线上";
            this.ItemImonline.ToolTipText = "表示希望好友看到您在线。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            // 
            // ItemQme
            // 
            this.ItemQme.AutoSize = false;
            this.ItemQme.Name = "ItemQme";
            this.ItemQme.Size = new System.Drawing.Size(105, 22);
            this.ItemQme.Tag = "1";
            this.ItemQme.Text = "Q我把";
            this.ItemQme.ToolTipText = "表示希望好友主动联系您。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：自动弹出会话窗口\r\n";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 6);
            // 
            // ItemAway
            // 
            this.ItemAway.AutoSize = false;
            this.ItemAway.Name = "ItemAway";
            this.ItemAway.Size = new System.Drawing.Size(105, 22);
            this.ItemAway.Tag = "3";
            this.ItemAway.Text = "离开";
            this.ItemAway.ToolTipText = "表示离开，暂无法处理消息。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            // 
            // ItemBusy
            // 
            this.ItemBusy.AutoSize = false;
            this.ItemBusy.Name = "ItemBusy";
            this.ItemBusy.Size = new System.Drawing.Size(105, 22);
            this.ItemBusy.Tag = "4";
            this.ItemBusy.Text = "忙碌";
            this.ItemBusy.ToolTipText = "表示忙碌，不会及时处理消息。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏显示气泡\r\n";
            // 
            // ItemMute
            // 
            this.ItemMute.AutoSize = false;
            this.ItemMute.Name = "ItemMute";
            this.ItemMute.Size = new System.Drawing.Size(105, 22);
            this.ItemMute.Tag = "5";
            this.ItemMute.Text = "请勿打扰";
            this.ItemMute.ToolTipText = "表示不想被打扰。\r\n声音：关闭\r\n消息提醒框：关闭\r\n会话消息：任务栏显示气泡\r\n\r\n";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 6);
            // 
            // ItemInVisble
            // 
            this.ItemInVisble.AutoSize = false;
            this.ItemInVisble.Name = "ItemInVisble";
            this.ItemInVisble.Size = new System.Drawing.Size(105, 22);
            this.ItemInVisble.Tag = "6";
            this.ItemInVisble.Text = "隐身";
            this.ItemInVisble.ToolTipText = "表示好友看到您是离线的。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            // 
            // menuStripState
            // 
            this.menuStripState.Arrow = System.Drawing.Color.Black;
            this.menuStripState.AutoSize = false;
            this.menuStripState.Back = System.Drawing.Color.White;
            this.menuStripState.BackRadius = 4;
            this.menuStripState.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.menuStripState.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.menuStripState.Fore = System.Drawing.Color.Black;
            this.menuStripState.HoverFore = System.Drawing.Color.White;
            this.menuStripState.ImageScalingSize = new System.Drawing.Size(11, 11);
            this.menuStripState.ItemAnamorphosis = false;
            this.menuStripState.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStripState.ItemBorderShow = false;
            this.menuStripState.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStripState.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStripState.ItemRadius = 4;
            this.menuStripState.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.menuStripState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemImonline,
            this.ItemQme,
            this.toolStripMenuItem1,
            this.ItemAway,
            this.ItemBusy,
            this.ItemMute,
            this.toolStripMenuItem2,
            this.ItemInVisble});
            this.menuStripState.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.menuStripState.Name = "MenuState";
            this.menuStripState.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menuStripState.Size = new System.Drawing.Size(106, 147);
            this.menuStripState.TitleAnamorphosis = false;
            this.menuStripState.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.menuStripState.TitleRadius = 4;
            this.menuStripState.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "伙伴系统网址:";
            // 
            // tbBaseUrl
            // 
            this.tbBaseUrl.Location = new System.Drawing.Point(120, 93);
            this.tbBaseUrl.Name = "tbBaseUrl";
            this.tbBaseUrl.Size = new System.Drawing.Size(239, 21);
            this.tbBaseUrl.TabIndex = 19;
            this.tbBaseUrl.Text = "http://";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(55, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "(输入您公司的伙伴网址，如：http://www.huoban.com ";
            // 
            // cbRunWhenStart
            // 
            this.cbRunWhenStart.AutoSize = true;
            this.cbRunWhenStart.BackColor = System.Drawing.Color.Transparent;
            this.cbRunWhenStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRunWhenStart.Location = new System.Drawing.Point(104, 181);
            this.cbRunWhenStart.Name = "cbRunWhenStart";
            this.cbRunWhenStart.Size = new System.Drawing.Size(91, 20);
            this.cbRunWhenStart.TabIndex = 21;
            this.cbRunWhenStart.Text = "开机启动";
            this.cbRunWhenStart.UseVisualStyleBackColor = false;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbMessage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(7, 51);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 16);
            this.lbMessage.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(193, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "或 http://192.168.0.1:8080)";
            // 
            // SettingForm
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Back = global::FuzhePan.HuobanClient.Properties.Resources.AV_VDC_Bkg;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(118)))), ((int)(((byte)(156)))));
            this.BackPalace = global::FuzhePan.HuobanClient.Properties.Resources.texture2;
            this.BackToColor = false;
            this.BorderPalace = global::FuzhePan.HuobanClient.Properties.Resources.BackPalace;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(379, 292);
            this.CloseBoxSize = new System.Drawing.Size(39, 20);
            this.CloseDownBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_close_disable;
            this.ControlBoxOffset = new System.Drawing.Point(0, -1);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.cbRunWhenStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBaseUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgLoadding);
            this.Controls.Add(this.btnMima);
            this.Controls.Add(this.btnZc);
            this.Controls.Add(this.buttonLogin);
            this.DropBack = false;
            this.EffectCaption = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_max_down;
            this.MaximizeBox = false;
            this.MaxMouseBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_max_highlight;
            this.MaxNormlBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_max_normal;
            this.MaxSize = new System.Drawing.Size(28, 20);
            this.MiniDownBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_mini_down;
            this.MinimizeBox = false;
            this.MiniMouseBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_mini_highlight;
            this.MiniNormlBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_mini_normal;
            this.MiniSize = new System.Drawing.Size(28, 20);
            this.Name = "SettingForm";
            this.RestoreDownBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_restore_down;
            this.RestoreMouseBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_restore_highlight;
            this.RestoreNormlBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_restore_normal;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SysBottomDown = global::FuzhePan.HuobanClient.Properties.Resources.btn_set_press;
            this.SysBottomMouse = global::FuzhePan.HuobanClient.Properties.Resources.btn_set_hover;
            this.SysBottomNorml = global::FuzhePan.HuobanClient.Properties.Resources.btn_set_normal;
            this.SysBottomToolTip = "设置";
            this.Text = "Huoban";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadding)).EndInit();
            this.menuStripState.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton buttonLogin;
        private CCWin.SkinControl.SkinButton btnMima;
        private CCWin.SkinControl.SkinButton btnZc;
        private System.Windows.Forms.ToolTip toolShow;
        private CCWin.SkinControl.SkinContextMenuStrip menuStripId;
        private System.Windows.Forms.PictureBox imgLoadding;
        private System.Windows.Forms.ToolStripMenuItem ItemImonline;
        private System.Windows.Forms.ToolStripMenuItem ItemQme;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ItemAway;
        private System.Windows.Forms.ToolStripMenuItem ItemBusy;
        private System.Windows.Forms.ToolStripMenuItem ItemMute;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ItemInVisble;
        private CCWin.SkinControl.SkinContextMenuStrip menuStripState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBaseUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbRunWhenStart;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label label3;
    }
}