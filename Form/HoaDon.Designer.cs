namespace QuanLiBanhang.Froms
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnLoad = new Button();
            RadKhachHang = new RadioButton();
            radNhanVien = new RadioButton();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dataGridView = new DataGridView();
            ID1 = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            btnLapHoaDon = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnXuat = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(RadKhachHang);
            groupBox1.Controls.Add(radNhanVien);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(908, 102);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Hóa Đơn";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.None;
            btnLoad.BackColor = Color.SteelBlue;
            btnLoad.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnLoad.ForeColor = Color.Transparent;
            btnLoad.Image = (Image)resources.GetObject("btnLoad.Image");
            btnLoad.Location = new Point(779, 25);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(97, 52);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Tải Lại";
            btnLoad.TextAlign = ContentAlignment.MiddleRight;
            btnLoad.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click_1;
            // 
            // RadKhachHang
            // 
            RadKhachHang.Anchor = AnchorStyles.None;
            RadKhachHang.AutoSize = true;
            RadKhachHang.Font = new Font("Microsoft Sans Serif", 10.2F);
            RadKhachHang.Location = new Point(175, 39);
            RadKhachHang.Name = "RadKhachHang";
            RadKhachHang.Size = new Size(122, 24);
            RadKhachHang.TabIndex = 1;
            RadKhachHang.Text = "Khách Hàng";
            RadKhachHang.UseVisualStyleBackColor = true;
            // 
            // radNhanVien
            // 
            radNhanVien.Anchor = AnchorStyles.None;
            radNhanVien.AutoSize = true;
            radNhanVien.Checked = true;
            radNhanVien.Font = new Font("Microsoft Sans Serif", 10.2F);
            radNhanVien.Location = new Point(55, 39);
            radNhanVien.Name = "radNhanVien";
            radNhanVien.Size = new Size(107, 24);
            radNhanVien.TabIndex = 0;
            radNhanVien.TabStop = true;
            radNhanVien.Text = "Nhân Viên";
            radNhanVien.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BackColor = SystemColors.ButtonHighlight;
            txtTimKiem.ForeColor = Color.Black;
            txtTimKiem.Location = new Point(305, 38);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(345, 27);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.Tag = "";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.SteelBlue;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnTimKiem.ForeColor = Color.Transparent;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(657, 25);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(116, 52);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID1, HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(908, 269);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // ID1
            // 
            ID1.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ID1.DefaultCellStyle = dataGridViewCellStyle1;
            ID1.HeaderText = "ID";
            ID1.MinimumWidth = 6;
            ID1.Name = "ID1";
            ID1.ReadOnly = true;
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Nhân Viên";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            HoVaTenNhanVien.ReadOnly = true;
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.HeaderText = "Khách Hàng";
            HoVaTenKhachHang.MinimumWidth = 6;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            HoVaTenKhachHang.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            NgayLap.DefaultCellStyle = dataGridViewCellStyle2;
            NgayLap.HeaderText = "Ngày Lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            TongTienHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            TongTienHoaDon.HeaderText = "Tổng Tiền";
            TongTienHoaDon.MinimumWidth = 6;
            TongTienHoaDon.Name = "TongTienHoaDon";
            TongTienHoaDon.ReadOnly = true;
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            XemChiTiet.DefaultCellStyle = dataGridViewCellStyle4;
            XemChiTiet.HeaderText = "Chi Tiết";
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.ReadOnly = true;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Anchor = AnchorStyles.None;
            btnLapHoaDon.BackColor = Color.SteelBlue;
            btnLapHoaDon.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnLapHoaDon.ForeColor = Color.Transparent;
            btnLapHoaDon.Image = (Image)resources.GetObject("btnLapHoaDon.Image");
            btnLapHoaDon.Location = new Point(98, 15);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(173, 52);
            btnLapHoaDon.TabIndex = 0;
            btnLapHoaDon.Text = "Lập Hóa Đơn Mới";
            btnLapHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnLapHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLapHoaDon.UseVisualStyleBackColor = false;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.SteelBlue;
            btnSua.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnSua.ForeColor = Color.White;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(302, 15);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 52);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.SteelBlue;
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(427, 15);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 52);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.BackColor = Color.SteelBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(716, 15);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 52);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.None;
            btnXuat.BackColor = Color.SteelBlue;
            btnXuat.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnXuat.ForeColor = Color.Transparent;
            btnXuat.Image = (Image)resources.GetObject("btnXuat.Image");
            btnXuat.Location = new Point(552, 15);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(133, 52);
            btnXuat.TabIndex = 3;
            btnXuat.Text = "Xuất Excel";
            btnXuat.TextAlign = ContentAlignment.MiddleRight;
            btnXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 269);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnLapHoaDon);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnXuat);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 371);
            panel2.Name = "panel2";
            panel2.Size = new Size(908, 79);
            panel2.TabIndex = 0;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 450);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "HoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHoaDon";
            Load += frmHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView;
        private Button btnLapHoaDon;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnXuat;
        private DataGridViewTextBoxColumn ID1;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewLinkColumn XemChiTiet;
        private TextBox txtTimKiem;
        private RadioButton RadKhachHang;
        private RadioButton radNhanVien;
        private Button btnLoad;
        private Panel panel1;
        private Panel panel2;
    }
}