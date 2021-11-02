using BLL;
using GUI.DefinedFramework;
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
    public partial class fHome : Form
    {
        private BLL_Goods bll = new BLL_Goods();
        private DataTable dt = null;
        private GoodsCell[] cells;
        public fHome()
        {
            InitializeComponent();
            tlpMain.ColumnStyles[1].Width = 0;
            btnBack.Hide();
            pnCart.Hide();

            BackColor = root.screenColor;
            tlpWrapper.BackColor = root.screenColor;
            btnRenew.FillColor = root.homePrimaryColor;
            btnBack.FillColor = root.homePrimaryColor;
            btnBack.FillColor = root.homePrimaryColor;
            btnCart.FillColor = root.homePrimaryColor;
            pnCartBody.FillColor = root.screenColor;
            pnCartFooter.FillColor = Color.Transparent;

            LoadGoods();
            CreateGoodsGrid();
        }

        private void fHome_Load(object sender, EventArgs e)
        {

        }

        private void LoadGoods()
        {
            string error = null;
            dt = bll.GetGoodsStillSelling(ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Can not load goods");
                return;
            }
        }

        private void CreateGoodsGrid()
        {
            int colCount = 6;
            int rowCount = dt.Rows.Count % colCount == 0 ? dt.Rows.Count / colCount : dt.Rows.Count / colCount + 1;
            tlpGoods.ColumnCount = colCount;
            tlpGoods.RowCount = rowCount;
            tlpGoods.Height = (int)((tlpGoods.Width / colCount) * (350.0 / 300.0) * rowCount);
            for (int i = 1; i < colCount; i++)
                tlpGoods.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
            for (int i = 1; i < rowCount; i++)
                tlpGoods.RowStyles.Add(new RowStyle(SizeType.Percent));
            foreach (ColumnStyle col in tlpGoods.ColumnStyles)
            {
                col.SizeType = SizeType.Percent;
                col.Width = 100 / colCount;
            }
            foreach (RowStyle row in tlpGoods.RowStyles)
            {
                row.SizeType = SizeType.Percent;
                row.Height = 100 / rowCount;

            }

            // Data
            cells = new GoodsCell[dt.Rows.Count];
            for (int i = 0; i < cells.Length; i++)
            {
                string url = dt.Rows[i]["gphoto"] == DBNull.Value ? null : (string)dt.Rows[i]["gphoto"];
                cells[i] = new GoodsCell(url,
                    (string)dt.Rows[i]["gname"],
                    (double)dt.Rows[i]["gprice"],
                    (int)dt.Rows[i]["gquantity"]);
                tlpGoods.Controls.Add(cells[i]);
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            tlpMain.ColumnStyles[0].Width = 0;
            tlpMain.ColumnStyles[1].Width = 100;
            btnRenew.Hide();
            btnCart.Hide();
            btnBack.Show();
            pnCart.Show();
        }

        private void tlpGoods_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnCartFooter_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, pnCartFooter.DisplayRectangle,
            //    Color.Red, 0, ButtonBorderStyle.Solid,
            //    Color.Red, 5, ButtonBorderStyle.Solid,
            //    Color.Red, 0, ButtonBorderStyle.Solid,
            //    Color.Red, 0, ButtonBorderStyle.Solid);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            tlpMain.ColumnStyles[1].Width = 0;
            tlpMain.ColumnStyles[0].Width = 100;
            btnBack.Hide();
            pnCart.Hide();
            btnRenew.Show();
            btnCart.Show();
        }
    }
}
