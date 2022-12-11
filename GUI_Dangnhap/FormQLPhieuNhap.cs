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
    public partial class FormQLPhieuNhap : UserControl
    {
        string _HoTenNV;
        decimal _TongTien = 0;
        BUS_PhieuNhap busPhieuNhap = new BUS_PhieuNhap();
        BUS_CTPN busCTPN = new BUS_CTPN();
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        BUS_SanPham busSP = new BUS_SanPham();
        BUS_NhaCungCap busNCC = new BUS_NhaCungCap();
        public FormQLPhieuNhap()
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
        private void FormQLPhieuNhap_Load(object sender, EventArgs e)
        {
            cbbTenNCC.DataSource = busNCC.getAllTenNCC();
            cbbTenNCC.DisplayMember = "TenNCC";
            cbbTenNCC.SelectedItem = null;
            dgvCTPN.DataSource = busCTPN.getdgvCTHD();
        }

        private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (busSP.checkMaSP(txtMaSP.Text))
                {
                    txtTenSP.Text = busSP.getThongTinSP(txtMaSP.Text).Rows[0].Field<string>(1);
                    txtLoai.Text = busSP.getThongTinSP(txtMaSP.Text).Rows[0].Field<string>(2);
                    txtXuatXu.Text = busSP.getThongTinSP(txtMaSP.Text).Rows[0].Field<string>(6);
                }
                else
                {
                    MessageBox.Show("Sản phẩm mới!");
                }
            }
        }

        private void txtGiaGoc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtThanhTien.Text = (Convert.ToInt32(txtSLNhap.Text) * Convert.ToDecimal(txtGiaGoc.Text)).ToString();
            }
        }

        private void btnThemVaoPhieuNhap_Click(object sender, EventArgs e)
        {
            string maphieu = txtMaPhieu.Text;
            string mancc = busNCC.getMaNCC(cbbTenNCC.Text);
            string masp = txtMaSP.Text;
            string tensp = txtTenSP.Text;
            string maloai = txtLoai.Text;
            string xuatxu = txtXuatXu.Text;
            decimal giagoc = Convert.ToDecimal(txtGiaGoc.Text);
            int slnhap = Convert.ToInt32(txtSLNhap.Text);
            decimal thanhtien = Convert.ToDecimal(txtThanhTien.Text);
            this.TongTien += thanhtien;
            txtTongTien.Text = this.TongTien.ToString();
            DateTime ngaynhap = Convert.ToDateTime(txtNgayNhap.Text);
            string manvnhap = txtMaNVNhap.Text;
            
            DTO_PhieuNhap dtoPhieuNhap = new DTO_PhieuNhap(maphieu, mancc, manvnhap, ngaynhap, 0);
            //Thêm phiếu nhập

            if (busPhieuNhap.checkMaPhieu(maphieu) == false)
            {
                busPhieuNhap.themPhieuNhap(dtoPhieuNhap);
            }
            //Thêm sản phẩm mới nếu có
            if (busSP.checkMaSP(masp)==false)
            {
                DTO_SanPham dtoSP = new DTO_SanPham(masp, tensp, maloai, 0, slnhap, 0, xuatxu);
                busSP.themSP(dtoSP);
            }   
            else
            {
                decimal giaban = busSP.getThongTinSP(masp).Rows[0].Field<decimal>(3);
                int thangbaohanh = busSP.getThongTinSP(masp).Rows[0].Field<int>(5);
                int slton = busSP.getThongTinSP(masp).Rows[0].Field<int>(4);
                int soluong = slnhap + slton;
                DTO_SanPham dtoSP = new DTO_SanPham(masp, tensp, maloai, giaban, soluong, thangbaohanh, xuatxu);
                busSP.suaSP(dtoSP);
            }
            //Thêm CTPN
            DTO_ChiTietPhieuNhap dtoCTPN = new DTO_ChiTietPhieuNhap(maphieu, masp, giagoc, slnhap, thanhtien);
            busCTPN.themCTPN(dtoCTPN);
            dgvCTPN.DataSource = busCTPN.getdgvCTHD();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            busPhieuNhap.suaPhieuNhap(this.TongTien, txtMaPhieu.Text);
            MessageBox.Show("Thêm thành công!");
        }

        private void dgvCTPN_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Text = dgvCTPN.SelectedRows[0].Cells[0].Value.ToString();
            cbbTenNCC.SelectedIndex = cbbTenNCC.FindStringExact(busNCC.getTenNCC(dgvCTPN.SelectedRows[0].Cells[1].Value.ToString()));
            txtMaSP.Text = dgvCTPN.SelectedRows[0].Cells[2].Value.ToString();
            txtTenSP.Text = dgvCTPN.SelectedRows[0].Cells[3].Value.ToString();
            txtGiaGoc.Text = dgvCTPN.SelectedRows[0].Cells[4].Value.ToString();
            txtSLNhap.Text = dgvCTPN.SelectedRows[0].Cells[5].Value.ToString();
            txtThanhTien.Text = dgvCTPN.SelectedRows[0].Cells[6].Value.ToString();
            txtTongTien.Text = busPhieuNhap.getPhieuNhap(txtMaPhieu.Text).Rows[0].Field<decimal>(4).ToString();
            txtNgayNhap.Text = busPhieuNhap.getPhieuNhap(txtMaPhieu.Text).Rows[0].Field<DateTime>(3).ToString("dd/MM/yyyy");
            txtMaNVNhap.Text = busPhieuNhap.getPhieuNhap(txtMaPhieu.Text).Rows[0].Field<string>(2);
            txtHoTenNV.Text = busNhanVien.getHoTenNhanVien(txtMaNVNhap.Text);
            txtXuatXu.Text = busSP.getThongTinSP(txtMaSP.Text).Rows[0].Field<string>(6);
            txtLoai.Text = busSP.getThongTinSP(txtMaSP.Text).Rows[0].Field<string>(2);
        }

        private void txtMaPhieu_Enter(object sender, EventArgs e)
        {
            txtNgayNhap.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtHoTenNV.Text = this.HoTenNV;
            txtMaNVNhap.Text = busNhanVien.findNhanVien(this.HoTenNV).Rows[0].Field<string>(0);
            string maphieucuoi = dgvCTPN.Rows[dgvCTPN.Rows.Count - 1].Cells[0].Value.ToString();
            string sophieumoi = (Convert.ToInt32(maphieucuoi.Substring(2)) + 1).ToString();
            if (Convert.ToInt32(sophieumoi) <= 9) txtMaPhieu.Text = "PN0" + sophieumoi;
            else txtMaPhieu.Text = "PN" + sophieumoi;
            cbbTenNCC.DataSource = busNCC.getAllTenNCC();
            cbbTenNCC.DisplayMember = "TenNCC";
            cbbTenNCC.SelectedItem = null;
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtLoai.Text = "";
            txtXuatXu.Text = "";
            txtSLNhap.Text = "";
            txtGiaGoc.Text = "";
            txtThanhTien.Text = "";
            txtTongTien.Text = "";
        }
    }
}
