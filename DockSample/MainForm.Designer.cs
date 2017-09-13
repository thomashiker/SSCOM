using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO.Ports;
using System.IO;
using System.Collections;


namespace DockSample
{
    public class PortInfo
    {
        private string port;
        private string baudrate;
        private string databits;
        private string stopbits;
        private string parity;
        private string flow;
        public string Port
        {
            get { return port; }
            set { port = value; }
        }
        public string BaudRate
        {
            get { return baudrate; }
            set { baudrate = value; }
        }
        public string DataBits
        {
            get { return databits; }
            set { databits = value; }
        }
        public string Stopbits
        {
            get { return stopbits; }
            set { stopbits = value; }
        }
        public string Parity
        {
            get { return parity; }
            set { parity = value; }
        }
        public string Flow
        {
            get { return flow; }
            set { flow = value; }
        }

        public string GetPortName()
        {
            return port;
        }
        public int GetPortBaudRate()
        {
            return int.Parse(baudrate);
        }
        public int GetPortDataBits()
        {
            return int.Parse(databits);
        }
        public StopBits GetPortStopBits()
        {
            switch (stopbits)
                {
                    case "1":
                        return StopBits.One;
                    case "1.5":
                        return StopBits.OnePointFive;
                    case "2":
                        return StopBits.Two;
                    default:
                        break;
                }
            return StopBits.One;
        }

