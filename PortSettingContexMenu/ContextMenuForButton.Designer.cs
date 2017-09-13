namespace SuperContextMenu
{
    partial class ContextMenuForButton
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
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMaxValue = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.btCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDown
            // 
            this.numUpDown.AccessibleDescription = "123456";
            this.numUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDown.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numUpDown.Location = new System.Drawing.Point(2, 7);
            this.numUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.numUpDown.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.numUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(104, 21);
            this.numUpDown.TabIndex = 2;
            this.numUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown.Value = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 3);
            this.panel1.TabIndex = 3;
            // 
            // labelMaxValue
            // 
            this.labelMaxValue.AutoSize = true;
            this.labelMaxValue.Location = new System.Drawing.Point(57, 34);
            this.labelMaxValue.Name = "labelMaxValue";
            this.labelMaxValue.Size = new System.Drawing.Size(71, 12);
            this.labelMaxValue.TabIndex = 4;
            this.labelMaxValue.Text = "Max:3600000";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUnit.Location = new System.Drawing.Point(5, 36);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(47, 12);
            this.labelUnit.TabIndex = 5;
            this.labelUnit.Text = "Unit:ms";
            this.labelUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btCheck
            // 
            this.btCheck.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheck.Image = global::SuperContextMenu.Properties.Resources.enter;
            this.btCheck.Location = new System.Drawing.Point(115, 7);
            this.btCheck.Margin = new System.Windows.Forms.Padding(0);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(21, 21);
            this.btCheck.TabIndex = 0;
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // ContextMenuForButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.labelMaxValue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.btCheck);
            this.Name = "ContextMenuForButton";
            this.Size = new System.Drawing.Size(140, 52);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMaxValue;
        private System.Windows.Forms.Label labelUnit;
    }
}
