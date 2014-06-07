namespace Fuzhepan.HuobanClient
{
    partial class InformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            this.pnlTx = new CCWin.SkinControl.SkinPanel();
            this.pnlImgTx = new CCWin.SkinControl.SkinPanel();
            this.slbMessage = new CCWin.SkinControl.SkinLabel();
            this.linkShowDetail = new System.Windows.Forms.LinkLabel();
            this.pnlTx.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTx
            // 
            this.pnlTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTx.Controls.Add(this.pnlImgTx);
            this.pnlTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlTx.DownBack = ((System.Drawing.Image)(resources.GetObject("pnlTx.DownBack")));
            this.pnlTx.Location = new System.Drawing.Point(22, 46);
            this.pnlTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTx.MouseBack = ((System.Drawing.Image)(resources.GetObject("pnlTx.MouseBack")));
            this.pnlTx.Name = "pnlTx";
            this.pnlTx.NormlBack = ((System.Drawing.Image)(resources.GetObject("pnlTx.NormlBack")));
            this.pnlTx.Palace = true;
            this.pnlTx.Size = new System.Drawing.Size(57, 57);
            this.pnlTx.TabIndex = 21;
            // 
            // pnlImgTx
            // 
            this.pnlImgTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlImgTx.BackgroundImage = global::FuzhePan.HuobanClient.Properties.Resources.huoban_logo;
            this.pnlImgTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImgTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlImgTx.DownBack = null;
            this.pnlImgTx.Location = new System.Drawing.Point(2, 2);
            this.pnlImgTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImgTx.MouseBack = null;
            this.pnlImgTx.Name = "pnlImgTx";
            this.pnlImgTx.NormlBack = null;
            this.pnlImgTx.Radius = 4;
            this.pnlImgTx.Size = new System.Drawing.Size(53, 53);
            this.pnlImgTx.TabIndex = 6;
            // 
            // slbMessage
            // 
            this.slbMessage.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.slbMessage.BackColor = System.Drawing.Color.Transparent;
            this.slbMessage.BorderColor = System.Drawing.Color.White;
            this.slbMessage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.slbMessage.Location = new System.Drawing.Point(79, 46);
            this.slbMessage.Margin = new System.Windows.Forms.Padding(0);
            this.slbMessage.Name = "slbMessage";
            this.slbMessage.Size = new System.Drawing.Size(163, 57);
            this.slbMessage.TabIndex = 22;
            this.slbMessage.Text = "您有一条未处理的通知。";
            // 
            // linkShowDetail
            // 
            this.linkShowDetail.AutoSize = true;
            this.linkShowDetail.BackColor = System.Drawing.Color.Transparent;
            this.linkShowDetail.Location = new System.Drawing.Point(152, 76);
            this.linkShowDetail.Name = "linkShowDetail";
            this.linkShowDetail.Size = new System.Drawing.Size(53, 12);
            this.linkShowDetail.TabIndex = 23;
            this.linkShowDetail.TabStop = true;
            this.linkShowDetail.Text = "立即查看";
            this.linkShowDetail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowDetail_LinkClicked);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BackLayout = false;
            this.BorderPalace = ((System.Drawing.Image)(resources.GetObject("$this.BorderPalace")));
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(258, 126);
            this.CloseBoxSize = new System.Drawing.Size(39, 20);
            this.CloseDownBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_close_disable;
            this.ControlBoxOffset = new System.Drawing.Point(0, -1);
            this.Controls.Add(this.linkShowDetail);
            this.Controls.Add(this.pnlTx);
            this.Controls.Add(this.slbMessage);
            this.DropBack = false;
            this.EffectWidth = 2;
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
            this.Name = "InformationForm";
            this.RestoreDownBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_restore_down;
            this.RestoreMouseBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_restore_highlight;
            this.RestoreNormlBack = global::FuzhePan.HuobanClient.Properties.Resources.btn_restore_normal;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "伙伴消息";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmInformation_Load);
            this.pnlTx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel pnlTx;
        private CCWin.SkinControl.SkinLabel slbMessage;
        private CCWin.SkinControl.SkinPanel pnlImgTx;
        private System.Windows.Forms.LinkLabel linkShowDetail;
    }
}