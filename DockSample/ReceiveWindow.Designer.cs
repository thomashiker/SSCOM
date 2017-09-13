namespace DockSample
{
    partial class ReceiveWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiveWindow));
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rightKeyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopScrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.stackToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripImageList = new System.Windows.Forms.ImageList(this.components);
            this.fastColoredTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.rightKeyMenuStrip.SuspendLayout();
            this.tabMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(136, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(136, 6);
            // 
            // rightKeyMenuStrip
            // 
            this.rightKeyMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.rightKeyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator4,
            this.stopScrollToolStripMenuItem,
            this.clearAllBookmarksToolStripMenuItem,
            this.toolStripSeparator3,
            this.windowSettingToolStripMenuItem});
            this.rightKeyMenuStrip.Name = "contextMenuStrip";
            this.rightKeyMenuStrip.Size = new System.Drawing.Size(140, 176);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openToolStripMenuItem.Text = "Connect";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem.Image")));
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.selectAllToolStripMenuItem.Text = "Copy &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripMenuItem.Image")));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // stopScrollToolStripMenuItem
            // 
            this.stopScrollToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stopScrollToolStripMenuItem.Image")));
            this.stopScrollToolStripMenuItem.Name = "stopScrollToolStripMenuItem";
            this.stopScrollToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.stopScrollToolStripMenuItem.Text = "&Auto Scroll";
            this.stopScrollToolStripMenuItem.Click += new System.EventHandler(this.stopScrollToolStripMenuItem_Click);
            // 
            // clearAllBookmarksToolStripMenuItem
            // 
            this.clearAllBookmarksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearAllBookmarksToolStripMenuItem.Image")));
            this.clearAllBookmarksToolStripMenuItem.Name = "clearAllBookmarksToolStripMenuItem";
            this.clearAllBookmarksToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clearAllBookmarksToolStripMenuItem.Text = "Clear &Tags";
            this.clearAllBookmarksToolStripMenuItem.Click += new System.EventHandler(this.clearAllBookmarksToolStripMenuItem_Click);
            // 
            // windowSettingToolStripMenuItem
            // 
            this.windowSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("windowSettingToolStripMenuItem.Image")));
            this.windowSettingToolStripMenuItem.Name = "windowSettingToolStripMenuItem";
            this.windowSettingToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.windowSettingToolStripMenuItem.Text = "&Setting";
            this.windowSettingToolStripMenuItem.Click += new System.EventHandler(this.windowSettingToolStripMenuItem_Click);
            // 
            // tabMenuStrip
            // 
            this.tabMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.tabMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.verticalToolStrip,
            this.stackToolStrip,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.tabMenuStrip.Name = "tabMenuStrip";
            this.tabMenuStrip.Size = new System.Drawing.Size(137, 98);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("horizontalToolStripMenuItem.Image")));
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.horizontalToolStripMenuItem.Text = "&Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStrip
            // 
            this.verticalToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("verticalToolStrip.Image")));
            this.verticalToolStrip.Name = "verticalToolStrip";
            this.verticalToolStrip.Size = new System.Drawing.Size(136, 22);
            this.verticalToolStrip.Text = "&Vertical";
            this.verticalToolStrip.Click += new System.EventHandler(this.verticalToolStrip_Click);
            // 
            // stackToolStrip
            // 
            this.stackToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("stackToolStrip.Image")));
            this.stackToolStrip.Name = "stackToolStrip";
            this.stackToolStrip.Size = new System.Drawing.Size(136, 22);
            this.stackToolStrip.Text = "&Stack";
            this.stackToolStrip.Click += new System.EventHandler(this.stackToolStrip_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStripImageList
            // 
            this.menuStripImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuStripImageList.ImageStream")));
            this.menuStripImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuStripImageList.Images.SetKeyName(0, "connect.png");
            this.menuStripImageList.Images.SetKeyName(1, "connection-error.png");
            // 
            // fastColoredTextBox
            // 
            this.fastColoredTextBox.AutoCompleteBracketsList = new char[] {
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
            this.fastColoredTextBox.AutoIndent = false;
            this.fastColoredTextBox.AutoIndentChars = false;
            this.fastColoredTextBox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox.BackBrush = null;
            this.fastColoredTextBox.BookmarkColor = System.Drawing.SystemColors.MenuHighlight;
            this.fastColoredTextBox.CharHeight = 14;
            this.fastColoredTextBox.CharWidth = 8;
            this.fastColoredTextBox.ContextMenuStrip = this.rightKeyMenuStrip;
            this.fastColoredTextBox.CurrentLineColor = System.Drawing.Color.Lime;
            this.fastColoredTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox.Hotkeys = resources.GetString("fastColoredTextBox.Hotkeys");
            this.fastColoredTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.fastColoredTextBox.IndentBackColor = System.Drawing.Color.White;
            this.fastColoredTextBox.IsReplaceMode = false;
            this.fastColoredTextBox.LineNumberColor = System.Drawing.SystemColors.Highlight;
            this.fastColoredTextBox.Location = new System.Drawing.Point(0, 4);
            this.fastColoredTextBox.Name = "fastColoredTextBox";
            this.fastColoredTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox.ReadOnly = true;
            this.fastColoredTextBox.ReservedCountOfLineNumberChars = 0;
            this.fastColoredTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.fastColoredTextBox.SelectionUnFormatColor = System.Drawing.Color.Lime;
            this.fastColoredTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox.ServiceColors")));
            this.fastColoredTextBox.Size = new System.Drawing.Size(564, 295);
            this.fastColoredTextBox.TabIndex = 3;
            this.fastColoredTextBox.Zoom = 100;
            this.fastColoredTextBox.KeyPressed += new System.Windows.Forms.KeyPressEventHandler(this.fastColoredTextBox_KeyPressed);
            this.fastColoredTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.receiveRichTextBox_KeyDown);
            this.fastColoredTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fastColoredTextBox_KeyPress);
            this.fastColoredTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fastColoredTextBox_MouseDoubleClick);
            // 
            // serialPort
            // 
            this.serialPort.ReadTimeout = 300;
            this.serialPort.WriteBufferSize = 1048576;
            // 
            // ReceiveWindow
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(564, 299);
            this.Controls.Add(this.fastColoredTextBox);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceiveWindow";
            this.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.TabPageContextMenuStrip = this.tabMenuStrip;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReceiveWindow_FormClosing);
            this.LocationChanged += new System.EventHandler(this.fastColoredTextBox_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.fastColoredTextBox_SizeChanged);
            this.rightKeyMenuStrip.ResumeLayout(false);
            this.tabMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem windowSettingToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip rightKeyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox;
        private System.Windows.Forms.ContextMenuStrip tabMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllBookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopScrollToolStripMenuItem;
        private System.Windows.Forms.ImageList menuStripImageList;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem stackToolStrip;
    }
}