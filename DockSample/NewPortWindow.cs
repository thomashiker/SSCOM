using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Collections;
using System.Xml;
using System.Runtime.InteropServices;


namespace DockSample
{
    public partial class NewPortWindow : Form
    {
        private const string PORT     = "port";
        private const string BAUDRATE = "baudrate";
        private const string DATABITS = "databits";
        private const string STOPBITS = "stopbits";
        private const string PARITY   = "parity";
        private const string FLOW     = "flow";

        private String configFile = "ini.xml";

        public NewPortWindow()
        {
            InitializeComponent();
            /*port list*/
            string[] ports = SerialPort.GetPortNames();
            portComboBox.Items.Clear();
            portComboBox.Items.AddRange(ports);
            
            ReadParseXml(configFile);
        }
        private void NewPortWindow_Load(object sender, EventArgs e)
        {
            //ReadParseXml(configFile);
        }

        public DialogResult ShowNewPortDialog(IWin32Window owner, string portName)
        {
            if (portComboBox.Items.Contains(portName))
            {
                portComboBox.SelectedItem = portName;
            }
            else
            {
                string[] ports = SerialPort.GetPortNames();
                if (Array.Exists<string>(ports, element => element == portName))
                {
                    portComboBox.Items.Clear();
                    portComboBox.Items.AddRange(ports);
                    portComboBox.SelectedText = portName;
                }
            }
            if (!this.Visible)
            {
                this.ShowDialog(owner);
            }
            this.Activate();

            return DialogResult.OK;
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        /// <summary>
        /// 为了是主界面能够移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private PortInfo getPortComboBoxInfo()
        {
            PortInfo info = new PortInfo();

            info.Port = portComboBox.Text;
            info.BaudRate = baudrateComboBox.Text;
            info.DataBits = databitsComboBox.Text;
            info.Stopbits = stopbitsComboBox.Text;
            info.Parity = parityComboBox.Text;
            info.Flow = flowComboBox.Text;

            return info;
        }

        private bool CheckPortInfo(PortInfo info)
        {
            if (!portComboBox.Items.Contains(info.Port))
            {
                return false;
            }
            if (!baudrateComboBox.Items.Contains(info.BaudRate))
            {
                //return false;
            }
            if (!databitsComboBox.Items.Contains(info.DataBits))
            {
                return false;
            }
            if (!stopbitsComboBox.Items.Contains(info.Stopbits))
            {
                return false;
            }
            if (!parityComboBox.Items.Contains(info.Parity))
            {
                return false;
            }
            if (!flowComboBox.Items.Contains(info.Flow))
            {
                return false;
            }

            return true;
        }

        private bool addPortInfoToComboBox(PortInfo info)
        {
            int index;
            bool flag = CheckPortInfo(info);

            if (flag)
            {
                index = portComboBox.FindString(info.Port);
                portComboBox.SelectedIndex = index;

                index = baudrateComboBox.FindString(info.BaudRate);
                baudrateComboBox.SelectedIndex = index;

                index = databitsComboBox.FindString(info.DataBits);
                databitsComboBox.SelectedIndex = index;

                index = stopbitsComboBox.FindString(info.Stopbits);
                stopbitsComboBox.SelectedIndex = index;

                index = parityComboBox.FindString(info.Parity);
                parityComboBox.SelectedIndex = index;

                index = flowComboBox.FindString(info.Flow);
                flowComboBox.SelectedIndex = index;
            }

            return flag;
        }

        private bool addPortInfoToListView(PortInfo info)
        {
            bool flag = CheckPortInfo(info);

            if (flag)
            {
                TreeNode root = null;
                TreeNode son = new TreeNode(string.Format("{0,20}", info.ToString()));
                bool exist = false;

                foreach (TreeNode node in portTreeView.Nodes)
                {
                    //MessageBox.Show(node.Text);
                    if (node.Text == info.Port)
                    {
                        root = node;
                    }
                }
                if (null == root)
                {
                    root = new TreeNode(info.Port);
                    portTreeView.Nodes.Add(root);
                    root.ImageIndex = 0;
                    //root.SelectedImageIndex = root.ImageIndex;//fixme
                    root.Nodes.Add(son);
                    //son.ForeColor = Color.Blue;
                    son.ImageIndex = 2;
                    portTreeView.SelectedNode = son;
                    portTreeView.Sort();
                }
                else
                {
                    foreach (TreeNode node in root.Nodes)
                    {
                        if (node.Text == info.ToString())
                        {
                            exist = true;
                            break;
                        }
                    }
                    if (!exist)
                    {
                        root.Nodes.Add(son);
                        //son.ForeColor = Color.Blue;
                        son.ImageIndex = 2;
                        portTreeView.SelectedNode = son;
                    }
                }
            }

            return flag;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            saveConfigToXml(configFile);
        }

        private void NewReceiveWindow()
        {
        }

        private void addSelectNodeToComboBox()
        {
            TreeNode node = portTreeView.SelectedNode;
            if (node.Parent == null)
            {
                return;
            }
            PortInfo info = new PortInfo();
            string[] port = node.Text.Split(',');
            info.Port = node.Parent.Text;
            info.BaudRate = port[0];
            info.DataBits = port[1];
            info.Stopbits = port[2];
            info.Parity   = port[3];
            info.Flow     = port[4];
            addPortInfoToComboBox(info);
            return;
        }

        private void removeTreeNode(TreeNode parent)
        {
            if (parent != null)
            {
                foreach (TreeNode node in parent.Nodes)
                {
                    removeTreeNode(node);
                }
                parent.Remove();
            }
        }

        private bool loadXmlNodeToListView(XmlNode xn)
        {
            if (xn == null)
            {
                return false;
            }
            XmlElement xe = (XmlElement)xn;
            PortInfo info = new PortInfo();

            info.Port = xe.GetAttribute("port").ToString();

            info.BaudRate = xe.GetAttribute("baudrate").ToString();

            info.DataBits = xe.GetAttribute("databits").ToString();
            
            info.Stopbits = xe.GetAttribute("stopbits").ToString();
            
            info.Parity = xe.GetAttribute("parity").ToString();
            
            info.Flow = xe.GetAttribute("flow").ToString();

            return addPortInfoToListView(info);
        }

        private bool loadXmlNodeToComboBox(XmlNode xn)
        {
            if (xn == null)
            {
                return false;
            }
            XmlElement xe = (XmlElement)xn;
            PortInfo info = new PortInfo();

            info.Port = xe.GetAttribute("port").ToString();

            info.BaudRate = xe.GetAttribute("baudrate").ToString();

            info.DataBits = xe.GetAttribute("databits").ToString();

            info.Stopbits = xe.GetAttribute("stopbits").ToString();

            info.Parity = xe.GetAttribute("parity").ToString();

            info.Flow = xe.GetAttribute("flow").ToString();

            return addPortInfoToComboBox(info);
        }

        private void ReadParseXml(string file)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释
            XmlReader reader = null;

            try
            {
                 reader = XmlReader.Create(file, settings);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                xmlDoc.Load(reader);
            }
            catch// (Exception ex)
            {
                //MessageBox.Show("xml" + ex.Message);
                reader.Close();
                return;
            }

            XmlNode root = xmlDoc.SelectSingleNode("config");
            if (root == null)
            {
                MessageBox.Show("null");
                reader.Close();
                return;
            }

            portTreeView.BeginUpdate();
            /*savedlist load*/
            XmlNodeList nodeList = null;
            if (root.SelectSingleNode("savedlist") != null)
            {
                nodeList = root.SelectSingleNode("savedlist").SelectNodes("com");
                foreach (XmlNode xn in nodeList)
                {
                    loadXmlNodeToListView(xn);
                }
            }
            portTreeView.EndUpdate();

            /*default load*/
            XmlNode defaultXmlNode = null;
            if (root.SelectSingleNode("default") != null)
            {
                defaultXmlNode = root.SelectSingleNode("default").FirstChild;
                loadXmlNodeToComboBox(defaultXmlNode);
                XmlElement xe = (XmlElement)defaultXmlNode;
                //MessageBox.Show(xe.GetAttribute("baudrate").ToString());
            }

 /*           portComboBox.SelectedIndex = 0;
            baudrateComboBox.SelectedIndex = 0;
            databitsComboBox.SelectedIndex = 0;
            stopbitsComboBox.SelectedIndex = 0;
            parityComboBox.SelectedIndex = 0;
            flowComboBox.SelectedIndex = 0;*/

            reader.Close();
        }

