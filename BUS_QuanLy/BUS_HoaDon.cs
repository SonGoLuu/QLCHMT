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
    public class BUS_HoaDon
    {
        DAL_HoaDon dalHoaDon = new DAL_HoaDon();
        public DataTable getAllHoaDon()
        {
            return dalHoaDon.getAllHoaDon();
        }
        public bool themHoaDon(DTO_HoaDon hoadon)
        {
            return dalHoaDon.themHoaDon(hoadon);
        }
        public DataTable findHoaDon(string SDTKH)
        {
            return dalHoaDon.findHoaDon(SDTKH);
        }
        public DataTable trongCTHD(string MaHD)
        {
            return dalHoaDon.trongCTHD(MaHD);
        }
    }
}
