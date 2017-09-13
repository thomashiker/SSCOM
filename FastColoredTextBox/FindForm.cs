using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace FastColoredTextBoxNS
{
    public partial class FindForm : Form
    {
        FastColoredTextBox tb;

        private bool wholeWordChecked = false;
        private bool caseChecked = false;

        public bool WholeWordChecked
        {
            get { return wholeWordChecked; }
            set
            {
                wholeWordChecked = value;
                if (true == wholeWordChecked)
                {
                    btWholeWord.BackColor = SystemColors.Highlight;
                }
                else
                {
                    btWholeWord.BackColor = SystemColors.Control;
                }
            }
        }

        public bool CaseChecked
        {
            get { return caseChecked; }
            set
            {
                caseChecked = value;
                if (true == caseChecked)
                {
                    btMatchCase.BackColor = SystemColors.Highlight;
                }
                else
                {
                    btMatchCase.BackColor = SystemColors.Control;
                }
            }
        }

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

        public FindForm(FastColoredTextBox tb)
        {
            InitializeComponent();
            this.tb = tb;
            if (tb != null)
            {
                //this.Location = new Point(-tb.PointToClient(tb.Location).X + tb.Width - this.Width - 20, -tb.PointToClient(tb.Location).Y + tb.Top);
                //Point cur = this.PointToScreen(tb.Location);
            }
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        /// <summary>
        /// 为了是主界面能够移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        public string GetFindComboBoxText()
        {
            return findComboBox.Text;
        }
        public void SetFindComboBoxText(string find)
        {
            findComboBox.Text = find;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();
        }

        private void btFindPrevious_Click(object sender, EventArgs e)
        {
            bool exist = false;
            string pattern = findComboBox.Text;

            foreach (Object obj in findComboBox.Items)
            {
                if (obj.ToString() == pattern)
                {
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                findComboBox.Items.Add(pattern);
            }
            FindPrevious(pattern);
        }

        private void btFindNext_Click(object sender, EventArgs e)
        {
            bool exist = false;
            string pattern = findComboBox.Text;

            foreach (Object obj in findComboBox.Items)
            {
                if (obj.ToString() == pattern)
                {
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                findComboBox.Items.Add(pattern);
            }
            FindNext(pattern);
        }

         private void btClear_Click(object sender, EventArgs e)
        {
            UnMarkAll(findComboBox.Text);
        }

        public void HighLightAll(string pattern)
        {
        }

        private void btBookMarkAll_Click(object sender, EventArgs e)
        {
            MarkAll(findComboBox.Text);
            //HighLightAll(findComboBox.Text);
        }

        public virtual void FindNext(string pattern)
        {
            List<Range> ranges = null;
            Place end;

            try
            {
                RegexOptions opt = CaseChecked ? RegexOptions.None : RegexOptions.IgnoreCase;/*match case*/

                if (WholeWordChecked)
                    pattern = "\\b" + pattern + "\\b"; /*match all*/
                //
                Range range = tb.Selection.Clone();
                range.Normalize();
                //
                range.Start = range.End;
                range.End = new Place(tb.GetLineLength(tb.LinesCount - 1), tb.LinesCount - 1);
                //
                ranges = new List<Range>(range.GetRangesByLines(pattern, opt));
                foreach (Range r in ranges)
                {
                    tb.Selection = r;
                    tb.DoSelectionVisible();
                    tb.Invalidate();
                    return;
                }
                //
                end = range.Start;
                range.Start = new Place(0, 0);
                range.End = end;
                //
                ranges = new List<Range>(range.GetRangesByLines(pattern, opt));
                foreach (Range r in ranges)
                {
                    tb.Selection = r;
                    tb.DoSelectionVisible();
                    tb.Invalidate();
                    return;
                }
                //MessageBox.Show("Not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public virtual void FindPrevious(string pattern)
        {
            List<Range> ranges = null;
            Place end;
            try
            {
                RegexOptions opt = CaseChecked ? RegexOptions.None : RegexOptions.IgnoreCase;/*match case*/

                if (WholeWordChecked)
                    pattern = "\\b" + pattern + "\\b";/*match all*/
                //
                Range range = tb.Selection.Clone();
                range.Normalize();
                //
                end = range.Start;
                range.Start = new Place(0, 0);
                range.End = end;
                //
                ranges = new List<Range>(range.GetRangesByLines(pattern, opt));
                ranges.Reverse();
                foreach (Range r in ranges)
                {
                    tb.Selection = r;
                    tb.DoSelectionVisible();
                    tb.Invalidate();
                    return;
                }
                //
                range.Start = range.End;
                range.End = new Place(tb.GetLineLength(tb.LinesCount - 1), tb.LinesCount - 1);
                //
                ranges = new List<Range>(range.GetRangesByLines(pattern, opt));
                ranges.Reverse();
                foreach (Range r in ranges)
                {
                    tb.Selection = r;
                    tb.DoSelectionVisible();
                    tb.Invalidate();
                    return;
                }
                //MessageBox.Show("Not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FCBFindNext()//(string pattern)
        {
            //FindNext(pattern);
            string pattern = findComboBox.Text;

            if (null != pattern)
            {
                FindNext(pattern);
            }
        }

        public void FCBFindPrevious()//(string pattern)
        {
            //FindPrevious(pattern);
            string pattern = findComboBox.Text;

            if (null != pattern)
            {
                FindPrevious(pattern);
            }
        }

        public virtual void MarkAll(string pattern)
        {
            try
            {
                RegexOptions opt = CaseChecked ? RegexOptions.None : RegexOptions.IgnoreCase;/*match case*/

                if (WholeWordChecked)
                    pattern = "\\b" + pattern + "\\b";/*match all*/

                List<int> lines = tb.FindLines(pattern, opt);

                foreach (int line in lines)
                {
                    tb.BookmarkLine(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public virtual void UnMarkAll(string pattern)
        {
            try
            {
                RegexOptions opt = CaseChecked ? RegexOptions.None : RegexOptions.IgnoreCase;/*match case*/

                if (WholeWordChecked)
                    pattern = "\\b" + pattern + "\\b";/*match all*/

                List<int> lines = tb.FindLines(pattern, opt);

                foreach (int line in lines)
                {
                    tb.UnbookmarkLine(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btFindNext.PerformClick();
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '\x1b')//ESC
            {
                Hide();
                e.Handled = true;
                return;
            }
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
            findComboBox.Focus();
        }

        private void findComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindNext(findComboBox.Text);
                e.Handled = true;
            }
        }

        private void btWholeWord_Click(object sender, EventArgs e)
        {
            WholeWordChecked = !WholeWordChecked;
        }

        private void btMatchCase_Click(object sender, EventArgs e)
        {
            CaseChecked = !CaseChecked;
        }
    }
}
