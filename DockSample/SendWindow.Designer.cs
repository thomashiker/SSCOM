namespace DockSample
{
    partial class SendWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendWindow));
            this.fctbSend = new FastColoredTextBoxNS.FastColoredTextBox();
            this.sendContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendLineItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendSelectedItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceSendItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendUnorderItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendAllTagsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendNextTagItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteLineItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyclicSendTimer = new System.Windows.Forms.Timer(this.components);
            this.sendFileBGWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStripimageList = new System.Windows.Forms.ImageList(this.components);
            this.sendPanel = new System.Windows.Forms.Panel();
            this.btLoopSend = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btReadOnly = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSendMsg = new System.Windows.Forms.TextBox();
            this.tbMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btFileOps = new System.Windows.Forms.Button();
            this.fileOpMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uploadFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseTool = new System.Windows.Forms.ToolStripMenuItem();
            this.playTool = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTool = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleTool = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatTool = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFromFilePgBar = new System.Windows.Forms.ProgressBar();
            this.btMenu = new System.Windows.Forms.Button();
            this.btSendFile = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.settingMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uploadTool = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.clearAllTool = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTagsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingTool = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fctbSend)).BeginInit();
            this.sendContextMenu.SuspendLayout();
            this.sendPanel.SuspendLayout();
            this.tbMenu.SuspendLayout();
            this.fileOpMenu.SuspendLayout();
            this.settingMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // fctbSend
            // 
            this.fctbSend.AutoCompleteBracketsList = new char[] {
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
            resources.ApplyResources(this.fctbSend, "fctbSend");
            this.fctbSend.BackBrush = null;
            this.fctbSend.BookmarkColor = System.Drawing.Color.LimeGreen;
            this.fctbSend.CharHeight = 14;
            this.fctbSend.CharWidth = 8;
            this.fctbSend.ContextMenuStrip = this.sendContextMenu;
            this.fctbSend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbSend.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbSend.Hotkeys = resources.GetString("fctbSend.Hotkeys");
            this.fctbSend.IndentBackColor = System.Drawing.Color.White;
            this.fctbSend.IsReplaceMode = false;
            this.fctbSend.LineNumberColor = System.Drawing.SystemColors.Highlight;
            this.fctbSend.Name = "fctbSend";
            this.fctbSend.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbSend.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbSend.SelectionUnFormatColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbSend.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbSend.ServiceColors")));
            this.fctbSend.Zoom = 100;
            this.fctbSend.SelectionChanged += new System.EventHandler(this.fctbSend_SelectionChanged);
            this.fctbSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctbSend_KeyDown);
            this.fctbSend.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fctbSend_MouseDoubleClick);
            // 
            // sendContextMenu
            // 
            this.sendContextMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sendContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendLineItem,
            this.sendSelectedItem,
            this.advanceSendItem,
            this.toolStripSeparator1,
            this.deleteLineItem,
            this.toolStripSeparator5,
            this.cutItem,
            this.copyItem,
            this.pasteItem});
            this.sendContextMenu.Name = "sendContextMenu";
            resources.ApplyResources(this.sendContextMenu, "sendContextMenu");
            // 
            // sendLineItem
            // 
            this.sendLineItem.Image = global::DockSample.Properties.Resources.location;
            this.sendLineItem.Name = "sendLineItem";
            resources.ApplyResources(this.sendLineItem, "sendLineItem");
            this.sendLineItem.Click += new System.EventHandler(this.sendCurrentItem_Click);
            // 
            // sendSelectedItem
            // 
            this.sendSelectedItem.Image = global::DockSample.Properties.Resources.resize;
            this.sendSelectedItem.Name = "sendSelectedItem";
            resources.ApplyResources(this.sendSelectedItem, "sendSelectedItem");
            this.sendSelectedItem.Click += new System.EventHandler(this.sendSelectedItem_Click);
            // 
            // advanceSendItem
            // 
            this.advanceSendItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendUnorderItem,
            this.sendAllTagsItem,
            this.sendNextTagItem});
            this.advanceSendItem.Image = global::DockSample.Properties.Resources.toolbox;
            this.advanceSendItem.Name = "advanceSendItem";
            resources.ApplyResources(this.advanceSendItem, "advanceSendItem");
            // 
            // sendUnorderItem
            // 
            this.sendUnorderItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sendUnorderItem.Image = global::DockSample.Properties.Resources.MD_shuffle;
            this.sendUnorderItem.Name = "sendUnorderItem";
            resources.ApplyResources(this.sendUnorderItem, "sendUnorderItem");
            this.sendUnorderItem.Click += new System.EventHandler(this.sendUnorderItem_Click);
            // 
            // sendAllTagsItem
            // 
            this.sendAllTagsItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sendAllTagsItem.Image = global::DockSample.Properties.Resources.tags;
            this.sendAllTagsItem.Name = "sendAllTagsItem";
            resources.ApplyResources(this.sendAllTagsItem, "sendAllTagsItem");
            this.sendAllTagsItem.Click += new System.EventHandler(this.sendAllTagsItem_Click);
            // 
            // sendNextTagItem
            // 
            this.sendNextTagItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sendNextTagItem.Image = global::DockSample.Properties.Resources.tag;
            this.sendNextTagItem.Name = "sendNextTagItem";
            resources.ApplyResources(this.sendNextTagItem, "sendNextTagItem");
            this.sendNextTagItem.Click += new System.EventHandler(this.sendNextTagItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // deleteLineItem
            // 
            this.deleteLineItem.Image = global::DockSample.Properties.Resources.delete;
            this.deleteLineItem.Name = "deleteLineItem";
            resources.ApplyResources(this.deleteLineItem, "deleteLineItem");
            this.deleteLineItem.Click += new System.EventHandler(this.deleteLineItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // cutItem
            // 
            this.cutItem.Image = global::DockSample.Properties.Resources.cut;
            this.cutItem.Name = "cutItem";
            resources.ApplyResources(this.cutItem, "cutItem");
            this.cutItem.Click += new System.EventHandler(this.cutItem_Click);
            // 
            // copyItem
            // 
            this.copyItem.Image = global::DockSample.Properties.Resources.copy;
            this.copyItem.Name = "copyItem";
            resources.ApplyResources(this.copyItem, "copyItem");
            this.copyItem.Click += new System.EventHandler(this.copyItem_Click);
            // 
            // pasteItem
            // 
            this.pasteItem.Image = global::DockSample.Properties.Resources.paste;
            this.pasteItem.Name = "pasteItem";
            resources.ApplyResources(this.pasteItem, "pasteItem");
            this.pasteItem.Click += new System.EventHandler(this.pasteItem_Click);
            // 
            // cyclicSendTimer
            // 
            this.cyclicSendTimer.Interval = 1000;
            this.cyclicSendTimer.Tick += new System.EventHandler(this.cyclicSendTimer_Tick);
            // 
            // sendFileBGWorker
            // 
            this.sendFileBGWorker.WorkerReportsProgress = true;
            this.sendFileBGWorker.WorkerSupportsCancellation = true;
            this.sendFileBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.sendFileBGWorker_DoWork);
            this.sendFileBGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.sendFileBGWorker_ProgressChanged);
            this.sendFileBGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.sendFileBGWorker_RunWorkerCompleted);
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
            // sendPanel
            // 
            this.sendPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.sendPanel.Controls.Add(this.btLoopSend);
            this.sendPanel.Controls.Add(this.panel2);
            this.sendPanel.Controls.Add(this.btReadOnly);
            this.sendPanel.Controls.Add(this.panel1);
            this.sendPanel.Controls.Add(this.tbSendMsg);
            this.sendPanel.Controls.Add(this.btFileOps);
            this.sendPanel.Controls.Add(this.sendFromFilePgBar);
            this.sendPanel.Controls.Add(this.btMenu);
            this.sendPanel.Controls.Add(this.btSendFile);
            this.sendPanel.Controls.Add(this.btSend);
            resources.ApplyResources(this.sendPanel, "sendPanel");
            this.sendPanel.Name = "sendPanel";
            // 
            // btLoopSend
            // 
            resources.ApplyResources(this.btLoopSend, "btLoopSend");
            this.btLoopSend.FlatAppearance.BorderSize = 0;
            this.btLoopSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btLoopSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLoopSend.Image = global::DockSample.Properties.Resources.MD_repeat_alt;
            this.btLoopSend.Name = "btLoopSend";
            this.btLoopSend.Tag = "Send";
            this.btLoopSend.UseVisualStyleBackColor = true;
            this.btLoopSend.Click += new System.EventHandler(this.btLoopSend_Click);
            this.btLoopSend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btLoopSend_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btReadOnly
            // 
            this.btReadOnly.FlatAppearance.BorderSize = 0;
            this.btReadOnly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btReadOnly, "btReadOnly");
            this.btReadOnly.Image = global::DockSample.Properties.Resources.read_only;
            this.btReadOnly.Name = "btReadOnly";
            this.btReadOnly.UseVisualStyleBackColor = true;
            this.btReadOnly.Click += new System.EventHandler(this.btReadOnly_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tbSendMsg
            // 
            this.tbSendMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSendMsg.ContextMenuStrip = this.tbMenu;
            resources.ApplyResources(this.tbSendMsg, "tbSendMsg");
            this.tbSendMsg.Name = "tbSendMsg";
            this.tbSendMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSendMsg_KeyDown);
            // 
            // tbMenu
            // 
            this.tbMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.tbMenu.Name = "tbMenu";
            resources.ApplyResources(this.tbMenu, "tbMenu");
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::DockSample.Properties.Resources.delete;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // btFileOps
            // 
            this.btFileOps.ContextMenuStrip = this.fileOpMenu;
            resources.ApplyResources(this.btFileOps, "btFileOps");
            this.btFileOps.FlatAppearance.BorderSize = 0;
            this.btFileOps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btFileOps.ImageList = this.toolStripimageList;
            this.btFileOps.Name = "btFileOps";
            this.btFileOps.UseVisualStyleBackColor = true;
            this.btFileOps.Click += new System.EventHandler(this.btFileOps_Click);
            // 
            // fileOpMenu
            // 
            this.fileOpMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fileOpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadFileTool,
            this.pauseTool,
            this.playTool,
            this.stopTool,
            this.shuffleTool,
            this.repeatTool});
            this.fileOpMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.fileOpMenu.Name = "fileOpContextMenuStrip";
            this.fileOpMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            resources.ApplyResources(this.fileOpMenu, "fileOpMenu");
            // 
            // uploadFileTool
            // 
            this.uploadFileTool.Image = global::DockSample.Properties.Resources.file_upload;
            this.uploadFileTool.Name = "uploadFileTool";
            resources.ApplyResources(this.uploadFileTool, "uploadFileTool");
            this.uploadFileTool.Click += new System.EventHandler(this.btSendFile_Click);
            // 
            // pauseTool
            // 
            this.pauseTool.CheckOnClick = true;
            this.pauseTool.Image = global::DockSample.Properties.Resources.MD_pause;
            this.pauseTool.Name = "pauseTool";
            resources.ApplyResources(this.pauseTool, "pauseTool");
            this.pauseTool.CheckStateChanged += new System.EventHandler(this.pauseTool_CheckChanged);
            // 
            // playTool
            // 
            this.playTool.Image = global::DockSample.Properties.Resources.MD_play;
            this.playTool.Name = "playTool";
            resources.ApplyResources(this.playTool, "playTool");
            this.playTool.Click += new System.EventHandler(this.playTool_Click);
            // 
            // stopTool
            // 
            this.stopTool.Image = global::DockSample.Properties.Resources.MD_stop;
            this.stopTool.Name = "stopTool";
            resources.ApplyResources(this.stopTool, "stopTool");
            this.stopTool.Click += new System.EventHandler(this.stopTool_Click);
            // 
            // shuffleTool
            // 
            this.shuffleTool.CheckOnClick = true;
            this.shuffleTool.Image = global::DockSample.Properties.Resources.MD_shuffle;
            this.shuffleTool.Name = "shuffleTool";
            resources.ApplyResources(this.shuffleTool, "shuffleTool");
            // 
            // repeatTool
            // 
            this.repeatTool.CheckOnClick = true;
            this.repeatTool.Image = global::DockSample.Properties.Resources.MD_repeat;
            this.repeatTool.Name = "repeatTool";
            resources.ApplyResources(this.repeatTool, "repeatTool");
            // 
            // sendFromFilePgBar
            // 
            this.sendFromFilePgBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.sendFromFilePgBar, "sendFromFilePgBar");
            this.sendFromFilePgBar.Name = "sendFromFilePgBar";
            this.sendFromFilePgBar.Step = 1;
            this.sendFromFilePgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // btMenu
            // 
            this.btMenu.FlatAppearance.BorderSize = 0;
            this.btMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btMenu, "btMenu");
            this.btMenu.Image = global::DockSample.Properties.Resources.list;
            this.btMenu.Name = "btMenu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // btSendFile
            // 
            resources.ApplyResources(this.btSendFile, "btSendFile");
            this.btSendFile.FlatAppearance.BorderSize = 0;
            this.btSendFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btSendFile.ImageList = this.toolStripimageList;
            this.btSendFile.Name = "btSendFile";
            this.btSendFile.UseVisualStyleBackColor = true;
            this.btSendFile.Click += new System.EventHandler(this.btSendFile_Click);
            // 
            // btSend
            // 
            resources.ApplyResources(this.btSend, "btSend");
            this.btSend.FlatAppearance.BorderSize = 0;
            this.btSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSend.Image = global::DockSample.Properties.Resources.chat_active;
            this.btSend.Name = "btSend";
            this.btSend.Tag = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // settingMenu
            // 
            this.settingMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.settingMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadTool,
            this.saveFileTool,
            this.toolStripSeparator4,
            this.clearAllTool,
            this.clearTagsTool,
            this.toolStripSeparator3,
            this.settingTool});
            this.settingMenu.Name = "settingMenu";
            resources.ApplyResources(this.settingMenu, "settingMenu");
            // 
            // uploadTool
            // 
            this.uploadTool.Image = global::DockSample.Properties.Resources.file_upload;
            this.uploadTool.Name = "uploadTool";
            resources.ApplyResources(this.uploadTool, "uploadTool");
            this.uploadTool.Click += new System.EventHandler(this.uploadTool_Click);
            // 
            // saveFileTool
            // 
            this.saveFileTool.Image = global::DockSample.Properties.Resources.file_download;
            this.saveFileTool.Name = "saveFileTool";
            resources.ApplyResources(this.saveFileTool, "saveFileTool");
            this.saveFileTool.Click += new System.EventHandler(this.saveFileTool_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // clearAllTool
            // 
            this.clearAllTool.Image = global::DockSample.Properties.Resources.brush_alt_1;
            this.clearAllTool.Name = "clearAllTool";
            resources.ApplyResources(this.clearAllTool, "clearAllTool");
            this.clearAllTool.Click += new System.EventHandler(this.clearAllTool_Click);
            // 
            // clearTagsTool
            // 
            this.clearTagsTool.Image = global::DockSample.Properties.Resources.tags;
            this.clearTagsTool.Name = "clearTagsTool";
            resources.ApplyResources(this.clearTagsTool, "clearTagsTool");
            this.clearTagsTool.Click += new System.EventHandler(this.clearTagsTool_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // settingTool
            // 
            this.settingTool.Image = global::DockSample.Properties.Resources.settings;
            this.settingTool.Name = "settingTool";
            resources.ApplyResources(this.settingTool, "settingTool");
            this.settingTool.Click += new System.EventHandler(this.settingTool_Click);
            // 
            // SendWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.fctbSend);
            this.Controls.Add(this.sendPanel);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom;
            this.HideOnClose = true;
            this.Name = "SendWindow";
            this.LocationChanged += new System.EventHandler(this.SendWindow_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.SendWindow_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.fctbSend)).EndInit();
            this.sendContextMenu.ResumeLayout(false);
            this.sendPanel.ResumeLayout(false);
            this.sendPanel.PerformLayout();
            this.tbMenu.ResumeLayout(false);
            this.fileOpMenu.ResumeLayout(false);
            this.settingMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FastColoredTextBoxNS.FastColoredTextBox fctbSend;
        private System.Windows.Forms.Timer cyclicSendTimer;
        private System.ComponentModel.BackgroundWorker sendFileBGWorker;
        private System.Windows.Forms.ImageList toolStripimageList;
        private System.Windows.Forms.Panel sendPanel;
        private System.Windows.Forms.Button btFileOps;
        private System.Windows.Forms.ProgressBar sendFromFilePgBar;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button btSendFile;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.ContextMenuStrip fileOpMenu;
        private System.Windows.Forms.ToolStripMenuItem uploadFileTool;
        private System.Windows.Forms.ToolStripMenuItem pauseTool;
        private System.Windows.Forms.ToolStripMenuItem playTool;
        private System.Windows.Forms.ToolStripMenuItem stopTool;
        private System.Windows.Forms.ToolStripMenuItem shuffleTool;
        private System.Windows.Forms.ToolStripMenuItem repeatTool;
        private System.Windows.Forms.ContextMenuStrip sendContextMenu;
        private System.Windows.Forms.ToolStripMenuItem sendLineItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLineItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copyItem;
        private System.Windows.Forms.ToolStripMenuItem cutItem;
        private System.Windows.Forms.ToolStripMenuItem pasteItem;
        private System.Windows.Forms.ToolStripMenuItem advanceSendItem;
        private System.Windows.Forms.ToolStripMenuItem sendUnorderItem;
        private System.Windows.Forms.ToolStripMenuItem sendNextTagItem;
        private System.Windows.Forms.ToolStripMenuItem sendAllTagsItem;
        private System.Windows.Forms.TextBox tbSendMsg;
        private System.Windows.Forms.ContextMenuStrip settingMenu;
        private System.Windows.Forms.ToolStripMenuItem uploadTool;
        private System.Windows.Forms.ToolStripMenuItem clearTagsTool;
        private System.Windows.Forms.ToolStripMenuItem clearAllTool;
        private System.Windows.Forms.ToolStripMenuItem settingTool;
        private System.Windows.Forms.ToolStripMenuItem saveFileTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem sendSelectedItem;
        private System.Windows.Forms.ContextMenuStrip tbMenu;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button btReadOnly;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btLoopSend;
    }
}