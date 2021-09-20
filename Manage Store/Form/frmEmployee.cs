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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        private void frmStaff_Load(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEmployee fAddStaff = new frmAddEmployee();
            fAddStaff.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEmployeeDetails fEmployeeDetail = new frmEmployeeDetails();
            fEmployeeDetail.Show();
        }
    }
}
