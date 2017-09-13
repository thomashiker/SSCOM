namespace PortSettingContextMenu
{
    partial class PortSettingMenu
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOpen = new System.Windows.Forms.Button();
            this.cbPortList = new System.Windows.Forms.ComboBox();
            this.cbBaudRateList = new System.Windows.Forms.ComboBox();
            this.cbDataBitsList = new System.Windows.Forms.ComboBox();
            this.cbStopBitsList = new System.Windows.Forms.ComboBox();
            this.cbParityList = new System.Windows.Forms.ComboBox();
            this.cbFlowCtrlList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbPortFavourate = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btReloadPort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 1);
            this.panel1.TabIndex = 3;
            // 
            // btOpen
            // 
            this.btOpen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpen.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btOpen.Location = new System.Drawing.Point(136, 149);
            this.btOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(50, 25);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "&Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // cbPortList
            // 
            this.cbPortList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.cbPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPortList.FormattingEnabled = true;
            this.cbPortList.Location = new System.Drawing.Point(107, 9);
            this.cbPortList.Name = "cbPortList";
            this.cbPortList.Size = new System.Drawing.Size(80, 20);
            this.cbPortList.TabIndex = 4;
            // 
            // cbBaudRateList
            // 
            this.cbBaudRateList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.cbBaudRateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBaudRateList.FormattingEnabled = true;
            this.cbBaudRateList.Items.AddRange(new object[] {
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
            this.cbBaudRateList.Location = new System.Drawing.Point(107, 32);
            this.cbBaudRateList.Name = "cbBaudRateList";
            this.cbBaudRateList.Size = new System.Drawing.Size(80, 20);
            this.cbBaudRateList.TabIndex = 5;
            // 
            // cbDataBitsList
            // 
            this.cbDataBitsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.cbDataBitsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBitsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDataBitsList.FormattingEnabled = true;
            this.cbDataBitsList.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBitsList.Location = new System.Drawing.Point(107, 55);
            this.cbDataBitsList.Name = "cbDataBitsList";
            this.cbDataBitsList.Size = new System.Drawing.Size(80, 20);
            this.cbDataBitsList.TabIndex = 6;
            // 
            // cbStopBitsList
            // 
            this.cbStopBitsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.cbStopBitsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBitsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStopBitsList.FormattingEnabled = true;
            this.cbStopBitsList.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStopBitsList.Location = new System.Drawing.Point(107, 78);
            this.cbStopBitsList.Name = "cbStopBitsList";
            this.cbStopBitsList.Size = new System.Drawing.Size(80, 20);
            this.cbStopBitsList.TabIndex = 7;
            // 
            // cbParityList
            // 
            this.cbParityList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.cbParityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParityList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbParityList.FormattingEnabled = true;
            this.cbParityList.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbParityList.Location = new System.Drawing.Point(107, 101);
            this.cbParityList.Name = "cbParityList";
            this.cbParityList.Size = new System.Drawing.Size(80, 20);
            this.cbParityList.TabIndex = 8;
            // 
            // cbFlowCtrlList
            // 
            this.cbFlowCtrlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.cbFlowCtrlList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFlowCtrlList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFlowCtrlList.FormattingEnabled = true;
            this.cbFlowCtrlList.Items.AddRange(new object[] {
            "None",
            "Hardware",
            "Software"});
            this.cbFlowCtrlList.Location = new System.Drawing.Point(107, 124);
            this.cbFlowCtrlList.Name = "cbFlowCtrlList";
            this.cbFlowCtrlList.Size = new System.Drawing.Size(80, 20);
            this.cbFlowCtrlList.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 44;
            this.label3.Text = "Flow Ctrl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 43;
            this.label4.Text = "Parity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 42;
            this.label5.Text = "Stop bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 41;
            this.label6.Text = "Data bits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "Baud rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(8, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 39;
            this.label8.Text = "Port";
            // 
            // lbPortFavourate
            // 
            this.lbPortFavourate.BackColor = System.Drawing.Color.White;
            this.lbPortFavourate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPortFavourate.FormattingEnabled = true;
            this.lbPortFavourate.ItemHeight = 12;
            this.lbPortFavourate.Location = new System.Drawing.Point(10, 177);
            this.lbPortFavourate.Name = "lbPortFavourate";
            this.lbPortFavourate.Size = new System.Drawing.Size(176, 60);
            this.lbPortFavourate.TabIndex = 45;
            this.lbPortFavourate.SelectedIndexChanged += new System.EventHandler(this.lbPortFavourate_SelectedIndexChanged);
            // 
            // btAdd
            // 
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(10, 149);
            this.btAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(50, 25);
            this.btAdd.TabIndex = 46;
            this.btAdd.Text = "&Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Location = new System.Drawing.Point(73, 149);
            this.btDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(50, 25);
            this.btDelete.TabIndex = 47;
            this.btDelete.Text = "&Del";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 244);
            this.panel2.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(194, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 244);
            this.panel3.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 244);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 1);
            this.panel4.TabIndex = 4;
            // 
            // btReloadPort
            // 
            this.btReloadPort.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btReloadPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReloadPort.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReloadPort.Image = global::PortSettingContextMenu.Properties.Resources._3D_Z_Axis_Rotation;
            this.btReloadPort.Location = new System.Drawing.Point(83, 8);
            this.btReloadPort.Margin = new System.Windows.Forms.Padding(0);
            this.btReloadPort.Name = "btReloadPort";
            this.btReloadPort.Size = new System.Drawing.Size(21, 21);
            this.btReloadPort.TabIndex = 50;
            this.btReloadPort.UseVisualStyleBackColor = true;
            this.btReloadPort.Click += new System.EventHandler(this.btReloadPort_Click);
            // 
            // PortSettingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.btReloadPort);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbPortFavourate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbFlowCtrlList);
            this.Controls.Add(this.cbParityList);
            this.Controls.Add(this.cbStopBitsList);
            this.Controls.Add(this.cbDataBitsList);
            this.Controls.Add(this.cbBaudRateList);
            this.Controls.Add(this.cbPortList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btOpen);
            this.Name = "PortSettingMenu";
            this.Size = new System.Drawing.Size(195, 245);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbPortList;
        private System.Windows.Forms.ComboBox cbBaudRateList;
        private System.Windows.Forms.ComboBox cbDataBitsList;
        private System.Windows.Forms.ComboBox cbStopBitsList;
        private System.Windows.Forms.ComboBox cbParityList;
        private System.Windows.Forms.ComboBox cbFlowCtrlList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbPortFavourate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btReloadPort;
    }
}
