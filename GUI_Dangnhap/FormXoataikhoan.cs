using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;
namespace GUI_Dangnhap
{
    public partial class FormXoataikhoan : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        BUS_PhanQuyen busPhanQuyen = new BUS_PhanQuyen();
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        public FormXoataikhoan()
        {
            InitializeComponent();
        }

        private void iconbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormXoataikhoan_Load(object sender, EventArgs e)
        {
            cbbMaNV.DataSource = busTaiKhoan.getAllMaNVTaiKhoan();
            cbbMaNV.DisplayMember = "MaNV";
            cbbMaNV.SelectedItem = null;
            cbbPhanQuyen.DataSource = busPhanQuyen.getAllTenQuyen();
            cbbPhanQuyen.DisplayMember = "TenQuyen";
            cbbPhanQuyen.SelectedItem = null;
        }

        private void cbbMaNV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtHoTenNV.Text = busNhanVien.getHoTenNhanVien(this.cbbMaNV.GetItemText(this.cbbMaNV.SelectedItem));
            txtChucVu.Text = busNhanVien.getChucVu(this.cbbMaNV.GetItemText(this.cbbMaNV.SelectedItem));
            txtTenTaiKhoan.Text = busTaiKhoan.getTenTaiKhoanFromMaNV(this.cbbMaNV.GetItemText(this.cbbMaNV.SelectedItem));
            txtMatKhau.Text = busTaiKhoan.getMatKhauFromTenTaiKhoan(txtTenTaiKhoan.Text);
            cbbPhanQuyen.SelectedIndex = cbbPhanQuyen.FindStringExact(busTaiKhoan.getPhanQuyenFromTenTaiKhoan(txtTenTaiKhoan.Text));
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbbMaNV.Text != "" && txtTenTaiKhoan.Text != "" && txtMatKhau.Text != "" && cbbPhanQuyen.Text != "")
            {
                if (busTaiKhoan.xoaTaiKhoan(txtTenTaiKhoan.Text))
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                }
                else MessageBox.Show("Xóa tài khoản không thành công!");
            }
            else MessageBox.Show("Thiếu thông tin cần thiết!");
        }
    }
}
