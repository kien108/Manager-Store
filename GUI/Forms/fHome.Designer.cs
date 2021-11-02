
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
            this.btnRenew = new Guna.UI2.WinForms.Guna2Button();
            this.btnCart = new Guna.UI2.WinForms.Guna2Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpGoods = new System.Windows.Forms.TableLayoutPanel();
            this.pnCartWrapper = new Guna.UI2.WinForms.Guna2Panel();
            this.pnCartBody = new Guna.UI2.WinForms.Guna2Panel();
            this.panelGoodsInCart10 = new GUI.DefinedFramework.PanelGoodsInCart();
            this.panelGoodsInCart9 = new GUI.DefinedFramework.PanelGoodsInCart();
            this.panelGoodsInCart8 = new GUI.DefinedFramework.PanelGoodsInCart();
            this.panelGoodsInCart5 = new GUI.DefinedFramework.PanelGoodsInCart();
            this.panelGoodsInCart1 = new GUI.DefinedFramework.PanelGoodsInCart();
            this.panelGoodsInCart7 = new GUI.DefinedFramework.PanelGoodsInCart();
            this.panelGoodsInCart6 = new GUI.DefinedFramework.PanelGoodsInCart();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnCartFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tlpWrapper.SuspendLayout();
            this.pnButtons.SuspendLayout();
            this.pnCart.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnCartWrapper.SuspendLayout();
            this.pnCartBody.SuspendLayout();
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
            this.pnButtons.Controls.Add(this.btnRenew);
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
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(111, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 10;
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
            this.btnBack.Location = new System.Drawing.Point(165, 5);
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
            // btnRenew
            // 
            this.btnRenew.Animated = true;
            this.btnRenew.BackColor = System.Drawing.Color.Transparent;
            this.btnRenew.BorderRadius = 10;
            this.btnRenew.CheckedState.Parent = this.btnRenew;
            this.btnRenew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenew.CustomImages.Parent = this.btnRenew;
            this.btnRenew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRenew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRenew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRenew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRenew.DisabledState.Parent = this.btnRenew;
            this.btnRenew.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRenew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnRenew.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnRenew.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnRenew.HoverState.Parent = this.btnRenew;
            this.btnRenew.Location = new System.Drawing.Point(5, 5);
            this.btnRenew.Margin = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnRenew.ShadowDecoration.Parent = this.btnRenew;
            this.btnRenew.Size = new System.Drawing.Size(160, 51);
            this.btnRenew.TabIndex = 5;
            this.btnRenew.Text = "Renew cart";
            this.btnRenew.TextOffset = new System.Drawing.Point(0, -2);
            // 
            // btnCart
            // 
            this.btnCart.Animated = true;
            this.btnCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCart.BorderRadius = 10;
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
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.73913F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.26087F));
            this.tlpMain.Controls.Add(this.guna2Panel1, 0, 0);
            this.tlpMain.Controls.Add(this.pnCartWrapper, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(3, 67);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 643F));
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
            this.guna2Panel1.Size = new System.Drawing.Size(755, 651);
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
            this.tlpGoods.Size = new System.Drawing.Size(755, 463);
            this.tlpGoods.TabIndex = 1;
            this.tlpGoods.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpGoods_Paint);
            // 
            // pnCartWrapper
            // 
            this.pnCartWrapper.Controls.Add(this.pnCartBody);
            this.pnCartWrapper.Controls.Add(this.guna2Panel2);
            this.pnCartWrapper.Controls.Add(this.pnCartFooter);
            this.pnCartWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCartWrapper.Location = new System.Drawing.Point(758, 3);
            this.pnCartWrapper.Name = "pnCartWrapper";
            this.pnCartWrapper.ShadowDecoration.Parent = this.pnCartWrapper;
            this.pnCartWrapper.Size = new System.Drawing.Size(389, 645);
            this.pnCartWrapper.TabIndex = 1;
            // 
            // pnCartBody
            // 
            this.pnCartBody.AutoScroll = true;
            this.pnCartBody.BackColor = System.Drawing.Color.Transparent;
            this.pnCartBody.Controls.Add(this.panelGoodsInCart10);
            this.pnCartBody.Controls.Add(this.panelGoodsInCart9);
            this.pnCartBody.Controls.Add(this.panelGoodsInCart8);
            this.pnCartBody.Controls.Add(this.panelGoodsInCart5);
            this.pnCartBody.Controls.Add(this.panelGoodsInCart1);
            this.pnCartBody.Controls.Add(this.panelGoodsInCart7);
            this.pnCartBody.Controls.Add(this.panelGoodsInCart6);
            this.pnCartBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCartBody.Location = new System.Drawing.Point(0, 0);
            this.pnCartBody.Name = "pnCartBody";
            this.pnCartBody.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnCartBody.ShadowDecoration.Parent = this.pnCartBody;
            this.pnCartBody.Size = new System.Drawing.Size(389, 594);
            this.pnCartBody.TabIndex = 4;
            // 
            // panelGoodsInCart10
            // 
            this.panelGoodsInCart10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.panelGoodsInCart10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGoodsInCart10.Location = new System.Drawing.Point(5, 450);
            this.panelGoodsInCart10.Name = "panelGoodsInCart10";
            this.panelGoodsInCart10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panelGoodsInCart10.Size = new System.Drawing.Size(379, 75);
            this.panelGoodsInCart10.TabIndex = 14;
            // 
            // panelGoodsInCart9
            // 
            this.panelGoodsInCart9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.panelGoodsInCart9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGoodsInCart9.Location = new System.Drawing.Point(5, 375);
            this.panelGoodsInCart9.Name = "panelGoodsInCart9";
            this.panelGoodsInCart9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panelGoodsInCart9.Size = new System.Drawing.Size(379, 75);
            this.panelGoodsInCart9.TabIndex = 13;
            // 
            // panelGoodsInCart8
            // 
            this.panelGoodsInCart8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.panelGoodsInCart8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGoodsInCart8.Location = new System.Drawing.Point(5, 300);
            this.panelGoodsInCart8.Name = "panelGoodsInCart8";
            this.panelGoodsInCart8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panelGoodsInCart8.Size = new System.Drawing.Size(379, 75);
            this.panelGoodsInCart8.TabIndex = 12;
            // 
            // panelGoodsInCart5
            // 
            this.panelGoodsInCart5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.panelGoodsInCart5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGoodsInCart5.Location = new System.Drawing.Point(5, 225);
            this.panelGoodsInCart5.Name = "panelGoodsInCart5";
            this.panelGoodsInCart5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panelGoodsInCart5.Size = new System.Drawing.Size(379, 75);
            this.panelGoodsInCart5.TabIndex = 11;
            // 
            // panelGoodsInCart1
            // 
            this.panelGoodsInCart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.panelGoodsInCart1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGoodsInCart1.Location = new System.Drawing.Point(5, 150);
            this.panelGoodsInCart1.Name = "panelGoodsInCart1";
            this.panelGoodsInCart1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panelGoodsInCart1.Size = new System.Drawing.Size(379, 75);
            this.panelGoodsInCart1.TabIndex = 7;
            // 
            // panelGoodsInCart7
            // 
            this.panelGoodsInCart7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.panelGoodsInCart7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGoodsInCart7.Location = new System.Drawing.Point(5, 75);
            this.panelGoodsInCart7.Name = "panelGoodsInCart7";
            this.panelGoodsInCart7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panelGoodsInCart7.Size = new System.Drawing.Size(379, 75);
            this.panelGoodsInCart7.TabIndex = 6;
            // 
            // panelGoodsInCart6
            // 
            this.panelGoodsInCart6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.panelGoodsInCart6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGoodsInCart6.Location = new System.Drawing.Point(5, 0);
            this.panelGoodsInCart6.Name = "panelGoodsInCart6";
            this.panelGoodsInCart6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panelGoodsInCart6.Size = new System.Drawing.Size(379, 75);
            this.panelGoodsInCart6.TabIndex = 5;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoRoundedCorners = true;
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.FillColor = System.Drawing.Color.Red;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 594);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(389, 1);
            this.guna2Panel2.TabIndex = 3;
            // 
            // pnCartFooter
            // 
            this.pnCartFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnCartFooter.Controls.Add(this.label3);
            this.pnCartFooter.Controls.Add(this.label2);
            this.pnCartFooter.Controls.Add(this.guna2GradientButton1);
            this.pnCartFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCartFooter.FillColor = System.Drawing.Color.Black;
            this.pnCartFooter.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnCartFooter.ForeColor = System.Drawing.Color.Black;
            this.pnCartFooter.Location = new System.Drawing.Point(0, 595);
            this.pnCartFooter.Name = "pnCartFooter";
            this.pnCartFooter.Padding = new System.Windows.Forms.Padding(10, 10, 10, 4);
            this.pnCartFooter.ShadowDecoration.Parent = this.pnCartFooter;
            this.pnCartFooter.Size = new System.Drawing.Size(389, 50);
            this.pnCartFooter.TabIndex = 2;
            this.pnCartFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCartFooter_Paint);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-75, 10);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(150, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Roboto Black", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(75, 10);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label2.Size = new System.Drawing.Size(102, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "65.000 đ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BorderRadius = 17;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.DisabledState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Poppins ExtraBold", 14F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(177, 10);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(202, 36);
            this.guna2GradientButton1.TabIndex = 1;
            this.guna2GradientButton1.Text = "Checkout";
            this.guna2GradientButton1.TextOffset = new System.Drawing.Point(0, 2);
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
            this.pnCartBody.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Button btnRenew;
        private Guna.UI2.WinForms.Guna2Button btnCart;
        private Guna.UI2.WinForms.Guna2Panel pnCartWrapper;
        private Guna.UI2.WinForms.Guna2Panel pnCartFooter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2Panel pnCart;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnCartBody;
        private DefinedFramework.PanelGoodsInCart panelGoodsInCart10;
        private DefinedFramework.PanelGoodsInCart panelGoodsInCart9;
        private DefinedFramework.PanelGoodsInCart panelGoodsInCart8;
        private DefinedFramework.PanelGoodsInCart panelGoodsInCart5;
        private DefinedFramework.PanelGoodsInCart panelGoodsInCart1;
        private DefinedFramework.PanelGoodsInCart panelGoodsInCart7;
        private DefinedFramework.PanelGoodsInCart panelGoodsInCart6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}