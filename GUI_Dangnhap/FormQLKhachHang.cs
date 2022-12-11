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
    public partial class FormQLKhachHang : UserControl
    {
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        public FormQLKhachHang()
        {
            InitializeComponent();
        }

        private void UserControlQLKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = busKhachHang.getAllKhachHang();
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvKhachHang.SelectedRows[0];
            txtMaKH.Text = row.Cells[0].Value.ToString();
            txtHoTenKH.Text = row.Cells[1].Value.ToString();
            txtSDTKH.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtHoTenKH.Text != "" && txtSDTKH.Text != "" && txtDiaChi.Text != "")
            { 
                string makh = txtMaKH.Text;
                string hotenkh = txtHoTenKH.Text;
                string sdtkh = txtSDTKH.Text;
                string diachi = txtDiaChi.Text;
                DTO_KhachHang dtoKhachHang = new DTO_KhachHang(makh, hotenkh, sdtkh, diachi);
                if (busKhachHang.themKhachHang(dtoKhachHang))
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    dgvKhachHang.DataSource = busKhachHang.getAllKhachHang();
                }    
                else MessageBox.Show("Thêm khách hàng không thành công!");
            }
            else MessageBox.Show("Vui lòng điền đầy đủ!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                if (txtMaKH.Text != "" && txtHoTenKH.Text != "" && txtSDTKH.Text != "" && txtDiaChi.Text != "")
                {
                    string makh = txtMaKH.Text;
                    string hotenkh = txtHoTenKH.Text;
                    string sdtkh = txtSDTKH.Text;
                    string diachi = txtDiaChi.Text;
                    DTO_KhachHang dtoKhachHang = new DTO_KhachHang(makh, hotenkh, sdtkh, diachi);
                    if (busKhachHang.suaKhachHang(dtoKhachHang))
                    {
                        MessageBox.Show("Sửa khách hàng thành công!");
                        dgvKhachHang.DataSource = busKhachHang.getAllKhachHang();
                    }
                    else MessageBox.Show("Sửa khách hàng không thành công!");
                }
                else MessageBox.Show("Vui lòng điền đầy đủ!");
            }
            else MessageBox.Show("Chọn khách hàng cần sửa!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                if (txtMaKH.Text != "" && txtHoTenKH.Text != "" && txtSDTKH.Text != "" && txtDiaChi.Text != "")
                {
                    string makh = txtMaKH.Text;
                    string hotenkh = txtHoTenKH.Text;
                    string sdtkh = txtSDTKH.Text;
                    string diachi = txtDiaChi.Text;
                    DTO_KhachHang dtoKhachHang = new DTO_KhachHang(makh, hotenkh, sdtkh, diachi);
                    if (busKhachHang.xoaKhachHang(dtoKhachHang))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        dgvKhachHang.DataSource = busKhachHang.getAllKhachHang();
                    }
                    else MessageBox.Show("Xóa khách hàng không thành công!");
                }
            }
            else MessageBox.Show("Chọn khách hàng cần xóa!");
        }

        private void btnFindKH_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = busKhachHang.findKhachHang(txtFindKH.Texts);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = busKhachHang.getAllKhachHang();
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtSDTKH.Text = "";
            txtDiaChi.Text = "";
            txtFindKH.Texts = "";
        }

        private void txtMaKH_Enter(object sender, EventArgs e)
        {
            string sokhcuoi = dgvKhachHang.Rows[dgvKhachHang.Rows.Count - 1].Cells[0].Value.ToString();
            string sokhmoi = (Convert.ToInt32(sokhcuoi.Substring(2)) + 1).ToString();
            if (Convert.ToInt32(sokhmoi) <= 9) txtMaKH.Text = "KH0" + sokhmoi;
            else txtMaKH.Text = "KH" + sokhmoi;
        }
    }
}
