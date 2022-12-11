using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ChiTietHoaDon
    {
        string _MaHD;
        string _MaSP;
        int _SLMua;
        int _KhuyenMai;
        decimal _ThanhTien;
        public string MaHD
        {
            get
            {
                return _MaHD;
            }
            set
            {
                _MaHD = value;
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
        public int SLMua
        {
            get
            {
                return _SLMua;
            }
            set
            {
                _SLMua = value;
            }
        }
        public int KhuyenMai
        {
            get
            {
                return _KhuyenMai;
            }
            set
            {
                _KhuyenMai = value;
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
        public DTO_ChiTietHoaDon()
        {

        }
        public DTO_ChiTietHoaDon(string mahd, string masp, int slmua, int khuyenmai, decimal thanhtien)
        {
            this.MaHD = mahd;
            this.MaSP = masp;
            this.SLMua = slmua;
            this.KhuyenMai = khuyenmai;
            this.ThanhTien = thanhtien;
        }
    }
}
