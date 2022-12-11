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
    public class BUS_PhieuNhap
    {
        DAL_PhieuNhap dalPhieuNhap = new DAL_PhieuNhap();
        public DataTable getPhieuNhap(string MaPhieu)
        {
            return dalPhieuNhap.getPhieuNhap(MaPhieu);
        }
        public bool themPhieuNhap(DTO_PhieuNhap phieunhap)
        {
            return dalPhieuNhap.themPhieuNhap(phieunhap);
        }
        public bool checkMaPhieu(string MaPhieu)
        {
            return dalPhieuNhap.checkMaPhieu(MaPhieu);
        }
        public bool suaPhieuNhap(decimal tongtien, string maphieu)
        {
            return dalPhieuNhap.suaPhieuNhap(tongtien, maphieu);
        }
    }
}
