using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_HoaDon
    {
        string _MaHD;
        string _MaKH;
        string _MaNVLap;
        DateTime _NgayLap;
        decimal _TongTien;
        /*=======GETTER/SETTER=======*/
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
        public string MaKH
        {
            get
            {
                return _MaKH;
            }
            set
            {
                _MaKH = value;
            }
        }
        public string MaNVLap
        {
            get
            {
                return _MaNVLap;
            }
            set
            {
                _MaNVLap = value;
            }
        }
        public DateTime NgayLap
        {
            get
            {
                return _NgayLap;
            }
            set
            {
                _NgayLap = value;
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
        public DTO_HoaDon()
        {

        }
        public DTO_HoaDon(string mahd, string makh, string manvlap, DateTime ngaylap, decimal tongtien)
        {
            this.MaHD = mahd;
            this.MaKH = makh;
            this.MaNVLap = manvlap;
            this.NgayLap = ngaylap;
            this.TongTien = tongtien;
        }
    }
}
