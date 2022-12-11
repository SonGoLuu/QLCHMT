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
    public class DAL_ChiTietBaoHanh:DBConnect
    {
     
        public bool checkBaoHanh(string mahd, string masp, int thangbaohanh)
        {
            cnn.Open();
            string sql = string.Format("SELECT A.NGAYLAP FROM HOADON A, CHITIETHOADON B WHERE A.MAHD = B.MAHD AND A.MAHD = '{0}' AND B.MASP = '{1}'", mahd, masp);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            DateTime ngaylaphd = dt.Rows[0].Field<DateTime>(0);
            TimeSpan tru = DateTime.Now - ngaylaphd;
            int songay = tru.Days;
            if (songay < thangbaohanh * 30) return true;
            else return false;
        }
        //Thêm chi tiết bảo hành
        public bool themCTBH(DTO_ChiTietBaoHanh ctbh)
        {
            try
            {
                // Ket noi
                cnn.Open();
                string SQL = string.Format("INSERT INTO CHITIETBAOHANH (MABH, MAHD, MASP, GHICHU) VALUES ('{0}', '{1}', '{2}', N'{3}')", ctbh.MaBH, ctbh.MaHD, ctbh.MaSP, ctbh.GhiChu);
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
