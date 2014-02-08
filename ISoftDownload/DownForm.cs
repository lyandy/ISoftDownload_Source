using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;

using CSharpWin;

namespace ISoftDownload
{
    public partial class DownForm : SkinForm
    {
        public DownForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            Startpath = lbDownpath.Text;
        }

        public int startFlag = 0;

        public int StartFlag
        {
            get
            {
                return startFlag;
            }
            set
            {
                startFlag = value;
            }
        }

        private void reflectionLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://chinetsoft.d209.cnaaa5.com");
        }

        private void reflectionImage1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://chinetsoft.d209.cnaaa5.com");
        }

        string Startpath = null;

        private void btxChangepath_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lbDownpath.Text = this.folderBrowserDialog1.SelectedPath.Trim() + @"\ISoft Setup.exe";
                Startpath = lbDownpath.Text;
            }
        }

        private void btxSet_Click(object sender, EventArgs e)
        {
            SetForm st = new SetForm(startFlag);
            st.Owner = this;
            st.Show();
        }

        Thread threadDown = null;

        private void btxGo_Click(object sender, EventArgs e)
        {
            btxSet.Enabled = false;
            btxChangepath.Enabled = false;

            if (btxGo.Text == "开 始")
            {
                btxGo.Text = "暂 停";

                threadDown = new Thread(new ThreadStart(DownUpdateFile));
                threadDown.IsBackground = true;
                threadDown.Start();
            }
            else
                if (btxGo.Text == "暂 停")
                {
                    threadDown.Suspend();
                    btxGo.Text = "继 续";
                }
                else
                {
                    threadDown.Resume();
                    btxGo.Text = "暂 停";
                }

        }

        private void DownUpdateFile()
        {
            btxSet.Enabled = false;
            btxChangepath.Enabled = false;

            WebClient wcClient = new WebClient();
            {

                long fileLength = 0;

                int existFlag = 0;

                WebRequest webReq = WebRequest.Create("http://www.chinetsoft.net/ISoftUpdate/ISoft Setup.exe");
                WebResponse webRes = webReq.GetResponse();
                fileLength = webRes.ContentLength;


                proBarDownload.Value = 0;
                proBarDownload.Maximum = (int)fileLength;

                try
                {
                    Stream srm = webRes.GetResponseStream();
                    StreamReader srmReader = new StreamReader(srm);
                    byte[] bufferbyte = new byte[fileLength];
                    int allByte = (int)bufferbyte.Length;
                    int startByte = 0;
                    int i = 0;
                    while (fileLength > 0)
                    {
                        //i++;
                        Application.DoEvents();
                        int downByte = srm.Read(bufferbyte, startByte, allByte);

                        //if (i == 2 && downByte == 0)
                        //{
                        //    proBarDownload.Value = 0;
                        //    existFlag = 1;
                        //    break;
                        //}

                        if (downByte == 0)
                        {
                            break;
                        }

                        startByte += downByte;
                        allByte -= downByte;
                        proBarDownload.Value += downByte;

                        float part = (float)startByte / 1024;
                        float total = (float)bufferbyte.Length / 1024;
                        int percent = Convert.ToInt32((part / total) * 100);                      

                    }

                    //if (existFlag == 1)
                    //{
                    //    CustomMessageBox.CustomMessageBox.Show("找不到资源！", "来自服务器的消息", CustomMessageBox.CustomMessageBox.MsgBoxButtons.OK, CustomMessageBox.CustomMessageBox.MsgBoxIcons.Error);
                    //    this.Close();
                    //    this.Dispose();
                    //}
                    //else
                    //{

                        CreateDirtory(lbDownpath.Text);
                        FileStream fs = new FileStream(lbDownpath.Text, FileMode.OpenOrCreate, FileAccess.Write);
                        fs.Write(bufferbyte, 0, bufferbyte.Length);
                        srm.Close();
                        srmReader.Close();
                        fs.Close();

                        CustomMessageBox.CustomMessageBox.Show("文件下载完成！", "提示", CustomMessageBox.CustomMessageBox.MsgBoxButtons.OK, CustomMessageBox.CustomMessageBox.MsgBoxIcons.Info);

                        this.Close();
                        this.Dispose();

                        if (startFlag == 1)
                        {
                            System.Diagnostics.Process.Start(Startpath);
                        }
                    //}
                }
                catch
                {
                    CustomMessageBox.CustomMessageBox.Show("发生未知错误,文件下载失败！", "错误", CustomMessageBox.CustomMessageBox.MsgBoxButtons.OK, CustomMessageBox.CustomMessageBox.MsgBoxIcons.Error);
                    this.Close();
                    this.Dispose();
                }
            }
        }
            
                    

        //创建目录
        private void CreateDirtory(string path)
        {
            if (!File.Exists(path))
            {
                string[] dirArray = path.Split('\\');
                string temp = string.Empty;
                for (int i = 0; i < dirArray.Length - 1; i++)
                {
                    temp += dirArray[i].Trim() + "\\";
                    if (!Directory.Exists(temp))
                        Directory.CreateDirectory(temp);
                }
            }
        }
    }
}
