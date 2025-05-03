namespace WinFormsApp1
{
    partial class BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            btnLoad = new Button();
            btnTimKiem = new Button();
            groupBox3 = new GroupBox();
            cboKhachHang = new ComboBox();
            txtGhiChuHoaDon = new TextBox();
            label3 = new Label();
            cboNhanVien = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cboLoc = new ComboBox();
            groupBox2 = new GroupBox();
            raddm = new RadioButton();
            radhang = new RadioButton();
            radsp = new RadioButton();
            panel1 = new Panel();
            btnLuuHoaDon = new Button();
            btnThoat = new Button();
            btnPhonCach = new Button();
            btnInHoaDon = new Button();
            groupBox4 = new GroupBox();
            btnXacNhanBan = new Button();
            btnXoa = new Button();
            label4 = new Label();
            label6 = new Label();
            numDonGiaBan = new NumericUpDown();
            numTonKho = new NumericUpDown();
            label5 = new Label();
            numSoLuongBan = new NumericUpDown();
            groupBox5 = new GroupBox();
            dataGridView = new DataGridView();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTonKho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(1317, 369);
            panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1317, 369);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(cboLoc);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1317, 161);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.None;
            btnLoad.BackColor = Color.SteelBlue;
            btnLoad.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnLoad.ForeColor = Color.Transparent;
            btnLoad.Image = (Image)resources.GetObject("btnLoad.Image");
            btnLoad.Location = new Point(570, 79);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(105, 52);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Tải Lại";
            btnLoad.TextAlign = ContentAlignment.MiddleRight;
            btnLoad.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.SteelBlue;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnTimKiem.ForeColor = Color.Transparent;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(459, 79);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(105, 52);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Lọc";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.Controls.Add(cboKhachHang);
            groupBox3.Controls.Add(txtGhiChuHoaDon);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(cboNhanVien);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(696, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(526, 115);
            groupBox3.TabIndex = 37;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông Tin Hóa Đơn";
            // 
            // cboKhachHang
            // 
            cboKhachHang.Anchor = AnchorStyles.None;
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(379, 26);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(133, 28);
            cboKhachHang.TabIndex = 2;
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Anchor = AnchorStyles.None;
            txtGhiChuHoaDon.Location = new Point(136, 66);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(376, 27);
            txtGhiChuHoaDon.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(284, 29);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 4;
            label3.Text = "Khách Hàng";
            // 
            // cboNhanVien
            // 
            cboNhanVien.Anchor = AnchorStyles.None;
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(138, 26);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(140, 28);
            cboNhanVien.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 5;
            label2.Text = "Ghi Chú Hóa Đơn";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 6;
            label1.Text = "Nhân Viên Lập(*)";
            // 
            // cboLoc
            // 
            cboLoc.Anchor = AnchorStyles.None;
            cboLoc.FormattingEnabled = true;
            cboLoc.Location = new Point(459, 36);
            cboLoc.Name = "cboLoc";
            cboLoc.Size = new Size(216, 28);
            cboLoc.TabIndex = 1;
            cboLoc.SelectedIndexChanged += cboLoc_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(raddm);
            groupBox2.Controls.Add(radhang);
            groupBox2.Controls.Add(radsp);
            groupBox2.Location = new Point(78, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 115);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn Tiêu Chí";
            // 
            // raddm
            // 
            raddm.Anchor = AnchorStyles.None;
            raddm.AutoSize = true;
            raddm.Location = new Point(246, 39);
            raddm.Name = "raddm";
            raddm.Size = new Size(97, 24);
            raddm.TabIndex = 2;
            raddm.Text = "Danh Mục";
            raddm.UseVisualStyleBackColor = true;
            raddm.CheckedChanged += raddm_CheckedChanged;
            // 
            // radhang
            // 
            radhang.Anchor = AnchorStyles.None;
            radhang.AutoSize = true;
            radhang.Location = new Point(112, 39);
            radhang.Name = "radhang";
            radhang.Size = new Size(128, 24);
            radhang.TabIndex = 1;
            radhang.Text = "Hãng Sản Xuất";
            radhang.UseVisualStyleBackColor = true;
            radhang.CheckedChanged += radhang_CheckedChanged;
            // 
            // radsp
            // 
            radsp.Anchor = AnchorStyles.None;
            radsp.AutoSize = true;
            radsp.Checked = true;
            radsp.Location = new Point(11, 39);
            radsp.Name = "radsp";
            radsp.Size = new Size(95, 24);
            radsp.TabIndex = 0;
            radsp.TabStop = true;
            radsp.Text = "Sản Phẩm";
            radsp.UseVisualStyleBackColor = true;
            radsp.CheckedChanged += radsp_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLuuHoaDon);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnPhonCach);
            panel1.Controls.Add(btnInHoaDon);
            panel1.Controls.Add(groupBox4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 758);
            panel1.Name = "panel1";
            panel1.Size = new Size(1317, 110);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Anchor = AnchorStyles.None;
            btnLuuHoaDon.BackColor = Color.SteelBlue;
            btnLuuHoaDon.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnLuuHoaDon.ForeColor = Color.Transparent;
            btnLuuHoaDon.Image = (Image)resources.GetObject("btnLuuHoaDon.Image");
            btnLuuHoaDon.Location = new Point(765, 31);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(138, 52);
            btnLuuHoaDon.TabIndex = 0;
            btnLuuHoaDon.Text = "Lưu Hóa Đơn";
            btnLuuHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnLuuHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuuHoaDon.UseVisualStyleBackColor = false;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.BackColor = Color.SteelBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(1187, 33);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(118, 49);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnPhonCach
            // 
            btnPhonCach.Anchor = AnchorStyles.None;
            btnPhonCach.BackColor = Color.SteelBlue;
            btnPhonCach.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnPhonCach.ForeColor = Color.Transparent;
            btnPhonCach.Image = (Image)resources.GetObject("btnPhonCach.Image");
            btnPhonCach.Location = new Point(1063, 33);
            btnPhonCach.Name = "btnPhonCach";
            btnPhonCach.Size = new Size(118, 49);
            btnPhonCach.TabIndex = 2;
            btnPhonCach.Text = "Cổ điển";
            btnPhonCach.TextAlign = ContentAlignment.MiddleRight;
            btnPhonCach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPhonCach.UseVisualStyleBackColor = false;
            btnPhonCach.Click += btnPhongCach_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Anchor = AnchorStyles.None;
            btnInHoaDon.BackColor = Color.SteelBlue;
            btnInHoaDon.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnInHoaDon.ForeColor = Color.Transparent;
            btnInHoaDon.Image = (Image)resources.GetObject("btnInHoaDon.Image");
            btnInHoaDon.Location = new Point(909, 34);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(148, 49);
            btnInHoaDon.TabIndex = 1;
            btnInHoaDon.Text = "In Hóa Đơn";
            btnInHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnInHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.None;
            groupBox4.Controls.Add(btnXacNhanBan);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(numDonGiaBan);
            groupBox4.Controls.Add(numTonKho);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(numSoLuongBan);
            groupBox4.Location = new Point(23, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(706, 92);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông Tin Hóa Đơn Chi Tiết";
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Anchor = AnchorStyles.None;
            btnXacNhanBan.BackColor = Color.SteelBlue;
            btnXacNhanBan.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhanBan.ForeColor = Color.Transparent;
            btnXacNhanBan.Image = (Image)resources.GetObject("btnXacNhanBan.Image");
            btnXacNhanBan.Location = new Point(419, 28);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(156, 52);
            btnXacNhanBan.TabIndex = 5;
            btnXacNhanBan.Text = "Xác Nhận Bán";
            btnXacNhanBan.TextAlign = ContentAlignment.MiddleRight;
            btnXacNhanBan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXacNhanBan.UseVisualStyleBackColor = false;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.SteelBlue;
            btnXoa.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnXoa.ForeColor = Color.Transparent;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(582, 28);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 51);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(308, 30);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 5;
            label4.Text = "Tồn Kho";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(170, 30);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 5;
            label6.Text = "Số Lượng Bán";
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Anchor = AnchorStyles.None;
            numDonGiaBan.Enabled = false;
            numDonGiaBan.Location = new Point(21, 52);
            numDonGiaBan.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(129, 27);
            numDonGiaBan.TabIndex = 7;
            // 
            // numTonKho
            // 
            numTonKho.Anchor = AnchorStyles.None;
            numTonKho.Enabled = false;
            numTonKho.Location = new Point(308, 52);
            numTonKho.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numTonKho.Name = "numTonKho";
            numTonKho.Size = new Size(105, 27);
            numTonKho.TabIndex = 8;
            numTonKho.ValueChanged += numTonKho_ValueChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(21, 28);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 6;
            label5.Text = "Đơn Giá Bán";
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Anchor = AnchorStyles.None;
            numSoLuongBan.Location = new Point(170, 52);
            numSoLuongBan.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(112, 27);
            numSoLuongBan.TabIndex = 1;
            numSoLuongBan.ValueChanged += numSoLuongBan_ValueChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView);
            groupBox5.Dock = DockStyle.Bottom;
            groupBox5.Location = new Point(0, 530);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1317, 228);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh Sách chi tiết hóa đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenSanPham, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1311, 202);
            dataGridView.TabIndex = 1;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // SanPhamID
            // 
            SanPhamID.DataPropertyName = "SanPhamID";
            SanPhamID.HeaderText = "ID";
            SanPhamID.MinimumWidth = 6;
            SanPhamID.Name = "SanPhamID";
            SanPhamID.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên Sản Phẩm ";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            DonGiaBan.HeaderText = "Đơn Giá Bán";
            DonGiaBan.MinimumWidth = 6;
            DonGiaBan.Name = "DonGiaBan";
            DonGiaBan.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongBan.HeaderText = "Số Lượng Bán";
            SoLuongBan.MinimumWidth = 6;
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 868);
            Controls.Add(panel2);
            Controls.Add(groupBox5);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "BanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết hóa đơn";
            WindowState = FormWindowState.Maximized;
            Load += BanHang_Load;
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTonKho).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private ComboBox cboLoc;
        private GroupBox groupBox2;
        private RadioButton raddm;
        private RadioButton radhang;
        private RadioButton radsp;
        private Button btnLoad;
        private Button btnTimKiem;
        private GroupBox groupBox3;
        private ComboBox cboKhachHang;
        private TextBox txtGhiChuHoaDon;
        private Label label3;
        private ComboBox cboNhanVien;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox4;
        private Label label6;
        private NumericUpDown numDonGiaBan;
        private Label label5;
        private NumericUpDown numSoLuongBan;
        private Button btnXacNhanBan;
        private Button btnXoa;
        private GroupBox groupBox5;
        private DataGridView dataGridView;
        private Button btnLuuHoaDon;
        private Button btnThoat;
        private Button btnInHoaDon;
        private Button btnPhonCach;
        private Label label4;
        private NumericUpDown numTonKho;
        private DataGridViewTextBoxColumn SanPhamID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}