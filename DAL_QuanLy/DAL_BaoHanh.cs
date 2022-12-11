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
    public class DAL_BaoHanh:DBConnect
    {
        public DataTable getAllBaoHanh()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT A.MABH, B.SDTKH, A.MANVLAP, E.TENSP, A.NGAYLAP, A.NGAYHENTRA, D.GHICHU  FROM BAOHANH A, KHACHHANG B, NHANVIEN C, CHITIETBAOHANH D, SANPHAM E WHERE A.MAKH = B.MAKH AND A.MANVLAP = C.MANV AND A.MABH = D.MABH AND D.MASP = E.MASP", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable findBaoHanh(string sdtkh)
        {
            cnn.Open();
            string sql = string.Format("SELECT A.MABH, B.SDTKH, A.MANVLAP, E.TENSP, A.NGAYLAP, A.NGAYHENTRA, D.GHICHU  FROM BAOHANH A, KHACHHANG B, NHANVIEN C, CHITIETBAOHANH D, SANPHAM E WHERE A.MAKH = B.MAKH AND A.MANVLAP = C.MANV AND A.MABH = D.MABH AND D.MASP = E.MASP AND B.SDTKH = '{0}'", sdtkh);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm bảo hành
        public bool themBaoHanh(DTO_BaoHanh baohanh)
        {
            try
            {
                // Ket noi
                cnn.Open();
                string SQL = string.Format("INSERT INTO BAOHANH (MABH, MAKH, MANVLAP, NGAYLAP, NGAYHENTRA) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", baohanh.MaBH, baohanh.MaKH, baohanh.MaNVLap, baohanh.NgayLap.ToString("yyyyMMdd"), baohanh.NgayHenTra.ToString("yyyyMMdd"));
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
