using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Drawing;

namespace FastColoredTextBoxNS
{
    public partial class SendForm : Form
    {
        Point mouseOff;                          //鼠标移动位置变量
        bool leftFlag;                               //标签是否为左键

        FastColoredTextBox tb;

        class EllipseStyle : Style
        {
            public override void Draw(Graphics gr, Point position, Range range)
            {
                //get size of rectangle
                Size size = GetSizeOfRange(range);
                //create rectangle
                Rectangle rect = new Rectangle(position, size);
                //inflate it
                rect.Inflate(2, 2);
                //get rounded rectangle
                var path = GetRoundedRectangle(rect, 7);
                //draw rounded rectangle
                gr.DrawPath(Pens.Red, path);
            }
        }

        public SendForm(FastColoredTextBox tb)
        {
            InitializeComponent();
            this.tb = tb;
            if (tb != null)
            {
                this.Location = new Point(-tb.PointToClient(tb.Location).X + tb.Width - this.Width - 20, -tb.PointToClient(tb.Location).Y + tb.Top);
                //Point cur = this.PointToScreen(tb.Location);
            }
        }

        public string GetFindComboBoxText()
        {
            return sendComboBox.Text;
        }
        public void SetFindComboBoxText(string find)
        {
            sendComboBox.Text = find;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

         private void btClear_Click(object sender, EventArgs e)
        {
            //clear search result
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
            this.tb.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnActivated(EventArgs e)
        {
            sendComboBox.Focus();
            ResetSerach();
        }

        void ResetSerach()
        {
        }

        private void cbMatchCase_CheckedChanged(object sender, EventArgs e)
        {
            ResetSerach();
        }

        private void FindForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
                Cursor = Cursors.SizeAll;
            }
        }

        private void FindForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y); //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void FindForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
                Cursor = Cursors.Default;
            }
        }

        private void findComboBox_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
