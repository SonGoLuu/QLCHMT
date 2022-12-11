
namespace GUI_Dangnhap
{
    partial class FormMainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainUI));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowFormMain = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconBtnLogout = new FontAwesome.Sharp.IconButton();
            this.iconBtnThongKe = new FontAwesome.Sharp.IconButton();
            this.iconBtnBaoHanh = new FontAwesome.Sharp.IconButton();
            this.iconBtnQLPN = new FontAwesome.Sharp.IconButton();
            this.iconBtnQLNCC = new FontAwesome.Sharp.IconButton();
            this.iconBtnQLHD = new FontAwesome.Sharp.IconButton();
            this.iconBtnQLSP = new FontAwesome.Sharp.IconButton();
            this.iconBtnQLKH = new FontAwesome.Sharp.IconButton();
            this.iconBtnQLNV = new FontAwesome.Sharp.IconButton();
            this.iconBtnQLTK = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.bunifuPanelTitle = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.iconbtnExit = new FontAwesome.Sharp.IconButton();
            this.panel3.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.bunifuPanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panel3.Controls.Add(this.panelMenu);
            this.panel3.Controls.Add(this.panelLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 540);
            this.panel3.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.panelMenu.Controls.Add(this.iconBtnLogout);
            this.panelMenu.Controls.Add(this.iconBtnThongKe);
            this.panelMenu.Controls.Add(this.iconBtnBaoHanh);
            this.panelMenu.Controls.Add(this.iconBtnQLPN);
            this.panelMenu.Controls.Add(this.iconBtnQLNCC);
            this.panelMenu.Controls.Add(this.iconBtnQLHD);
            this.panelMenu.Controls.Add(this.iconBtnQLSP);
            this.panelMenu.Controls.Add(this.iconBtnQLKH);
            this.panelMenu.Controls.Add(this.iconBtnQLNV);
            this.panelMenu.Controls.Add(this.iconBtnQLTK);
            this.panelMenu.Location = new System.Drawing.Point(0, 89);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(217, 448);
            this.panelMenu.TabIndex = 1;
            // 
            // iconBtnLogout
            // 
            this.iconBtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnLogout.FlatAppearance.BorderSize = 0;
            this.iconBtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconBtnLogout.IconColor = System.Drawing.Color.White;
            this.iconBtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnLogout.IconSize = 40;
            this.iconBtnLogout.Location = new System.Drawing.Point(174, 403);
            this.iconBtnLogout.Name = "iconBtnLogout";
            this.iconBtnLogout.Size = new System.Drawing.Size(40, 34);
            this.iconBtnLogout.TabIndex = 1;
            this.iconBtnLogout.UseVisualStyleBackColor = true;
            this.iconBtnLogout.Click += new System.EventHandler(this.iconButton11_Click);
            // 
            // iconBtnThongKe
            // 
            this.iconBtnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnThongKe.FlatAppearance.BorderSize = 0;
            this.iconBtnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnThongKe.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnThongKe.ForeColor = System.Drawing.Color.White;
            this.iconBtnThongKe.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconBtnThongKe.IconColor = System.Drawing.Color.White;
            this.iconBtnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnThongKe.IconSize = 40;
            this.iconBtnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnThongKe.Location = new System.Drawing.Point(0, 352);
            this.iconBtnThongKe.Name = "iconBtnThongKe";
            this.iconBtnThongKe.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnThongKe.Size = new System.Drawing.Size(217, 44);
            this.iconBtnThongKe.TabIndex = 0;
            this.iconBtnThongKe.Text = "  Thống Kê, Báo Cáo";
            this.iconBtnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnThongKe.UseVisualStyleBackColor = true;
            this.iconBtnThongKe.Click += new System.EventHandler(this.iconButton10_Click);
            // 
            // iconBtnBaoHanh
            // 
            this.iconBtnBaoHanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnBaoHanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnBaoHanh.FlatAppearance.BorderSize = 0;
            this.iconBtnBaoHanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnBaoHanh.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnBaoHanh.ForeColor = System.Drawing.Color.White;
            this.iconBtnBaoHanh.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.iconBtnBaoHanh.IconColor = System.Drawing.Color.White;
            this.iconBtnBaoHanh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnBaoHanh.IconSize = 40;
            this.iconBtnBaoHanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnBaoHanh.Location = new System.Drawing.Point(0, 308);
            this.iconBtnBaoHanh.Name = "iconBtnBaoHanh";
            this.iconBtnBaoHanh.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnBaoHanh.Size = new System.Drawing.Size(217, 44);
            this.iconBtnBaoHanh.TabIndex = 0;
            this.iconBtnBaoHanh.Text = "  Bảo Hành";
            this.iconBtnBaoHanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnBaoHanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnBaoHanh.UseVisualStyleBackColor = true;
            this.iconBtnBaoHanh.Click += new System.EventHandler(this.iconButton9_Click);
            // 
            // iconBtnQLPN
            // 
            this.iconBtnQLPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnQLPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnQLPN.FlatAppearance.BorderSize = 0;
            this.iconBtnQLPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQLPN.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnQLPN.ForeColor = System.Drawing.Color.White;
            this.iconBtnQLPN.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.iconBtnQLPN.IconColor = System.Drawing.Color.White;
            this.iconBtnQLPN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnQLPN.IconSize = 40;
            this.iconBtnQLPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLPN.Location = new System.Drawing.Point(0, 264);
            this.iconBtnQLPN.Name = "iconBtnQLPN";
            this.iconBtnQLPN.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnQLPN.Size = new System.Drawing.Size(217, 44);
            this.iconBtnQLPN.TabIndex = 0;
            this.iconBtnQLPN.Text = "  Quản Lý Phiếu Nhập";
            this.iconBtnQLPN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLPN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQLPN.UseVisualStyleBackColor = true;
            this.iconBtnQLPN.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // iconBtnQLNCC
            // 
            this.iconBtnQLNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnQLNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnQLNCC.FlatAppearance.BorderSize = 0;
            this.iconBtnQLNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQLNCC.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnQLNCC.ForeColor = System.Drawing.Color.White;
            this.iconBtnQLNCC.IconChar = FontAwesome.Sharp.IconChar.ShippingFast;
            this.iconBtnQLNCC.IconColor = System.Drawing.Color.White;
            this.iconBtnQLNCC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnQLNCC.IconSize = 40;
            this.iconBtnQLNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLNCC.Location = new System.Drawing.Point(0, 220);
            this.iconBtnQLNCC.Name = "iconBtnQLNCC";
            this.iconBtnQLNCC.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnQLNCC.Size = new System.Drawing.Size(217, 44);
            this.iconBtnQLNCC.TabIndex = 0;
            this.iconBtnQLNCC.Text = "  Quản Lý Nhà Cung Cấp";
            this.iconBtnQLNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQLNCC.UseVisualStyleBackColor = true;
            this.iconBtnQLNCC.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // iconBtnQLHD
            // 
            this.iconBtnQLHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnQLHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnQLHD.FlatAppearance.BorderSize = 0;
            this.iconBtnQLHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQLHD.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnQLHD.ForeColor = System.Drawing.Color.White;
            this.iconBtnQLHD.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.iconBtnQLHD.IconColor = System.Drawing.Color.White;
            this.iconBtnQLHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnQLHD.IconSize = 40;
            this.iconBtnQLHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLHD.Location = new System.Drawing.Point(0, 176);
            this.iconBtnQLHD.Name = "iconBtnQLHD";
            this.iconBtnQLHD.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnQLHD.Size = new System.Drawing.Size(217, 44);
            this.iconBtnQLHD.TabIndex = 0;
            this.iconBtnQLHD.Text = "  Quản Lý Hóa Đơn";
            this.iconBtnQLHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQLHD.UseVisualStyleBackColor = true;
            this.iconBtnQLHD.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconBtnQLSP
            // 
            this.iconBtnQLSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnQLSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnQLSP.FlatAppearance.BorderSize = 0;
            this.iconBtnQLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQLSP.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnQLSP.ForeColor = System.Drawing.Color.White;
            this.iconBtnQLSP.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.iconBtnQLSP.IconColor = System.Drawing.Color.White;
            this.iconBtnQLSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnQLSP.IconSize = 40;
            this.iconBtnQLSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLSP.Location = new System.Drawing.Point(0, 132);
            this.iconBtnQLSP.Name = "iconBtnQLSP";
            this.iconBtnQLSP.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnQLSP.Size = new System.Drawing.Size(217, 44);
            this.iconBtnQLSP.TabIndex = 0;
            this.iconBtnQLSP.Text = "  Quản Lý Sản Phẩm";
            this.iconBtnQLSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQLSP.UseVisualStyleBackColor = true;
            this.iconBtnQLSP.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconBtnQLKH
            // 
            this.iconBtnQLKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnQLKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnQLKH.FlatAppearance.BorderSize = 0;
            this.iconBtnQLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQLKH.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnQLKH.ForeColor = System.Drawing.Color.White;
            this.iconBtnQLKH.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconBtnQLKH.IconColor = System.Drawing.Color.White;
            this.iconBtnQLKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnQLKH.IconSize = 40;
            this.iconBtnQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLKH.Location = new System.Drawing.Point(0, 88);
            this.iconBtnQLKH.Name = "iconBtnQLKH";
            this.iconBtnQLKH.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnQLKH.Size = new System.Drawing.Size(217, 44);
            this.iconBtnQLKH.TabIndex = 0;
            this.iconBtnQLKH.Text = "  Quản Lý Khách Hàng";
            this.iconBtnQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQLKH.UseVisualStyleBackColor = true;
            this.iconBtnQLKH.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconBtnQLNV
            // 
            this.iconBtnQLNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnQLNV.FlatAppearance.BorderSize = 0;
            this.iconBtnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQLNV.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnQLNV.ForeColor = System.Drawing.Color.White;
            this.iconBtnQLNV.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconBtnQLNV.IconColor = System.Drawing.Color.White;
            this.iconBtnQLNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnQLNV.IconSize = 40;
            this.iconBtnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLNV.Location = new System.Drawing.Point(0, 44);
            this.iconBtnQLNV.Name = "iconBtnQLNV";
            this.iconBtnQLNV.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnQLNV.Size = new System.Drawing.Size(217, 44);
            this.iconBtnQLNV.TabIndex = 0;
            this.iconBtnQLNV.Text = "  Quản Lý Nhân Viên";
            this.iconBtnQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQLNV.UseVisualStyleBackColor = true;
            this.iconBtnQLNV.Click += new System.EventHandler(this.iconBtnQLNV_Click);
            // 
            // iconBtnQLTK
            // 
            this.iconBtnQLTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnQLTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnQLTK.FlatAppearance.BorderSize = 0;
            this.iconBtnQLTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQLTK.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnQLTK.ForeColor = System.Drawing.Color.White;
            this.iconBtnQLTK.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconBtnQLTK.IconColor = System.Drawing.Color.White;
            this.iconBtnQLTK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnQLTK.IconSize = 40;
            this.iconBtnQLTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLTK.Location = new System.Drawing.Point(0, 0);
            this.iconBtnQLTK.Name = "iconBtnQLTK";
            this.iconBtnQLTK.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnQLTK.Size = new System.Drawing.Size(217, 44);
            this.iconBtnQLTK.TabIndex = 0;
            this.iconBtnQLTK.Text = "  Quản Lý Tài Khoản";
            this.iconBtnQLTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQLTK.UseVisualStyleBackColor = true;
            this.iconBtnQLTK.Click += new System.EventHandler(this.iconBtnQLTK_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.panelLogo.Controls.Add(this.btnMenu);
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(217, 91);
            this.panelLogo.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(180, 1);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(37, 32);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.Image = global::GUI_Dangnhap.Properties.Resources.sgl_store__1_;
            this.pictureBoxLogo.Location = new System.Drawing.Point(39, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(114, 91);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.panelHome);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 540);
            this.panel2.TabIndex = 2;
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.pictureBoxHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(217, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(857, 537);
            this.panelHome.TabIndex = 3;
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHome.Image")));
            this.pictureBoxHome.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(857, 537);
            this.pictureBoxHome.TabIndex = 2;
            this.pictureBoxHome.TabStop = false;
            // 
            // bunifuPanelTitle
            // 
            this.bunifuPanelTitle.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanelTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanelTitle.BackgroundImage")));
            this.bunifuPanelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanelTitle.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanelTitle.BorderRadius = 3;
            this.bunifuPanelTitle.BorderThickness = 1;
            this.bunifuPanelTitle.Controls.Add(this.lblNhanVien);
            this.bunifuPanelTitle.Controls.Add(this.iconbtnExit);
            this.bunifuPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanelTitle.Name = "bunifuPanelTitle";
            this.bunifuPanelTitle.ShowBorders = true;
            this.bunifuPanelTitle.Size = new System.Drawing.Size(1074, 34);
            this.bunifuPanelTitle.TabIndex = 0;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.BackColor = System.Drawing.Color.White;
            this.lblNhanVien.Font = new System.Drawing.Font("Be Vietnam Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNhanVien.Location = new System.Drawing.Point(22, 5);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(246, 23);
            this.lblNhanVien.TabIndex = 6;
            this.lblNhanVien.Text = "Admin: Trần Huỳnh Lưu";
            // 
            // iconbtnExit
            // 
            this.iconbtnExit.BackColor = System.Drawing.Color.White;
            this.iconbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconbtnExit.FlatAppearance.BorderSize = 0;
            this.iconbtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconbtnExit.IconColor = System.Drawing.Color.Black;
            this.iconbtnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconbtnExit.IconSize = 35;
            this.iconbtnExit.Location = new System.Drawing.Point(1041, 2);
            this.iconbtnExit.Name = "iconbtnExit";
            this.iconbtnExit.Size = new System.Drawing.Size(30, 29);
            this.iconbtnExit.TabIndex = 5;
            this.iconbtnExit.UseVisualStyleBackColor = false;
            this.iconbtnExit.Click += new System.EventHandler(this.iconbtnExit_Click);
            // 
            // FormMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuPanelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainUI";
            this.Load += new System.EventHandler(this.FormMainUI_Load);
            this.panel3.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.bunifuPanelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanelTitle;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowFormMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconBtnLogout;
        private FontAwesome.Sharp.IconButton iconBtnThongKe;
        private FontAwesome.Sharp.IconButton iconBtnBaoHanh;
        private FontAwesome.Sharp.IconButton iconBtnQLPN;
        private FontAwesome.Sharp.IconButton iconBtnQLNCC;
        private FontAwesome.Sharp.IconButton iconBtnQLHD;
        private FontAwesome.Sharp.IconButton iconBtnQLSP;
        private FontAwesome.Sharp.IconButton iconBtnQLKH;
        private FontAwesome.Sharp.IconButton iconBtnQLNV;
        private FontAwesome.Sharp.IconButton iconBtnQLTK;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private FontAwesome.Sharp.IconButton iconbtnExit;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Panel panelHome;
    }
}