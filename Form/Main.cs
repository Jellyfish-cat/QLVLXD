using QuanLiBanhang.Froms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp1.Data;
using BC = BCrypt.Net.BCrypt;

namespace QLBH
{
    public partial class Main : Form
    {
        public Main()
        {
            Flash flash = new Flash();
            flash.ShowDialog();
            InitializeComponent();

        }
        #region Biến toàn cục
        QLBHDbcontext context = new QLBHDbcontext();
        DangNhap dangNhap = null;
        string hoVaTen = "";
        DanhMuc DanhMuc = null;
        SanPham SanPham = null;
        HoaDon HoaDon = null;
        KhachHang KhachHang = null;
        frmHoaDon_ChiTiet ChiTietHoaDon = null;
        NhanVien nhanVien = null;
        AboutBox1 aboutBox1 = null;
        Helpa help = null;
        BanHang banhang = null;
        string hoVaTenNhanVien = "";
        #endregion
        #region Hệ thống
        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            dangNhap.txtTenDangNhap.Clear();
            dangNhap.txtMatKhau.Clear();
            ChuaDangNhap();
        }
        #endregion
        #region Quản Lí
        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutBox1 == null || aboutBox1.IsDisposed)
            {
                aboutBox1 = new AboutBox1();
                aboutBox1.MdiParent = this;
                aboutBox1.Show();
            }
            else
                aboutBox1.Activate();
        }
        private void hườngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (help == null || help.IsDisposed)
            {
                help = new Helpa();
                help.MdiParent = this;
                help.Show();
            }
            else
                help.Activate();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            mnuDangNhap_Click(sender, e);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            mnuDangXuat_Click(sender, e);
        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if (DanhMuc == null || DanhMuc.IsDisposed)
            {
                DanhMuc = new DanhMuc();
                DanhMuc.MdiParent = this;
                DanhMuc.Show();
            }
            else
                DanhMuc.Activate();
        }
        private void btnDoanhThu_Click(object sender, EventArgs e)
        {

        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            if (SanPham == null || SanPham.IsDisposed)
            {
                SanPham = new SanPham();
                SanPham.MdiParent = this;
                SanPham.Show();
            }
            else
                SanPham.Activate();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            if (HoaDon == null || HoaDon.IsDisposed)
            {
                HoaDon = new HoaDon();
                HoaDon.MdiParent = this;
                HoaDon.Show();
            }
            else
                HoaDon.Activate();
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            if (ChiTietHoaDon == null || ChiTietHoaDon.IsDisposed)
            {
                ChiTietHoaDon = new frmHoaDon_ChiTiet();
                ChiTietHoaDon.MdiParent = this;
                ChiTietHoaDon.Show();
            }
            else
                ChiTietHoaDon.Activate();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (KhachHang == null || KhachHang.IsDisposed)
            {
                KhachHang = new KhachHang();
                KhachHang.MdiParent = this;
                KhachHang.Show();
            }
            else
                KhachHang.Activate();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new NhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có muốn Thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                Application.Exit();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            btnThoat_Click(sender, e);
        }

        private void mnuDanhMuc_Click(object sender, EventArgs e)
        {
            btnDanhMuc_Click(sender, e);
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            btnSanPham_Click(sender, e);
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            btnKhachHang_Click(sender, e);
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            btnTaiKhoan_Click(sender, e);
        }

        private void mnuMuaHang_Click(object sender, EventArgs e)
        {
            btnMuaHang_Click(sender, e);
        }

        private void mnuDonHang_Click(object sender, EventArgs e)
        {
            btnDonHang_Click(sender, e);
        }
        private void mnuDoanhThu_Click(object sender, EventArgs e)
        {
            btnDoanhThu_Click(sender, e);
        }
        #endregion

        #region form đăng nhập
        public void ChuaDangNhap()
        {
            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;
            btnDonHang.Enabled = false;
            btnDanhMuc.Enabled = false;
            btnSanPham.Enabled = false;
            btnDoanhThu.Enabled = false;
            btnKhachHang.Enabled = false;
            btnTaiKhoan.Enabled = false;
            btnMuaHang.Enabled = false;
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = false;
            mnuDanhMuc.Enabled = false;
            mnuDonHang.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuMuaHang.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuTaiKhoan.Enabled = false;
        }
        public void QuanTriVien()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnDonHang.Enabled = true;
            btnDanhMuc.Enabled = true;
            btnKhachHang.Enabled = true;
            btnSanPham.Enabled = true;
            btnDoanhThu.Enabled = true;
            btnTaiKhoan.Enabled = true;
            btnMuaHang.Enabled = true;
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDanhMuc.Enabled = true;
            mnuDonHang.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuMuaHang.Enabled = true;
            mnuSanPham.Enabled = true;
            mnuTaiKhoan.Enabled = true;
        }
        public void NhanVien()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnDonHang.Enabled = true;
            btnDanhMuc.Enabled = true;
            btnKhachHang.Enabled = true;
            btnTaiKhoan.Enabled = false;
            btnSanPham.Enabled = true;
            btnDoanhThu.Enabled = true;
            btnMuaHang.Enabled = true;
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDanhMuc.Enabled = true;
            mnuDonHang.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuMuaHang.Enabled = true;
            mnuSanPham.Enabled = true;
            mnuTaiKhoan.Enabled = false;
        }
        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new DangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;

                if (dangNhap.txtTenDangNhap.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (dangNhap.txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();
                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (BC.Verify(matKhau, nhanVien.MatKhau))
                        {
                            hoVaTenNhanVien = nhanVien.HoVaTen;
                            if (nhanVien.QuyenHan == true)
                                QuanTriVien();
                            else if (nhanVien.QuyenHan == false)
                                NhanVien();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
            if (banhang == null || banhang.IsDisposed)
            {
                banhang = new BanHang();
                banhang.MdiParent = this;
                banhang.Show();
            }
            else
                banhang.Activate();
        }
        #endregion
        #region form load
        private void Main_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();


        }




        #endregion


        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
