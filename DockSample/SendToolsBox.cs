using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Threading;
using System.Collections;

namespace DockSample
{
    public partial class SendToolsBox : DockContent
    {
        private class SendSetting
        {
            private BackgroundWorker bgWorker = null;
            private TreeNode pTreeNode = null;
            private bool startEnabled = false;
            private bool shuffleEnabled = false;
            private bool loopEnabled = false;
            private SendToolsBox sTB = null;
            private int timerInterval = 1000;

            public int TimerInterval
            {
                set { timerInterval = value; }
                get { return timerInterval; }
            }

            public bool StartEnabled
            {
                set { startEnabled = value; }
                get { return startEnabled; }
            }

            public bool ShuffleEnabled
            {
                set { shuffleEnabled = value; }
                get { return shuffleEnabled; }
            }

            public bool LoopEnabled
            {
                set { loopEnabled = value; }
                get { return loopEnabled; }
            }

            public TreeNode PTreeNode
            {
                set { pTreeNode = value; }
                get { return pTreeNode; }
            }

            public SendSetting(SendToolsBox tb, TreeNode node)
            {
                bgWorker = new BackgroundWorker();

                /*bgWorker init*/
                bgWorker.WorkerSupportsCancellation = true;
                bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(MsgBGWorker_DoWork);
                bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(MsgBGWorker_RunWorkerCompleted);

                sTB = tb;
                PTreeNode = node;
            }

            private void SendTreeNodeText(TreeNode node)
            {
                //add here
                if (null != sTB)
                {
                    sTB.SendTreeNodeMessage(node);
                }
            }

            public bool GetTimerStartState()
            {
                return StartEnabled;
            }

            public void StartBGWorker()
            {
                bgWorker.RunWorkerAsync();
                StartEnabled = true;
            }

            public void CancelBGWorker()
            {
                bgWorker.CancelAsync();
                StartEnabled = false;
            }

