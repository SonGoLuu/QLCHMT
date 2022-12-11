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
    public partial class FormLapHoaDon : Form
    {
        string _HoTenNV;
        string _MaHDCuoi;
        decimal _TongTien = 0;
        BUS_HoaDon busHoaDon = new BUS_HoaDon();
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        BUS_SanPham busSP = new BUS_SanPham();
        BUS_CTHD busCTHD = new BUS_CTHD();
        public FormLapHoaDon()
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
        public decimal TongTien
        {
            get
            {
                return _TongTien;
            }
            set
            {
                _TongTien = value;
            }
        }

        public string MaHDCuoi
        {
            get
            {
                return _MaHDCuoi;
            }
            set
            {
                _MaHDCuoi = value;
            }
        }
        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            string makh = txtMaKH.Text;
            string manvlap = txtMaNVLap.Text;
            DateTime ngaylap = Convert.ToDateTime(txtNgayLap.Text);
            decimal tongtien = Convert.ToDecimal(txtTongTien.Text);
            DTO_HoaDon dtoHoaDon = new DTO_HoaDon(mahd, makh, manvlap, ngaylap, tongtien);
            busHoaDon.themHoaDon(dtoHoaDon);
            foreach(DataGridViewRow row in dgvCTHD.Rows)
            {
                string masp = row.Cells[0].Value.ToString();
                int sl = Convert.ToInt32(row.Cells[3].Value.ToString());
                int khuyenmai = Convert.ToInt32(row.Cells[4].Value.ToString());
                decimal thanhtien = Convert.ToDecimal(row.Cells[6].Value.ToString());
                DTO_ChiTietHoaDon dtoCTHD = new DTO_ChiTietHoaDon(mahd, masp, sl, khuyenmai, thanhtien);
                busCTHD.themCTHD(dtoCTHD);
                busSP.updateSLTon(sl, masp);
            }
            MessageBox.Show("Lập hóa đơn thành công!");
        }
        private void FormLapHoaDon_Load(object sender, EventArgs e)
        {
            txtNgayLap.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtHoTenNV.Text = this.HoTenNV;
            txtMaNVLap.Text = busNhanVien.findNhanVien(this.HoTenNV).Rows[0].Field<string>(0);
            cbbMaSP.DataSource = busSP.getAllMaSP();
            cbbMaSP.DisplayMember = "MaSP";
            cbbMaSP.SelectedItem = null;
        }
        private void iconbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(busKhachHang.checkMaKH(txtMaKH.Text))
                {
                    txtHoTenKH.Text = busKhachHang.getHoTenKhachHang(txtMaKH.Text);
                    txtSDTKH.Text = busKhachHang.getSDTKH(txtMaKH.Text);
                    txtDiaChi.Text = busKhachHang.getDiaChi(txtMaKH.Text);
                }   
                else
                {
                    MessageBox.Show("Khách hàng mới!");
                }    
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtHoTenKH.Text != "" && txtSDTKH.Text != "" && txtDiaChi.Text != "")
            {
                string makh = txtMaKH.Text;
                string hotenkh = txtHoTenKH.Text;
                string sdtkh = txtSDTKH.Text;
                string diachi = txtDiaChi.Text;
                DTO_KhachHang dtoKhachHang = new DTO_KhachHang(makh, hotenkh, sdtkh, diachi);
                if (busKhachHang.themKhachHang(dtoKhachHang))
                {
                    MessageBox.Show("Thêm khách hàng mới thành công!");
                }
                else MessageBox.Show("Thêm khách hàng mới không thành công!");
            }
            else MessageBox.Show("Vui lòng điền đầy đủ!");
        }

        private void cbbMaSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtTenSP.Text = busSP.getThongTinSP(this.cbbMaSP.GetItemText(this.cbbMaSP.SelectedItem)).Rows[0].Field<string> (1);
            txtGiaBan.Text = busSP.getThongTinSP(this.cbbMaSP.GetItemText(this.cbbMaSP.SelectedItem)).Rows[0].Field<decimal>(3).ToString();
            txtThangBaoHanh.Text = busSP.getThongTinSP(this.cbbMaSP.GetItemText(this.cbbMaSP.SelectedItem)).Rows[0].Field<int>(5).ToString();
        }

        private void btnThemVaoHoaDon_Click(object sender, EventArgs e)
        {
            
            if (txtTenSP.Text != "" && txtSLMua.Text != "" && txtKhuyenMai.Text != "")
            {
                string masp = this.cbbMaSP.GetItemText(this.cbbMaSP.SelectedItem);
                string tensp = txtTenSP.Text;
                decimal giaban = Convert.ToDecimal(txtGiaBan.Text);
                int sl = Convert.ToInt32(txtSLMua.Text);
                int khuyenmai = Convert.ToInt32(txtKhuyenMai.Text);
                int thangbaohanh = Convert.ToInt32(txtThangBaoHanh.Text);
                decimal thanhtien = Convert.ToDecimal(txtThanhTien.Text);
                this.dgvCTHD.Rows.Add(masp, tensp, giaban, sl, khuyenmai, thangbaohanh, thanhtien);
                this.TongTien += thanhtien;
                txtTongTien.Text = this.TongTien.ToString();
            }
            else MessageBox.Show("Vui lòng điền đầy đủ!");
        }

        private void txtKhuyenMai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(Convert.ToInt32(txtKhuyenMai.Text) != 0)
                {
                    txtThanhTien.Text = (Convert.ToDecimal(txtGiaBan.Text) * Convert.ToInt32(txtSLMua.Text) * (100 - Convert.ToInt32(txtKhuyenMai.Text))/100).ToString();
                }
                else
                {
                    txtThanhTien.Text = (Convert.ToDecimal(txtGiaBan.Text) * Convert.ToInt32(txtSLMua.Text)).ToString();
                }             
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtSDTKH.Text = "";
            txtDiaChi.Text = "";
            cbbMaSP.SelectedItem = null;
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            txtSLMua.Text = "";
            txtThangBaoHanh.Text = "";
            txtKhuyenMai.Text = "";
            txtThanhTien.Text = "";
            txtTongTien.Text = "";
            this.TongTien = 0;
            dgvCTHD.Rows.Clear();
        }

        private void txtMaHD_Enter(object sender, EventArgs e)
        {
            string sohdcuoi = MaHDCuoi;
            string sohdmoi = (Convert.ToInt32(sohdcuoi.Substring(2)) + 1).ToString();
            if (Convert.ToInt32(sohdmoi) <= 9) txtMaHD.Text = "HD0" + sohdmoi;
            else txtMaHD.Text = "HD" + sohdmoi;
        }
    }
}
