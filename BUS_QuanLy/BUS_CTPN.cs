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
    public class BUS_CTPN
    {
        DAL_ChiTietPhieuNhap dalCTPN = new DAL_ChiTietPhieuNhap();
        public DataTable getdgvCTHD()
        {
            return dalCTPN.getdgvCTHD();
        }
        public DataTable getCTHD()
        {
            return dalCTPN.getCTHD();
        }
        public bool themCTPN(DTO_ChiTietPhieuNhap ctpn)
        {
            return dalCTPN.themCTPN(ctpn);
        }
        
    }
}
