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
    public partial class InPhieuNhap : Form
    {
        QLBHDbcontext context = new QLBHDbcontext();
        string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "InPhieuNhap.mrt");
        int id;
        private StiViewerControl stiViewerControl;
        private DateTimePicker dtpFromDate;
        StiReport stiReport;
        StiViewerControl viewer;
        public InPhieuNhap(int ma)
        {
            InitializeComponent();
            stiViewerControl = new StiViewerControl();
            stiViewerControl.Dock = DockStyle.Fill;
            this.Controls.Add(stiViewerControl);
            id = ma;
        }

        private void InPhieuNhap_Load(object sender, EventArgs e)
        {
            var danhSachPhieuNhap = context.ChiTietPhieuNhap.Where(r => r.PhieuNhapID == id).Select(r => new
            {
                r.ID,
                r.PhieuNhapID,
                r.SanPhamID,
                r.SanPham.TenSanPham,
                r.HangSanXuatID,
                r.HangSanXuat.TenHangSanXuat,
                r.SoLuongNhap
            }).ToList();
            var NhaCungCap = context.PhieuNhap.Where(r => r.ID == id).Select(r => new
            {
                r.NhaCungCapID,
                r.NhaCungCap.TenNhaCungCap,
                r.NhaCungCap.DiaChi,
                r.NhaCungCap.DienThoai
            }).ToList();
            // Tạo báo cáo
            if (!File.Exists(reportPath))
            {
                MessageBox.Show("File báo cáo không tồn tại tại: " + reportPath);
                return;
            }

            StiReport report = new StiReport();
            report.Load(reportPath);
            report.RegBusinessObject("DanhSachPhieuNhap", danhSachPhieuNhap);
            report.RegBusinessObject("NhaCungCap", NhaCungCap);
            report.Render();
            stiViewerControl.Report = report;
            stiViewerControl.Refresh();
        }
    }
}
