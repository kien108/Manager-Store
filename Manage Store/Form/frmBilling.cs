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
    public partial class frmBilling : Form
    {
        public frmBilling()
        {
            InitializeComponent();
        }
        private void frmBilling_Load(object sender, EventArgs e)
        {
            LoadForm(this.Width - 50);
        }

        private void LoadForm(int childForm_width)
        {
            dgBill.Width = childForm_width;
            dgBill.Height = this.Height + 160;
            dgBill.Location = new Point(23, pnBillHeading.Height - 20);

            pnBillHeading.Width = dgBill.Width;
            pnBillHeading.Height = (int)(this.Height * 0.2);
        }
    }
}
