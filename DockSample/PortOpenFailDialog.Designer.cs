namespace DockSample
{
    partial class PortOpenFailDialog
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btIgnore = new System.Windows.Forms.Button();
            this.portNameLabelTag = new System.Windows.Forms.Label();
            this.warnPicBox = new System.Windows.Forms.PictureBox();
            this.baudRateLabelTag = new System.Windows.Forms.Label();
            this.parityLabelTag = new System.Windows.Forms.Label();
            this.dataBitsLabelTag = new System.Windows.Forms.Label();
            this.stopBitsLabelTag = new System.Windows.Forms.Label();
            this.stopBitsLabel = new System.Windows.Forms.Label();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.parityLabel = new System.Windows.Forms.Label();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.portNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.warnPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Location = new System.Drawing.Point(186, 104);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "&Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btIgnore
            // 
            this.btIgnore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIgnore.Location = new System.Drawing.Point(93, 104);
            this.btIgnore.Name = "btIgnore";
            this.btIgnore.Size = new System.Drawing.Size(75, 23);
            this.btIgnore.TabIndex = 1;
            this.btIgnore.Text = "&Ignore";
            this.btIgnore.UseVisualStyleBackColor = true;
            this.btIgnore.Click += new System.EventHandler(this.btIgnore_Click);
            // 
            // portNameLabelTag
            // 
            this.portNameLabelTag.AutoSize = true;
            this.portNameLabelTag.Location = new System.Drawing.Point(121, 13);
            this.portNameLabelTag.Name = "portNameLabelTag";
            this.portNameLabelTag.Size = new System.Drawing.Size(59, 12);
            this.portNameLabelTag.TabIndex = 3;
            this.portNameLabelTag.Text = "Port    :";
            // 
            // warnPicBox
            // 
            this.warnPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.warnPicBox.Image = global::DockSample.Properties.Resources.error_64px;
            this.warnPicBox.InitialImage = null;
            this.warnPicBox.Location = new System.Drawing.Point(10, 14);
            this.warnPicBox.Name = "warnPicBox";
            this.warnPicBox.Size = new System.Drawing.Size(64, 64);
            this.warnPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.warnPicBox.TabIndex = 2;
            this.warnPicBox.TabStop = false;
            // 
            // baudRateLabelTag
            // 
            this.baudRateLabelTag.AutoSize = true;
            this.baudRateLabelTag.Location = new System.Drawing.Point(121, 31);
            this.baudRateLabelTag.Name = "baudRateLabelTag";
            this.baudRateLabelTag.Size = new System.Drawing.Size(59, 12);
            this.baudRateLabelTag.TabIndex = 4;
            this.baudRateLabelTag.Text = "BaudRate:";
            // 
            // parityLabelTag
            // 
            this.parityLabelTag.AutoSize = true;
            this.parityLabelTag.Location = new System.Drawing.Point(121, 49);
            this.parityLabelTag.Name = "parityLabelTag";
            this.parityLabelTag.Size = new System.Drawing.Size(59, 12);
            this.parityLabelTag.TabIndex = 5;
            this.parityLabelTag.Text = "Parity  :";
            // 
            // dataBitsLabelTag
            // 
            this.dataBitsLabelTag.AutoSize = true;
            this.dataBitsLabelTag.Location = new System.Drawing.Point(121, 67);
            this.dataBitsLabelTag.Name = "dataBitsLabelTag";
            this.dataBitsLabelTag.Size = new System.Drawing.Size(59, 12);
            this.dataBitsLabelTag.TabIndex = 6;
            this.dataBitsLabelTag.Text = "DataBits:";
            // 
            // stopBitsLabelTag
            // 
            this.stopBitsLabelTag.AutoSize = true;
            this.stopBitsLabelTag.Location = new System.Drawing.Point(121, 85);
            this.stopBitsLabelTag.Name = "stopBitsLabelTag";
            this.stopBitsLabelTag.Size = new System.Drawing.Size(59, 12);
            this.stopBitsLabelTag.TabIndex = 7;
            this.stopBitsLabelTag.Text = "StopBits:";
            // 
            // stopBitsLabel
            // 
            this.stopBitsLabel.AutoSize = true;
            this.stopBitsLabel.Location = new System.Drawing.Point(189, 86);
            this.stopBitsLabel.Name = "stopBitsLabel";
            this.stopBitsLabel.Size = new System.Drawing.Size(47, 12);
            this.stopBitsLabel.TabIndex = 12;
            this.stopBitsLabel.Text = "Unknown";
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Location = new System.Drawing.Point(189, 68);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(47, 12);
            this.dataBitsLabel.TabIndex = 11;
            this.dataBitsLabel.Text = "Unknown";
            // 
            // parityLabel
            // 
            this.parityLabel.AutoSize = true;
            this.parityLabel.Location = new System.Drawing.Point(189, 50);
            this.parityLabel.Name = "parityLabel";
            this.parityLabel.Size = new System.Drawing.Size(47, 12);
            this.parityLabel.TabIndex = 10;
            this.parityLabel.Text = "Unknown";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(189, 32);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(47, 12);
            this.baudRateLabel.TabIndex = 9;
            this.baudRateLabel.Text = "Unknown";
            // 
            // portNameLabel
            // 
            this.portNameLabel.AutoSize = true;
            this.portNameLabel.Location = new System.Drawing.Point(189, 14);
            this.portNameLabel.Name = "portNameLabel";
            this.portNameLabel.Size = new System.Drawing.Size(47, 12);
            this.portNameLabel.TabIndex = 8;
            this.portNameLabel.Text = "Unknown";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(93, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 80);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 131);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(1, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 1);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(270, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 130);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 1);
            this.panel5.TabIndex = 17;
            // 
            // PortOpenFailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(271, 131);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stopBitsLabel);
            this.Controls.Add(this.dataBitsLabel);
            this.Controls.Add(this.parityLabel);
            this.Controls.Add(this.baudRateLabel);
            this.Controls.Add(this.portNameLabel);
            this.Controls.Add(this.stopBitsLabelTag);
            this.Controls.Add(this.dataBitsLabelTag);
            this.Controls.Add(this.parityLabelTag);
            this.Controls.Add(this.baudRateLabelTag);
            this.Controls.Add(this.portNameLabelTag);
            this.Controls.Add(this.warnPicBox);
            this.Controls.Add(this.btIgnore);
            this.Controls.Add(this.btCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PortOpenFailDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PortOpenFailDialog";
            this.Load += new System.EventHandler(this.PortOpenFailDialog_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.warnPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btIgnore;
        private System.Windows.Forms.PictureBox warnPicBox;
        private System.Windows.Forms.Label portNameLabelTag;
        private System.Windows.Forms.Label baudRateLabelTag;
        private System.Windows.Forms.Label parityLabelTag;
        private System.Windows.Forms.Label dataBitsLabelTag;
        private System.Windows.Forms.Label stopBitsLabelTag;
        private System.Windows.Forms.Label stopBitsLabel;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Label portNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}