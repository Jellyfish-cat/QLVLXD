namespace QLBH
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            picHinhAnh = new PictureBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnSua = new Button();
            btnDoiAnh = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            groupBox1 = new GroupBox();
            cboNhaCungCap = new ComboBox();
            btnthemdanhmuc = new Button();
            btnthemhangsanxuat = new Button();
            cboHangSanXuat = new ComboBox();
            cboTenDanhMuc = new ComboBox();
            txtMoTa = new TextBox();
            label5 = new Label();
            label1 = new Label();
            numSoLuong = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            txtTenSanPham = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            numGia = new NumericUpDown();
            groupBox2 = new GroupBox();
            btnLoad = new Button();
            btnTimKiem = new Button();
            radNhaCungCap = new RadioButton();
            radHangSanXuat = new RadioButton();
            txtTimKiem = new TextBox();
            radDanhMuc = new RadioButton();
            radVatLieu = new RadioButton();
            panel1 = new Panel();
            dgvSanPham = new DataGridView();
            id1 = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            TenDanhMuc = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGia).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(picHinhAnh);
            panel2.Controls.Add(btnXuat);
            panel2.Controls.Add(btnNhap);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnDoiAnh);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnHuy);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1106, 422);
            panel2.TabIndex = 0;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Anchor = AnchorStyles.None;
            picHinhAnh.Location = new Point(571, 25);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(227, 223);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 10;
            picHinhAnh.TabStop = false;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.None;
            btnXuat.BackColor = Color.SteelBlue;
            btnXuat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnXuat.ForeColor = Color.Transparent;
            btnXuat.Image = (Image)resources.GetObject("btnXuat.Image");
            btnXuat.Location = new Point(559, 344);
            btnXuat.Margin = new Padding(3, 4, 3, 4);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(105, 52);
            btnXuat.TabIndex = 5;
            btnXuat.Text = "Xuất";
            btnXuat.TextAlign = ContentAlignment.MiddleRight;
            btnXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Anchor = AnchorStyles.None;
            btnNhap.BackColor = Color.SteelBlue;
            btnNhap.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnNhap.ForeColor = Color.White;
            btnNhap.Image = (Image)resources.GetObject("btnNhap.Image");
            btnNhap.Location = new Point(443, 344);
            btnNhap.Margin = new Padding(3, 4, 3, 4);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(105, 52);
            btnNhap.TabIndex = 4;
            btnNhap.Text = "Nhập";
            btnNhap.TextAlign = ContentAlignment.MiddleRight;
            btnNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.SteelBlue;
            btnSua.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSua.ForeColor = Color.Transparent;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(322, 344);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 52);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Anchor = AnchorStyles.None;
            btnDoiAnh.BackColor = Color.SteelBlue;
            btnDoiAnh.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnDoiAnh.ForeColor = Color.Transparent;
            btnDoiAnh.Image = (Image)resources.GetObject("btnDoiAnh.Image");
            btnDoiAnh.Location = new Point(632, 268);
            btnDoiAnh.Margin = new Padding(3, 4, 3, 4);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(124, 52);
            btnDoiAnh.TabIndex = 9;
            btnDoiAnh.Text = "Đổi Ảnh";
            btnDoiAnh.TextAlign = ContentAlignment.MiddleRight;
            btnDoiAnh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDoiAnh.UseVisualStyleBackColor = false;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.SteelBlue;
            btnThem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThem.ForeColor = Color.Transparent;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.Location = new Point(84, 344);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 52);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.SteelBlue;
            btnXoa.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnXoa.ForeColor = Color.Transparent;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(203, 344);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 52);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.None;
            btnHuy.BackColor = Color.SteelBlue;
            btnHuy.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnHuy.ForeColor = Color.White;
            btnHuy.Image = (Image)resources.GetObject("btnHuy.Image");
            btnHuy.Location = new Point(798, 344);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(105, 52);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.TextAlign = ContentAlignment.MiddleRight;
            btnHuy.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.BackColor = Color.SteelBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(917, 344);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 52);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.BackColor = Color.SteelBlue;
            btnLuu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnLuu.ForeColor = Color.White;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(679, 344);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(105, 52);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(btnthemdanhmuc);
            groupBox1.Controls.Add(btnthemhangsanxuat);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(cboTenDanhMuc);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numGia);
            groupBox1.Location = new Point(26, 10);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(510, 326);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Sản Phẩm";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.Anchor = AnchorStyles.None;
            cboNhaCungCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(157, 241);
            cboNhaCungCap.Margin = new Padding(3, 4, 3, 4);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(254, 28);
            cboNhaCungCap.TabIndex = 5;
            // 
            // btnthemdanhmuc
            // 
            btnthemdanhmuc.Anchor = AnchorStyles.None;
            btnthemdanhmuc.BackColor = Color.SteelBlue;
            btnthemdanhmuc.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnthemdanhmuc.ForeColor = Color.Transparent;
            btnthemdanhmuc.Image = (Image)resources.GetObject("btnthemdanhmuc.Image");
            btnthemdanhmuc.Location = new Point(426, 152);
            btnthemdanhmuc.Margin = new Padding(3, 4, 3, 4);
            btnthemdanhmuc.Name = "btnthemdanhmuc";
            btnthemdanhmuc.Size = new Size(50, 36);
            btnthemdanhmuc.TabIndex = 7;
            btnthemdanhmuc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnthemdanhmuc.UseVisualStyleBackColor = false;
            btnthemdanhmuc.Click += btnthemdanhmuc_Click;
            // 
            // btnthemhangsanxuat
            // 
            btnthemhangsanxuat.Anchor = AnchorStyles.None;
            btnthemhangsanxuat.BackColor = Color.SteelBlue;
            btnthemhangsanxuat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnthemhangsanxuat.ForeColor = Color.Transparent;
            btnthemhangsanxuat.Image = (Image)resources.GetObject("btnthemhangsanxuat.Image");
            btnthemhangsanxuat.Location = new Point(426, 194);
            btnthemhangsanxuat.Margin = new Padding(3, 4, 3, 4);
            btnthemhangsanxuat.Name = "btnthemhangsanxuat";
            btnthemhangsanxuat.Size = new Size(50, 36);
            btnthemhangsanxuat.TabIndex = 8;
            btnthemhangsanxuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnthemhangsanxuat.UseVisualStyleBackColor = false;
            btnthemhangsanxuat.Click += btnthemhang_Click;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.Anchor = AnchorStyles.None;
            cboHangSanXuat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(157, 199);
            cboHangSanXuat.Margin = new Padding(3, 4, 3, 4);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(254, 28);
            cboHangSanXuat.TabIndex = 4;
            // 
            // cboTenDanhMuc
            // 
            cboTenDanhMuc.Anchor = AnchorStyles.None;
            cboTenDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTenDanhMuc.FormattingEnabled = true;
            cboTenDanhMuc.Location = new Point(157, 157);
            cboTenDanhMuc.Margin = new Padding(3, 4, 3, 4);
            cboTenDanhMuc.Name = "cboTenDanhMuc";
            cboTenDanhMuc.Size = new Size(254, 28);
            cboTenDanhMuc.TabIndex = 3;
            // 
            // txtMoTa
            // 
            txtMoTa.Anchor = AnchorStyles.None;
            txtMoTa.Location = new Point(157, 75);
            txtMoTa.Margin = new Padding(3, 4, 3, 4);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(289, 27);
            txtMoTa.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(31, 123);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 1;
            label5.Text = "Giá";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(31, 82);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Mô Tả Sản Phẩm";
            label1.Click += label1_Click;
            // 
            // numSoLuong
            // 
            numSoLuong.Anchor = AnchorStyles.None;
            numSoLuong.Location = new Point(157, 283);
            numSoLuong.Margin = new Padding(3, 4, 3, 4);
            numSoLuong.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(167, 27);
            numSoLuong.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(31, 290);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 15;
            label6.Text = "Số Lượng";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(31, 249);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 2;
            label7.Text = "Nhà Cung Cấp";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Anchor = AnchorStyles.None;
            txtTenSanPham.Location = new Point(157, 34);
            txtTenSanPham.Margin = new Padding(3, 4, 3, 4);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(289, 27);
            txtTenSanPham.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(31, 207);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Hãng Sản Xuất";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(31, 37);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên Sản Phẩm";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(31, 165);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 2;
            label4.Text = "Tên Danh Mục";
            // 
            // numGia
            // 
            numGia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numGia.Location = new Point(157, 116);
            numGia.Margin = new Padding(3, 4, 3, 4);
            numGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numGia.Name = "numGia";
            numGia.Size = new Size(219, 27);
            numGia.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(btnLoad);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(radNhaCungCap);
            groupBox2.Controls.Add(radHangSanXuat);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(radDanhMuc);
            groupBox2.Controls.Add(radVatLieu);
            groupBox2.Location = new Point(814, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 284);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Kiếm";
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.None;
            btnLoad.BackColor = Color.SteelBlue;
            btnLoad.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnLoad.ForeColor = Color.Transparent;
            btnLoad.Image = (Image)resources.GetObject("btnLoad.Image");
            btnLoad.Location = new Point(150, 207);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(105, 52);
            btnLoad.TabIndex = 6;
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
            btnTimKiem.Location = new Point(27, 207);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(117, 52);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // radNhaCungCap
            // 
            radNhaCungCap.Anchor = AnchorStyles.None;
            radNhaCungCap.AutoSize = true;
            radNhaCungCap.Location = new Point(27, 168);
            radNhaCungCap.Name = "radNhaCungCap";
            radNhaCungCap.Size = new Size(125, 24);
            radNhaCungCap.TabIndex = 4;
            radNhaCungCap.Text = "Nhà Cung Cấp";
            radNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // radHangSanXuat
            // 
            radHangSanXuat.Anchor = AnchorStyles.None;
            radHangSanXuat.AutoSize = true;
            radHangSanXuat.Location = new Point(27, 136);
            radHangSanXuat.Name = "radHangSanXuat";
            radHangSanXuat.Size = new Size(128, 24);
            radHangSanXuat.TabIndex = 3;
            radHangSanXuat.Text = "Hãng Sản Xuất";
            radHangSanXuat.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BackColor = SystemColors.ButtonHighlight;
            txtTimKiem.ForeColor = SystemColors.ScrollBar;
            txtTimKiem.Location = new Point(27, 34);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(228, 27);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.Tag = "";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // radDanhMuc
            // 
            radDanhMuc.Anchor = AnchorStyles.None;
            radDanhMuc.AutoSize = true;
            radDanhMuc.Location = new Point(27, 106);
            radDanhMuc.Name = "radDanhMuc";
            radDanhMuc.Size = new Size(97, 24);
            radDanhMuc.TabIndex = 2;
            radDanhMuc.Text = "Danh Mục";
            radDanhMuc.UseVisualStyleBackColor = true;
            // 
            // radVatLieu
            // 
            radVatLieu.Anchor = AnchorStyles.None;
            radVatLieu.AutoSize = true;
            radVatLieu.Checked = true;
            radVatLieu.Location = new Point(27, 76);
            radVatLieu.Name = "radVatLieu";
            radVatLieu.Size = new Size(83, 24);
            radVatLieu.TabIndex = 1;
            radVatLieu.TabStop = true;
            radVatLieu.Text = "Vật Liệu";
            radVatLieu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvSanPham);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 422);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 223);
            panel1.TabIndex = 1;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { id1, TenSanPham, TenDanhMuc, TenHangSanXuat, TenNhaCungCap, MoTa, Gia, SoLuong, HinhAnh });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSanPham.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(0, 0);
            dgvSanPham.Margin = new Padding(3, 4, 3, 4);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.RowTemplate.Height = 24;
            dgvSanPham.ScrollBars = ScrollBars.Horizontal;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(1106, 223);
            dgvSanPham.TabIndex = 1;
            dgvSanPham.CellFormatting += dgvSanPham_CellFormatting;
            // 
            // id1
            // 
            id1.DataPropertyName = "id1";
            id1.HeaderText = "ID";
            id1.MinimumWidth = 6;
            id1.Name = "id1";
            id1.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // TenDanhMuc
            // 
            TenDanhMuc.DataPropertyName = "TenDanhMuc";
            TenDanhMuc.HeaderText = "Tên Danh Mục";
            TenDanhMuc.MinimumWidth = 6;
            TenDanhMuc.Name = "TenDanhMuc";
            TenDanhMuc.ReadOnly = true;
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Hãng Sản Xuất";
            TenHangSanXuat.MinimumWidth = 6;
            TenHangSanXuat.Name = "TenHangSanXuat";
            TenHangSanXuat.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.HeaderText = "Tên Nhà Cung Cấp";
            TenNhaCungCap.MinimumWidth = 6;
            TenNhaCungCap.Name = "TenNhaCungCap";
            TenNhaCungCap.ReadOnly = true;
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            MoTa.DefaultCellStyle = dataGridViewCellStyle2;
            MoTa.HeaderText = "Mô tả";
            MoTa.MinimumWidth = 6;
            MoTa.Name = "MoTa";
            MoTa.ReadOnly = true;
            // 
            // Gia
            // 
            Gia.DataPropertyName = "Gia";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            Gia.DefaultCellStyle = dataGridViewCellStyle3;
            Gia.HeaderText = "Giá";
            Gia.MinimumWidth = 6;
            Gia.Name = "Gia";
            Gia.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình Ảnh";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            HinhAnh.Resizable = DataGridViewTriState.True;
            // 
            // SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 645);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản Phẩm";
            WindowState = FormWindowState.Maximized;
            Load += SanPham_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGia).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTenDanhMuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnNhap;
        private PictureBox picHinhAnh;
        private Button btnDoiAnh;
        private ComboBox cboHangSanXuat;
        private Label label3;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private RadioButton radVatLieu;
        private RadioButton radHangSanXuat;
        private RadioButton radDanhMuc;
        private GroupBox groupBox2;
        private Button btnLoad;
        private ComboBox cboNhaCungCap;
        private Label label7;
        private RadioButton radNhaCungCap;
        private Button btnthemdanhmuc;
        private Button btnthemhangsanxuat;
        private DataGridViewTextBoxColumn id1;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn TenDanhMuc;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewImageColumn HinhAnh;
    }
}