            private void MsgBGWorker_DoWork(object sender, DoWorkEventArgs e)
            {
                BackgroundWorker myWork = sender as BackgroundWorker;
                int ms;

                if (null != PTreeNode)
                {
                    do
                    {
                        if (ShuffleEnabled)
                        {
                            int range = PTreeNode.Nodes.Count;
                            Hashtable hashtable = new Hashtable();
                            Random rm = new Random();
                            int RmNum = range;
                            int max = range + 1;
                            while (hashtable.Count < RmNum)
                            {
                                int nValue = rm.Next(max);
                                if (!hashtable.ContainsValue(nValue) && nValue != 0)
                                {
                                    hashtable.Add(nValue, nValue);

                                    SendTreeNodeText(PTreeNode.Nodes[nValue - 1]);

                                    ms = TimerInterval;
                                    while ((ms > 0) && !(myWork.CancellationPending))
                                    {
                                        Thread.Sleep(1);
                                        ms--;
                                    }

                                    if (myWork.CancellationPending)
                                    {
                                        e.Cancel = true;
                                        return;
                                        //break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (TreeNode node in PTreeNode.Nodes)
                            {
                                    SendTreeNodeText(node);

                                    ms = TimerInterval;
                                    while ((ms > 0) && !(myWork.CancellationPending))
                                    {
                                        Thread.Sleep(1);
                                        ms--;
                                    }

                                    if (myWork.CancellationPending)
                                    {
                                        e.Cancel = true;
                                        return;
                                        //break;
                                    }

                                    //Application.DoEvents();
                            }
                        }
                    } while (LoopEnabled);
                }

                e.Cancel = true;
            }

            private void MsgBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
            {
                if (e.Error != null)
                {
                    MessageBox.Show(e.Error.Message);
                }
                else if (e.Cancelled)
                {
                   // sendFromFilePgBar.Value = 0;
                    //sendFromFilePgBar.Visible = false;
                   // UploadFileButtonCheck = false;
                }
                else
                {
                    //
                    //sendFileProgressBar.Value = 100;
                    //sendFromFilePgBar.Value = 100;
                    //UploadFileButtonCheck = false;
                    //sendFromFilePgBar.Visible = false;
                }
            }
        }

        enum NODE_TYPE
        {
            NODE_ROOT_TYPE = 0,
            NODE_FAVORITE_TYPE,
            NODE_CMD_UNCHECKED_TYPE,
            NODE_CMD_CHECKED_TYPE,
            NODE_TYPE_MAX
        };

        private MainForm mainForm;

        public SendToolsBox(MainForm form)
        {
            mainForm = form;
            InitializeComponent();
        }

        protected override void OnRightToLeftLayoutChanged(EventArgs e)
        {
            treeViewFavorite.RightToLeftLayout = RightToLeftLayout;
        }

        private void SetToolsEnableState(bool state)
        {
            tsbtLoop.Enabled = state;
            tsbtShuffle.Enabled = state;
            tsbtTimer.Enabled = state;
            tstbTimerInterval.Visible = state;
        }

        private void UpdateCmdGroupNodeTimerState()
        {
            if (treeViewFavorite.SelectedNode.ImageIndex == (Int32)NODE_TYPE.NODE_FAVORITE_TYPE)
            {
                SendSetting st = (SendSetting)treeViewFavorite.SelectedNode.Tag;
                if (null != st)
                {
                    tstbTimerInterval.Text = st.TimerInterval.ToString();
                    tstbTimerInterval.Enabled = !st.GetTimerStartState();
                    tsbtTimer.Checked = st.GetTimerStartState();
                    
                    tsbtLoop.Checked = st.LoopEnabled;
                    tsbtShuffle.Checked = st.ShuffleEnabled;
                }
            }
        }

        private void SetCheckedState(TreeNode node, bool state)
        {
            if (null != node)
            {
                if (true == state)
                {
                    node.Checked = true;
                    node.ImageIndex = (Int32)NODE_TYPE.NODE_CMD_CHECKED_TYPE;
                }
                else
                {
                    node.Checked = false;
                    node.ImageIndex = (Int32)NODE_TYPE.NODE_CMD_UNCHECKED_TYPE;
                }

                node.SelectedImageIndex = treeViewFavorite.SelectedNode.ImageIndex;
            }
        }

        private TreeNode CreateCmdTreeNode(TreeNode pNode, int location)
        {
            TreeNode node = null;

            if (null != pNode)
            {
                node = new TreeNode("add cmd ...");
                node.ToolTipText = "Double Click To Send";
                SetCheckedState(node, false);
                pNode.Nodes.Insert(location, node);
            }

            return node;
        }

        private TreeNode CreateCmdGroupTreeNode(TreeNode pNode, int location)
        {
            TreeNode group = null;

            if (null != pNode)
            {
                group = new TreeNode("Group");
                SendSetting st = new SendSetting(this, group);

                group.ToolTipText = "Right Click To Send Selections";
                group.Tag = st;
                group.ImageIndex = (Int32)NODE_TYPE.NODE_FAVORITE_TYPE;
                group.SelectedImageIndex = group.ImageIndex;

                pNode.Nodes.Insert(location, group);
            }

            return group;
        }

        private void treeViewFavorite_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)//判断你点的是不是右键
            {
                Point ClickPoint = new Point(e.X, e.Y);

                TreeNode CurrentNode = treeViewFavorite.GetNodeAt(ClickPoint);

                if (CurrentNode != null)//判断你点的是不是一个节点
                {
                    switch (CurrentNode.ImageIndex)
                    {
                        case (Int32)NODE_TYPE.NODE_ROOT_TYPE:
                            CurrentNode.ContextMenuStrip = rootContextMenuStrip;
                            break;
                        case (Int32)NODE_TYPE.NODE_FAVORITE_TYPE:
                            CurrentNode.ContextMenuStrip = favoriteContextMenuStrip;
                            break;
                        case (Int32)NODE_TYPE.NODE_CMD_CHECKED_TYPE:
                        case (Int32)NODE_TYPE.NODE_CMD_UNCHECKED_TYPE:
                            CurrentNode.ContextMenuStrip = cmdContextMenuStrip;
                            break;
                        default:
                            break;
                    }

                    treeViewFavorite.SelectedNode = CurrentNode;//选中这个节点
                    //MessageBox.Show("treeView1_MouseDown");
                }
            }
        }

        private void addCommanderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode CurrentNode = null;

