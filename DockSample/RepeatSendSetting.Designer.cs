namespace DockSample
{
    partial class RepeatSendSetting
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
            this.nudTimerPeriod = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // nudTimerPeriod
            // 
            this.nudTimerPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTimerPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTimerPeriod.Location = new System.Drawing.Point(0, 0);
            this.nudTimerPeriod.Name = "nudTimerPeriod";
            this.nudTimerPeriod.Size = new System.Drawing.Size(100, 21);
            this.nudTimerPeriod.TabIndex = 0;
            // 
            // RepeatSendSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(100, 22);
            this.Controls.Add(this.nudTimerPeriod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RepeatSendSetting";
            this.Text = "RepeatSendSetting";
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerPeriod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTimerPeriod;
    }
}