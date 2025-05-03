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
    public partial class BieuDoDoanhThu : Form
    {
        QLBHDbcontext context = new QLBHDbcontext();

        string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "BieuDoDoanhThu1.mrt");
        private StiViewerControl stiViewerControl;
        private DateTimePicker dtpFromDate;
        private Panel panel1;
        private Label lblNgayDau;
        private DateTimePicker dtpToDate;
        private Label lblNgayCuoi;
        StiReport stiReport;
        StiViewerControl viewer;
        public BieuDoDoanhThu()
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

        private void BieuDoDoanhThu_Load(object sender, EventArgs e)
        {
            LoadReport();
        }
        private void LoadReport()
        {
            if (radngay.Checked)
                reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "BieuDoDoanhThu1.mrt");
            else if (radthang.Checked)
                reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "BieuDoDoanhThu2.mrt");
            else if (radNam.Checked)
                reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "BieuDoDoanhThu3.mrt");

            if (!File.Exists(reportPath))
            {
                MessageBox.Show("File báo cáo không tồn tại tại: " + reportPath);
                return;
            }

            var report = new StiReport();
            report.Load(reportPath);
            report.Render();
            stiViewerControl.Report = report;
            stiViewerControl.Refresh();
        }
        private void radngay_CheckedChanged(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void radthang_CheckedChanged(object sender, EventArgs e)
        {
            LoadReport();

        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            LoadReport();
        }
    }
}