            if (null != treeViewFavorite.SelectedNode)
            {
                switch (treeViewFavorite.SelectedNode.ImageIndex)
                {
                    case (Int32)NODE_TYPE.NODE_ROOT_TYPE:
                        break;
                    case (Int32)NODE_TYPE.NODE_FAVORITE_TYPE:
                        //CurrentNode = AddTreeNode(treeViewFavorite.SelectedNode, NODE_TYPE.NODE_CMD_UNCHECKED_TYPE);
                        CurrentNode = CreateCmdTreeNode(treeViewFavorite.SelectedNode, treeViewFavorite.SelectedNode.Nodes.Count);

                        treeViewFavorite.SelectedNode = CurrentNode;
                        break;
                    case (Int32)NODE_TYPE.NODE_CMD_CHECKED_TYPE:
                    case (Int32)NODE_TYPE.NODE_CMD_UNCHECKED_TYPE:
                        break;
                    default:
                        break;
                }
            }

            //CurrentNode.BeginEdit();
            //treeViewFavorite.LabelEdit = true;
        }

        private void addFavoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode CurrentNode = null;

            if (null != treeViewFavorite.SelectedNode)
            {
                switch (treeViewFavorite.SelectedNode.ImageIndex)
                {
                    case (Int32)NODE_TYPE.NODE_ROOT_TYPE:
                        CurrentNode = CreateCmdGroupTreeNode(treeViewFavorite.SelectedNode, treeViewFavorite.SelectedNode.Nodes.Count + 1);
                        treeViewFavorite.SelectedNode = CurrentNode;
                        break;
                    case (Int32)NODE_TYPE.NODE_FAVORITE_TYPE:
                        if (null != treeViewFavorite.SelectedNode.Parent)
                        {
                            CurrentNode = CreateCmdGroupTreeNode(treeViewFavorite.SelectedNode.Parent, treeViewFavorite.SelectedNode.Index + 1);
                            treeViewFavorite.SelectedNode = CurrentNode;
                        }
                        break;
                    case (Int32)NODE_TYPE.NODE_CMD_CHECKED_TYPE:
                    case (Int32)NODE_TYPE.NODE_CMD_UNCHECKED_TYPE:
                        break;
                    default:
                        break;
                }
            }

            //CurrentNode.BeginEdit();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            if (null != treeViewFavorite.SelectedNode)
            {
                if (1 == treeViewFavorite.SelectedNode.Level)
                {
                    SendSetting st = (SendSetting)treeViewFavorite.SelectedNode.Tag;
                    if (null != st)
                    {
                        MessageBox.Show(st.TimerInterval.ToString());
                    }
                    else
                    {
                        MessageBox.Show("st is null");
                    }
                }
                else
                {
                    MessageBox.Show(treeViewFavorite.SelectedNode.Level.ToString());
                }
            }
            else
            {
                MessageBox.Show("null");
            }
        }

        private void addCmdFrontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode NewNode = null;

