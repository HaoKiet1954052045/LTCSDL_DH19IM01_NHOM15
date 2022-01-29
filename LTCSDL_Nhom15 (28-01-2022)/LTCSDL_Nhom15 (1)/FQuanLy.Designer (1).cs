namespace LTCSDL_Nhom15
{
    partial class FQuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQuanLy));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbGioiTinhKH = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btXoaKH = new System.Windows.Forms.Button();
            this.btSuaKH = new System.Windows.Forms.Button();
            this.btThemKH = new System.Windows.Forms.Button();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.txtNgaySinhKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvQuanLyKH = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbChucVuNV = new System.Windows.Forms.ComboBox();
            this.cbGioiTinhNV = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btXoaNV = new System.Windows.Forms.Button();
            this.btSuaNV = new System.Windows.Forms.Button();
            this.btThemNV = new System.Windows.Forms.Button();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.txtNgaySinhNV = new System.Windows.Forms.TextBox();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvQuanLyNV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btThongTin_QL = new System.Windows.Forms.Button();
            this.btDangXuat_QL = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKH)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1025, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbGioiTinhKH);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.btXoaKH);
            this.tabPage1.Controls.Add(this.btSuaKH);
            this.tabPage1.Controls.Add(this.btThemKH);
            this.tabPage1.Controls.Add(this.txtDiaChiKH);
            this.tabPage1.Controls.Add(this.txtSDTKH);
            this.tabPage1.Controls.Add(this.txtHoTenKH);
            this.tabPage1.Controls.Add(this.txtNgaySinhKH);
            this.tabPage1.Controls.Add(this.txtMaKH);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.ForeColor = System.Drawing.Color.Red;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1017, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khách Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbGioiTinhKH
            // 
            this.cbGioiTinhKH.FormattingEnabled = true;
            this.cbGioiTinhKH.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cbGioiTinhKH.Location = new System.Drawing.Point(615, 34);
            this.cbGioiTinhKH.Name = "cbGioiTinhKH";
            this.cbGioiTinhKH.Size = new System.Drawing.Size(172, 26);
            this.cbGioiTinhKH.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.YellowGreen;
            this.label14.Location = new System.Drawing.Point(523, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 18);
            this.label14.TabIndex = 5;
            this.label14.Text = "Giới Tính";
            // 
            // btXoaKH
            // 
            this.btXoaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(134)))), ((int)(((byte)(53)))));
            this.btXoaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaKH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoaKH.Location = new System.Drawing.Point(869, 136);
            this.btXoaKH.Name = "btXoaKH";
            this.btXoaKH.Size = new System.Drawing.Size(84, 46);
            this.btXoaKH.TabIndex = 4;
            this.btXoaKH.Text = "Xóa ";
            this.btXoaKH.UseVisualStyleBackColor = false;
            this.btXoaKH.Click += new System.EventHandler(this.btXoaKH_Click);
            // 
            // btSuaKH
            // 
            this.btSuaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(134)))), ((int)(((byte)(53)))));
            this.btSuaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaKH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSuaKH.Location = new System.Drawing.Point(869, 77);
            this.btSuaKH.Name = "btSuaKH";
            this.btSuaKH.Size = new System.Drawing.Size(84, 46);
            this.btSuaKH.TabIndex = 4;
            this.btSuaKH.Text = "Sửa";
            this.btSuaKH.UseVisualStyleBackColor = false;
            this.btSuaKH.Click += new System.EventHandler(this.btSuaKH_Click);
            // 
            // btThemKH
            // 
            this.btThemKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(134)))), ((int)(((byte)(53)))));
            this.btThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemKH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThemKH.Location = new System.Drawing.Point(869, 15);
            this.btThemKH.Name = "btThemKH";
            this.btThemKH.Size = new System.Drawing.Size(84, 46);
            this.btThemKH.TabIndex = 4;
            this.btThemKH.Text = "Thêm";
            this.btThemKH.UseVisualStyleBackColor = false;
            this.btThemKH.Click += new System.EventHandler(this.btThemKH_Click);
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(615, 138);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(173, 24);
            this.txtDiaChiKH.TabIndex = 3;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(615, 85);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(173, 24);
            this.txtSDTKH.TabIndex = 3;
            this.txtSDTKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTKH_KeyPress);
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(233, 85);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(177, 24);
            this.txtHoTenKH.TabIndex = 3;
            this.txtHoTenKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTenKH_KeyPress);
            // 
            // txtNgaySinhKH
            // 
            this.txtNgaySinhKH.Location = new System.Drawing.Point(233, 138);
            this.txtNgaySinhKH.Name = "txtNgaySinhKH";
            this.txtNgaySinhKH.Size = new System.Drawing.Size(177, 24);
            this.txtNgaySinhKH.TabIndex = 3;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(233, 35);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(177, 24);
            this.txtMaKH.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.YellowGreen;
            this.label5.Location = new System.Drawing.Point(548, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.YellowGreen;
            this.label6.Location = new System.Drawing.Point(539, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa chỉ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvQuanLyKH);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 208);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Khách Hàng";
            // 
            // dgvQuanLyKH
            // 
            this.dgvQuanLyKH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQuanLyKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyKH.Location = new System.Drawing.Point(6, 26);
            this.dgvQuanLyKH.Name = "dgvQuanLyKH";
            this.dgvQuanLyKH.Size = new System.Drawing.Size(974, 166);
            this.dgvQuanLyKH.TabIndex = 1;
            this.dgvQuanLyKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyKH_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.YellowGreen;
            this.label4.Location = new System.Drawing.Point(129, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.YellowGreen;
            this.label3.Location = new System.Drawing.Point(133, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(133, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã KH";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbChucVuNV);
            this.tabPage2.Controls.Add(this.cbGioiTinhNV);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txtMatKhau);
            this.tabPage2.Controls.Add(this.txtTenDN);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btXoaNV);
            this.tabPage2.Controls.Add(this.btSuaNV);
            this.tabPage2.Controls.Add(this.btThemNV);
            this.tabPage2.Controls.Add(this.txtDiaChiNV);
            this.tabPage2.Controls.Add(this.txtSDTNV);
            this.tabPage2.Controls.Add(this.txtNgaySinhNV);
            this.tabPage2.Controls.Add(this.txtHoTenNV);
            this.tabPage2.Controls.Add(this.txtMaNV);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1017, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân Viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbChucVuNV
            // 
            this.cbChucVuNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChucVuNV.FormattingEnabled = true;
            this.cbChucVuNV.Items.AddRange(new object[] {
            "Nhân viên bán hàng",
            "Phó quản lý",
            "Trưởng ca"});
            this.cbChucVuNV.Location = new System.Drawing.Point(721, 21);
            this.cbChucVuNV.Name = "cbChucVuNV";
            this.cbChucVuNV.Size = new System.Drawing.Size(148, 26);
            this.cbChucVuNV.TabIndex = 11;
            // 
            // cbGioiTinhNV
            // 
            this.cbGioiTinhNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinhNV.FormattingEnabled = true;
            this.cbGioiTinhNV.Items.AddRange(new object[] {
            "Nữ ",
            "Nam"});
            this.cbGioiTinhNV.Location = new System.Drawing.Point(432, 103);
            this.cbGioiTinhNV.Name = "cbGioiTinhNV";
            this.cbGioiTinhNV.Size = new System.Drawing.Size(160, 26);
            this.cbGioiTinhNV.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.YellowGreen;
            this.label16.Location = new System.Drawing.Point(638, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 18);
            this.label16.TabIndex = 9;
            this.label16.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(721, 105);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(148, 24);
            this.txtMatKhau.TabIndex = 8;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(720, 65);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(149, 24);
            this.txtTenDN.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.YellowGreen;
            this.label15.Location = new System.Drawing.Point(649, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 18);
            this.label15.TabIndex = 6;
            this.label15.Text = "Tên ĐN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.YellowGreen;
            this.label13.Location = new System.Drawing.Point(645, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "Chức vụ";
            // 
            // btXoaNV
            // 
            this.btXoaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(134)))), ((int)(((byte)(53)))));
            this.btXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoaNV.Location = new System.Drawing.Point(917, 110);
            this.btXoaNV.Name = "btXoaNV";
            this.btXoaNV.Size = new System.Drawing.Size(77, 42);
            this.btXoaNV.TabIndex = 3;
            this.btXoaNV.Text = "Xóa";
            this.btXoaNV.UseVisualStyleBackColor = false;
            this.btXoaNV.Click += new System.EventHandler(this.btXoaNV_Click);
            // 
            // btSuaNV
            // 
            this.btSuaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(134)))), ((int)(((byte)(53)))));
            this.btSuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSuaNV.Location = new System.Drawing.Point(917, 60);
            this.btSuaNV.Name = "btSuaNV";
            this.btSuaNV.Size = new System.Drawing.Size(77, 42);
            this.btSuaNV.TabIndex = 3;
            this.btSuaNV.Text = "Sửa";
            this.btSuaNV.UseVisualStyleBackColor = false;
            this.btSuaNV.Click += new System.EventHandler(this.btSuaNV_Click);
            // 
            // btThemNV
            // 
            this.btThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(134)))), ((int)(((byte)(53)))));
            this.btThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThemNV.Location = new System.Drawing.Point(917, 12);
            this.btThemNV.Name = "btThemNV";
            this.btThemNV.Size = new System.Drawing.Size(77, 42);
            this.btThemNV.TabIndex = 3;
            this.btThemNV.Text = "Thêm";
            this.btThemNV.UseVisualStyleBackColor = false;
            this.btThemNV.Click += new System.EventHandler(this.btThemNV_Click);
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNV.Location = new System.Drawing.Point(432, 64);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(160, 24);
            this.txtDiaChiNV.TabIndex = 2;
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTNV.Location = new System.Drawing.Point(432, 20);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(160, 24);
            this.txtSDTNV.TabIndex = 2;
            this.txtSDTNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTNV_KeyPress);
            // 
            // txtNgaySinhNV
            // 
            this.txtNgaySinhNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinhNV.Location = new System.Drawing.Point(134, 105);
            this.txtNgaySinhNV.Name = "txtNgaySinhNV";
            this.txtNgaySinhNV.Size = new System.Drawing.Size(151, 24);
            this.txtNgaySinhNV.TabIndex = 2;
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenNV.Location = new System.Drawing.Point(134, 64);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(151, 24);
            this.txtHoTenNV.TabIndex = 2;
            this.txtHoTenNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTenNV_KeyPress);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(134, 21);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(151, 24);
            this.txtMaNV.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.YellowGreen;
            this.label12.Location = new System.Drawing.Point(351, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Địa chỉ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.YellowGreen;
            this.label11.Location = new System.Drawing.Point(56, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mã NV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.YellowGreen;
            this.label10.Location = new System.Drawing.Point(351, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Giới tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.YellowGreen;
            this.label9.Location = new System.Drawing.Point(49, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ngày Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.YellowGreen;
            this.label8.Location = new System.Drawing.Point(363, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "SĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.YellowGreen;
            this.label7.Location = new System.Drawing.Point(56, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Họ Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvQuanLyNV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(973, 220);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản Lý Nhân Viên";
            // 
            // dgvQuanLyNV
            // 
            this.dgvQuanLyNV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQuanLyNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyNV.Location = new System.Drawing.Point(7, 26);
            this.dgvQuanLyNV.Name = "dgvQuanLyNV";
            this.dgvQuanLyNV.Size = new System.Drawing.Size(960, 187);
            this.dgvQuanLyNV.TabIndex = 0;
            this.dgvQuanLyNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyNV_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 45);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CỬA HÀNG Y.A.M.A";
            // 
            // btThongTin_QL
            // 
            this.btThongTin_QL.BackColor = System.Drawing.Color.Goldenrod;
            this.btThongTin_QL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongTin_QL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThongTin_QL.Location = new System.Drawing.Point(330, 493);
            this.btThongTin_QL.Name = "btThongTin_QL";
            this.btThongTin_QL.Size = new System.Drawing.Size(123, 38);
            this.btThongTin_QL.TabIndex = 2;
            this.btThongTin_QL.Text = "Thông tin";
            this.btThongTin_QL.UseVisualStyleBackColor = false;
            this.btThongTin_QL.Click += new System.EventHandler(this.btThongTin_QL_Click);
            // 
            // btDangXuat_QL
            // 
            this.btDangXuat_QL.BackColor = System.Drawing.Color.Goldenrod;
            this.btDangXuat_QL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangXuat_QL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDangXuat_QL.Location = new System.Drawing.Point(614, 493);
            this.btDangXuat_QL.Name = "btDangXuat_QL";
            this.btDangXuat_QL.Size = new System.Drawing.Size(123, 38);
            this.btDangXuat_QL.TabIndex = 2;
            this.btDangXuat_QL.Text = "Đăng xuất";
            this.btDangXuat_QL.UseVisualStyleBackColor = false;
            this.btDangXuat_QL.Click += new System.EventHandler(this.btDangXuat_QL_Click);
            // 
            // FQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1029, 550);
            this.Controls.Add(this.btDangXuat_QL);
            this.Controls.Add(this.btThongTin_QL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FQuanLy";
            this.Load += new System.EventHandler(this.FQuanLy_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKH)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvQuanLyKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.TextBox txtNgaySinhKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btXoaKH;
        private System.Windows.Forms.Button btSuaKH;
        private System.Windows.Forms.Button btThemKH;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Button btXoaNV;
        private System.Windows.Forms.Button btSuaNV;
        private System.Windows.Forms.Button btThemNV;
        private System.Windows.Forms.TextBox txtDiaChiNV;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.TextBox txtNgaySinhNV;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvQuanLyNV;
        private System.Windows.Forms.Button btThongTin_QL;
        private System.Windows.Forms.Button btDangXuat_QL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbGioiTinhNV;
        private System.Windows.Forms.ComboBox cbChucVuNV;
        private System.Windows.Forms.ComboBox cbGioiTinhKH;
    }
}