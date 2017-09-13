namespace FastColoredTextBoxNS
{
    partial class FindForm
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
            this.findComboBox = new System.Windows.Forms.ComboBox();
            this.btWholeWord = new System.Windows.Forms.Button();
            this.btMatchCase = new System.Windows.Forms.Button();
            this.btFindNext = new System.Windows.Forms.Button();
            this.btFindPrevious = new System.Windows.Forms.Button();
            this.btBookMarkAll = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findComboBox
            // 
            this.findComboBox.FormattingEnabled = true;
            this.findComboBox.Location = new System.Drawing.Point(6, 5);
            this.findComboBox.Name = "findComboBox";
            this.findComboBox.Size = new System.Drawing.Size(170, 20);
            this.findComboBox.TabIndex = 9;
            this.findComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.findComboBox_KeyDown);
            // 
            // btWholeWord
            // 
            this.btWholeWord.FlatAppearance.BorderSize = 0;
            this.btWholeWord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btWholeWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWholeWord.Image = global::FastColoredTextBoxNS.Properties.Resources.match_height_16px;
            this.btWholeWord.Location = new System.Drawing.Point(32, 30);
            this.btWholeWord.Margin = new System.Windows.Forms.Padding(0);
            this.btWholeWord.Name = "btWholeWord";
            this.btWholeWord.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btWholeWord.Size = new System.Drawing.Size(16, 16);
            this.btWholeWord.TabIndex = 16;
            this.btWholeWord.UseVisualStyleBackColor = true;
            this.btWholeWord.Click += new System.EventHandler(this.btWholeWord_Click);
            // 
            // btMatchCase
            // 
            this.btMatchCase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMatchCase.FlatAppearance.BorderSize = 0;
            this.btMatchCase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btMatchCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMatchCase.Image = global::FastColoredTextBoxNS.Properties.Resources.book_alt_4;
            this.btMatchCase.Location = new System.Drawing.Point(8, 30);
            this.btMatchCase.Name = "btMatchCase";
            this.btMatchCase.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btMatchCase.Size = new System.Drawing.Size(16, 16);
            this.btMatchCase.TabIndex = 15;
            this.btMatchCase.UseVisualStyleBackColor = true;
            this.btMatchCase.Click += new System.EventHandler(this.btMatchCase_Click);
            // 
            // btFindNext
            // 
            this.btFindNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFindNext.FlatAppearance.BorderSize = 0;
            this.btFindNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindNext.Image = global::FastColoredTextBoxNS.Properties.Resources.arrow_7_right;
            this.btFindNext.Location = new System.Drawing.Point(128, 30);
            this.btFindNext.Name = "btFindNext";
            this.btFindNext.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btFindNext.Size = new System.Drawing.Size(16, 16);
            this.btFindNext.TabIndex = 13;
            this.btFindNext.UseVisualStyleBackColor = true;
            this.btFindNext.Click += new System.EventHandler(this.btFindNext_Click);
            // 
            // btFindPrevious
            // 
            this.btFindPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFindPrevious.FlatAppearance.BorderSize = 0;
            this.btFindPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btFindPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindPrevious.Image = global::FastColoredTextBoxNS.Properties.Resources.arrow_7_left;
            this.btFindPrevious.Location = new System.Drawing.Point(104, 30);
            this.btFindPrevious.Name = "btFindPrevious";
            this.btFindPrevious.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btFindPrevious.Size = new System.Drawing.Size(16, 16);
            this.btFindPrevious.TabIndex = 7;
            this.btFindPrevious.UseVisualStyleBackColor = true;
            this.btFindPrevious.Click += new System.EventHandler(this.btFindPrevious_Click);
            // 
            // btBookMarkAll
            // 
            this.btBookMarkAll.FlatAppearance.BorderSize = 0;
            this.btBookMarkAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btBookMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBookMarkAll.Image = global::FastColoredTextBoxNS.Properties.Resources.bookmark_alt;
            this.btBookMarkAll.Location = new System.Drawing.Point(56, 30);
            this.btBookMarkAll.Name = "btBookMarkAll";
            this.btBookMarkAll.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btBookMarkAll.Size = new System.Drawing.Size(16, 16);
            this.btBookMarkAll.TabIndex = 6;
            this.btBookMarkAll.UseVisualStyleBackColor = true;
            this.btBookMarkAll.Click += new System.EventHandler(this.btBookMarkAll_Click);
            // 
            // btClear
            // 
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Image = global::FastColoredTextBoxNS.Properties.Resources.eraser;
            this.btClear.Location = new System.Drawing.Point(80, 30);
            this.btClear.Name = "btClear";
            this.btClear.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btClear.Size = new System.Drawing.Size(16, 16);
            this.btClear.TabIndex = 5;
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btClose
            // 
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::FastColoredTextBoxNS.Properties.Resources.cancel;
            this.btClose.Location = new System.Drawing.Point(158, 30);
            this.btClose.Name = "btClose";
            this.btClose.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btClose.Size = new System.Drawing.Size(16, 16);
            this.btClose.TabIndex = 18;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(182, 51);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btWholeWord);
            this.Controls.Add(this.btMatchCase);
            this.Controls.Add(this.btFindNext);
            this.Controls.Add(this.findComboBox);
            this.Controls.Add(this.btFindPrevious);
            this.Controls.Add(this.btBookMarkAll);
            this.Controls.Add(this.btClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindForm";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Find";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btBookMarkAll;
        private System.Windows.Forms.Button btFindPrevious;
        private System.Windows.Forms.ComboBox findComboBox;
        private System.Windows.Forms.Button btFindNext;
        private System.Windows.Forms.Button btMatchCase;
        private System.Windows.Forms.Button btWholeWord;
        private System.Windows.Forms.Button btClose;
    }
}