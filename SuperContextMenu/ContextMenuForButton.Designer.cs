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
            this.labelUnit = new System.Windows.Forms.Label();
            this.btCheck = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDown
            // 
            this.numUpDown.AccessibleDescription = "";
            this.numUpDown.BackColor = System.Drawing.Color.White;
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
            this.numUpDown.Size = new System.Drawing.Size(70, 21);
            this.numUpDown.TabIndex = 2;
            this.numUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown.Value = new decimal(new int[] {
            1000,
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
            this.panel1.Size = new System.Drawing.Size(100, 1);
            this.panel1.TabIndex = 3;
            // 
            // labelUnit
            // 
            this.labelUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUnit.Location = new System.Drawing.Point(5, 30);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(47, 12);
            this.labelUnit.TabIndex = 5;
            this.labelUnit.Text = "Unit:ms";
            this.labelUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btCheck
            // 
            this.btCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCheck.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheck.Image = global::SuperContextMenu.Properties.Resources.enter;
            this.btCheck.Location = new System.Drawing.Point(76, 7);
            this.btCheck.Margin = new System.Windows.Forms.Padding(0);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(21, 21);
            this.btCheck.TabIndex = 0;
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 44);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(99, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 44);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(98, 1);
            this.panel4.TabIndex = 8;
            // 
            // ContextMenuForButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.btCheck);
            this.Name = "ContextMenuForButton";
            this.Size = new System.Drawing.Size(100, 45);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
