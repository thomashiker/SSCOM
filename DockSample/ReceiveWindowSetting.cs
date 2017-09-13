using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DockSample
{
    public partial class ReceiveWindowSetting : Form
    {
        private MainForm mainForm;
        private string defaultLogPath = null;

        private float[] allFontSize = {42, 36, 26.25F, 24, 21.75F, 18, 15.75F, 15, 14.25F, 12, 10.5F, 9, 7.5F, 6.75F, 
                5.25F, 5.25F, 5, 5.5F, 6.5F, 7.5F, 8, 9, 9.75F, 10.5F, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72};
        public ReceiveWindowSetting(MainForm parentForm)
        {
            mainForm = parentForm;
            InitializeComponent();

            foreach (FontFamily family in FontFamily.Families)
            {
                fontComboBox.Items.Add(family.Name);
                //sampleFCTBox.AppendText(family.Name + "\r\n");
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
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void LoadSetting()
        {
            int index;

            /*load current setting*/

            //font
            index = fontComboBox.FindString(sampleFCTBox.Font.FontFamily.Name);
            fontComboBox.SelectedIndex = (index < 0) ? 0 : index;
            
            //style
            index = receiveWinFontStyleComboBox.FindString(sampleFCTBox.Font.Style.ToString());
            receiveWinFontStyleComboBox.SelectedIndex = (index < 0) ? 0 : index;

            //size
            index = receiveWinFontSizeComboBox.FindString(sampleFCTBox.Font.Size.ToString());
            if (index >= 0)
            {
                receiveWinFontSizeComboBox.SelectedIndex = index;
            }

            //text color
            foreColorRadioButton.Checked = true;
            index = rcvColorComboBox.FindColorIndex(sampleFCTBox.ForeColor);
            rcvColorComboBox.SelectedIndex = (index < 0) ? 0 : index;

            //line color
            lineNumberRadioButton.Checked = true;
            index = lineColorCombobox.FindColorIndex(sampleFCTBox.LineNumberColor);
            lineColorCombobox.SelectedIndex = (index < 0) ? 0 : index;

            //set bookmark
            sampleFCTBox.BookmarkLine(0);
            sampleFCTBox.BookmarkLine(1);
        }

        private void DownLoadSetting()
        {
        }

        public void CenterShow()
        {
            LoadSetting();

            this.CenterToParent();
            this.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Visible = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DownLoadSetting();

            //this.Close();
            this.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DownLoadSetting();
        }

        private void receiveWinCharSetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void receiveWinFontStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontStyle style = (FontStyle)System.Enum.Parse(typeof(FontStyle), receiveWinFontStyleComboBox.Text, true);
            sampleFCTBox.Font = new Font(sampleFCTBox.Font.FontFamily, sampleFCTBox.Font.Size, style);
        }

        private void receiveWinFontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = receiveWinFontSizeComboBox.SelectedIndex;
            sampleFCTBox.Font = new Font(sampleFCTBox.Font.FontFamily, allFontSize[index], sampleFCTBox.Font.Style);
        }

        private void rcvTextColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (foreColorRadioButton.Checked)
            {
                //
                sampleFCTBox.ForeColor = rcvColorComboBox.SelectedColor();
            }

            if (backgroundRadioButton.Checked)
            {
                //
                sampleFCTBox.BackColor = rcvColorComboBox.SelectedColor();
            }

            if (selectionRadioButton.Checked)
            {
                //
                sampleFCTBox.SelectionColor = rcvColorComboBox.SelectedColor();
            }
        }

        private void lineColorComobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lineNumberRadioButton.Checked)
            {
                //
                sampleFCTBox.LineNumberColor = lineColorCombobox.SelectedColor();
            }

            if (indentBackRadioButton.Checked)
            {
                //
                sampleFCTBox.IndentBackColor = lineColorCombobox.SelectedColor();
            }

            if (bookMarkRadioButton.Checked)
            {
                //
                sampleFCTBox.BookmarkColor = lineColorCombobox.SelectedColor();
                sampleFCTBox.UnbookmarkLine(0);
                sampleFCTBox.UnbookmarkLine(1);
                sampleFCTBox.BookmarkLine(0);
                sampleFCTBox.BookmarkLine(1);
            }
        }

        private void foreColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            int index;
            if (foreColorRadioButton.Checked)
            {
                index = rcvColorComboBox.FindColorIndex(sampleFCTBox.ForeColor);
                rcvColorComboBox.SelectedIndex = (index < 0) ? 0 : index;
            }
        }

        private void backgroundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            int index;
            if (backgroundRadioButton.Checked)
            {
                index = rcvColorComboBox.FindColorIndex(sampleFCTBox.BackColor);
                rcvColorComboBox.SelectedIndex = (index < 0) ? 0 : index;
            }
        }

        private void selectionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            int index;
            if (selectionRadioButton.Checked)
            {
                index = rcvColorComboBox.FindColorIndex(sampleFCTBox.SelectionUnFormatColor);
                rcvColorComboBox.SelectedIndex = (index < 0) ? 0 : index;
            }
        }

        private void lineNumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            int index;
            if (lineNumberRadioButton.Checked)
            {
                index = lineColorCombobox.FindColorIndex(sampleFCTBox.LineNumberColor);
                lineColorCombobox.SelectedIndex = (index < 0) ? 0 : index;
            }
        }

        private void indentBackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            int index;
            if (indentBackRadioButton.Checked)
            {
                index = lineColorCombobox.FindColorIndex(sampleFCTBox.IndentBackColor);
                lineColorCombobox.SelectedIndex = (index < 0) ? 0 : index;
            }
        }

        private void bookMarkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            int index;
            if (bookMarkRadioButton.Checked)
            {
                index = lineColorCombobox.FindColorIndex(sampleFCTBox.BookmarkColor);
                lineColorCombobox.SelectedIndex = (index < 0) ? 0 : index;
            }
        }

        private void btOpenPath_Click(object sender, EventArgs e)
        {
            //
            folderBrowserDialog.SelectedPath = System.IO.Directory.GetCurrentDirectory();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbLogPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void rbCurrentPath_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDefaultPath.Checked)
            {
                tbLogPath.Enabled = false;
                btOpenPath.Enabled = false;
            }
        }

        private void rbCustomPath_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomPath.Checked)
            {
                tbLogPath.Enabled = true;
                btOpenPath.Enabled = true;
            }
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "配置文件(*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbConfigurationFile.Text = openFileDialog.FileName;
            }
        }

        private void rbDefaultFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDefaultFile.Checked)
            {
                tbConfigurationFile.Enabled = false;
                btOpenFile.Enabled = false;
            }
        }

        private void rbCustomFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomFile.Checked)
            {
                tbConfigurationFile.Enabled = true;
                btOpenFile.Enabled = true;
            }
        }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily ff = new FontFamily(fontComboBox.Text);
            sampleFCTBox.Font = new Font(ff, sampleFCTBox.Font.Size, sampleFCTBox.Font.Style);
        }
    }
}
