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
    public partial class frmGoods : Form
    {
        public frmGoods()
        {
            InitializeComponent();
        }

        private void frmGoods_Load(object sender, EventArgs e)
        {
            loadForm(this.Width - 60);
        }
        private void loadForm(int childForm_width)
        {
            dgGoods.Width = childForm_width + 10;
            dgGoods.Height = this.Height + 40;
            dgGoods.Location = new Point(23, pnGoodsHeading.Height + 60);

            pnGoodsHeading.Width = dgGoods.Width;
            pnGoodsHeading.Height = (int)(this.Height * 0.33);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddGoods fAddGoods = new frmAddGoods();
            fAddGoods.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGoodsDetail frmGoodsDetail = new frmGoodsDetail();
            frmGoodsDetail.Show();
        }
    }
}
