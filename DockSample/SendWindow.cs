using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Threading;
using System.IO;
using SuperContextMenu;
using FastColoredTextBoxNS;
using System.Collections;

namespace DockSample
{
    public partial class SendWindow : DockContent
    {
        private MainForm mainForm;
        //private bool btSendChecked = false;
        private bool btReadOnlyChecked = false;
        //private double floatOpacity = 0.5;
        PoperContainer btLoopContextMenu = new PoperContainer();

        public SendWindow(MainForm owner)
        {
            InitializeComponent();

            btLoopContextMenu.Closing += new ToolStripDropDownClosingEventHandler(btLoopSendContextMenu_closed);
            btLoopContextMenu.Time = cyclicSendTimer.Interval;

            mainForm = owner;
            AutoScaleMode = AutoScaleMode.Dpi;
        }

        public void SetLocationChangedEvent(EventArgs e)
        {
            this.OnLocationChanged(e);
        }

        public void SendToolBarEnable(bool enable)
        {
            /*send tool bar*/
            btSend.Enabled = enable;
            btLoopSend.Enabled = enable;
            btSendFile.Enabled = enable;
            btFileOps.Enabled = enable;
        }

        private bool btLoopChecked = false;
        public bool BTLoopChecked
        {
            get { return btLoopChecked; }
            set
            {
                btLoopChecked = value;
                if (true == btLoopChecked)
                {
                    btLoopSend.BackColor = Color.FromArgb(222, 77, 58);
                }
                else
                {
                    btLoopSend.BackColor = sendPanel.BackColor;
                }
            }
        }

        public string SendTextBoxMsg
        {
            get { return tbSendMsg.Text; }
            set { tbSendMsg.Text = value; }
        }

        private void SendMessage(string msg)
        {
        }

        private void SendLine(string msg)
        {
            StringBuilder sendMsgBuilder = new StringBuilder(msg);
            sendMsgBuilder.Append("\r\n");

            SendMessage(sendMsgBuilder.ToString());
        }

        private bool SendMessageWithoutLog(string msg)
        {
            bool state = true;


            return state;
        }

        private void StartCyclicSendTimer(bool flag)
        {
            cyclicSendTimer.Enabled = flag;
        }

        private void SetCyclicSendTimerInterval(int time)
        {
            cyclicSendTimer.Interval = time;

            if (null != mainForm)
            {
                mainForm.SetTimerPeriodLabel(cyclicSendTimer.Interval.ToString() + "ms");
            }
        }

        private void cyclicSendTimer_Tick(object sender, EventArgs e)
        {
            if (0 != tbSendMsg.Text.Length)
            {
                /*StringBuilder sendMsgBuilder = new StringBuilder(tbSendMsg.Text);
                sendMsgBuilder.Append("\r\n");

                SendMessage(sendMsgBuilder.ToString());*/
                SendLine(tbSendMsg.Text);
            }
        }

        private void ResetFileSendOperation()
        {
            PauseFileSendState = false;
            shuffleTool.Checked = false;
            repeatTool.Checked = false;
        }

        private bool uploadFileButtonCheck = false;

        private bool UploadFileButtonCheck
        {
            get { return uploadFileButtonCheck; }
            set
            {
                uploadFileButtonCheck = value;
                if (true == uploadFileButtonCheck)
                {
                    btSendFile.Image = toolStripimageList.Images[12];
                    //btSendFile.ToolTipText = "Click To Cancel";
                }
                else
                {
                    btSendFile.Image = toolStripimageList.Images[22];
                    //btSendFile.ToolTipText = "Click To Send";
                }
            }
        }

        private bool PauseFileSendState
        {
            get { return pauseTool.Checked; }
            set { pauseTool.Checked = value; }
        }

        private void UploadFileToSend()
        {
            FileStream uploadFS;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt)|*.txt";
            ofd.InitialDirectory = Application.StartupPath;

