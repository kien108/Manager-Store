
namespace GUI.DefinedFramework
{
    partial class GoodsCell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsCell));
            this.tlpWrapper = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.pnImage = new Guna.UI2.WinForms.Guna2Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.tlpPriceAndQuantity = new System.Windows.Forms.TableLayoutPanel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pnQuantity = new Guna.UI2.WinForms.Guna2Panel();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPlus = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinus = new Guna.UI2.WinForms.Guna2Button();
            this.ecCell = new ElipseToolDemo.ElipseControl();
            this.tlpWrapper.SuspendLayout();
            this.tlpPriceAndQuantity.SuspendLayout();
            this.pnQuantity.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpWrapper
            // 
            this.tlpWrapper.ColumnCount = 1;
            this.tlpWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWrapper.Controls.Add(this.btnAddToCart, 0, 3);
            this.tlpWrapper.Controls.Add(this.pnImage, 0, 0);
            this.tlpWrapper.Controls.Add(this.lbName, 0, 1);
            this.tlpWrapper.Controls.Add(this.tlpPriceAndQuantity, 0, 2);
            this.tlpWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWrapper.Location = new System.Drawing.Point(0, 0);
            this.tlpWrapper.Name = "tlpWrapper";
            this.tlpWrapper.RowCount = 4;
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59F));
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpWrapper.Size = new System.Drawing.Size(300, 350);
            this.tlpWrapper.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Animated = true;
            this.btnAddToCart.BorderRadius = 10;
            this.btnAddToCart.CheckedState.Parent = this.btnAddToCart;
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.CustomImages.Parent = this.btnAddToCart;
            this.btnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToCart.DisabledState.Parent = this.btnAddToCart;
            this.btnAddToCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddToCart.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.Parent = this.btnAddToCart;
            this.btnAddToCart.Location = new System.Drawing.Point(5, 284);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.ShadowDecoration.Parent = this.btnAddToCart;
            this.btnAddToCart.Size = new System.Drawing.Size(290, 61);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.TextOffset = new System.Drawing.Point(0, 2);
            // 
            // pnImage
            // 
            this.pnImage.BackColor = System.Drawing.Color.White;
            this.pnImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnImage.BackgroundImage")));
            this.pnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnImage.Location = new System.Drawing.Point(3, 3);
            this.pnImage.Name = "pnImage";
            this.pnImage.ShadowDecoration.Parent = this.pnImage;
            this.pnImage.Size = new System.Drawing.Size(294, 200);
            this.pnImage.TabIndex = 0;
            this.pnImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnImage_Paint);
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(10, 206);
            this.lbName.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(280, 24);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Mì Hảo Hảo tôm chua cay 75g";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpPriceAndQuantity
            // 
            this.tlpPriceAndQuantity.ColumnCount = 2;
            this.tlpPriceAndQuantity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tlpPriceAndQuantity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tlpPriceAndQuantity.Controls.Add(this.lbPrice, 0, 0);
            this.tlpPriceAndQuantity.Controls.Add(this.pnQuantity, 1, 0);
            this.tlpPriceAndQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPriceAndQuantity.Location = new System.Drawing.Point(10, 235);
            this.tlpPriceAndQuantity.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.tlpPriceAndQuantity.Name = "tlpPriceAndQuantity";
            this.tlpPriceAndQuantity.RowCount = 1;
            this.tlpPriceAndQuantity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPriceAndQuantity.Size = new System.Drawing.Size(280, 44);
            this.tlpPriceAndQuantity.TabIndex = 6;
            // 
            // lbPrice
            // 
            this.lbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPrice.Font = new System.Drawing.Font("Roboto Medium", 12.5F, System.Drawing.FontStyle.Bold);
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(0, 0);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(145, 44);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "6,000 đ";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnQuantity
            // 
            this.pnQuantity.AutoRoundedCorners = true;
            this.pnQuantity.BorderRadius = 18;
            this.pnQuantity.Controls.Add(this.txtQuantity);
            this.pnQuantity.Controls.Add(this.btnPlus);
            this.pnQuantity.Controls.Add(this.btnMinus);
            this.pnQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnQuantity.FillColor = System.Drawing.Color.White;
            this.pnQuantity.Location = new System.Drawing.Point(151, 3);
            this.pnQuantity.Name = "pnQuantity";
            this.pnQuantity.ShadowDecoration.Parent = this.pnQuantity;
            this.pnQuantity.Size = new System.Drawing.Size(126, 38);
            this.pnQuantity.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "0";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.Parent = this.txtQuantity;
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtQuantity.FocusedState.Parent = this.txtQuantity;
            this.txtQuantity.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtQuantity.HoverState.Parent = this.txtQuantity;
            this.txtQuantity.Location = new System.Drawing.Point(18, 0);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionStart = 1;
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(90, 38);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // btnPlus
            // 
            this.btnPlus.Animated = true;
            this.btnPlus.AutoRoundedCorners = true;
            this.btnPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnPlus.BorderRadius = 8;
            this.btnPlus.CheckedState.Parent = this.btnPlus;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.CustomImages.Parent = this.btnPlus;
            this.btnPlus.CustomizableEdges.BottomLeft = false;
            this.btnPlus.CustomizableEdges.TopLeft = false;
            this.btnPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlus.DisabledState.Parent = this.btnPlus;
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.HoverState.Parent = this.btnPlus;
            this.btnPlus.Image = global::Manage_Store.Properties.Resources.plus;
            this.btnPlus.ImageSize = new System.Drawing.Size(15, 15);
            this.btnPlus.Location = new System.Drawing.Point(108, 0);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.ShadowDecoration.Parent = this.btnPlus;
            this.btnPlus.Size = new System.Drawing.Size(18, 38);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Animated = true;
            this.btnMinus.AutoRoundedCorners = true;
            this.btnMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnMinus.BorderRadius = 8;
            this.btnMinus.CheckedState.Parent = this.btnMinus;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.CustomImages.Parent = this.btnMinus;
            this.btnMinus.CustomizableEdges.BottomRight = false;
            this.btnMinus.CustomizableEdges.TopRight = false;
            this.btnMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinus.DisabledState.Parent = this.btnMinus;
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.HoverState.Parent = this.btnMinus;
            this.btnMinus.Image = global::Manage_Store.Properties.Resources.minus;
            this.btnMinus.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnMinus.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinus.Location = new System.Drawing.Point(0, 0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.ShadowDecoration.Parent = this.btnMinus;
            this.btnMinus.Size = new System.Drawing.Size(18, 38);
            this.btnMinus.TabIndex = 0;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // ecCell
            // 
            this.ecCell.CornerRadius = 11;
            this.ecCell.TargetControl = this;
            // 
            // GoodsCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.tlpWrapper);
            this.Name = "GoodsCell";
            this.Size = new System.Drawing.Size(300, 350);
            this.tlpWrapper.ResumeLayout(false);
            this.tlpPriceAndQuantity.ResumeLayout(false);
            this.pnQuantity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpWrapper;
        private Guna.UI2.WinForms.Guna2Panel pnImage;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TableLayoutPanel tlpPriceAndQuantity;
        private System.Windows.Forms.Label lbPrice;
        private Guna.UI2.WinForms.Guna2Panel pnQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2Button btnPlus;
        private Guna.UI2.WinForms.Guna2Button btnMinus;
        private ElipseToolDemo.ElipseControl ecCell;
        public Guna.UI2.WinForms.Guna2Button btnAddToCart;
    }
}
