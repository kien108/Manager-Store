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
    public partial class GoodsCell : UserControl
    {
        private int quantityRemain;
        public GoodsCell(string url, string name, double price, int quantity)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            SetImage(url);
            SetName(name);
            SetPrice(price);
            quantityRemain = quantity;

            BackColor = Color.White;
            lbName.ForeColor = Color.Black;
            lbPrice.ForeColor = Color.Red;
            btnAddToCart.FillColor = root.homePrimaryColor;
            btnMinus.FillColor = root.homePrimaryColor;
            btnPlus.FillColor = root.homePrimaryColor;
            btnMinus.Enabled = false;
        }

        private void SetImage(string url)
        {
            if (url == null)
                url = root.ProjectPath() + root.imageGoods + "default.png";
            else
                url = root.ProjectPath() + url;
            pnImage.BackgroundImage = Image.FromFile(url);
        }

        private void SetName(string name)
        {
            lbName.Text = name;
        }

        private void SetPrice(double price)
        {
            string s = price.ToString();
            for (int i = s.Length - 3; i > 0; i -= 3)
                s = s.Insert(i, ".");
            lbPrice.Text = s + " đ";
        }

        private void pnImage_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, (sender as Panel).DisplayRectangle,
                Color.Transparent, 0, ButtonBorderStyle.Solid,
                Color.Transparent, 0, ButtonBorderStyle.Solid,
                Color.Transparent, 0, ButtonBorderStyle.Solid,
                Color.FromArgb(200, 200, 200), 2, ButtonBorderStyle.Solid);
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            string quantity = txtQuantity.Text;
            if (string.IsNullOrEmpty(quantity))
            {
                quantity = "0";
                txtQuantity.Text = "0";
            }
            int temp;
            if (!int.TryParse(quantity, out temp))
            {
                txtQuantity.Text = quantity.Remove(quantity.Length - 1);
                txtQuantity.Focus();
                txtQuantity.SelectionLength = 0;
                txtQuantity.SelectionStart = txtQuantity.Text.Length;
                return;
            }
            if (temp > quantityRemain)
            {
                temp = quantityRemain;
                txtQuantity.Text = temp.ToString();
            }
            if (temp == quantityRemain)
                btnPlus.Enabled = false;
            else
                btnPlus.Enabled = true;
            if (temp < 0)
            {
                temp = 0;
                txtQuantity.Text = "0";
            }
            if (temp == 0)
            {
                btnMinus.Enabled = false;
                BackColor = Color.White;
            }
            else
            {
                btnMinus.Enabled = true;
                BackColor = Color.FromArgb(255, 200, 200);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtQuantity.Text);
            txtQuantity.Text = (quantity + 1).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtQuantity.Text);
            txtQuantity.Text = (quantity - 1).ToString();
        }
    }
}
