using ClosedXML.Excel;
using QuanLiBanhang.Froms;
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

namespace WinFormsApp1
{
    public partial class PhieuNhap : Form
    {
        QLBHDbcontext context = new QLBHDbcontext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        public PhieuNhap()
        {
            InitializeComponent();
        }

        private void RadKhachHang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (ChiTietPhieuNhap chiTiet = new ChiTietPhieuNhap())
            {
                chiTiet.ShowDialog();
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet" && e.RowIndex >= 0)
            {
                int phieunhapID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID1"].Value);
                ChiTietPhieuNhap ccphieunhap = new ChiTietPhieuNhap(phieunhapID);
                ccphieunhap.ShowDialog();
            }
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            List<DanhSachPhieuNhap> hd = new List<DanhSachPhieuNhap>();
            hd = context.PhieuNhap.Select(r => new DanhSachPhieuNhap
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                TenNhanVien = r.NhanVien.HoVaTen,
                HangSanXuatID = r.HangSanXuatID,
                TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                NhaCungCapID = r.NhaCungCapID,
                TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                NgayLap = r.NgayLap,
                GhiChuPhieuNhap = r.GhiChuPhieuNhap,
                XemChiTiet = "Xem chi tiết"
            }).ToList();
            dataGridView.DataSource = hd;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID1"].Value.ToString());
            using (ChiTietPhieuNhap chiTiet = new ChiTietPhieuNhap(id))
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
                cPhieuNhap hd = context.PhieuNhap.Find(id);
                if (hd != null)
                {
                    context.PhieuNhap.Remove(hd);
                }
                context.SaveChanges();
                PhieuNhap_Load(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            string keyword = txtTimKiem.Text.Trim();
            List<DanhSachPhieuNhap> hd = new List<DanhSachPhieuNhap>();
            if (keyword.ToLower() == "" || keyword.ToLower().GetType() != typeof(string))
            {
                MessageBox.Show("Từ khóa không được bỏ trống và phải là tên nhân viên hoặc khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radNhanVien.Checked == true)
                {
                    hd = context.PhieuNhap.Where(r => r.NhanVien.HoVaTen.Contains(keyword)).Select(r => new DanhSachPhieuNhap
                    {
                        ID = r.ID,
                        NhanVienID = r.NhanVienID,
                        TenNhanVien = r.NhanVien.HoVaTen,
                        NhaCungCapID = r.NhaCungCapID,
                        TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                        HangSanXuatID = r.HangSanXuatID,
                        TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                        NgayLap = r.NgayLap,
                        GhiChuPhieuNhap = r.GhiChuPhieuNhap,
                        XemChiTiet = "Xem chi tiết"
                    }).ToList();
                }
                if (radNhaCungCap.Checked == true)
                {
                    hd = context.PhieuNhap.Where(d => d.NhaCungCap.TenNhaCungCap.Contains(keyword)).Select(r => new DanhSachPhieuNhap
                    {
                        ID = r.ID,
                        NhanVienID = r.NhanVienID,
                        TenNhanVien = r.NhanVien.HoVaTen,
                        NhaCungCapID = r.NhaCungCapID,
                        TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                        HangSanXuatID = r.HangSanXuatID,
                        TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                        NgayLap = r.NgayLap,
                        GhiChuPhieuNhap = r.GhiChuPhieuNhap,
                        XemChiTiet = "Xem chi tiết"
                    }).ToList();

                    dataGridView.DataSource = hd;
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "DanhSachPhieuNhap_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss").Replace("/", "_") + ".xlsx"; if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[5] {
                            new DataColumn("ID", typeof(int)),
                            new DataColumn("TenNhanVien", typeof(string)),
                            new DataColumn("TenNhaCungCap", typeof(string)),
                            new DataColumn("GhiChuPhieuNhap", typeof(string)),
                            new DataColumn("NgayLap", typeof(string)),


                            });

                    foreach (DataGridViewRow p in dataGridView.Rows)
                    {
                        var id = p.Cells[0].Value;
                        var tenNhanVien = p.Cells[1].Value;
                        var tenNhaCungCap = p.Cells[2].Value;
                        var ghiChuPhieuNhap = p.Cells[3].Value;
                        var ngayLap = p.Cells[4].Value;
                        table.Rows.Add(id, tenNhanVien, tenNhaCungCap, ghiChuPhieuNhap, ngayLap);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "PhieuNhap");
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có muốn Thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            PhieuNhap_Load(sender, e);
        }
    }
}
