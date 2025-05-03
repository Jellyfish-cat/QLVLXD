namespace QuanLiBanhang.Froms
{
    partial class frmHoaDon_ChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon_ChiTiet));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnLuuHoaDon = new Button();
            btnInHoaDon = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            btnPhongCach = new Button();
            txtGhiChuHoaDon = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            cboNhanVien = new ComboBox();
            cboKhachHang = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            cboSanPham = new ComboBox();
            dataGridView = new DataGridView();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            numDonGiaBan = new NumericUpDown();
            numSoLuongBan = new NumericUpDown();
            btnXacNhanBan = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            button1 = new Button();
            txtTimKiem = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            numTonKho = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTonKho).BeginInit();
            SuspendLayout();
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Anchor = AnchorStyles.None;
            btnLuuHoaDon.BackColor = Color.SteelBlue;
            btnLuuHoaDon.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnLuuHoaDon.ForeColor = Color.Transparent;
            btnLuuHoaDon.Image = (Image)resources.GetObject("btnLuuHoaDon.Image");
            btnLuuHoaDon.Location = new Point(176, 16);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(136, 52);
            btnLuuHoaDon.TabIndex = 0;
            btnLuuHoaDon.Text = "Lưu Hóa Đơn";
            btnLuuHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnLuuHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuuHoaDon.UseVisualStyleBackColor = false;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Anchor = AnchorStyles.None;
            btnInHoaDon.BackColor = Color.SteelBlue;
            btnInHoaDon.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnInHoaDon.ForeColor = Color.Transparent;
            btnInHoaDon.Image = (Image)resources.GetObject("btnInHoaDon.Image");
            btnInHoaDon.Location = new Point(331, 16);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(129, 52);
            btnInHoaDon.TabIndex = 1;
            btnInHoaDon.Text = "In Hóa Đơn";
            btnInHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnInHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.BackColor = Color.SteelBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(616, 16);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(118, 52);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLuuHoaDon);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnPhongCach);
            panel1.Controls.Add(btnInHoaDon);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 435);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 77);
            panel1.TabIndex = 5;
            // 
            // btnPhongCach
            // 
            btnPhongCach.Anchor = AnchorStyles.None;
            btnPhongCach.BackColor = Color.SteelBlue;
            btnPhongCach.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnPhongCach.ForeColor = Color.Transparent;
            btnPhongCach.Image = (Image)resources.GetObject("btnPhongCach.Image");
            btnPhongCach.Location = new Point(479, 16);
            btnPhongCach.Name = "btnPhongCach";
            btnPhongCach.Size = new Size(118, 52);
            btnPhongCach.TabIndex = 2;
            btnPhongCach.Text = "Hiện Đại";
            btnPhongCach.TextAlign = ContentAlignment.MiddleRight;
            btnPhongCach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPhongCach.UseVisualStyleBackColor = false;
            btnPhongCach.Click += btnPhongCach_Click;
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Anchor = AnchorStyles.None;
            txtGhiChuHoaDon.Location = new Point(213, 72);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(615, 27);
            txtGhiChuHoaDon.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(83, 38);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhân Viên Lập(*)";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(502, 38);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 1;
            label3.Text = "Khách Hàng";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(83, 75);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 1;
            label2.Text = "Ghi Chú Hóa Đơn";
            // 
            // cboNhanVien
            // 
            cboNhanVien.Anchor = AnchorStyles.None;
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(213, 35);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(227, 28);
            cboNhanVien.TabIndex = 0;
            // 
            // cboKhachHang
            // 
            cboKhachHang.Anchor = AnchorStyles.None;
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(618, 35);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(210, 28);
            cboKhachHang.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(228, 13);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 1;
            label5.Text = "Đơn Giá Bán";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(377, 13);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 1;
            label6.Text = "Số Lượng Bán";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(25, 13);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 1;
            label4.Text = "Sản phẩm(*)";
            label4.Click += label4_Click;
            // 
            // cboSanPham
            // 
            cboSanPham.Anchor = AnchorStyles.None;
            cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(25, 36);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(181, 28);
            cboSanPham.TabIndex = 0;
            cboSanPham.SelectedIndexChanged += cboSanPham_SelectedIndexChanged;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
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
            dataGridView.Location = new Point(0, 0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(905, 140);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
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
            // numDonGiaBan
            // 
            numDonGiaBan.Anchor = AnchorStyles.None;
            numDonGiaBan.BackColor = SystemColors.ButtonHighlight;
            numDonGiaBan.Enabled = false;
            numDonGiaBan.Location = new Point(228, 36);
            numDonGiaBan.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(129, 27);
            numDonGiaBan.TabIndex = 1;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Anchor = AnchorStyles.None;
            numSoLuongBan.Location = new Point(377, 36);
            numSoLuongBan.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(117, 27);
            numSoLuongBan.TabIndex = 2;
            numSoLuongBan.ValueChanged += numSoLuongBan_ValueChanged;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Anchor = AnchorStyles.None;
            btnXacNhanBan.BackColor = Color.SteelBlue;
            btnXacNhanBan.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhanBan.ForeColor = Color.Transparent;
            btnXacNhanBan.Image = (Image)resources.GetObject("btnXacNhanBan.Image");
            btnXacNhanBan.Location = new Point(647, 23);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(146, 52);
            btnXacNhanBan.TabIndex = 4;
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
            btnXoa.Location = new Point(800, 23);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(96, 51);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.SteelBlue;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnTimKiem.ForeColor = Color.Transparent;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(647, 80);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(146, 52);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F);
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(800, 80);
            button1.Name = "button1";
            button1.Size = new Size(96, 52);
            button1.TabIndex = 8;
            button1.Text = "Tải Lại";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BackColor = SystemColors.ButtonHighlight;
            txtTimKiem.ForeColor = SystemColors.ScrollBar;
            txtTimKiem.Location = new Point(25, 99);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(608, 27);
            txtTimKiem.TabIndex = 6;
            txtTimKiem.Tag = "";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(28, 75);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 30;
            label7.Text = "Tìm Kiếm";
            label7.Click += label7_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboKhachHang);
            groupBox2.Controls.Add(txtGhiChuHoaDon);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cboNhanVien);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(911, 118);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Hóa Đơn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(911, 317);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Hóa Đơn Chi Tiết";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 174);
            panel3.Name = "panel3";
            panel3.Size = new Size(905, 140);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtTimKiem);
            panel2.Controls.Add(cboSanPham);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(numTonKho);
            panel2.Controls.Add(numDonGiaBan);
            panel2.Controls.Add(numSoLuongBan);
            panel2.Controls.Add(btnXacNhanBan);
            panel2.Controls.Add(btnXoa);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(905, 151);
            panel2.TabIndex = 0;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(515, 13);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 1;
            label8.Text = "Tồn Kho";
            label8.Click += label6_Click;
            // 
            // numTonKho
            // 
            numTonKho.Anchor = AnchorStyles.None;
            numTonKho.Enabled = false;
            numTonKho.Location = new Point(515, 36);
            numTonKho.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numTonKho.Name = "numTonKho";
            numTonKho.Size = new Size(118, 27);
            numTonKho.TabIndex = 3;
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 512);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa Đơn Chi tiết";
            Load += frmHoaDon_ChiTiet_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTonKho).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLuuHoaDon;
        private Button btnInHoaDon;
        private Button btnThoat;
        private Panel panel1;
        private ComboBox cboKhachHang;
        private ComboBox cboNhanVien;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtGhiChuHoaDon;
        private Label label7;
        private TextBox txtTimKiem;
        private Button button1;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnXacNhanBan;
        private NumericUpDown numSoLuongBan;
        private NumericUpDown numDonGiaBan;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn SanPhamID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
        private Label label4;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Panel panel3;
        private Panel panel2;
        public ComboBox cboSanPham;
        private Button btnPhongCach;
        private Label label8;
        private NumericUpDown numTonKho;
    }
}