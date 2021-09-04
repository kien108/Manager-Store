using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Store
{
    public partial class frmMain : Form
    {
        public static Color primary_color = Color.FromArgb(39, 166, 137);
        public static Color default_color = Color.FromArgb(184, 184, 187);
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            changeColor();
        }
        private void AllItemNav_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.White;
            btn.BackColor = primary_color;
            
        }
        private void AllItemNav_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = default_color;
            btn.BackColor = Color.FromArgb(248, 249, 253);
        }
        private void changeColor()
        {
            foreach(Control btn in pnNav.Controls)
            {
                if(btn is Button)
                {
                    btn.MouseHover += new System.EventHandler(this.AllItemNav_MouseHover);
                    btn.MouseLeave += new System.EventHandler(this.AllItemNav_MouseLeave);
                }
            }
        }

    }
}
