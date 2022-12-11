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
    public class DAL_SanPham:DBConnect
    {
        public DataTable getAllSP()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SANPHAM", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy mã sp từ tên sp
        public string getMaSP(string TenSP)
        {
            cnn.Open();
            string sql = string.Format("SELECT MASP FROM SANPHAM WHERE TENSP ='{0}'", TenSP);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string MaSP = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return MaSP;
        }

        //Lấy thông tin sản phẩm từ mã sp
        public DataTable getThongTinSP(string MaSP)
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM SANPHAM WHERE MASP = '{0}'", MaSP);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        //Thêm sản phẩm
        public bool themSP(DTO_SanPham sp)
        {
            try
            {
                // Ket noi
                cnn.Open();
                string SQL = string.Format("INSERT INTO SANPHAM (MASP, TENSP, MALOAI, GIABAN, SLTON, THANGBAOHANH, XUATXU) VALUES ('{0}', N'{1}', '{2}', {3}, {4}, {5}, N'{6}')", sp.MaSP, sp.TenSP, sp.MaLoai, sp.GiaBan, sp.SLTon, sp.ThangBaoHanh, sp.XuatXu);
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
        //Sửa Sản phẩm
        public bool suaSP(DTO_SanPham sp)
        {
            try
            {
                // Ket noi
                cnn.Open();
                string SQL = string.Format("UPDATE SANPHAM SET TENSP = N'{0}', MALOAI ='{1}', GIABAN = {2}, SLTON = {3}, THANGBAOHANH = {4}, XUATXU = N'{5}' WHERE MASP ='{6}'", sp.TenSP, sp.MaLoai, sp.GiaBan, sp.SLTon, sp.ThangBaoHanh, sp.XuatXu, sp.MaSP);
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
        //Xóa SP
        public bool xoaSP(DTO_SanPham sp)
        {
            try
            {
                // Ket noi
                cnn.Open();
                string SQL = string.Format("DELETE FROM SANPHAM WHERE MASP='{0}'", sp.MaSP);
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
        //Tìm kiếm SP
        public DataTable findSP(string TenSP)
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM SANPHAM WHERE TENSP =N'{0}'", TenSP);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy tất cả mã sản phẩm
        public DataTable getAllMaSP()
        {
            cnn.Open();
            string sql = string.Format("SELECT MASP FROM SANPHAM");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public bool checkMaSP(string MaSP)
        {
            cnn.Open();
            string sql = string.Format("SELECT MASP FROM SANPHAM WHERE MASP ='{0}'", MaSP);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            if (dt.Rows.Count > 0) return true;
            else return false;
        }
        public bool updateSLTon(int SLMua, string MaSP)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("UPDATE SANPHAM SET SLTON = SLTON - {0} WHERE MASP = '{1}'", SLMua, MaSP);
                SqlCommand cmd = new SqlCommand(sql, cnn);
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
