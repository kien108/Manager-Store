using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DefinedFramework
{
    public partial class PanelGoodsInCart : UserControl
    {
        public PanelGoodsInCart()
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            BackColor = root.screenColor;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.Image = global::Manage_Store.Properties.Resources.delete;
            btnDelete.FillColor = Color.DarkRed;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.Image = global::Manage_Store.Properties.Resources.delete_red;
            btnDelete.FillColor = Color.Transparent;
        }
    }
}
