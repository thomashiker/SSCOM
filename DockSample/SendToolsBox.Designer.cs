namespace DockSample
{
    partial class SendToolsBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendToolsBox));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Root");
            this.treeViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.favoriteContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendCmdsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.unCheckAllToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.rootContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.sendCmdToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.addCmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCmdAfterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delCmdToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.checkedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtLoop = new System.Windows.Forms.ToolStripButton();
            this.tsbtShuffle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtTimer = new System.Windows.Forms.ToolStripButton();
            this.tstbTimerInterval = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.sendToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbtReset = new System.Windows.Forms.ToolStripButton();
            this.treeViewFavorite = new System.Windows.Forms.TreeView();
            this.favoriteContextMenuStrip.SuspendLayout();
            this.rootContextMenuStrip.SuspendLayout();
            this.cmdContextMenuStrip.SuspendLayout();
            this.sendToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewImageList
            // 
            this.treeViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeViewImageList.ImageStream")));
            this.treeViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.treeViewImageList.Images.SetKeyName(0, "directions-alt.png");
            this.treeViewImageList.Images.SetKeyName(1, "badge.png");
            this.treeViewImageList.Images.SetKeyName(2, "checkbox-empty.png");
            this.treeViewImageList.Images.SetKeyName(3, "checkbox.png");
            this.treeViewImageList.Images.SetKeyName(4, "ui_check_box_uncheck.png");
            this.treeViewImageList.Images.SetKeyName(5, "ui_check_box_mix.png");
            this.treeViewImageList.Images.SetKeyName(6, "home.png");
            this.treeViewImageList.Images.SetKeyName(7, "star.png");
            // 
            // favoriteContextMenuStrip
            // 
            this.favoriteContextMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.favoriteContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.addSonToolStripMenuItem,
            this.delFavoriteToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendCmdsToolStrip,
            this.checkAllToolStrip,
            this.unCheckAllToolStrip});
            this.favoriteContextMenuStrip.Name = "favoriteContextMenuStrip";
            this.favoriteContextMenuStrip.Size = new System.Drawing.Size(160, 142);
            this.favoriteContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.favoriteContextMenuStrip_Opening);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::DockSample.Properties.Resources.terminal;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addCommanderToolStripMenuItem_Click);
            // 
            // addSonToolStripMenuItem
            // 
            this.addSonToolStripMenuItem.Image = global::DockSample.Properties.Resources.badge;
            this.addSonToolStripMenuItem.Name = "addSonToolStripMenuItem";
            this.addSonToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addSonToolStripMenuItem.Text = "&New";
            this.addSonToolStripMenuItem.Click += new System.EventHandler(this.addFavoriteToolStripMenuItem_Click);
            // 
            // delFavoriteToolStripMenuItem
            // 
            this.delFavoriteToolStripMenuItem.Image = global::DockSample.Properties.Resources.delete;
            this.delFavoriteToolStripMenuItem.Name = "delFavoriteToolStripMenuItem";
            this.delFavoriteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.delFavoriteToolStripMenuItem.Text = "&Delete";
            this.delFavoriteToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // sendCmdsToolStrip
            // 
            this.sendCmdsToolStrip.Image = global::DockSample.Properties.Resources.chat_active;
            this.sendCmdsToolStrip.Name = "sendCmdsToolStrip";
            this.sendCmdsToolStrip.Size = new System.Drawing.Size(159, 22);
            this.sendCmdsToolStrip.Text = "&Send Checked";
            this.sendCmdsToolStrip.Click += new System.EventHandler(this.sendCmdsToolStrip_Click);
            // 
            // checkAllToolStrip
            // 
            this.checkAllToolStrip.Image = global::DockSample.Properties.Resources.check_alt;
            this.checkAllToolStrip.Name = "checkAllToolStrip";
            this.checkAllToolStrip.Size = new System.Drawing.Size(159, 22);
            this.checkAllToolStrip.Text = "&Check All";
            this.checkAllToolStrip.Click += new System.EventHandler(this.checkAllToolStrip_Click);
            // 
            // unCheckAllToolStrip
            // 
            this.unCheckAllToolStrip.Image = global::DockSample.Properties.Resources.cancel;
            this.unCheckAllToolStrip.Name = "unCheckAllToolStrip";
            this.unCheckAllToolStrip.Size = new System.Drawing.Size(159, 22);
            this.unCheckAllToolStrip.Text = "&UnCheck All";
            this.unCheckAllToolStrip.Click += new System.EventHandler(this.unCheckAllToolStrip_Click);
            // 
            // rootContextMenuStrip
            // 
            this.rootContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFavoriteToolStripMenuItem});
            this.rootContextMenuStrip.Name = "rootContextMenuStrip";
            this.rootContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.rootContextMenuStrip.Size = new System.Drawing.Size(103, 26);
            // 
            // addFavoriteToolStripMenuItem
            // 
            this.addFavoriteToolStripMenuItem.Image = global::DockSample.Properties.Resources.badge;
            this.addFavoriteToolStripMenuItem.Name = "addFavoriteToolStripMenuItem";
            this.addFavoriteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.addFavoriteToolStripMenuItem.Text = "&New";
            this.addFavoriteToolStripMenuItem.Click += new System.EventHandler(this.addFavoriteToolStripMenuItem_Click);
            // 
            // cmdContextMenuStrip
            // 
            this.cmdContextMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStrip,
            this.sendCmdToolStrip,
            this.toolStripSeparator3,
            this.addCmdToolStripMenuItem,
            this.addCmdAfterToolStripMenuItem,
            this.delCmdToolStrip,
            this.toolStripSeparator4,
            this.checkedToolStripMenuItem,
            this.unCheckToolStripMenuItem,
            this.toolStripSeparator5,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem});
            this.cmdContextMenuStrip.Name = "cmdContextMenuStrip";
            this.cmdContextMenuStrip.Size = new System.Drawing.Size(135, 220);
            // 
            // editToolStrip
            // 
            this.editToolStrip.Image = global::DockSample.Properties.Resources.file_edit;
            this.editToolStrip.Name = "editToolStrip";
            this.editToolStrip.Size = new System.Drawing.Size(134, 22);
            this.editToolStrip.Text = "Edit";
            this.editToolStrip.Click += new System.EventHandler(this.editToolStrip_Click);
            // 
            // sendCmdToolStrip
            // 
            this.sendCmdToolStrip.Image = global::DockSample.Properties.Resources.chat_active;
            this.sendCmdToolStrip.Name = "sendCmdToolStrip";
            this.sendCmdToolStrip.Size = new System.Drawing.Size(134, 22);
            this.sendCmdToolStrip.Text = "Send";
            this.sendCmdToolStrip.Click += new System.EventHandler(this.sendCmdToolStrip_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(131, 6);
            // 
            // addCmdToolStripMenuItem
            // 
            this.addCmdToolStripMenuItem.Image = global::DockSample.Properties.Resources.shapes_move_front;
            this.addCmdToolStripMenuItem.Name = "addCmdToolStripMenuItem";
            this.addCmdToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addCmdToolStripMenuItem.Text = "Add Front";
            this.addCmdToolStripMenuItem.Click += new System.EventHandler(this.addCmdFrontToolStripMenuItem_Click);
            // 
            // addCmdAfterToolStripMenuItem
            // 
            this.addCmdAfterToolStripMenuItem.Image = global::DockSample.Properties.Resources.shapes_move_back;
            this.addCmdAfterToolStripMenuItem.Name = "addCmdAfterToolStripMenuItem";
            this.addCmdAfterToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addCmdAfterToolStripMenuItem.Text = "Add Back";
            this.addCmdAfterToolStripMenuItem.Click += new System.EventHandler(this.addCmdBackToolStripMenuItem_Click);
            // 
            // delCmdToolStrip
            // 
            this.delCmdToolStrip.Image = global::DockSample.Properties.Resources.delete;
            this.delCmdToolStrip.Name = "delCmdToolStrip";
            this.delCmdToolStrip.Size = new System.Drawing.Size(134, 22);
            this.delCmdToolStrip.Text = "Delete";
            this.delCmdToolStrip.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(131, 6);
            // 
            // checkedToolStripMenuItem
            // 
            this.checkedToolStripMenuItem.Image = global::DockSample.Properties.Resources.check_alt;
            this.checkedToolStripMenuItem.Name = "checkedToolStripMenuItem";
            this.checkedToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.checkedToolStripMenuItem.Text = "Check";
            this.checkedToolStripMenuItem.Click += new System.EventHandler(this.checkedToolStripMenuItem_Click);
            // 
            // unCheckToolStripMenuItem
            // 
            this.unCheckToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.unCheckToolStripMenuItem.Image = global::DockSample.Properties.Resources.cancel;
            this.unCheckToolStripMenuItem.Name = "unCheckToolStripMenuItem";
            this.unCheckToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.unCheckToolStripMenuItem.Text = "UnCheck";
            this.unCheckToolStripMenuItem.Click += new System.EventHandler(this.uncheckedToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(131, 6);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Image = global::DockSample.Properties.Resources.arrow_3_up;
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.moveUpToolStripMenuItem.Text = "Move Up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.treeView1_MoveUp_Click);
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Image = global::DockSample.Properties.Resources.arrow_3_down;
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.moveDownToolStripMenuItem.Text = "Move Dn";
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.treeView1_MoveDown_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 18);
            // 
            // tsbtLoop
            // 
            this.tsbtLoop.CheckOnClick = true;
            this.tsbtLoop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtLoop.Enabled = false;
            this.tsbtLoop.Image = global::DockSample.Properties.Resources.MD_repeat_alt;
            this.tsbtLoop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtLoop.Name = "tsbtLoop";
            this.tsbtLoop.Size = new System.Drawing.Size(23, 22);
            this.tsbtLoop.Text = "Loop";
            this.tsbtLoop.Click += new System.EventHandler(this.tsbtLoop_Click);
            // 
            // tsbtShuffle
            // 
            this.tsbtShuffle.CheckOnClick = true;
            this.tsbtShuffle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtShuffle.Enabled = false;
            this.tsbtShuffle.Image = global::DockSample.Properties.Resources.MD_shuffle;
            this.tsbtShuffle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtShuffle.Name = "tsbtShuffle";
            this.tsbtShuffle.Size = new System.Drawing.Size(23, 22);
            this.tsbtShuffle.Text = "Shuffle";
            this.tsbtShuffle.Click += new System.EventHandler(this.tsbtShuffle_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.AutoSize = false;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 18);
            // 
            // tsbtTimer
            // 
            this.tsbtTimer.CheckOnClick = true;
            this.tsbtTimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtTimer.Enabled = false;
            this.tsbtTimer.Image = global::DockSample.Properties.Resources.alarm;
            this.tsbtTimer.ImageTransparentColor = System.Drawing.SystemColors.Highlight;
            this.tsbtTimer.Name = "tsbtTimer";
            this.tsbtTimer.Size = new System.Drawing.Size(23, 22);
            this.tsbtTimer.Text = "Enable Timer";
            this.tsbtTimer.Click += new System.EventHandler(this.tsbtTimer_Click);
            // 
            // tstbTimerInterval
            // 
            this.tstbTimerInterval.BackColor = System.Drawing.SystemColors.Window;
            this.tstbTimerInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tstbTimerInterval.Margin = new System.Windows.Forms.Padding(0);
            this.tstbTimerInterval.Name = "tstbTimerInterval";
            this.tstbTimerInterval.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.tstbTimerInterval.Size = new System.Drawing.Size(29, 25);
            this.tstbTimerInterval.Text = "1000";
            this.tstbTimerInterval.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tstbTimerInterval.ToolTipText = "ms";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel1.Text = "ms";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.AutoSize = false;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 18);
            // 
            // sendToolStrip
            // 
            this.sendToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.sendToolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.sendToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.sendToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtReset,
            this.toolStripSeparator2,
            this.tsbtLoop,
            this.tsbtShuffle,
            this.toolStripSeparator6,
            this.tsbtTimer,
            this.tstbTimerInterval,
            this.toolStripLabel1,
            this.toolStripSeparator7});
            this.sendToolStrip.Location = new System.Drawing.Point(0, 4);
            this.sendToolStrip.Name = "sendToolStrip";
            this.sendToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.sendToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.sendToolStrip.Size = new System.Drawing.Size(232, 25);
            this.sendToolStrip.TabIndex = 10;
            this.sendToolStrip.Text = "toolStrip1";
            // 
            // tsbtReset
            // 
            this.tsbtReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtReset.Image = global::DockSample.Properties.Resources.MD_reload;
            this.tsbtReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtReset.Name = "tsbtReset";
            this.tsbtReset.Size = new System.Drawing.Size(23, 22);
            this.tsbtReset.Text = "Reset";
            this.tsbtReset.Click += new System.EventHandler(this.tsbtReset_Click);
            // 
            // treeViewFavorite
            // 
            this.treeViewFavorite.AllowDrop = true;
            this.treeViewFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.treeViewFavorite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewFavorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFavorite.ImageIndex = 0;
            this.treeViewFavorite.ImageList = this.treeViewImageList;
            this.treeViewFavorite.Indent = 19;
            this.treeViewFavorite.ItemHeight = 18;
            this.treeViewFavorite.LabelEdit = true;
            this.treeViewFavorite.Location = new System.Drawing.Point(0, 29);
            this.treeViewFavorite.Name = "treeViewFavorite";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "";
            treeNode1.Text = "Root";
            this.treeViewFavorite.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewFavorite.SelectedImageIndex = 0;
            this.treeViewFavorite.ShowNodeToolTips = true;
            this.treeViewFavorite.Size = new System.Drawing.Size(232, 331);
            this.treeViewFavorite.TabIndex = 0;
            this.treeViewFavorite.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewFavorite_ItemDrag);
            this.treeViewFavorite.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFavorite_AfterSelect);
            this.treeViewFavorite.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewFavorite_DragDrop);
            this.treeViewFavorite.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewFavorite_DragEnter);
            this.treeViewFavorite.DoubleClick += new System.EventHandler(this.treeViewFavorite_DoubleClick);
            this.treeViewFavorite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewFavorite_MouseDown);
            // 
            // SendToolsBox
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(232, 361);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.treeViewFavorite);
            this.Controls.Add(this.sendToolStrip);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(180, 100);
            this.Name = "SendToolsBox";
            this.Padding = new System.Windows.Forms.Padding(0, 4, 0, 1);
            this.TabText = "Solution Explorer";
            this.Text = "SendToolsBox";
            this.favoriteContextMenuStrip.ResumeLayout(false);
            this.rootContextMenuStrip.ResumeLayout(false);
            this.cmdContextMenuStrip.ResumeLayout(false);
            this.sendToolStrip.ResumeLayout(false);
            this.sendToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        private System.Windows.Forms.ContextMenuStrip favoriteContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delFavoriteToolStripMenuItem;
        private System.Windows.Forms.ImageList treeViewImageList;
        private System.Windows.Forms.ContextMenuStrip rootContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addFavoriteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmdContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addCmdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delCmdToolStrip;
        private System.Windows.Forms.ToolStripMenuItem addCmdAfterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStrip;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendCmdsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem sendCmdToolStrip;
        private System.Windows.Forms.ToolStripMenuItem addSonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtLoop;
        private System.Windows.Forms.ToolStripButton tsbtShuffle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbtTimer;
        private System.Windows.Forms.ToolStripTextBox tstbTimerInterval;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStrip sendToolStrip;
        private System.Windows.Forms.TreeView treeViewFavorite;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStrip;
        private System.Windows.Forms.ToolStripMenuItem unCheckAllToolStrip;
        private System.Windows.Forms.ToolStripButton tsbtReset;
    }
}