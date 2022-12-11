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
    public class BUS_SanPham
    {
        DAL_SanPham dalSP = new DAL_SanPham();
        public DataTable getAllSP()
        {
            return dalSP.getAllSP();
        }
        public string getMaSP(string TenSP)
        {
            return dalSP.getMaSP(TenSP);
        }
        public DataTable getThongTinSP(string MaSP)
        {
            return dalSP.getThongTinSP(MaSP);
        }
        public bool themSP(DTO_SanPham sp)
        {
            return dalSP.themSP(sp);
        }
        public bool suaSP(DTO_SanPham sp)
        {
            return dalSP.suaSP(sp);
        }
        public bool xoaSP(DTO_SanPham sp)
        {
            return dalSP.xoaSP(sp);
        }
        public DataTable findSP(string TenSP)
        {
            return dalSP.findSP(TenSP);
        }
        public DataTable getAllMaSP()
        {
            return dalSP.getAllMaSP();
        }
        public bool checkMaSP(string MaSP)
        {
            return dalSP.checkMaSP(MaSP);
        }
        public bool updateSLTon(int SLMua, string MaSP)
        {
            return dalSP.updateSLTon(SLMua, MaSP);
        }
    }
}
