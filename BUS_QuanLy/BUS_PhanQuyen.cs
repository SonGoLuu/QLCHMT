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
    public class BUS_PhanQuyen
    {
        DAL_PhanQuyen dalPhanQuyen = new DAL_PhanQuyen();
        public string getMaQuyen(string TenQuyen)
        {
            return dalPhanQuyen.getMaQuyen(TenQuyen);
        }
        public string getTenQuyen(string MaQuyen)
        {
            return dalPhanQuyen.getTenQuyen(MaQuyen);
        }
        
        public DataTable getAllMaQuyen()
        {
            return dalPhanQuyen.getAllMaQuyen();
        }
        
        public DataTable getAllTenQuyen()
        {
            return dalPhanQuyen.getAllTenQuyen();
        }    
    }
}
