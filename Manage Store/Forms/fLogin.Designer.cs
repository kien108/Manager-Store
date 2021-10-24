namespace GUI
{
    partial class fLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.pnRight = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.passwordLine = new System.Windows.Forms.Panel();
            this.phoneNumberLine = new System.Windows.Forms.Panel();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.pbImage2 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pbImage1 = new System.Windows.Forms.PictureBox();
            this.ecForm = new ElipseToolDemo.ElipseControl();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage2)).BeginInit();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.btnClose);
            this.pnRight.Controls.Add(this.btnLogin);
            this.pnRight.Controls.Add(this.lbPassword);
            this.pnRight.Controls.Add(this.passwordLine);
            this.pnRight.Controls.Add(this.phoneNumberLine);
            this.pnRight.Controls.Add(this.pbPassword);
            this.pnRight.Controls.Add(this.pbUsername);
            this.pnRight.Controls.Add(this.txtPassword);
            this.pnRight.Controls.Add(this.txtPhoneNumber);
            this.pnRight.Controls.Add(this.lbPhoneNumber);
            this.pnRight.Controls.Add(this.lbWelcome);
            this.pnRight.Controls.Add(this.pbImage2);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnRight.Location = new System.Drawing.Point(551, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(527, 625);
            this.pnRight.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(487, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 5;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnLogin.Font = new System.Drawing.Font("Poppins Medium", 13F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnLogin.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogin.Location = new System.Drawing.Point(65, 485);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(351, 50);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.SystemColors.Window;
            this.lbPassword.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(154)))), ((int)(((byte)(157)))));
            this.lbPassword.Location = new System.Drawing.Point(100, 371);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(94, 30);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Password";
            // 
            // passwordLine
            // 
            this.passwordLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(150)))));
            this.passwordLine.Location = new System.Drawing.Point(66, 440);
            this.passwordLine.Name = "passwordLine";
            this.passwordLine.Size = new System.Drawing.Size(350, 3);
            this.passwordLine.TabIndex = 6;
            // 
            // phoneNumberLine
            // 
            this.phoneNumberLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(150)))));
            this.phoneNumberLine.Location = new System.Drawing.Point(66, 339);
            this.phoneNumberLine.Name = "phoneNumberLine";
            this.phoneNumberLine.Size = new System.Drawing.Size(350, 3);
            this.phoneNumberLine.TabIndex = 6;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
            this.pbPassword.Location = new System.Drawing.Point(67, 404);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(30, 26);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 4;
            this.pbPassword.TabStop = false;
            // 
            // pbUsername
            // 
            this.pbUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUsername.Location = new System.Drawing.Point(67, 303);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(30, 26);
            this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsername.TabIndex = 4;
            this.pbUsername.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Poppins", 10F);
            this.txtPassword.Location = new System.Drawing.Point(107, 402);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(309, 25);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Poppins", 14F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(107, 297);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(309, 35);
            this.txtPhoneNumber.TabIndex = 1;
            this.txtPhoneNumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
            this.txtPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhoneNumber_KeyDown);
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(154)))), ((int)(((byte)(157)))));
            this.lbPhoneNumber.Location = new System.Drawing.Point(100, 266);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(140, 30);
            this.lbPhoneNumber.TabIndex = 2;
            this.lbPhoneNumber.Text = "Phone number";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Poppins Medium", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(55)))));
            this.lbWelcome.Location = new System.Drawing.Point(114, 145);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(264, 79);
            this.lbWelcome.TabIndex = 1;
            this.lbWelcome.Text = "WELCOME";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbImage2
            // 
            this.pbImage2.Image = ((System.Drawing.Image)(resources.GetObject("pbImage2.Image")));
            this.pbImage2.Location = new System.Drawing.Point(194, 51);
            this.pbImage2.Name = "pbImage2";
            this.pbImage2.Size = new System.Drawing.Size(95, 80);
            this.pbImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage2.TabIndex = 0;
            this.pbImage2.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            // 
            // pnLeft
            // 
            this.pnLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnLeft.BackgroundImage")));
            this.pnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnLeft.Controls.Add(this.pbImage1);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(533, 625);
            this.pnLeft.TabIndex = 6;
            // 
            // pbImage1
            // 
            this.pbImage1.BackColor = System.Drawing.Color.Transparent;
            this.pbImage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbImage1.BackgroundImage")));
            this.pbImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage1.Location = new System.Drawing.Point(9, 78);
            this.pbImage1.Name = "pbImage1";
            this.pbImage1.Size = new System.Drawing.Size(576, 408);
            this.pbImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage1.TabIndex = 1;
            this.pbImage1.TabStop = false;
            // 
            // ecForm
            // 
            this.ecForm.CornerRadius = 20;
            this.ecForm.TargetControl = this;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1078, 625);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage2)).EndInit();
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel passwordLine;
        private System.Windows.Forms.Panel phoneNumberLine;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.PictureBox pbImage2;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.PictureBox pbImage1;
        private ElipseToolDemo.ElipseControl ecForm;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label lbPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}