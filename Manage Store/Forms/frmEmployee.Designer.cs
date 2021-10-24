namespace GUI
{
    partial class frmEmployee
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
            this.btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgEmployee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnStop = new Guna.UI2.WinForms.Guna2Button();
            this.btnSoldout = new Guna.UI2.WinForms.Guna2Button();
            this.btnStocking = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.lbOption = new System.Windows.Forms.Label();
            this.pnEmployeeHeading = new Guna.UI2.WinForms.Guna2Panel();
            this.elipseControl2 = new ElipseToolDemo.ElipseControl();
            this.elipseControl3 = new ElipseToolDemo.ElipseControl();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            this.pnEmployeeHeading.SuspendLayout();
            this.SuspendLayout();
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
            this.btnAdd.Location = new System.Drawing.Point(925, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Poppins", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconRightSize = new System.Drawing.Size(25, 25);
            this.txtSearch.Location = new System.Drawing.Point(178, 121);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(740, 44);
            this.txtSearch.TabIndex = 30;
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
            this.dgEmployee.TabIndex = 11;
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
            this.cbSearch.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.cbSearch.ForeColor = System.Drawing.Color.Black;
            this.cbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.cbSearch.HoverState.Parent = this.cbSearch;
            this.cbSearch.ItemHeight = 30;
            this.cbSearch.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Birthday",
            "Address",
            "Gender",
            "Phone Number",
            "WorkDays",
            "SalaryPerDay"});
            this.cbSearch.ItemsAppearance.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.ItemsAppearance.Parent = this.cbSearch;
            this.cbSearch.Location = new System.Drawing.Point(15, 125);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.ShadowDecoration.Parent = this.cbSearch;
            this.cbSearch.Size = new System.Drawing.Size(156, 36);
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
            this.btnStop.Size = new System.Drawing.Size(131, 45);
            this.btnStop.TabIndex = 26;
            this.btnStop.Text = "Accountant";
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
            this.btnSoldout.Location = new System.Drawing.Point(418, 23);
            this.btnSoldout.Name = "btnSoldout";
            this.btnSoldout.ShadowDecoration.Parent = this.btnSoldout;
            this.btnSoldout.Size = new System.Drawing.Size(160, 45);
            this.btnSoldout.TabIndex = 27;
            this.btnSoldout.Text = "Stock manager";
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
            this.btnStocking.Text = "Staff";
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
            this.btnAll.Text = "All Roles";
            // 
            // lbOption
            // 
            this.lbOption.AutoSize = true;
            this.lbOption.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(154)))), ((int)(((byte)(157)))));
            this.lbOption.Location = new System.Drawing.Point(10, 83);
            this.lbOption.Name = "lbOption";
            this.lbOption.Size = new System.Drawing.Size(129, 30);
            this.lbOption.TabIndex = 25;
            this.lbOption.Text = "All Employees";
            // 
            // pnEmployeeHeading
            // 
            this.pnEmployeeHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnEmployeeHeading.BackColor = System.Drawing.Color.White;
            this.pnEmployeeHeading.BorderRadius = 30;
            this.pnEmployeeHeading.Controls.Add(this.button1);
            this.pnEmployeeHeading.Controls.Add(this.btnAdd);
            this.pnEmployeeHeading.Controls.Add(this.cbSearch);
            this.pnEmployeeHeading.Controls.Add(this.txtSearch);
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
            this.pnEmployeeHeading.TabIndex = 12;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 33);
            this.button1.TabIndex = 33;
            this.button1.Text = "Test mở form detail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1094, 593);
            this.Controls.Add(this.dgEmployee);
            this.Controls.Add(this.pnEmployeeHeading);
            this.Name = "frmEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            this.pnEmployeeHeading.ResumeLayout(false);
            this.pnEmployeeHeading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgEmployee;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearch;
        private Guna.UI2.WinForms.Guna2Button btnStop;
        private Guna.UI2.WinForms.Guna2Button btnSoldout;
        private Guna.UI2.WinForms.Guna2Button btnStocking;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private System.Windows.Forms.Label lbOption;
        private Guna.UI2.WinForms.Guna2Panel pnEmployeeHeading;
        private ElipseToolDemo.ElipseControl elipseControl2;
        private ElipseToolDemo.ElipseControl elipseControl3;
        private System.Windows.Forms.Button button1;
    }
}