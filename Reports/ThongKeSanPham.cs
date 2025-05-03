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
using Stimulsoft.Report.Design.Controls;

namespace WinFormsApp1.Reports
{
    public partial class ThongKeSanPham : Form
    {
        QLBHDbcontext context = new QLBHDbcontext();
        string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "rptThongKeSanPham2.mrt");
        private StiViewerControl stiViewerControl;
        private Panel panel1;
        StiReport stiReport;
        StiViewerControl viewer;
        string tukhoa = "";
        public ThongKeSanPham()
        {
            InitializeComponent();
            panel1 = new Panel();
            panel1.Height = 80;
            panel1.Dock = DockStyle.Top;

            stiViewerControl = new StiViewerControl();
            stiViewerControl.Dock = DockStyle.Fill;
            this.Controls.Add(stiViewerControl);
            this.Controls.Add(panel1);
        }
        private void Layvaohangsanxuat()
        {
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
        }
        private void Layvaodanhmuc()
        {
            CboDanhMuc.ValueMember = "id";
            CboDanhMuc.DisplayMember = "TenDanhMuc";
            CboDanhMuc.DataSource = context.DanhMuc.ToList();
        }
        private void Layvaosanpham()
        {
            cboSanPham.ValueMember = "id";
            cboSanPham.DisplayMember = "TenSanPham";
            cboSanPham.DataSource = context.VatLieu.ToList();
        }
        private void ThongKeSanPham_Load(object sender, EventArgs e)
        {
            Layvaodanhmuc();
            Layvaohangsanxuat();
            Layvaosanpham();
            var danhSachSanPham = context.VatLieu.Select(r => new
            {
                r.id,
                r.HangSanXuatId,
                r.HangSanXuat.TenHangSanXuat,
                r.DanhMucId,
                r.DanhMuc.TenDanhMuc,
                r.TenSanPham,
                r.Gia,
                r.SoLuong,
                r.HinhAnh,
                r.MoTa
            }).ToList();

            // Tạo báo cáo
            if (!File.Exists(reportPath))
            {
                MessageBox.Show("File báo cáo không tồn tại tại: " + reportPath);
                return;
            }

            StiReport report = new StiReport();
            report.Load(reportPath);
            report.RegBusinessObject("DanhSachSanPham", danhSachSanPham);
            report.Render();
            stiViewerControl.Report = report;
            stiViewerControl.Refresh();
        }

        private void cboHangSanXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            tukhoa = "hsx";
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            tukhoa = "sp";
        }

        private void CboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            tukhoa = "dm";
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (tukhoa == "")
            {
                MessageBox.Show("vui lòng chọn mục để lọc!!", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tukhoa == "hsx")
            {
                var danhSachSanPham = context.VatLieu.Where(r => r.HangSanXuat.TenHangSanXuat == cboHangSanXuat.Text).Select(r => new
                {
                    r.id,
                    r.HangSanXuatId,
                    r.HangSanXuat.TenHangSanXuat,
                    r.DanhMucId,
                    r.DanhMuc.TenDanhMuc,
                    r.TenSanPham,
                    r.Gia,
                    r.SoLuong,
                    r.HinhAnh,
                    r.MoTa
                }).ToList();
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("File báo cáo không tồn tại tại: " + reportPath);
                    return;
                }

                StiReport report = new StiReport();
                report.Load(reportPath);
                report.RegBusinessObject("DanhSachSanPham", danhSachSanPham);
                report.Render();
                stiViewerControl.Report = report;
                stiViewerControl.Refresh();
            }
            else if (tukhoa == "sp")
            {
                var danhSachSanPham = context.VatLieu.Where(r => r.TenSanPham == cboSanPham.Text).Select(r => new
                {
                    r.id,
                    r.HangSanXuatId,
                    r.HangSanXuat.TenHangSanXuat,
                    r.DanhMucId,
                    r.DanhMuc.TenDanhMuc,
                    r.TenSanPham,
                    r.Gia,
                    r.SoLuong,
                    r.HinhAnh,
                    r.MoTa
                }).ToList();
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("File báo cáo không tồn tại tại: " + reportPath);
                    return;
                }

                StiReport report = new StiReport();
                report.Load(reportPath);
                report.RegBusinessObject("DanhSachSanPham", danhSachSanPham);
                report.Render();
                stiViewerControl.Report = report;
                stiViewerControl.Refresh();
            }
            else if (tukhoa == "dm")
            {
                var danhSachSanPham = context.VatLieu.Where(r => r.DanhMuc.TenDanhMuc == CboDanhMuc.Text).Select(r => new
                {
                    r.id,
                    r.HangSanXuatId,
                    r.HangSanXuat.TenHangSanXuat,
                    r.DanhMucId,
                    r.DanhMuc.TenDanhMuc,
                    r.TenSanPham,
                    r.Gia,
                    r.SoLuong,
                    r.HinhAnh,
                    r.MoTa
                }).ToList();
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("File báo cáo không tồn tại tại: " + reportPath);
                    return;
                }

                StiReport report = new StiReport();
                report.Load(reportPath);
                report.RegBusinessObject("DanhSachSanPham", danhSachSanPham);
                report.Render();
                stiViewerControl.Report = report;
                stiViewerControl.Refresh();
            }
            // Tạo báo cáo

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ThongKeSanPham_Load(sender, e);
        }
    }


}

