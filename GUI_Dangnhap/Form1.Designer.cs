
namespace GUI_Dangnhap
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelDangnhap = new System.Windows.Forms.Panel();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.iconPictureBoxShow = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxHide = new FontAwesome.Sharp.IconPictureBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtMatKhau = new RJCodeAdvance.RJControls.RJTextBox();
            this.cbbNguoiDung = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtTenTaiKhoan = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblMatKhau = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnDangNhap = new RJCodeAdvance.RJControls.RJButton();
            this.lblTenDangNhap = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.pictureDangnhap = new System.Windows.Forms.PictureBox();
            this.pictureBGLOGO = new System.Windows.Forms.PictureBox();
            this.loadingDangNhap = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.guna2ShadowFormLogin = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControlLogin = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelDangnhap.SuspendLayout();
            this.bunifuGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDangnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBGLOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDangnhap
            // 
            this.panelDangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.panelDangnhap.Controls.Add(this.bunifuGroupBox2);
            this.panelDangnhap.Controls.Add(this.btnExit);
            this.panelDangnhap.Controls.Add(this.pictureDangnhap);
            this.panelDangnhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDangnhap.Location = new System.Drawing.Point(410, 0);
            this.panelDangnhap.Name = "panelDangnhap";
            this.panelDangnhap.Size = new System.Drawing.Size(394, 450);
            this.panelDangnhap.TabIndex = 1;
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox2.BorderRadius = 1;
            this.bunifuGroupBox2.BorderThickness = 1;
            this.bunifuGroupBox2.Controls.Add(this.iconPictureBoxShow);
            this.bunifuGroupBox2.Controls.Add(this.iconPictureBoxHide);
            this.bunifuGroupBox2.Controls.Add(this.bunifuLabel3);
            this.bunifuGroupBox2.Controls.Add(this.txtMatKhau);
            this.bunifuGroupBox2.Controls.Add(this.cbbNguoiDung);
            this.bunifuGroupBox2.Controls.Add(this.txtTenTaiKhoan);
            this.bunifuGroupBox2.Controls.Add(this.lblMatKhau);
            this.bunifuGroupBox2.Controls.Add(this.btnDangNhap);
            this.bunifuGroupBox2.Controls.Add(this.lblTenDangNhap);
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(76, 140);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Size = new System.Drawing.Size(253, 298);
            this.bunifuGroupBox2.TabIndex = 4;
            this.bunifuGroupBox2.TabStop = false;
            this.bunifuGroupBox2.Text = "Thông tin đăng nhập";
            // 
            // iconPictureBoxShow
            // 
            this.iconPictureBoxShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.iconPictureBoxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxShow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBoxShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconPictureBoxShow.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBoxShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxShow.IconSize = 20;
            this.iconPictureBoxShow.Location = new System.Drawing.Point(203, 199);
            this.iconPictureBoxShow.Name = "iconPictureBoxShow";
            this.iconPictureBoxShow.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBoxShow.TabIndex = 5;
            this.iconPictureBoxShow.TabStop = false;
            this.iconPictureBoxShow.Click += new System.EventHandler(this.iconPictureBoxShow_Click);
            // 
            // iconPictureBoxHide
            // 
            this.iconPictureBoxHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.iconPictureBoxHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxHide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBoxHide.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconPictureBoxHide.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBoxHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxHide.IconSize = 20;
            this.iconPictureBoxHide.Location = new System.Drawing.Point(203, 199);
            this.iconPictureBoxHide.Name = "iconPictureBoxHide";
            this.iconPictureBoxHide.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBoxHide.TabIndex = 5;
            this.iconPictureBoxHide.TabStop = false;
            this.iconPictureBoxHide.Click += new System.EventHandler(this.iconPictureBoxHide_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuLabel3.Location = new System.Drawing.Point(27, 22);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(86, 20);
            this.bunifuLabel3.TabIndex = 3;
            this.bunifuLabel3.Text = "Người dùng*";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.txtMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(207)))), ((int)(((byte)(237)))));
            this.txtMatKhau.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtMatKhau.BorderRadius = 0;
            this.txtMatKhau.BorderSize = 2;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(207)))), ((int)(((byte)(237)))));
            this.txtMatKhau.Location = new System.Drawing.Point(27, 191);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMatKhau.PasswordChar = true;
            this.txtMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(200, 31);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.Texts = "";
            this.txtMatKhau.UnderlinedStyle = false;
            // 
            // cbbNguoiDung
            // 
            this.cbbNguoiDung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbNguoiDung.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cbbNguoiDung.BorderSize = 3;
            this.cbbNguoiDung.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbbNguoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbNguoiDung.Font = new System.Drawing.Font("Be Vietnam Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.cbbNguoiDung.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cbbNguoiDung.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên "});
            this.cbbNguoiDung.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbNguoiDung.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.cbbNguoiDung.Location = new System.Drawing.Point(27, 48);
            this.cbbNguoiDung.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbNguoiDung.Name = "cbbNguoiDung";
            this.cbbNguoiDung.Padding = new System.Windows.Forms.Padding(3);
            this.cbbNguoiDung.Size = new System.Drawing.Size(200, 30);
            this.cbbNguoiDung.TabIndex = 4;
            this.cbbNguoiDung.Texts = "Chọn người dùng";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.txtTenTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(207)))), ((int)(((byte)(237)))));
            this.txtTenTaiKhoan.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTenTaiKhoan.BorderRadius = 0;
            this.txtTenTaiKhoan.BorderSize = 2;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(207)))), ((int)(((byte)(237)))));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(27, 118);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTaiKhoan.Multiline = false;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenTaiKhoan.PasswordChar = false;
            this.txtTenTaiKhoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenTaiKhoan.PlaceholderText = "";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(200, 31);
            this.txtTenTaiKhoan.TabIndex = 1;
            this.txtTenTaiKhoan.Texts = "";
            this.txtTenTaiKhoan.UnderlinedStyle = false;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AllowParentOverrides = false;
            this.lblMatKhau.AutoEllipsis = false;
            this.lblMatKhau.CursorType = null;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMatKhau.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMatKhau.Location = new System.Drawing.Point(27, 164);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMatKhau.Size = new System.Drawing.Size(67, 20);
            this.lblMatKhau.TabIndex = 3;
            this.lblMatKhau.Text = "Mật khẩu*";
            this.lblMatKhau.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblMatKhau.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDangNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDangNhap.BorderColor = System.Drawing.Color.Honeydew;
            this.btnDangNhap.BorderRadius = 17;
            this.btnDangNhap.BorderSize = 0;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(27, 248);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(200, 32);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextColor = System.Drawing.Color.White;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AllowParentOverrides = false;
            this.lblTenDangNhap.AutoEllipsis = false;
            this.lblTenDangNhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTenDangNhap.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTenDangNhap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTenDangNhap.Location = new System.Drawing.Point(27, 91);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTenDangNhap.Size = new System.Drawing.Size(95, 20);
            this.lblTenDangNhap.TabIndex = 3;
            this.lblTenDangNhap.Text = "Tên tài khoản*";
            this.lblTenDangNhap.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTenDangNhap.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnExit.IconSize = 35;
            this.btnExit.Location = new System.Drawing.Point(357, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureDangnhap
            // 
            this.pictureDangnhap.Image = global::GUI_Dangnhap.Properties.Resources.Đăng;
            this.pictureDangnhap.Location = new System.Drawing.Point(19, 24);
            this.pictureDangnhap.Name = "pictureDangnhap";
            this.pictureDangnhap.Size = new System.Drawing.Size(360, 110);
            this.pictureDangnhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDangnhap.TabIndex = 2;
            this.pictureDangnhap.TabStop = false;
            // 
            // pictureBGLOGO
            // 
            this.pictureBGLOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBGLOGO.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBGLOGO.Image = global::GUI_Dangnhap.Properties.Resources.BGLOGIN;
            this.pictureBGLOGO.Location = new System.Drawing.Point(0, 0);
            this.pictureBGLOGO.Name = "pictureBGLOGO";
            this.pictureBGLOGO.Size = new System.Drawing.Size(410, 450);
            this.pictureBGLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBGLOGO.TabIndex = 0;
            this.pictureBGLOGO.TabStop = false;
            // 
            // loadingDangNhap
            // 
            this.loadingDangNhap.Animated = false;
            this.loadingDangNhap.AnimationInterval = 1;
            this.loadingDangNhap.AnimationSpeed = 1;
            this.loadingDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.loadingDangNhap.CircleMargin = 10;
            this.loadingDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.loadingDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.loadingDangNhap.IsPercentage = false;
            this.loadingDangNhap.LineProgressThickness = 10;
            this.loadingDangNhap.LineThickness = 10;
            this.loadingDangNhap.Location = new System.Drawing.Point(336, 160);
            this.loadingDangNhap.Name = "loadingDangNhap";
            this.loadingDangNhap.ProgressAnimationSpeed = 200;
            this.loadingDangNhap.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.loadingDangNhap.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(41)))), ((int)(((byte)(138)))));
            this.loadingDangNhap.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.loadingDangNhap.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.loadingDangNhap.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.loadingDangNhap.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.loadingDangNhap.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.loadingDangNhap.Size = new System.Drawing.Size(147, 147);
            this.loadingDangNhap.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loadingDangNhap.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.loadingDangNhap.SubScriptText = "";
            this.loadingDangNhap.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(70)))), ((int)(((byte)(184)))));
            this.loadingDangNhap.SuperScriptMargin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.loadingDangNhap.SuperScriptText = "%";
            this.loadingDangNhap.TabIndex = 16;
            this.loadingDangNhap.Text = "30";
            this.loadingDangNhap.TextMargin = new System.Windows.Forms.Padding(-3, 5, 0, 0);
            this.loadingDangNhap.Value = 30;
            this.loadingDangNhap.ValueByTransition = 30;
            this.loadingDangNhap.ValueMargin = new System.Windows.Forms.Padding(-3, 5, 0, 0);
            // 
            // guna2DragControlLogin
            // 
            this.guna2DragControlLogin.TargetControl = this.pictureBGLOGO;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panelDangnhap;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.pictureDangnhap;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::GUI_Dangnhap.Properties.Resources.bgqlch1;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.loadingDangNhap);
            this.Controls.Add(this.panelDangnhap);
            this.Controls.Add(this.pictureBGLOGO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDangnhap.ResumeLayout(false);
            this.bunifuGroupBox2.ResumeLayout(false);
            this.bunifuGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDangnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBGLOGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBGLOGO;
        private System.Windows.Forms.Panel panelDangnhap;
        private RJCodeAdvance.RJControls.RJTextBox txtMatKhau;
        private RJCodeAdvance.RJControls.RJTextBox txtTenTaiKhoan;
        private RJCodeAdvance.RJControls.RJButton btnDangNhap;
        private Bunifu.UI.WinForms.BunifuLabel lblMatKhau;
        private Bunifu.UI.WinForms.BunifuLabel lblTenDangNhap;
        private RJCodeAdvance.RJControls.RJComboBox cbbNguoiDung;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxHide;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxShow;
        private System.Windows.Forms.PictureBox pictureDangnhap;
        private FontAwesome.Sharp.IconButton btnExit;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
        private Bunifu.UI.WinForms.BunifuCircleProgress loadingDangNhap;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowFormLogin;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControlLogin;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}

