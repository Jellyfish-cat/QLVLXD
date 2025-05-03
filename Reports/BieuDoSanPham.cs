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
using Stimulsoft.Report.Design.Controls;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class BieuDoSanPham : Form
    {
        QLBHDbcontext context = new QLBHDbcontext();
        string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "BieuDo.mrt");
        private StiViewerControl stiViewerControl;
        private Panel panel1;
        StiReport stiReport;
        StiViewerControl viewer;
        string tukhoa = "";
        public BieuDoSanPham()
        {
            InitializeComponent();
            stiViewerControl = new StiViewerControl();
            stiViewerControl.Dock = DockStyle.Fill;
            this.Controls.Add(stiViewerControl);
            this.Controls.Add(panel1);
        }

        private void BieuDo_Load(object sender, EventArgs e)
        {
            
            // Tạo báo cáo
            if (!File.Exists(reportPath))
            {
                MessageBox.Show("File báo cáo không tồn tại tại: " + reportPath);
                return;
            }

            StiReport report = new StiReport();
            report.Load(reportPath);
            report.Render();
            stiViewerControl.Report = report;
            stiViewerControl.Refresh();
        }
    }
}
