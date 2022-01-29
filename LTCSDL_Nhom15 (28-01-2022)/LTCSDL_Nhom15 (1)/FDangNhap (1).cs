using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom15_DAL;
using Nhom15_BLL;

namespace LTCSDL_Nhom15
{
    public partial class FDangNhap : Form
    {
        BLL_NHANVIEN bLL_NHANVIEN;
        public FDangNhap()
        {
            InitializeComponent();
            bLL_NHANVIEN = new BLL_NHANVIEN();
        }
        
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Hãy nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
            }
            else
            {
                if (bLL_NHANVIEN.KiemTraDN(txtTenDangNhap.Text, txtMatKhau.Text))
                {
                    
                    FQuanLy f = new FQuanLy();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Đăng nhập sai tài khoản", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                    txtTenDangNhap.Focus();
                }
            }

        }
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDangNhap_Click(sender, e);
            }
        }
        private void btDangKy_Click(object sender, EventArgs e)
        {
            FDangKy f = new FDangKy();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn thoát chương trình chứ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.No:
                    break;
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }


        
    }
}

