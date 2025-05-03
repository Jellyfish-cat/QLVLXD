using Stimulsoft.Report.Viewer;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Data;

namespace WinFormsApp1.Reports
{
    public partial class ThongKeDoanhThu : Form
    {
        QLBHDbcontext context = new QLBHDbcontext();
        string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "rptThongKeDoanhThu.mrt");

        private StiViewerControl stiViewerControl;
        private DateTimePicker dtpFromDate;
        private Panel panel1;
        private Label lblNgayDau;
        private DateTimePicker dtpToDate;
        private Label lblNgayCuoi;
        private Button btnLoc;
        private Button btnHuy;
        StiReport stiReport;
        StiViewerControl viewer;
        public ThongKeDoanhThu()
        {
            InitializeComponent();
            panel1 = new Panel();
            panel1.Height = 80;

            dtpFromDate = new DateTimePicker();
            dtpFromDate.Height = 30; // Đặt chiều cao cho DateTimePicker
            dtpFromDate.Width = 150; // Đặt chiều rộng cho DateTimePicker
            dtpFromDate.Value = new DateTime(2025, 4, 28); // Đặt giá trị mặc định
            dtpFromDate.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày tháng
            dtpFromDate.Format = DateTimePickerFormat.Custom; // Sử dụng định dạng tùy chỉnh
            dtpFromDate.Location = new Point(140, 25); // Vị trí của DateTimePicker trên form
            dtpFromDate.Anchor= AnchorStyles.Top;

            dtpToDate = new DateTimePicker();
            dtpToDate.Height = 30; // Đặt chiều cao cho DateTimePicker
            dtpToDate.Width = 150; // Đặt chiều rộng cho DateTimePicker
            dtpToDate.Value = new DateTime(2025, 4, 28); // Đặt giá trị mặc định
            dtpToDate.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày tháng
            dtpToDate.Format = DateTimePickerFormat.Custom; // Sử dụng định dạng tùy chỉnh
            dtpToDate.Location = new Point(400, 25); // Vị trí của DateTimePicker trên form
            dtpToDate.Anchor = AnchorStyles.Top;

            lblNgayDau = new Label();
            lblNgayDau.Text = "Từ Ngày : ";
            lblNgayDau.Location = new Point(60, 25);
            lblNgayDau.Anchor = AnchorStyles.Top;

            lblNgayCuoi = new Label();
            lblNgayCuoi.Text = "Đến Ngày : ";
            lblNgayCuoi.Location = new Point(320, 25);
            lblNgayCuoi.Anchor = AnchorStyles.Top;

            btnLoc = new Button();
            btnLoc.Text = "Lọc";
            btnLoc.Height = 50;
            btnLoc.Width = 80;
            btnLoc.Location = new Point(580, 15);
            btnLoc.Anchor = AnchorStyles.Top;

            btnHuy = new Button();
            btnHuy.Text = "Hủy";
            btnHuy.Height = 50;
            btnHuy.Width = 80;
            btnHuy.Location = new Point(680, 15);
            btnHuy .Anchor = AnchorStyles.Top;

            panel1.Dock = DockStyle.Top;
            stiViewerControl = new StiViewerControl();
            stiViewerControl.Dock = DockStyle.Fill;

            btnLoc.Click += (sender, e) =>
            {
                loc();
            };
            btnHuy.Click += (sender, e) => ThongKeDoanhThu_Load(sender, e);

            this.Controls.Add(stiViewerControl);
            panel1.Controls.Add(dtpFromDate);
            panel1.Controls.Add(dtpToDate);
            panel1.Controls.Add(lblNgayDau);
            panel1.Controls.Add(lblNgayCuoi);
            panel1.Controls.Add(btnLoc);
            panel1.Controls.Add(btnHuy);
            this.Controls.Add(panel1);


        }

        private void ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            var danhSachDoanhThu = context.DonHang.Select(r => new
            {
                ID = r.ID,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan),
            }).ToList();

            // Tạo báo cáo
            if (!File.Exists(reportPath))
            {
                MessageBox.Show("File báo cáo không tồn tại tại: " + reportPath);
                return;
            }

            StiReport report = new StiReport();
            report.Load(reportPath);
            report.RegBusinessObject("DanhSachDoanhThu", danhSachDoanhThu);
            report.Render();
            stiViewerControl.Report = report;
            stiViewerControl.Refresh();
        }
        private void loc()
        {
            if (dtpFromDate.Value > dtpToDate.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày cuối !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var danhSachDoanhThu = context.DonHang.Where(r => r.NgayLap < dtpToDate.Value && r.NgayLap > dtpFromDate.Value).Select(r => new
                {
                    ID = r.ID,
                    KhachHangID = r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    NhanVienID = r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    NgayLap = r.NgayLap,
                    GhiChuHoaDon = r.GhiChuHoaDon,
                    TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan),
                }).ToList();

                // Tạo báo cáo
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("File báo cáo không tồn tại tại: " + reportPath);
                    return;
                }

                StiReport report = new StiReport();
                report.Load(reportPath);
                report.RegBusinessObject("DanhSachDoanhThu", danhSachDoanhThu);
                report.Render();
                stiViewerControl.Report = report;
                stiViewerControl.Refresh();
            }
        }
    }
}
