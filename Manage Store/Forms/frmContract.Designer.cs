namespace GUI
{
    partial class frmContract
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
            this.dgContract = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnStocking = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.lbOption = new System.Windows.Forms.Label();
            this.pnContractHeading = new Guna.UI2.WinForms.Guna2Panel();
            this.elipseControl2 = new ElipseToolDemo.ElipseControl();
            this.elipseControl3 = new ElipseToolDemo.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgContract)).BeginInit();
            this.pnContractHeading.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgContract
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgContract.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgContract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgContract.BackgroundColor = System.Drawing.Color.White;
            this.dgContract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgContract.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgContract.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgContract.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgContract.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgContract.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgContract.EnableHeadersVisualStyles = false;
            this.dgContract.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgContract.Location = new System.Drawing.Point(23, 195);
            this.dgContract.Name = "dgContract";
            this.dgContract.RowHeadersVisible = false;
            this.dgContract.RowHeadersWidth = 51;
            this.dgContract.RowTemplate.Height = 24;
            this.dgContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgContract.Size = new System.Drawing.Size(1070, 386);
            this.dgContract.TabIndex = 13;
            this.dgContract.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this.dgContract.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgContract.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgContract.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgContract.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgContract.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgContract.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgContract.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgContract.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgContract.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgContract.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgContract.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgContract.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgContract.ThemeStyle.HeaderStyle.Height = 4;
            this.dgContract.ThemeStyle.ReadOnly = false;
            this.dgContract.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dgContract.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgContract.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgContract.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgContract.ThemeStyle.RowsStyle.Height = 24;
            this.dgContract.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.dgContract.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            "Employee ID",
            "Goods ID",
            "Provider ID",
            "Date",
            "Quantity",
            "Price"});
            this.cbSearch.ItemsAppearance.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.ItemsAppearance.Parent = this.cbSearch;
            this.cbSearch.Location = new System.Drawing.Point(15, 125);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.ShadowDecoration.Parent = this.cbSearch;
            this.cbSearch.Size = new System.Drawing.Size(156, 36);
            this.cbSearch.TabIndex = 31;
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
            this.btnStocking.Text = "Provider";
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
            this.btnAll.Text = "All Contract";
            // 
            // lbOption
            // 
            this.lbOption.AutoSize = true;
            this.lbOption.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(154)))), ((int)(((byte)(157)))));
            this.lbOption.Location = new System.Drawing.Point(12, 83);
            this.lbOption.Name = "lbOption";
            this.lbOption.Size = new System.Drawing.Size(112, 30);
            this.lbOption.TabIndex = 25;
            this.lbOption.Text = "All Contract";
            // 
            // pnContractHeading
            // 
            this.pnContractHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContractHeading.BackColor = System.Drawing.Color.White;
            this.pnContractHeading.BorderRadius = 30;
            this.pnContractHeading.Controls.Add(this.btnAdd);
            this.pnContractHeading.Controls.Add(this.cbSearch);
            this.pnContractHeading.Controls.Add(this.txtSearch);
            this.pnContractHeading.Controls.Add(this.btnStocking);
            this.pnContractHeading.Controls.Add(this.btnAll);
            this.pnContractHeading.Controls.Add(this.lbOption);
            this.pnContractHeading.Location = new System.Drawing.Point(23, 12);
            this.pnContractHeading.Name = "pnContractHeading";
            this.pnContractHeading.ShadowDecoration.BorderRadius = 10;
            this.pnContractHeading.ShadowDecoration.Depth = 50;
            this.pnContractHeading.ShadowDecoration.Parent = this.pnContractHeading;
            this.pnContractHeading.Size = new System.Drawing.Size(1070, 177);
            this.pnContractHeading.TabIndex = 14;
            // 
            // elipseControl2
            // 
            this.elipseControl2.CornerRadius = 10;
            this.elipseControl2.TargetControl = this.pnContractHeading;
            // 
            // elipseControl3
            // 
            this.elipseControl3.CornerRadius = 10;
            this.elipseControl3.TargetControl = this.dgContract;
            // 
            // frmContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1094, 593);
            this.Controls.Add(this.dgContract);
            this.Controls.Add(this.pnContractHeading);
            this.Name = "frmContract";
            this.Text = "Contract";
            this.Load += new System.EventHandler(this.Contract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgContract)).EndInit();
            this.pnContractHeading.ResumeLayout(false);
            this.pnContractHeading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgContract;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnStocking;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private System.Windows.Forms.Label lbOption;
        private Guna.UI2.WinForms.Guna2Panel pnContractHeading;
        private ElipseToolDemo.ElipseControl elipseControl2;
        private ElipseToolDemo.ElipseControl elipseControl3;
    }
}