using BLL;
using GUI.DefinedFramework;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class fEmployee : Form
    {
        private BLL_Employee bll = new BLL_Employee();
        public fEmployee()
        {
            InitializeComponent();
            tlpWrapper.ColumnStyles[1].Width = 0;
            btnDeleteSearch.Hide();

            BackColor = root.screenColor;
            tlpWrapper.BackColor = root.screenColor;
            dgvEmployees.ThemeStyle.BackColor = root.screenColor;
            dgvEmployees.GridColor = root.screenColor;
            dgvEmployees.DefaultCellStyle.ForeColor = Color.Black;
            dgvEmployees.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvEmployees.ColumnHeadersDefaultCellStyle.SelectionBackColor = root.employeePrimaryColor;
            pnSearchAndFunction.FillColor = root.backColorComponentEmployee;
            pnFunctions.FillColor = root.backColorComponentEmployee;
            btnAllRoles.FillColor = root.employeePrimaryColor;
            btnStaff.FillColor = root.employeePrimaryColor;
            btnStockManager.FillColor = root.employeePrimaryColor;
            btnDetail.FillColor = root.employeePrimaryColor;
            btnAdd.FillColor = root.employeePrimaryColor;
            pnSearch.BorderColor = root.employeePrimaryColor;
            txtSearch.FillColor = root.backColorComponentEmployee;
            pnSideBar.FillColor = root.backGroundSideBarEmployee;
            cbbFilter.FillColor = root.employeePrimaryColor;
            pnSearch.BorderColor = root.employeePrimaryColor;
            pnSideBarHeader.FillColor = root.sideBarHeaderFooterEmployee;
            pnSideBarFooter.FillColor = root.sideBarHeaderFooterEmployee;
            tlpPictureSide.BackColor = root.darkerBackGroundSideBarEmployee;
            pnStateOptionWrapper.FillColor = root.darkerBackGroundSideBarEmployee;
            gbPersonalInformation.CustomBorderColor = root.darkerBackGroundSideBarEmployee;
            gbPersonalInformation.FillColor = root.sideBarHeaderFooterEmployee;
            gbWorkInformation.CustomBorderColor = root.darkerBackGroundSideBarEmployee;
            gbWorkInformation.FillColor = root.sideBarHeaderFooterEmployee;
        }

        private void fEmployee_Load(object sender, EventArgs e)
        {
            btnAllRoles.PerformClick();
        }

        private void CustomDataGridViewEmployee()
        {
            if (dgvEmployees.Rows.Count == 0)
            {
                txtSearch.SelectAll();
                pnSearch.BorderColor = Color.FromArgb(240, 67, 80);
            }
            else
                pnSearch.BorderColor = root.employeePrimaryColor;
            dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            foreach (DataGridViewColumn col in dgvEmployees.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font(new FontFamily("Poppins"), 12, FontStyle.Bold);
                col.HeaderCell.Style.ForeColor = Color.BlanchedAlmond;
            }

            dgvEmployees.DefaultCellStyle.Font = new Font(new FontFamily("Roboto"), 12, FontStyle.Bold);
            dgvEmployees.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvEmployees.Columns["ID"].MinimumWidth = 60;
            dgvEmployees.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmployees.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmployees.Columns["Birthday"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmployees.Columns["Birthday"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvEmployees.Columns["Birthday"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvEmployees.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmployees.Columns["Address"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmployees.Columns["Gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvEmployees.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns["Phone Number"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvEmployees.Columns["Phone Number"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmployees.Columns["Working Days"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvEmployees.Columns["Working Days"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns["Day's Wage"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvEmployees.Columns["Day's Wage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvEmployees.Columns["Day's Wage"].DefaultCellStyle.Format = "#,##0 VND";
            dgvEmployees.Columns["Month Salary"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvEmployees.Columns["Month Salary"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvEmployees.Columns["Month Salary"].DefaultCellStyle.Format = "#,##0 VND";
            dgvEmployees.Columns["Password"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmployees.Columns["Password"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmployees.Columns["Role"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmployees.Columns["Role"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns["Working"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmployees.Columns["Working"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns["Image"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvEmployees.Columns["Image"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            int width = 2, height = dgvEmployees.ColumnHeadersHeight + 1;
            foreach (DataGridViewColumn col in dgvEmployees.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font(new FontFamily("Poppins"), 12, FontStyle.Bold);
                col.HeaderCell.Style.ForeColor = Color.BlanchedAlmond;
                width += col.Width;
            }
            foreach (DataGridViewRow row in dgvEmployees.Rows)
                height += row.Height;
            dgvEmployees.Size = new Size(width, height);
        }

        private void btnAllRoles_Click(object sender, EventArgs e)
        {
            string error = null;
            DataTable dt = bll.GetAllEmployee(ref error);
            if (error != null)
            {
                MessageBox.Show(error);
                dgvEmployees.DataSource = null;
                ChangeEmployeeType(btnAllRoles);
                CustomDataGridViewEmployee();
                return;
            }
            dgvEmployees.DataSource = dt;
            ChangeEmployeeType(btnAllRoles);
            CustomDataGridViewEmployee();
        }

        private void ChangeEmployeeType(object sender)
        {
            foreach (Guna2Button c in tlpEmployeeType.Controls)
                c.FillColor = root.employeePrimaryColor;
            (sender as Guna2Button).FillColor = root.darkerBackGroundSideBarEmployee;
        }

        private void btnStockManager_Click(object sender, EventArgs e)
        {
            string error = null;
            DataTable dt = bll.GetStockManagers(ref error);
            if (error != null)
            {
                MessageBox.Show(error);
                dgvEmployees.DataSource = null;
                ChangeEmployeeType(btnStockManager);
                CustomDataGridViewEmployee();
                return;
            }
            dgvEmployees.DataSource = dt;
            ChangeEmployeeType(btnStockManager);
            CustomDataGridViewEmployee();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            string error = null;
            DataTable dt = bll.GetStaffs(ref error);
            if (error != null)
            {
                MessageBox.Show(error);
                dgvEmployees.DataSource = null;
                ChangeEmployeeType(btnStaff);
                CustomDataGridViewEmployee();
                return;
            }
            dgvEmployees.DataSource = dt;
            ChangeEmployeeType(btnStaff);
            CustomDataGridViewEmployee();
        }

        private void txtSearch_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, (sender as Control).DisplayRectangle,
                Color.FromArgb(200, 200, 200), 2, ButtonBorderStyle.Solid,
                Color.Transparent, 0, ButtonBorderStyle.Solid,
                Color.Transparent, 0, ButtonBorderStyle.Solid,
                Color.Transparent, 0, ButtonBorderStyle.Solid);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            pnSearch.BorderColor = root.employeePrimaryColor;
            if (txtSearch.Text.Length > 0)
                btnDeleteSearch.Show();
            else
                btnDeleteSearch.Hide();
        }

        private void btnDeleteSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchBy = cbbFilter.Text, text = txtSearch.Text;
            if (string.IsNullOrEmpty(text))
            {
                txtSearch.Focus();
                pnSearch.BorderColor = Color.Red;
                return;
            }
            string role = null;
            foreach (Guna2Button c in tlpEmployeeType.Controls)
                if (c.FillColor == root.darkerBackGroundSideBarEmployee)
                {
                    role = c.Text;
                    break;
                }
            if (role.ToLower().Contains("all"))
                role = null;
            string error = null;
            DataTable dt = bll.SearchEmployee(searchBy, text, role, ref error);
            if (error != null)
            {
                MessageBox.Show(error);
                dgvEmployees.DataSource = null;
                txtSearch.SelectAll();
                txtSearch.Focus();
                pnSearch.BorderColor = root.employeePrimaryColor;
                return;
            }
            dgvEmployees.DataSource = dt;
            CustomDataGridViewEmployee();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tlpWrapper.ColumnStyles[1].Width > 0)
                btnDetail.PerformClick();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int row = dgvEmployees.CurrentCell.RowIndex;
            DataRow dr = ((DataTable)dgvEmployees.DataSource).Rows[row];
            txtName.Text = dr["Name"].ToString();
            txtPhoneNumber.Text = dr["Phone Number"].ToString();
            txtID.Text = dr["ID"].ToString();
            txtAddress.Text = dr["Address"].ToString();
            txtPassword.Text = dr["Password"].ToString();
            string url = root.ProjectPath() + root.imageEmployees + txtID.Text + ".png";
            if (File.Exists(url))
            {
                pbPiture.Image = Image.FromFile(url);
                txtUrl.Text = url;
            }
            else
            {
                pbPiture.Image = Image.FromFile(root.ProjectPath() + root.imageEmployees + "tempAvatar.png");
                txtUrl.Clear();
            }
            if ((bool)dr["Working"])
                rbWorking.Checked = true;
            else
                rbQuitWork.Checked = true;
            if (dr["Role"].ToString().ToLower() == "staff")
                cbbRole.SelectedIndex = 0;
            else
                cbbRole.SelectedIndex = 1;
            nudWorkingDays.Value = decimal.Parse(dr["Working Days"].ToString());
            nudDayWage.Value = decimal.Parse(dr["Day's Wage"].ToString());
            nudMonthSalary.Value = decimal.Parse(dr["Month Salary"].ToString());

            tlpWrapper.ColumnStyles[1].Width = 600;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            tlpWrapper.ColumnStyles[1].Width = 0;
        }

        private void btnSideBarCancel_Click(object sender, EventArgs e)
        {
            btnCollapse.PerformClick();
        }

        private void btnTick_Click(object sender, EventArgs e)
        {
            if (lbSideBarTitle.Text.ToLower().Contains("detail"))
            {
                lbSideBarTitle.Text = "Edit Information";
                pnStateOptionWrapper.Enabled = true;
                cbbRole.Enabled = true;
                nudDayWage.Enabled = true;
            }
        }

        private void EnableAllControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.Enabled = true;
                EnableAllControls(c);
            }
        }
    }
}
