namespace DockSample
{
    partial class HistoryWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryWindow));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.menuButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeButton = new System.Windows.Forms.ToolStripButton();
            this.topMostButton = new System.Windows.Forms.ToolStripButton();
            this.sendButton = new System.Windows.Forms.ToolStripButton();
            this.historyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuImageList = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.heloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuButton,
            this.closeButton,
            this.topMostButton,
            this.sendButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(330, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip_MouseDown);
            this.toolStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStrip_MouseMove);
            this.toolStrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStrip_MouseUp);
            // 
            // menuButton
            // 
            this.menuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.menuButton.Font = new System.Drawing.Font("STLiti", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuButton.Name = "menuButton";
            this.menuButton.ShowDropDownArrow = false;
            this.menuButton.Size = new System.Drawing.Size(49, 22);
            this.menuButton.Text = "History";
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearToolStripMenuItem.Image = global::DockSample.Properties.Resources.brush_alt_2;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            // 
            // closeButton
            // 
            this.closeButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeButton.Image = global::DockSample.Properties.Resources.cancel;
            this.closeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 22);
            this.closeButton.Text = "Close";
            this.closeButton.ToolTipText = "Close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // topMostButton
            // 
            this.topMostButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.topMostButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topMostButton.Image = global::DockSample.Properties.Resources.arrow_3_down_left;
            this.topMostButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topMostButton.Name = "topMostButton";
            this.topMostButton.Size = new System.Drawing.Size(23, 22);
            this.topMostButton.Text = "Top Most";
            this.topMostButton.Click += new System.EventHandler(this.topMostButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sendButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sendButton.Image = global::DockSample.Properties.Resources.chat_active;
            this.sendButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(23, 22);
            this.sendButton.Text = "Send Message";
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // historyRichTextBox
            // 
            this.historyRichTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.historyRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyRichTextBox.Location = new System.Drawing.Point(0, 25);
            this.historyRichTextBox.Name = "historyRichTextBox";
            this.historyRichTextBox.ReadOnly = true;
            this.historyRichTextBox.Size = new System.Drawing.Size(330, 126);
            this.historyRichTextBox.TabIndex = 2;
            this.historyRichTextBox.Text = "";
            // 
            // menuImageList
            // 
            this.menuImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuImageList.ImageStream")));
            this.menuImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuImageList.Images.SetKeyName(0, "arrow-3-down-left.png");
            this.menuImageList.Images.SetKeyName(1, "arrow-3-up-left.png");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heloToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(104, 26);
            // 
            // heloToolStripMenuItem
            // 
            this.heloToolStripMenuItem.Name = "heloToolStripMenuItem";
            this.heloToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.heloToolStripMenuItem.Text = "Helo";
            // 
            // HistoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 151);
            this.Controls.Add(this.historyRichTextBox);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryWindow";
            this.Deactivate += new System.EventHandler(this.HistoryWindow_Deactivate);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton topMostButton;
        private System.Windows.Forms.ToolStripButton sendButton;
        private System.Windows.Forms.RichTextBox historyRichTextBox;
        private System.Windows.Forms.ToolStripButton closeButton;
        private System.Windows.Forms.ImageList menuImageList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem heloToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton menuButton;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;

    }
}