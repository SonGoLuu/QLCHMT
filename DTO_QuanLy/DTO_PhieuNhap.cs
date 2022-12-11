using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_PhieuNhap
    {
        string _MaPhieu;
        string _MaNCC;
        string _MaNVNhap;
        DateTime _NgayNhap;
        decimal _TongTien;
        /*=======GETTER/SETTER=======*/
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
        public string MaNCC
        {
            get
            {
                return _MaNCC;
            }
            set
            {
                _MaNCC = value;
            }
        }
        public string MaNVNhap
        {
            get
            {
                return _MaNVNhap;
            }
            set
            {
                _MaNVNhap = value;
            }
        }
        public DateTime NgayNhap
        {
            get
            {
                return _NgayNhap;
            }
            set
            {
                _NgayNhap = value;
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
        public DTO_PhieuNhap()
        {

        }
        public DTO_PhieuNhap(string maphieu, string mancc, string manvlap, DateTime ngaylap, decimal tongtien)
        {
            this.MaPhieu = maphieu;
            this.MaNCC = mancc;
            this.MaNVNhap = manvlap;
            this.NgayNhap = ngaylap;
            this.TongTien = tongtien;
        }
    }
}
