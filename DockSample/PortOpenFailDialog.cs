using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;

namespace DockSample
{
    public partial class PortOpenFailDialog : Form
    {
        public PortOpenFailDialog(SerialPort port)
        {
            InitializeComponent();

            if (null != port)
            {
                portNameLabel.Text = port.PortName;
                baudRateLabel.Text = port.BaudRate.ToString();
                parityLabel.Text   = port.Parity.ToString();
                dataBitsLabel.Text = port.DataBits.ToString();
                stopBitsLabel.Text = port.StopBits.ToString();
            }
        }

        public PortOpenFailDialog(SerialPort port, string btName)
        {
            InitializeComponent();

            btCancel.Text = btName;

            if (null != port)
            {
                portNameLabel.Text = port.PortName;
                baudRateLabel.Text = port.BaudRate.ToString();
                parityLabel.Text = port.Parity.ToString();
                dataBitsLabel.Text = port.DataBits.ToString();
                stopBitsLabel.Text = port.StopBits.ToString();
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
        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void btIgnore_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void PortOpenFailDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
