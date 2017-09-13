using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;
using DockSample.Customization;
using System.Diagnostics;
using FastColoredTextBoxNS;
using CSharpWin_JD.CaptureImage;
using ColorListBoxSelector;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using CCWin;
using CCWin.SkinClass;
using CCWin.SkinControl;
using CCWin.Win32;
using SuperContextMenu;
using PortSettingContextMenu;
using TextListContextMenu;


namespace DockSample
{
    public partial class MainForm : CCSkinMain
    {
        private string SavedLogPath;
        private string openLogFileApplication = "notepad++.exe";
        //private bool btRepeatedSendEnable = false;
        private string logPath = "log";
        private string logFileName = null;
        private bool fctbRcvAutoScroll = true;
        private Int64 rcvCharNum = 0;
        private Int64 sendCharNum = 0;
        private Int64 TimeElapse = 0;

        SendHistoryForm sendHistory = new SendHistoryForm();

        private PortSettingContainer portSelectMenu = new PortSettingContainer();
        private TextListContainer sentList = new TextListContainer();

        public delegate void UpdateTxtEventHandler(string text);
        public delegate void UpdateDigitEventHandler(Int64 digit);


        public string LogPath
        {
            get { return SavedLogPath; }
            set { SavedLogPath = value; }
        }

        public string LogFile
        {
            get { return logFileName; }
            set { logFileName = value; }
        }

        private void btLoopSendContextMenu_closed(object sender, ToolStripDropDownClosingEventArgs e)
        {
            /*if (btLoopContextMenu.Time > 0)
            {
                SetCyclicSendTimerInterval(btLoopContextMenu.Time);
            }*/
        }

        bool PortInit()
        {
            serialPort.Encoding = System.Text.Encoding.GetEncoding("GB2312");

            return true;
        }

        private string GetPortSetting()
        {
            string state = null;

            if (null != serialPort)
            {
                state = serialPort.PortName + ","
                        + serialPort.BaudRate.ToString() + ","
                        + serialPort.DataBits.ToString() + ","
                        + serialPort.StopBits.ToString() + ","
                        + serialPort.Parity.ToString();
            }

            return state;
        }

        private bool IsPortOpen()
        {
            return serialPort.IsOpen;
        }

        private void PortStateUpdate()
        {
            if (IsPortOpen())
            {
                btOpenClose.Image = global::DockSample.Properties.Resources.connect;
                lableConectState.Text = GetPortSetting();
                lableConectState.Font = new Font(lableConectState.Font, FontStyle.Regular);
                lableConectState.ForeColor = Color.Green;

                LinkTimer.Start();
            }
            else
            {
                btOpenClose.Image = global::DockSample.Properties.Resources.connection_error;
                //lableConectState.Text = "No Conection";
                lableConectState.Font = new Font(lableConectState.Font, FontStyle.Strikeout);
                lableConectState.ForeColor = Color.Red;

                LinkTimer.Stop();
            }
        }

        private bool OpenPort()
        {
            if (null == serialPort)
                return false;

            if (!IsPortOpen())
            {
                //MessageBox.Show(serialPort.PortName + " is openning!");
                try
                {
                    serialPort.Open();
                }
                catch
                {
                }
            }

            PortStateUpdate();

            return true;
        }

        private bool ClosePort()
        {
            if (null == serialPort)
                return false;

            if (IsPortOpen())
            {
                try
                {
                    serialPort.Close();
                }
                catch
                {
                }
            }

            PortStateUpdate();

            return true;
        }
        private void portSettingContextMenu_closed(object sender, ToolStripDropDownClosingEventArgs e)
        {
            ClosePort();

            serialPort.PortName = portSelectMenu.Port.PortName;
            serialPort.BaudRate = portSelectMenu.Port.BaudRate;
            serialPort.DataBits = portSelectMenu.Port.DataBits;
            serialPort.StopBits = portSelectMenu.Port.StopBits;
            serialPort.Parity = portSelectMenu.Port.Parity;

            OpenPort();
        }

