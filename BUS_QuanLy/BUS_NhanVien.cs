using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        public DataTable getNhanVien()
        {
            return dalNhanVien.getNhanVien();
        }

        public bool themNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.themNhanVien(nv);
        }

        public bool suaNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.suaNhanVien(nv);
        }

        public bool xoaNhanVien(string MANV)
        {
            return dalNhanVien.xoaNhanVien(MANV);
        }
        public DataTable findNhanVien(string HoTenNV)
        {
            return dalNhanVien.findNhanVien(HoTenNV);
        }
        public string getHoTenNhanVien(string MaNV)
        {
            return dalNhanVien.getHoTenNhanVien(MaNV);
        }
        public string getChucVu(string MaNV)
        {
            return dalNhanVien.getChucVu(MaNV);
        }
        public DataTable getMaNVChuaCoTaiKhoan()
        {
            return dalNhanVien.getMaNVChuaCoTaiKhoan();
        }
    }
}
