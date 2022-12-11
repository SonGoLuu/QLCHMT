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
    public partial class FormTaomoitaikhoan : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        BUS_PhanQuyen busPhanQuyen = new BUS_PhanQuyen();
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        public FormTaomoitaikhoan()
        {
            InitializeComponent();
            
            
        }

        private void iconbtnExit_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
        
        private void FormTaomoitaikhoan_Load(object sender, EventArgs e)
        {
            cbbMaNV.DataSource = busNhanVien.getMaNVChuaCoTaiKhoan();
            cbbMaNV.DisplayMember = "MaNV";
            cbbMaNV.SelectedItem = null;
            cbbPhanQuyen.DataSource = busPhanQuyen.getAllTenQuyen();
            cbbPhanQuyen.DisplayMember = "TenQuyen";
            cbbPhanQuyen.SelectedItem = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbbMaNV.Text != "" && txtTenTaiKhoan.Text != "" && txtMatKhau.Text != "" && cbbPhanQuyen.Text != "")
            {
                string MaQuyen = busPhanQuyen.getMaQuyen(this.cbbPhanQuyen.GetItemText(this.cbbPhanQuyen.SelectedItem));
                
                if (busTaiKhoan.themTaiKhoan(txtTenTaiKhoan.Text, txtMatKhau.Text, cbbMaNV.Text, MaQuyen))
                   {
                    MessageBox.Show("Thêm tài khoản thành công!");
                    }
                else MessageBox.Show("Thêm tài khoản không thành công!");
            }
            else MessageBox.Show("Bạn hãy nhập đầy đủ!");
        }

        private void cbbMaNV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtTenNV.Text = busNhanVien.getHoTenNhanVien(this.cbbMaNV.GetItemText(this.cbbMaNV.SelectedItem));
            txtChucVu.Text = busNhanVien.getChucVu(this.cbbMaNV.GetItemText(this.cbbMaNV.SelectedItem));
        }
    }
}
