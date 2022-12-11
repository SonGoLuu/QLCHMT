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
    public partial class FormQLNhanVien : UserControl
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public FormQLNhanVien()
        {
            InitializeComponent();
        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            dgvNV.DataSource = busNV.getNhanVien();  //Lấy danh sách nhân viên
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtHoTenNV.Text != "" && txtChucVu.Text != "" && radioNam.Checked == true || radioNu.Checked == true && txtSDTNV.Text != "" && txtDiaChi.Text != "")
            {
                DateTime dtNgaySinh = dtpNgaySinh.Value;
                // Tạo DTo
                DTO_NhanVien nv = new DTO_NhanVien(txtMaNV.Text, txtHoTenNV.Text, txtChucVu.Text, dtNgaySinh, getRadioGioiTinh(), txtSDTNV.Text, txtDiaChi.Text); 

                // Them
                if (busNV.themNhanVien(nv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvNV.DataSource = busNV.getNhanVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
        //Lấy giới tính nam hay nữ của nút radio
        private string getRadioGioiTinh()
        {
            if (radioNam.Checked == true) return "Nam";
            else return "Nữ";
        }

        //Đặt giới tính nam hay nữ của nút radio
        private void setRadioGioiTinh(string gt)
        {
            if(gt=="Nam")
            {
                radioNam.Checked = true;
                radioNu.Checked = false;
            }   
            else
            {
                radioNam.Checked = false;
                radioNu.Checked = true;
            }    
        }    
        //Gán giá trị từ datagridview lên các textbox
        private void dgvNV_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNV.SelectedRows[0];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtHoTenNV.Text = row.Cells[1].Value.ToString();
            txtChucVu.Text = row.Cells[2].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
            setRadioGioiTinh(row.Cells[4].Value.ToString());
            txtSDTNV.Text = row.Cells[5].Value.ToString();
            txtDiaChi.Text = row.Cells[6].Value.ToString();
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            if(dgvNV.SelectedRows.Count>0)
            {
                if (txtMaNV.Text != "" && txtHoTenNV.Text != "" && txtChucVu.Text != "" && radioNam.Checked == true || radioNu.Checked == true && txtSDTNV.Text != "" && txtDiaChi.Text != "")
                {
                    DateTime dtNgaySinh = dtpNgaySinh.Value;
                    // Tạo DTo
                    DTO_NhanVien nv = new DTO_NhanVien(txtMaNV.Text, txtHoTenNV.Text, txtChucVu.Text, dtNgaySinh, getRadioGioiTinh(), txtSDTNV.Text, txtDiaChi.Text);

                    // Them
                    if (busNV.suaNhanVien(nv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvNV.DataSource = busNV.getNhanVien(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên muốn sửa");
            }
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvNV.SelectedRows[0];
                string MaNV = row.Cells[0].Value.ToString();
                    // Them
                    if (busNV.xoaNhanVien(MaNV))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvNV.DataSource = busNV.getNhanVien(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên muốn xóa");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvNV.DataSource = busNV.findNhanVien(txtFind.Texts);  //Lấy danh sách nhân viên cần tìm
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            dgvNV.DataSource = busNV.getNhanVien();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvNV.DataSource = busNV.getNhanVien();
            txtFind.Texts = "";
            txtHoTenNV.Text = "";
            txtMaNV.Text = "";
            txtDiaChi.Text = "";
            txtChucVu.Text = "";
            txtSDTNV.Text = "";
            radioNam.Checked = false;
            radioNu.Checked = false;
        }

        private void txtMaNV_Enter(object sender, EventArgs e)
        {
            string sonvcuoi = dgvNV.Rows[dgvNV.Rows.Count - 1].Cells[0].Value.ToString();
            string sonvmoi = (Convert.ToInt32(sonvcuoi.Substring(2)) + 1).ToString();
            if (Convert.ToInt32(sonvmoi) <= 9) txtMaNV.Text = "NV0" + sonvmoi;
            else txtMaNV.Text = "NV" + sonvmoi;
        }
    }
}