        private bool deleteSavedListFromXml(XmlNode savedRoot)
        {
            if (savedRoot != null)
            {
                savedRoot.RemoveAll();
                return true;
            }
            return false;
        }

        private bool saveDefaultConfigToXml(XmlDocument doc, XmlNode defaultRoot)
        {
            if (defaultRoot == null)
            {
                return false;
            }
            XmlElement xe = (XmlElement)defaultRoot.FirstChild;
            if (xe == null)
            {
                xe = doc.CreateElement("com");
            }
            PortInfo info = getPortComboBoxInfo();

            xe.SetAttribute(PORT, info.Port);
            xe.SetAttribute(BAUDRATE, info.BaudRate);
            xe.SetAttribute(DATABITS, info.DataBits);
            xe.SetAttribute(STOPBITS, info.Stopbits);
            xe.SetAttribute(PARITY, info.Parity);
            xe.SetAttribute(FLOW, info.Flow);
            defaultRoot.AppendChild(xe);

            return true;
        }

        private bool saveSavedListToXml(XmlDocument doc, XmlNode savedtRoot)
        {
            deleteSavedListFromXml(savedtRoot);

            foreach (TreeNode root in portTreeView.Nodes)
            {
                foreach (TreeNode node in root.Nodes)
                {
                    string[] info = node.Text.Trim().Split(',');
                    XmlElement xelKey = doc.CreateElement("com");
                    xelKey.SetAttribute(PORT, root.Text);
                    xelKey.SetAttribute(BAUDRATE, info[0]);
                    xelKey.SetAttribute(DATABITS, info[1]);
                    xelKey.SetAttribute(STOPBITS, info[2]);
                    xelKey.SetAttribute(PARITY, info[3]);
                    xelKey.SetAttribute(FLOW, info[4]);
                    savedtRoot.AppendChild(xelKey);
                }
            }
            
            return true;
        }

