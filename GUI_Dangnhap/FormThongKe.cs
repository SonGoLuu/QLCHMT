using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Dangnhap
{
    public partial class FormThongKe : UserControl
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTongThe_Click(object sender, EventArgs e)
        {
            int gt1 = 0, gt2 = 0, loaichon = 0;
            if (radioThang.Checked == true)
            {
                gt1 = Convert.ToInt32(cbbThang.Text);
                gt2 = Convert.ToInt32(cbbNamThang.Text);
                loaichon = 1;
            }
            else if (radioQuy.Checked == true)
            {
                gt1 = Convert.ToInt32(cbbQuy.Text);
                gt2 = Convert.ToInt32(cbbNamQuy.Text);
                loaichon = 2;
            }
            else if (radioNam.Checked == true)
            {
                gt1 = Convert.ToInt32(cbbNam1.Text);
                gt2 = Convert.ToInt32(cbbNam2.Text);
                loaichon = 3;
            }
            else if (radioTatCa.Checked == true)
            {
                gt1 = 0;
                gt2 = 0;
                loaichon = 4;
            }

            FormDoanhThuTongThe dttt = new FormDoanhThuTongThe(gt1, gt2, loaichon);
            dttt.ShowDialog();
        }

        private void btnTungSanPham_Click(object sender, EventArgs e)
        {
            int gt1 = 0, gt2 = 0, loaichon = 0;
            if (radioThang.Checked == true)
            {
                gt1 = Convert.ToInt32(cbbThang.Text);
                gt2 = Convert.ToInt32(cbbNamThang.Text);
                loaichon = 1;
            }
            else if (radioQuy.Checked == true)
            {
                gt1 = Convert.ToInt32(cbbQuy.Text);
                gt2 = Convert.ToInt32(cbbNamQuy.Text);
                loaichon = 2;
            }
            else if (radioNam.Checked == true)
            {
                gt1 = Convert.ToInt32(cbbNam1.Text);
                gt2 = Convert.ToInt32(cbbNam2.Text);
                loaichon = 3;
            }
            else if (radioTatCa.Checked == true)
            {
                gt1 = 0;
                gt2 = 0;
                loaichon = 4;
            }
            FormDoanhThuTungSanPham dttsp = new FormDoanhThuTungSanPham(gt1, gt2, loaichon);
            dttsp.ShowDialog();
        }
    }
}
