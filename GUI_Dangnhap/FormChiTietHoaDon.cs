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
    public partial class FormChiTietHoaDon : Form
    {
        string _MaHD;
        BUS_CTHD busCTHD = new BUS_CTHD();
        BUS_HoaDon busHoaDon = new BUS_HoaDon();
        public FormChiTietHoaDon()
        {
            InitializeComponent();
        }
        public string MaHD
        {
            get
            {
                return _MaHD;
            }
            set
            {
                _MaHD = value;
            }
        }
        private void iconbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dgvCTHD.DataSource = busCTHD.getCTHD(this.MaHD);
            txtMaHD.Text = busHoaDon.trongCTHD(this.MaHD).Rows[0].Field<string>(0);
            txtSDTKH.Text = busHoaDon.trongCTHD(this.MaHD).Rows[0].Field<string>(1);
            txtMaNVLap.Text = busHoaDon.trongCTHD(this.MaHD).Rows[0].Field<string>(2);
            txtHoTenNV.Text = busHoaDon.trongCTHD(this.MaHD).Rows[0].Field<string>(3);
            txtNgayLap.Text = busHoaDon.trongCTHD(this.MaHD).Rows[0].Field<DateTime>(4).ToString("dd/MM/yyyy");
            txtTongTien.Text = Convert.ToString(busHoaDon.trongCTHD(this.MaHD).Rows[0].Field<decimal>(5));
        }
    }
}
