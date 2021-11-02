using BaiqiSoft.GridControl;
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
    public partial class fBill : Form
    {
        private BLL_Bill bll = new BLL_Bill();
        public fBill()
        {
            InitializeComponent();
            tlpWrapper.ColumnStyles[1].Width = 0;

            BackColor = root.screenColor;
            tlpWrapper.BackColor = root.screenColor;
            dgvBills.ThemeStyle.BackColor = root.screenColor;
            dgvBills.GridColor = root.screenColor;
            dgvBills.DefaultCellStyle.ForeColor = Color.Black;
            dgvBills.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvBills.ColumnHeadersDefaultCellStyle.SelectionBackColor = root.billPrimaryColor;
            pnSearchAndFunction.FillColor = root.backColorComponentBill;
            pnFunctions.FillColor = root.backColorComponentBill;
            cbbFilter.FillColor = root.billPrimaryColor;
            btnDetail.FillColor = root.billPrimaryColor;
            pnSearch.BorderColor = root.billPrimaryColor;
            txtSearch.FillColor = root.backColorComponentBill;
            pnSideBar.FillColor = root.backGroundSideBarBill;
            pnSideBarHeader.FillColor = root.sideBarHeaderFooterBill;
            pnSideBarFooter.FillColor = root.sideBarHeaderFooterBill;
            gbBillInformation.CustomBorderColor = root.darkerBackGroundSideBarBill;
            gbBillInformation.FillColor = root.sideBarHeaderFooterBill;
            gbItemsInformation.CustomBorderColor = root.darkerBackGroundSideBarBill;
            gbItemsInformation.FillColor = root.sideBarHeaderFooterBill;
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            string error = null;
            dgvBills.DataSource = bll.GetAllBills(ref error);
            if (error != null)
                MessageBox.Show(error);
            else
                CustomDgvBill();
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

        private void CustomDgvBill()
        {
            if (dgvBills.Rows.Count == 0)
            {
                txtSearch.SelectAll();
                pnSearch.BorderColor = Color.FromArgb(240, 67, 80);
            }
            else
                pnSearch.BorderColor = root.billPrimaryColor;
            dgvBills.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            dgvBills.DefaultCellStyle.Font = new Font(new FontFamily("Roboto"), 12, FontStyle.Bold);
            dgvBills.Columns["BID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvBills.Columns["BID"].MinimumWidth = 60;
            dgvBills.Columns["BID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBills.Columns["GID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvBills.Columns["GID"].MinimumWidth = 60;
            dgvBills.Columns["GID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBills.Columns["Goods Name"].MinimumWidth = 250;
            dgvBills.Columns["Goods Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBills.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvBills.Columns["Quantity"].MinimumWidth = 120;
            dgvBills.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBills.Columns["Unit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvBills.Columns["Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBills.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBills.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBills.Columns["Price"].DefaultCellStyle.Format = "#,##0 VND";
            dgvBills.Columns["Total Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBills.Columns["Total Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBills.Columns["Total Price"].DefaultCellStyle.Format = "#,##0 VND";
            dgvBills.Columns["EID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvBills.Columns["EID"].MinimumWidth = 60;
            dgvBills.Columns["EID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBills.Columns["Employee Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBills.Columns["Employee Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBills.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBills.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBills.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss tt";

            int width = 2;
            foreach (DataGridViewColumn col in dgvBills.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font(new FontFamily("Poppins"), 12, FontStyle.Bold);
                col.HeaderCell.Style.ForeColor = Color.BlanchedAlmond;
                width += col.Width;
            }
            int i = 0;
            foreach (DataGridViewRow row in dgvBills.Rows)
            {
                if (row.Index == 0)
                    continue;
                if (row.Cells["BID"].Value.ToString() == dgvBills.Rows[i].Cells["BID"].Value.ToString())
                {
                    row.Cells["BID"].Value = DBNull.Value;
                    row.Cells["Total Price"].Value = DBNull.Value;
                    row.Cells["EID"].Value = DBNull.Value;
                    row.Cells["Employee Name"].Value = DBNull.Value;
                    row.Cells["Date"].Value = DBNull.Value;
                }
                else
                    i = row.Index;
            }
            dgvBills.Width = width;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            tlpWrapper.ColumnStyles[1].Width = 600;
        }
    }
}
