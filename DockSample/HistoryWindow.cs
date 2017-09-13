using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DockSample
{
    public partial class HistoryWindow : Form
    {
        private Point mouseOff;                          //鼠标移动位置变量
        private bool leftFlag;                               //标签是否为左键
        public HistoryWindow()
        {
            InitializeComponent();
            /*if (parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(parent.Left + parent.Width / 2 - this.Width / 2, parent.Top + parent.Height / 2 - this.Height / 2);
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterScreen;
            }*/
        }

        public void Show(Form parent)
        {
            if (parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(parent.Left + parent.Width / 2 - this.Width / 2, parent.Top + parent.Height / 2 - this.Height / 2);
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            this.Show();
        }

        private void HistoryWindow_Deactivate(object sender, EventArgs e)
        {
            if (!this.TopMost)
            {
                //this.Close();
                this.Hide();
            }
        }

        private void toolStrip_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
                Cursor = Cursors.SizeAll;
                this.Opacity = 0.65;
            }
        }

        private void toolStrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y); //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void toolStrip_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
                Cursor = Cursors.Default;
                this.Opacity = 0.95;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();//fixme
        }

        private void topMostButton_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                topMostButton.Image = menuImageList.Images[0];
            }
            else
            {
                topMostButton.Image = menuImageList.Images[1];
            }
            this.TopMost = !this.TopMost;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //contextMenuStrip.Show(Cursor.Position);
            //contextMenuStrip.Show(menuButton.l);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            //send
        }
    }
}
