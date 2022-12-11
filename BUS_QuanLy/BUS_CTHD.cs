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
    public class BUS_CTHD
    {
        DAL_ChiTietHoaDon dalcthd = new DAL_ChiTietHoaDon();
        public DataTable getCTHD(string MaHD)
        {
            return dalcthd.getCTHD(MaHD);
        }
        public bool themCTHD(DTO_ChiTietHoaDon cthd)
        {
            return dalcthd.themCTHD(cthd);
        }
    }
}
