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
    public partial class frmMainn : Form
    {
        public static Color primary_color = Color.FromArgb(39, 166, 137);
        public static Color default_color = Color.FromArgb(184, 184, 187);
        public frmMainn()
        {
            InitializeComponent();
        }
        private void frmMainn_Load(object sender, EventArgs e)
        {
            changeColor();
        }
        private void AllItemNav_MouseEnter(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton btn = (FontAwesome.Sharp.IconButton)sender;
            btn.ForeColor = Color.White;
            btn.IconColor = Color.White;
            btn.BackColor = primary_color;

        }
        private void AllItemNav_MouseLeave(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton btn = (FontAwesome.Sharp.IconButton)sender;
            btn.ForeColor = default_color;
            btn.IconColor = default_color;
            btn.BackColor = Color.FromArgb(248, 249, 253);
        }
        private void changeColor()
        {
            foreach (Control btn in pnNav.Controls)
            {
                if (btn is Button)
                {
                    btn.MouseEnter += new System.EventHandler(this.AllItemNav_MouseEnter);
                    btn.MouseLeave += new System.EventHandler(this.AllItemNav_MouseLeave);
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(this.pnNav.Width > 200)
            {
                label1.Text = "";
                pnNav.Width = 80;
                panel1.Location = new Point(90, -6);
                panel2.Location = new Point(90, 80);
                panel1.Width = 1300;
                panel2.Width = 1300;
                foreach (FontAwesome.Sharp.IconButton btn in pnNav.Controls.OfType<FontAwesome.Sharp.IconButton>())
                {
                    if(btn is FontAwesome.Sharp.IconButton)
                    {
                        btn.Text = "";
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                    }
                }
            }
            else
            {
                label1.Text = label1.Tag.ToString();
                pnNav.Width = 218;
                panel1.Location = new Point(230, -6);
                panel2.Location = new Point(230, 80);
                panel1.Width = 1154;
                panel2.Width = 1154;
                foreach (FontAwesome.Sharp.IconButton btn in pnNav.Controls.OfType<FontAwesome.Sharp.IconButton>())
                {
                    if (btn is FontAwesome.Sharp.IconButton)
                    {
                        btn.Text = btn.Tag.ToString();
                        btn.ImageAlign = ContentAlignment.MiddleLeft;
                    }
                }
            }
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.ForeColor = Color.White;
            btnMenu.IconColor = Color.White;
            btnMenu.BackColor = primary_color;
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.ForeColor = default_color;
            btnMenu.IconColor = default_color;
            btnMenu.BackColor = Color.FromArgb(248, 249, 253);
        }
    }
}
