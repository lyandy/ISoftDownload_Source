using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSharpWin;

namespace ISoftDownload
{
    public partial class SetForm : SkinForm
    {

        int Flag ;

        public SetForm(int sFlag)
        {
            InitializeComponent();

            if (sFlag == 0)
                chkGo.Checked = false;
            else
                chkGo.Checked = true;
        }

        private void lblGo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://chinetsoft.d209.cnaaa5.com");
        }



        private void setParentStartFlag()
        {
            DownForm db = (DownForm)this.Owner;
            db.StartFlag = Flag;
        }

        private void btxGo_Click(object sender, EventArgs e)
        {
            if (chkGo.Checked == true)
            {
                Flag = 1;
                setParentStartFlag();
            }
            else
            {
                Flag = 0;
                setParentStartFlag();
            }

            this.Close();
        }
    }
}
