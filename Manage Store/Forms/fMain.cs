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
            pnFunctions[0] = new FunctionPanel(IconChar.Home, "Home");
            pnFunctions[1] = new FunctionPanel(IconChar.CookieBite, "Goods");
            pnFunctions[2] = new FunctionPanel(IconChar.FileInvoiceDollar, "Bills");
            pnFunctions[3] = new FunctionPanel(IconChar.Users, "Employees");
            pnFunctions[4] = new FunctionPanel(IconChar.FileSignature, "Contracts");
            pnFunctions[5] = new FunctionPanel(IconChar.ChartLine, "Charts");
            profile = emp;
            if (emp != null)
            {
                lbName.Text = root.RemoveSignOfVietnameseString(profile.Name).ToUpper();
                lbRole.Text = profile.Role;
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            pnAccount.BackColor = root.primaryColor;
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
            OpenChildForm(new fGoods());
            formIndex = 0;

            // Open goods form
            pnFunctions[1].Click += new EventHandler(OpenGoodsForm);
            foreach (Control c in pnFunctions[1].Controls)
                c.Click += new EventHandler(OpenGoodsForm);
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
            tlpBody.Controls.Add(childForm, 0, 0);
            this.childForm.BringToFront();
            this.childForm.Show();
            lbHeader.Text = this.childForm.Text.ToUpper();
        }

        private void fMain_SizeChanged(object sender, EventArgs e)
        {
            pnNav.Width = expandSize;
            pnContainer.Width = Width - pnNav.Width;
            pnHeader.Height = (int)(0.06 * Height);
            //pnBody.Height = pnContainer.Height - pnHeader.Height;
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
            }
        }

        private void OpenGoodsForm(object sender, EventArgs e)
        {
            OpenChildForm(new fGoods());
        }
    }
}
