using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace FastColoredTextBoxNS
{
    public partial class GoToForm : Form
    {
        public int SelectedLineNumber { get; set; }
        public int TotalLineCount { get; set; }

        public GoToForm()
        {
            InitializeComponent();
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.tbLineNumber.Text = this.SelectedLineNumber.ToString();

            this.label.Text = String.Format("Line(1 - {0}):", this.TotalLineCount);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            this.tbLineNumber.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int enteredLine;
            if (int.TryParse(this.tbLineNumber.Text, out enteredLine))
            {
                enteredLine = Math.Min(enteredLine, this.TotalLineCount);
                enteredLine = Math.Max(1, enteredLine);

                this.SelectedLineNumber = enteredLine;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
         }

        private void tbLineNumber_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.Handled = true;
                    int enteredLine;
                    if (int.TryParse(this.tbLineNumber.Text, out enteredLine))
                    {
                        enteredLine = Math.Min(enteredLine, this.TotalLineCount);
                        enteredLine = Math.Max(1, enteredLine);

                        this.SelectedLineNumber = enteredLine;
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
