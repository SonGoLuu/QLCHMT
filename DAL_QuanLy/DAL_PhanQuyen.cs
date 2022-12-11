using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_PhanQuyen:DBConnect
    {
        public string getMaQuyen(string TenQuyen)
        {
            cnn.Open();
            string sql = string.Format("SELECT MAQUYEN FROM PHANQUYEN WHERE TENQUYEN = N'{0}'", TenQuyen);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string MaQuyen = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return MaQuyen;
            
        }
        public string getTenQuyen(string MaQuyen)
        {
            cnn.Open();
            string sql = string.Format("SELECT MAQUYEN FROM PHANQUYEN WHERE TENQUYEN = N'{0}'", MaQuyen);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string TenQuyen = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return TenQuyen;

        }
        public DataTable getAllMaQuyen()
        {
            cnn.Open();
            string sql = string.Format("SELECT MAQUYEN FROM PHANQUYEN ");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dtAllMaQuyen = new DataTable();
            da.Fill(dtAllMaQuyen);
            cnn.Close();
            return dtAllMaQuyen;
        }
        public DataTable getAllTenQuyen()
        {
            cnn.Open();
            string sql = string.Format("SELECT TENQUYEN FROM PHANQUYEN ");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dtAllTenQuyen = new DataTable();
            da.Fill(dtAllTenQuyen);
            cnn.Close();
            return dtAllTenQuyen;
        }
    }
}
