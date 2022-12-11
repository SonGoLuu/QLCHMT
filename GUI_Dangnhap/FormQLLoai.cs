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
    public partial class FormQLLoai : Form
    {
        BUS_Loai busLoai = new BUS_Loai();
        public FormQLLoai()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormQLLoai_Load(object sender, EventArgs e)
        {
            dgvLoai.DataSource = busLoai.getAllLoai();
        }

        private void iconbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLoai_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvLoai.SelectedRows[0];
            txtMaLoai.Text = row.Cells[0].Value.ToString();
            txtTenLoai.Text = row.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaLoai.Text!="" && txtTenLoai.Text !="")
            {
                DTO_Loai dtoLoai = new DTO_Loai();
                dtoLoai.MaLoai = txtMaLoai.Text;
                dtoLoai.TenLoai = txtTenLoai.Text;
                if(busLoai.themLoai(dtoLoai))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvLoai.DataSource = busLoai.getAllLoai();
                }    
                else MessageBox.Show("Thêm không thành công!");
            }
            else MessageBox.Show("Vui lòng điền đầy đủ!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvLoai.SelectedRows.Count>0)
            {
                if(txtMaLoai.Text != "" && txtTenLoai.Text != "")
                {
                    DTO_Loai dtoLoai = new DTO_Loai();
                    dtoLoai.MaLoai = txtMaLoai.Text;
                    dtoLoai.TenLoai = txtTenLoai.Text;
                    if (busLoai.suaLoai(dtoLoai))
                    {
                        MessageBox.Show("Sửa thành công!");
                        dgvLoai.DataSource = busLoai.getAllLoai();
                    }
                    else MessageBox.Show("Sửa không thành công!");
                }
                else MessageBox.Show("Vui lòng điền đầy đủ!");
            }   
            else MessageBox.Show("Hãy chọn Loại cần sửa!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLoai.SelectedRows.Count > 0)
            {
                if (txtMaLoai.Text != "" && txtTenLoai.Text != "")
                {
                    DTO_Loai dtoLoai = new DTO_Loai();
                    dtoLoai.MaLoai = txtMaLoai.Text;
                    dtoLoai.TenLoai = txtTenLoai.Text;
                    if (busLoai.xoaLoai(dtoLoai))
                    {
                        MessageBox.Show("Xóa thành công!");
                        dgvLoai.DataSource = busLoai.getAllLoai();
                    }
                    else MessageBox.Show("Xóa không thành công!");
                }
                else MessageBox.Show("Thiếu thông tin cần thiết!");
            }
            else MessageBox.Show("Hãy chọn Loại cần xóa!");
        }

        private void btnFindLoai_Click(object sender, EventArgs e)
        {
            dgvLoai.DataSource = busLoai.findLoai(txtFindLoai.Texts);
        }

        private void txtFindLoai__TextChanged(object sender, EventArgs e)
        {
            if(txtFindLoai.Texts == "")
            {
                dgvLoai.DataSource = busLoai.getAllLoai();
                txtMaLoai.Text = "";
                txtTenLoai.Text = "";
            }    
        }

        private void txtMaLoai_Enter(object sender, EventArgs e)
        {
            string soloaicuoi = dgvLoai.Rows[dgvLoai.Rows.Count - 1].Cells[0].Value.ToString();
            string soloaimoi = (Convert.ToInt32(soloaicuoi.Substring(1)) + 1).ToString();
            if (Convert.ToInt32(soloaimoi) <= 9) txtMaLoai.Text = "L0" + soloaimoi;
            else txtMaLoai.Text = "L" + soloaimoi;
        }
    }
}
