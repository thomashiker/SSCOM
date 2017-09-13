namespace FastColoredTextBoxNS
{
    partial class ReplaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceForm));
            this.tbFind = new System.Windows.Forms.TextBox();
            this.cbRegex = new System.Windows.Forms.CheckBox();
            this.cbMatchCase = new System.Windows.Forms.CheckBox();
            this.cbWholeWord = new System.Windows.Forms.CheckBox();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.btCollapse = new System.Windows.Forms.Button();
            this.toolImageList = new System.Windows.Forms.ImageList(this.components);
            this.btReplaceAll = new System.Windows.Forms.Button();
            this.btReplace = new System.Windows.Forms.Button();
            this.btFindNext = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFind
            // 
            this.tbFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFind.Location = new System.Drawing.Point(25, 8);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(153, 21);
            this.tbFind.TabIndex = 0;
            this.tbFind.TextChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            this.tbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFind_KeyPress);
            // 
            // cbRegex
            // 
            this.cbRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbRegex.AutoSize = true;
            this.cbRegex.Location = new System.Drawing.Point(130, 57);
            this.cbRegex.Name = "cbRegex";
            this.cbRegex.Size = new System.Drawing.Size(54, 16);
            this.cbRegex.TabIndex = 3;
            this.cbRegex.Text = "Regex";
            this.cbRegex.UseVisualStyleBackColor = true;
            this.cbRegex.CheckedChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            // 
            // cbMatchCase
            // 
            this.cbMatchCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMatchCase.AutoSize = true;
            this.cbMatchCase.Location = new System.Drawing.Point(25, 57);
            this.cbMatchCase.Name = "cbMatchCase";
            this.cbMatchCase.Size = new System.Drawing.Size(48, 16);
            this.cbMatchCase.TabIndex = 1;
            this.cbMatchCase.Text = "Case";
            this.cbMatchCase.UseVisualStyleBackColor = true;
            this.cbMatchCase.CheckedChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            // 
            // cbWholeWord
            // 
            this.cbWholeWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbWholeWord.AutoSize = true;
            this.cbWholeWord.Location = new System.Drawing.Point(73, 57);
            this.cbWholeWord.Name = "cbWholeWord";
            this.cbWholeWord.Size = new System.Drawing.Size(54, 16);
            this.cbWholeWord.TabIndex = 2;
            this.cbWholeWord.Text = "Whole";
            this.cbWholeWord.UseVisualStyleBackColor = true;
            this.cbWholeWord.CheckedChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            // 
            // tbReplace
            // 
            this.tbReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReplace.Location = new System.Drawing.Point(25, 31);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(153, 21);
            this.tbReplace.TabIndex = 0;
            this.tbReplace.Visible = false;
            this.tbReplace.TextChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            this.tbReplace.VisibleChanged += new System.EventHandler(this.tbReplace_VisibleChanged);
            this.tbReplace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFind_KeyPress);
            // 
            // btCollapse
            // 
            this.btCollapse.FlatAppearance.BorderSize = 0;
            this.btCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCollapse.ImageIndex = 3;
            this.btCollapse.ImageList = this.toolImageList;
            this.btCollapse.Location = new System.Drawing.Point(4, 11);
            this.btCollapse.Name = "btCollapse";
            this.btCollapse.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btCollapse.Size = new System.Drawing.Size(16, 16);
            this.btCollapse.TabIndex = 9;
            this.btCollapse.UseVisualStyleBackColor = true;
            this.btCollapse.Click += new System.EventHandler(this.btCollapse_Click);
            // 
            // toolImageList
            // 
            this.toolImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolImageList.ImageStream")));
            this.toolImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.toolImageList.Images.SetKeyName(0, "arrow-8-down.png");
            this.toolImageList.Images.SetKeyName(1, "arrow-8-left.png");
            this.toolImageList.Images.SetKeyName(2, "arrow-8-right.png");
            this.toolImageList.Images.SetKeyName(3, "arrow-8-up.png");
            // 
            // btReplaceAll
            // 
            this.btReplaceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReplaceAll.FlatAppearance.BorderSize = 0;
            this.btReplaceAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btReplaceAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReplaceAll.Image = global::FastColoredTextBoxNS.Properties.Resources.shapes_rotate_clockwise;
            this.btReplaceAll.Location = new System.Drawing.Point(204, 34);
            this.btReplaceAll.Margin = new System.Windows.Forms.Padding(0);
            this.btReplaceAll.Name = "btReplaceAll";
            this.btReplaceAll.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btReplaceAll.Size = new System.Drawing.Size(16, 16);
            this.btReplaceAll.TabIndex = 7;
            this.btReplaceAll.UseVisualStyleBackColor = true;
            this.btReplaceAll.Click += new System.EventHandler(this.btReplaceAll_Click);
            // 
            // btReplace
            // 
            this.btReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReplace.FlatAppearance.BorderSize = 0;
            this.btReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReplace.Image = global::FastColoredTextBoxNS.Properties.Resources.edit_replace_16px_20757_easyicon1;
            this.btReplace.Location = new System.Drawing.Point(181, 34);
            this.btReplace.Margin = new System.Windows.Forms.Padding(0);
            this.btReplace.Name = "btReplace";
            this.btReplace.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btReplace.Size = new System.Drawing.Size(16, 16);
            this.btReplace.TabIndex = 6;
            this.btReplace.UseVisualStyleBackColor = true;
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // btFindNext
            // 
            this.btFindNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFindNext.FlatAppearance.BorderSize = 0;
            this.btFindNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindNext.Image = global::FastColoredTextBoxNS.Properties.Resources.search_advanced;
            this.btFindNext.Location = new System.Drawing.Point(181, 11);
            this.btFindNext.Margin = new System.Windows.Forms.Padding(0);
            this.btFindNext.Name = "btFindNext";
            this.btFindNext.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btFindNext.Size = new System.Drawing.Size(16, 16);
            this.btFindNext.TabIndex = 5;
            this.btFindNext.UseVisualStyleBackColor = true;
            this.btFindNext.Click += new System.EventHandler(this.btFindNext_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::FastColoredTextBoxNS.Properties.Resources.cancel;
            this.btClose.Location = new System.Drawing.Point(204, 11);
            this.btClose.Name = "btClose";
            this.btClose.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btClose.Size = new System.Drawing.Size(16, 16);
            this.btClose.TabIndex = 8;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(227, 76);
            this.Controls.Add(this.btCollapse);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.btReplaceAll);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.cbWholeWord);
            this.Controls.Add(this.cbMatchCase);
            this.Controls.Add(this.cbRegex);
            this.Controls.Add(this.btFindNext);
            this.Controls.Add(this.btClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReplaceForm";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Find and replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReplaceForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btFindNext;
        private System.Windows.Forms.CheckBox cbRegex;
        private System.Windows.Forms.CheckBox cbMatchCase;
        private System.Windows.Forms.CheckBox cbWholeWord;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Button btReplaceAll;
        public System.Windows.Forms.TextBox tbFind;
        public System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.Button btCollapse;
        private System.Windows.Forms.ImageList toolImageList;
    }
}