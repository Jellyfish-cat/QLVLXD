using Microsoft.Data.SqlClient;
using QLBH;
using QuanLiBanhang.Froms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Data;
using WinFormsApp1.Reports;
using BC = BCrypt.Net.BCrypt;
namespace WinFormsApp1
{
    public partial class Main2 : Form
    {
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
        HangSanXuat hangSanXuat = null;
        NhaCungCap nhaCungCap = null;
        ThongKeDoanhThu thongKeDoanhThu = null;
        ThongKeSanPham thongKeSanPham = null;
        BieuDoDoanhThu bieuDoDoanhThu = null;
        BieuDoSanPham bieuDoSanPham = null;
        PhieuNhap PhieuNhap = null;
        ChiTietPhieuNhap chiTietPhieuNhap = null;
        private readonly DatabaseBackupRestoreService _backupRestoreService;
        #endregion

        public Main2()
        {
            InitializeComponent();
            Flash flash = new Flash();
            flash.ShowDialog();
            _backupRestoreService = new DatabaseBackupRestoreService("Server=ASUS-TUF-F15\\THANHDUC;Database=QLVLXD;MultipleActiveResultSets=True;TrustServerCertificate=True;Trusted_Connection=True");
        }

        public void ChuaDangNhap()
        {
            btnTrangChu.Enabled = false;
            btnHoaDon.Enabled = false;
            btnDanhMuc.Enabled = false;
            btnSanPham.Enabled = false;
            btnHangSanXuat.Enabled = false;
            btnKhachHang.Enabled = false;
            btnNhanVien.Enabled = false;
            btnNhaCungCap.Enabled = false;
            btnHoaDonChiTiet.Enabled = false;
            btnPhieuNhap.Enabled = false;
            btnPhieuNhapChiTiet.Enabled = false;
            btnThongKeDoanhThu.Enabled = false;
            btnThongKeSanPham.Enabled = false;
            btnBieuDoDanhThu.Enabled = false;
            btnBieuDoSanPham.Enabled = false;
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = false;
            mnuHeThong.Enabled = true;
            mnuQuanLy.Enabled = false;
            mnuHoatDong.Enabled = false;
            mnuThongKe.Enabled = false;
            mnuBaoCao.Enabled = false;
            mnuTroGiup.Enabled = true;
            mnuSLKP.Enabled = false;
            mnuCapNhat.Enabled = false;
        }
        public void QuanTriVien()
        {
            btnTrangChu.Enabled = true;
            btnSanPham.Enabled = true;
            btnHangSanXuat.Enabled = true;
            btnHoaDon.Enabled = true;
            btnDanhMuc.Enabled = true;
            btnKhachHang.Enabled = true;
            btnNhanVien.Enabled = true;
            btnNhaCungCap.Enabled = true;
            btnHoaDonChiTiet.Enabled = true;
            btnPhieuNhap.Enabled = true;
            btnPhieuNhapChiTiet.Enabled = true;
            btnThongKeDoanhThu.Enabled = true;
            btnThongKeSanPham.Enabled = true;
            btnBieuDoDanhThu.Enabled = true;
            btnBieuDoSanPham.Enabled = true;
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = true;
            mnuHeThong.Enabled = true;
            mnuQuanLy.Enabled = true;
            mnuHoatDong.Enabled = true;
            mnuThongKe.Enabled = true;
            mnuBaoCao.Enabled = true;
            mnuTroGiup.Enabled = true;
            mnuSLKP.Enabled = true;
            mnuCapNhat.Enabled = true;
        }
        public void NhanVien()
        {
            btnSanPham.Enabled = false;
            btnHangSanXuat.Enabled = false;
            btnTrangChu.Enabled = true;
            btnHoaDon.Enabled = true;
            btnDanhMuc.Enabled = false;
            btnKhachHang.Enabled = true;
            btnNhanVien.Enabled = false;
            btnNhaCungCap.Enabled = false;
            btnHoaDonChiTiet.Enabled = true;
            btnPhieuNhap.Enabled = false;
            btnPhieuNhapChiTiet.Enabled = false;
            btnThongKeDoanhThu.Enabled = true;
            btnThongKeSanPham.Enabled = true;
            btnBieuDoDanhThu.Enabled = true;
            btnBieuDoSanPham.Enabled = true;
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuTaiKhoan.Enabled = false;
            mnuNhaCungCap.Enabled = false;
            mnuHangSanXuat.Enabled = false;
            mnmuPhieuNhap.Enabled = false;
            mnuPhieuNhapChiTiet.Enabled = false;
            mnuThongKe.Enabled = true;
            mnuBaoCao.Enabled = true;
            mnuTroGiup.Enabled = true;
            mnuSLKP.Enabled = false;
            mnuCapNhat.Enabled = false;
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
                            {
                                QuanTriVien();
                                if (banhang == null || banhang.IsDisposed)
                                {
                                    banhang = new BanHang();
                                    banhang.MdiParent = this;
                                    banhang.Show();
                                }
                                else
                                    banhang.Activate();
                            }
                            else if (nhanVien.QuyenHan == false)
                            {

                                NhanVien();
                                if (banhang == null || banhang.IsDisposed)
                                {
                                    banhang = new BanHang();
                                    banhang.MdiParent = this;
                                    banhang.Show();
                                }
                                else
                                    banhang.Activate();
                            }
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

        }
        private void button1_Click(object sender, EventArgs e)
        {
            mnuDanhMuc_Click(sender, e);
        }
        private async void Main2_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
            mnuCapNhat_Click(sender, e);
        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (thongKeSanPham == null || thongKeSanPham.IsDisposed)
            {
                thongKeSanPham = new ThongKeSanPham();
                thongKeSanPham.MdiParent = this;
                thongKeSanPham.Show();
            }
            else
                thongKeSanPham.Activate();
        }