        private void saveConfigToXml(string file)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释
            XmlReader reader = null;
            XmlNode tmp = null;
            XmlNode root = null;

            try
            {
                reader = XmlReader.Create(file, settings);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                xmlDoc.Load(reader);
            }
            catch// (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //reader.Close();
                //return;
                root = xmlDoc.CreateElement("config");
                xmlDoc.AppendChild(root);
            }

            root = xmlDoc.SelectSingleNode("config");

            /*save savedlist*/
            tmp = root.SelectSingleNode("savedlist");
            if (tmp == null)
            {
                tmp = xmlDoc.CreateElement("savedlist");
                root.AppendChild(tmp);
            }
            saveSavedListToXml(xmlDoc, tmp);

            /*save default*/
            tmp = root.SelectSingleNode("default");
            if (tmp == null)
            {
                tmp = xmlDoc.CreateElement("default");
                root.PrependChild(tmp);
            }
            saveDefaultConfigToXml(xmlDoc, tmp);

            reader.Close();
            xmlDoc.Save(file);
        }

        private bool IsPortAvailable(SerialPort serialPort)
        {
            if (serialPort == null)
            {
                return false;
            }

            try {
                serialPort.Open();
            }
            catch {
                return false;
            }

            serialPort.Close();

            return true;
        }

        private bool IsPortAvailableWithName(string portName)
        {
            SerialPort serialPort = null;

            try {
                serialPort = new SerialPort(portComboBox.Text);
            }
            catch {
                return false;
            }

            return IsPortAvailable(serialPort);
        }

        private void portComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPortAvailableWithName(portComboBox.Text))
            {
                portOpenStatusLabel.Text = portComboBox.Text + " is available!";
                //portOpenStatusLabel.Image = stateFaceImageList.Images[0];
                portOpenStatusLabel.Image = stateFaceImageList.Images[0];
            }
            else
            {
                portOpenStatusLabel.Text = portComboBox.Text + " is unavailable!";
                //portOpenStatusLabel.Image = stateFaceImageList.Images[1];
                portOpenStatusLabel.Image = stateFaceImageList.Images[1];
            }
        }

        private void portTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            portTreeView_AfterSelect(null, null);

            NewReceiveWindow();

            this.Close();
        }

        private void portTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (portTreeView.SelectedNode != null)
            {
                portTreeView.SelectedNode.SelectedImageIndex = portTreeView.SelectedNode.ImageIndex;
            }
        }

        private void portTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node in portTreeView.Nodes)
            {
                //MessageBox.Show(portTreeView.SelectedNode.Text);
                if (portTreeView.SelectedNode.Parent != node)
                {
                    node.Collapse();
                }
            }

            //addSelectNodeToComboBox();

            portTreeView.SelectedNode.ExpandAll();

            if (portTreeView.SelectedNode.Parent != null)
            {
                portTreeView.SelectedNode.SelectedImageIndex = 3;// e.Node.ImageIndex;selected image
            }
            else
            {
                portTreeView.SelectedNode.SelectedImageIndex = portTreeView.SelectedNode.ImageIndex;// e.Node.ImageIndex;
            }
            if (check)
            {
                addSelectNodeToComboBox();
                check = false;
            }
        }

        private static bool check = false;
        private void portTreeView_MouseClick(object sender, MouseEventArgs e)
        {
            check = true;
        }

        private void btDelCfg_Click(object sender, EventArgs e)
        {
            removeTreeNode(portTreeView.SelectedNode);
        }

        private void btAddCfg_Click(object sender, EventArgs e)
        {
            PortInfo info = getPortComboBoxInfo();

            addPortInfoToListView(info);
        }

        private void btOpenPort_Click(object sender, EventArgs e)
        {
            NewReceiveWindow();

            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void baudrateComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !System.Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btEnableCustomBaud_Click(object sender, EventArgs e)
        {
            if (ComboBoxStyle.DropDown == baudrateComboBox.DropDownStyle)
            {
                baudrateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                btCustomBaud.Image = stateFaceImageList.Images[2];
            }
            else if (ComboBoxStyle.DropDownList == baudrateComboBox.DropDownStyle)
            {
                baudrateComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                btCustomBaud.Image = stateFaceImageList.Images[3];
            }
        }
    }
}
