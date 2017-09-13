namespace TextListContextMenu
{
    partial class TextListContextMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextListContextMenu));
            this.btClear = new System.Windows.Forms.Button();
            this.lbTextList = new System.Windows.Forms.ListBox();
            this.btDownload = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btUpload = new System.Windows.Forms.Button();
            this.btCopy = new System.Windows.Forms.Button();
            this.btCopyAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClear
            // 
            this.btClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.btClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClear.Image = ((System.Drawing.Image)(resources.GetObject("btClear.Image")));
            this.btClear.Location = new System.Drawing.Point(360, 124);
            this.btClear.Margin = new System.Windows.Forms.Padding(0);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(21, 21);
            this.btClear.TabIndex = 0;
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // lbTextList
            // 
            this.lbTextList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTextList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTextList.FormattingEnabled = true;
            this.lbTextList.HorizontalScrollbar = true;
            this.lbTextList.ItemHeight = 12;
            this.lbTextList.Location = new System.Drawing.Point(0, 1);
            this.lbTextList.Name = "lbTextList";
            this.lbTextList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTextList.Size = new System.Drawing.Size(388, 120);
            this.lbTextList.TabIndex = 45;
            this.lbTextList.SelectedValueChanged += new System.EventHandler(this.lbTextList_SelectedValueChanged);
            // 
            // btDownload
            // 
            this.btDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.btDownload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btDownload.FlatAppearance.BorderSize = 0;
            this.btDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDownload.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDownload.Image = ((System.Drawing.Image)(resources.GetObject("btDownload.Image")));
            this.btDownload.Location = new System.Drawing.Point(264, 124);
            this.btDownload.Margin = new System.Windows.Forms.Padding(0);
            this.btDownload.Name = "btDownload";
            this.btDownload.Size = new System.Drawing.Size(21, 21);
            this.btDownload.TabIndex = 46;
            this.btDownload.UseVisualStyleBackColor = false;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.btDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btDelete.FlatAppearance.BorderSize = 0;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.Location = new System.Drawing.Point(336, 124);
            this.btDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(21, 21);
            this.btDelete.TabIndex = 47;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.panel5.Controls.Add(this.btUpload);
            this.panel5.Controls.Add(this.btDownload);
            this.panel5.Controls.Add(this.btDelete);
            this.panel5.Controls.Add(this.btCopy);
            this.panel5.Controls.Add(this.btCopyAll);
            this.panel5.Controls.Add(this.btClear);
            this.panel5.Controls.Add(this.lbTextList);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 148);
            this.panel5.TabIndex = 50;
            // 
            // btUpload
            // 
            this.btUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.btUpload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btUpload.FlatAppearance.BorderSize = 0;
            this.btUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpload.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btUpload.Image = ((System.Drawing.Image)(resources.GetObject("btUpload.Image")));
            this.btUpload.Location = new System.Drawing.Point(240, 124);
            this.btUpload.Margin = new System.Windows.Forms.Padding(0);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(21, 21);
            this.btUpload.TabIndex = 49;
            this.btUpload.UseVisualStyleBackColor = false;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // btCopy
            // 
            this.btCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.btCopy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCopy.FlatAppearance.BorderSize = 0;
            this.btCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCopy.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCopy.Image = ((System.Drawing.Image)(resources.GetObject("btCopy.Image")));
            this.btCopy.Location = new System.Drawing.Point(288, 124);
            this.btCopy.Margin = new System.Windows.Forms.Padding(0);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(21, 21);
            this.btCopy.TabIndex = 48;
            this.btCopy.UseVisualStyleBackColor = false;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // btCopyAll
            // 
            this.btCopyAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCopyAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.btCopyAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCopyAll.FlatAppearance.BorderSize = 0;
            this.btCopyAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCopyAll.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCopyAll.Image = ((System.Drawing.Image)(resources.GetObject("btCopyAll.Image")));
            this.btCopyAll.Location = new System.Drawing.Point(312, 124);
            this.btCopyAll.Margin = new System.Windows.Forms.Padding(0);
            this.btCopyAll.Name = "btCopyAll";
            this.btCopyAll.Size = new System.Drawing.Size(21, 21);
            this.btCopyAll.TabIndex = 47;
            this.btCopyAll.UseVisualStyleBackColor = false;
            this.btCopyAll.Click += new System.EventHandler(this.btCopyAll_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 1);
            this.panel1.TabIndex = 46;
            // 
            // TextListContextMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.panel5);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TextListContextMenu";
            this.Size = new System.Drawing.Size(388, 148);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ListBox lbTextList;
        private System.Windows.Forms.Button btDownload;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.Button btCopyAll;
        private System.Windows.Forms.Button btUpload;
    }
}