        private void doanhThuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (thongKeDoanhThu == null || thongKeDoanhThu.IsDisposed)
            {
                thongKeDoanhThu = new ThongKeDoanhThu();
                thongKeDoanhThu.MdiParent = this;
                thongKeDoanhThu.Show();
            }
            else
                thongKeDoanhThu.Activate();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
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

        private void mnuThongTin_Click(object sender, EventArgs e)
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

        private void mnuHuongDan_Click(object sender, EventArgs e)
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

        private void mnuDanhMuc_Click(object sender, EventArgs e)
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

        private void mnuSanPham_Click(object sender, EventArgs e)
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

        private void mnuDonHang_Click(object sender, EventArgs e)
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

        private void mnuMuaHang_Click(object sender, EventArgs e)
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

        private void mnuKhachHang_Click(object sender, EventArgs e)
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

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có muốn Thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                Application.Exit();
        }

        private void mnuHangSanXuat_Click(object sender, EventArgs e)
        {
            if (hangSanXuat == null || hangSanXuat.IsDisposed)
            {
                hangSanXuat = new HangSanXuat();
                hangSanXuat.MdiParent = this;
                hangSanXuat.Show();
            }
            else
                hangSanXuat.Activate();
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            if (nhaCungCap == null || nhaCungCap.IsDisposed)
            {
                nhaCungCap = new NhaCungCap();
                nhaCungCap.MdiParent = this;
                nhaCungCap.Show();
            }
            else
                nhaCungCap.Activate();
        }

        private void mnmuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (PhieuNhap == null || PhieuNhap.IsDisposed)
            {
                PhieuNhap = new PhieuNhap();
                PhieuNhap.MdiParent = this;
                PhieuNhap.Show();
            }
            else
                PhieuNhap.Activate();
        }

        private void mnuPhieuNhapChiTiet_Click(object sender, EventArgs e)
        {
            if (chiTietPhieuNhap == null || chiTietPhieuNhap.IsDisposed)
            {
                chiTietPhieuNhap = new ChiTietPhieuNhap();
                chiTietPhieuNhap.MdiParent = this;
                chiTietPhieuNhap.Show();
            }
            else
                chiTietPhieuNhap.Activate();
        }

        private void mnuBDSP_Click(object sender, EventArgs e)
        {
            if (bieuDoSanPham == null || bieuDoSanPham.IsDisposed)
            {
                bieuDoSanPham = new BieuDoSanPham();
                bieuDoSanPham.MdiParent = this;
                bieuDoSanPham.Show();
            }
            else
                bieuDoSanPham.Activate();
        }

        private void mnuBDDT_Click(object sender, EventArgs e)
        {
            if (bieuDoDoanhThu == null || bieuDoDoanhThu.IsDisposed)
            {
                bieuDoDoanhThu = new BieuDoDoanhThu();
                bieuDoDoanhThu.MdiParent = this;
                bieuDoDoanhThu.Show();
            }
            else
                bieuDoDoanhThu.Activate();
        }

        private void btnHangSanXuat_Click(object sender, EventArgs e)
        {
            mnuHangSanXuat_Click(sender, e);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            mnuSanPham_Click(sender, e);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            mnuDonHang_Click(sender, e);
        }

        private void HoaDonChiTiet_Click(object sender, EventArgs e)
        {
            mnuMuaHang_Click(sender, e);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            mnuNhaCungCap_Click(sender, e);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            mnuKhachHang_Click(sender, e);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            mnuTaiKhoan_Click(sender, e);
        }

        private void btnPhieuLap_Click(object sender, EventArgs e)
        {
            mnmuPhieuNhap_Click(sender, e);
        }

        private void PhieuNhapChiTiet_Click(object sender, EventArgs e)
        {
            mnuPhieuNhapChiTiet_Click(sender, e);
        }

        private void btnTKSP_Click(object sender, EventArgs e)
        {
            sảnPhẩmToolStripMenuItem1_Click(sender, e);
        }

        private void btnTKDT_Click(object sender, EventArgs e)
        {
            doanhThuToolStripMenuItem1_Click(sender, e);
        }

        private void BieuDoSP_Click(object sender, EventArgs e)
        {
            mnuBDSP_Click(sender, e);
        }

        private void btnBDDT_Click(object sender, EventArgs e)
        {
            mnuBDDT_Click(sender, e);
        }

        private void btnTranChu_Click(object sender, EventArgs e)
        {
            if (banhang == null || banhang.IsDisposed)
            {
                banhang = new BanHang();
                banhang.MdiParent = this;
                banhang.Show();
            }
            else
                banhang.Activate();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            mnuThoat_Click(sender, e);
        }

        private void mnuSaoLuu_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Chọn thư mục sao lưu";
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupFilePath = Path.Combine(folderDialog.SelectedPath, "QLVLXD.bak");
                    // Tiến hành sao lưu vào backupFilePath
                    _backupRestoreService.BackupDatabase(backupFilePath);
                    MessageBox.Show("Sao Lưu Thành Công!");
                }
            }

        }
        private void mnuKhoiPhuc_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Chọn thư mục phục hồi";
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupFilePath = Path.Combine(folderDialog.SelectedPath, "QLVLXD.bak");
                    try
                    {
                        _backupRestoreService.RestoreDatabase(backupFilePath);
                        MessageBox.Show("Phục hồi hoàn tất!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi phục hồi: " + ex.Message);
                    }
                }
            }
        }
        private async void mnuCapNhat_Click(object sender, EventArgs e)
        {
            var updateService = new UpdateService();
            var latestVersion = await updateService.GetLatestVersionFromGitHub();
            var rawVersion = Application.ProductVersion;
            var match = Regex.Match(rawVersion, @"\d+\.\d+\.\d+");
            var currentVersion = match.Success ? match.Value : "0.0.0";
            // Loại bỏ tiền tố 'v' nếu có trong phiên bản GitHub
            latestVersion = latestVersion?.TrimStart('v');

            // Nếu có bản cập nhật mới
            if (latestVersion != null && latestVersion != currentVersion)
            {
                mnuCapNhat.ForeColor = Color.Red;

                DialogResult kq = MessageBox.Show(
                    "Bạn Có Muốn Cập Nhật Ngay Bây Giờ?",
                    "Cập Nhật",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (kq == DialogResult.Yes)
                {
                    // Tạo form tiến trình cập nhật
                    Form progressForm = new Form
                    {
                        Text = "Đang cập nhật...",
                        Width = 400,
                        Height = 120,
                        FormBorderStyle = FormBorderStyle.FixedDialog,
                        StartPosition = FormStartPosition.CenterScreen,
                        ControlBox = false
                    };

                    var statusLabel = new Label
                    {
                        Dock = DockStyle.Top,
                        Height = 40,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Text = "Đang chuẩn bị..."
                    };

                    var progressBar = new ProgressBar
                    {
                        Style = ProgressBarStyle.Marquee,
                        Dock = DockStyle.Bottom,
                        Height = 10
                    };

                    progressForm.Controls.Add(statusLabel);
                    progressForm.Controls.Add(progressBar);
                    progressForm.Show();

                    await Task.Run(async () =>
                    {
                        try
                        {
                            // Đóng ứng dụng cũ
                            progressForm.Invoke(() => statusLabel.Text = "Đang đóng ứng dụng...");
                            var running = Process.GetProcessesByName("WinFormsApp1");
                            foreach (var p in running)
                                if (p.Id != Process.GetCurrentProcess().Id) p.Kill();
                            await Task.Delay(500);

                            // Tải về
                            progressForm.Invoke(() => statusLabel.Text = "Đang tải bản cập nhật...");
                            string zipPath = "Update.zip";
                            using var client = new HttpClient();
                            var data = await client.GetByteArrayAsync("https://github.com/Jellyfish-cat/QLVLXD/releases/download/v1.0.2/WinFormsApp1.zip");
                            await File.WriteAllBytesAsync(zipPath, data);

                            // Giải nén
                            progressForm.Invoke(() => statusLabel.Text = "Đang giải nén bản cập nhật...");
                            string extractPath = Directory.GetCurrentDirectory();
                            ZipFile.ExtractToDirectory(zipPath, extractPath, true);
                            File.Delete(zipPath);

                            // Khởi động lại
                            progressForm.Invoke(() => statusLabel.Text = "Khởi động lại ứng dụng...");
                            await Task.Delay(1000);

                            progressForm.Invoke(() => progressForm.Close());

                            Process.Start("Updater.exe"); // Dùng Updater trung gian
                            Application.Exit();
                        }
                        catch (Exception ex)
                        {
                            progressForm.Invoke(() =>
                            {
                                progressForm.Close();
                                MessageBox.Show(
                                    $"Lỗi cập nhật: {ex.Message}",
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            });
                        }
                    });

                }
            }

        }
    }
}
