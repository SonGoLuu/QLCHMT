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
    public class DAL_ChiTietHoaDon:DBConnect
    {
        public DataTable getCTHD(string MaHD)
        {
            cnn.Open();
            string sql = string.Format("SELECT A.MASP, B.TENSP, B.GIABAN, A.SLMUA, A.KHUYENMAI, A.THANHTIEN FROM CHITIETHOADON A, SANPHAM B WHERE A.MASP = B.MASP AND A.MAHD = '{0}'", MaHD);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public bool themCTHD(DTO_ChiTietHoaDon cthd)
        {
            try
            {
                // Ket noi
                cnn.Open();
                string SQL = string.Format("INSERT INTO CHITIETHOADON (MAHD, MASP, SLMUA, KHUYENMAI, THANHTIEN) VALUES ('{0}', '{1}', {2}, {3}, {4})", cthd.MaHD, cthd.MaSP, cthd.SLMua, cthd.KhuyenMai, cthd.ThanhTien);
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
