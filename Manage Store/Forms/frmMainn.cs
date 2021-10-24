using GUI.DefinedFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMainn : Form
    {
        private Color primary_color = root.primaryColor;
        private Color default_color = root.defaultColor;

        private Form currentChildForm;
        private void OpenChildForm(Form childForm) // function to open child_form
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbHeader.Text = childForm.Text;
        }
        public frmMainn()
        {
            InitializeComponent();
        }
        private void frmMainn_Load(object sender, EventArgs e)
        {
            changeColor();
            loadForm(this.Width - pnNav.Width - 165, (int)(0.16 * this.Width));
        }

        private void loadForm(int panel2_width, int pnNav_width)
        {
            pnNav.Width = pnNav_width;
            pnHeader.Width = panel2_width - 50;
            pnHeader.Height = (int)(this.Height * 0.1);
            pnHeader.Location = new Point(pnNav.Width + 50, 0);

            panel2.Width = panel2_width;
            panel2.Height = this.Height - pnHeader.Height - 10;
            panel2.Location = new Point(pnNav.Width + 28, pnHeader.Height);

            panel10.Width = (int)(0.6 * panel2.Width);
            panel10.Height = panel2.Height - panel3.Height - 158;
            panel10.Location = new Point(21, panel3.Height + 100);

            label18.Location = new Point(panel10.Width / 2 - 170, 22);

            pictureBox10.Width = panel10.Width - 20;
            pictureBox10.Height = panel10.Height - 120;

            panel6.Width = panel2.Width - panel10.Width - 40;
            panel6.Height = panel2.Height;
            panel6.Location = new Point(panel10.Width + 40, 3);

            panel3.Width = (int)(0.32 * panel10.Width);
            panel3.Height = (int)(0.18 * panel2.Height);

            panel4.Width = panel3.Width;
            panel4.Height = panel3.Height;
            panel4.Location = new Point(panel3.Width + 41, 26);

            panel5.Width = panel3.Width;
            panel5.Height = panel3.Height;
            panel5.Location = new Point(panel4.Width * 2 + 62, 26);

            panel11.Width = panel6.Width - 40;
            panel11.Height = (int)(panel2.Height * 0.48);

            pictureBox9.Width = panel11.Width - 32;
            pictureBox9.Height = panel11.Height - 110;

            btnChangeWeek.Location = new Point(panel11.Width - label15.Width + 30, 15);

            panel7.Width = (int)(0.5 * panel6.Width - 30);
            panel7.Height = 150;
            panel7.Location = new Point(11, panel11.Height + 50);

            panel8.Width = panel7.Width;
            panel8.Height = panel7.Height;
            panel8.Location = new Point(panel7.Width + 30, panel11.Height + 50);
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
            btn.IconColor = Color.FromArgb(51, 51, 51);
            btn.BackColor = Color.FromArgb(238, 238, 238);
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
                panel2.Width = this.Width - pnNav.Width - 30;
                this.loadForm(panel2.Width, pnNav.Width);
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
                foreach (FontAwesome.Sharp.IconButton btn in pnNav.Controls.OfType<FontAwesome.Sharp.IconButton>())
                {
                    if (btn is FontAwesome.Sharp.IconButton)
                    {
                        btn.Text = btn.Tag.ToString();
                        btn.ImageAlign = ContentAlignment.MiddleLeft;
                    }
                }
                this.loadForm(this.Width - pnNav.Width - 250, (int)(0.156 * Width));
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
            btnMenu.BackColor = Color.FromArgb(238, 238, 238);
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGoods());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEmployee());
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBilling());
        }
        private void btnContract_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmContract());
        }
        private void btnChart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChart());
        }
  
        private void btnHome1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                lbHeader.Text = "Home";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                lbHeader.Text = "Home";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                lbHeader.Text = "Home";
            }

        }

        
    }
}
