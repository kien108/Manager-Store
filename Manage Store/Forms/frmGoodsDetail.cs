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
    public partial class frmGoodsDetail : Form
    {
        public frmGoodsDetail()
        {
            InitializeComponent();
        }

        private void frmGoodsDetail_Load(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtQuantity.Enabled = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtPrice.Enabled = true;
            txtQuantity.Enabled = true;
            btnDelete.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtQuantity.Enabled = false;
            btnDelete.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }
    }
}
