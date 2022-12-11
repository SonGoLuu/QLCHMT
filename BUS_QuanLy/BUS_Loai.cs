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
    public class BUS_Loai
    {
        DAL_Loai dalLoai = new DAL_Loai();
        public DataTable getAllLoai()
        {
            return dalLoai.getAllLoai();
        }
        public string getTenLoai(string MaLoai)
        {
            return dalLoai.getTenLoai(MaLoai);
        }
        public string getMaLoai(string TenLoai)
        {
            return dalLoai.getMaLoai(TenLoai);
        }
        public bool themLoai(DTO_Loai loai)
        {
            return dalLoai.themLoai(loai);
        }
        public bool suaLoai(DTO_Loai loai)
        {
            return dalLoai.suaLoai(loai);
        }
        public bool xoaLoai(DTO_Loai loai)
        {
            return dalLoai.xoaLoai(loai);
        }
        public DataTable findLoai(string TenLoai)
        {
            return dalLoai.findLoai(TenLoai);
        }
    }
}
