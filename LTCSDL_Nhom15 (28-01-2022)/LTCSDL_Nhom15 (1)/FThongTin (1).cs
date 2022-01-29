using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom15_BLL;
using Nhom15_DAL;

namespace LTCSDL_Nhom15
{
    public partial class FThongTin : Form
    {
        BLL_BANHCOOKIE bLL_BANHCOOKIE;
        BLL_BANHNGOT bLL_BANHNGOT;
        BLL_BANHMAN bLL_BANHMAN;
        public FThongTin()
        {
            InitializeComponent();
        }
        private void btQuanLy_Click(object sender, EventArgs e)
        {
            FQuanLy f = new FQuanLy();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            FDangNhap f = new FDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();

        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            FHoaDon f = new FHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void FThongTin_Load(object sender, EventArgs e)
        {
            bLL_BANHCOOKIE = new BLL_BANHCOOKIE();
            bLL_BANHNGOT = new BLL_BANHNGOT();
            bLL_BANHMAN = new BLL_BANHMAN();
            dgvBanhCookie.DataSource = bLL_BANHCOOKIE.ListBanhCookie();
            dgvBanhNgot.DataSource = bLL_BANHNGOT.ListBanhNgot();
            dgvBanhMan.DataSource = bLL_BANHMAN.ListBanhMan();
            lbChuoi.Text = "               CỬA HÀNG BÁNH Y.A.M.A    ";
            setup_dgvBanhMan();
            setup_dgvBanhNgot();
            setup_dgvBanhCookie();
        }

        //BÁNH MẶN
        private void dgvBanhMan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaBanhMan.Text = dgvBanhMan.Rows[e.RowIndex].Cells["MaBanh"].Value.ToString();
                txtTenBanhMan.Text = dgvBanhMan.Rows[e.RowIndex].Cells["TenBanh"].Value.ToString();
                txtGiaBanhMan.Text = dgvBanhMan.Rows[e.RowIndex].Cells["GiaTien"].Value.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn đúng dòng!", "Chú ý");
            }
        }
        private void btThemBanhMan_Click(object sender, EventArgs e)
        {
            if (txtTenBanhMan.Text == "" || txtGiaBanhMan.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bánh", "Thông báo");
            }
            else
            {
                BanhMan man = new BanhMan();
                man.TenBanh = txtTenBanhMan.Text;
                man.GiaTien = txtGiaBanhMan.Text;
                int kq = bLL_BANHMAN.them_BanhMan(man);
                resetBanhMan();
                if (kq == 0)
                    MessageBox.Show("Bánh này đã có trong danh sách", "Thông báo");
                else
                    MessageBox.Show("Thêm bánh thành công", "Thông báo");
            }
        }       
        
        private void btSuaBanhMan_Click(object sender, EventArgs e)
        {
            if (txtTenBanhMan.Text == "" || txtGiaBanhMan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa", "Thông báo");

            }
            else
            {
                BanhMan man = new BanhMan();
                man.MaBanh = int.Parse(txtMaBanhMan.Text);
                man.TenBanh = txtTenBanhMan.Text;
                man.GiaTien = txtGiaBanhMan.Text;
                int banhman = bLL_BANHMAN.SUA_BanhMan(man);
                if (banhman == 0)
                    MessageBox.Show("Bánh mặn đã có trong danh sách", "Thông báo");
                else
                    MessageBox.Show("Sửa bánh thành công", "Thông báo");
                this.resetSuaBanhMan();
            }
        }
        public void resetSuaBanhMan()
        {
            bLL_BANHMAN = new BLL_BANHMAN();
            txtMaBanhMan.Text = "";
            txtTenBanhMan.Text = "";
            txtGiaBanhMan.Text = "";
            this.dgvBanhMan.DataSource = bLL_BANHMAN.ListBanhMan();
        }

