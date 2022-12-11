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
    public partial class FormLapBaoHanh : Form
    {
        string _HoTenNV;
        string _MaBH;
        BUS_BaoHanh busBaoHanh = new BUS_BaoHanh();
        BUS_CTBH busCTBH = new BUS_CTBH();
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        BUS_SanPham busSP = new BUS_SanPham();
        BUS_NhanVien busNV = new BUS_NhanVien();
        public FormLapBaoHanh()
        {
            InitializeComponent();
        }
        public string HoTenNV
        {
            get
            {
                return _HoTenNV;
            }
            set
            {
                _HoTenNV = value;
            }
        }
        public string MaBH
        {
            get
            {
                return _MaBH;
            }
            set
            {
                _MaBH = value;
            }
        }
        private void btnLapBaoHanh_Click(object sender, EventArgs e)
        {
            string mabh = txtMaBH.Text;
            string makh = busKhachHang.findKhachHang(txtSDTKH.Text).Rows[0].Field<string>(0);    
            string manv = busNV.findNhanVien(HoTenNV).Rows[0].Field<string>(0);
            DateTime ngaylap = Convert.ToDateTime(txtNgayLap.Text);
            DateTime ngayhentra = Convert.ToDateTime(txtNgayHenTra.Text);
            DTO_BaoHanh dtoBaoHanh = new DTO_BaoHanh(mabh, makh, manv, ngaylap, ngayhentra);
            string mahd = txtMaHD.Text;
            string masp = txtMaSP.Text;
            string ghichu = txtGhiChu.Text;
            DTO_ChiTietBaoHanh dtoCTBH = new DTO_ChiTietBaoHanh(mabh, mahd, masp, ghichu);
            if(busBaoHanh.themBaoHanh(dtoBaoHanh))
            {
                if(busCTBH.themCTBH(dtoCTBH))
                    MessageBox.Show("Lập bảo hành thành công!");
            }
            else MessageBox.Show("Lập bảo hành không thành công!");
        }

        private void iconbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string mahd = txtMaHD.Text;
                string masp = txtMaSP.Text;
                txtTenSP.Text = busSP.getThongTinSP(masp).Rows[0].Field<string>(1);
                int thangbaohanh = busSP.getThongTinSP(masp).Rows[0].Field<int>(5);
                if (busCTBH.checkBaoHanh(mahd, masp, thangbaohanh))
                {
                    MessageBox.Show("Sản phẩm còn thời gian bảo hành!");
                    btnLapBaoHanh.Enabled = true;
                }
                else
                {
                    btnLapBaoHanh.Enabled = false;
                    MessageBox.Show("Sản phẩm không còn thời gian bảo hành!");
                }
            }
        }

        private void FormLapBaoHanh_Load(object sender, EventArgs e)
        {
            txtMaBH.Text = MaBH;
            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
