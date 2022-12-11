using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ChiTietPhieuNhap
    {
        string _MaPhieu;
        string _MaSP;
        decimal _GiaGoc;
        int _SLNhap;
        decimal _ThanhTien;
        public string MaPhieu
        {
            get
            {
                return _MaPhieu;
            }
            set
            {
                _MaPhieu = value;
            }
        }
        public string MaSP
        {
            get
            {
                return _MaSP;
            }
            set
            {
                _MaSP = value;
            }
        }
        public decimal GiaGoc
        {
            get
            {
                return _GiaGoc;
            }
            set
            {
                _GiaGoc = value;
            }
        }
        public int SLNhap
        {
            get
            {
                return _SLNhap;
            }
            set
            {
                _SLNhap = value;
            }
        }
        public decimal ThanhTien
        {
            get
            {
                return _ThanhTien;
            }
            set
            {
                _ThanhTien = value;
            }
        }
        public DTO_ChiTietPhieuNhap()
        {

        }
        public DTO_ChiTietPhieuNhap(string maphieu, string masp, decimal giagoc, int slnhap, decimal thanhtien)
        {
            this.MaPhieu = maphieu;
            this.MaSP = masp;
            this.GiaGoc = giagoc;
            this.SLNhap = slnhap;
            this.ThanhTien = thanhtien;
        }
    }
}
