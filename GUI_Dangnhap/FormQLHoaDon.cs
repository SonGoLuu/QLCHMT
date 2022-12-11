using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;

namespace GUI_Dangnhap
{
    public partial class FormQLHoaDon : UserControl
    {
        string _HoTenNV;
        BUS_HoaDon busHoaDon = new BUS_HoaDon();
        public FormQLHoaDon()
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
        private void FormQLHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = busHoaDon.getAllHoaDon();
        }
        
        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            string mahd = dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString();
            FormChiTietHoaDon ct = new FormChiTietHoaDon();
            ct.MaHD = mahd;
            ct.ShowDialog();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            FormLapHoaDon lhd = new FormLapHoaDon();
            lhd.HoTenNV = this.HoTenNV;
            lhd.MaHDCuoi = dgvHoaDon.Rows[dgvHoaDon.Rows.Count - 1].Cells[0].Value.ToString();
            lhd.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = busHoaDon.findHoaDon(txtFind.Texts);
        }

        private void txtFind__TextChanged(object sender, EventArgs e)
        {
            if(txtFind.Texts == "")
            {
                dgvHoaDon.DataSource = busHoaDon.getAllHoaDon();
            }    
        }
    }
}
