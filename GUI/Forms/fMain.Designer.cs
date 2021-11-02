
namespace GUI
{
    partial class fMain
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
            this.pnLogo = new System.Windows.Forms.Panel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnAccount = new Guna.UI2.WinForms.Guna2Panel();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnNav = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.pnScreen = new Guna.UI2.WinForms.Guna2Panel();
            this.pnHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pnWindowButton = new System.Windows.Forms.Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.pnNav.SuspendLayout();
            this.pnContainer.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.pnWindowButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogo
            // 
            this.pnLogo.AutoSize = true;
            this.pnLogo.Controls.Add(this.lbLogo);
            this.pnLogo.Controls.Add(this.pbLogo);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 5);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(10, 10, 10, 40);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.pnLogo.Size = new System.Drawing.Size(200, 106);
            this.pnLogo.TabIndex = 3;
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Font = new System.Drawing.Font("Poppins Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lbLogo.Location = new System.Drawing.Point(104, 3);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(204, 53);
            this.lbLogo.TabIndex = 1;
            this.lbLogo.Text = "WIBU MART";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Manage_Store.Properties.Resources.logo_yellow;
            this.pbLogo.Location = new System.Drawing.Point(15, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(54, 45);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnAccount
            // 
            this.pnAccount.BackColor = System.Drawing.Color.Transparent;
            this.pnAccount.BorderRadius = 5;
            this.pnAccount.Controls.Add(this.lbRole);
            this.pnAccount.Controls.Add(this.lbName);
            this.pnAccount.Controls.Add(this.pbAvatar);
            this.pnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnAccount.Location = new System.Drawing.Point(0, 519);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Padding = new System.Windows.Forms.Padding(10);
            this.pnAccount.ShadowDecoration.Parent = this.pnAccount;
            this.pnAccount.Size = new System.Drawing.Size(200, 79);
            this.pnAccount.TabIndex = 1;
            this.pnAccount.UseTransparentBackground = true;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.BackColor = System.Drawing.Color.Transparent;
            this.lbRole.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lbRole.Location = new System.Drawing.Point(87, 45);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(63, 20);
            this.lbRole.TabIndex = 2;
            this.lbRole.Text = "ADMIN";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lbName.Location = new System.Drawing.Point(86, 17);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(215, 24);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "NGUYEN QUANG VINH";
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pbAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbAvatar.Image = global::Manage_Store.Properties.Resources.avatar;
            this.pbAvatar.ImageRotate = 0F;
            this.pbAvatar.Location = new System.Drawing.Point(10, 10);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.ShadowDecoration.Parent = this.pbAvatar;
            this.pbAvatar.Size = new System.Drawing.Size(60, 59);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            // 
            // pnNav
            // 
            this.pnNav.BackColor = System.Drawing.Color.Transparent;
            this.pnNav.Controls.Add(this.pnAccount);
            this.pnNav.Controls.Add(this.pnLogo);
            this.pnNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnNav.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(97)))), ((int)(((byte)(80)))));
            this.pnNav.Location = new System.Drawing.Point(0, 0);
            this.pnNav.Name = "pnNav";
            this.pnNav.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnNav.ShadowDecoration.Parent = this.pnNav;
            this.pnNav.Size = new System.Drawing.Size(200, 603);
            this.pnNav.TabIndex = 2;
            this.pnNav.UseTransparentBackground = true;
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.White;
            this.pnContainer.Controls.Add(this.pnScreen);
            this.pnContainer.Controls.Add(this.pnHeader);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnContainer.Location = new System.Drawing.Point(200, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(777, 603);
            this.pnContainer.TabIndex = 3;
            // 
            // pnScreen
            // 
            this.pnScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.pnScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnScreen.Location = new System.Drawing.Point(0, 78);
            this.pnScreen.Name = "pnScreen";
            this.pnScreen.ShadowDecoration.Parent = this.pnScreen;
            this.pnScreen.Size = new System.Drawing.Size(777, 525);
            this.pnScreen.TabIndex = 2;
            this.pnScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.pnScreen_Paint);
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.SystemColors.Window;
            this.pnHeader.Controls.Add(this.pnWindowButton);
            this.pnHeader.Controls.Add(this.lbHeader);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.ShadowDecoration.Parent = this.pnHeader;
            this.pnHeader.Size = new System.Drawing.Size(777, 78);
            this.pnHeader.TabIndex = 1;
            // 
            // pnWindowButton
            // 
            this.pnWindowButton.BackColor = System.Drawing.Color.Transparent;
            this.pnWindowButton.Controls.Add(this.btnMinimize);
            this.pnWindowButton.Controls.Add(this.btnClose);
            this.pnWindowButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnWindowButton.Location = new System.Drawing.Point(683, 0);
            this.pnWindowButton.Name = "pnWindowButton";
            this.pnWindowButton.Size = new System.Drawing.Size(94, 78);
            this.pnWindowButton.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Animated = true;
            this.btnMinimize.BorderRadius = 5;
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.DisabledState.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = global::Manage_Store.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(12, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 5;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.DisabledState.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::Manage_Store.Properties.Resources.close;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(54, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbHeader.Font = new System.Drawing.Font("Poppins Black", 22F, System.Drawing.FontStyle.Bold);
            this.lbHeader.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Padding = new System.Windows.Forms.Padding(20, 3, 0, 0);
            this.lbHeader.Size = new System.Drawing.Size(286, 78);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "HOME";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 603);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.pnNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.Text = "fMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fMain_Load);
            this.SizeChanged += new System.EventHandler(this.fMain_SizeChanged);
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnAccount.ResumeLayout(false);
            this.pnAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.pnNav.ResumeLayout(false);
            this.pnNav.PerformLayout();
            this.pnContainer.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pnWindowButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbLogo;
        private Guna.UI2.WinForms.Guna2Panel pnAccount;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2PictureBox pbAvatar;
        private Guna.UI2.WinForms.Guna2Panel pnNav;
        private System.Windows.Forms.Panel pnContainer;
        private Guna.UI2.WinForms.Guna2Panel pnScreen;
        private Guna.UI2.WinForms.Guna2Panel pnHeader;
        private System.Windows.Forms.Panel pnWindowButton;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lbHeader;
    }
}