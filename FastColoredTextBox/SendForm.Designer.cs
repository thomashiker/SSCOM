namespace FastColoredTextBoxNS
{
    partial class SendForm
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
            this.sendComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendComboBox
            // 
            this.sendComboBox.FormattingEnabled = true;
            this.sendComboBox.Location = new System.Drawing.Point(6, 24);
            this.sendComboBox.Name = "sendComboBox";
            this.sendComboBox.Size = new System.Drawing.Size(265, 20);
            this.sendComboBox.TabIndex = 9;
            this.sendComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.findComboBox_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 2);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchResultLabel);
            this.panel2.Controls.Add(this.btClose);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 18);
            this.panel2.TabIndex = 12;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FindForm_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FindForm_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FindForm_MouseUp);
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.ForeColor = System.Drawing.Color.Red;
            this.searchResultLabel.Location = new System.Drawing.Point(7, 3);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(0, 12);
            this.searchResultLabel.TabIndex = 12;
            this.searchResultLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FindForm_MouseDown);
            this.searchResultLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FindForm_MouseMove);
            this.searchResultLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FindForm_MouseUp);
            // 
            // btSend
            // 
            this.btSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSend.Location = new System.Drawing.Point(278, 23);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(52, 22);
            this.btSend.TabIndex = 5;
            this.btSend.Text = "&Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.BackgroundImage = global::FastColoredTextBoxNS.Properties.Resources.cancel;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btClose.Location = new System.Drawing.Point(319, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(16, 16);
            this.btClose.TabIndex = 11;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // SendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 108);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sendComboBox);
            this.Controls.Add(this.btSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Find";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FindForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FindForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FindForm_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.ComboBox sendComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label searchResultLabel;
    }
}