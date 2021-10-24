using BLL;
using GUI.DefinedFramework;
using Guna.UI2.WinForms;
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
    public partial class fGoods : Form
    {
        private BLL_Goods bll = new BLL_Goods();
        public fGoods()
        {
            InitializeComponent();
        }

        private void fGoods_Load(object sender, EventArgs e)
        {
            btnAll.PerformClick();
            btnDeleteSearch.Hide();
        }

        private void CustomDataGridViewGoods()
        {
            if (dgvGoods.Rows.Count == 0)
            {
                txtSearch.SelectAll();
                pnSearch.BorderColor = Color.FromArgb(240, 67, 80);
            }
            else
                pnSearch.BorderColor = root.primaryColor;
            dgvGoods.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            foreach (DataGridViewColumn col in dgvGoods.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font(new FontFamily("Poppins"), 12, FontStyle.Bold);
                col.HeaderCell.Style.ForeColor = Color.BlanchedAlmond;
            }
            dgvGoods.GridColor = Color.FromArgb(240, 240, 240);
            dgvGoods.DefaultCellStyle.ForeColor = Color.FromArgb(100, 60, 0);
            dgvGoods.DefaultCellStyle.SelectionForeColor = Color.FromArgb(100, 60, 0);
            dgvGoods.DefaultCellStyle.Font = new Font(new FontFamily("Roboto"), 12, FontStyle.Bold);
            dgvGoods.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvGoods.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGoods.Columns["Unit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGoods.Columns["Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGoods.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGoods.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvGoods.Columns["Profit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGoods.Columns["Profit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvGoods.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvGoods.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGoods.Columns["Selling"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvGoods.Columns["Selling"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGoods.Columns["URL Image"].Width = 300;

            foreach (DataRow row in ((DataTable)dgvGoods.DataSource).Rows)
            {
                row["Price"] = root.MoneyShow(row["Price"].ToString()) + " VND";
                row["Profit"] = root.MoneyShow(row["Profit"].ToString()) + " VND";
            }
        }

        private void btnSearch_Paint(object sender, PaintEventArgs e)
        {
            Panel searchIcon = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, searchIcon.DisplayRectangle,
                Color.Transparent, 0, ButtonBorderStyle.Solid,
                Color.Transparent, 0, ButtonBorderStyle.Solid,
                Color.FromArgb(200, 200, 200), 2, ButtonBorderStyle.Solid,
                Color.Transparent, 0, ButtonBorderStyle.Solid);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            string error = null;
            DataTable dt = bll.GetGoodTable(ref error);
            if (error != null)
            {
                MessageBox.Show(error);
                dgvGoods.DataSource = null;
                ChangeGoodsType(btnAll);
                return;
            }
            dgvGoods.DataSource = dt;
            CustomDataGridViewGoods();
            ChangeGoodsType(btnAll);
        }

        private void btnStocking_Click(object sender, EventArgs e)
        {
            string error = null;
            DataTable dt = bll.GetStokingGoodTable(ref error);
            if (error != null)
            {
                MessageBox.Show(error);
                dgvGoods.DataSource = null;
                ChangeGoodsType(btnStocking);
                return;
            }
            dgvGoods.DataSource = dt;
            CustomDataGridViewGoods();
            ChangeGoodsType(btnStocking);
        }

        private void btnSoldOut_Click(object sender, EventArgs e)
        {
            string error = null;
            DataTable dt = bll.GetSoldOutGoodTable(ref error);
            if (error != null)
            {
                MessageBox.Show(error);
                dgvGoods.DataSource = null;
                ChangeGoodsType(btnSoldOut);
                return;
            }
            dgvGoods.DataSource = dt;
            CustomDataGridViewGoods();
            ChangeGoodsType(btnSoldOut);
        }

        private void btnStopSelling_Click(object sender, EventArgs e)
        {
            string error = null;
            DataTable dt = bll.GetStopSellingGoodTable(ref error);
            if (error != null)
            {
                MessageBox.Show(error);
                dgvGoods.DataSource = null;
                ChangeGoodsType(btnStopSelling);
                return;
            }
            dgvGoods.DataSource = dt;
            CustomDataGridViewGoods();
            ChangeGoodsType(btnStopSelling);
        }

        private void ChangeGoodsType(object sender)
        {
            foreach (Guna2Button c in tlpGoodsType.Controls)
                c.FillColor = root.primaryColor;
            (sender as Guna2Button).FillColor = root.primaryColor2;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string text = txtSearch.Text, error = null;
            DataTable dt;
            string state = null;
            if (btnStocking.FillColor == root.primaryColor2)
                state = "STOCKING";
            else if (btnSoldOut.FillColor == root.primaryColor2)
                state = "SOLD OUT";
            else if (btnStopSelling.FillColor == root.primaryColor2)
                state = "STOP SELLING";
            if (root.IsNummerics(text))
                dt = bll.SearchGoods(Convert.ToInt32(text), state, ref error);
            else
                dt = bll.SearchGoods(text, state, ref error);
            if (error != null)
            {
                MessageBox.Show(error);
                dgvGoods.DataSource = null;
                return;
            }
            dgvGoods.DataSource = dt;
            CustomDataGridViewGoods();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
                btnDeleteSearch.Hide();
            else
            {
                pnSearch.BorderColor = root.primaryColor;
                btnDeleteSearch.Show();
            }
        }

        private void btnDeleteSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
            pnSearch.BorderColor = root.primaryColor;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSearch_Click(btnSearch, new EventArgs());
            }
        }
    }
}