        public Parity GetPortParity()
        {
            return (Parity)Enum.Parse(typeof(Parity), parity);;
        }
        public string GetPortFlow()
        {
            return flow;
        }
        public override string ToString()
        {
            return (baudrate + "," + databits + "," + stopbits + "," + parity + "," + flow);
        }
    };

    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btPortSetting = new System.Windows.Forms.ToolStripButton();
            this.btOpenClose = new System.Windows.Forms.ToolStripButton();
            this.toolBarButtonSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsButton = new System.Windows.Forms.ToolStripButton();
            this.btClear = new System.Windows.Forms.ToolStripButton();
            this.btShowLine = new System.Windows.Forms.ToolStripButton();
            this.btRmAllBookmarks = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tBarButtonRecord = new System.Windows.Forms.ToolStripButton();
            this.newLogToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolBarButtonOpenLog = new System.Windows.Forms.ToolStripButton();
            this.openLogFolderButton = new System.Windows.Forms.ToolStripButton();
            this.toolBarButtonSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.topMostButton = new System.Windows.Forms.ToolStripButton();
            this.tsBtGoBack = new System.Windows.Forms.ToolStripButton();
            this.tsBtGoForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtFindPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsBtFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.screenShotButton = new System.Windows.Forms.ToolStripButton();
            this.btHideSendBar = new System.Windows.Forms.ToolStripButton();
            this.btSize = new System.Windows.Forms.ToolStripSplitButton();
            this.zoomItem0 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStripimageList = new System.Windows.Forms.ImageList(this.components);
            this.systemStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lableConectState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendTimerPeriodLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelSendNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelRcvNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.linkTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyMenu = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyTSMIShow = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyTSMINewPort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.notifyTSMIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.sysMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingSysMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.themeSysMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btTopMost = new System.Windows.Forms.Button();
            this.btSysMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.btMaximize = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LinkTimer = new System.Windows.Forms.Timer(this.components);
            this.fctbRcv = new FastColoredTextBoxNS.FastColoredTextBox();
            this.sendPanel = new System.Windows.Forms.Panel();
            this.btHistory = new System.Windows.Forms.Button();
            this.btLoopSend = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.btFileOps = new System.Windows.Forms.Button();
            this.sendFilePgBar = new System.Windows.Forms.ProgressBar();
            this.btSetting = new System.Windows.Forms.Button();
            this.btSendFile = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.toolBar.SuspendLayout();
            this.systemStatusStrip.SuspendLayout();
            this.cmsNotifyMenu.SuspendLayout();
            this.sysMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbRcv)).BeginInit();
            this.sendPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.toolBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btPortSetting,
            this.btOpenClose,
            this.toolBarButtonSeparator1,
            this.saveAsButton,
            this.btClear,
            this.btShowLine,
            this.btRmAllBookmarks,
            this.toolStripSeparator2,
            this.tBarButtonRecord,
            this.newLogToolStripButton,
            this.toolBarButtonOpenLog,
            this.openLogFolderButton,
            this.toolBarButtonSeparator2,
            this.topMostButton,
            this.tsBtGoBack,
            this.tsBtGoForward,
            this.toolStripSeparator1,
            this.tsBtFindPrevious,
            this.tsBtFindNext,
            this.toolStripSeparator3,
            this.screenShotButton,
            this.btHideSendBar,
            this.btSize});
            this.toolBar.Location = new System.Drawing.Point(4, 28);
            this.toolBar.Name = "toolBar";
            this.toolBar.Padding = new System.Windows.Forms.Padding(0);
            this.toolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolBar.Size = new System.Drawing.Size(542, 25);
            this.toolBar.TabIndex = 6;
            // 
            // btPortSetting
            // 
            this.btPortSetting.Image = global::DockSample.Properties.Resources.toolbox;
            this.btPortSetting.Margin = new System.Windows.Forms.Padding(1);
            this.btPortSetting.Name = "btPortSetting";
            this.btPortSetting.Size = new System.Drawing.Size(23, 23);
            this.btPortSetting.ToolTipText = "Connect Setting";
            this.btPortSetting.Click += new System.EventHandler(this.btPortSetting_Click_1);
            // 
            // btOpenClose
            // 
            this.btOpenClose.Image = global::DockSample.Properties.Resources.connection_error;
            this.btOpenClose.Margin = new System.Windows.Forms.Padding(1);
            this.btOpenClose.Name = "btOpenClose";
            this.btOpenClose.Size = new System.Drawing.Size(23, 23);
            this.btOpenClose.ToolTipText = "Open/Close";
            this.btOpenClose.Click += new System.EventHandler(this.toolBarButtonOpen_Click);
            // 
            // toolBarButtonSeparator1
            // 
            this.toolBarButtonSeparator1.AutoSize = false;
            this.toolBarButtonSeparator1.Name = "toolBarButtonSeparator1";
            this.toolBarButtonSeparator1.Size = new System.Drawing.Size(6, 20);
            // 
            // saveAsButton
            // 
            this.saveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsButton.Image = global::DockSample.Properties.Resources.save;
            this.saveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsButton.Margin = new System.Windows.Forms.Padding(1);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(23, 23);
            this.saveAsButton.Text = "toolStripButton2";
            this.saveAsButton.ToolTipText = "Save As";
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // btClear
            // 
            this.btClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btClear.Image = global::DockSample.Properties.Resources.eraser;
            this.btClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClear.Margin = new System.Windows.Forms.Padding(1);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(23, 23);
            this.btClear.Text = "ClearReceive";
            this.btClear.ToolTipText = "Clear";
            this.btClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // btShowLine
            // 
            this.btShowLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btShowLine.Image = global::DockSample.Properties.Resources.list_numbered;
            this.btShowLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btShowLine.Name = "btShowLine";
            this.btShowLine.Size = new System.Drawing.Size(23, 22);
            this.btShowLine.Text = "Show Line";
            this.btShowLine.ToolTipText = "Show Line Number";
            this.btShowLine.Click += new System.EventHandler(this.showLineToolStripButton_Click);
            // 
            // btRmAllBookmarks
            // 
            this.btRmAllBookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRmAllBookmarks.Image = global::DockSample.Properties.Resources.tags;
            this.btRmAllBookmarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRmAllBookmarks.Name = "btRmAllBookmarks";
            this.btRmAllBookmarks.Size = new System.Drawing.Size(23, 22);
            this.btRmAllBookmarks.Text = "Clear Tags";
            this.btRmAllBookmarks.Click += new System.EventHandler(this.rmAllBookmarksButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 20);
            // 
            // tBarButtonRecord
            // 
            this.tBarButtonRecord.Image = global::DockSample.Properties.Resources.MD_record;
            this.tBarButtonRecord.Margin = new System.Windows.Forms.Padding(1);
            this.tBarButtonRecord.Name = "tBarButtonRecord";
            this.tBarButtonRecord.Size = new System.Drawing.Size(23, 23);
            this.tBarButtonRecord.ToolTipText = "Record\r\n";
            this.tBarButtonRecord.Click += new System.EventHandler(this.toolBarButtonLogEnable_Click);
            // 
            // newLogToolStripButton
            // 
            this.newLogToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newLogToolStripButton.Image = global::DockSample.Properties.Resources.file;
            this.newLogToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newLogToolStripButton.Name = "newLogToolStripButton";
            this.newLogToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newLogToolStripButton.Text = "New Log";
            this.newLogToolStripButton.Click += new System.EventHandler(this.newLogToolStripButton_Click);
            // 
            // toolBarButtonOpenLog
            // 
            this.toolBarButtonOpenLog.Image = global::DockSample.Properties.Resources.notepad_alt;
            this.toolBarButtonOpenLog.Margin = new System.Windows.Forms.Padding(1);
            this.toolBarButtonOpenLog.Name = "toolBarButtonOpenLog";
            this.toolBarButtonOpenLog.Size = new System.Drawing.Size(23, 23);
            this.toolBarButtonOpenLog.ToolTipText = "Open Log";
            this.toolBarButtonOpenLog.Click += new System.EventHandler(this.toolBarButtonOpenLog_Click);
            // 
            // openLogFolderButton
            // 
            this.openLogFolderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openLogFolderButton.Image = global::DockSample.Properties.Resources.folder_open;
            this.openLogFolderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openLogFolderButton.Name = "openLogFolderButton";
            this.openLogFolderButton.Size = new System.Drawing.Size(23, 22);
            this.openLogFolderButton.Text = "OpenLogFolder";
            this.openLogFolderButton.ToolTipText = "Open Folder";
            this.openLogFolderButton.Click += new System.EventHandler(this.openLogFolderButton_Click);
            // 
            // toolBarButtonSeparator2
            // 
            this.toolBarButtonSeparator2.AutoSize = false;
            this.toolBarButtonSeparator2.Name = "toolBarButtonSeparator2";
            this.toolBarButtonSeparator2.Size = new System.Drawing.Size(6, 20);
            // 
            // topMostButton
            // 
            this.topMostButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.topMostButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topMostButton.Image = ((System.Drawing.Image)(resources.GetObject("topMostButton.Image")));
            this.topMostButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topMostButton.Name = "topMostButton";
            this.topMostButton.Size = new System.Drawing.Size(23, 22);
            this.topMostButton.Text = "TopMost";
            this.topMostButton.Click += new System.EventHandler(this.topMostButton_Click);
            // 
            // tsBtGoBack
            // 
            this.tsBtGoBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtGoBack.Image = global::DockSample.Properties.Resources.arrow_2_left;
            this.tsBtGoBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtGoBack.Name = "tsBtGoBack";
            this.tsBtGoBack.Size = new System.Drawing.Size(23, 22);
            this.tsBtGoBack.Text = "toolStripButton1";
            this.tsBtGoBack.ToolTipText = "Go Back";
            this.tsBtGoBack.Click += new System.EventHandler(this.tsBtGoBack_Click);
            // 
            // tsBtGoForward
            // 
            this.tsBtGoForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtGoForward.Image = global::DockSample.Properties.Resources.arrow_2_right;
            this.tsBtGoForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtGoForward.Name = "tsBtGoForward";
            this.tsBtGoForward.Size = new System.Drawing.Size(23, 22);
            this.tsBtGoForward.Text = "toolStripButton2";
            this.tsBtGoForward.ToolTipText = "Go Forward";
            this.tsBtGoForward.Click += new System.EventHandler(this.tsBtGoForward_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 20);
            // 
            // tsBtFindPrevious
            // 
            this.tsBtFindPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtFindPrevious.Image = global::DockSample.Properties.Resources.zoom_out;
            this.tsBtFindPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtFindPrevious.Name = "tsBtFindPrevious";
            this.tsBtFindPrevious.Size = new System.Drawing.Size(23, 22);
            this.tsBtFindPrevious.Text = "FindPrevious";
            this.tsBtFindPrevious.ToolTipText = "Previous";
            this.tsBtFindPrevious.Click += new System.EventHandler(this.tsBtFindPrevious_Click);
            // 
            // tsBtFindNext
            // 
            this.tsBtFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtFindNext.Image = global::DockSample.Properties.Resources.zoom_in;
            this.tsBtFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtFindNext.Name = "tsBtFindNext";
            this.tsBtFindNext.Size = new System.Drawing.Size(23, 22);
            this.tsBtFindNext.Text = "Search";
            this.tsBtFindNext.ToolTipText = "Next";
            this.tsBtFindNext.Click += new System.EventHandler(this.tsBtFindNext_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 20);
            // 
            // screenShotButton
            // 
            this.screenShotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.screenShotButton.Image = global::DockSample.Properties.Resources.screenshot;
            this.screenShotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.screenShotButton.Margin = new System.Windows.Forms.Padding(1);
            this.screenShotButton.Name = "screenShotButton";
            this.screenShotButton.Size = new System.Drawing.Size(23, 23);
            this.screenShotButton.ToolTipText = "Screenshot";
            this.screenShotButton.Click += new System.EventHandler(this.toolStripButtonScreenShot_Click);
            // 
            // btHideSendBar
            // 
            this.btHideSendBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btHideSendBar.Image = global::DockSample.Properties.Resources.view;
            this.btHideSendBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btHideSendBar.Margin = new System.Windows.Forms.Padding(1);
            this.btHideSendBar.Name = "btHideSendBar";
            this.btHideSendBar.Size = new System.Drawing.Size(23, 23);
            this.btHideSendBar.Text = "toolStripButton1";
            this.btHideSendBar.ToolTipText = "Click To Hide Send Window";
            // 
            // btSize
            // 
            this.btSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomItem0,
            this.zoomItem1,
            this.zoomItem2,
            this.zoomItem3,
            this.zoomItem4});
            this.btSize.Font = new System.Drawing.Font("NSimSun", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSize.Image = global::DockSample.Properties.Resources.resize;
            this.btSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSize.Name = "btSize";
            this.btSize.Size = new System.Drawing.Size(45, 22);
            this.btSize.Text = "Zoom";
            this.btSize.ToolTipText = "Zoom";
            this.btSize.ButtonClick += new System.EventHandler(this.btSize_ButtonClick);
            this.btSize.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btSize_DropDownItemClicked);
            // 
            // zoomItem0
            // 
            this.zoomItem0.Name = "zoomItem0";
            this.zoomItem0.Size = new System.Drawing.Size(94, 22);
            this.zoomItem0.Text = "50%";
            // 
            // zoomItem1
            // 
            this.zoomItem1.Name = "zoomItem1";
            this.zoomItem1.Size = new System.Drawing.Size(94, 22);
            this.zoomItem1.Text = "70%";
            // 
            // zoomItem2
            // 
            this.zoomItem2.Name = "zoomItem2";
            this.zoomItem2.Size = new System.Drawing.Size(94, 22);
            this.zoomItem2.Text = "100%";
            // 
            // zoomItem3
            // 
            this.zoomItem3.Name = "zoomItem3";
            this.zoomItem3.Size = new System.Drawing.Size(94, 22);
            this.zoomItem3.Text = "150%";
            // 
            // zoomItem4
            // 
            this.zoomItem4.Name = "zoomItem4";
            this.zoomItem4.Size = new System.Drawing.Size(94, 22);
            this.zoomItem4.Text = "200%";
            // 
            // notifyImageList
            // 
            this.notifyImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("notifyImageList.ImageStream")));
            this.notifyImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.notifyImageList.Images.SetKeyName(0, "connect.png");
            this.notifyImageList.Images.SetKeyName(1, "connection-error.png");
            this.notifyImageList.Images.SetKeyName(2, "connect-alt-1.png");
            this.notifyImageList.Images.SetKeyName(3, "connection-error-alt-1.png");
            this.notifyImageList.Images.SetKeyName(4, "connect-alt-2.png");
            this.notifyImageList.Images.SetKeyName(5, "connection-error-alt-2.png");
            this.notifyImageList.Images.SetKeyName(6, "MD-repeat-alt.png");
            this.notifyImageList.Images.SetKeyName(7, "MD-repeat-once.png");
            // 
            // toolStripimageList
            // 
            this.toolStripimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolStripimageList.ImageStream")));
            this.toolStripimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.toolStripimageList.Images.SetKeyName(0, "connect.png");
            this.toolStripimageList.Images.SetKeyName(1, "connection-error.png");
            this.toolStripimageList.Images.SetKeyName(2, "connect-alt-1.png");
            this.toolStripimageList.Images.SetKeyName(3, "connection-error-alt-1.png");
            this.toolStripimageList.Images.SetKeyName(4, "arrow-8-up.png");
            this.toolStripimageList.Images.SetKeyName(5, "arrow-8-down.png");
            this.toolStripimageList.Images.SetKeyName(6, "padlock-open.png");
            this.toolStripimageList.Images.SetKeyName(7, "padlock-closed.png");
            this.toolStripimageList.Images.SetKeyName(8, "MD-play.png");
            this.toolStripimageList.Images.SetKeyName(9, "MD-pause.png");
            this.toolStripimageList.Images.SetKeyName(10, "MD-resume.png");
            this.toolStripimageList.Images.SetKeyName(11, "MD-record.png");
            this.toolStripimageList.Images.SetKeyName(12, "MD-stop.png");
            this.toolStripimageList.Images.SetKeyName(13, "MD-next.png");
            this.toolStripimageList.Images.SetKeyName(14, "MD-previous.png");
            this.toolStripimageList.Images.SetKeyName(15, "MD-levels-decrease.png");
            this.toolStripimageList.Images.SetKeyName(16, "MD-levels-increase.png");
            this.toolStripimageList.Images.SetKeyName(17, "MD-reload.png");
            this.toolStripimageList.Images.SetKeyName(18, "MD-repeat.png");
            this.toolStripimageList.Images.SetKeyName(19, "MD-repeat-alt.png");
            this.toolStripimageList.Images.SetKeyName(20, "MD-repeat-once.png");
            this.toolStripimageList.Images.SetKeyName(21, "MD-shuffle.png");
            this.toolStripimageList.Images.SetKeyName(22, "file-upload.png");
            // 
            // systemStatusStrip
            // 
            this.systemStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.systemStatusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.systemStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lableConectState,
            this.toolStripStatusLabel4,
            this.sendTimerPeriodLabel,
            this.toolStripStatusLabel1,
            this.labelSendNum,
            this.toolStripStatusLabel8,
            this.labelRcvNum,
            this.toolStripStatusLabel5,
            this.linkTimeLabel});
            this.systemStatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.systemStatusStrip.Location = new System.Drawing.Point(4, 374);
            this.systemStatusStrip.Name = "systemStatusStrip";
            this.systemStatusStrip.Size = new System.Drawing.Size(542, 22);
            this.systemStatusStrip.SizingGrip = false;
            this.systemStatusStrip.TabIndex = 14;
            this.systemStatusStrip.Text = "statusStrip1";
            // 
            // lableConectState
            // 
            this.lableConectState.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.lableConectState.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lableConectState.Name = "lableConectState";
            this.lableConectState.Size = new System.Drawing.Size(88, 19);
            this.lableConectState.Text = "No Conection";
            this.lableConectState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // sendTimerPeriodLabel
            // 
            this.sendTimerPeriodLabel.Image = global::DockSample.Properties.Resources.alarm;
            this.sendTimerPeriodLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.sendTimerPeriodLabel.Name = "sendTimerPeriodLabel";
            this.sendTimerPeriodLabel.Size = new System.Drawing.Size(69, 19);
            this.sendTimerPeriodLabel.Text = "1000ms";
            this.sendTimerPeriodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // labelSendNum
            // 
            this.labelSendNum.Image = global::DockSample.Properties.Resources.arrow_4_up;
            this.labelSendNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSendNum.IsLink = true;
            this.labelSendNum.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.labelSendNum.LinkColor = System.Drawing.SystemColors.ControlText;
            this.labelSendNum.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelSendNum.Name = "labelSendNum";
            this.labelSendNum.Size = new System.Drawing.Size(31, 19);
            this.labelSendNum.Text = "0";
            this.labelSendNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSendNum.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel8.Text = "|";
            // 
            // labelRcvNum
            // 
            this.labelRcvNum.Image = global::DockSample.Properties.Resources.arrow_4_down;
            this.labelRcvNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRcvNum.IsLink = true;
            this.labelRcvNum.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.labelRcvNum.LinkColor = System.Drawing.SystemColors.ControlText;
            this.labelRcvNum.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelRcvNum.Name = "labelRcvNum";
            this.labelRcvNum.Size = new System.Drawing.Size(31, 19);
            this.labelRcvNum.Text = "0";
            this.labelRcvNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRcvNum.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel5.Text = "|";
            // 
            // linkTimeLabel
            // 
            this.linkTimeLabel.Image = global::DockSample.Properties.Resources.stopwatch;
            this.linkTimeLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.linkTimeLabel.Name = "linkTimeLabel";
            this.linkTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkTimeLabel.Size = new System.Drawing.Size(72, 19);
            this.linkTimeLabel.Text = "00:00:00";
            this.linkTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkTimeLabel.ToolTipText = "Link Time";
            // 
            // notifyMenu
            // 
            this.notifyMenu.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyMenu.BalloonTipText = "Notify";
            this.notifyMenu.BalloonTipTitle = "Notify Menu";
            this.notifyMenu.ContextMenuStrip = this.cmsNotifyMenu;
            this.notifyMenu.Text = "Notify Menu";
            this.notifyMenu.Visible = true;
            this.notifyMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyMenu_MouseClick);
            // 
            // cmsNotifyMenu
            // 
            this.cmsNotifyMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmsNotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifyTSMIShow,
            this.notifyTSMINewPort,
            this.toolStripSeparator4,
            this.notifyTSMIExit});
            this.cmsNotifyMenu.Name = "cmsNotifyIcon";
            this.cmsNotifyMenu.Size = new System.Drawing.Size(108, 76);
            // 
            // notifyTSMIShow
            // 
            this.notifyTSMIShow.Image = global::DockSample.Properties.Resources.view;
            this.notifyTSMIShow.Name = "notifyTSMIShow";
            this.notifyTSMIShow.Size = new System.Drawing.Size(107, 22);
            this.notifyTSMIShow.Text = "&Show";
            this.notifyTSMIShow.Click += new System.EventHandler(this.notifyTSMIShow_Click);
            // 
            // notifyTSMINewPort
            // 
            this.notifyTSMINewPort.Image = global::DockSample.Properties.Resources.add;
            this.notifyTSMINewPort.Name = "notifyTSMINewPort";
            this.notifyTSMINewPort.Size = new System.Drawing.Size(107, 22);
            this.notifyTSMINewPort.Text = "&New";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(104, 6);
            // 
            // notifyTSMIExit
            // 
            this.notifyTSMIExit.Image = global::DockSample.Properties.Resources.door_closed;
            this.notifyTSMIExit.Name = "notifyTSMIExit";
            this.notifyTSMIExit.Size = new System.Drawing.Size(107, 22);
            this.notifyTSMIExit.Text = "&Exit";
            this.notifyTSMIExit.Click += new System.EventHandler(this.notifyTSMIExit_Click);
            // 
            // sysMenu
            // 
            this.sysMenu.BackColor = System.Drawing.Color.White;
            this.sysMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingSysMenu,
            this.themeSysMenu});
            this.sysMenu.Name = "sysMenu";
            this.sysMenu.Size = new System.Drawing.Size(117, 48);
            // 
            // settingSysMenu
            // 
            this.settingSysMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.settingSysMenu.Image = global::DockSample.Properties.Resources._3D_Cube;
            this.settingSysMenu.Name = "settingSysMenu";
            this.settingSysMenu.Size = new System.Drawing.Size(116, 22);
            this.settingSysMenu.Text = "&Setting";
            // 
            // themeSysMenu
            // 
            this.themeSysMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.themeSysMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.lightToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.themeSysMenu.Image = global::DockSample.Properties.Resources.paintroller;
            this.themeSysMenu.Name = "themeSysMenu";
            this.themeSysMenu.Size = new System.Drawing.Size(116, 22);
            this.themeSysMenu.Text = "&Theme";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem1.Text = "Dark";
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // btTopMost
            // 
            this.btTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTopMost.FlatAppearance.BorderSize = 0;
            this.btTopMost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.btTopMost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTopMost.Image = global::DockSample.Properties.Resources.pin_24px_1083523_easyicon_net;
            this.btTopMost.Location = new System.Drawing.Point(392, 1);
            this.btTopMost.Margin = new System.Windows.Forms.Padding(0);
            this.btTopMost.Name = "btTopMost";
            this.btTopMost.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btTopMost.Size = new System.Drawing.Size(27, 27);
            this.btTopMost.TabIndex = 16;
            this.btTopMost.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btTopMost.UseVisualStyleBackColor = true;
            this.btTopMost.Click += new System.EventHandler(this.btTopMost_Click);
            // 
            // btSysMenu
            // 
            this.btSysMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSysMenu.FlatAppearance.BorderSize = 0;
            this.btSysMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.btSysMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSysMenu.Image = global::DockSample.Properties.Resources.list;
            this.btSysMenu.Location = new System.Drawing.Point(422, 1);
            this.btSysMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btSysMenu.Name = "btSysMenu";
            this.btSysMenu.Size = new System.Drawing.Size(27, 27);
            this.btSysMenu.TabIndex = 19;
            this.btSysMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btSysMenu.UseVisualStyleBackColor = true;
            this.btSysMenu.Click += new System.EventHandler(this.btSysMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(450, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 16);
            this.panel1.TabIndex = 20;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btClose.Location = new System.Drawing.Point(349, 1);
            this.btClose.Margin = new System.Windows.Forms.Padding(0);
            this.btClose.Name = "btClose";
            this.btClose.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btClose.Size = new System.Drawing.Size(34, 24);
            this.btClose.TabIndex = 23;
            this.btClose.Text = "r";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // btMaximize
            // 
            this.btMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximize.FlatAppearance.BorderSize = 0;
            this.btMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.btMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximize.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btMaximize.Location = new System.Drawing.Point(321, 1);
            this.btMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btMaximize.Name = "btMaximize";
            this.btMaximize.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btMaximize.Size = new System.Drawing.Size(27, 24);
            this.btMaximize.TabIndex = 24;
            this.btMaximize.Text = "1";
            this.btMaximize.UseVisualStyleBackColor = true;
            this.btMaximize.Click += new System.EventHandler(this.btMaximize_Click);
            // 
            // btMinimize
            // 
            this.btMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimize.FlatAppearance.BorderSize = 0;
            this.btMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btMinimize.Location = new System.Drawing.Point(293, 1);
            this.btMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btMinimize.Size = new System.Drawing.Size(27, 24);
            this.btMinimize.TabIndex = 25;
            this.btMinimize.Text = "0";
            this.btMinimize.UseVisualStyleBackColor = true;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Wingdings", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(250, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 26);
            this.button2.TabIndex = 27;
            this.button2.Text = "S";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LinkTimer
            // 
            this.LinkTimer.Interval = 1000;
            this.LinkTimer.Tick += new System.EventHandler(this.LinkTimer_Tick);
            // 
            // fctbRcv
            // 
            this.fctbRcv.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbRcv.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctbRcv.BackBrush = null;
            this.fctbRcv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.fctbRcv.BookmarkColor = System.Drawing.Color.Red;
            this.fctbRcv.CharHeight = 14;
            this.fctbRcv.CharWidth = 8;
            this.fctbRcv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbRcv.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbRcv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctbRcv.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctbRcv.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.fctbRcv.IsReplaceMode = false;
            this.fctbRcv.Location = new System.Drawing.Point(4, 53);
            this.fctbRcv.Margin = new System.Windows.Forms.Padding(0);
            this.fctbRcv.Name = "fctbRcv";
            this.fctbRcv.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbRcv.ReadOnly = true;
            this.fctbRcv.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.fctbRcv.SelectionUnFormatColor = System.Drawing.Color.Lime;
            this.fctbRcv.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbRcv.ServiceColors")));
            this.fctbRcv.ServiceLinesColor = System.Drawing.Color.White;
            this.fctbRcv.Size = new System.Drawing.Size(542, 295);
            this.fctbRcv.TabIndex = 30;
            this.fctbRcv.TabLength = 8;
            this.fctbRcv.Zoom = 100;
            this.fctbRcv.KeyPressed += new System.Windows.Forms.KeyPressEventHandler(this.fctbRcv_KeyPressed);
            this.fctbRcv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctbRcv_KeyDown);
            this.fctbRcv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fctbRcv_KeyPress);
            this.fctbRcv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fctbRcv_MouseDoubleClick);
            // 
            // sendPanel
            // 
            this.sendPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.sendPanel.Controls.Add(this.btHistory);
            this.sendPanel.Controls.Add(this.btLoopSend);
            this.sendPanel.Controls.Add(this.panel2);
            this.sendPanel.Controls.Add(this.panel3);
            this.sendPanel.Controls.Add(this.tbSend);
            this.sendPanel.Controls.Add(this.btFileOps);
            this.sendPanel.Controls.Add(this.sendFilePgBar);
            this.sendPanel.Controls.Add(this.btSetting);
            this.sendPanel.Controls.Add(this.btSendFile);
            this.sendPanel.Controls.Add(this.btSend);
            this.sendPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendPanel.Location = new System.Drawing.Point(4, 348);
            this.sendPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sendPanel.Name = "sendPanel";
            this.sendPanel.Size = new System.Drawing.Size(542, 26);
            this.sendPanel.TabIndex = 34;
            // 
            // btHistory
            // 
            this.btHistory.FlatAppearance.BorderSize = 0;
            this.btHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHistory.Image = global::DockSample.Properties.Resources.attachment;
            this.btHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btHistory.Location = new System.Drawing.Point(409, 4);
            this.btHistory.Name = "btHistory";
            this.btHistory.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btHistory.Size = new System.Drawing.Size(19, 19);
            this.btHistory.TabIndex = 36;
            this.btHistory.UseVisualStyleBackColor = true;
            this.btHistory.Click += new System.EventHandler(this.btHistory_Click);
            // 
            // btLoopSend
            // 
            this.btLoopSend.FlatAppearance.BorderSize = 0;
            this.btLoopSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btLoopSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoopSend.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btLoopSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLoopSend.Image = global::DockSample.Properties.Resources.MD_repeat_alt;
            this.btLoopSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btLoopSend.Location = new System.Drawing.Point(453, 4);
            this.btLoopSend.Name = "btLoopSend";
            this.btLoopSend.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btLoopSend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btLoopSend.Size = new System.Drawing.Size(19, 19);
            this.btLoopSend.TabIndex = 17;
            this.btLoopSend.Tag = "Send";
            this.btLoopSend.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(448, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 12);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(479, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 12);
            this.panel3.TabIndex = 33;
            // 
            // tbSend
            // 
            this.tbSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSend.Font = new System.Drawing.Font("SimSun", 9F);
            this.tbSend.Location = new System.Drawing.Point(28, 5);
            this.tbSend.Margin = new System.Windows.Forms.Padding(0);
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(350, 14);
            this.tbSend.TabIndex = 32;
            // 
            // btFileOps
            // 
            this.btFileOps.FlatAppearance.BorderSize = 0;
            this.btFileOps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btFileOps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFileOps.ImageIndex = 8;
            this.btFileOps.ImageList = this.toolStripimageList;
            this.btFileOps.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btFileOps.Location = new System.Drawing.Point(508, 4);
            this.btFileOps.Name = "btFileOps";
            this.btFileOps.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btFileOps.Size = new System.Drawing.Size(19, 19);
            this.btFileOps.TabIndex = 29;
            this.btFileOps.UseVisualStyleBackColor = true;
            // 
            // sendFilePgBar
            // 
            this.sendFilePgBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sendFilePgBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sendFilePgBar.Location = new System.Drawing.Point(28, 21);
            this.sendFilePgBar.Name = "sendFilePgBar";
            this.sendFilePgBar.Size = new System.Drawing.Size(350, 2);
            this.sendFilePgBar.Step = 1;
            this.sendFilePgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.sendFilePgBar.TabIndex = 28;
            this.sendFilePgBar.Visible = false;
            // 
            // btSetting
            // 
            this.btSetting.FlatAppearance.BorderSize = 0;
            this.btSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSetting.Image = global::DockSample.Properties.Resources.list;
            this.btSetting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSetting.Location = new System.Drawing.Point(2, 4);
            this.btSetting.Name = "btSetting";
            this.btSetting.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btSetting.Size = new System.Drawing.Size(19, 19);
            this.btSetting.TabIndex = 20;
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // btSendFile
            // 
            this.btSendFile.FlatAppearance.BorderSize = 0;
            this.btSendFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btSendFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSendFile.ImageIndex = 22;
            this.btSendFile.ImageList = this.toolStripimageList;
            this.btSendFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSendFile.Location = new System.Drawing.Point(485, 4);
            this.btSendFile.Name = "btSendFile";
            this.btSendFile.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btSendFile.Size = new System.Drawing.Size(19, 19);
            this.btSendFile.TabIndex = 17;
            this.btSendFile.UseVisualStyleBackColor = true;
            // 
            // btSend
            // 
            this.btSend.FlatAppearance.BorderSize = 0;
            this.btSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSend.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSend.Image = global::DockSample.Properties.Resources.chat_active;
            this.btSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSend.Location = new System.Drawing.Point(382, 4);
            this.btSend.Name = "btSend";
            this.btSend.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btSend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btSend.Size = new System.Drawing.Size(19, 19);
            this.btSend.TabIndex = 16;
            this.btSend.Tag = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(4, 347);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(542, 1);
            this.panel4.TabIndex = 35;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.BackRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.BackShade = false;
            this.BackToColor = false;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.BorderRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.CloseBoxSize = new System.Drawing.Size(30, 27);
            this.CloseDownBack = global::DockSample.Properties.Resources.sysbtn_close_down;
            this.CloseMouseBack = global::DockSample.Properties.Resources.sysbtn_close_hover;
            this.CloseNormlBack = global::DockSample.Properties.Resources.sysbtn_close_normal;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.fctbRcv);
            this.Controls.Add(this.sendPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btMinimize);
            this.Controls.Add(this.btMaximize);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSysMenu);
            this.Controls.Add(this.btTopMost);
            this.Controls.Add(this.systemStatusStrip);
            this.Controls.Add(this.toolBar);
            this.EffectCaption = CCWin.TitleType.Title;
            this.EffectWidth = 0;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.IsMdiContainer = true;
            this.MaxDownBack = global::DockSample.Properties.Resources.sysbtn_max_down;
            this.MaxMouseBack = global::DockSample.Properties.Resources.sysbtn_max_hover;
            this.MaxNormlBack = global::DockSample.Properties.Resources.sysbtn_max_normal;
            this.MaxSize = new System.Drawing.Size(30, 27);
            this.MdiBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MiniDownBack = global::DockSample.Properties.Resources.sysbtn_min_down;
            this.MiniMouseBack = global::DockSample.Properties.Resources.sysbtn_min_hover;
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.MiniNormlBack = global::DockSample.Properties.Resources.sysbtn_min_normal;
            this.MiniSize = new System.Drawing.Size(30, 27);
            this.Name = "MainForm";
            this.Radius = 0;
            this.RestoreDownBack = global::DockSample.Properties.Resources.sysbtn_restore_down;
            this.RestoreMouseBack = global::DockSample.Properties.Resources.sysbtn_restore_hover;
            this.RestoreNormlBack = global::DockSample.Properties.Resources.sysbtn_restore_normal;
            this.Shadow = false;
            this.ShadowRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ShadowWidth = 1;
            this.ShowBorder = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Com Tool";
            this.SysBottomClick += new CCWin.CCSkinMain.SysBottomEventHandler(this.MainForm_SysBottomClick);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.systemStatusStrip.ResumeLayout(false);
            this.systemStatusStrip.PerformLayout();
            this.cmsNotifyMenu.ResumeLayout(false);
            this.sysMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctbRcv)).EndInit();
            this.sendPanel.ResumeLayout(false);
            this.sendPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton btOpenClose;
        private System.Windows.Forms.ToolStripSeparator toolBarButtonSeparator1;
        private System.Windows.Forms.ToolStripButton btPortSetting;
        private System.Windows.Forms.ToolStripButton tBarButtonRecord;
        private System.Windows.Forms.ToolStripButton toolBarButtonOpenLog;
        private System.Windows.Forms.ToolStripSeparator toolBarButtonSeparator2;
        private System.Windows.Forms.ToolStripButton btClear;
        private ImageList notifyImageList;
        private ToolStripButton btHideSendBar;
        private ToolStripButton saveAsButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton screenShotButton;
        private ImageList toolStripimageList;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton topMostButton;
        private ToolStripButton newLogToolStripButton;
        private ToolStripButton btShowLine;
        private ToolStripButton btRmAllBookmarks;
        private ToolStripButton openLogFolderButton;
        private ToolStripButton tsBtFindPrevious;
        private ToolStripButton tsBtFindNext;
        private StatusStrip systemStatusStrip;
        private ToolStripStatusLabel lableConectState;
        private ToolStripStatusLabel sendTimerPeriodLabel;
        private ToolStripStatusLabel linkTimeLabel;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel labelRcvNum;
        private ToolStripStatusLabel labelSendNum;
        private ToolStripStatusLabel toolStripStatusLabel8;
        private ToolStripButton tsBtGoBack;
        private ToolStripButton tsBtGoForward;
        private ToolStripSeparator toolStripSeparator1;
        private NotifyIcon notifyMenu;
        private ContextMenuStrip cmsNotifyMenu;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem notifyTSMIExit;
        private ToolStripMenuItem notifyTSMIShow;
        private ToolStripMenuItem notifyTSMINewPort;
        private ContextMenuStrip sysMenu;
        private ToolStripMenuItem settingSysMenu;
        private ToolStripMenuItem themeSysMenu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem lightToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private Button btTopMost;
        private Button btSysMenu;
        private Panel panel1;
        private Button btClose;
        private Button btMaximize;
        private Button btMinimize;
        private Button button2;
        private Timer LinkTimer;
        private FastColoredTextBoxNS.FastColoredTextBox fctbRcv;
        private Panel sendPanel;
        private Button btLoopSend;
        private Panel panel2;
        private Panel panel3;
        private TextBox tbSend;
        private Button btFileOps;
        private ProgressBar sendFilePgBar;
        private Button btSetting;
        private Button btSendFile;
        private Button btSend;
        private Panel panel4;
        private SerialPort serialPort;
        private ToolStripSplitButton btSize;
        private ToolStripMenuItem zoomItem0;
        private ToolStripMenuItem zoomItem1;
        private ToolStripMenuItem zoomItem2;
        private ToolStripMenuItem zoomItem3;
        private ToolStripMenuItem zoomItem4;
        private Button btHistory;
    }
}