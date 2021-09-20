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
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();
        }
        private void frmChart_Load(object sender, EventArgs e)
        {
            LoadForm(this.Width - 60);
        }
        private void LoadForm(int childForm_width)
        {
            dgEmployee.Width = childForm_width + 10;
            dgEmployee.Height = this.Height + 40;
            dgEmployee.Location = new Point(23, pnEmployeeHeading.Height + 60);

            pnEmployeeHeading.Width = dgEmployee.Width;
            pnEmployeeHeading.Height = (int)(this.Height * 0.33);
        }

       
    }
}
