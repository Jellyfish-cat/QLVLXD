namespace WinFormsApp1
{
    partial class ChiTietPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietPhieuNhap));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnthemnhacungcap = new Button();
            cboNhaCungCap = new ComboBox();
            cboNhanVien = new ComboBox();
            txtGhiChuHoaDon = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            panel3 = new Panel();
            dataGridView = new DataGridView();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            SoLuongNhap = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label7 = new Label();
            numSoLuongNhap = new NumericUpDown();
            btnThemSanPham = new Button();
            btnXacNhanBan = new Button();
            txtTimKiem = new TextBox();
            btnXoa = new Button();
            label6 = new Label();
            cboHangSanXuat = new ComboBox();
            cboSanPham = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            btnTimKiem = new Button();
            label4 = new Label();
            panel1 = new Panel();
            btnLuuPhieuNhap = new Button();
            btnThoat = new Button();
            btnInPhieuNhap = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongNhap).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnthemnhacungcap);
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 126);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Phiếu Nhập";
            // 
            // btnthemnhacungcap
            // 
            btnthemnhacungcap.Anchor = AnchorStyles.None;
            btnthemnhacungcap.BackColor = Color.SteelBlue;
            btnthemnhacungcap.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnthemnhacungcap.ForeColor = Color.Transparent;
            btnthemnhacungcap.Image = (Image)resources.GetObject("btnthemnhacungcap.Image");
            btnthemnhacungcap.Location = new Point(716, 24);
            btnthemnhacungcap.Margin = new Padding(3, 4, 3, 4);
            btnthemnhacungcap.Name = "btnthemnhacungcap";
            btnthemnhacungcap.Size = new Size(50, 36);
            btnthemnhacungcap.TabIndex = 32;
            btnthemnhacungcap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnthemnhacungcap.UseVisualStyleBackColor = false;
            btnthemnhacungcap.Click += btnthemnhacungcap_Click;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.Anchor = AnchorStyles.None;
            cboNhaCungCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(527, 29);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(184, 28);
            cboNhaCungCap.TabIndex = 1;
            // 
            // cboNhanVien
            // 
            cboNhanVien.Anchor = AnchorStyles.None;
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(151, 29);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(227, 28);
            cboNhanVien.TabIndex = 0;
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Anchor = AnchorStyles.None;
            txtGhiChuHoaDon.Location = new Point(151, 77);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(615, 27);
            txtGhiChuHoaDon.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 4;
            label2.Text = "Ghi Chú Phiếu Nhập";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 6;
            label1.Text = "Nhân Viên Lập(*)";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(417, 32);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 5;
            label3.Text = "Nhà Cung Cấp";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 386);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Phiếu Nhập Chi Tiết";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 170);
            panel3.Name = "panel3";
            panel3.Size = new Size(794, 213);
            panel3.TabIndex = 44;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenSanPham, TenHangSanXuat, SoLuongNhap });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(794, 213);
            dataGridView.TabIndex = 1;
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
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Hãng Sản Xuất";
            TenHangSanXuat.MinimumWidth = 6;
            TenHangSanXuat.Name = "TenHangSanXuat";
            TenHangSanXuat.ReadOnly = true;
            // 
            // SoLuongNhap
            // 
            SoLuongNhap.DataPropertyName = "SoLuongNhap";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            SoLuongNhap.DefaultCellStyle = dataGridViewCellStyle1;
            SoLuongNhap.HeaderText = "Số Lượng Nhập";
            SoLuongNhap.MinimumWidth = 6;
            SoLuongNhap.Name = "SoLuongNhap";
            SoLuongNhap.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(numSoLuongNhap);
            panel2.Controls.Add(btnThemSanPham);
            panel2.Controls.Add(btnXacNhanBan);
            panel2.Controls.Add(txtTimKiem);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cboHangSanXuat);
            panel2.Controls.Add(cboSanPham);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 147);
            panel2.TabIndex = 43;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(537, 21);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 42;
            label7.Text = "Tìm Kiếm";
            // 
            // numSoLuongNhap
            // 
            numSoLuongNhap.Anchor = AnchorStyles.None;
            numSoLuongNhap.Location = new Point(190, 45);
            numSoLuongNhap.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongNhap.Name = "numSoLuongNhap";
            numSoLuongNhap.Size = new Size(128, 27);
            numSoLuongNhap.TabIndex = 1;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.Anchor = AnchorStyles.None;
            btnThemSanPham.BackColor = Color.SteelBlue;
            btnThemSanPham.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemSanPham.ForeColor = Color.Transparent;
            btnThemSanPham.Image = (Image)resources.GetObject("btnThemSanPham.Image");
            btnThemSanPham.ImageAlign = ContentAlignment.MiddleRight;
            btnThemSanPham.Location = new Point(283, 79);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(167, 52);
            btnThemSanPham.TabIndex = 5;
            btnThemSanPham.Text = "Sản Phẩm Mới";
            btnThemSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnThemSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemSanPham.UseVisualStyleBackColor = false;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Anchor = AnchorStyles.None;
            btnXacNhanBan.BackColor = Color.SteelBlue;
            btnXacNhanBan.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhanBan.ForeColor = Color.Transparent;
            btnXacNhanBan.Image = (Image)resources.GetObject("btnXacNhanBan.Image");
            btnXacNhanBan.Location = new Point(16, 77);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(159, 52);
            btnXacNhanBan.TabIndex = 3;
            btnXacNhanBan.Text = "Xác Nhận Nhập";
            btnXacNhanBan.TextAlign = ContentAlignment.MiddleRight;
            btnXacNhanBan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXacNhanBan.UseVisualStyleBackColor = false;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BackColor = SystemColors.ButtonHighlight;
            txtTimKiem.ForeColor = Color.Black;
            txtTimKiem.Location = new Point(537, 45);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(248, 27);
            txtTimKiem.TabIndex = 6;
            txtTimKiem.Tag = "";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.SteelBlue;
            btnXoa.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnXoa.ForeColor = Color.Transparent;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(181, 79);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(96, 51);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(190, 18);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 32;
            label6.Text = "Số Lượng Nhập";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.Anchor = AnchorStyles.None;
            cboHangSanXuat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(340, 45);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(151, 28);
            cboHangSanXuat.TabIndex = 2;
            // 
            // cboSanPham
            // 
            cboSanPham.Anchor = AnchorStyles.None;
            cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(16, 45);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(166, 28);
            cboSanPham.TabIndex = 0;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F);
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(670, 78);
            button1.Name = "button1";
            button1.Size = new Size(101, 50);
            button1.TabIndex = 8;
            button1.Text = "Tải Lại";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(340, 18);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 31;
            label5.Text = "Hãng Sản Xuất(*)";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.SteelBlue;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnTimKiem.ForeColor = Color.Transparent;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(537, 78);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(127, 52);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(18, 18);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 31;
            label4.Text = "Sản phẩm(*)";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLuuPhieuNhap);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnInPhieuNhap);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 445);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 3;
            // 
            // btnLuuPhieuNhap
            // 
            btnLuuPhieuNhap.Anchor = AnchorStyles.None;
            btnLuuPhieuNhap.BackColor = Color.SteelBlue;
            btnLuuPhieuNhap.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnLuuPhieuNhap.ForeColor = Color.Transparent;
            btnLuuPhieuNhap.Image = (Image)resources.GetObject("btnLuuPhieuNhap.Image");
            btnLuuPhieuNhap.Location = new Point(161, 7);
            btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            btnLuuPhieuNhap.Size = new Size(176, 52);
            btnLuuPhieuNhap.TabIndex = 0;
            btnLuuPhieuNhap.Text = "Lưu Phiếu Nhập";
            btnLuuPhieuNhap.TextAlign = ContentAlignment.MiddleRight;
            btnLuuPhieuNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuuPhieuNhap.UseVisualStyleBackColor = false;
            btnLuuPhieuNhap.Click += btnLuuPhieuNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.BackColor = Color.SteelBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(521, 9);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(118, 49);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnInPhieuNhap
            // 
            btnInPhieuNhap.Anchor = AnchorStyles.None;
            btnInPhieuNhap.BackColor = Color.SteelBlue;
            btnInPhieuNhap.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnInPhieuNhap.ForeColor = Color.Transparent;
            btnInPhieuNhap.Image = (Image)resources.GetObject("btnInPhieuNhap.Image");
            btnInPhieuNhap.Location = new Point(343, 9);
            btnInPhieuNhap.Name = "btnInPhieuNhap";
            btnInPhieuNhap.Size = new Size(172, 49);
            btnInPhieuNhap.TabIndex = 1;
            btnInPhieuNhap.Text = "In Phiếu Nhập";
            btnInPhieuNhap.TextAlign = ContentAlignment.MiddleRight;
            btnInPhieuNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInPhieuNhap.UseVisualStyleBackColor = false;
            btnInPhieuNhap.Click += btnInPhieuNhap_Click;
            // 
            // ChiTietPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ChiTietPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChiTietPhieuNhap";
            Load += ChiTietPhieuNhap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongNhap).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cboNhaCungCap;
        private ComboBox cboNhanVien;
        private TextBox txtGhiChuHoaDon;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label7;
        private TextBox txtTimKiem;
        private Button button1;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnXacNhanBan;
        private NumericUpDown numSoLuongNhap;
        private ComboBox cboSanPham;
        private Label label4;
        private Label label6;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dataGridView;
        private ComboBox cboHangSanXuat;
        private Label label5;
        private Button btnThemSanPham;
        private Panel panel1;
        private Button btnLuuPhieuNhap;
        private Button btnThoat;
        private Button btnInPhieuNhap;
        private DataGridViewTextBoxColumn SanPhamID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn SoLuongNhap;
        private Button btnthemnhacungcap;
    }
}