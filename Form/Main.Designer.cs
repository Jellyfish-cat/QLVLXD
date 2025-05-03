namespace QLBH
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            mnuHoatDong = new ToolStripMenuItem();
            mnuMuaHang = new ToolStripMenuItem();
            mnuDonHang = new ToolStripMenuItem();
            mnuDoanhThu = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            thôngTinPhầnMềmToolStripMenuItem = new ToolStripMenuItem();
            hườngDẫnSửDụngToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnDangNhap = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            btnDangXuat = new ToolStripButton();
            toolStripLabel2 = new ToolStripLabel();
            btnDanhMuc = new ToolStripButton();
            toolStripLabel3 = new ToolStripLabel();
            btnSanPham = new ToolStripButton();
            toolStripLabel4 = new ToolStripLabel();
            btnDonHang = new ToolStripButton();
            toolStripLabel9 = new ToolStripLabel();
            btnMuaHang = new ToolStripButton();
            toolStripLabel10 = new ToolStripLabel();
            btnDoanhThu = new ToolStripButton();
            DoanhThu = new ToolStripLabel();
            btnKhachHang = new ToolStripButton();
            toolStripLabel6 = new ToolStripLabel();
            btnTaiKhoan = new ToolStripButton();
            toolStripLabel7 = new ToolStripLabel();
            btnThoat = new ToolStripButton();
            toolStripLabel8 = new ToolStripLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(30, 30);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuHoatDong, mnuDoanhThu, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1327, 28);
            menuStrip1.TabIndex = 0;
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
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuDanhMuc, mnuSanPham, mnuKhachHang, mnuTaiKhoan });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(75, 24);
            mnuQuanLy.Text = "Quản Lý";
            // 
            // mnuDanhMuc
            // 
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Size = new Size(181, 26);
            mnuDanhMuc.Text = "&Danh Mục...";
            mnuDanhMuc.Click += mnuDanhMuc_Click;
            // 
            // mnuSanPham
            // 
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(181, 26);
            mnuSanPham.Text = "&Sản Phẩm...";
            mnuSanPham.Click += mnuSanPham_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(181, 26);
            mnuKhachHang.Text = "&Khách Hàng...";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuTaiKhoan
            // 
            mnuTaiKhoan.Name = "mnuTaiKhoan";
            mnuTaiKhoan.Size = new Size(181, 26);
            mnuTaiKhoan.Text = "Nhân &Viên";
            mnuTaiKhoan.Click += mnuTaiKhoan_Click;
            // 
            // mnuHoatDong
            // 
            mnuHoatDong.DropDownItems.AddRange(new ToolStripItem[] { mnuMuaHang, mnuDonHang });
            mnuHoatDong.Name = "mnuHoatDong";
            mnuHoatDong.Size = new Size(97, 24);
            mnuHoatDong.Text = "H&oạt Động";
            // 
            // mnuMuaHang
            // 
            mnuMuaHang.Name = "mnuMuaHang";
            mnuMuaHang.Size = new Size(206, 26);
            mnuMuaHang.Text = "&Chi Tiết Hóa Đơn";
            mnuMuaHang.Click += mnuMuaHang_Click;
            // 
            // mnuDonHang
            // 
            mnuDonHang.Name = "mnuDonHang";
            mnuDonHang.Size = new Size(206, 26);
            mnuDonHang.Text = "Hóa Đơ&n";
            mnuDonHang.Click += mnuDonHang_Click;
            // 
            // mnuDoanhThu
            // 
            mnuDoanhThu.Name = "mnuDoanhThu";
            mnuDoanhThu.Size = new Size(95, 24);
            mnuDoanhThu.Text = "Doanh Thu";
            mnuDoanhThu.Click += mnuDoanhThu_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinPhầnMềmToolStripMenuItem, hườngDẫnSửDụngToolStripMenuItem });
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(79, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            thôngTinPhầnMềmToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F1;
            thôngTinPhầnMềmToolStripMenuItem.Size = new Size(287, 26);
            thôngTinPhầnMềmToolStripMenuItem.Text = "Thông tin Phần mềm";
            thôngTinPhầnMềmToolStripMenuItem.Click += thôngTinPhầnMềmToolStripMenuItem_Click;
            // 
            // hườngDẫnSửDụngToolStripMenuItem
            // 
            hườngDẫnSửDụngToolStripMenuItem.Name = "hườngDẫnSửDụngToolStripMenuItem";
            hườngDẫnSửDụngToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F2;
            hườngDẫnSửDụngToolStripMenuItem.Size = new Size(287, 26);
            hườngDẫnSửDụngToolStripMenuItem.Text = "Hường Dẫn Sử Dụng";
            hườngDẫnSửDụngToolStripMenuItem.Click += hườngDẫnSửDụngToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnDangNhap, toolStripLabel1, btnDangXuat, toolStripLabel2, btnDanhMuc, toolStripLabel3, btnSanPham, toolStripLabel4, btnDonHang, toolStripLabel9, btnMuaHang, toolStripLabel10, btnDoanhThu, DoanhThu, btnKhachHang, toolStripLabel6, btnTaiKhoan, toolStripLabel7, btnThoat, toolStripLabel8 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1327, 37);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnDangNhap
            // 
            btnDangNhap.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDangNhap.Image = (Image)resources.GetObject("btnDangNhap.Image");
            btnDangNhap.ImageTransparentColor = Color.Magenta;
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(34, 34);
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(85, 34);
            toolStripLabel1.Text = "Đăng Nhập";
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDangXuat.Image = (Image)resources.GetObject("btnDangXuat.Image");
            btnDangXuat.ImageTransparentColor = Color.Magenta;
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(34, 34);
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(79, 34);
            toolStripLabel2.Text = "Đăng Xuất";
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDanhMuc.Image = (Image)resources.GetObject("btnDanhMuc.Image");
            btnDanhMuc.ImageTransparentColor = Color.Magenta;
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(34, 34);
            btnDanhMuc.Text = "Danh Mục";
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(76, 34);
            toolStripLabel3.Text = "Danh Mục";
            // 
            // btnSanPham
            // 
            btnSanPham.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSanPham.Image = (Image)resources.GetObject("btnSanPham.Image");
            btnSanPham.ImageTransparentColor = Color.Magenta;
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(34, 34);
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.Click += btnSanPham_Click;
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(74, 34);
            toolStripLabel4.Text = "Sản Phẩm";
            // 
            // btnDonHang
            // 
            btnDonHang.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDonHang.Image = (Image)resources.GetObject("btnDonHang.Image");
            btnDonHang.ImageTransparentColor = Color.Magenta;
            btnDonHang.Name = "btnDonHang";
            btnDonHang.Size = new Size(34, 34);
            btnDonHang.Text = "Đơn Hàng";
            btnDonHang.Click += btnDonHang_Click;
            // 
            // toolStripLabel9
            // 
            toolStripLabel9.Name = "toolStripLabel9";
            toolStripLabel9.Size = new Size(69, 34);
            toolStripLabel9.Text = "Hóa Đơn";
            // 
            // btnMuaHang
            // 
            btnMuaHang.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMuaHang.Image = (Image)resources.GetObject("btnMuaHang.Image");
            btnMuaHang.ImageTransparentColor = Color.Magenta;
            btnMuaHang.Name = "btnMuaHang";
            btnMuaHang.Size = new Size(34, 34);
            btnMuaHang.Text = "Mua Hàng";
            btnMuaHang.Click += btnMuaHang_Click;
            // 
            // toolStripLabel10
            // 
            toolStripLabel10.Name = "toolStripLabel10";
            toolStripLabel10.Size = new Size(123, 34);
            toolStripLabel10.Text = "Chi Tiết Hóa Đơn";
            // 
            // btnDoanhThu
            // 
            btnDoanhThu.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDoanhThu.Image = (Image)resources.GetObject("btnDoanhThu.Image");
            btnDoanhThu.ImageTransparentColor = Color.Magenta;
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.Size = new Size(34, 34);
            btnDoanhThu.Text = "toolStripButton1";
            btnDoanhThu.Click += btnDoanhThu_Click;
            // 
            // DoanhThu
            // 
            DoanhThu.Name = "DoanhThu";
            DoanhThu.Size = new Size(77, 34);
            DoanhThu.Text = "DoanhThu";
            // 
            // btnKhachHang
            // 
            btnKhachHang.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnKhachHang.Image = (Image)resources.GetObject("btnKhachHang.Image");
            btnKhachHang.ImageTransparentColor = Color.Magenta;
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(34, 34);
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // toolStripLabel6
            // 
            toolStripLabel6.Name = "toolStripLabel6";
            toolStripLabel6.Size = new Size(89, 34);
            toolStripLabel6.Text = "Khách Hàng";
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnTaiKhoan.Image = (Image)resources.GetObject("btnTaiKhoan.Image");
            btnTaiKhoan.ImageTransparentColor = Color.Magenta;
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(34, 34);
            btnTaiKhoan.Text = "Tài Khoản";
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // toolStripLabel7
            // 
            toolStripLabel7.Name = "toolStripLabel7";
            toolStripLabel7.Size = new Size(77, 34);
            toolStripLabel7.Text = "Nhân Viên";
            // 
            // btnThoat
            // 
            btnThoat.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageTransparentColor = Color.Magenta;
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(34, 34);
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // toolStripLabel8
            // 
            toolStripLabel8.Name = "toolStripLabel8";
            toolStripLabel8.Size = new Size(47, 34);
            toolStripLabel8.Text = "Thoát";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 655);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lí Bán Hàng";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHoatDong;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuMuaHang;
        private System.Windows.Forms.ToolStripMenuItem mnuDonHang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDangNhap;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnDangXuat;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnDanhMuc;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnSanPham;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btnDonHang;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripButton btnMuaHang;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripButton btnKhachHang;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton btnTaiKhoan;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hườngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnDoanhThu;
        private System.Windows.Forms.ToolStripLabel DoanhThu;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    }
}

