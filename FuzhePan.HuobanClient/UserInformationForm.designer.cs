namespace FuzhePan.HuobanClient
{
    partial class UserInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInformationForm));
            this.timShow = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new CCWin.SkinControl.SkinLabel();
            this.lblPosition = new CCWin.SkinControl.SkinLabel();
            this.lblExtnum = new CCWin.SkinControl.SkinLabel();
            this.lblPhone = new CCWin.SkinControl.SkinLabel();
            this.lblEmail = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timShow
            // 
            this.timShow.Enabled = true;
            this.timShow.Interval = 500;
            this.timShow.Tick += new System.EventHandler(this.timShow_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.BorderColor = System.Drawing.Color.Black;
            this.lblName.BorderSize = 4;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(96, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 30);
            this.lblName.TabIndex = 101;
            this.lblName.Text = "姓名";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            this.lblName.MouseEnter += new System.EventHandler(this.lblChatName_MouseEnter);
            this.lblName.MouseLeave += new System.EventHandler(this.lblChatName_MouseLeave);
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosition.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.BorderColor = System.Drawing.Color.Black;
            this.lblPosition.BorderSize = 4;
            this.lblPosition.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(97, 52);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(176, 20);
            this.lblPosition.TabIndex = 102;
            this.lblPosition.Text = "职位";
            // 
            // lblExtnum
            // 
            this.lblExtnum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExtnum.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblExtnum.BackColor = System.Drawing.Color.Transparent;
            this.lblExtnum.BorderColor = System.Drawing.Color.Black;
            this.lblExtnum.BorderSize = 4;
            this.lblExtnum.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblExtnum.ForeColor = System.Drawing.Color.White;
            this.lblExtnum.Location = new System.Drawing.Point(96, 77);
            this.lblExtnum.Name = "lblExtnum";
            this.lblExtnum.Size = new System.Drawing.Size(176, 20);
            this.lblExtnum.TabIndex = 103;
            this.lblExtnum.Text = "分机";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.BorderColor = System.Drawing.Color.Black;
            this.lblPhone.BorderSize = 4;
            this.lblPhone.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(97, 104);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(176, 20);
            this.lblPhone.TabIndex = 104;
            this.lblPhone.Text = "手机";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.BorderColor = System.Drawing.Color.Black;
            this.lblEmail.BorderSize = 4;
            this.lblEmail.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(97, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(176, 20);
            this.lblEmail.TabIndex = 105;
            this.lblEmail.Text = "邮箱";
            // 
            // UserInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BackLayout = false;
            this.BorderPalace = global::FuzhePan.HuobanClient.Properties.Resources.BackPalace;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(279, 181);
            this.CloseBoxSize = new System.Drawing.Size(39, 20);
            this.CloseDownBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_close_disable;
            this.ControlBox = false;
            this.ControlBoxOffset = new System.Drawing.Point(0, -1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblExtnum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.pictureBox1);
            this.DropBack = false;
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
            this.Mobile = CCWin.MobileStyle.None;
            this.Name = "UserInformationForm";
            this.RestoreDownBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_restore_down;
            this.RestoreMouseBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_restore_highlight;
            this.RestoreNormlBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_restore_normal;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmInformation_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmUserInformation_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CCWin.SkinControl.SkinLabel lblName;
        private CCWin.SkinControl.SkinLabel lblPosition;
        private CCWin.SkinControl.SkinLabel lblExtnum;
        private CCWin.SkinControl.SkinLabel lblPhone;
        private CCWin.SkinControl.SkinLabel lblEmail;
    }
}