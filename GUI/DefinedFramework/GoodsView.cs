using DTO;
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
    public partial class GoodsView : UserControl
    {
        public Goods g { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }
        public GoodsView(Goods g, int quantity, double price, bool isNew)
        {
            InitializeComponent();
            this.g = g;
            Quantity = quantity;
            Price = price;
            IsNew = isNew;
            Dock = DockStyle.Fill;
            lbQuantity.BackColor = Color.FromArgb(100, Color.Black);
            lbQuantity.ForeColor = Color.White;
            UpdateQuantity();
            BackColor = Color.White;
            BackgroundImage = Image.FromFile(root.ProjectPath() + root.imageGoods + g.Name.Replace(' ', '_') + ".png");
            BackgroundImageLayout = ImageLayout.Zoom;
            Name = g.Name;
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Add Item");
            cm.MenuItems.Add("Delete Item");
            ContextMenu = cm;
        }

        public void UpdateQuantity()
        {
            lbQuantity.Text = "x" + Quantity.ToString();
        }

        private void GoodsPreview_SizeChanged(object sender, EventArgs e)
        {
            lbQuantity.Height = (int)(0.3 * Height);
        }

        private void pnHover_MouseEnter(object sender, EventArgs e)
        {
            pnHover.BackColor = Color.FromArgb(50, Color.Black);
        }

        private void pnHover_MouseLeave(object sender, EventArgs e)
        {
            pnHover.BackColor = Color.Transparent;
        }

        private void pnHover_Click(object sender, EventArgs e)
        {
            Parent.Tag = this;
            Parent.Parent.Parent.Controls["pnItemNameList"].Controls["cbbItemsName"].Text = g.Name;
        }
    }
}