            if (null != treeViewFavorite.SelectedNode)
            {
                if (null != treeViewFavorite.SelectedNode.Parent)
                {
                    NewNode = CreateCmdTreeNode(treeViewFavorite.SelectedNode.Parent, treeViewFavorite.SelectedNode.Index);

                    treeViewFavorite.SelectedNode = NewNode;
                }
            }
        }

        private void addCmdBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode NewNode = null;

            if (null != treeViewFavorite.SelectedNode)
            {
                if (null != treeViewFavorite.SelectedNode.Parent)
                {
                    NewNode = CreateCmdTreeNode(treeViewFavorite.SelectedNode.Parent, treeViewFavorite.SelectedNode.Index + 1);

                    treeViewFavorite.SelectedNode = NewNode;
                }
            }
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewFavorite.SelectedNode.Remove();
        }

        private void checkedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCheckedState(treeViewFavorite.SelectedNode, true);
        }

        private void uncheckedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCheckedState(treeViewFavorite.SelectedNode, false);
        }

        private void treeViewFavorite_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewFavorite.SelectedNode != null)
            {
                treeViewFavorite.SelectedNode.SelectedImageIndex = treeViewFavorite.SelectedNode.ImageIndex;
            }

            if (treeViewFavorite.SelectedNode.ImageIndex == (Int32)NODE_TYPE.NODE_FAVORITE_TYPE)
            {
                SetToolsEnableState(true);
                UpdateCmdGroupNodeTimerState();
            }
            else
            {
                SetToolsEnableState(false);
                tsbtTimer.Checked = false;
            }
        }

        private void treeView1_MoveUp_Click(object sender, EventArgs e) //向上移动                    
        {
            TreeNode Node = treeViewFavorite.SelectedNode;
            TreeNode PrevNode = Node.PrevNode;
            if (PrevNode != null)
            {

                TreeNode NewNode = (TreeNode)Node.Clone();
                if (Node.Parent == null)
                {
                    treeViewFavorite.Nodes.Insert(PrevNode.Index, NewNode);
                }
                else
                {
                    Node.Parent.Nodes.Insert(PrevNode.Index, NewNode);
                }
                Node.Remove();
                treeViewFavorite.SelectedNode = NewNode;
            }
        }
        private void treeView1_MoveDown_Click(object sender, EventArgs e)//向下移动                   
        {
            TreeNode Node = treeViewFavorite.SelectedNode;
            TreeNode NextNode = Node.NextNode;
            if (NextNode != null)
            {

                TreeNode NewNode = (TreeNode)Node.Clone();
                if (Node.Parent == null)
                {
                    treeViewFavorite.Nodes.Insert(NextNode.Index + 1, NewNode);
                }
                else
                {
                    Node.Parent.Nodes.Insert(NextNode.Index + 1, NewNode);
                }
                Node.Remove();
                treeViewFavorite.SelectedNode = NewNode;
            }
        }

        //拖动代码                                                                            
        private void treeViewFavorite_ItemDrag(object sender, ItemDragEventArgs e)
        {//左键拖动
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }

        private void treeViewFavorite_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode"))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void treeViewFavorite_DragDrop(object sender, DragEventArgs e)//拖动              
        {
            //获得拖放中的节点                                                                
            TreeNode moveNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            //根据鼠标坐标确定要移动到的目标节点                                              
            Point pt;
            TreeNode targeNode;
            pt = ((TreeView)(sender)).PointToClient(new Point(e.X, e.Y));
            targeNode = this.treeViewFavorite.GetNodeAt(pt);

            //如果目标节点无子节点则添加为同级节点,反之添加到下级节点的未端                   
            TreeNode NewMoveNode = (TreeNode)moveNode.Clone();
            if (moveNode.Level == targeNode.Level)
            {
                //
                targeNode.Parent.Nodes.Insert(targeNode.Index, NewMoveNode);
            }
            else if (moveNode.Level > targeNode.Level)
            {
                //
                targeNode.Nodes.Insert(targeNode.Nodes.Count, NewMoveNode);
            }
            else
            {
                return;
            }

            //更新当前拖动的节点选择                                                          
            treeViewFavorite.SelectedNode = NewMoveNode;
            //展开目标节点,便于显示拖放效果                                                   
            targeNode.Expand();

            //移除拖放的节点                                                                  
            moveNode.Remove();
        }

        private void SendTreeNodeMessage(TreeNode tn)
        {
            StringBuilder sendMsgBuilder;

            if (null != tn)
            {
                sendMsgBuilder = new StringBuilder(tn.Text);
                sendMsgBuilder.Append("\n");

                if (null != mainForm)
                {
                    mainForm.SendMessage(sendMsgBuilder.ToString());
                }
            }
        }
        public void SendMessage(string str)
        {
            StringBuilder sendMsgBuilder;

            if (null != str)
            {
                sendMsgBuilder = new StringBuilder(str);
                sendMsgBuilder.Append("\n");

                if (null != mainForm)
                {
                    mainForm.SendMessage(sendMsgBuilder.ToString());
                }
            }
        }

        private void treeViewFavorite_DoubleClick(object sender, EventArgs e)
        {
            if (2 == treeViewFavorite.SelectedNode.Level)
            {
                SendTreeNodeMessage(treeViewFavorite.SelectedNode);
            }
        }

        private void editToolStrip_Click(object sender, EventArgs e)
        {
            treeViewFavorite.SelectedNode.BeginEdit();
        }

        private void sendCmdsToolStrip_Click(object sender, EventArgs e)
        {
            if (null != treeViewFavorite.SelectedNode)
            {
                foreach (TreeNode tn in treeViewFavorite.SelectedNode.Nodes)
                {
                    if (tn.Checked)
                    {
                        SendTreeNodeMessage(tn);
                    }
                }
            }
        }

        private void sendCmdToolStrip_Click(object sender, EventArgs e)
        {
            SendTreeNodeMessage(treeViewFavorite.SelectedNode);
        }

        private void favoriteContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (null != treeViewFavorite.SelectedNode)
            {
                if (1 == treeViewFavorite.SelectedNode.Level)
                {
                    tstbTimerInterval.Text = ((SendSetting)treeViewFavorite.SelectedNode.Tag).TimerInterval.ToString();
                }
            }
        }

        private void tsbtSend_Click(object sender, EventArgs e)
        {
            if (1 == treeViewFavorite.SelectedNode.Level)
            {
                foreach (TreeNode node in treeViewFavorite.SelectedNode.Nodes)
                {
                    SendTreeNodeMessage(node);
                    Thread.Sleep(1000);
                }
            }
        }

        private void tsbtLoop_Click(object sender, EventArgs e)
        {
            if (null != treeViewFavorite.SelectedNode && treeViewFavorite.SelectedNode.ImageIndex == (Int32)NODE_TYPE.NODE_FAVORITE_TYPE)
            {
                SendSetting st = (SendSetting)treeViewFavorite.SelectedNode.Tag;
                if (null != st)
                {
                    st.LoopEnabled = tsbtLoop.Checked;
                }
            }
        }

        private void tsbtShuffle_Click(object sender, EventArgs e)
        {
            if (null != treeViewFavorite.SelectedNode && treeViewFavorite.SelectedNode.ImageIndex == (Int32)NODE_TYPE.NODE_FAVORITE_TYPE)
            {
                SendSetting st = (SendSetting)treeViewFavorite.SelectedNode.Tag;
                if (null != st)
                {
                    st.ShuffleEnabled = tsbtShuffle.Checked;
                }
            }
        }

        private void tsbtTimer_Click(object sender, EventArgs e)
        {
            tstbTimerInterval.Enabled = !tsbtTimer.Checked;
            int time = -1;

            if (null != treeViewFavorite.SelectedNode && treeViewFavorite.SelectedNode.ImageIndex == (Int32)NODE_TYPE.NODE_FAVORITE_TYPE)
            {
                SendSetting st = (SendSetting)treeViewFavorite.SelectedNode.Tag;
                if (null != st)
                {
                    if (int.TryParse(tstbTimerInterval.Text, out time))
                    {
                        st.TimerInterval = time;
                    }

                    if (tsbtTimer.Checked)
                    {
                        //st.StartTimer();
                        st.StartBGWorker();
                    }
                    else
                    {
                        //st.StopTimer();
                        st.CancelBGWorker();
                    }
                }
            }

            if (null != treeViewFavorite.SelectedNode && 1 == treeViewFavorite.SelectedNode.Level)
            {
                SendSetting st = (SendSetting)treeViewFavorite.SelectedNode.Tag;
                if (null != st)
                {
                    if (int.TryParse(tstbTimerInterval.Text, out time))
                    {
                        st.TimerInterval = time;
                    }
                }
            }
        }

        private void checkAllToolStrip_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in treeViewFavorite.SelectedNode.Nodes)
            {
                SetCheckedState(node, true);
            }
        }

        private void unCheckAllToolStrip_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in treeViewFavorite.SelectedNode.Nodes)
            {
                SetCheckedState(node, false);
            }
        }

        private void tsbtReset_Click(object sender, EventArgs e)
        {
            //
            foreach (TreeNode root in treeViewFavorite.Nodes)
            {
                foreach (TreeNode node in root.Nodes)
                {
                    if (node.ImageIndex == (Int32)NODE_TYPE.NODE_FAVORITE_TYPE)
                    {
                        SendSetting st = (SendSetting)node.Tag;
                        if (null != st)
                        {
                            st.LoopEnabled = false;
                            st.ShuffleEnabled = false;
                            st.StartEnabled = false;
                        }
                    }
                }
            }
            tsbtLoop.Checked = false;
            tsbtShuffle.Checked = false;
            tsbtTimer.Checked = false;
            tsbtTimer.Enabled = true;
        }
    }
}