        public MainForm()
        {
            InitializeComponent();


            portSelectMenu.Closing += new ToolStripDropDownClosingEventHandler(portSettingContextMenu_closed);

            //serialPort.Encoding = System.Text.Encoding.GetEncoding("GB2312");

            SavedLogPath = Application.StartupPath + "\\log";

            linkTimeLabel.Alignment = ToolStripItemAlignment.Right;

            InitialNotifyMenu();
        }

        public void SetTimerPeriodLabel(string label)
        {
            sendTimerPeriodLabel.Text = label;
        }

        #region Methods

        public void SetOpenLogsApplication(string file)
        {
            openLogFileApplication = file;
        }

        public void SetOpenLogsPath(string path)
        {
            SavedLogPath = path;
        }

        #endregion

        private void toolBarButtonOpen_Click(object sender, EventArgs e)
        {
            if (IsPortOpen())
            {
                ClosePort();
            }
            else
            {
                OpenPort();
            }
        }

        public bool SetRecordState(bool state)
        {
            if (state)
            {
                tBarButtonRecord.Image = global::DockSample.Properties.Resources.MD_record; //toolStripimageList.Images[11];
                tBarButtonRecord.ToolTipText = "Click to Stop Record";
            }
            else
            {
                tBarButtonRecord.Image = global::DockSample.Properties.Resources.MD_stop;//toolStripimageList.Images[12];
                tBarButtonRecord.ToolTipText = "Click to Start Record";
            }
            return true;
        }
        private void toolBarButtonLogEnable_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButtonCloseWindow_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButtonScreenShot_Click(object sender, EventArgs e)
        {
            CaptureImageTool capture = new CaptureImageTool();

            capture.SelectCursor = Cursors.Default;
            capture.DrawCursor = Cursors.Default;
            if (capture.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void ColorSettingToolStripButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            //cd.Color = textBox1.ForeColor;

            //if (cd.ShowDialog() == DialogResult.OK)
                //textBox1.ForeColor = MyDialog.Color;

            cd.ShowDialog();
        }

        private void toolStripButtonFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            fd.ShowApply = true;
            //fd.AnyColor = true;
            fd.ShowDialog();
        }

                //lableConectState.Font = new Font(lableConectState.Font.Name, lableConectState.Font.Size, FontStyle.Regular);
                //lableConectState.Font = new Font(lableConectState.Font.Name, lableConectState.Font.Size, FontStyle.Strikeout);

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            fctbRcv.Clear();
            labelRcvNum.Text = "0";
        }

        private string CreateLogFile()
        {
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }
            //if (this.LogFile == null)
            //{
            this.LogFile = logPath + "\\" + "[" + serialPort.PortName + "]" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            //}
            /*            else
                        {
                            this.LogFile = "[" + serialPort.PortName + "]" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
                        }*/

            if (!File.Exists(this.LogFile))
            {
                FileStream fs = new FileStream(this.LogFile, FileMode.Create, FileAccess.ReadWrite);
                fs.Close();
            }

