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
    public partial class FDangKy : Form
    {
        BLL_NHANVIEN bLL_NHANVIEN;
        public FDangKy()
        {
            bLL_NHANVIEN = new BLL_NHANVIEN();
            InitializeComponent();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            if (txtHoTenDK.Text == "" || txtNgaySinhDK.Text == "" || txtSDTDK.Text == "" ||
               txtDiaChiDK.Text == "" || txtTenTaiKhoanDK.Text == "" || txtMatKhauDK.Text == "" ||
               cbChucVuDK.Text == "" || cbGioiTinhDK.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                if (txtMatKhauDK.Text.Length <= 6)
            {
                MessageBox.Show("Mật khẩu phải lớn hơn 6 ký tự", "Thông báo");
                txtMatKhauDK.Focus();
                txtMatKhauDK.SelectAll();
            }
            else
                if (bLL_NHANVIEN.KiemTraTkTonTai(txtTenTaiKhoanDK.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                txtTenTaiKhoanDK.Focus();
                txtTenTaiKhoanDK.SelectAll();
            }
            else
            {
                NhanVien nv = new NhanVien();
                nv.HoTen = txtHoTenDK.Text;
                nv.NgaySinh = DateTime.Parse(txtNgaySinhDK.Text);
                nv.SoDienThoai = txtSDTDK.Text;
                nv.DiaChi = txtDiaChiDK.Text;
                nv.ChucVu = cbChucVuDK.Text;
                nv.GioiTinh = cbGioiTinhDK.Text;
                nv.TenDangNhap = txtTenTaiKhoanDK.Text;
                nv.MatKhau = txtMatKhauDK.Text;
                bLL_NHANVIEN.them_NhanVien(nv);
                MessageBox.Show("Đăng ký tài khoản thành công","Thông báo");
                FDangNhap f = new FDangNhap();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }

        private void txtHoTenDK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122));
        }

        private void txtSDTDK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void picQLDN_Click(object sender, EventArgs e)
        {
            FDangNhap f = new FDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
