using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp1.Data;

namespace QuanLiBanhang.Froms
{
    public partial class HoaDon : Form
    {

        QLBHDbcontext context = new QLBHDbcontext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        public HoaDon()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet" && e.RowIndex >= 0)
            {
                int hoaDonId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID1"].Value);
                BanHang chitiethoadon = new BanHang(hoaDonId);
               
                chitiethoadon.ShowDialog();
            }
        }

        public void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.DonHang.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).ToList();
            dataGridView.DataSource = hd;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (BanHang chiTiet = new BanHang())
            {
                chiTiet.ShowDialog();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID1"].Value.ToString());
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa Hóa Đơn ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
            DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID1"].Value.ToString());
                cDonHang hd = context.DonHang.Find(id);
                if (hd != null)
                {
                    context.DonHang.Remove(hd);
                }
                context.SaveChanges();
                frmHoaDon_Load(sender, e);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            string keyword = txtTimKiem.Text.Trim();
            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            if (keyword.ToLower() == "" || keyword.ToLower().GetType() != typeof(string))
            {
                MessageBox.Show("Từ khóa không được bỏ trống và phải là tên nhân viên hoặc khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radNhanVien.Checked == true)
                {
                    hd = context.DonHang.Where(r => r.NhanVien.HoVaTen.Contains(keyword)).Select(r => new DanhSachHoaDon
                    {
                        ID = r.ID,
                        NhanVienID = r.NhanVienID,
                        HoVaTenNhanVien = r.NhanVien.HoVaTen,
                        KhachHangID = r.KhachHangID,
                        HoVaTenKhachHang = r.KhachHang.HoVaTen,
                        NgayLap = r.NgayLap,
                        GhiChuHoaDon = r.GhiChuHoaDon,
                        TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan),
                        XemChiTiet = "Xem chi tiết"
                    }).ToList();
                }
                if (RadKhachHang.Checked == true)
                {
                    hd = context.DonHang.Where(d => d.KhachHang.HoVaTen.Contains(keyword)).Select(r => new DanhSachHoaDon
                    {
                        ID = r.ID,
                        NhanVienID = r.NhanVienID,
                        HoVaTenNhanVien = r.NhanVien.HoVaTen,
                        KhachHangID = r.KhachHangID,
                        HoVaTenKhachHang = r.KhachHang.HoVaTen,
                        NgayLap = r.NgayLap,
                        GhiChuHoaDon = r.GhiChuHoaDon,
                        TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan),
                        XemChiTiet = "Xem chi tiết"
                    }).ToList();
                }

                dataGridView.DataSource = hd;
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "DanhSachHoaDon_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss").Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[5] {
                            new DataColumn("ID", typeof(int)),
                            new DataColumn("HoVaTenNhanVien", typeof(string)),
                            new DataColumn("HoVaTenKhachHang", typeof(string)),
                            new DataColumn("NgayLap", typeof(string)),
                            new DataColumn("TongTien", typeof(string)),

                            });

                    foreach (DataGridViewRow p in dataGridView.Rows)
                    {
                        var id = p.Cells[0].Value;
                        var tenNhanVien = p.Cells[1].Value;
                        var tenKhachHang = p.Cells[2].Value;
                        var tongTien = p.Cells[4].Value;
                        var ngayLap = p.Cells[3].Value;
                        table.Rows.Add(id, tenNhanVien, tenKhachHang, ngayLap, tongTien);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "ChiTiet_HoaDon");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            frmHoaDon_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có muốn Thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                this.Close();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
