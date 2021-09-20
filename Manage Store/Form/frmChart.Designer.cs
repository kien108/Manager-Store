namespace Manage_Store
{
    partial class frmChart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgEmployee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnStop = new Guna.UI2.WinForms.Guna2Button();
            this.btnSoldout = new Guna.UI2.WinForms.Guna2Button();
            this.btnStocking = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.lbOption = new System.Windows.Forms.Label();
            this.pnEmployeeHeading = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rdYear = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdMonth = new Guna.UI2.WinForms.Guna2RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.elipseControl2 = new ElipseToolDemo.ElipseControl();
            this.elipseControl3 = new ElipseToolDemo.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            this.pnEmployeeHeading.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgEmployee
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgEmployee.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEmployee.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgEmployee.EnableHeadersVisualStyles = false;
            this.dgEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgEmployee.Location = new System.Drawing.Point(23, 195);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.RowHeadersVisible = false;
            this.dgEmployee.RowHeadersWidth = 51;
            this.dgEmployee.RowTemplate.Height = 24;
            this.dgEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmployee.Size = new System.Drawing.Size(1070, 386);
            this.dgEmployee.TabIndex = 13;
            this.dgEmployee.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this.dgEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgEmployee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgEmployee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgEmployee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgEmployee.ThemeStyle.HeaderStyle.Height = 4;
            this.dgEmployee.ThemeStyle.ReadOnly = false;
            this.dgEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dgEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgEmployee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgEmployee.ThemeStyle.RowsStyle.Height = 24;
            this.dgEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.dgEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::Manage_Store.Properties.Resources.add1;
            this.btnAdd.Location = new System.Drawing.Point(571, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 32;
            // 
            // cbSearch
            // 
            this.cbSearch.BackColor = System.Drawing.Color.Transparent;
            this.cbSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.cbSearch.BorderRadius = 10;
            this.cbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.cbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.cbSearch.FocusedState.Parent = this.cbSearch;
            this.cbSearch.Font = new System.Drawing.Font("Poppins", 9F);
            this.cbSearch.ForeColor = System.Drawing.Color.Black;
            this.cbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.cbSearch.HoverState.Parent = this.cbSearch;
            this.cbSearch.ItemHeight = 30;
            this.cbSearch.Items.AddRange(new object[] {
            "Column Chart",
            "Percentage Chart",
            "Line Chart"});
            this.cbSearch.ItemsAppearance.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.ItemsAppearance.Parent = this.cbSearch;
            this.cbSearch.Location = new System.Drawing.Point(194, 124);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.ShadowDecoration.Parent = this.cbSearch;
            this.cbSearch.Size = new System.Drawing.Size(210, 36);
            this.cbSearch.TabIndex = 31;
            // 
            // btnStop
            // 
            this.btnStop.Animated = true;
            this.btnStop.BorderRadius = 10;
            this.btnStop.CheckedState.Parent = this.btnStop;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.CustomImages.Parent = this.btnStop;
            this.btnStop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStop.DisabledState.Parent = this.btnStop;
            this.btnStop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnStop.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.HoverState.Parent = this.btnStop;
            this.btnStop.Location = new System.Drawing.Point(281, 23);
            this.btnStop.Name = "btnStop";
            this.btnStop.ShadowDecoration.Parent = this.btnStop;
            this.btnStop.Size = new System.Drawing.Size(155, 45);
            this.btnStop.TabIndex = 26;
            this.btnStop.Text = "Profit";
            // 
            // btnSoldout
            // 
            this.btnSoldout.Animated = true;
            this.btnSoldout.BorderRadius = 10;
            this.btnSoldout.CheckedState.Parent = this.btnSoldout;
            this.btnSoldout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoldout.CustomImages.Parent = this.btnSoldout;
            this.btnSoldout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSoldout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSoldout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSoldout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSoldout.DisabledState.Parent = this.btnSoldout;
            this.btnSoldout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnSoldout.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnSoldout.ForeColor = System.Drawing.Color.White;
            this.btnSoldout.HoverState.Parent = this.btnSoldout;
            this.btnSoldout.Location = new System.Drawing.Point(446, 23);
            this.btnSoldout.Name = "btnSoldout";
            this.btnSoldout.ShadowDecoration.Parent = this.btnSoldout;
            this.btnSoldout.Size = new System.Drawing.Size(160, 45);
            this.btnSoldout.TabIndex = 27;
            this.btnSoldout.Text = "All";
            // 
            // btnStocking
            // 
            this.btnStocking.Animated = true;
            this.btnStocking.BorderRadius = 10;
            this.btnStocking.CheckedState.Parent = this.btnStocking;
            this.btnStocking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStocking.CustomImages.Parent = this.btnStocking;
            this.btnStocking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStocking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStocking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStocking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStocking.DisabledState.Parent = this.btnStocking;
            this.btnStocking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnStocking.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnStocking.ForeColor = System.Drawing.Color.White;
            this.btnStocking.HoverState.Parent = this.btnStocking;
            this.btnStocking.Location = new System.Drawing.Point(144, 23);
            this.btnStocking.Name = "btnStocking";
            this.btnStocking.ShadowDecoration.Parent = this.btnStocking;
            this.btnStocking.Size = new System.Drawing.Size(131, 45);
            this.btnStocking.TabIndex = 28;
            this.btnStocking.Text = "Revenue";
            // 
            // btnAll
            // 
            this.btnAll.Animated = true;
            this.btnAll.BorderRadius = 10;
            this.btnAll.CheckedState.Parent = this.btnAll;
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.CustomImages.Parent = this.btnAll;
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.DisabledState.Parent = this.btnAll;
            this.btnAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnAll.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.HoverState.Parent = this.btnAll;
            this.btnAll.Location = new System.Drawing.Point(13, 23);
            this.btnAll.Name = "btnAll";
            this.btnAll.ShadowDecoration.Parent = this.btnAll;
            this.btnAll.Size = new System.Drawing.Size(125, 45);
            this.btnAll.TabIndex = 29;
            this.btnAll.Text = "Bills";
            // 
            // lbOption
            // 
            this.lbOption.AutoSize = true;
            this.lbOption.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(154)))), ((int)(((byte)(157)))));
            this.lbOption.Location = new System.Drawing.Point(13, 83);
            this.lbOption.Name = "lbOption";
            this.lbOption.Size = new System.Drawing.Size(96, 30);
            this.lbOption.TabIndex = 25;
            this.lbOption.Text = "Bills Chart";
            // 
            // pnEmployeeHeading
            // 
            this.pnEmployeeHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnEmployeeHeading.BackColor = System.Drawing.Color.White;
            this.pnEmployeeHeading.BorderRadius = 30;
            this.pnEmployeeHeading.Controls.Add(this.label1);
            this.pnEmployeeHeading.Controls.Add(this.rdYear);
            this.pnEmployeeHeading.Controls.Add(this.rdMonth);
            this.pnEmployeeHeading.Controls.Add(this.btnAdd);
            this.pnEmployeeHeading.Controls.Add(this.cbSearch);
            this.pnEmployeeHeading.Controls.Add(this.btnStop);
            this.pnEmployeeHeading.Controls.Add(this.btnSoldout);
            this.pnEmployeeHeading.Controls.Add(this.btnStocking);
            this.pnEmployeeHeading.Controls.Add(this.btnAll);
            this.pnEmployeeHeading.Controls.Add(this.lbOption);
            this.pnEmployeeHeading.Location = new System.Drawing.Point(23, 12);
            this.pnEmployeeHeading.Name = "pnEmployeeHeading";
            this.pnEmployeeHeading.ShadowDecoration.BorderRadius = 10;
            this.pnEmployeeHeading.ShadowDecoration.Depth = 50;
            this.pnEmployeeHeading.ShadowDecoration.Parent = this.pnEmployeeHeading;
            this.pnEmployeeHeading.Size = new System.Drawing.Size(1070, 177);
            this.pnEmployeeHeading.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Choose type of chart:";
            // 
            // rdYear
            // 
            this.rdYear.AutoSize = true;
            this.rdYear.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.rdYear.CheckedState.BorderThickness = 2;
            this.rdYear.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.rdYear.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.rdYear.CheckedState.InnerOffset = -4;
            this.rdYear.Font = new System.Drawing.Font("Poppins", 9F);
            this.rdYear.Location = new System.Drawing.Point(498, 128);
            this.rdYear.Name = "rdYear";
            this.rdYear.Size = new System.Drawing.Size(67, 30);
            this.rdYear.TabIndex = 33;
            this.rdYear.Text = "Year";
            this.rdYear.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdYear.UncheckedState.BorderThickness = 2;
            this.rdYear.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdYear.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdMonth
            // 
            this.rdMonth.AutoSize = true;
            this.rdMonth.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.rdMonth.CheckedState.BorderThickness = 2;
            this.rdMonth.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.rdMonth.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.rdMonth.CheckedState.InnerOffset = -4;
            this.rdMonth.Font = new System.Drawing.Font("Poppins", 9F);
            this.rdMonth.Location = new System.Drawing.Point(410, 128);
            this.rdMonth.Name = "rdMonth";
            this.rdMonth.Size = new System.Drawing.Size(82, 30);
            this.rdMonth.TabIndex = 33;
            this.rdMonth.Text = "Month";
            this.rdMonth.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdMonth.UncheckedState.BorderThickness = 2;
            this.rdMonth.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdMonth.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 313);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 70);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Vẽ biểu đồ ở đây nè Bu";
            // 
            // elipseControl2
            // 
            this.elipseControl2.CornerRadius = 10;
            this.elipseControl2.TargetControl = this.pnEmployeeHeading;
            // 
            // elipseControl3
            // 
            this.elipseControl3.CornerRadius = 10;
            this.elipseControl3.TargetControl = this.dgEmployee;
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1094, 593);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgEmployee);
            this.Controls.Add(this.pnEmployeeHeading);
            this.Name = "frmChart";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.frmChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            this.pnEmployeeHeading.ResumeLayout(false);
            this.pnEmployeeHeading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgEmployee;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearch;
        private Guna.UI2.WinForms.Guna2Button btnStop;
        private Guna.UI2.WinForms.Guna2Button btnSoldout;
        private Guna.UI2.WinForms.Guna2Button btnStocking;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private System.Windows.Forms.Label lbOption;
        private Guna.UI2.WinForms.Guna2Panel pnEmployeeHeading;
        private ElipseToolDemo.ElipseControl elipseControl2;
        private ElipseToolDemo.ElipseControl elipseControl3;
        private Guna.UI2.WinForms.Guna2RadioButton rdMonth;
        private Guna.UI2.WinForms.Guna2RadioButton rdYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}