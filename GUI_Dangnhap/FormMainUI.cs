using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_Dangnhap
{
    public partial class FormMainUI : Form
    {
        string _TenTaiKhoan;
        string _CheDoNguoiDung;
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        public FormMainUI()
        {
            InitializeComponent();
        }

        public string TenTaiKhoan
        {
            get
            {
                return _TenTaiKhoan;
            }
            set
            {
                _TenTaiKhoan = value;
            }
        }

        public string CheDoNguoiDung
        {
            get
            {
                return _CheDoNguoiDung;
            }
            set
            {
                _CheDoNguoiDung = value;
            }
        }
        private void FormMainUI_Load(object sender, EventArgs e)
        {
            guna2ShadowFormMain.SetShadowForm(this);
            lblNhanVien.Text = CheDoNguoiDung + ": " + busNhanVien.getHoTenNhanVien(busTaiKhoan.getMaNVTaiKhoan(TenTaiKhoan));
            if (CheDoNguoiDung != "Admin")
            {
                iconBtnQLTK.Cursor = Cursors.No;
                iconBtnQLNV.Cursor = Cursors.No;
            }    
            addFormPanelHome();
            lockVisiblePanelHome();
            panelHome.Controls[0].Visible = true;
            
        }

        private void iconbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
            
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void addFormPanelHome()
        {
            FormQLTaiKhoan qltk = new FormQLTaiKhoan();
            FormQLNhanVien qlnv = new FormQLNhanVien();
            FormQLKhachHang qlkh = new FormQLKhachHang();
            FormQLSanPham qlsp = new FormQLSanPham();
            FormQLHoaDon qlhd = new FormQLHoaDon();
            qlhd.HoTenNV = busNhanVien.getHoTenNhanVien(busTaiKhoan.getMaNVTaiKhoan(TenTaiKhoan));
            FormQLNhaCungCap qlncc = new FormQLNhaCungCap();
            FormQLPhieuNhap qlpn = new FormQLPhieuNhap();
            qlpn.HoTenNV = busNhanVien.getHoTenNhanVien(busTaiKhoan.getMaNVTaiKhoan(TenTaiKhoan));
            FormBaoHanh bh = new FormBaoHanh();
            bh.HoTenNV = busNhanVien.getHoTenNhanVien(busTaiKhoan.getMaNVTaiKhoan(TenTaiKhoan));
            FormThongKe tk = new FormThongKe();
            panelHome.Controls.Add(qltk);
            panelHome.Controls.Add(qlnv);
            panelHome.Controls.Add(qlkh);
            panelHome.Controls.Add(qlsp);
            panelHome.Controls.Add(qlhd);
            panelHome.Controls.Add(qlncc);
            panelHome.Controls.Add(qlpn);
            panelHome.Controls.Add(bh);
            panelHome.Controls.Add(tk);
        }
        private void lockVisiblePanelHome()
        {
            panelHome.Controls[0].Visible = false;
            panelHome.Controls[1].Visible = false;
            panelHome.Controls[2].Visible = false;
            panelHome.Controls[3].Visible = false;
            panelHome.Controls[4].Visible = false;
            panelHome.Controls[5].Visible = false;
            panelHome.Controls[6].Visible = false;
            panelHome.Controls[7].Visible = false;
            panelHome.Controls[8].Visible = false;
            panelHome.Controls[9].Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            changeColor(5, 19, 22);
            lockVisiblePanelHome();
            panelHome.Controls[0].Visible = true;
        }
        private void changeColor(int a, int b, int c)
        {
            panelLogo.BackColor = Color.FromArgb(a,b,c);
            panelMenu.BackColor = Color.FromArgb(a, b, c);
            pictureBoxLogo.BackColor = Color.FromArgb(a, b, c);
            btnMenu.BackColor = Color.FromArgb(a, b, c); 
        }
        //Nút Quản Lý Tài Khoản
        private void iconBtnQLTK_Click(object sender, EventArgs e)
        {
            if (CheDoNguoiDung == "Admin")
            {
                changeColor(98, 102, 244);
                lockVisiblePanelHome();
                panelHome.Controls[1].Visible = true;
            }
        }

        //Nút Quản Lý Nhân Viên
        private void iconBtnQLNV_Click(object sender, EventArgs e)
        {
            if (CheDoNguoiDung == "Admin")
            {
                changeColor(0, 140, 94);
                lockVisiblePanelHome();
                panelHome.Controls[2].Visible = true;
            }        
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            changeColor(162, 0, 124);
            lockVisiblePanelHome();
            panelHome.Controls[3].Visible = true;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            changeColor(199, 195, 0);
            lockVisiblePanelHome();
            panelHome.Controls[4].Visible = true;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            changeColor(98, 102, 244);
            lockVisiblePanelHome();
            panelHome.Controls[5].Visible = true;
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            changeColor(182, 41, 43);
            lockVisiblePanelHome();
            panelHome.Controls[6].Visible = true;
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            changeColor(0, 0, 0);
            lockVisiblePanelHome();
            panelHome.Controls[7].Visible = true;
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            changeColor(0, 146, 152);
            lockVisiblePanelHome();
            panelHome.Controls[8].Visible = true;
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            changeColor(214, 41, 138);
            lockVisiblePanelHome();
            panelHome.Controls[9].Visible = true;
        }
    }
}
