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
    public class BUS_CTBH
    {
        DAL_ChiTietBaoHanh dalCTBH = new DAL_ChiTietBaoHanh();
        public bool checkBaoHanh(string mahd, string masp, int thangbaohanh)
        {
            return dalCTBH.checkBaoHanh(mahd, masp, thangbaohanh);
        }
        public bool themCTBH(DTO_ChiTietBaoHanh ctbh)
        {
            return dalCTBH.themCTBH(ctbh);
        }
    }
}