        private void btXoaBanhMan_Click(object sender, EventArgs e)
        {
            if (txtTenBanhMan.Text == "" || txtGiaBanhMan.Text == "" || txtMaBanhMan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa", "Thông báo");
            }
            else
            {
                BanhMan man = new BanhMan();
                man.MaBanh = int.Parse(txtMaBanhMan.Text);
                bLL_BANHMAN.deleteBanhMan(man);
                this.resetXoaBanhMan();
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
        }
        public void resetXoaBanhMan()
        {
            bLL_BANHMAN = new BLL_BANHMAN();
            txtMaBanhMan.Text = "";
            txtGiaBanhMan.Text = "";
            txtTenBanhMan.Text = "";
            this.dgvBanhMan.DataSource = bLL_BANHMAN.ListBanhMan();
        }
        public void resetBanhMan()
        {
            bLL_BANHMAN = new BLL_BANHMAN();
            txtTenBanhMan.Text = "";
            txtGiaBanhMan.Text = "";
            dgvBanhMan.DataSource = bLL_BANHMAN.ListBanhMan();
        }


        //BÁNH NGỌT
        private void dgvBanhNgot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaBanhNgot.Text = dgvBanhNgot.Rows[e.RowIndex].Cells["MaBanh"].Value.ToString();
                txtTenBanhNgot.Text = dgvBanhNgot.Rows[e.RowIndex].Cells["TenBanh"].Value.ToString();
                txtGiaBanhNgot.Text = dgvBanhNgot.Rows[e.RowIndex].Cells["GiaTien"].Value.ToString();

            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn đúng dòng!", "Chú ý");
            }
        }
        private void btThemBanhNgot_Click(object sender, EventArgs e)
        {
            if (txtTenBanhNgot.Text == "" || txtGiaBanhNgot.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bánh", "Thông báo");
            }
            else
            {
                BanhNgot ngot = new BanhNgot();
                ngot.TenBanh = txtTenBanhNgot.Text;
                ngot.GiaTien = txtGiaBanhNgot.Text;
                int kq = bLL_BANHNGOT.them_BanhNgot(ngot);
                resetBanhNgot();
                if (kq == 0)
                    MessageBox.Show("Bánh này đã có trong danh sách", "Thông báo");
                else
                    MessageBox.Show("Thêm bánh thành công", "Thông báo");
            }
        }
        private void btSuaBanhNgot_Click(object sender, EventArgs e)
        {
            if (txtTenBanhNgot.Text == "" || txtGiaBanhNgot.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa", "Thông báo");

            }
            else
            {
                BanhNgot ngot = new BanhNgot();
                ngot.MaBanh = int.Parse(txtMaBanhNgot.Text);
                ngot.TenBanh = txtTenBanhNgot.Text;
                ngot.GiaTien = txtGiaBanhNgot.Text;
                int banhngot = bLL_BANHNGOT.SUA_BanhNgot(ngot);
                if (banhngot == 0)
                    MessageBox.Show("Bánh ngọt đã có trong danh sách", "Thông báo");
                else
                    MessageBox.Show("Sửa bánh thành công", "Thông báo");
                this.resetSuaBanhNgot();
            }
        }
        public void resetSuaBanhNgot()
        {
            bLL_BANHNGOT = new BLL_BANHNGOT();
            txtMaBanhNgot.Text = "";
            txtTenBanhNgot.Text = "";
            txtGiaBanhNgot.Text = "";
            this.dgvBanhNgot.DataSource = bLL_BANHNGOT.ListBanhNgot();
        }

        private void btXoaBanhNgot_Click_1(object sender, EventArgs e)
        {
            if (txtTenBanhNgot.Text == "" || txtGiaBanhNgot.Text == "" || txtMaBanhNgot.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa", "Thông báo");
            }
            else
            {
                BanhNgot ngot = new BanhNgot();
                ngot.MaBanh = int.Parse(txtMaBanhNgot.Text);
                bLL_BANHNGOT.deleteBanhNgot(ngot);
                this.resetXoaBanhNgot();
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
        }
        public void resetXoaBanhNgot()
        {
            bLL_BANHNGOT = new BLL_BANHNGOT();
            txtMaBanhNgot.Text = "";
            txtGiaBanhNgot.Text = "";
            txtTenBanhNgot.Text = "";
            this.dgvBanhNgot.DataSource = bLL_BANHNGOT.ListBanhNgot();
        }
        public void resetBanhNgot()
        {
            bLL_BANHNGOT = new BLL_BANHNGOT();
            txtTenBanhNgot.Text = "";
            txtGiaBanhNgot.Text = "";
            dgvBanhNgot.DataSource = bLL_BANHNGOT.ListBanhNgot();
        }

        //BÁNH COOKIE
        private void dgvBanhCookie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaBanhCookie.Text = dgvBanhCookie.Rows[e.RowIndex].Cells["MaBanh"].Value.ToString();
                txtTenBanhCookie.Text = dgvBanhCookie.Rows[e.RowIndex].Cells["TenBanh"].Value.ToString();
                txtGiaBanhCookie.Text = dgvBanhCookie.Rows[e.RowIndex].Cells["GiaTien"].Value.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn đúng dòng!", "Chú ý");
            }
        }

        private void btThemBanhCookie_Click(object sender, EventArgs e)
        {
            if (txtGiaBanhCookie.Text == "" || txtTenBanhCookie.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bánh", "Thông báo");
            }
            else
            {
                BanhCookie ck = new BanhCookie();
                ck.TenBanh = txtTenBanhCookie.Text;
                ck.GiaTien = txtGiaBanhCookie.Text;
                int kq = bLL_BANHCOOKIE.them_BanhCookie(ck);
                resetBanhCookie();
                if (kq == 0)
                    MessageBox.Show("Bánh này đã có trong danh sách", "Thông báo");
                else
                    MessageBox.Show("Thêm bánh thành công", "Thông báo");
            }
        }

        private void btSuaBanhCookie_Click(object sender, EventArgs e)
        {
            if (txtTenBanhCookie.Text == "" || txtGiaBanhCookie.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa", "Thông báo");

            }
            else
            {
                BanhCookie ck = new BanhCookie();
                ck.MaBanh = int.Parse(txtMaBanhCookie.Text);
                ck.TenBanh = txtTenBanhCookie.Text;
                ck.GiaTien = txtGiaBanhCookie.Text;
                int banhck = bLL_BANHCOOKIE.SUA_BanhCookie(ck);
                if (banhck == 0)
                    MessageBox.Show("Bánh cookie đã có trong danh sách", "Thông báo");
                else
                    MessageBox.Show("Sửa bánh thành công", "Thông báo");
                this.resetSuaBanhCookie();
            }
        }
        public void resetSuaBanhCookie()
        {
            bLL_BANHCOOKIE = new BLL_BANHCOOKIE();
            txtMaBanhCookie.Text = "";
            txtTenBanhCookie.Text = "";
            txtGiaBanhCookie.Text = "";

            this.dgvBanhCookie.DataSource = bLL_BANHCOOKIE.ListBanhCookie();
        }

        private void btXoaBanhCookie_Click(object sender, EventArgs e)
        {
            if (txtTenBanhCookie.Text == "" || txtGiaBanhCookie.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa", "Thông báo");
            }
            else
            {
                BanhCookie ck = new BanhCookie();
                ck.MaBanh = int.Parse(txtMaBanhCookie.Text);
                bLL_BANHCOOKIE.deleteBanhCookie(ck);
                this.resetXoaBanhCookie();
                MessageBox.Show("Xóa thành công", "Thông báo");

            }
        }
        public void resetXoaBanhCookie()
        {
            bLL_BANHCOOKIE = new BLL_BANHCOOKIE();
            txtMaBanhCookie.Text = "";
            txtTenBanhCookie.Text = "";
            txtGiaBanhCookie.Text = "";
            this.dgvBanhCookie.DataSource = bLL_BANHCOOKIE.ListBanhCookie();
        }
        public void resetBanhCookie()
        {
            bLL_BANHCOOKIE = new BLL_BANHCOOKIE();
            txtTenBanhCookie.Text = "";
            txtGiaBanhCookie.Text = "";
            dgvBanhCookie.DataSource = bLL_BANHCOOKIE.ListBanhCookie();
        }
        
        private void txtTenBanhMan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122));

        }

        private void txtGiaBanhMan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenBanhNgot_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122));
        }

        private void txtGiaBanhNgot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenBanhCookie_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122));
        }

        private void txtGiaBanhCookie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }        

        private void txtTimKiemBanhMan_TextChanged(object sender, EventArgs e)
        {
            if (rdTenBanhMan.Checked)
            {
                string value = txtTimKiemBanhMan.Text;
                if (!string.IsNullOrWhiteSpace(value))
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("MaBanh");
                    dt.Columns.Add("TenBanh");
                    dt.Columns.Add("GiaBanh");
                    DataRow row;
                    for (int i = 0; i < dgvBanhMan.Rows.Count - 1; i++)
                    {
                        string temp = dgvBanhMan.Rows[i].Cells[1].Value.ToString().ToLower();
                        if (temp.Contains(value.ToLower()))
                        {
                            row = dt.NewRow();
                            row[0] = dgvBanhMan.Rows[i].Cells[0].Value.ToString();
                            row[1] = dgvBanhMan.Rows[i].Cells[1].Value.ToString();
                            row[2] = dgvBanhMan.Rows[i].Cells[2].Value.ToString();
                            dt.Rows.Add(row);
                        }
                    }
                    dgvBanhMan.DataSource = dt;
                }
                else
                {
                    dgvBanhMan.DataSource = bLL_BANHMAN.ListBanhMan();
                }
            }
            else
                if (rdGiaBanhMan.Checked)
            {
                string value = txtTimKiemBanhMan.Text;
                if (!string.IsNullOrWhiteSpace(value))
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("MaBanh");
                    dt.Columns.Add("TenBanh");
                    dt.Columns.Add("GiaBanh");
                    DataRow row;
                    for (int i = 0; i < dgvBanhMan.Rows.Count - 1; i++)
                    {
                        string temp = dgvBanhMan.Rows[i].Cells[2].Value.ToString().ToLower();
                        if (temp.Contains(value.ToLower()))
                        {
                            row = dt.NewRow();
                            row[0] = dgvBanhMan.Rows[i].Cells[0].Value.ToString();
                            row[1] = dgvBanhMan.Rows[i].Cells[1].Value.ToString();
                            row[2] = dgvBanhMan.Rows[i].Cells[2].Value.ToString();
                            dt.Rows.Add(row);
                        }
                    }
                    dgvBanhMan.DataSource = dt;
                }
                else
                {
                    dgvBanhMan.DataSource = bLL_BANHMAN.ListBanhMan(); ;
                }
            }
        }

        private void txtTimKiemBanhNgot_TextChanged(object sender, EventArgs e)
        {
            if (rdTenBanhNgot.Checked)
            {
                string value = txtTimKiemBanhNgot.Text;
                if (!string.IsNullOrWhiteSpace(value))
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("MaBanh");
                    dt.Columns.Add("TenBanh");
                    dt.Columns.Add("GiaBanh");
                    DataRow row;
                    for (int i = 0; i < dgvBanhNgot.Rows.Count - 1; i++)
                    {
                        string temp = dgvBanhMan.Rows[i].Cells[1].Value.ToString().ToLower();
                        if (temp.Contains(value.ToLower()))
                        {
                            row = dt.NewRow();
                            row[0] = dgvBanhNgot.Rows[i].Cells[0].Value.ToString();
                            row[1] = dgvBanhNgot.Rows[i].Cells[1].Value.ToString();                           
                            row[2] = dgvBanhNgot.Rows[i].Cells[2].Value.ToString();
                            dt.Rows.Add(row);
                        }
                    }
                    dgvBanhNgot.DataSource = dt;
                }
                else
                {
                    dgvBanhNgot.DataSource = bLL_BANHNGOT.ListBanhNgot();
                }
            }
            else
                if (rdGiaBanhNgot.Checked)
            {
                string value = txtTimKiemBanhNgot.Text;
                if (!string.IsNullOrWhiteSpace(value))
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("MaBanh");
                    dt.Columns.Add("TenBanh");
                    dt.Columns.Add("GiaBanh");
                    DataRow row;
                    for (int i = 0; i < dgvBanhNgot.Rows.Count - 1; i++)
                    {
                        string temp = dgvBanhNgot.Rows[i].Cells[2].Value.ToString().ToLower();
                        if (temp.Contains(value.ToLower()))
                        {
                            row = dt.NewRow();
                            row[0] = dgvBanhNgot.Rows[i].Cells[0].Value.ToString();
                            row[1] = dgvBanhNgot.Rows[i].Cells[1].Value.ToString();
                            row[2] = dgvBanhNgot.Rows[i].Cells[2].Value.ToString();
                            dt.Rows.Add(row);
                        }
                    }
                    dgvBanhNgot.DataSource = dt;
                }
                else
                {
                    dgvBanhNgot.DataSource = bLL_BANHNGOT.ListBanhNgot(); ;
                }
            }
            
        }

        private void txtTimKiemBanhCookie_TextChanged(object sender, EventArgs e)
        {
            if (rdTenBanhCookie.Checked)
            {
                string value = txtTimKiemBanhCookie.Text;
                if (!string.IsNullOrWhiteSpace(value))
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("MaBanh");
                    dt.Columns.Add("TenBanh");
                    dt.Columns.Add("GiaBanh");
                    DataRow row;
                    for (int i = 0; i < dgvBanhCookie.Rows.Count - 1; i++)
                    {
                        string temp = dgvBanhCookie.Rows[i].Cells[1].Value.ToString().ToLower();
                        if (temp.Contains(value.ToLower()))
                        {
                            row = dt.NewRow();
                            row[0] = dgvBanhCookie.Rows[i].Cells[0].Value.ToString();
                            row[1] = dgvBanhCookie.Rows[i].Cells[1].Value.ToString();
                            row[2] = dgvBanhCookie.Rows[i].Cells[2].Value.ToString();
                            dt.Rows.Add(row);
                        }
                    }
                    dgvBanhCookie.DataSource = dt;
                }
                else
                {
                    dgvBanhCookie.DataSource = bLL_BANHCOOKIE.ListBanhCookie(); ;
                }
            }
            else
                if (rdGiaBanhCookie.Checked)
            {
                string value = txtTimKiemBanhCookie.Text;
                if (!string.IsNullOrWhiteSpace(value))
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("MaBanh");
                    dt.Columns.Add("TenBanh");
                    dt.Columns.Add("GiaBanh");
                    DataRow row;
                    for (int i = 0; i < dgvBanhCookie.Rows.Count - 1; i++)
                    {
                        string temp = dgvBanhCookie.Rows[i].Cells[2].Value.ToString().ToLower();
                        if (temp.Contains(value.ToLower()))
                        {
                            row = dt.NewRow();
                            row[0] = dgvBanhCookie.Rows[i].Cells[0].Value.ToString();
                            row[1] = dgvBanhCookie.Rows[i].Cells[1].Value.ToString();
                            row[2] = dgvBanhCookie.Rows[i].Cells[2].Value.ToString();
                            dt.Rows.Add(row);
                        }
                    }
                    dgvBanhCookie.DataSource = dt;
                }
                else
                {
                    dgvBanhCookie.DataSource = bLL_BANHCOOKIE.ListBanhCookie(); ;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbChuoi.Text = lbChuoi.Text.Substring(1) + lbChuoi.Text.Substring(0, 1);
        }

        private void setup_dgvBanhMan()
        {
            dgvBanhMan.Columns[0].Width = (int)(dgvBanhMan.Width * 0.2);
            dgvBanhMan.Columns[1].Width = (int)(dgvBanhMan.Width * 0.5);
            dgvBanhMan.Columns[2].Width = (int)(dgvBanhMan.Width * 0.2);
            dgvBanhMan.Columns[2].DefaultCellStyle.Format = "VNĐ";
        }
        private void setup_dgvBanhNgot()
        {
            dgvBanhNgot.Columns[0].Width = (int)(dgvBanhNgot.Width * 0.2);
            dgvBanhNgot.Columns[1].Width = (int)(dgvBanhNgot.Width * 0.5);
            dgvBanhNgot.Columns[2].Width = (int)(dgvBanhNgot.Width * 0.2);
            dgvBanhNgot.Columns[2].DefaultCellStyle.Format = "VNĐ";
        }
        private void setup_dgvBanhCookie()
        {
            dgvBanhCookie.Columns[0].Width = (int)(dgvBanhCookie.Width * 0.2);
            dgvBanhCookie.Columns[1].Width = (int)(dgvBanhCookie.Width * 0.5);
            dgvBanhCookie.Columns[2].Width = (int)(dgvBanhCookie.Width * 0.2);
            dgvBanhCookie.Columns[2].DefaultCellStyle.Format = "VNĐ";
        }
    }
}

