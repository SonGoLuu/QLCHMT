using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_TaiKhoan
    {
        string _TenTaiKhoan;
        string _MatKhau;
        string _MaNV;
        string _MaQuyen;

        /*=======GETTER/SETTER=======*/
        public string TenTaiKhoan
        {
            get
            {
                return _TenTaiKhoan;
            }
            set
            {
                _TenTaiKhoan = value;
            }
        }
        public string MatKhau
        {
            get
            {
                return _MatKhau;
            }
            set
            {
                _MatKhau = value;
            }
        }
        public string MaNV
        {
            get
            {
                return _MaNV;
            }
            set
            {
                _MaNV = value;
            }
        }
        public string MaQuyen
        {
            get
            {
                return _MaQuyen;
            }
            set
            {
                _MaQuyen = value;
            }
        }
        public DTO_TaiKhoan()
        {

        }
        public DTO_TaiKhoan(string tentaikhoan, string matkhau, string manv, string maquyen)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.MatKhau = matkhau;
            this.MaNV = manv;
            this.MaQuyen = maquyen;
        }
    }
    
}