            return this.LogFile;
        }

        private void newLogToolStripButton_Click(object sender, EventArgs e)
        {
            CreateLogFile();
        }

        private void toolBarButtonOpenLog_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(openLogFileApplication, this.LogFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showLineToolStripButton_Click(object sender, EventArgs e)
        {
            fctbRcv.ShowLineNumbers = !fctbRcv.ShowLineNumbers;
            if (!fctbRcv.ShowLineNumbers)
            {
                fctbRcv.Bookmarks.Clear();
            }
        }

        private void rmAllBookmarksButton_Click(object sender, EventArgs e)
        {
            //fctbRcv.Bookmarks.Clear();
            int line = 0;
            while (line < fctbRcv.LinesCount)
            {
                fctbRcv.Bookmarks.Remove(line);
                line++;
            }
        }

        private void tsBtFindNext_Click(object sender, EventArgs e)
        {
            fctbRcv.findForm.FCBFindNext();
        }

        private void tsBtFindPrevious_Click(object sender, EventArgs e)
        {
            fctbRcv.findForm.FCBFindPrevious();
        }

        private void topMostButton_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
                topMostButton.Image = toolStripimageList.Images[6];
            }
            else{
                this.TopMost = true;
                topMostButton.Image = toolStripimageList.Images[7];
            }
        }

        public void SaveToFileAs()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.DefaultExt = "txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fctbRcv.SaveToFile(fileDialog.FileName, Encoding.GetEncoding("GB2312"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            SaveToFileAs();
        }

        private void openLogFolderButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
                psi.Arguments = "/e,/select," + SavedLogPath;
            System.Diagnostics.Process.Start(psi);
            //System.Diagnostics.Process.Start("explorer.exe", path);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T && e.Control)
            {
                e.Handled = true;

                //sendwin.Display();
                //MessageBox.Show("MainForm_KeyDown");
            }
        }

        private void UpdateRcvCharDisplay(Int64 num)
        {
            labelRcvNum.Text = num.ToString();
        }

        private void UpdateSendCharDisplay(Int64 num)
        {
            labelSendNum.Text = num.ToString();
        }

        private void UpdateLinkTimeDisplay(Int64 time)
        {
            Int64 seconds;
            Int64 hours;
            Int64 minutes;

            this.Invoke((EventHandler)(delegate
            {
                seconds = time % 60;
                hours = time / 60;
                minutes = (hours) % 60;
                hours = hours / 60;
                linkTimeLabel.Text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
            }));
        }

        private void tsBtGoBack_Click(object sender, EventArgs e)
        {
            fctbRcv.NavigateBackward();
        }

        private void tsBtGoForward_Click(object sender, EventArgs e)
        {
            fctbRcv.NavigateForward();
        }

        private void InitialNotifyMenu()
        {
            notifyMenu.Icon = this.Icon;

            if (null != notifyMenu.ContextMenuStrip)
            {
                //CreatDropDownPorts();
            }
            else
            {
                notifyMenu.ShowBalloonTip(1000, "Error", "Menu Create Failed!", ToolTipIcon.Error);
            }

            //mainTimer.Start();
        }

        private void notifyMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Activate();
                    //this.ShowInTaskbar = true;
                }
                else
                {
                    this.WindowState = FormWindowState.Minimized;
                   // this.ShowInTaskbar = false;
                }
            }
        }

        private void notifyTSMIExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyTSMIShow_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Activate();
                this.ShowInTaskbar = true;
            }
            this.Visible = true;
        }

        private void MainForm_SysBottomClick(object sender, SysButtonEventArgs e)
        {
            if (e.SysButton.Name == "SysMenu")
            {
                sysMenu.Show(MousePosition);
            }
        }

        private void btTopMost_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
                btTopMost.BackColor = this.BackColor;
            }
            else
            {
                this.TopMost = true;
                btTopMost.BackColor = Color.FromArgb(222, 77, 58);
            }
        }

        private void btSysMenu_Click(object sender, EventArgs e)
        {
            //Point p = btSysMenu.PointToClient(btSysMenu.Location);
            
            sysMenu.Show(Cursor.Position);//Cursor.Position);
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btMaximize.Text = "2";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btMaximize.Text = "1";
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                btMaximize.Text = "1";
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                btMaximize.Text = "1";
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                btMaximize.Text = "2";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btPortSetting_Click(object sender, EventArgs e)
        {
            //portSettingMenu.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            //portSettingMenu.Show(Cursor.Position.X, Cursor.Position.Y);
            //sendHistory.listbox.Items.Add(tbSend.Text);
            sentList.AddItem(tbSend.Text);
        }

        private void fctbRcv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.X < fctbRcv.LeftIndent)
            {
                var place = fctbRcv.PointToPlace(e.Location);
                if (fctbRcv.Bookmarks.Contains(place.iLine))
                    fctbRcv.Bookmarks.Remove(place.iLine);
                else
                    fctbRcv.Bookmarks.Add(place.iLine);
            }
        }

        private void btSize_ButtonClick(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)btSize.DefaultItem;
            if (null != item)
                item.Checked = false;
            fctbRcv.Zoom = 100;
            btSize.Text = "Zoom";
        }

        private void btSize_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)btSize.DefaultItem;
            if (null != item)
                item.Checked = false;
            btSize.DefaultItem = e.ClickedItem;
            item = (ToolStripMenuItem)btSize.DefaultItem;
            item.Checked = true;
            btSize.Text = btSize.DefaultItem.Text;
            fctbRcv.Zoom = Convert.ToInt32(btSize.Text.TrimEnd((char[])"%".ToCharArray()));
        }

        private void PortListMenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)e.ClickedItem;
            //PortListMenu.Text = item.Text;
        }

        private void btPortSelect_Click(object sender, EventArgs e)
        {
            //portSelectMenu.Show(btPortSelect);
            portSelectMenu.Show(this, new Point (btPortSetting.Width, toolBar.Bottom));
        }

        private void btPortSetting_Click_1(object sender, EventArgs e)
        {
            portSelectMenu.Show(this, new Point(3, toolBar.Bottom));
        }

        private void Log(string msg)
        {
            fctbRcv.Invoke(new EventHandler(delegate
            {
                fctbRcv.AppendText(msg);
                if (fctbRcvAutoScroll)
                {
                    fctbRcv.GoEnd();
                }
            }));
        }
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = serialPort.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致  
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据  
            rcvCharNum += n;//增加接收计数  
            serialPort.Read(buf, 0, n); ;//读取缓冲数据

            StringBuilder builder = new StringBuilder();
            builder.Clear();//清除字符串构造器的内容  
            //因为要访问ui资源，所以需要使用invoke方式同步ui。  
            this.Invoke((EventHandler)(delegate
            {
                //直接按ASCII规则转换成字符串  
                builder.Append(Encoding.ASCII.GetString(buf));
                //追加的形式添加到文本框末端，并滚动到最后。  
                fctbRcv.AppendText(builder.ToString());
                if (fctbRcvAutoScroll)
                {
                    fctbRcv.GoEnd();
                }
                UpdateRcvCharDisplay(rcvCharNum);
            }));


            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
        }

        private bool SendMessage(string msg, bool save2file)
        {
            if (msg == null)
            {
                return true;
            }

            if (IsPortOpen())
            {
                try
                {
                    this.Invoke((EventHandler)(delegate
                    {
                        StringBuilder builder = new StringBuilder(msg);
                        builder.Append("\r\n");
                        //fctbRcv.AppendText(builder.ToString());

                        serialPort.Write(builder.ToString());

                        sendCharNum += msg.Length;
                        labelSendNum.Text = sendCharNum.ToString();

                        fctbRcv.AppendText(builder.ToString());

                        if (save2file)
                        {
                            //SaveSendLogToFile(msg);
                        }
                    }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            SendMessage(tbSend.Text, true);
        }

        private void btHistory_Click(object sender, EventArgs e)
        {
            sentList.Show(tbSend);
            //sendHistory.ShowForm(tbSend);
        }

        public string MsgToSend
        {
            get { return tbSend.Text; }
            set {
                this.Invoke((EventHandler)(delegate
                {
                    tbSend.Text = value;
                }));
            }
        }

        private void ReceiveUserInput(string input)
        {
            MsgToSend = MsgToSend + input;
        }

        private void MinusUserInputChar()
        {
            string userInputMsg = MsgToSend;

            if (null != userInputMsg)
            {
                if (userInputMsg.Length > 1)
                {
                    userInputMsg = userInputMsg.Remove(userInputMsg.Length - 1);
                }
                else
                {
                    userInputMsg = null;
                }
            }

            MsgToSend = userInputMsg;
        }

        private void fctbRcv_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ReceiveUserInput("\n");
                    StringBuilder sendMsgBuilder = new StringBuilder(MsgToSend);
                    SendMessage(sendMsgBuilder.ToString(), true);
                    MsgToSend = null;
                    e.Handled = true;
                    break;
                case Keys.Back:
                    MinusUserInputChar();
                    e.Handled = true;
                    break;
                case Keys.Delete:
                    e.Handled = true;
                    break;
                default:
                    break;
            }
        }

        private void fctbRcv_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            if (input > 31 && input < 126)
            {
                ReceiveUserInput(input.ToString());
            }
        }

        private void fctbRcv_KeyPressed(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            if (input > 31 && input < 126)
            {
                ReceiveUserInput(input.ToString());
            }
        }

        private void LinkTimer_Tick(object sender, EventArgs e)
        {
            TimeElapse++;
            UpdateLinkTimeDisplay(TimeElapse);
        }
    }
}