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
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap dalNCC = new DAL_NhaCungCap();
        public DataTable getAllNCC()
        {
            return dalNCC.getAllNCC();
        }
        public string getMaNCC(string TenNCC)
        {
            return dalNCC.getMaNCC(TenNCC);
        }
        public DataTable getAllTenNCC()
        {
            return dalNCC.getAllTenNCC();
        }
        public bool themNCC(DTO_NhaCungCap ncc)
        {
            return dalNCC.themNCC(ncc);
        }
        public bool suaNCC(DTO_NhaCungCap ncc)
        {
            return dalNCC.suaNCC(ncc);
        }
        public bool xoaNCC(DTO_NhaCungCap ncc)
        {
            return dalNCC.xoaNCC(ncc);
        }
        public DataTable findNCC(string TenNCC)
        {
            return dalNCC.findNCC(TenNCC);
        }
        public string getTenNCC(string mancc)
        {
            return dalNCC.getTenNCC(mancc);
        }
    }
}
