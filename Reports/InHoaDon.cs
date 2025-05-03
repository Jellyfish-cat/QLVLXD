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
    public partial class InHoaDon : Form
    {
        QLBHDbcontext context = new QLBHDbcontext();
        string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "InHoaDon.mrt");
        int id;
        private StiViewerControl stiViewerControl;
        private DateTimePicker dtpFromDate;
        StiReport stiReport;
        StiViewerControl viewer;
        public InHoaDon(int ma)
        {
            InitializeComponent();
            stiViewerControl = new StiViewerControl();
            stiViewerControl.Dock = DockStyle.Fill;
            this.Controls.Add(stiViewerControl);
            id = ma;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            var danhSachHoaDon = context.HoaDon_ChiTiet.Where(r=>r.DonHangID==id).Select(r => new
            {
                r.ID,
                r.DonHangID,
                r.SanPhamID,
                r.SanPham.TenSanPham,
                r.SoLuongBan,
                r.DonGiaBan,
                ThanhTien=Convert.ToInt32(r.DonGiaBan*r.SoLuongBan)
            }).ToList();
            var khachHang = context.DonHang.Where(r => r.ID == id).Select(r => new
            {
                r.KhachHangID,
                r.KhachHang.HoVaTen,
                r.KhachHang.DiaChi,
                r.KhachHang.DienThoai
            }).ToList();
            // Tạo báo cáo
            if (!File.Exists(reportPath))
            {
                MessageBox.Show("File báo cáo không tồn tại tại: " + reportPath);
                return;
            }

            StiReport report = new StiReport();
            report.Load(reportPath);
            report.RegBusinessObject("DanhSachHoaDon", danhSachHoaDon);
            report.RegBusinessObject("KhachHang", khachHang);
            report.Render();
            stiViewerControl.Report = report;
            stiViewerControl.Refresh();
        }
    }
}
