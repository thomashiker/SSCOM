using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace TextListContextMenu
{
    public partial class TextListContextMenu : PopedCotainer
    {
        private TextListContainer parent_container = null;
        private TextBox textBox = null;

        //定义delegate
        public delegate void BtClickEventHandler(object sender, EventArgs e);

        //用event 关键字声明事件对象
        public event BtClickEventHandler BtOkClickEvent;
        public event BtClickEventHandler BtCancelClickEvent;

        //事件触发方法
        protected virtual void OnBtOkClickEvent(EventArgs e)
        {
            if (null != BtOkClickEvent)
                BtOkClickEvent(this, e);
        }

        protected virtual void OnBtCancelClickEvent(EventArgs e)
        {
            if (null != BtCancelClickEvent)
                BtCancelClickEvent(this, e);
        }

        public TextListContextMenu()
        {
            InitializeComponent();
        }

        public TextListContextMenu(TextListContainer container)
        {
            parent_container = container;
            InitializeComponent();
        }

        public TextBox MyTextBox
        {
            get
            {
                return textBox;
            }
            set
            {
                textBox = value;
            }
        }

        public ListBox MyListBox
        {
            get
            {
                return lbTextList;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int index;

            if (0 == lbTextList.Items.Count)
            {
                return;
            }

            index = lbTextList.SelectedIndex;

            if (index > 0)
            {
                if ((index + 1) == lbTextList.Items.Count)
                {
                    lbTextList.SelectedIndex = index - 1;
                }
                else
                {
                    lbTextList.SelectedIndex = index + 1;
                }
            }
            else
            {
                lbTextList.SelectedItem = null;
            }
            
            lbTextList.Items.RemoveAt(index);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            lbTextList.Items.Clear();
        }

        private void btCopyAll_Click(object sender, EventArgs e)
        {
            string str = null;
            foreach (object obj in lbTextList.Items)
            {
                str = str + obj.ToString() + "\r";
            }
            Clipboard.SetDataObject(str);
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            string str = null;
            foreach (object obj in lbTextList.SelectedItems)
            {
                str = str + obj.ToString() + "\r";
            }
            Clipboard.SetDataObject(str);
        }

        private void lbTextList_SelectedValueChanged(object sender, EventArgs e)
        {
            this.Invoke((EventHandler)(delegate
            {
                if (null != lbTextList.SelectedItem)
                {
                    textBox.Text = lbTextList.SelectedItem.ToString();
                }
            }));
        }

        private void btDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.DefaultExt = "txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //fctbRcv.SaveToFile(fileDialog.FileName, Encoding.GetEncoding("GB2312"));
                    StringBuilder sb = new StringBuilder();
                    //sb.AppendLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + " " + arg0);
                    foreach (object item in lbTextList.Items)
                    {
                        sb.AppendLine(item.ToString());
                    }
                    File.WriteAllText(fileDialog.FileName, sb.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt)|*.txt";
            ofd.InitialDirectory = Application.StartupPath;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8);

                string content = streamReader.ReadLine();
                while (content != null)
                {
                    if (content.Length > 0)
                        lbTextList.Items.Add(content);
                    content = streamReader.ReadLine();
                }
            }
        }
    }
}
