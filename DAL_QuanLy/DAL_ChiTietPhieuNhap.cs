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
    public class DAL_ChiTietPhieuNhap:DBConnect
    {
        public DataTable getdgvCTHD()
        {
            cnn.Open();
            string sql = string.Format("SELECT A.MAPHIEU, B.MANCC, C.MASP, C.TENSP, A.GIAGOC, A.SLNHAP, A.THANHTIEN FROM CHITIETPHIEUNHAP A, PHIEUNHAP B, SANPHAM C WHERE A.MAPHIEU = B.MAPHIEU AND A.MASP = C.MASP");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable getCTHD()
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM CHITIETPHIEUNHAP");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public bool themCTPN(DTO_ChiTietPhieuNhap ctpn)
        {
            try
            {
                // Ket noi
                cnn.Open();
                string SQL = string.Format("INSERT INTO CHITIETPHIEUNHAP (MAPHIEU, MASP, GIAGOC, SLNHAP, THANHTIEN) VALUES ('{0}', '{1}', {2}, {3}, {4})", ctpn.MaPhieu, ctpn.MaSP, ctpn.GiaGoc, ctpn.SLNhap, ctpn.ThanhTien);
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
