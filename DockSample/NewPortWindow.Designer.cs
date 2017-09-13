namespace DockSample
{
    partial class NewPortWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPortWindow));
            this.treeViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.stateFaceImageList = new System.Windows.Forms.ImageList(this.components);
            this.portOpenStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.portInfoStatusStrip = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRcvWinName = new System.Windows.Forms.ComboBox();
            this.flowComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stopbitsComboBox = new System.Windows.Forms.ComboBox();
            this.databitsComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.baudrateComboBox = new System.Windows.Forms.ComboBox();
            this.portTreeView = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAdd = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btCustomBaud = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.portInfoStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewImageList
            // 
            this.treeViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeViewImageList.ImageStream")));
            this.treeViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.treeViewImageList.Images.SetKeyName(0, "link.png");
            this.treeViewImageList.Images.SetKeyName(1, "link-broken.png");
            this.treeViewImageList.Images.SetKeyName(2, "checkbox-empty.png");
            this.treeViewImageList.Images.SetKeyName(3, "checkbox.png");
            this.treeViewImageList.Images.SetKeyName(4, "connect-alt-1.png");
            this.treeViewImageList.Images.SetKeyName(5, "connection-error-alt-1.png");
            // 
            // stateFaceImageList
            // 
            this.stateFaceImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("stateFaceImageList.ImageStream")));
            this.stateFaceImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.stateFaceImageList.Images.SetKeyName(0, "connect.png");
            this.stateFaceImageList.Images.SetKeyName(1, "connection-error.png");
            this.stateFaceImageList.Images.SetKeyName(2, "user-locked.png");
            this.stateFaceImageList.Images.SetKeyName(3, "user.png");
            // 
            // portOpenStatusLabel
            // 
            this.portOpenStatusLabel.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.portOpenStatusLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.portOpenStatusLabel.Margin = new System.Windows.Forms.Padding(2);
            this.portOpenStatusLabel.Name = "portOpenStatusLabel";
            this.portOpenStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.portOpenStatusLabel.Size = new System.Drawing.Size(95, 18);
            this.portOpenStatusLabel.Text = "Port Status";
            // 
            // portInfoStatusStrip
            // 
            this.portInfoStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.portInfoStatusStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.portInfoStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portOpenStatusLabel});
            this.portInfoStatusStrip.Location = new System.Drawing.Point(0, 217);
            this.portInfoStatusStrip.Name = "portInfoStatusStrip";
            this.portInfoStatusStrip.Size = new System.Drawing.Size(421, 22);
            this.portInfoStatusStrip.SizingGrip = false;
            this.portInfoStatusStrip.Stretch = false;
            this.portInfoStatusStrip.TabIndex = 26;
            this.portInfoStatusStrip.Text = "portInfoStatusStrip";
            this.portInfoStatusStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 1);
            this.panel1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(227, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 42;
            this.label2.Text = "Name";
            // 
            // cbRcvWinName
            // 
            this.cbRcvWinName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRcvWinName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.cbRcvWinName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRcvWinName.FormattingEnabled = true;
            this.cbRcvWinName.Location = new System.Drawing.Point(318, 37);
            this.cbRcvWinName.Name = "cbRcvWinName";
            this.cbRcvWinName.Size = new System.Drawing.Size(95, 20);
            this.cbRcvWinName.TabIndex = 41;
            // 
            // flowComboBox
            // 
            this.flowComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.flowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flowComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowComboBox.FormattingEnabled = true;
            this.flowComboBox.Items.AddRange(new object[] {
            "None",
            "Hardware",
            "Software"});
            this.flowComboBox.Location = new System.Drawing.Point(318, 187);
            this.flowComboBox.Name = "flowComboBox";
            this.flowComboBox.Size = new System.Drawing.Size(95, 20);
            this.flowComboBox.TabIndex = 40;
            // 
            // parityComboBox
            // 
            this.parityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.parityComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.parityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.parityComboBox.Location = new System.Drawing.Point(318, 162);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(95, 20);
            this.parityComboBox.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 38;
            this.label3.Text = "Flow control";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "Parity";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 36;
            this.label5.Text = "Stop bits";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 35;
            this.label6.Text = "Data bits";
            // 
            // stopbitsComboBox
            // 
            this.stopbitsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopbitsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.stopbitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopbitsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopbitsComboBox.FormattingEnabled = true;
            this.stopbitsComboBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopbitsComboBox.Location = new System.Drawing.Point(318, 137);
            this.stopbitsComboBox.Name = "stopbitsComboBox";
            this.stopbitsComboBox.Size = new System.Drawing.Size(95, 20);
            this.stopbitsComboBox.TabIndex = 34;
            // 
            // databitsComboBox
            // 
            this.databitsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.databitsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.databitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databitsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.databitsComboBox.FormattingEnabled = true;
            this.databitsComboBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databitsComboBox.Location = new System.Drawing.Point(318, 112);
            this.databitsComboBox.Name = "databitsComboBox";
            this.databitsComboBox.Size = new System.Drawing.Size(95, 20);
            this.databitsComboBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "Baud rate";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(227, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "Port";
            // 
            // portComboBox
            // 
            this.portComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.portComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(318, 62);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(95, 20);
            this.portComboBox.TabIndex = 29;
            // 
            // baudrateComboBox
            // 
            this.baudrateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.baudrateComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.baudrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudrateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baudrateComboBox.FormattingEnabled = true;
            this.baudrateComboBox.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "128000",
            "115200",
            "256000"});
            this.baudrateComboBox.Location = new System.Drawing.Point(318, 87);
            this.baudrateComboBox.Name = "baudrateComboBox";
            this.baudrateComboBox.Size = new System.Drawing.Size(95, 20);
            this.baudrateComboBox.TabIndex = 30;
            // 
            // portTreeView
            // 
            this.portTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.portTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.portTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portTreeView.Location = new System.Drawing.Point(8, 37);
            this.portTreeView.Name = "portTreeView";
            this.portTreeView.Size = new System.Drawing.Size(197, 169);
            this.portTreeView.StateImageList = this.treeViewImageList;
            this.portTreeView.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(213, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 160);
            this.panel2.TabIndex = 46;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("DengXian", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Image = global::DockSample.Properties.Resources.database_add_alt_2;
            this.btAdd.Location = new System.Drawing.Point(330, 1);
            this.btAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btAdd.Name = "btAdd";
            this.btAdd.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btAdd.Size = new System.Drawing.Size(23, 22);
            this.btAdd.TabIndex = 49;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAddCfg_Click);
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.FlatAppearance.BorderSize = 0;
            this.btOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Webdings", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btOk.Image = global::DockSample.Properties.Resources.check;
            this.btOk.Location = new System.Drawing.Point(365, 1);
            this.btOk.Margin = new System.Windows.Forms.Padding(0);
            this.btOk.Name = "btOk";
            this.btOk.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btOk.Size = new System.Drawing.Size(23, 22);
            this.btOk.TabIndex = 48;
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOpenPort_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btCancel.Image = global::DockSample.Properties.Resources.cancel;
            this.btCancel.Location = new System.Drawing.Point(391, 1);
            this.btCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btCancel.Name = "btCancel";
            this.btCancel.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btCancel.Size = new System.Drawing.Size(30, 22);
            this.btCancel.TabIndex = 47;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btDel
            // 
            this.btDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDel.FlatAppearance.BorderSize = 0;
            this.btDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.Font = new System.Drawing.Font("DengXian", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDel.Image = global::DockSample.Properties.Resources.database_remove_alt_2;
            this.btDel.Location = new System.Drawing.Point(304, 1);
            this.btDel.Margin = new System.Windows.Forms.Padding(0);
            this.btDel.Name = "btDel";
            this.btDel.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btDel.Size = new System.Drawing.Size(23, 22);
            this.btDel.TabIndex = 50;
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDelCfg_Click);
            // 
            // btCustomBaud
            // 
            this.btCustomBaud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCustomBaud.FlatAppearance.BorderSize = 0;
            this.btCustomBaud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.btCustomBaud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCustomBaud.Font = new System.Drawing.Font("DengXian", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCustomBaud.Image = global::DockSample.Properties.Resources.user_locked;
            this.btCustomBaud.Location = new System.Drawing.Point(278, 1);
            this.btCustomBaud.Margin = new System.Windows.Forms.Padding(0);
            this.btCustomBaud.Name = "btCustomBaud";
            this.btCustomBaud.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btCustomBaud.Size = new System.Drawing.Size(23, 22);
            this.btCustomBaud.TabIndex = 51;
            this.btCustomBaud.UseVisualStyleBackColor = true;
            this.btCustomBaud.Click += new System.EventHandler(this.btEnableCustomBaud_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(357, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 16);
            this.panel3.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 53;
            this.label1.Text = "New Port";
            // 
            // NewPortWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(421, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btCustomBaud);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.portTreeView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRcvWinName);
            this.Controls.Add(this.flowComboBox);
            this.Controls.Add(this.parityComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stopbitsComboBox);
            this.Controls.Add(this.databitsComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.baudrateComboBox);
            this.Controls.Add(this.portInfoStatusStrip);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPortWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewPortWindow";
            this.Load += new System.EventHandler(this.NewPortWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.portInfoStatusStrip.ResumeLayout(false);
            this.portInfoStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList treeViewImageList;
        private System.Windows.Forms.ImageList stateFaceImageList;
        private System.Windows.Forms.ToolStripStatusLabel portOpenStatusLabel;
        private System.Windows.Forms.StatusStrip portInfoStatusStrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRcvWinName;
        private System.Windows.Forms.ComboBox flowComboBox;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox stopbitsComboBox;
        private System.Windows.Forms.ComboBox databitsComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.ComboBox baudrateComboBox;
        private System.Windows.Forms.TreeView portTreeView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btCustomBaud;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}