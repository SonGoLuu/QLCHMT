using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_Dangnhap
{
    public partial class FormBaoHanh : UserControl
    {
        string _HoTenNV;
        BUS_BaoHanh busBH = new BUS_BaoHanh();
        public FormBaoHanh()
        {
            InitializeComponent();
        }
        public string HoTenNV
        {
            get
            {
                return _HoTenNV;
            }
            set
            {
                _HoTenNV = value;
            }
        }
        private void btnLapBH_Click(object sender, EventArgs e)
        {
            FormLapBaoHanh lbh = new FormLapBaoHanh();
            lbh.HoTenNV = this.HoTenNV;
            string mabhcuoi = dgvBH.Rows[dgvBH.Rows.Count - 1].Cells[0].Value.ToString();
            string sobhmoi = (Convert.ToInt32(mabhcuoi.Substring(2)) + 1).ToString();
            if (Convert.ToInt32(sobhmoi) <= 9) lbh.MaBH = "BH0" + sobhmoi;
            else lbh.MaBH = "BH" + sobhmoi;
            lbh.ShowDialog();
        }

        private void FormBaoHanh_Load(object sender, EventArgs e)
        {
            dgvBH.DataSource = busBH.getAllBaoHanh();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvBH.DataSource = busBH.findBaoHanh(txtFind.Texts);
        }

        private void txtFind__TextChanged(object sender, EventArgs e)
        {
            if(txtFind.Texts == "")
            {
                dgvBH.DataSource = busBH.getAllBaoHanh();
            }    
        }
    }
}
