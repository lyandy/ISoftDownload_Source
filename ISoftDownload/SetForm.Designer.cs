namespace ISoftDownload
{
    partial class SetForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetForm));
            this.chkGo = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btxGo = new DevComponents.DotNetBar.ButtonX();
            this.lblGo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // chkGo
            // 
            this.chkGo.Location = new System.Drawing.Point(18, 40);
            this.chkGo.Name = "chkGo";
            this.chkGo.Size = new System.Drawing.Size(144, 23);
            this.chkGo.TabIndex = 0;
            this.chkGo.Text = "下载完成后自动打开";
            // 
            // btxGo
            // 
            this.btxGo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btxGo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btxGo.Location = new System.Drawing.Point(185, 40);
            this.btxGo.Name = "btxGo";
            this.btxGo.Size = new System.Drawing.Size(75, 23);
            this.btxGo.TabIndex = 1;
            this.btxGo.Text = "确 定";
            this.btxGo.Click += new System.EventHandler(this.btxGo_Click);
            // 
            // lblGo
            // 
            this.lblGo.AutoSize = true;
            this.lblGo.Location = new System.Drawing.Point(162, 83);
            this.lblGo.Name = "lblGo";
            this.lblGo.Size = new System.Drawing.Size(101, 12);
            this.lblGo.TabIndex = 3;
            this.lblGo.TabStop = true;
            this.lblGo.Text = "访问艾软国际官网";
            this.lblGo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGo_LinkClicked);
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.lblGo);
            this.Controls.Add(this.btxGo);
            this.Controls.Add(this.chkGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CheckBoxX chkGo;
        private DevComponents.DotNetBar.ButtonX btxGo;
        private System.Windows.Forms.LinkLabel lblGo;
    }
}