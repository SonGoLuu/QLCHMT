using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace GUI_Dangnhap
{
    public partial class FormDoanhThuTungSanPham : Form
    {
        int date1, date2, loai;
        public FormDoanhThuTungSanPham()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        public FormDoanhThuTungSanPham(int gt1, int gt2, int loaichon) : this()
        {
            date1 = gt1;
            date2 = gt2;
            loai = loaichon;
        }
        private void FormDoanhThuTungSanPham_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-5LK6RF58;Initial Catalog=SGLSTORE;Integrated Security=True");
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataAdapter da2 = new SqlDataAdapter();
            if (loai == 1)
            {
                da = new SqlDataAdapter("Select DISTINCT SANPHAM.MASP, SANPHAM.TENSP, SANPHAM.MALOAI, SANPHAM.GIABAN, SANPHAM.SLTON, SANPHAM.THANGBAOHANH, SANPHAM.XUATXU" +
                    " From SANPHAM, CHITIETHOADON, HOADON Where SANPHAM.MASP = CHITIETHOADON.MASP" +
                    " And CHITIETHOADON.MAHD = HOADON.MAHD And MONTH(HOADON.NGAYLAP) = '" + date1 + "' " +
                    "AND YEAR(HOADON.NGAYLAP) = '" + date2 + "'", cnn);
                da2 = new SqlDataAdapter("Select DISTINCT CHITIETHOADON.MAHD, CHITIETHOADON.MASP, CHITIETHOADON.SLMUA, CHITIETHOADON.KHUYENMAI, CHITIETHOADON.THANHTIEN" +
                    " From SANPHAM, CHITIETHOADON, HOADON Where SANPHAM.MASP = CHITIETHOADON.MASP" +
                    " And CHITIETHOADON.MAHD = HOADON.MAHD And MONTH(HOADON.NGAYLAP) = '" + date1 + "' " +
                    "AND YEAR(HOADON.NGAYLAP) = '" + date2 + "'", cnn);
            }
            else if (loai == 2)
            {
                da = new SqlDataAdapter("Select DISTINCT SANPHAM.MASP, SANPHAM.TENSP, SANPHAM.MALOAI, SANPHAM.GIABAN, SANPHAM.SLTON, SANPHAM.THANGBAOHANH, SANPHAM.XUATXU" +
                    " From SANPHAM, CHITIETHOADON, HOADON Where SANPHAM.MASP = CHITIETHOADON.MASP" +
                    " And CHITIETHOADON.MAHD = HOADON.MAHD And DATEPART(QUARTER, HOADON.NGAYLAP) = '" + date1 + "' " +
                    "AND YEAR(HOADON.NGAYLAP) = '" + date2 + "'", cnn);
                da2 = new SqlDataAdapter("Select DISTINCT CHITIETHOADON.MAHD, CHITIETHOADON.MASP, CHITIETHOADON.SLMUA, CHITIETHOADON.KHUYENMAI, CHITIETHOADON.THANHTIEN" +
                    " From SANPHAM, CHITIETHOADON, HOADON Where SANPHAM.MASP = CHITIETHOADON.MASP" +
                    " And CHITIETHOADON.MAHD = HOADON.MAHD And DATEPART(QUARTER, HOADON.NGAYLAP) = '" + date1 + "' " +
                    "AND YEAR(HOADON.NGAYLAP) = '" + date2 + "'", cnn);
            }
            else if (loai == 3)
            {
                da = new SqlDataAdapter("Select DISTINCT SANPHAM.MASP, SANPHAM.TENSP, SANPHAM.MALOAI, SANPHAM.GIABAN, SANPHAM.SLTON, SANPHAM.THANGBAOHANH, SANPHAM.XUATXU" +
                    " From SANPHAM, CHITIETHOADON, HOADON Where SANPHAM.MASP = CHITIETHOADON.MASP" +
                    " And CHITIETHOADON.MAHD = HOADON.MAHD And YEAR(HOADON.NGAYLAP) >= '" + date1 + "' " +
                    "AND YEAR(HOADON.NGAYLAP) <= '" + date2 + "'", cnn);
                da2 = new SqlDataAdapter("Select DISTINCT CHITIETHOADON.MAHD, CHITIETHOADON.MASP, CHITIETHOADON.SLMUA, CHITIETHOADON.KHUYENMAI, CHITIETHOADON.THANHTIEN" +
                    " From SANPHAM, CHITIETHOADON, HOADON Where SANPHAM.MASP = CHITIETHOADON.MASP" +
                    " And CHITIETHOADON.MAHD = HOADON.MAHD And YEAR(HOADON.NGAYLAP) >= '" + date1 + "' " +
                    "AND YEAR(HOADON.NGAYLAP) <= '" + date2 + "'", cnn);
            }
            else if (loai == 4)
            {
                da = new SqlDataAdapter("Select * From SANPHAM", cnn);
                da2 = new SqlDataAdapter("Select * From CHITIETHOADON", cnn);
            }
            DataTable dt = new DataTable("DataSetSanPham");
            da.Fill(dt);
            DataTable dt2 = new DataTable("DataSetCTHD");
            da2.Fill(dt2);
            cnn.Close();
            ReportDataSource rds = new ReportDataSource("DataSetSanPham", dt);
            ReportDataSource rds2 = new ReportDataSource("DataSetCTHD", dt2);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.RefreshReport();

        }
    }
}
