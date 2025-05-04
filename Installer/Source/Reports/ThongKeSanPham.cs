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
        string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "rptThongKeSanPham1.mrt");

        private StiViewerControl stiViewerControl;
        StiReport stiReport;
        StiViewerControl viewer;
        public ThongKeSanPham()
        {
            InitializeComponent();
            stiViewerControl = new StiViewerControl();
            stiViewerControl.Dock = DockStyle.Fill;
            this.Controls.Add(stiViewerControl);
        }
        
        private void ThongKeSanPham_Load(object sender, EventArgs e)
        {

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
           if (stiViewerControl.Report == null)
            {
                MessageBox.Show("Không có báo cáo nào được tải.");
            }
        StiReport report = new StiReport();
        report.Load(reportPath);
        report.RegBusinessObject("DanhSachSanPham", danhSachSanPham);
        report.Render();
        stiViewerControl.Report = report;
        stiViewerControl.Refresh();
        }
    }
    
 
    }

