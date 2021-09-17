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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
     
        }
        private void BorderColor(object sender, PaintEventArgs e)
        {
            Panel pn = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, pn.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Search...")
            {
                textBox1.Text = "";
                panel2.Paint += new PaintEventHandler(this.BorderColor);
                this.Refresh();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            panel2.BorderStyle = BorderStyle.None;
        }

       
    }
}
