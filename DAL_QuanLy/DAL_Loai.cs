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
    public class DAL_Loai:DBConnect
    {
        public DataTable getAllLoai()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAISANPHAM", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }    
        
        //Lấy tên loại từ mã loại
        public string getTenLoai(string MaLoai)
        {
            cnn.Open();
            string sql = string.Format("SELECT TENLOAI FROM LOAISANPHAM WHERE MALOAI ='{0}'", MaLoai);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string TenLoai = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return TenLoai;

        }
        //Lấy mã loại từ tên loại
        public string getMaLoai(string TenLoai)
        {
            cnn.Open();
            string sql = string.Format("SELECT MALOAI FROM LOAISANPHAM WHERE TENLOAI ='{0}'", TenLoai);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string MaLoai = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return MaLoai;
        }
        //Thêm Loại
        public bool themLoai(DTO_Loai loai)
        {
            try
            {
                // Ket noi
                cnn.Open();
                string SQL = string.Format("INSERT INTO LOAISANPHAM (MALOAI, TENLOAI) VALUES ('{0}', N'{1}')", loai.MaLoai, loai.TenLoai);
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
        //Sửa Loại
        public bool suaLoai(DTO_Loai loai)
        {
            try
            {
                // Ket noi
                cnn.Open();
                string SQL = string.Format("UPDATE LOAISANPHAM SET TENLOAI = N'{0}' WHERE MALOAI ='{1}'", loai.TenLoai, loai.MaLoai);
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

        //Xóa Loại
        public bool xoaLoai(DTO_Loai loai)
        {
            try
            {
                // Ket noi
                cnn.Open();
                string SQL = string.Format("DELETE FROM LOAISANPHAM WHERE MALOAI ='{0}'", loai.MaLoai);
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

        //Tìm kiếm Loại
        public DataTable findLoai(string TenLoai)
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM LOAISANPHAM WHERE TENLOAI = N'{0}'", TenLoai);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
