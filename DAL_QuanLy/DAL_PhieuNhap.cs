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
     public class DAL_PhieuNhap:DBConnect
    {
        public DataTable getPhieuNhap(string MaPhieu)
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM PHIEUNHAP WHERE MAPHIEU = '{0}'", MaPhieu);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm phiếu nhập
        public bool themPhieuNhap(DTO_PhieuNhap phieunhap)
        {
            try
            {
                // Ket noi
                cnn.Open();
                string SQL = string.Format("INSERT INTO PHIEUNHAP (MAPHIEU, MANCC, MANVNHAP, NGAYNHAP, TONGTIEN) VALUES ('{0}', '{1}', '{2}', '{3}', {4})", phieunhap.MaPhieu, phieunhap.MaNCC, phieunhap.MaNVNhap, phieunhap.NgayNhap.ToString("yyyyMMdd"), phieunhap.TongTien);
                SqlCommand cmd = new SqlCommand(SQL, cnn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                cnn.Close();
            }

            return false;
        }
        public bool checkMaPhieu(string MaPhieu)
        {
            cnn.Open();
            string sql = string.Format("SELECT MAPHIEU FROM PHIEUNHAP WHERE MAPHIEU = '{0}'", MaPhieu);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            { return false; }
        }

        //Sửa phiếu nhập
        public bool suaPhieuNhap(decimal tongtien, string maphieu)
        {
            try
            {
                // Ket noi
                cnn.Open();
                string SQL = string.Format("UPDATE PHIEUNHAP SET TONGTIEN ={0} WHERE MAPHIEU ='{1}'", tongtien, maphieu);
                SqlCommand cmd = new SqlCommand(SQL, cnn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                cnn.Close();
            }

            return false;
        }
    }
}
