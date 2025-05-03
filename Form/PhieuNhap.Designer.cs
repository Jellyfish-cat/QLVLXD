namespace WinFormsApp1
{
    partial class PhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuNhap));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnXuat = new Button();
            btnSua = new Button();
            btnLapHoaDon = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            btnLoad = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            radNhanVien = new RadioButton();
            radNhaCungCap = new RadioButton();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            ID1 = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            GhiChuPhieuNhap = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXuat);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnLapHoaDon);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThoat);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 354);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 96);
            panel1.TabIndex = 0;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.None;
            btnXuat.BackColor = Color.SteelBlue;
            btnXuat.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnXuat.ForeColor = Color.Transparent;
            btnXuat.Image = (Image)resources.GetObject("btnXuat.Image");
            btnXuat.Location = new Point(563, 23);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(131, 52);
            btnXuat.TabIndex = 3;
            btnXuat.Text = "Xuất Excel";
            btnXuat.TextAlign = ContentAlignment.MiddleRight;
            btnXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.SteelBlue;
            btnSua.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnSua.ForeColor = Color.White;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(313, 23);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 52);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Anchor = AnchorStyles.None;
            btnLapHoaDon.BackColor = Color.SteelBlue;
            btnLapHoaDon.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnLapHoaDon.ForeColor = Color.Transparent;
            btnLapHoaDon.Image = (Image)resources.GetObject("btnLapHoaDon.Image");
            btnLapHoaDon.Location = new Point(91, 23);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(193, 52);
            btnLapHoaDon.TabIndex = 0;
            btnLapHoaDon.Text = "Lập Phiếu Nhập Mới";
            btnLapHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnLapHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLapHoaDon.UseVisualStyleBackColor = false;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.SteelBlue;
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(436, 23);
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
            btnThoat.Location = new Point(723, 23);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 52);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(radNhanVien);
            groupBox1.Controls.Add(radNhaCungCap);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(908, 94);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Phiếu Nhập";
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.None;
            btnLoad.BackColor = Color.SteelBlue;
            btnLoad.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnLoad.ForeColor = Color.Transparent;
            btnLoad.Image = (Image)resources.GetObject("btnLoad.Image");
            btnLoad.Location = new Point(787, 19);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(97, 52);
            btnLoad.TabIndex = 4;
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
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnTimKiem.ForeColor = Color.Transparent;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(669, 19);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 52);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BackColor = SystemColors.ButtonHighlight;
            txtTimKiem.ForeColor = SystemColors.ScrollBar;
            txtTimKiem.Location = new Point(317, 32);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(345, 27);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.Tag = "";
            // 
            // radNhanVien
            // 
            radNhanVien.Anchor = AnchorStyles.None;
            radNhanVien.AutoSize = true;
            radNhanVien.Font = new Font("Microsoft Sans Serif", 10.2F);
            radNhanVien.Location = new Point(187, 33);
            radNhanVien.Name = "radNhanVien";
            radNhanVien.Size = new Size(107, 24);
            radNhanVien.TabIndex = 1;
            radNhanVien.Text = "Nhân Viên";
            radNhanVien.UseVisualStyleBackColor = true;
            radNhanVien.CheckedChanged += RadKhachHang_CheckedChanged;
            // 
            // radNhaCungCap
            // 
            radNhaCungCap.Anchor = AnchorStyles.None;
            radNhaCungCap.AutoSize = true;
            radNhaCungCap.Checked = true;
            radNhaCungCap.Font = new Font("Microsoft Sans Serif", 10.2F);
            radNhaCungCap.Location = new Point(42, 33);
            radNhaCungCap.Name = "radNhaCungCap";
            radNhaCungCap.Size = new Size(139, 24);
            radNhaCungCap.TabIndex = 0;
            radNhaCungCap.TabStop = true;
            radNhaCungCap.Text = "Nhà Cung Cấp";
            radNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(908, 260);
            panel2.TabIndex = 2;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID1, TenNhanVien, TenNhaCungCap, GhiChuPhieuNhap, NgayLap, XemChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(908, 260);
            dataGridView.TabIndex = 1;
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
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Nhân Viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.HeaderText = "Nhà Cung Cấp";
            TenNhaCungCap.MinimumWidth = 6;
            TenNhaCungCap.Name = "TenNhaCungCap";
            TenNhaCungCap.ReadOnly = true;
            // 
            // GhiChuPhieuNhap
            // 
            GhiChuPhieuNhap.DataPropertyName = "GhiChuPhieuNhap";
            GhiChuPhieuNhap.HeaderText = "Ghi Chú";
            GhiChuPhieuNhap.MinimumWidth = 6;
            GhiChuPhieuNhap.Name = "GhiChuPhieuNhap";
            GhiChuPhieuNhap.ReadOnly = true;
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
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            XemChiTiet.DefaultCellStyle = dataGridViewCellStyle3;
            XemChiTiet.HeaderText = "Chi Tiết";
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.ReadOnly = true;
            // 
            // PhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 450);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "PhieuNhap";
            Text = "PhieuNhap";
            Load += PhieuNhap_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnXuat;
        private Button btnSua;
        private Button btnLapHoaDon;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnLoad;
        private RadioButton radNhanVien;
        private RadioButton radNhaCungCap;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Panel panel2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID1;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn GhiChuPhieuNhap;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewLinkColumn XemChiTiet;
    }
}