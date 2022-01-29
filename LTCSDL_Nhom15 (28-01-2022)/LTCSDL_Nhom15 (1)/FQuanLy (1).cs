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
    public partial class FQuanLy : Form
    {
        BLL_NHANVIEN bLL_NHANVIEN;
        BLL_KHACHHANG bLL_KHACHHANG;

        public FQuanLy()
        {
            InitializeComponent();
        }
        private void btThongTin_QL_Click(object sender, EventArgs e)
        {
            FThongTin f = new FThongTin();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        private void btDangXuat_QL_Click(object sender, EventArgs e)
        {
            FDangNhap f = new FDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        private void FQuanLy_Load(object sender, EventArgs e)
        {
            bLL_KHACHHANG = new BLL_KHACHHANG();
            bLL_NHANVIEN = new BLL_NHANVIEN();
            dgvQuanLyKH.DataSource = bLL_KHACHHANG.ListKhachHang();
            dgvQuanLyNV.DataSource = bLL_NHANVIEN.ListNhanVien();
            setup_dgvQuanLyKH();
            setup_dgvQuanLyNV();
        }


        //NHÂN VIÊN
        private void dgvQuanLyNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                txtHoTenNV.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                cbGioiTinhNV.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                cbChucVuNV.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells["ChucVu"].Value.ToString();
                txtNgaySinhNV.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                txtSDTNV.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
                txtDiaChiNV.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtTenDN.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn đúng dòng!", "Chú ý") ;
            }
        }
        private void btThemNV_Click(object sender, EventArgs e)
        {
            if (txtHoTenNV.Text == "" || txtNgaySinhNV.Text == "" || txtSDTNV.Text == "" ||
                txtDiaChiNV.Text == "" || cbGioiTinhNV.Text == "" || txtTenDN.Text == "" || txtMatKhau.Text == ""
                || cbChucVuNV.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên để thêm", "Thông báo");
            }
            else
            {
                NhanVien nv = new NhanVien();
                nv.HoTen = txtHoTenNV.Text;
                nv.NgaySinh = DateTime.Parse(txtNgaySinhNV.Text);
                nv.SoDienThoai = txtSDTNV.Text;
                nv.DiaChi = txtDiaChiNV.Text;
                nv.GioiTinh = cbGioiTinhNV.Text;
                nv.TenDangNhap = txtTenDN.Text;
                nv.MatKhau = txtMatKhau.Text;
                nv.ChucVu = cbChucVuNV.Text;
                int kq = bLL_NHANVIEN.them_NhanVien(nv);
                resetNV();
                if (kq == 0)
                    MessageBox.Show("Nhân viên đã có trong danh sách", "Thông báo");
                else
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
            }

        }
        public void resetNV()
        {
            bLL_NHANVIEN = new BLL_NHANVIEN();
            txtMaNV.Text = "";
            txtHoTenNV.Text = "";
            txtNgaySinhNV.Text = "";
            txtSDTNV.Text = "";
            txtDiaChiNV.Text = "";
            cbGioiTinhNV.Text = "";
            txtMatKhau.Text = "";
            txtTenDN.Text = "";
            cbChucVuNV.Text = "";
            dgvQuanLyNV.DataSource = bLL_NHANVIEN.ListNhanVien();
        }
        private void btSuaNV_Click(object sender, EventArgs e)
        {
            if (txtHoTenNV.Text == "" || txtSDTNV.Text == "" || txtNgaySinhNV.Text == "" || cbGioiTinhNV.Text == "" || txtDiaChiNV.Text == "" || cbChucVuNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa", "Thông báo", MessageBoxButtons.OK);

            }
            else
            {
                NhanVien nv = new NhanVien();
                nv.MaNhanVien = int.Parse(txtMaNV.Text);
                nv.HoTen = txtHoTenNV.Text;
                nv.NgaySinh = DateTime.Parse(txtNgaySinhNV.Text);
                nv.SoDienThoai = txtSDTNV.Text;
                nv.GioiTinh = cbGioiTinhNV.Text;
                nv.DiaChi = txtDiaChiNV.Text;
                nv.ChucVu = cbChucVuNV.Text;
                nv.TenDangNhap = txtTenDN.Text;
                nv.MatKhau = txtMatKhau.Text;
                int kq = bLL_NHANVIEN.SUA_NhanVien(nv);
                if (kq == 0)
                    MessageBox.Show("Nhân viên đã có trong danh sách", "Thông báo");
                else
                    MessageBox.Show("Sửa nhân viên thành công", "Thông báo");
                this.resetSuaNhanVien();
            }
        }
        public void resetSuaNhanVien()
        {
            bLL_NHANVIEN = new BLL_NHANVIEN();
            txtMaNV.Text = "";
            txtHoTenNV.Text = "";
            txtNgaySinhNV.Text = "";
            txtSDTNV.Text = "";
            cbGioiTinhNV.Text = "";
            txtDiaChiNV.Text = "";
            cbChucVuNV.Text = "";
            txtTenDN.Text = "";
            txtMatKhau.Text = "";
            this.dgvQuanLyNV.DataSource = bLL_NHANVIEN.ListNhanVien();
        }
        private void btXoaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtHoTenNV.Text == "" || cbGioiTinhNV.Text == "" || txtNgaySinhNV.Text == "" || txtSDTNV.Text == "" || txtDiaChiNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa", "Thông báo");
            }
            else
            {
                NhanVien nv = new NhanVien();
                nv.MaNhanVien = int.Parse(txtMaNV.Text);
                bLL_NHANVIEN.deleteNhanVien(nv);
                this.resetXoaNV();
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
        }
        public void resetXoaNV()
        {
            bLL_NHANVIEN = new BLL_NHANVIEN();
            txtMaNV.Text = "";
            txtHoTenNV.Text = "";
            cbGioiTinhNV.Text = "";
            txtNgaySinhNV.Text = "";
            txtSDTNV.Text = "";
            txtDiaChiNV.Text = "";
            cbChucVuNV.Text = "";
            txtTenDN.Text = "";
            txtMatKhau.Text = "";
            this.dgvQuanLyNV.DataSource = bLL_NHANVIEN.ListNhanVien();
        }
        private void txtHoTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122));
        }
        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void setup_dgvQuanLyKH()
        {
            dgvQuanLyKH.Columns[0].Width = (int)(dgvQuanLyKH.Width * 0.15);
            dgvQuanLyKH.Columns[1].Width = (int)(dgvQuanLyKH.Width * 0.2);
            dgvQuanLyKH.Columns[2].Width = (int)(dgvQuanLyKH.Width * 0.15);
            dgvQuanLyKH.Columns[3].Width = (int)(dgvQuanLyKH.Width * 0.15);
            dgvQuanLyKH.Columns[4].Width = (int)(dgvQuanLyKH.Width * 0.15);
            dgvQuanLyKH.Columns[5].Width = (int)(dgvQuanLyKH.Width * 0.156);
        }

        //KHÁCH HÀNG
        private void dgvQuanLyKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtMaKH.Text = dgvQuanLyKH.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
                txtHoTenKH.Text = dgvQuanLyKH.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                cbGioiTinhKH.Text = dgvQuanLyKH.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                txtNgaySinhKH.Text = dgvQuanLyKH.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                txtSDTKH.Text = dgvQuanLyKH.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
                txtDiaChiKH.Text = dgvQuanLyKH.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn đúng dòng!", "Chú ý");
            }
        }
        private void btThemKH_Click(object sender, EventArgs e)
        {
            if (txtHoTenKH.Text == "" || txtNgaySinhKH.Text == "" || txtSDTKH.Text == "" || txtDiaChiKH.Text == "" || cbGioiTinhKH.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng để thêm", "Thông báo");
            }
            else
            {
                KhachHang kh = new KhachHang();
                kh.HoTen = txtHoTenKH.Text;
                kh.NgaySinh = DateTime.Parse(txtNgaySinhKH.Text);
                kh.GioiTinh = cbGioiTinhKH.Text;
                kh.SoDienThoai = txtSDTKH.Text;
                kh.DiaChi = txtDiaChiKH.Text;
                int kq = bLL_KHACHHANG.them_KhachHang(kh);
                resetKH();
                if (kq == 0)
                    MessageBox.Show("Khách hàng này đã có trong danh sách", "Thông báo");
                else
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo");
            }
        }
        public void resetKH()
        {
            bLL_KHACHHANG = new BLL_KHACHHANG();
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtNgaySinhKH.Text = "";
            cbGioiTinhKH.Text = "";
            txtSDTKH.Text = "";
            txtDiaChiKH.Text = "";
            dgvQuanLyKH.DataSource = bLL_KHACHHANG.ListKhachHang();
        }
        private void btSuaKH_Click(object sender, EventArgs e)
        {
            if (txtHoTenKH.Text == "" || txtSDTKH.Text == "" || txtNgaySinhKH.Text == "" || txtDiaChiKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa", "Thông báo", MessageBoxButtons.OK);

            }
            else
            {

                KhachHang kh = new KhachHang();
                kh.MaKhachHang = int.Parse(txtMaKH.Text);
                kh.HoTen = txtHoTenKH.Text;
                kh.GioiTinh = cbGioiTinhKH.Text;
                kh.NgaySinh = DateTime.Parse(txtNgaySinhKH.Text);
                kh.SoDienThoai = txtSDTKH.Text;
                kh.DiaChi = txtDiaChiKH.Text;

                int kq = bLL_KHACHHANG.SUA_KhachHang(kh);
                if (kq == 0)
                    MessageBox.Show("Khách hàng đã có trong danh sách", "Thông báo");
                else
                    MessageBox.Show("Sửa khách hàng thành công", "Thông báo");
                this.resetSuaKhachHang();
            }
        }
        public void resetSuaKhachHang()
        {
            bLL_KHACHHANG = new BLL_KHACHHANG();
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtNgaySinhKH.Text = "";
            cbGioiTinhKH.Text = "";
            txtSDTKH.Text = "";
            txtDiaChiKH.Text = "";
            this.dgvQuanLyKH.DataSource = bLL_KHACHHANG.ListKhachHang();
        }
        private void btXoaKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtHoTenKH.Text == "" || txtNgaySinhKH.Text == "" || txtSDTKH.Text == "" || txtDiaChiKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa", "Thông báo");
            }
            else
            {
                KhachHang kh = new KhachHang();
                kh.MaKhachHang = int.Parse(txtMaKH.Text);
                bLL_KHACHHANG.deleteKhachHang(kh);
                this.resetXoaKH();
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
        }
        public void resetXoaKH()
        {
            bLL_KHACHHANG = new BLL_KHACHHANG();
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtNgaySinhKH.Text = "";
            cbGioiTinhKH.Text = "";
            txtSDTKH.Text = "";
            txtDiaChiKH.Text = "";
            this.dgvQuanLyKH.DataSource = bLL_KHACHHANG.ListKhachHang();
        }  
        private void txtHoTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122));
        }
        private void txtSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void setup_dgvQuanLyNV()
        {
            dgvQuanLyNV.Columns[0].Width = (int)(dgvQuanLyNV.Width * 0.1);
            dgvQuanLyNV.Columns[1].Width = (int)(dgvQuanLyNV.Width * 0.165);
            dgvQuanLyNV.Columns[2].Width = (int)(dgvQuanLyNV.Width * 0.08);
            dgvQuanLyNV.Columns[3].Width = (int)(dgvQuanLyNV.Width * 0.11);
            dgvQuanLyNV.Columns[4].Width = (int)(dgvQuanLyNV.Width * 0.075);
            dgvQuanLyNV.Columns[5].Width = (int)(dgvQuanLyNV.Width * 0.075);
            dgvQuanLyNV.Columns[6].Width = (int)(dgvQuanLyNV.Width * 0.14);
            dgvQuanLyNV.Columns[7].Width = (int)(dgvQuanLyNV.Width * 0.11);
            dgvQuanLyNV.Columns[8].Width = (int)(dgvQuanLyNV.Width * 0.1);
        }        
    }
}
