using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperContextMenu
{
    public partial class ContextMenuForButton : PopedCotainer
    {
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

        private bool btChecked = true;
        public bool OkChecked
        {
            get { return btChecked; }
            set {
                btChecked = value;
                if (true == btChecked)
                {
                    btCheck.BackColor = System.Drawing.SystemColors.Highlight;
                }
                else
                {
                    btCheck.BackColor = System.Drawing.SystemColors.Control;
                }
                numUpDown.Enabled = !btChecked;
            }
        }

        public Decimal NumValue
        {
            get { return numUpDown.Value; }
            set
            {
                numUpDown.Value = value;
            }
        }
        //private System.Windows.Forms.Button btOk;
        //private System.Windows.Forms.Button btCancel;
        //private System.Windows.Forms.NumericUpDown numUpDown;
        //private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.Label labelMaxValue;
        //private System.Windows.Forms.Label labelUnit;

        public ContextMenuForButton()
        {
            InitializeComponent();
            OkChecked = true;
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            OkChecked = !OkChecked;
        }
    }
}
