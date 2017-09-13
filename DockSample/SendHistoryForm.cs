using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DockSample
{
    public partial class SendHistoryForm : Form
    {
        public SendHistoryForm()
        {
            InitializeComponent();
        }

        private void SendHistoryForm_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void ShowForm(Point location)
        {
            this.Location = location;
            this.ShowDialog();
        }

        public void ShowForm(Control control)
        {
            int x, y;

            if (control == null)
                throw new ArgumentNullException("control");

            x = control.Location.X;
            y = control.Location.Y + control.Height + 1;
            if (null != control.Parent)
            {
                this.Location = control.Parent.PointToScreen(new Point(x, y));
            }
            else
            {
                this.Location = control.PointToScreen(new Point(x, y));
            }
            this.Width = control.Width;

            this.Show();
        }

        public ListBox listbox
        {
            get
            {
                return listBox;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            string str = null;
            foreach (object obj in listBox.SelectedItems)
            {
                str = str + obj.ToString() + "\r";
            }
            Clipboard.SetDataObject(str);
        }

        private void btCopyAll_Click(object sender, EventArgs e)
        {
            string str = null;
            foreach (object obj in listBox.Items)
            {
                str = str + obj.ToString() + "\r";
            }
            Clipboard.SetDataObject(str);
        }
    }
}
