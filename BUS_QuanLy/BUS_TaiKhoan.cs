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
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dalTaiKhoan = new DAL_TaiKhoan();
        public bool checkTaiKhoan(string TenTaiKhoan, string MatKhau, string NguoiDung)
        {
            return dalTaiKhoan.checkTaiKhoan(TenTaiKhoan, MatKhau, NguoiDung);
        }
        public string getMaNVTaiKhoan(string TenTaiKhoan)
        {
            return dalTaiKhoan.getMaNVTaiKhoan(TenTaiKhoan);
        }
        public DataTable getAllTaiKhoan()
        {
            return dalTaiKhoan.getAllTaiKhoan();
        }
        public string getTenTaiKhoanFromMaNV(string MaNV)
        {
            return dalTaiKhoan.getTenTaiKhoanFromMaNV(MaNV);
        }
        public string getPhanQuyenFromTenTaiKhoan(string TentaiKhoan)
        {
            return dalTaiKhoan.getPhanQuyenFromTenTaiKhoan(TentaiKhoan);
        }
        public string getMatKhauFromTenTaiKhoan(string TenTaiKhoan)
        {
            return dalTaiKhoan.getMatKhauFromTenTaiKhoan(TenTaiKhoan);
        }
        public DataTable getAllMaNVTaiKhoan()
        {
            return dalTaiKhoan.getAllMaNVTaiKhoan();
        }    
        public bool themTaiKhoan(string TenTaiKhoan, string MatKhau, string MaNV, string MaQuyen)
        {
            return dalTaiKhoan.themTaiKhoan(TenTaiKhoan, MatKhau, MaNV, MaQuyen);
        }
        public bool suaTaiKhoan(string TenTaiKhoan, string MatKhau, string MaNV, string MaQuyen)
        {
            return dalTaiKhoan.suaTaiKhoan(TenTaiKhoan, MatKhau, MaNV, MaQuyen);
        }
        public bool xoaTaiKhoan(string TenTaiKhoan)
        {
            return dalTaiKhoan.xoaTaiKhoan(TenTaiKhoan);
        }
        public DataTable findTaiKhoan(string TenTaiKhoan)
        {
            return dalTaiKhoan.findTaiKhoan(TenTaiKhoan);
        }
    }
}