            if (pauseTool.Checked || shuffleTool.Checked || repeatTool.Checked)
            {
                DialogResult dr;
                string btState;
                btState = pauseTool.Checked ? "Pause is enabled!\n" : null;
                btState += shuffleTool.Checked ? "Shuffle is enabled!\n" : null;
                btState += repeatTool.Checked ? "Repeat is enabled!\n" : null;
                btState += "\nDo you want to reset!";
                dr = MessageBox.Show(btState, "Warning", MessageBoxButtons.YesNoCancel,
                                     MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    ResetFileSendOperation();
                }
                else if (dr == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (false == UploadFileButtonCheck)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    UploadFileButtonCheck = true;
                    uploadFS = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    sendFromFilePgBar.Visible = true;
                    sendFileBGWorker.RunWorkerAsync(uploadFS);
                }
            }
            else
            {
                //cancel
                PauseFileSendState = false;
                sendFileBGWorker.CancelAsync();
            }
        }

        private void sendFileBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            long num;
            byte[] byteData;
            long size;
            int percent;
            UTF8Encoding temp;

            BackgroundWorker myWork = sender as BackgroundWorker;
            FileStream uploadFS = e.Argument as FileStream;
            if (null != uploadFS)
            {
                temp = new UTF8Encoding(true);

                do
                {
                    num = uploadFS.Length;
                    while ((num > 0) && (!myWork.CancellationPending))
                    {
                        while (PauseFileSendState)
                        {
                            Thread.Sleep(1);
                        }
                        size = (num > 100) ? 100 : num;
                        num -= size;
                        byteData = new byte[size];
                        if (uploadFS.Read(byteData, 0, (int)size) > 0)
                        {
                            string output = temp.GetString(byteData);
                            SendMessageWithoutLog(output);
                        }
                        percent = (int)((uploadFS.Length - num) * 100 / uploadFS.Length);
                        try
                        {
                            //trigger ProgressChanged event
                            myWork.ReportProgress(percent);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        //Thread.Sleep(1);
                        Application.DoEvents();
                    }
                    uploadFS.Position = 0;
                } while (repeatTool.Checked && (!myWork.CancellationPending));
                uploadFS.Close();
                if (myWork.CancellationPending)
                {
                    e.Cancel = true;
                }
            }
        }

