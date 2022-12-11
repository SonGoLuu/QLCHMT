using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_BaoHanh
    {
        string _MaBH;
        string _MaKH;
        string _MaNVLap;
        DateTime _NgayLap;
        DateTime _NgayHenTra;
        /*=======GETTER/SETTER=======*/
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
        public DateTime NgayHenTra
        {
            get
            {
                return _NgayHenTra;
            }
            set
            {
                _NgayHenTra = value;
            }
        }
        public DTO_BaoHanh()
        {

        }
        public DTO_BaoHanh(string mabh, string makh, string manvlap, DateTime ngaylap, DateTime ngayhentra)
        {
            this.MaBH = mabh;
            this.MaKH = makh;
            this.MaNVLap = manvlap;
            this.NgayLap = ngaylap;
            this.NgayHenTra = ngayhentra;
        }
    }
}
