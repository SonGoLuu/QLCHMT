using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ChiTietBaoHanh
    {
        string _MaBH;
        string _MaHD;
        string _MaSP;
        string _GhiChu;
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
        public string GhiChu
        {
            get
            {
                return _GhiChu;
            }
            set
            {
                _GhiChu = value;
            }
        }
        public DTO_ChiTietBaoHanh()
        {

        }   
        public DTO_ChiTietBaoHanh(string mabh, string mahd, string masp, string ghichu)
        {
            this.MaBH = mabh;
            this.MaHD = mahd;
            this.MaSP = masp;
            this.GhiChu = ghichu;
        }    
    }
}
