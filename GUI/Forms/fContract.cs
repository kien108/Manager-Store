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
    public partial class fContract : Form
    {
        private BLL_Contract bll = new BLL_Contract();
        public fContract()
        {
            InitializeComponent();
            tlpWrapper.ColumnStyles[1].Width = 0;
            tlpMain.RowStyles[0].Height = 12;

            BackColor = root.screenColor;
            tlpWrapper.BackColor = root.screenColor;
            dgvContract.ThemeStyle.BackColor = root.screenColor;
            dgvContract.GridColor = root.screenColor;
            dgvContract.DefaultCellStyle.ForeColor = Color.Black;
            dgvContract.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvContract.ColumnHeadersDefaultCellStyle.SelectionBackColor = root.contractPrimaryColor;
            pnSearchAndFunction.FillColor = root.backColorComponentContract;
            pnFunctions.FillColor = root.backColorComponentContract;
            btnGoodsReceipt.FillColor = root.contractPrimaryColor;
            btnProvider.FillColor = root.contractPrimaryColor;
            btnImport.FillColor = root.contractPrimaryColor;
            btnDetail.FillColor = root.contractPrimaryColor;
            pnSearch.BorderColor = root.contractPrimaryColor;
            txtSearch.FillColor = root.backColorComponentContract;
            pnSideBar.FillColor = root.backGroundSideBarContract;
            pnSideBarHeader.FillColor = root.sideBarHeaderFooterContract;
            pnSideBarFooter.FillColor = root.sideBarHeaderFooterContract;
        }

        private void fContract_Load(object sender, EventArgs e)
        {
            btnGoodsReceipt.PerformClick();
            label6.BackColor = Color.FromArgb(100, Color.Black);
            label7.BackColor = Color.FromArgb(100, Color.Black);
            label8.BackColor = Color.FromArgb(100, Color.Black);
            label10.BackColor = Color.FromArgb(100, Color.Black);
            label11.BackColor = Color.FromArgb(100, Color.Black);
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Add Item");
            cm.MenuItems.Add("Delete Item");
            guna2Panel10.ContextMenu = cm;
        }

        private void CustomGoodsReceiptTable()
        {
            if (dgvContract.Rows.Count == 0)
            {
                txtSearch.SelectAll();
                pnSearch.BorderColor = Color.FromArgb(240, 67, 80);
            }
            else
                pnSearch.BorderColor = root.contractPrimaryColor;
            dgvContract.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            dgvContract.DefaultCellStyle.Font = new Font(new FontFamily("Roboto"), 12, FontStyle.Bold);
            dgvContract.Columns["CID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvContract.Columns["CID"].MinimumWidth = 60;
            dgvContract.Columns["CID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvContract.Columns["GID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvContract.Columns["GID"].MinimumWidth = 60;
            dgvContract.Columns["GID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvContract.Columns["Goods Name"].MinimumWidth = 400;
            dgvContract.Columns["Goods Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvContract.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContract.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvContract.Columns["Unit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContract.Columns["Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvContract.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContract.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvContract.Columns["Price"].DefaultCellStyle.Format = "#,##0 VND";
            dgvContract.Columns["Total Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContract.Columns["Total Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvContract.Columns["Total Price"].DefaultCellStyle.Format = "#,##0 VND";
            dgvContract.Columns["EID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvContract.Columns["EID"].MinimumWidth = 60;
            dgvContract.Columns["EID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvContract.Columns["Employee Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContract.Columns["Employee Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvContract.Columns["Provider Name"].MinimumWidth = 250;
            dgvContract.Columns["Provider Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvContract.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContract.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvContract.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss tt";

            int width = 2, height = dgvContract.ColumnHeadersHeight + 1;
            foreach (DataGridViewColumn col in dgvContract.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font(new FontFamily("Poppins"), 12, FontStyle.Bold);
                col.HeaderCell.Style.ForeColor = Color.BlanchedAlmond;
                width += col.Width;
            }
            int i = 0;
            foreach (DataGridViewRow row in dgvContract.Rows)
            {
                if (row.Index == 0)
                    continue;
                if (row.Cells["CID"].Value.ToString() == dgvContract.Rows[i].Cells["CID"].Value.ToString())
                {
                    row.Cells["CID"].Value = DBNull.Value;
                    row.Cells["Total Price"].Value = DBNull.Value;
                    row.Cells["EID"].Value = DBNull.Value;
                    row.Cells["Employee Name"].Value = DBNull.Value;
                    row.Cells["Provider Name"].Value = DBNull.Value;
                    row.Cells["Date"].Value = DBNull.Value;
                }
                else
                    i = row.Index;
                height += row.Height;
            }
            dgvContract.Size = new Size(width, height);
        }

        private void CustomProviderTable()
        {
            if (dgvContract.Rows.Count == 0)
            {
                txtSearch.SelectAll();
                pnSearch.BorderColor = Color.FromArgb(240, 67, 80);
            }
            else
                pnSearch.BorderColor = root.contractPrimaryColor;
            dgvContract.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            foreach (DataGridViewColumn col in dgvContract.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font(new FontFamily("Poppins"), 12, FontStyle.Bold);
                col.HeaderCell.Style.ForeColor = Color.BlanchedAlmond;
            }

            dgvContract.DefaultCellStyle.SelectionForeColor = Color.FromArgb(100, 60, 0);
            dgvContract.DefaultCellStyle.Font = new Font(new FontFamily("Roboto"), 12, FontStyle.Bold);
            dgvContract.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContract.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvContract.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvContract.Columns["Address"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvContract.Columns["Phone Number"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContract.Columns["Phone Number"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvContract.Columns["Providing"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContract.Columns["Providing"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            int height = dgvContract.ColumnHeadersHeight + 1;
            foreach (DataGridViewRow row in dgvContract.Rows)
                height += row.Height;
            dgvContract.Height = height;
        }

        private void ChangeTable(object sender)
        {
            foreach (Guna2Button c in tlpType.Controls)
                c.FillColor = root.contractPrimaryColor;
            (sender as Guna2Button).FillColor = root.buttonChoosingContract;
        }

        private void btnGoodsReceipt_Click(object sender, EventArgs e)
        {
            string error = null;
            DataTable dt = bll.GetAllGoodsReceipt(ref error);
            if (error != null)
            {
                MessageBox.Show(error);
                dgvContract.DataSource = null;
                ChangeTable(btnProvider);
                return;
            }
            dgvContract.DataSource = dt;
            CustomGoodsReceiptTable();
            ChangeTable(btnGoodsReceipt);
            tlpMain.RowStyles[1].Height = 11.5F;
            tlpMain.RowStyles[2].Height = 76.5F;
            tlpMain.RowStyles[3].Height = 0;
        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            string error = null;
            DataTable dt = bll.GetAllProviders(ref error);
            if (error != null)
            {
                MessageBox.Show(error);
                dgvContract.DataSource = null;
                ChangeTable(btnProvider);
                return;
            }
            dgvContract.DataSource = dt;
            CustomProviderTable();
            ChangeTable(btnProvider);
            tlpMain.RowStyles[1].Height = 11.5F;
            tlpMain.RowStyles[2].Height = 76.5F;
            tlpMain.RowStyles[3].Height = 0;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            tlpWrapper.ColumnStyles[1].Width = 0;
            tlpMain.RowStyles[1].Height = 0;
            tlpMain.RowStyles[2].Height = 0;
            tlpMain.RowStyles[3].Height = 88;
            ChangeTable(btnImport);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            tlpWrapper.ColumnStyles[1].Width = 550;
        }
    }
}
