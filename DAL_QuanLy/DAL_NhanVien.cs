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
    public class DAL_NhanVien : DBConnect
    {
        /// <summary>
        /// Get toàn bộ nhân viên
        /// </summary>
        /// <returns></returns>
        public DataTable getNhanVien()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien", cnn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            cnn.Close();
            return dtNhanVien;
        }
        /// <summary>
        /// Thêm nhân viên
        /// </summary>
        /// <returns></returns>
        public bool themNhanVien(DTO_NhanVien nv)
        {
            try
            {
                // Ket noi
                cnn.Open();
                string SQL = string.Format("INSERT INTO NHANVIEN(MANV, HOTENNV, CHUCVU, NGAYSINH, GIOITINH, SDTNV, DIACHI) VALUES ('{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}', N'{6}')", nv.MaNV, nv.HoTenNV, nv.ChucVu, nv.NgaySinh.ToString("yyyMMdd"), nv.GioiTinh, nv.SDTNV, nv.DiaChi);
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
        public bool suaNhanVien(DTO_NhanVien nv)
        {
            try
            {
                // Ket noi
                cnn.Open();
                // Query string
                string SQL = string.Format("UPDATE NHANVIEN SET HOTENNV = N'{0}', CHUCVU = N'{1}', NGAYSINH = '{2}', GIOITINH = N'{3}', SDTNV = '{4}', DIACHI = N'{5}' WHERE MANV = '{6}'", nv.HoTenNV, nv.ChucVu, nv.NgaySinh.ToString("yyyMMdd"), nv.GioiTinh, nv.SDTNV, nv.DiaChi, nv.MaNV);
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
        public bool xoaNhanVien(string MANV)
        {
            try
            {
                // Ket noi
                cnn.Open();
                string SQL = string.Format("DELETE FROM NHANVIEN WHERE MANV = '{0}'", MANV);
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
        public DataTable findNhanVien(string HoTenNV)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT * FROM NHANVIEN WHERE HOTENNV = N'{0}'", HoTenNV);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtFindNhanVien = new DataTable();
            da.Fill(dtFindNhanVien);
            cnn.Close();
            return dtFindNhanVien;
        }

        //Lấy họ tên nhân viên
        public string getHoTenNhanVien(string MaNV)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT HOTENNV FROM NHANVIEN WHERE MANV = '{0}'", MaNV);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtTenNhanVien = new DataTable();
            da.Fill(dtTenNhanVien);
            string HoTenNV = dtTenNhanVien.Rows[0].Field<string>(0); 
            cnn.Close();
            return HoTenNV;
        }

        //Lấy chức vụ nhân viên
        public string getChucVu(string MaNV)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT CHUCVU FROM NHANVIEN WHERE MANV = '{0}'", MaNV);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtChucVu = new DataTable();
            da.Fill(dtChucVu);
            string ChucVu = dtChucVu.Rows[0].Field<string>(0);
            cnn.Close();
            return ChucVu;
        }

        //Lấy danh sách Mã Nhân Viên chưa có tài khoản
        public DataTable getMaNVChuaCoTaiKhoan()
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT MANV FROM NHANVIEN EXCEPT SELECT MANV FROM TAIKHOAN");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtDsMaNV = new DataTable();
            da.Fill(dtDsMaNV);
            cnn.Close();
            return dtDsMaNV;
        }

    }
}
