using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_NhanVien
    {
        private string _MaNV;
        private string _HoTenNV;
        private string _ChucVu;
        private DateTime _NgaySinh;
        private string _GioiTinh;
        private string _SDTNV;
        private string _DiaChi;

        /*=======GETTER/SETTER=======*/
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
        public string ChucVu
        {
            get
            {
                return _ChucVu;
            }
            set
            {
                _ChucVu = value;
            }
        }
        public DateTime NgaySinh
        {
            get
            {
                return _NgaySinh;
            }
            set
            {
                _NgaySinh = value;
            }
        }
        public string GioiTinh
        {
            get
            {
                return _GioiTinh;
            }
            set
            {
                _GioiTinh = value;
            }
        }
        public string SDTNV
        {
            get
            {
                return _SDTNV;
            }
            set
            {
                _SDTNV = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }
            set
            {
                _DiaChi = value;
            }
        }
        public DTO_NhanVien()
        {

        }
        public DTO_NhanVien(string manv, string hotennv, string chucvu, DateTime ngaysinh, string gioitinh, string sdtnv, string diachi)
        {
            this.MaNV = manv;
            this.HoTenNV = hotennv;
            this.ChucVu = chucvu;
            this.NgaySinh = ngaysinh;
            this.GioiTinh = gioitinh;
            this.SDTNV = sdtnv;
            this.DiaChi = diachi;
        }
    }
}
