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
    public class DAL_TaiKhoan:DBConnect
    {
        //Kiểm tra tài khoản 
        public bool checkTaiKhoan(string TenTaiKhoan, string MatKhau, string NguoiDung)
        {
            if(NguoiDung == "Admin")
            {
                cnn.Open();
                string sql = string.Format("SELECT * FROM TAIKHOAN WHERE TENTAIKHOAN = '{0}' AND MATKHAU = '{1}'AND MAQUYEN = '1'", TenTaiKhoan, MatKhau);
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();
                if (dt.Rows.Count > 0) return true;
                else return false;
            }
            else
            {
                cnn.Open();
                string sql = string.Format("SELECT * FROM TAIKHOAN WHERE TENTAIKHOAN = '{0}'ANd MATKHAU = '{1}'AND MAQUYEN = '2'", TenTaiKhoan, MatKhau);
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();
                if (dt.Rows.Count > 0) return true;
                else return false;
            }       
        }

        //Lấy mã nhân viên của tài khoản
        public string getMaNVTaiKhoan(string TenTaiKhoan)
        {
            cnn.Open();
            string sql = string.Format("SELECT MANV FROM TAIKHOAN WHERE TENTAIKHOAN = '{0}'", TenTaiKhoan);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string manv = dt.Rows[0].Field<string>(0); 
            cnn.Close();
            return manv;
        }

        //Lấy danh sách tài khoản
        public DataTable getAllTaiKhoan()
        {
            cnn.Open();
            string sql = string.Format("SELECT A.TENTAIKHOAN, A.MATKHAU, B.TENQUYEN, C.HOTENNV, C.CHUCVU FROM TAIKHOAN A, PHANQUYEN B, NHANVIEN C WHERE A.MAQUYEN = B.MAQUYEN AND A.MANV = C.MANV");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        //Lấy tên tài khoản từ mã nhân viên
        public string getTenTaiKhoanFromMaNV(string MaNV)
        {
            cnn.Open();
            string sql = string.Format("SELECT TENTAIKHOAN FROM TAIKHOAN WHERE MANV = '{0}'", MaNV);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string tentaikhoan = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return tentaikhoan;
        }
        //Lấy tên phân quyền từ tên tài khoản
        public string getPhanQuyenFromTenTaiKhoan(string TenTaiKhoan)
        {
            cnn.Open();
            string sql = string.Format("SELECT B.TENQUYEN FROM TAIKHOAN A, PHANQUYEN B WHERE A.MAQUYEN = B.MAQUYEN AND  A.TENTAIKHOAN= '{0}'", TenTaiKhoan);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string tenquyen = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return tenquyen;
        }
        //Lấy mật khẩu từ tên tài khoản
        public string getMatKhauFromTenTaiKhoan(string TenTaiKhoan)
        {
            cnn.Open();
            string sql = string.Format("SELECT MATKHAU FROM TAIKHOAN WHERE TENTAIKHOAN= '{0}'", TenTaiKhoan);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string matkhau = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return matkhau;
        }
        //Lấy tất cả mã nhân viên
        public DataTable getAllMaNVTaiKhoan()
        {
            cnn.Open();
            string sql = string.Format("SELECT MANV FROM TAIKHOAN");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Tạo mới tài khoản
        public bool themTaiKhoan(string TenTaiKhoan, string MatKhau, string MaNV, string MaQuyen)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("INSERT INTO TAIKHOAN (TENTAIKHOAN, MATKHAU, MANV, MAQUYEN) VALUES ('{0}', '{1}', '{2}', '{3}')", TenTaiKhoan, MatKhau, MaNV, MaQuyen);
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
        //Sửa tài khoản
        public bool suaTaiKhoan(string TenTaiKhoan, string MatKhau, string MaNV, string MaQuyen)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("UPDATE TAIKHOAN SET MATKHAU ='{0}', MAQUYEN ='{1}' WHERE TENTAIKHOAN = '{2}' AND MANV = '{3}'", MatKhau, MaQuyen, TenTaiKhoan, MaNV);
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
        //Xóa tài khoản
        public bool xoaTaiKhoan(string TenTaiKhoan)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("DELETE FROM TAIKHOAN WHERE TENTAIKHOAN = '{0}'",TenTaiKhoan);
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

        //Tìm kiếm theo tên tài khoản
        public DataTable findTaiKhoan(string TenTaiKhoan)
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM TAIKHOAN WHERE TENTAIKHOAN ='{0}'", TenTaiKhoan);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
