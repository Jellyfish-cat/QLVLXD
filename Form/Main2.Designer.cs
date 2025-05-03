namespace WinFormsApp1
{
    partial class Main2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main2));
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuDanhMuc = new ToolStripMenuItem();
            mnuSanPham = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuTaiKhoan = new ToolStripMenuItem();
            mnuHangSanXuat = new ToolStripMenuItem();
            mnuNhaCungCap = new ToolStripMenuItem();
            mnuHoatDong = new ToolStripMenuItem();
            mnuMuaHang = new ToolStripMenuItem();
            mnuDonHang = new ToolStripMenuItem();
            mnmuPhieuNhap = new ToolStripMenuItem();
            mnuPhieuNhapChiTiet = new ToolStripMenuItem();
            mnuThongKe = new ToolStripMenuItem();
            mnuBDSP = new ToolStripMenuItem();
            mnuBDDT = new ToolStripMenuItem();
            mnuBaoCao = new ToolStripMenuItem();
            mnuSP = new ToolStripMenuItem();
            mnuDT = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuThongTin = new ToolStripMenuItem();
            mnuHuongDan = new ToolStripMenuItem();
            mnuSLKP = new ToolStripMenuItem();
            mnuSaoLuu = new ToolStripMenuItem();
            mnuKhoiPhuc = new ToolStripMenuItem();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            btnTrangChu = new Button();
            btnHangSanXuat = new Button();
            btnSanPham = new Button();
            btnHoaDon = new Button();
            btnHoaDonChiTiet = new Button();
            btnDanhMuc = new Button();
            btnNhaCungCap = new Button();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnKhachHang = new Button();
            btnNhanVien = new Button();
            btnPhieuNhap = new Button();
            btnPhieuNhapChiTiet = new Button();
            btnThongKeSanPham = new Button();
            btnThongKeDoanhThu = new Button();
            btnBieuDoSanPham = new Button();
            btnBieuDoDanhThu = new Button();
            btnThoat = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(30, 30);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuHoatDong, mnuThongKe, mnuBaoCao, mnuTroGiup, mnuSLKP, cậpNhậtToolStripMenuItem });
            menuStrip1.Location = new Point(212, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(829, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, đổiMậtKhẩuToolStripMenuItem, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.ShowShortcutKeys = false;
            mnuHeThong.Size = new Size(88, 24);
            mnuHeThong.Text = "&Hệ Thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.ShortcutKeyDisplayString = "";
            mnuDangNhap.Size = new Size(183, 26);
            mnuDangNhap.Text = "&Đăng Nhập...";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(183, 26);
            mnuDangXuat.Text = "Đăng &Xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(183, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật &Khẩu";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(183, 26);
            mnuThoat.Text = "&Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuDanhMuc, mnuSanPham, mnuKhachHang, mnuTaiKhoan, mnuHangSanXuat, mnuNhaCungCap });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(75, 24);
            mnuQuanLy.Text = "&Quản Lý";
            // 
            // mnuDanhMuc
            // 
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Size = new Size(199, 26);
            mnuDanhMuc.Text = "&Danh Mục...";
            mnuDanhMuc.Click += mnuDanhMuc_Click;
            // 
            // mnuSanPham
            // 
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(199, 26);
            mnuSanPham.Text = "&Sản Phẩm...";
            mnuSanPham.Click += mnuSanPham_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(199, 26);
            mnuKhachHang.Text = "&Khách Hàng...";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuTaiKhoan
            // 
            mnuTaiKhoan.Name = "mnuTaiKhoan";
            mnuTaiKhoan.Size = new Size(199, 26);
            mnuTaiKhoan.Text = "Nhân &Viên...";
            mnuTaiKhoan.Click += mnuTaiKhoan_Click;
            // 
            // mnuHangSanXuat
            // 
            mnuHangSanXuat.Name = "mnuHangSanXuat";
            mnuHangSanXuat.Size = new Size(199, 26);
            mnuHangSanXuat.Text = "Hãng Sản &Xuất...";
            mnuHangSanXuat.Click += mnuHangSanXuat_Click;
            // 
            // mnuNhaCungCap
            // 
            mnuNhaCungCap.Name = "mnuNhaCungCap";
            mnuNhaCungCap.Size = new Size(199, 26);
            mnuNhaCungCap.Text = "Nhà Cung &Cấp...";
            mnuNhaCungCap.Click += mnuNhaCungCap_Click;
            // 
            // mnuHoatDong
            // 
            mnuHoatDong.DropDownItems.AddRange(new ToolStripItem[] { mnuMuaHang, mnuDonHang, mnmuPhieuNhap, mnuPhieuNhapChiTiet });
            mnuHoatDong.Name = "mnuHoatDong";
            mnuHoatDong.Size = new Size(97, 24);
            mnuHoatDong.Text = "H&oạt Động";
            // 
            // mnuMuaHang
            // 
            mnuMuaHang.Name = "mnuMuaHang";
            mnuMuaHang.Size = new Size(222, 26);
            mnuMuaHang.Text = "&Chi Tiết Hóa Đơn...";
            mnuMuaHang.Click += mnuMuaHang_Click;
            // 
            // mnuDonHang
            // 
            mnuDonHang.Name = "mnuDonHang";
            mnuDonHang.Size = new Size(222, 26);
            mnuDonHang.Text = "Hóa Đơ&n...";
            mnuDonHang.Click += mnuDonHang_Click;
            // 
            // mnmuPhieuNhap
            // 
            mnmuPhieuNhap.Name = "mnmuPhieuNhap";
            mnmuPhieuNhap.Size = new Size(222, 26);
            mnmuPhieuNhap.Text = "Phiếu &Nhập";
            mnmuPhieuNhap.Click += mnmuPhieuNhap_Click;
            // 
            // mnuPhieuNhapChiTiet
            // 
            mnuPhieuNhapChiTiet.Name = "mnuPhieuNhapChiTiet";
            mnuPhieuNhapChiTiet.Size = new Size(222, 26);
            mnuPhieuNhapChiTiet.Text = "Chi Tiết Phiếu Nhập";
            mnuPhieuNhapChiTiet.Click += mnuPhieuNhapChiTiet_Click;
            // 
            // mnuThongKe
            // 
            mnuThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuBDSP, mnuBDDT });
            mnuThongKe.Name = "mnuThongKe";
            mnuThongKe.Size = new Size(86, 24);
            mnuThongKe.Text = "Thốn&g Kê";
            // 
            // mnuBDSP
            // 
            mnuBDSP.Name = "mnuBDSP";
            mnuBDSP.Size = new Size(230, 26);
            mnuBDSP.Text = "Biểu Đồ Sản Phẩm...";
            mnuBDSP.Click += mnuBDSP_Click;
            // 
            // mnuBDDT
            // 
            mnuBDDT.Name = "mnuBDDT";
            mnuBDDT.Size = new Size(230, 26);
            mnuBDDT.Text = "Biểu Đồ Doanh Thu...";
            mnuBDDT.Click += mnuBDDT_Click;
            // 
            // mnuBaoCao
            // 
            mnuBaoCao.DropDownItems.AddRange(new ToolStripItem[] { mnuSP, mnuDT });
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.Size = new Size(79, 24);
            mnuBaoCao.Text = "&Báo Cáo";
            // 
            // mnuSP
            // 
            mnuSP.Name = "mnuSP";
            mnuSP.Size = new Size(173, 26);
            mnuSP.Text = "Sản Phẩm...";
            // 
            // mnuDT
            // 
            mnuDT.Name = "mnuDT";
            mnuDT.Size = new Size(173, 26);
            mnuDT.Text = "Doanh Thu...";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuThongTin, mnuHuongDan });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(88, 24);
            mnuTroGiup.Text = "Trợ Giú&p...";
            // 
            // mnuThongTin
            // 
            mnuThongTin.Name = "mnuThongTin";
            mnuThongTin.ShortcutKeys = Keys.Control | Keys.F1;
            mnuThongTin.Size = new Size(287, 26);
            mnuThongTin.Text = "Thông tin Phần mềm";
            mnuThongTin.Click += mnuThongTin_Click;
            // 
            // mnuHuongDan
            // 
            mnuHuongDan.Name = "mnuHuongDan";
            mnuHuongDan.ShortcutKeys = Keys.Control | Keys.F2;
            mnuHuongDan.Size = new Size(287, 26);
            mnuHuongDan.Text = "Hường Dẫn Sử Dụng";
            mnuHuongDan.Click += mnuHuongDan_Click;
            // 
            // mnuSLKP
            // 
            mnuSLKP.DropDownItems.AddRange(new ToolStripItem[] { mnuSaoLuu, mnuKhoiPhuc });
            mnuSLKP.Name = "mnuSLKP";
            mnuSLKP.Size = new Size(145, 24);
            mnuSLKP.Text = "Sao Lưu Khôi Phục";
            // 
            // mnuSaoLuu
            // 
            mnuSaoLuu.Name = "mnuSaoLuu";
            mnuSaoLuu.Size = new Size(157, 26);
            mnuSaoLuu.Text = "Sao Lưu";
            mnuSaoLuu.Click += mnuSaoLuu_Click;
            // 
            // mnuKhoiPhuc
            // 
            mnuKhoiPhuc.Name = "mnuKhoiPhuc";
            mnuKhoiPhuc.Size = new Size(157, 26);
            mnuKhoiPhuc.Text = "Khôi Phục";
            mnuKhoiPhuc.Click += mnuKhoiPhuc_Click;
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(85, 24);
            cậpNhậtToolStripMenuItem.Text = "Cập Nhật";
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.SteelBlue;
            btnTrangChu.ForeColor = SystemColors.ButtonHighlight;
            btnTrangChu.Image = (Image)resources.GetObject("btnTrangChu.Image");
            btnTrangChu.Location = new Point(3, 3);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(184, 60);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleRight;
            btnTrangChu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTranChu_Click;
            // 
            // btnHangSanXuat
            // 
            btnHangSanXuat.BackColor = Color.SteelBlue;
            btnHangSanXuat.ForeColor = SystemColors.ButtonHighlight;
            btnHangSanXuat.Image = (Image)resources.GetObject("btnHangSanXuat.Image");
            btnHangSanXuat.Location = new Point(3, 135);
            btnHangSanXuat.Name = "btnHangSanXuat";
            btnHangSanXuat.Size = new Size(184, 60);
            btnHangSanXuat.TabIndex = 2;
            btnHangSanXuat.Text = "Hãng Sản Xuất";
            btnHangSanXuat.TextAlign = ContentAlignment.MiddleRight;
            btnHangSanXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHangSanXuat.UseVisualStyleBackColor = false;
            btnHangSanXuat.Click += btnHangSanXuat_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.SteelBlue;
            btnSanPham.ForeColor = SystemColors.ButtonHighlight;
            btnSanPham.Image = (Image)resources.GetObject("btnSanPham.Image");
            btnSanPham.Location = new Point(3, 201);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(184, 60);
            btnSanPham.TabIndex = 3;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.SteelBlue;
            btnHoaDon.ForeColor = SystemColors.ButtonHighlight;
            btnHoaDon.Image = (Image)resources.GetObject("btnHoaDon.Image");
            btnHoaDon.Location = new Point(3, 267);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(184, 60);
            btnHoaDon.TabIndex = 4;
            btnHoaDon.Text = "Hóa Đơn";
            btnHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnHoaDonChiTiet
            // 
            btnHoaDonChiTiet.BackColor = Color.SteelBlue;
            btnHoaDonChiTiet.ForeColor = SystemColors.ButtonHighlight;
            btnHoaDonChiTiet.Image = (Image)resources.GetObject("btnHoaDonChiTiet.Image");
            btnHoaDonChiTiet.Location = new Point(3, 333);
            btnHoaDonChiTiet.Name = "btnHoaDonChiTiet";
            btnHoaDonChiTiet.Size = new Size(184, 60);
            btnHoaDonChiTiet.TabIndex = 5;
            btnHoaDonChiTiet.Text = "Lập Hóa Đơn";
            btnHoaDonChiTiet.TextAlign = ContentAlignment.MiddleRight;
            btnHoaDonChiTiet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHoaDonChiTiet.UseVisualStyleBackColor = false;
            btnHoaDonChiTiet.Click += HoaDonChiTiet_Click;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.BackColor = Color.SteelBlue;
            btnDanhMuc.ForeColor = SystemColors.ButtonHighlight;
            btnDanhMuc.Image = (Image)resources.GetObject("btnDanhMuc.Image");
            btnDanhMuc.Location = new Point(3, 69);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(184, 60);
            btnDanhMuc.TabIndex = 1;
            btnDanhMuc.Text = "Danh Mục";
            btnDanhMuc.TextAlign = ContentAlignment.MiddleRight;
            btnDanhMuc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDanhMuc.UseVisualStyleBackColor = false;
            btnDanhMuc.Click += button1_Click;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.BackColor = Color.SteelBlue;
            btnNhaCungCap.ForeColor = SystemColors.ButtonHighlight;
            btnNhaCungCap.Image = (Image)resources.GetObject("btnNhaCungCap.Image");
            btnNhaCungCap.Location = new Point(3, 399);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Size = new Size(184, 60);
            btnNhaCungCap.TabIndex = 6;
            btnNhaCungCap.Text = "Nhà Cung Cấp";
            btnNhaCungCap.TextAlign = ContentAlignment.MiddleRight;
            btnNhaCungCap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhaCungCap.UseVisualStyleBackColor = false;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 1055);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnTrangChu);
            flowLayoutPanel1.Controls.Add(btnDanhMuc);
            flowLayoutPanel1.Controls.Add(btnHangSanXuat);
            flowLayoutPanel1.Controls.Add(btnSanPham);
            flowLayoutPanel1.Controls.Add(btnHoaDon);
            flowLayoutPanel1.Controls.Add(btnHoaDonChiTiet);
            flowLayoutPanel1.Controls.Add(btnNhaCungCap);
            flowLayoutPanel1.Controls.Add(btnKhachHang);
            flowLayoutPanel1.Controls.Add(btnNhanVien);
            flowLayoutPanel1.Controls.Add(btnPhieuNhap);
            flowLayoutPanel1.Controls.Add(btnPhieuNhapChiTiet);
            flowLayoutPanel1.Controls.Add(btnThongKeSanPham);
            flowLayoutPanel1.Controls.Add(btnThongKeDoanhThu);
            flowLayoutPanel1.Controls.Add(btnBieuDoSanPham);
            flowLayoutPanel1.Controls.Add(btnBieuDoDanhThu);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(212, 1055);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.SteelBlue;
            btnKhachHang.ForeColor = SystemColors.ButtonHighlight;
            btnKhachHang.Image = (Image)resources.GetObject("btnKhachHang.Image");
            btnKhachHang.Location = new Point(3, 465);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(184, 60);
            btnKhachHang.TabIndex = 7;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleRight;
            btnKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.SteelBlue;
            btnNhanVien.ForeColor = SystemColors.ButtonHighlight;
            btnNhanVien.Image = (Image)resources.GetObject("btnNhanVien.Image");
            btnNhanVien.Location = new Point(3, 531);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(184, 60);
            btnNhanVien.TabIndex = 8;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleRight;
            btnNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnPhieuNhap
            // 
            btnPhieuNhap.BackColor = Color.SteelBlue;
            btnPhieuNhap.ForeColor = SystemColors.ButtonHighlight;
            btnPhieuNhap.Image = (Image)resources.GetObject("btnPhieuNhap.Image");
            btnPhieuNhap.Location = new Point(3, 597);
            btnPhieuNhap.Name = "btnPhieuNhap";
            btnPhieuNhap.Size = new Size(184, 60);
            btnPhieuNhap.TabIndex = 9;
            btnPhieuNhap.Text = "Phiếu Nhập";
            btnPhieuNhap.TextAlign = ContentAlignment.MiddleRight;
            btnPhieuNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPhieuNhap.UseVisualStyleBackColor = false;
            btnPhieuNhap.Click += btnPhieuLap_Click;
            // 
            // btnPhieuNhapChiTiet
            // 
            btnPhieuNhapChiTiet.BackColor = Color.SteelBlue;
            btnPhieuNhapChiTiet.ForeColor = SystemColors.ButtonHighlight;
            btnPhieuNhapChiTiet.Image = (Image)resources.GetObject("btnPhieuNhapChiTiet.Image");
            btnPhieuNhapChiTiet.Location = new Point(3, 663);
            btnPhieuNhapChiTiet.Name = "btnPhieuNhapChiTiet";
            btnPhieuNhapChiTiet.Size = new Size(184, 60);
            btnPhieuNhapChiTiet.TabIndex = 10;
            btnPhieuNhapChiTiet.Text = "Lập Phiếu Nhập";
            btnPhieuNhapChiTiet.TextAlign = ContentAlignment.MiddleRight;
            btnPhieuNhapChiTiet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPhieuNhapChiTiet.UseVisualStyleBackColor = false;
            btnPhieuNhapChiTiet.Click += PhieuNhapChiTiet_Click;
            // 
            // btnThongKeSanPham
            // 
            btnThongKeSanPham.BackColor = Color.SteelBlue;
            btnThongKeSanPham.ForeColor = SystemColors.ButtonHighlight;
            btnThongKeSanPham.Image = (Image)resources.GetObject("btnThongKeSanPham.Image");
            btnThongKeSanPham.Location = new Point(3, 729);
            btnThongKeSanPham.Name = "btnThongKeSanPham";
            btnThongKeSanPham.Size = new Size(184, 60);
            btnThongKeSanPham.TabIndex = 11;
            btnThongKeSanPham.Text = "Báo Cáo Sản Phẩm";
            btnThongKeSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnThongKeSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongKeSanPham.UseVisualStyleBackColor = false;
            btnThongKeSanPham.Click += btnTKSP_Click;
            // 
            // btnThongKeDoanhThu
            // 
            btnThongKeDoanhThu.BackColor = Color.SteelBlue;
            btnThongKeDoanhThu.ForeColor = SystemColors.ButtonHighlight;
            btnThongKeDoanhThu.Image = (Image)resources.GetObject("btnThongKeDoanhThu.Image");
            btnThongKeDoanhThu.Location = new Point(3, 795);
            btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            btnThongKeDoanhThu.Size = new Size(184, 60);
            btnThongKeDoanhThu.TabIndex = 12;
            btnThongKeDoanhThu.Text = "Báo Cáo Doanh Thu";
            btnThongKeDoanhThu.TextAlign = ContentAlignment.MiddleRight;
            btnThongKeDoanhThu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongKeDoanhThu.UseVisualStyleBackColor = false;
            btnThongKeDoanhThu.Click += btnTKDT_Click;
            // 
            // btnBieuDoSanPham
            // 
            btnBieuDoSanPham.BackColor = Color.SteelBlue;
            btnBieuDoSanPham.ForeColor = SystemColors.ButtonHighlight;
            btnBieuDoSanPham.Image = (Image)resources.GetObject("btnBieuDoSanPham.Image");
            btnBieuDoSanPham.Location = new Point(3, 861);
            btnBieuDoSanPham.Name = "btnBieuDoSanPham";
            btnBieuDoSanPham.Size = new Size(184, 60);
            btnBieuDoSanPham.TabIndex = 13;
            btnBieuDoSanPham.Text = "Biểu Đồ Sản Phẩm";
            btnBieuDoSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnBieuDoSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBieuDoSanPham.UseVisualStyleBackColor = false;
            btnBieuDoSanPham.Click += BieuDoSP_Click;
            // 
            // btnBieuDoDanhThu
            // 
            btnBieuDoDanhThu.BackColor = Color.SteelBlue;
            btnBieuDoDanhThu.ForeColor = SystemColors.ButtonHighlight;
            btnBieuDoDanhThu.Image = (Image)resources.GetObject("btnBieuDoDanhThu.Image");
            btnBieuDoDanhThu.Location = new Point(3, 927);
            btnBieuDoDanhThu.Name = "btnBieuDoDanhThu";
            btnBieuDoDanhThu.Size = new Size(184, 60);
            btnBieuDoDanhThu.TabIndex = 14;
            btnBieuDoDanhThu.Text = "Biểu Đồ Doanh Thu";
            btnBieuDoDanhThu.TextAlign = ContentAlignment.MiddleRight;
            btnBieuDoDanhThu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBieuDoDanhThu.UseVisualStyleBackColor = false;
            btnBieuDoDanhThu.Click += btnBDDT_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SteelBlue;
            btnThoat.ForeColor = SystemColors.ButtonHighlight;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(3, 993);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(184, 60);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // Main2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 1055);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "Main2";
            Text = "Quản Lý Vật Liệu Xây Dựng";
            WindowState = FormWindowState.Maximized;
            Load += Main2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuTaiKhoan;
        private ToolStripMenuItem mnuHoatDong;
        private ToolStripMenuItem mnuMuaHang;
        private ToolStripMenuItem mnuDonHang;
        private ToolStripMenuItem mnuThongKe;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuThongTin;
        private ToolStripMenuItem mnuHuongDan;
        private Button btnTrangChu;
        private Button btnHangSanXuat;
        private Button btnSanPham;
        private Button btnHoaDon;
        private Button btnHoaDonChiTiet;
        private Button btnDanhMuc;
        private Button btnNhaCungCap;
        private Panel panel1;
        private Button btnKhachHang;
        private Button btnPhieuNhapChiTiet;
        private Button btnPhieuNhap;
        private Button btnNhanVien;
        private Button btnBieuDoDanhThu;
        private Button btnBieuDoSanPham;
        private Button btnThongKeDoanhThu;
        private Button btnThongKeSanPham;
        private ToolStripMenuItem mnuBaoCao;
        private ToolStripMenuItem mnuBDSP;
        private ToolStripMenuItem mnuBDDT;
        private ToolStripMenuItem mnuSP;
        private ToolStripMenuItem mnuDT;
        private ToolStripMenuItem mnuHangSanXuat;
        private ToolStripMenuItem mnuNhaCungCap;
        private ToolStripMenuItem mnmuPhieuNhap;
        private ToolStripMenuItem mnuPhieuNhapChiTiet;
        private Button btnThoat;
        private ToolStripMenuItem mnuSLKP;
        private ToolStripMenuItem mnuSaoLuu;
        private ToolStripMenuItem mnuKhoiPhuc;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
    }
}