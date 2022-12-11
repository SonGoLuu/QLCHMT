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
    public partial class FormQLNhaCungCap : UserControl
    {
        BUS_NhaCungCap busNCC = new BUS_NhaCungCap();
        public FormQLNhaCungCap()
        {
            InitializeComponent();
        }

        private void FormQLNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = busNCC.getAllNCC();
        }

        private void dgvNCC_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNCC.SelectedRows[0];
            txtMaNCC.Text = row.Cells[0].Value.ToString();
            txtTenNCC.Text = row.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text != "" && txtTenNCC.Text != "")
            {
                DTO_NhaCungCap dtoNCC = new DTO_NhaCungCap();
                dtoNCC.MaNCC = txtMaNCC.Text;
                dtoNCC.TenNCC = txtTenNCC.Text;
                if (busNCC.themNCC(dtoNCC))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvNCC.DataSource = busNCC.getAllNCC();
                }
                else MessageBox.Show("Thêm không thành công!");
            }
            else MessageBox.Show("Vui lòng điền đầy đủ!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count > 0)
            {
                if (txtMaNCC.Text != "" && txtTenNCC.Text != "")
                {
                    DTO_NhaCungCap dtoNCC = new DTO_NhaCungCap();
                    dtoNCC.MaNCC = txtMaNCC.Text;
                    dtoNCC.TenNCC = txtTenNCC.Text;
                    if (busNCC.suaNCC(dtoNCC))
                    {
                        MessageBox.Show("Sửa thành công!");
                        dgvNCC.DataSource = busNCC.getAllNCC();
                    }
                    else MessageBox.Show("Sửa không thành công!");
                }
                else MessageBox.Show("Vui lòng điền đầy đủ!");
            }
            else MessageBox.Show("Hãy chọn Nhà cung cấp cần sửa!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count > 0)
            {
                if (txtMaNCC.Text != "" && txtTenNCC.Text != "")
                {
                    DTO_NhaCungCap dtoNCC = new DTO_NhaCungCap();
                    dtoNCC.MaNCC = txtMaNCC.Text;
                    dtoNCC.TenNCC = txtTenNCC.Text;
                    if (busNCC.xoaNCC(dtoNCC))
                    {
                        MessageBox.Show("Xóa thành công!");
                        dgvNCC.DataSource = busNCC.getAllNCC();
                        txtMaNCC.Text = "";
                        txtTenNCC.Text = "";
                    }
                    else MessageBox.Show("Xóa không thành công!");
                }
                else MessageBox.Show("Thiếu thông tin cần thiết!");
            }
            else MessageBox.Show("Hãy chọn Nhà cung cấp cần xóa!");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvNCC.DataSource = busNCC.findNCC(txtFind.Texts);
        }

        private void txtFind__TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Texts == "")
            {
                dgvNCC.DataSource = busNCC.getAllNCC();
                txtMaNCC.Text = "";
                txtTenNCC.Text = "";
            }
        }

        private void txtMaNCC_Enter(object sender, EventArgs e)
        {
            string soncccuoi = dgvNCC.Rows[dgvNCC.Rows.Count - 1].Cells[0].Value.ToString();
            string sonccmoi = (Convert.ToInt32(soncccuoi.Substring(3)) + 1).ToString();
            if (Convert.ToInt32(sonccmoi) <= 9) txtMaNCC.Text = "NCC0" + sonccmoi;
            else txtMaNCC.Text = "NCC" + sonccmoi;
        }
    }
}
