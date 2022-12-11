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
    public partial class Form1 : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(cbbNguoiDung.Texts !="" && txtTenTaiKhoan.Texts !="" && txtMatKhau.Texts !="")
            {
                if (busTaiKhoan.checkTaiKhoan(txtTenTaiKhoan.Texts, txtMatKhau.Texts, cbbNguoiDung.Texts) == true)
                {
                    loadingDangNhap.Size = new Size(147, 147);
                    int i;
                    for (i = 0; i <= 100; i++)
                    {
                        loadingDangNhap.Value = i;
                    }
                    FormMainUI m = new FormMainUI();
                    m.TenTaiKhoan = txtTenTaiKhoan.Texts;
                    m.CheDoNguoiDung = cbbNguoiDung.Texts;
                    m.ShowDialog();
                    loadingDangNhap.Visible = false;
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công!");
                }    
            }
            else
            {
                MessageBox.Show("Mời bạn nhập đầy đủ!");
            } 
                
            
        }
        private void iconPictureBoxShow_Click(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = false;
            iconPictureBoxHide.BringToFront();
        }

        private void iconPictureBoxHide_Click(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = true;
            iconPictureBoxShow.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadingDangNhap.Size = new Size(0, 0);
            guna2ShadowFormLogin.SetShadowForm(this);
        }
    }
}
