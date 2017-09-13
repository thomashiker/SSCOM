using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace PortSettingContextMenu
{
    public partial class PortSettingContainer : ToolStripDropDown
    {
        private Control m_popedContainer;

        private ToolStripControlHost m_host;

        private bool m_fade = true;

        private PortSettingMenu contextMenu;//new PortSettingMenu();


        public PortSettingContainer()
        {
            contextMenu = new PortSettingMenu(this);
            InitializeComponent();

            if (contextMenu == null)
                throw new ArgumentNullException("content");

            this.m_popedContainer = contextMenu;

            this.m_fade = SystemInformation.IsMenuAnimationEnabled && SystemInformation.IsMenuFadeEnabled;

            this.m_host = new ToolStripControlHost(contextMenu);
            m_host.AutoSize = false;//make it take the same room as the poped control

            Padding = Margin = m_host.Padding = m_host.Margin = Padding.Empty;

            contextMenu.Location = Point.Empty;

            this.Items.Add(m_host);

            contextMenu.Disposed += delegate (object sender, EventArgs e)
            {
                contextMenu = null;
                Dispose(true);// this popup container will be disposed immediately after disposion of the contained control
            };
        }

        public SerialPort Port
        {
            get
            {
                return contextMenu.GetSerialPort();
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {//prevent alt from closing it and allow alt+menumonic to work
            if ((keyData & Keys.Alt) == Keys.Alt)
                return false;

            return base.ProcessDialogKey(keyData);
        }

        public void Show(Control control)
        {
            if (control == null)
                throw new ArgumentNullException("control");

            Show(control, control.ClientRectangle);
        }

        public void Show(Form f, Point p)
        {
            this.Show(f, new Rectangle(p, new Size(0, 0)));
        }

        private void Show(Control control, Rectangle area)
        {
            if (control == null)
                throw new ArgumentNullException("control");


            Point location = control.PointToScreen(new Point(area.Left, area.Top + area.Height));

            Rectangle screen = Screen.FromControl(control).WorkingArea;

            if (location.X + Size.Width > (screen.Left + screen.Width))
                location.X = (screen.Left + screen.Width) - Size.Width;

            if (location.Y + Size.Height > (screen.Top + screen.Height))
                location.Y -= Size.Height + area.Height;

            location = control.PointToClient(location);

            Show(control, location, ToolStripDropDownDirection.BelowRight);
        }

        private const int frames = 5;
        private const int totalduration = 100;
        private const int frameduration = totalduration / frames;

        protected override void SetVisibleCore(bool visible)
        {
            double opacity = Opacity;
            if (visible && m_fade) Opacity = 0;
            base.SetVisibleCore(visible);
            if (!visible || !m_fade) return;
            for (int i = 1; i <= frames; i++)
            {
                if (i > 1)
                {
                    System.Threading.Thread.Sleep(frameduration);
                }
                Opacity = opacity * (double)i / (double)frames;
            }
            Opacity = opacity;
        }

        protected override void OnOpening(CancelEventArgs e)
        {
            if (m_popedContainer.IsDisposed || m_popedContainer.Disposing)
            {
                e.Cancel = true;
                return;
            }
            base.OnOpening(e);
        }

        protected override void OnOpened(EventArgs e)
        {
            m_popedContainer.Focus();

            base.OnOpened(e);
        }
    }
}
