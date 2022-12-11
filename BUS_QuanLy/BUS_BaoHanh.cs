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
    public class BUS_BaoHanh
    {
        DAL_BaoHanh dalBH = new DAL_BaoHanh();
        public DataTable getAllBaoHanh()
        {
            return dalBH.getAllBaoHanh();
        }
        public DataTable findBaoHanh(string sdtkh)
        {
            return dalBH.findBaoHanh(sdtkh);
        }
        public bool themBaoHanh(DTO_BaoHanh baohanh)
        {
            return dalBH.themBaoHanh(baohanh);
        }
    }
}
