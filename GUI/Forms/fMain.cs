using DTO;
using FontAwesome.Sharp;
using GUI.DefinedFramework;
using Guna.UI2.WinForms;
using Manage_Store.DefinedFramework;
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
    public partial class fMain : Form
    {
        private FunctionPanel[] pnFunctions;
        private int expandSize = 360, collapseSize = 90;
        private Form childForm;
        private Employee profile;
        private int formIndex;

        public fMain(Employee emp)
        {
            InitializeComponent();
            pnFunctions = new FunctionPanel[6];
            pnFunctions[0] = new FunctionPanel(IconChar.Home, "Home", root.navHomeOptionColor, root.homePrimaryColor);
            pnFunctions[1] = new FunctionPanel(IconChar.FileInvoiceDollar, "Bills", root.navBillOptionColor, root.billPrimaryColor);
            pnFunctions[2] = new FunctionPanel(IconChar.CookieBite, "Goods", root.navGoodsOptionColor, root.goodsPrimaryColor);
            pnFunctions[3] = new FunctionPanel(IconChar.FileSignature, "Contracts", root.navContractOptionColor, root.contractPrimaryColor);
            pnFunctions[4] = new FunctionPanel(IconChar.Users, "Employees", root.navEmployeeOptionColor, root.employeePrimaryColor);
            pnFunctions[5] = new FunctionPanel(IconChar.ChartLine, "Charts", root.navChartOptionColor, root.chartPrimaryColor);
            profile = emp;
            if (emp != null)
            {
                lbName.Text = root.RemoveSignOfVietnameseString(profile.Name).ToUpper();
                lbRole.Text = profile.Role;
            }
            pnHeader.FillColor = root.titleBarColor;
            pnNav.FillColor = root.navBarColor;
            pnScreen.FillColor = root.screenColor;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            pnAccount.BackColor = root.navBarColor;
            for (int i = pnFunctions.Length - 1; i >= 0; --i)
            {
                pnNav.Controls.Add(pnFunctions[i]);
            }
            Controls.Add(pnLogo);
            pnNav.Controls.Add(pnLogo);

            // Collapse and expand navigation bar
            pnNav.DoubleClick += new EventHandler(CollapseAndExpand);
            for (int i = 0; i < pnFunctions.Length; ++i)
            {
                pnFunctions[i].DoubleClick += new EventHandler(CollapseAndExpand);
                foreach (Control c in pnFunctions[i].Controls)
                    c.DoubleClick += new EventHandler(CollapseAndExpand);
            }
            CollapseAndExpand(pnNav, new EventArgs());

            // Open home form
            pnFunctions[0].Click += new EventHandler(OpenHomePage);
            foreach (Control c in pnFunctions[0].Controls)
                c.Click += new EventHandler(OpenHomePage);

            // Open bill form
            pnFunctions[1].Click += new EventHandler(OpenBillForm);
            foreach (Control c in pnFunctions[1].Controls)
                c.Click += new EventHandler(OpenBillForm);

            // Open goods form
            pnFunctions[2].Click += new EventHandler(OpenGoodsForm);
            foreach (Control c in pnFunctions[2].Controls)
                c.Click += new EventHandler(OpenGoodsForm);

            // Open contract form
            pnFunctions[3].Click += new EventHandler(OpenContractForm);
            foreach (Control c in pnFunctions[3].Controls)
                c.Click += new EventHandler(OpenContractForm);

            // Open employees form
            pnFunctions[5].Click += new EventHandler(OpenEmployeeForm);
            foreach (Control c in pnFunctions[4].Controls)
                c.Click += new EventHandler(OpenEmployeeForm);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; 
        }

        private void OpenChildForm(Form childForm) // function to open child_form
        {

            if (this.childForm != null && childForm.GetType().ToString() == this.childForm.GetType().ToString())
                return;
            this.childForm = childForm;
            this.childForm.TopLevel = false;
            this.childForm.FormBorderStyle = FormBorderStyle.None;
            this.childForm.Dock = DockStyle.Fill;
            pnScreen.Controls.Add(childForm);
            this.childForm.BringToFront();
            this.childForm.Show();
            lbHeader.Text = this.childForm.Text.ToUpper();
        }

        private void fMain_SizeChanged(object sender, EventArgs e)
        {
            pnNav.Width = expandSize;
            pnContainer.Width = Width - pnNav.Width;
            pnHeader.Height = (int)(0.06 * Height);
        }

        private void CollapseAndExpand(object sender, EventArgs e)
        {
            if (pnNav.Width == expandSize)
            {
                pnNav.Width = collapseSize;
                foreach (FunctionPanel pn in pnFunctions)
                {
                    pn.name.Hide(); 
                    pn.Width = pnNav.Width - pn.Margin.Left * 2;
                }
                pnContainer.Width = Width - pnNav.Width;
            }
            else
            {
                pnNav.Width = expandSize;
                foreach (FunctionPanel pn in pnFunctions)
                {
                    pn.AutoSize = false;
                    pn.name.Show();
                    pn.Width = pnNav.Width - pn.Margin.Left * 2;
                }
                pnContainer.Width = Width - pnNav.Width;
                pnNav.Width = expandSize;
            }
        }

        private void HighlightOption(int p)
        {
            for (int i = 0; i < pnFunctions.Length; i++)
                pnFunctions[i].Chose();
            pnFunctions[p].Chose(true);
        }

        private void pnScreen_Paint(object sender, PaintEventArgs e)
        {
            HighlightOption(1);
            OpenChildForm(new fBill());
        }

        private void OpenHomePage(object sender, EventArgs e)
        {
            HighlightOption(0);
            OpenChildForm(new fHome());
        }

        private void OpenBillForm(object sender, EventArgs e)
        {
            HighlightOption(1);
            OpenChildForm(new fBill());
        }

        private void OpenGoodsForm(object sender, EventArgs e)
        {
            HighlightOption(2);
            OpenChildForm(new fGoods());
        }

        private void OpenContractForm(object sender, EventArgs e)
        {
            HighlightOption(3);
            OpenChildForm(new fContract());
        }

        private void OpenEmployeeForm(object sender, EventArgs e)
        {
            HighlightOption(4);
            OpenChildForm(new fEmployee());
        }
    }
}
