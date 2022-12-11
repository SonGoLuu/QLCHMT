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
    public partial class FormDoanhThuTongThe : Form
    {
        int date1, date2, loai;
        public FormDoanhThuTongThe()
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

        private void HoaDonBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        public FormDoanhThuTongThe(int gt1, int gt2, int loaichon) : this()
        {
            date1 = gt1;
            date2 = gt2;
            loai = loaichon;
        }
        private void FormDoanhThuTongThe_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-5LK6RF58;Initial Catalog=SGLSTORE;Integrated Security=True");
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            if (loai == 1)
            {
                da = new SqlDataAdapter("Select * From HOADON Where MONTH(NGAYLAP) = '" + date1 + "' AND YEAR(NGAYLAP) = '" + date2 + "'", cnn);
            }
            else if (loai == 2)
            {
                da = new SqlDataAdapter("Select * From HOADON Where DATEPART(QUARTER, NGAYLAP) = '" + date1 + "' AND YEAR(NGAYLAP) = '" + date2 + "'", cnn);
            }
            else if (loai == 3)
            {
                da = new SqlDataAdapter("Select * From HOADON Where YEAR(NGAYLAP) >= '" + date1 + "' AND YEAR(NGAYLAP) <= '" + date2 + "'", cnn);
            }
            else if (loai == 4)
            {
                da = new SqlDataAdapter("Select * From HOADON", cnn);
            }
            DataTable dt = new DataTable("DataSetHoaDon");
            da.Fill(dt);
            cnn.Close();
            ReportDataSource rds = new ReportDataSource("DataSetHoaDon", dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
