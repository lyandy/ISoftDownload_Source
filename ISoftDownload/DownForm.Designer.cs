namespace ISoftDownload
{
    partial class DownForm
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
            CSharpWin.ProgressBarColorTable progressBarColorTable1 = new CSharpWin.ProgressBarColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lbDownpath = new System.Windows.Forms.Label();
            this.btxChangepath = new DevComponents.DotNetBar.ButtonX();
            this.btxSet = new DevComponents.DotNetBar.ButtonX();
            this.btxGo = new DevComponents.DotNetBar.ButtonX();
            this.proBarDownload = new CSharpWin.ProgressBarEx();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "下载路径：";
            // 
            // lbDownpath
            // 
            this.lbDownpath.AutoSize = true;
            this.lbDownpath.Location = new System.Drawing.Point(77, 40);
            this.lbDownpath.Name = "lbDownpath";
            this.lbDownpath.Size = new System.Drawing.Size(167, 12);
            this.lbDownpath.TabIndex = 0;
            this.lbDownpath.Text = "C:\\Download\\ISoft Setup.exe";
            // 
            // btxChangepath
            // 
            this.btxChangepath.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btxChangepath.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btxChangepath.Location = new System.Drawing.Point(454, 29);
            this.btxChangepath.Name = "btxChangepath";
            this.btxChangepath.Size = new System.Drawing.Size(75, 23);
            this.btxChangepath.TabIndex = 3;
            this.btxChangepath.Text = "修改路径";
            this.btxChangepath.Click += new System.EventHandler(this.btxChangepath_Click);
            // 
            // btxSet
            // 
            this.btxSet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btxSet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btxSet.Location = new System.Drawing.Point(8, 73);
            this.btxSet.Name = "btxSet";
            this.btxSet.Size = new System.Drawing.Size(75, 23);
            this.btxSet.TabIndex = 3;
            this.btxSet.Tag = " ";
            this.btxSet.Text = "设 置";
            this.btxSet.Click += new System.EventHandler(this.btxSet_Click);
            // 
            // btxGo
            // 
            this.btxGo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btxGo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btxGo.Location = new System.Drawing.Point(100, 73);
            this.btxGo.Name = "btxGo";
            this.btxGo.Size = new System.Drawing.Size(75, 23);
            this.btxGo.TabIndex = 3;
            this.btxGo.Text = "开 始";
            this.btxGo.Click += new System.EventHandler(this.btxGo_Click);
            // 
            // proBarDownload
            // 
            this.proBarDownload.ColorTable = progressBarColorTable1;
            this.proBarDownload.ForeColor = System.Drawing.Color.DarkRed;
            this.proBarDownload.Location = new System.Drawing.Point(195, 73);
            this.proBarDownload.Name = "proBarDownload";
            this.proBarDownload.Size = new System.Drawing.Size(334, 23);
            this.proBarDownload.TabIndex = 4;
            // 
            // DownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(538, 113);
            this.Controls.Add(this.proBarDownload);
            this.Controls.Add(this.btxGo);
            this.Controls.Add(this.btxSet);
            this.Controls.Add(this.btxChangepath);
            this.Controls.Add(this.lbDownpath);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DownForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISoft专用下载器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDownpath;
        private DevComponents.DotNetBar.ButtonX btxChangepath;
        private DevComponents.DotNetBar.ButtonX btxSet;
        private DevComponents.DotNetBar.ButtonX btxGo;
        private CSharpWin.ProgressBarEx proBarDownload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

