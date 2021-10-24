using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Store.DefinedFramework
{
    public partial class FunctionPanel : Guna2Panel
    {
        private IconPictureBox icon;
        public Label name;
        private AutoScaleMode _autoscaleMode = AutoScaleMode.Dpi;
        public AutoScaleMode AutoScaleMode
        {
            get { return _autoscaleMode; }
            set { _autoscaleMode = value; }
        }
        public FunctionPanel(IconChar icon, string name)
        {
            InitializeComponent();
            this.icon = new IconPictureBox();
            this.icon.IconChar = icon;
            this.name = new Label();
            this.name.Text = name;
            ParentChanged += new EventHandler(SetupUI);
        }

        private void SetupUI(object sender, EventArgs e)
        {   
            // this
            Margin = new Padding(5, 0, 5, 0);
            Size = new Size(Parent.Width - Margin.Left * 2, 80);
            BackColor = Color.White;
            Padding = new Padding(15, 15, 10, 15);
            Dock = DockStyle.Top;
            Padding = new Padding(22, 17, 20, 10);
            BackColor = Color.Transparent;
            MouseEnter += new EventHandler(MouseEnterPanel);
            MouseLeave += new EventHandler(MouseLeavePanel);
            Cursor = Cursors.Hand;

            // icon
            icon.IconColor = Color.Black;
            icon.Size = new Size(40, 40);
            icon.Padding = new Padding(0, 5, 5, 5);
            icon.Dock = DockStyle.Left;
            icon.IconColor = Color.BlanchedAlmond;
            icon.MouseEnter += new EventHandler(MouseEnterPanel);
            icon.MouseLeave += new EventHandler(MouseLeavePanel);

            // name
            name.AutoSize = true;
            name.ForeColor = Color.Black;
            name.Font = new Font(new FontFamily("Poppins Medium"), 14, FontStyle.Regular);
            name.Padding = new Padding(15, 3, 0, 0);
            name.Dock = DockStyle.Left;
            name.ForeColor = Color.BlanchedAlmond;
            name.MouseEnter += new EventHandler(MouseEnterPanel);
            name.MouseLeave += new EventHandler(MouseLeavePanel);

            Controls.Add(name);
            Controls.Add(icon);
        }

        private void MouseEnterPanel(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(41, 61, 50);
        }

        private void MouseLeavePanel(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }
    }
}
