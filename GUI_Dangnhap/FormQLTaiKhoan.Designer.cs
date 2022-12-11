
namespace GUI_Dangnhap
{
    partial class FormQLTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLTaiKhoan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQLTK = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvTaiKhoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFindTK = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnThemTK = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSuaTK = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoaTK = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnFindTK = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.lblQLTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 48);
            this.panel1.TabIndex = 0;
            // 
            // lblQLTK
            // 
            this.lblQLTK.AllowParentOverrides = false;
            this.lblQLTK.AutoEllipsis = false;
            this.lblQLTK.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblQLTK.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblQLTK.Font = new System.Drawing.Font("Be Vietnam Pro Black", 14F, System.Drawing.FontStyle.Bold);
            this.lblQLTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblQLTK.Location = new System.Drawing.Point(340, 10);
            this.lblQLTK.Name = "lblQLTK";
            this.lblQLTK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQLTK.Size = new System.Drawing.Size(204, 29);
            this.lblQLTK.TabIndex = 0;
            this.lblQLTK.Text = "QUẢN LÝ TÀI KHOẢN";
            this.lblQLTK.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblQLTK.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTaiKhoan.ColumnHeadersHeight = 40;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvTaiKhoan.Location = new System.Drawing.Point(71, 134);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowTemplate.Height = 40;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(719, 358);
            this.dgvTaiKhoan.TabIndex = 1;
            this.dgvTaiKhoan.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTaiKhoan.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTaiKhoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvTaiKhoan.ThemeStyle.ReadOnly = true;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.Height = 40;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTaiKhoan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTaiKhoan_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "TenTaiKhoan";
            this.Column1.HeaderText = "Tên tài khoản";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 124;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MatKhau";
            this.Column5.HeaderText = "Mật khẩu";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "TenQuyen";
            this.Column2.HeaderText = "Quyền hạn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 123;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "HoTenNV";
            this.Column3.HeaderText = "Người sở hữu";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 184;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ChucVu";
            this.Column4.HeaderText = "Chức vụ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txtFindTK
            // 
            this.txtFindTK.BackColor = System.Drawing.SystemColors.Window;
            this.txtFindTK.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFindTK.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFindTK.BorderRadius = 0;
            this.txtFindTK.BorderSize = 2;
            this.txtFindTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFindTK.Location = new System.Drawing.Point(71, 74);
            this.txtFindTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindTK.Multiline = false;
            this.txtFindTK.Name = "txtFindTK";
            this.txtFindTK.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFindTK.PasswordChar = false;
            this.txtFindTK.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFindTK.PlaceholderText = "Tìm kiếm theo tên tài khoản...";
            this.txtFindTK.Size = new System.Drawing.Size(250, 31);
            this.txtFindTK.TabIndex = 4;
            this.txtFindTK.Texts = "";
            this.txtFindTK.UnderlinedStyle = false;
            // 
            // btnThemTK
            // 
            this.btnThemTK.BorderRadius = 23;
            this.btnThemTK.CheckedState.Parent = this.btnThemTK;
            this.btnThemTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemTK.CustomImages.Parent = this.btnThemTK;
            this.btnThemTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(147)))));
            this.btnThemTK.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(136)))), ((int)(((byte)(193)))));
            this.btnThemTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.ForeColor = System.Drawing.Color.White;
            this.btnThemTK.HoverState.Parent = this.btnThemTK;
            this.btnThemTK.Location = new System.Drawing.Point(475, 64);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.ShadowDecoration.Parent = this.btnThemTK;
            this.btnThemTK.Size = new System.Drawing.Size(101, 45);
            this.btnThemTK.TabIndex = 7;
            this.btnThemTK.Text = "Tạo mới";
            this.btnThemTK.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.BorderRadius = 23;
            this.btnSuaTK.CheckedState.Parent = this.btnSuaTK;
            this.btnSuaTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaTK.CustomImages.Parent = this.btnSuaTK;
            this.btnSuaTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(147)))));
            this.btnSuaTK.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(136)))), ((int)(((byte)(193)))));
            this.btnSuaTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTK.ForeColor = System.Drawing.Color.White;
            this.btnSuaTK.HoverState.Parent = this.btnSuaTK;
            this.btnSuaTK.Location = new System.Drawing.Point(582, 64);
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.ShadowDecoration.Parent = this.btnSuaTK;
            this.btnSuaTK.Size = new System.Drawing.Size(101, 45);
            this.btnSuaTK.TabIndex = 7;
            this.btnSuaTK.Text = "Sửa";
            this.btnSuaTK.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.BorderRadius = 23;
            this.btnXoaTK.CheckedState.Parent = this.btnXoaTK;
            this.btnXoaTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaTK.CustomImages.Parent = this.btnXoaTK;
            this.btnXoaTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(147)))));
            this.btnXoaTK.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(136)))), ((int)(((byte)(193)))));
            this.btnXoaTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.ForeColor = System.Drawing.Color.White;
            this.btnXoaTK.HoverState.Parent = this.btnXoaTK;
            this.btnXoaTK.Location = new System.Drawing.Point(689, 64);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.ShadowDecoration.Parent = this.btnXoaTK;
            this.btnXoaTK.Size = new System.Drawing.Size(101, 45);
            this.btnXoaTK.TabIndex = 7;
            this.btnXoaTK.Text = "Xóa";
            this.btnXoaTK.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // btnFindTK
            // 
            this.btnFindTK.CheckedState.Parent = this.btnFindTK;
            this.btnFindTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindTK.CustomImages.Parent = this.btnFindTK;
            this.btnFindTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnFindTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindTK.ForeColor = System.Drawing.Color.White;
            this.btnFindTK.HoverState.Parent = this.btnFindTK;
            this.btnFindTK.Image = ((System.Drawing.Image)(resources.GetObject("btnFindTK.Image")));
            this.btnFindTK.Location = new System.Drawing.Point(328, 71);
            this.btnFindTK.Name = "btnFindTK";
            this.btnFindTK.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnFindTK.ShadowDecoration.Parent = this.btnFindTK;
            this.btnFindTK.Size = new System.Drawing.Size(38, 38);
            this.btnFindTK.TabIndex = 6;
            this.btnFindTK.Click += new System.EventHandler(this.btnFindTK_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 25;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(409, 498);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 29);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnXoaTK);
            this.Controls.Add(this.btnSuaTK);
            this.Controls.Add(this.btnThemTK);
            this.Controls.Add(this.btnFindTK);
            this.Controls.Add(this.txtFindTK);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.panel1);
            this.Name = "FormQLTaiKhoan";
            this.Size = new System.Drawing.Size(858, 540);
            this.Load += new System.EventHandler(this.FormQLTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel lblQLTK;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTaiKhoan;
        private RJCodeAdvance.RJControls.RJTextBox txtFindTK;
        private Guna.UI2.WinForms.Guna2CircleButton btnFindTK;
        private Guna.UI2.WinForms.Guna2GradientButton btnThemTK;
        private Guna.UI2.WinForms.Guna2GradientButton btnSuaTK;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private FontAwesome.Sharp.IconButton btnRefresh;
    }
}
