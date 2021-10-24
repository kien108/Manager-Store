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
    public partial class frmEmployeeDetails : Form
    {
        public frmEmployeeDetails()
        {
            InitializeComponent();
        }

        private void frmEmployeeDetails_Load(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtBD.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            txtUsername.Enabled = false;
            txtPasword.Enabled = false;
            btnCancel.Visible = false;
            btnSave.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtBD.Enabled = true;
            txtPhone.Enabled = true;
            txtAddress.Enabled = true;
            txtUsername.Enabled = true;
            txtPasword.Enabled = true;
            btnDelete.Visible = false;
            btnCancel.Visible = true;
            btnSave.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtBD.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            txtUsername.Enabled = false;
            txtPasword.Enabled = false;
            btnDelete.Visible = true;
            btnCancel.Visible = false;
            btnSave.Visible = false;
        }
    }
}
