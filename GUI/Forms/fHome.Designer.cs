
namespace GUI
{
    partial class fHome
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
            this.tlpWrapper = new System.Windows.Forms.TableLayoutPanel();
            this.pnButtons = new Guna.UI2.WinForms.Guna2Panel();
            this.pnCart = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnClean = new Guna.UI2.WinForms.Guna2Button();
            this.btnCart = new Guna.UI2.WinForms.Guna2Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpGoods = new System.Windows.Forms.TableLayoutPanel();
            this.pnCartWrapper = new Guna.UI2.WinForms.Guna2Panel();
            this.pnCartBody = new Guna.UI2.WinForms.Guna2Panel();
            this.horizontalLine = new Guna.UI2.WinForms.Guna2Panel();
            this.pnCartFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCleanCart = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tlpWrapper.SuspendLayout();
            this.pnButtons.SuspendLayout();
            this.pnCart.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnCartWrapper.SuspendLayout();
            this.pnCartFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpWrapper
            // 
            this.tlpWrapper.ColumnCount = 1;
            this.tlpWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWrapper.Controls.Add(this.pnButtons, 0, 0);
            this.tlpWrapper.Controls.Add(this.tlpMain, 0, 1);
            this.tlpWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWrapper.Location = new System.Drawing.Point(0, 0);
            this.tlpWrapper.Name = "tlpWrapper";
            this.tlpWrapper.RowCount = 2;
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.tlpWrapper.Size = new System.Drawing.Size(1156, 721);
            this.tlpWrapper.TabIndex = 0;
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.pnCart);
            this.pnButtons.Controls.Add(this.btnBack);
            this.pnButtons.Controls.Add(this.btnClean);
            this.pnButtons.Controls.Add(this.btnCart);
            this.pnButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnButtons.Location = new System.Drawing.Point(3, 3);
            this.pnButtons.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Padding = new System.Windows.Forms.Padding(5);
            this.pnButtons.ShadowDecoration.Parent = this.pnButtons;
            this.pnButtons.Size = new System.Drawing.Size(1150, 61);
            this.pnButtons.TabIndex = 0;
            // 
            // pnCart
            // 
            this.pnCart.AutoRoundedCorners = true;
            this.pnCart.BorderRadius = 24;
            this.pnCart.Controls.Add(this.label1);
            this.pnCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.pnCart.Location = new System.Drawing.Point(874, 5);
            this.pnCart.Name = "pnCart";
            this.pnCart.ShadowDecoration.Parent = this.pnCart;
            this.pnCart.Size = new System.Drawing.Size(111, 51);
            this.pnCart.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label1.Size = new System.Drawing.Size(111, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 24;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.DisabledState.Parent = this.btnBack;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnBack.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(132, 5);
            this.btnBack.Margin = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(160, 51);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back to Home";
            this.btnBack.TextOffset = new System.Drawing.Point(0, -2);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClean
            // 
            this.btnClean.Animated = true;
            this.btnClean.AutoRoundedCorners = true;
            this.btnClean.BackColor = System.Drawing.Color.Transparent;
            this.btnClean.BorderRadius = 24;
            this.btnClean.CheckedState.Parent = this.btnClean;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.CustomImages.Parent = this.btnClean;
            this.btnClean.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClean.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClean.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClean.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClean.DisabledState.Parent = this.btnClean;
            this.btnClean.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClean.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnClean.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnClean.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnClean.HoverState.Parent = this.btnClean;
            this.btnClean.Location = new System.Drawing.Point(5, 5);
            this.btnClean.Margin = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.btnClean.Name = "btnClean";
            this.btnClean.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnClean.ShadowDecoration.Parent = this.btnClean;
            this.btnClean.Size = new System.Drawing.Size(127, 51);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Clean";
            this.btnClean.TextOffset = new System.Drawing.Point(0, -2);
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnCart
            // 
            this.btnCart.Animated = true;
            this.btnCart.AutoRoundedCorners = true;
            this.btnCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCart.BorderRadius = 24;
            this.btnCart.CheckedState.Parent = this.btnCart;
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.CustomImages.Parent = this.btnCart;
            this.btnCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCart.DisabledState.Parent = this.btnCart;
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnCart.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnCart.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCart.HoverState.Parent = this.btnCart;
            this.btnCart.Location = new System.Drawing.Point(985, 5);
            this.btnCart.Margin = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.btnCart.Name = "btnCart";
            this.btnCart.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnCart.ShadowDecoration.Parent = this.btnCart;
            this.btnCart.Size = new System.Drawing.Size(160, 51);
            this.btnCart.TabIndex = 4;
            this.btnCart.Text = "Go to Cart";
            this.btnCart.TextOffset = new System.Drawing.Point(0, -2);
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.34783F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.65217F));
            this.tlpMain.Controls.Add(this.guna2Panel1, 0, 0);
            this.tlpMain.Controls.Add(this.pnCartWrapper, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(3, 67);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 651F));
            this.tlpMain.Size = new System.Drawing.Size(1150, 651);
            this.tlpMain.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.Controls.Add(this.tlpGoods);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(487, 651);
            this.guna2Panel1.TabIndex = 0;
            // 
            // tlpGoods
            // 
            this.tlpGoods.ColumnCount = 1;
            this.tlpGoods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpGoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpGoods.Location = new System.Drawing.Point(0, 0);
            this.tlpGoods.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tlpGoods.Name = "tlpGoods";
            this.tlpGoods.RowCount = 1;
            this.tlpGoods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpGoods.Size = new System.Drawing.Size(487, 463);
            this.tlpGoods.TabIndex = 1;
            // 
            // pnCartWrapper
            // 
            this.pnCartWrapper.Controls.Add(this.pnCartBody);
            this.pnCartWrapper.Controls.Add(this.horizontalLine);
            this.pnCartWrapper.Controls.Add(this.pnCartFooter);
            this.pnCartWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCartWrapper.Location = new System.Drawing.Point(490, 3);
            this.pnCartWrapper.Name = "pnCartWrapper";
            this.pnCartWrapper.ShadowDecoration.Parent = this.pnCartWrapper;
            this.pnCartWrapper.Size = new System.Drawing.Size(657, 645);
            this.pnCartWrapper.TabIndex = 1;
            // 
            // pnCartBody
            // 
            this.pnCartBody.AutoScroll = true;
            this.pnCartBody.BackColor = System.Drawing.Color.Transparent;
            this.pnCartBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCartBody.Location = new System.Drawing.Point(0, 0);
            this.pnCartBody.Name = "pnCartBody";
            this.pnCartBody.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnCartBody.ShadowDecoration.Parent = this.pnCartBody;
            this.pnCartBody.Size = new System.Drawing.Size(657, 594);
            this.pnCartBody.TabIndex = 4;
            // 
            // horizontalLine
            // 
            this.horizontalLine.AutoRoundedCorners = true;
            this.horizontalLine.BackColor = System.Drawing.Color.Transparent;
            this.horizontalLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalLine.FillColor = System.Drawing.Color.Red;
            this.horizontalLine.Location = new System.Drawing.Point(0, 594);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.ShadowDecoration.Parent = this.horizontalLine;
            this.horizontalLine.Size = new System.Drawing.Size(657, 1);
            this.horizontalLine.TabIndex = 3;
            // 
            // pnCartFooter
            // 
            this.pnCartFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnCartFooter.Controls.Add(this.btnCleanCart);
            this.pnCartFooter.Controls.Add(this.label3);
            this.pnCartFooter.Controls.Add(this.lbTotalPrice);
            this.pnCartFooter.Controls.Add(this.btnCheckout);
            this.pnCartFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCartFooter.FillColor = System.Drawing.Color.Black;
            this.pnCartFooter.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnCartFooter.ForeColor = System.Drawing.Color.Black;
            this.pnCartFooter.Location = new System.Drawing.Point(0, 595);
            this.pnCartFooter.Name = "pnCartFooter";
            this.pnCartFooter.Padding = new System.Windows.Forms.Padding(10, 10, 10, 4);
            this.pnCartFooter.ShadowDecoration.Parent = this.pnCartFooter;
            this.pnCartFooter.Size = new System.Drawing.Size(657, 50);
            this.pnCartFooter.TabIndex = 2;
            // 
            // btnCleanCart
            // 
            this.btnCleanCart.Animated = true;
            this.btnCleanCart.AutoRoundedCorners = true;
            this.btnCleanCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCleanCart.BorderRadius = 17;
            this.btnCleanCart.CheckedState.Parent = this.btnCleanCart;
            this.btnCleanCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleanCart.CustomImages.Parent = this.btnCleanCart;
            this.btnCleanCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCleanCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCleanCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCleanCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCleanCart.DisabledState.Parent = this.btnCleanCart;
            this.btnCleanCart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCleanCart.Enabled = false;
            this.btnCleanCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnCleanCart.Font = new System.Drawing.Font("Poppins ExtraBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnCleanCart.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCleanCart.HoverState.Parent = this.btnCleanCart;
            this.btnCleanCart.Image = global::Manage_Store.Properties.Resources.clean;
            this.btnCleanCart.ImageOffset = new System.Drawing.Point(-5, -2);
            this.btnCleanCart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCleanCart.Location = new System.Drawing.Point(10, 10);
            this.btnCleanCart.Margin = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.btnCleanCart.Name = "btnCleanCart";
            this.btnCleanCart.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnCleanCart.ShadowDecoration.Parent = this.btnCleanCart;
            this.btnCleanCart.Size = new System.Drawing.Size(160, 36);
            this.btnCleanCart.TabIndex = 6;
            this.btnCleanCart.Text = "Clean Cart";
            this.btnCleanCart.TextOffset = new System.Drawing.Point(-2, -2);
            this.btnCleanCart.Click += new System.EventHandler(this.btnCleanCart_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(193, 10);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(150, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalPrice.Font = new System.Drawing.Font("Roboto Black", 16F, System.Drawing.FontStyle.Bold);
            this.lbTotalPrice.ForeColor = System.Drawing.Color.Salmon;
            this.lbTotalPrice.Location = new System.Drawing.Point(343, 10);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Padding = new System.Windows.Forms.Padding(0, 2, 5, 0);
            this.lbTotalPrice.Size = new System.Drawing.Size(102, 36);
            this.lbTotalPrice.TabIndex = 2;
            this.lbTotalPrice.Text = "0 đ";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Animated = true;
            this.btnCheckout.AutoRoundedCorners = true;
            this.btnCheckout.BorderRadius = 17;
            this.btnCheckout.CheckedState.Parent = this.btnCheckout;
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.CustomImages.Parent = this.btnCheckout;
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.DisabledState.Parent = this.btnCheckout;
            this.btnCheckout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCheckout.Enabled = false;
            this.btnCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheckout.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnCheckout.Font = new System.Drawing.Font("Poppins ExtraBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.HoverState.Parent = this.btnCheckout;
            this.btnCheckout.Image = global::Manage_Store.Properties.Resources.checkout;
            this.btnCheckout.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnCheckout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCheckout.Location = new System.Drawing.Point(445, 10);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.ShadowDecoration.Parent = this.btnCheckout;
            this.btnCheckout.Size = new System.Drawing.Size(202, 36);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.TextOffset = new System.Drawing.Point(-2, 2);
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 721);
            this.Controls.Add(this.tlpWrapper);
            this.Name = "fHome";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.fHome_Load);
            this.tlpWrapper.ResumeLayout(false);
            this.pnButtons.ResumeLayout(false);
            this.pnCart.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.pnCartWrapper.ResumeLayout(false);
            this.pnCartFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpWrapper;
        private Guna.UI2.WinForms.Guna2Panel pnButtons;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tlpGoods;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnClean;
        private Guna.UI2.WinForms.Guna2Button btnCart;
        private Guna.UI2.WinForms.Guna2Panel pnCartWrapper;
        private Guna.UI2.WinForms.Guna2Panel pnCartFooter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalPrice;
        private Guna.UI2.WinForms.Guna2GradientButton btnCheckout;
        private Guna.UI2.WinForms.Guna2Panel pnCart;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnCartBody;
        private Guna.UI2.WinForms.Guna2Panel horizontalLine;
        private Guna.UI2.WinForms.Guna2Button btnCleanCart;
    }
}