using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Nhom15_BLL;
using Nhom15_DAL;

namespace LTCSDL_Nhom15
{
    public partial class FHoaDon : Form
    {
        //HoaDon d;
        BLL_HOADON bLL_HOADON;
        
        public FHoaDon()
        {
            InitializeComponent();
        }

        private void FHoaDon_Load(object sender, EventArgs e)
        {
            bLL_HOADON = new BLL_HOADON();
            dgvHoaDon.DataSource = bLL_HOADON.ListHoaDon();
            txtMaHD.Text = bLL_HOADON.getMaHD();
            txtNgayMua.Text = DateTime.Now.ToString();
            dgvHoaDon.Columns[11].Visible = false;
            dgvHoaDon.Columns[12].Visible = false;
            dgvHoaDon.Columns[13].Visible = false;
            dgvHoaDon.Columns[14].Visible = false;
            dgvHoaDon.Columns[15].Visible = false;
            setup_dgvHoaDon();
        }

        private void dgvHoaDon_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaHD.Text = dgvHoaDon.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
                txtMaKH.Text = dgvHoaDon.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
                txtMaNV.Text = dgvHoaDon.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                txtBanhMan.Text = dgvHoaDon.Rows[e.RowIndex].Cells["MabanhMan"].Value.ToString();
                txtSLBanhMan.Text = dgvHoaDon.Rows[e.RowIndex].Cells["SoLuongbanhMan"].Value.ToString();
                txtBanhNgot.Text = dgvHoaDon.Rows[e.RowIndex].Cells["MabanhNgot"].Value.ToString();
                txtSLBanhNgot.Text = dgvHoaDon.Rows[e.RowIndex].Cells["SoLuongBanhNgot"].Value.ToString();
                txtBanhCookie.Text = dgvHoaDon.Rows[e.RowIndex].Cells["MabanhCookie"].Value.ToString();
                txtSLBanhCookie.Text = dgvHoaDon.Rows[e.RowIndex].Cells["SoLuongBanhCookie"].Value.ToString();
                txtNgayMua.Text = dgvHoaDon.Rows[e.RowIndex].Cells["NgayMuaHang"].Value.ToString();
                txtTongTien.Text = dgvHoaDon.Rows[e.RowIndex].Cells["TongTien"].Value.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn đúng dòng", "Lỗi");
            }
        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                HoaDon d = new HoaDon();
                d.MaKhachHang = int.Parse(txtMaKH.Text);
                d.MaNhanVien = int.Parse(txtMaNV.Text);
                d.MaBanhMan = int.Parse(txtBanhMan.Text);
                d.SoLuongBanhMan = int.Parse(txtSLBanhMan.Text);
                d.MaBanhNgot = int.Parse(txtBanhNgot.Text);
                d.SoLuongBanhNgot = int.Parse(txtSLBanhNgot.Text);
                d.MaBanhCookie = int.Parse(txtBanhCookie.Text);
                d.SoLuongBanhCookie = int.Parse(txtSLBanhCookie.Text);
                int kq = bLL_HOADON.them_HoaDon(d);

                if (kq == 1)
                {
                    MessageBox.Show("Thêm Thành Công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch (SqlException e1)
            {
                string loi = e1.ToString().Substring(49, 5);
                if (loi == "error")
                    MessageBox.Show("Vui lòng nhập đúng các thông tin");
            }
            dgvHoaDon.DataSource = bLL_HOADON.ListHoaDon();
            dgvHoaDon.Columns[11].Visible = false;
            dgvHoaDon.Columns[12].Visible = false;
            dgvHoaDon.Columns[13].Visible = false;
            dgvHoaDon.Columns[14].Visible = false;
            dgvHoaDon.Columns[15].Visible = false;
            this.resetHD();
        }
        public void resetHD()
        {            
            txtMaKH.Text = "";
            txtMaNV.Text = "";
            txtBanhMan.Text = "";
            txtSLBanhMan.Text = "";
            txtBanhNgot.Text = "";
            txtSLBanhNgot.Text = "";
            txtBanhCookie.Text = "";
            txtSLBanhCookie.Text = "";                     
        }

       
        private void btThongTin_HD_Click(object sender, EventArgs e)
        {
            FThongTin f = new FThongTin();            
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btDangXuat_HD_Click(object sender, EventArgs e)
        {
            FDangNhap f = new FDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void txtSLBanhMan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSLBanhNgot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSLBanhCookie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void setup_dgvHoaDon()
        {
            dgvHoaDon.Columns[0].Width = (int)(dgvHoaDon.Width * 0.07);
            dgvHoaDon.Columns[1].Width = (int)(dgvHoaDon.Width * 0.07);
            dgvHoaDon.Columns[3].Width = (int)(dgvHoaDon.Width * 0.07);
            dgvHoaDon.Columns[4].Width = (int)(dgvHoaDon.Width * 0.09);
            dgvHoaDon.Columns[5].Width = (int)(dgvHoaDon.Width * 0.08);
            dgvHoaDon.Columns[6].Width = (int)(dgvHoaDon.Width * 0.1);
            dgvHoaDon.Columns[7].Width = (int)(dgvHoaDon.Width * 0.08);
            dgvHoaDon.Columns[8].Width = (int)(dgvHoaDon.Width * 0.1);
            dgvHoaDon.Columns[9].Width = (int)(dgvHoaDon.Width * 0.11);
            dgvHoaDon.Columns[10].Width = (int)(dgvHoaDon.Width * 0.11);            
        }
    }
}
