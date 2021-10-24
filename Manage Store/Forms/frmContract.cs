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
    public partial class frmContract : Form
    {
        public frmContract()
        {
            InitializeComponent();
        }

        private void Contract_Load(object sender, EventArgs e)
        {
            LoadForm(this.Width - 60);
        }
        private void LoadForm(int childForm_width)
        {
            dgContract.Width = childForm_width + 10;
            dgContract.Height = this.Height + 40;
            dgContract.Location = new Point(23, pnContractHeading.Height + 60);

            pnContractHeading.Width = dgContract.Width;
            pnContractHeading.Height = (int)(this.Height * 0.33);
        }
    }
}
