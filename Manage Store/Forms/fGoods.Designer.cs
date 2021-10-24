
namespace GUI
{
    partial class fGoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.pnSearchAndFunction = new Guna.UI2.WinForms.Guna2Panel();
            this.pnSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDeleteSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpFunction = new System.Windows.Forms.TableLayoutPanel();
            this.pnBtnEdit = new System.Windows.Forms.Panel();
            this.btnEditGoods = new Guna.UI2.WinForms.Guna2Button();
            this.pnDelete = new System.Windows.Forms.Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.pnBtnAdd = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGoodsType = new System.Windows.Forms.TableLayoutPanel();
            this.btnStopSelling = new Guna.UI2.WinForms.Guna2Button();
            this.btnSoldOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnStocking = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.dgvGoods = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ecDgvGoods = new ElipseToolDemo.ElipseControl();
            this.tlpSearch.SuspendLayout();
            this.pnSearchAndFunction.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tlpFunction.SuspendLayout();
            this.pnBtnEdit.SuspendLayout();
            this.pnDelete.SuspendLayout();
            this.pnBtnAdd.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpGoodsType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpSearch
            // 
            this.tlpSearch.ColumnCount = 2;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.57699F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 416F));
            this.tlpSearch.Controls.Add(this.pnSearchAndFunction, 0, 0);
            this.tlpSearch.Controls.Add(this.guna2Panel1, 1, 0);
            this.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearch.Location = new System.Drawing.Point(3, 84);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 1;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tlpSearch.Size = new System.Drawing.Size(1234, 63);
            this.tlpSearch.TabIndex = 1;
            // 
            // pnSearchAndFunction
            // 
            this.pnSearchAndFunction.AutoRoundedCorners = true;
            this.pnSearchAndFunction.BorderRadius = 24;
            this.pnSearchAndFunction.Controls.Add(this.pnSearch);
            this.pnSearchAndFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearchAndFunction.FillColor = System.Drawing.Color.MistyRose;
            this.pnSearchAndFunction.Location = new System.Drawing.Point(10, 10);
            this.pnSearchAndFunction.Margin = new System.Windows.Forms.Padding(10, 10, 0, 3);
            this.pnSearchAndFunction.Name = "pnSearchAndFunction";
            this.pnSearchAndFunction.Padding = new System.Windows.Forms.Padding(10);
            this.pnSearchAndFunction.ShadowDecoration.Parent = this.pnSearchAndFunction;
            this.pnSearchAndFunction.Size = new System.Drawing.Size(808, 50);
            this.pnSearchAndFunction.TabIndex = 0;
            // 
            // pnSearch
            // 
            this.pnSearch.AutoRoundedCorners = true;
            this.pnSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.pnSearch.BorderRadius = 14;
            this.pnSearch.BorderThickness = 2;
            this.pnSearch.Controls.Add(this.btnDeleteSearch);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearch.FillColor = System.Drawing.Color.Transparent;
            this.pnSearch.Location = new System.Drawing.Point(10, 10);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Padding = new System.Windows.Forms.Padding(5, 5, 8, 5);
            this.pnSearch.ShadowDecoration.Parent = this.pnSearch;
            this.pnSearch.Size = new System.Drawing.Size(788, 30);
            this.pnSearch.TabIndex = 2;
            // 
            // btnDeleteSearch
            // 
            this.btnDeleteSearch.BackgroundImage = global::Manage_Store.Properties.Resources.cancel_96px;
            this.btnDeleteSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteSearch.Location = new System.Drawing.Point(760, 5);
            this.btnDeleteSearch.Name = "btnDeleteSearch";
            this.btnDeleteSearch.ShadowDecoration.Parent = this.btnDeleteSearch;
            this.btnDeleteSearch.Size = new System.Drawing.Size(20, 20);
            this.btnDeleteSearch.TabIndex = 2;
            this.btnDeleteSearch.Click += new System.EventHandler(this.btnDeleteSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.txtSearch.BorderThickness = 0;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.FillColor = System.Drawing.Color.MistyRose;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(45, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search by ID or goods name...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(357, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Manage_Store.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Location = new System.Drawing.Point(5, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(40, 20);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSearch_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BorderRadius = 24;
            this.guna2Panel1.Controls.Add(this.tlpFunction);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.MistyRose;
            this.guna2Panel1.Location = new System.Drawing.Point(828, 10);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(396, 50);
            this.guna2Panel1.TabIndex = 1;
            // 
            // tlpFunction
            // 
            this.tlpFunction.BackColor = System.Drawing.Color.Transparent;
            this.tlpFunction.ColumnCount = 3;
            this.tlpFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFunction.Controls.Add(this.pnBtnEdit, 0, 0);
            this.tlpFunction.Controls.Add(this.pnDelete, 2, 0);
            this.tlpFunction.Controls.Add(this.pnBtnAdd, 1, 0);
            this.tlpFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFunction.Location = new System.Drawing.Point(0, 0);
            this.tlpFunction.Name = "tlpFunction";
            this.tlpFunction.RowCount = 1;
            this.tlpFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFunction.Size = new System.Drawing.Size(396, 50);
            this.tlpFunction.TabIndex = 0;
            // 
            // pnBtnEdit
            // 
            this.pnBtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.pnBtnEdit.Controls.Add(this.btnEditGoods);
            this.pnBtnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBtnEdit.Location = new System.Drawing.Point(0, 0);
            this.pnBtnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.pnBtnEdit.Name = "pnBtnEdit";
            this.pnBtnEdit.Padding = new System.Windows.Forms.Padding(13, 10, 5, 10);
            this.pnBtnEdit.Size = new System.Drawing.Size(132, 50);
            this.pnBtnEdit.TabIndex = 14;
            // 
            // btnEditGoods
            // 
            this.btnEditGoods.AutoRoundedCorners = true;
            this.btnEditGoods.BorderRadius = 14;
            this.btnEditGoods.CheckedState.Parent = this.btnEditGoods;
            this.btnEditGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditGoods.CustomImages.Parent = this.btnEditGoods;
            this.btnEditGoods.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditGoods.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditGoods.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditGoods.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditGoods.DisabledState.Parent = this.btnEditGoods;
            this.btnEditGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditGoods.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnEditGoods.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGoods.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEditGoods.HoverState.Parent = this.btnEditGoods;
            this.btnEditGoods.Image = global::Manage_Store.Properties.Resources.detail;
            this.btnEditGoods.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEditGoods.Location = new System.Drawing.Point(13, 10);
            this.btnEditGoods.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditGoods.Name = "btnEditGoods";
            this.btnEditGoods.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnEditGoods.ShadowDecoration.Parent = this.btnEditGoods;
            this.btnEditGoods.Size = new System.Drawing.Size(114, 30);
            this.btnEditGoods.TabIndex = 0;
            this.btnEditGoods.Text = "Detail";
            // 
            // pnDelete
            // 
            this.pnDelete.BackColor = System.Drawing.Color.Transparent;
            this.pnDelete.Controls.Add(this.btnDelete);
            this.pnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDelete.Location = new System.Drawing.Point(264, 0);
            this.pnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.pnDelete.Name = "pnDelete";
            this.pnDelete.Padding = new System.Windows.Forms.Padding(5, 10, 13, 10);
            this.pnDelete.Size = new System.Drawing.Size(132, 50);
            this.pnDelete.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderRadius = 14;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.DisabledState.Parent = this.btnDelete;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FillColor = System.Drawing.Color.Brown;
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::Manage_Store.Properties.Resources.delete;
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(5, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(114, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            // 
            // pnBtnAdd
            // 
            this.pnBtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnBtnAdd.Controls.Add(this.guna2Button1);
            this.pnBtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBtnAdd.Location = new System.Drawing.Point(132, 0);
            this.pnBtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.pnBtnAdd.Name = "pnBtnAdd";
            this.pnBtnAdd.Padding = new System.Windows.Forms.Padding(5, 10, 4, 10);
            this.pnBtnAdd.Size = new System.Drawing.Size(132, 50);
            this.pnBtnAdd.TabIndex = 10;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.guna2Button1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Manage_Store.Properties.Resources.add;
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(5, 10);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(123, 30);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Add";
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpGoodsType, 0, 0);
            this.tlpMain.Controls.Add(this.tlpSearch, 0, 1);
            this.tlpMain.Controls.Add(this.dgvGoods, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tlpMain.Size = new System.Drawing.Size(1240, 722);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpGoodsType
            // 
            this.tlpGoodsType.ColumnCount = 4;
            this.tlpGoodsType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpGoodsType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpGoodsType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpGoodsType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpGoodsType.Controls.Add(this.btnStopSelling, 3, 0);
            this.tlpGoodsType.Controls.Add(this.btnSoldOut, 2, 0);
            this.tlpGoodsType.Controls.Add(this.btnStocking, 1, 0);
            this.tlpGoodsType.Controls.Add(this.btnAll, 0, 0);
            this.tlpGoodsType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGoodsType.Location = new System.Drawing.Point(3, 3);
            this.tlpGoodsType.Name = "tlpGoodsType";
            this.tlpGoodsType.RowCount = 1;
            this.tlpGoodsType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGoodsType.Size = new System.Drawing.Size(1234, 75);
            this.tlpGoodsType.TabIndex = 0;
            // 
            // btnStopSelling
            // 
            this.btnStopSelling.BackColor = System.Drawing.Color.Transparent;
            this.btnStopSelling.BorderRadius = 10;
            this.btnStopSelling.CheckedState.Parent = this.btnStopSelling;
            this.btnStopSelling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopSelling.CustomImages.Parent = this.btnStopSelling;
            this.btnStopSelling.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStopSelling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStopSelling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStopSelling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStopSelling.DisabledState.Parent = this.btnStopSelling;
            this.btnStopSelling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopSelling.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnStopSelling.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnStopSelling.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnStopSelling.HoverState.Parent = this.btnStopSelling;
            this.btnStopSelling.Location = new System.Drawing.Point(934, 10);
            this.btnStopSelling.Margin = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.btnStopSelling.Name = "btnStopSelling";
            this.btnStopSelling.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnStopSelling.ShadowDecoration.Parent = this.btnStopSelling;
            this.btnStopSelling.Size = new System.Drawing.Size(290, 57);
            this.btnStopSelling.TabIndex = 3;
            this.btnStopSelling.Text = "Stop selling";
            this.btnStopSelling.Click += new System.EventHandler(this.btnStopSelling_Click);
            // 
            // btnSoldOut
            // 
            this.btnSoldOut.BackColor = System.Drawing.Color.Transparent;
            this.btnSoldOut.BorderRadius = 10;
            this.btnSoldOut.CheckedState.Parent = this.btnSoldOut;
            this.btnSoldOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoldOut.CustomImages.Parent = this.btnSoldOut;
            this.btnSoldOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSoldOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSoldOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSoldOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSoldOut.DisabledState.Parent = this.btnSoldOut;
            this.btnSoldOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSoldOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnSoldOut.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnSoldOut.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSoldOut.HoverState.Parent = this.btnSoldOut;
            this.btnSoldOut.Location = new System.Drawing.Point(626, 10);
            this.btnSoldOut.Margin = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.btnSoldOut.Name = "btnSoldOut";
            this.btnSoldOut.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSoldOut.ShadowDecoration.Parent = this.btnSoldOut;
            this.btnSoldOut.Size = new System.Drawing.Size(288, 57);
            this.btnSoldOut.TabIndex = 2;
            this.btnSoldOut.Text = "Sold out";
            this.btnSoldOut.Click += new System.EventHandler(this.btnSoldOut_Click);
            // 
            // btnStocking
            // 
            this.btnStocking.BackColor = System.Drawing.Color.Transparent;
            this.btnStocking.BorderRadius = 10;
            this.btnStocking.CheckedState.Parent = this.btnStocking;
            this.btnStocking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStocking.CustomImages.Parent = this.btnStocking;
            this.btnStocking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStocking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStocking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStocking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStocking.DisabledState.Parent = this.btnStocking;
            this.btnStocking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStocking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnStocking.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnStocking.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnStocking.HoverState.Parent = this.btnStocking;
            this.btnStocking.Location = new System.Drawing.Point(318, 10);
            this.btnStocking.Margin = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.btnStocking.Name = "btnStocking";
            this.btnStocking.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnStocking.ShadowDecoration.Parent = this.btnStocking;
            this.btnStocking.Size = new System.Drawing.Size(288, 57);
            this.btnStocking.TabIndex = 1;
            this.btnStocking.Text = "Stocking";
            this.btnStocking.Click += new System.EventHandler(this.btnStocking_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.BorderRadius = 10;
            this.btnAll.CheckedState.Parent = this.btnAll;
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.CustomImages.Parent = this.btnAll;
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.DisabledState.Parent = this.btnAll;
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnAll.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnAll.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAll.HoverState.Parent = this.btnAll;
            this.btnAll.Location = new System.Drawing.Point(10, 10);
            this.btnAll.Margin = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.btnAll.Name = "btnAll";
            this.btnAll.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAll.ShadowDecoration.Parent = this.btnAll;
            this.btnAll.Size = new System.Drawing.Size(288, 57);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "All";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // dgvGoods
            // 
            this.dgvGoods.AllowUserToAddRows = false;
            this.dgvGoods.AllowUserToDeleteRows = false;
            this.dgvGoods.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvGoods.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoods.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.dgvGoods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGoods.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGoods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGoods.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGoods.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGoods.EnableHeadersVisualStyles = false;
            this.dgvGoods.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvGoods.Location = new System.Drawing.Point(13, 165);
            this.dgvGoods.Margin = new System.Windows.Forms.Padding(13, 15, 0, 10);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.ReadOnly = true;
            this.dgvGoods.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGoods.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGoods.RowHeadersVisible = false;
            this.dgvGoods.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            this.dgvGoods.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGoods.RowTemplate.Height = 40;
            this.dgvGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoods.Size = new System.Drawing.Size(1227, 547);
            this.dgvGoods.TabIndex = 2;
            this.dgvGoods.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvGoods.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvGoods.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGoods.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGoods.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGoods.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGoods.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.dgvGoods.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvGoods.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvGoods.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGoods.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvGoods.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGoods.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvGoods.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvGoods.ThemeStyle.ReadOnly = true;
            this.dgvGoods.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvGoods.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGoods.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvGoods.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGoods.ThemeStyle.RowsStyle.Height = 40;
            this.dgvGoods.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvGoods.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ecDgvGoods
            // 
            this.ecDgvGoods.CornerRadius = 20;
            this.ecDgvGoods.TargetControl = this.dgvGoods;
            // 
            // fGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 722);
            this.Controls.Add(this.tlpMain);
            this.Name = "fGoods";
            this.Text = "GOODS";
            this.Load += new System.EventHandler(this.fGoods_Load);
            this.tlpSearch.ResumeLayout(false);
            this.pnSearchAndFunction.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.tlpFunction.ResumeLayout(false);
            this.pnBtnEdit.ResumeLayout(false);
            this.pnDelete.ResumeLayout(false);
            this.pnBtnAdd.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpGoodsType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpGoodsType;
        private Guna.UI2.WinForms.Guna2Button btnStopSelling;
        private Guna.UI2.WinForms.Guna2Button btnSoldOut;
        private Guna.UI2.WinForms.Guna2Button btnStocking;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsImageDataGridViewTextBoxColumn;
        private ElipseToolDemo.ElipseControl ecDgvGoods;
        private Guna.UI2.WinForms.Guna2Panel pnSearchAndFunction;
        private Guna.UI2.WinForms.Guna2Panel pnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel btnSearch;
        private Guna.UI2.WinForms.Guna2Panel btnDeleteSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tlpFunction;
        private System.Windows.Forms.Panel pnBtnEdit;
        private Guna.UI2.WinForms.Guna2Button btnEditGoods;
        private System.Windows.Forms.Panel pnDelete;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Panel pnBtnAdd;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}