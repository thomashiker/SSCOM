using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace PortSettingContextMenu
{
    public partial class PortSettingMenu : PopedCotainer
    {
        private PortSettingContainer parent_container = null;
        SerialPort port = new SerialPort();
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

        void UpdatePortList()
        {
            string[] ports = SerialPort.GetPortNames();
            cbPortList.Items.Clear();
            cbPortList.Items.AddRange(ports);
            cbPortList.SelectedIndex = 0;
        }

        public PortSettingMenu()
        {
            InitializeComponent();
            UpdatePortList();
        }

        public SerialPort GetSerialPort()
        {
            return port;
        }

        public PortSettingMenu(PortSettingContainer container)
        {
            parent_container = container;
            InitializeComponent();
            UpdatePortList();

            /*default*/
            cbBaudRateList.Text = "115200";
            cbDataBitsList.Text = "8";
            cbStopBitsList.Text = "1";
            cbParityList.SelectedIndex = 0;
            cbFlowCtrlList.SelectedIndex = 0;
        }

        private void btReloadPort_Click(object sender, EventArgs e)
        {
            UpdatePortList();
        }

        void PortSettingListToSerialPort()
        {
            port.PortName = cbPortList.Text;
            port.BaudRate = int.Parse(cbBaudRateList.Text);
            port.DataBits = int.Parse(cbDataBitsList.Text);
            switch (cbStopBitsList.Text)
            {
                case "0":
                    port.StopBits = StopBits.None;
                    break;
                case "1":
                    port.StopBits = StopBits.One;
                    break;
                case "2":
                    port.StopBits = StopBits.Two;
                    break;
                case "1.5":
                    port.StopBits = StopBits.OnePointFive;
                    break;
            }
            switch (cbParityList.Text)
            {
                case "None":
                    port.Parity = Parity.None;
                    break;
                case "Odd":
                    port.Parity = Parity.Odd;
                    break;
                case "Even":
                    port.Parity = Parity.Even;
                    break;
                case "Mark":
                    port.Parity = Parity.Mark;
                    break;
                case "Space":
                    port.Parity = Parity.Space;
                    break;
            }
            //port.cbFlowCtrlList.Text;
        }
        private void btOpen_Click(object sender, EventArgs e)
        {
            //this.Parent.Hide();
            PortSettingListToSerialPort();
            
            if (null != parent_container)
            {
                parent_container.Close();
            }
        }

        string PortSettingToString()
        {
            string list;

            list = cbPortList.Text + ","
                   + cbBaudRateList.Text + ","
                   + cbDataBitsList.Text + ","
                   + cbStopBitsList.Text + ","
                   + cbParityList.Text + ","
                   + cbFlowCtrlList.Text;

            return list;
        }

        int SetPortSettingList(int index, string str)
        {
            int number;
        
            switch (index)
            {
                case 0:
                    if (cbPortList.Items.Contains(str))
                    {
                        cbPortList.Text = str;
                    }
                    else
                    {
                        return -1;
                    }
                    break;
                case 1:
                    if (Int32.TryParse(str, out number))
                    {
                        if (number > 0)
                        {
                            cbBaudRateList.Text = str;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else
                    {
                        return -1;
                    }
                    break;
                case 2:
                    if (cbDataBitsList.Items.Contains(str))
                    {
                        cbDataBitsList.Text = str;
                    }
                    else
                    {
                        cbDataBitsList.Text = null;
                        return -1;
                    }
                    break;
                case 3:
                    if (cbStopBitsList.Items.Contains(str))
                    {
                        cbStopBitsList.Text = str;
                    }
                    else
                    {
                        cbStopBitsList.Text = null;
                        return -1;
                    }
                    break;
                case 4:
                    if (cbParityList.Items.Contains(str))
                    {
                        cbParityList.Text = str;
                    }
                    else
                    {
                        cbParityList.Text = null;
                        return -1;
                    }
                    break;
                case 5:
                    if (cbFlowCtrlList.Items.Contains(str))
                    {
                        cbFlowCtrlList.Text = str;
                    }
                    else
                    {
                        cbFlowCtrlList.Text = null;
                        return -1;
                    }
                    break;
                default:
                    return -1;
            }

            return 0;
        }
        int StringToPortSetting()
        {
            string str;
            int index;
            int ret = 0;
        
            if (null == lbPortFavourate.SelectedItem)
            {
                return 0;
            }
            str = lbPortFavourate.SelectedItem.ToString();

            string[] sArray = str.Split(',');

            if (sArray.Length != 6)
            {
                lbPortFavourate.SelectedItem = "fail:" + str;
                return -1;
            }
            
            for (index = 0; index < 6; index++)
            {
                ret += SetPortSettingList(index, sArray[index]);
            }

            return ret;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int index = lbPortFavourate.SelectedIndex;
            lbPortFavourate.Items.Remove(lbPortFavourate.SelectedItem);
            if (index < lbPortFavourate.Items.Count)
            {
                lbPortFavourate.SelectedIndex = index;
            }
            else
            {
                index -= 1;
                if (index < lbPortFavourate.Items.Count && index >= 0)
                {
                    lbPortFavourate.SelectedIndex = index;
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string setting = PortSettingToString();
            if (!lbPortFavourate.Items.Contains(setting))
            {
                lbPortFavourate.Items.Insert(lbPortFavourate.Items.Count,setting);
            }
        }

        private void lbPortFavourate_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringToPortSetting();
        }
    }
}
