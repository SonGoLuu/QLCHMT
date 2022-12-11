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
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();
        public DataTable getAllKhachHang()
        {
            return dalKhachHang.getAllKhachHang();
        }
        public string getHoTenKhachHang(string MaKH)
        {
            return dalKhachHang.getHoTenKhachHang(MaKH);
        }
        public string getSDTKH(string MaKH)
        {
            return dalKhachHang.getSDTKH(MaKH);
        }
        public string getDiaChi(string MaKH)
        {
            return dalKhachHang.getDiaChi(MaKH);
        }
        public string getMaKHFromSDTKH(string SDTKH)
        {
            return dalKhachHang.getMaKHFromSDTKH(SDTKH);
        }
        public bool themKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.themKhachHang(kh);
        }
        public bool suaKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.suaKhachHang(kh);
        }
        public bool xoaKhachHang(DTO_KhachHang kh)
        {
            return dalKhachHang.xoaKhachHang(kh);
        }
        public DataTable findKhachHang(string SDTKH)
        {
            return dalKhachHang.findKhachHang(SDTKH);
        }
        public bool checkMaKH(string MaKH)
        {
            return dalKhachHang.checkMaKH(MaKH);
        }
    }
}