        private void sendFileBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                //show ProgressPercentage
                sendFromFilePgBar.Value = e.ProgressPercentage;
                //Thread.Sleep(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendFileBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                sendFromFilePgBar.Value = 0;
                sendFromFilePgBar.Visible = false;
                UploadFileButtonCheck = false;
            }
            else
            {
                UploadFileButtonCheck = false;
                //sendFromFilePgBar.Visible = false;
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            /*StringBuilder sendMsgBuilder = new StringBuilder(tbSendMsg.Text);
            sendMsgBuilder.Append("\n");

            SendMessage(sendMsgBuilder.ToString());*/

            SendLine(tbSendMsg.Text);
        }

       private void btSendFile_Click(object sender, EventArgs e)
       {
           UploadFileToSend();
       }

        private void btFileOps_Click(object sender, EventArgs e)
        {
            PauseFileSendState = !PauseFileSendState;
            //pauseToolStrip.Checked = GetBTPauseState();
        }

        private void playTool_Click(object sender, EventArgs e)
       {
           PauseFileSendState = false;
       }

       private void stopTool_Click(object sender, EventArgs e)
       {
           //cancel
           PauseFileSendState = false;
           sendFileBGWorker.CancelAsync();
       }

        private void pauseTool_CheckChanged(object sender, EventArgs e)
        {
            if (pauseTool.Checked)
            {
                btFileOps.Image = toolStripimageList.Images[9];
            }
            else
            {
                btFileOps.Image = toolStripimageList.Images[8];
            }
        }

        private void btLoopSend_Click(object sender, EventArgs e)
        {
            BTLoopChecked = !BTLoopChecked;
            StartCyclicSendTimer(BTLoopChecked);
        }

        private void btLoopSend_MouseDown(object sender, MouseEventArgs e)
        {
            //PoperContainer m_poperContainerForButton;
            //m_poperContainerForButton = new PoperContainer();
            //m_poperContainerForButton.Closed += new ToolStripDropDownClosedEventHandler(btLoopSendContextMenu_closed);
            if (e.Button == MouseButtons.Right)
            {
                btLoopContextMenu.Show(btLoopSend);
            }
        }

        private void btLoopSendContextMenu_closed(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (btLoopContextMenu.Time > 0)
            {
                SetCyclicSendTimerInterval(btLoopContextMenu.Time);
            }
        }

        private void fctbSend_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.X < fctbSend.LeftIndent)
            {
                var place = fctbSend.PointToPlace(e.Location);
                if (fctbSend.Bookmarks.Contains(place.iLine))
                    fctbSend.Bookmarks.Remove(place.iLine);
                else
                    fctbSend.Bookmarks.Add(place.iLine);
            }
        }

        private void sendCurrentItem_Click(object sender, EventArgs e)
        {
            string msg = fctbSend.GetLineText(fctbSend.Selection.Start.iLine);//place.iLine
            /*StringBuilder sendMsgBuilder = new StringBuilder(msg);
            sendMsgBuilder.Append("\n");

            SendMessage(sendMsgBuilder.ToString());*/

            SendLine(msg);
        }

        private void sendSelectedItem_Click(object sender, EventArgs e)
        {
            if (null != fctbSend.SelectedText && 0 != fctbSend.SelectedText.Length)
            {
                SendLine(fctbSend.SelectedText);
            }
        }

        private void copyItem_Click(object sender, EventArgs e)
        {
            fctbSend.Copy();
        }

        private void cutItem_Click(object sender, EventArgs e)
        {
            fctbSend.Cut();
        }

        private void pasteItem_Click(object sender, EventArgs e)
        {
            fctbSend.Paste();
        }

        private void deleteLineItem_Click(object sender, EventArgs e)
        {
            fctbSend.ClearCurrentLine();
        }

        private void fctbSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (btReadOnlyChecked)
            {
                if (e.KeyCode == Keys.Enter)//enter
                {
                    string msg = fctbSend.GetLineText(fctbSend.Selection.Start.iLine);//place.iLine
                    SendLine(msg);
                    fctbSend.Navigate(fctbSend.Selection.Start.iLine + 1);//NavigateBackward();
                    fctbSend.SelectionStart += fctbSend.GetLineLength(fctbSend.Selection.Start.iLine);

                    e.Handled = true;
                }
            }
        }

        private void fctbSend_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show();
            tbSendMsg.Text = fctbSend.GetLineText(fctbSend.Selection.Start.iLine);
        }

        /*private void zoomInItem_Click(object sender, EventArgs e)
        {
            fctbSend.Zoom += 10;
        }

        private void zoomOutItem_Click(object sender, EventArgs e)
        {
            fctbSend.Zoom -= 10;
        }*/

        private void btMenu_Click(object sender, EventArgs e)
        {
            settingMenu.Show(Cursor.Position);
        }

        private void clearTagsTool_Click(object sender, EventArgs e)
        {
            int line = 0;
            while (line < fctbSend.LinesCount)
            {
                fctbSend.Bookmarks.Remove(line);
                line++;
            }
        }

        private void clearAllTool_Click(object sender, EventArgs e)
        {
            fctbSend.Clear();
        }

        private void uploadTool_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //FileStream fs = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read);
               // StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.UTF8);
                //String line;
                fctbSend.OpenFile(fileDialog.FileName, UTF8Encoding.UTF8);
               // sr.Close();
            }
        }

        private void saveFileTool_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            fileDialog.FileName = "cmd_script_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            fileDialog.FilterIndex = 1;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fctbSend.SaveToFile(fileDialog.FileName, UTF8Encoding.UTF8);
            }
        }

        private void settingTool_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I'm Waiting");
        }

        private void tbSendMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//enter
            {
                SendLine(tbSendMsg.Text);

                e.Handled = true;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbSendMsg.Text = null;
        }

        private void sendUnorderItem_Click(object sender, EventArgs e)
        {
            int range = fctbSend.LinesCount;
            Hashtable hashtable = new Hashtable();
            Random rm = new Random();
            int RmNum = range;
            int max = range + 1;
            while (hashtable.Count < RmNum)
            {
                int nValue = rm.Next(max);
                if (!hashtable.ContainsValue(nValue) && nValue != 0)
                {
                    hashtable.Add(nValue, nValue);
                    string msg = fctbSend.GetLineText(nValue - 1);
                    SendLine(msg);
                }
            }
        }

        private void sendAllTagsItem_Click(object sender, EventArgs e)
        {
            foreach (Bookmark mark in fctbSend.Bookmarks)
            {
                string msg = fctbSend.GetLineText(mark.LineIndex);
                SendLine(msg);
            }
        }

        private void sendNextTagItem_Click(object sender, EventArgs e)
        {
            fctbSend.GotoNextBookmark(fctbSend.Selection.Start.iLine);
            string msg = fctbSend.GetLineText(fctbSend.Selection.Start.iLine);
            SendLine(msg);
        }

        private void btReadOnly_Click(object sender, EventArgs e)
        {
            btReadOnlyChecked = !btReadOnlyChecked;
            fctbSend.ReadOnly = btReadOnlyChecked;
            if (fctbSend.ReadOnly)
            {
                btReadOnly.BackColor = Color.FromArgb(222, 77, 58);
            }
            else
            {
                btReadOnly.BackColor = sendPanel.BackColor;
            }
        }

        private void SendWindow_LocationChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("SendWindow_LocationChanged");
            if (null != fctbSend.findForm)
            {
                //fastColoredTextBox.findForm.TopMost = true;
                fctbSend.findForm.Location = new Point(-this.PointToClient(this.Location).X + this.Width - fctbSend.findForm.Width - 20, -this.PointToClient(this.Location).Y + this.Top + 26);
            }
            if (null != fctbSend.replaceForm)
            {
                fctbSend.replaceForm.Location = new Point(-this.PointToClient(this.Location).X + this.Width - fctbSend.replaceForm.Width - 20, -this.PointToClient(this.Location).Y + this.Top + 26);
            }
        }

        private void SendWindow_TextChanged(object sender, EventArgs e)
        {
            if (null != fctbSend.findForm)
            {
                //fastColoredTextBox.findForm.TopMost = true;
                fctbSend.findForm.Location = new Point(-this.PointToClient(this.Location).X + this.Width - fctbSend.findForm.Width - 20, -this.PointToClient(this.Location).Y + this.Top + 26);
            }
            if (null != fctbSend.replaceForm)
            {
                fctbSend.replaceForm.Location = new Point(-this.PointToClient(this.Location).X + this.Width - fctbSend.replaceForm.Width - 20, -this.PointToClient(this.Location).Y + this.Top + 26);
            }
        }

        private void SendWindow_SizeChanged(object sender, EventArgs e)
        {
            if (null != fctbSend.findForm)
            {
                //fastColoredTextBox.findForm.TopMost = true;
                fctbSend.findForm.Location = new Point(-this.PointToClient(this.Location).X + this.Width - fctbSend.findForm.Width - 20, -this.PointToClient(this.Location).Y + this.Top + 26);
            }
            if (null != fctbSend.replaceForm)
            {
                fctbSend.replaceForm.Location = new Point(-this.PointToClient(this.Location).X + this.Width - fctbSend.replaceForm.Width - 20, -this.PointToClient(this.Location).Y + this.Top + 26);
            }
        }
    }
}
