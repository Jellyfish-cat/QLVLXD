using ClosedXML.Excel;
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
    public partial class NhaCungCap : Form
    {
        QLBHDbcontext context = new QLBHDbcontext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa)
        public NhaCungCap()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtTenHang.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            txtDiaChi.Enabled = giaTri;
            txtSDT.Enabled = giaTri;
        }
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            BatTatChucNang(false);
            List<cNhaCungCap> lsp = new List<cNhaCungCap>();
            lsp = context.NhaCungCap.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;
            txtTenHang.DataBindings.Clear();
            txtTenHang.DataBindings.Add("Text", bindingSource, "TenNhaCungCap", false, DataSourceUpdateMode.Never);
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenHang.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtSDT.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                cNhaCungCap lsp = context.NhaCungCap.Find(id);
                if (lsp != null)
                {
                    context.NhaCungCap.Remove(lsp);
                }
                context.SaveChanges();
                NhaCungCap_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHang.Text))
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                MessageBox.Show("Vui lòng nhập địa chỉ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtSDT.Text))
                MessageBox.Show("Vui lòng nhập tên số điện thoại?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    cNhaCungCap lsp = new cNhaCungCap();
                    lsp.TenNhaCungCap = txtTenHang.Text;
                    lsp.DiaChi=txtDiaChi.Text;
                    lsp.DienThoai=txtSDT.Text;
                    context.NhaCungCap.Add(lsp);
                    context.SaveChanges();
                }
                else
                {
                    cNhaCungCap lsp = context.NhaCungCap.Find(id);
                    if (lsp != null)
                    {
                        lsp.TenNhaCungCap = txtTenHang.Text;
                        lsp.DiaChi = txtDiaChi.Text;
                        lsp.DienThoai = txtSDT.Text;
                        context.NhaCungCap.Update(lsp);
                        context.SaveChanges();
                    }
                }
                NhaCungCap_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            NhaCungCap_Load(sender, e);
            BatTatChucNang(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có muốn Thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "NhaCungCap_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss").Replace("/", "_") + ".xlsx"; if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[4] {
                            new DataColumn("ID", typeof(int)),
                            new DataColumn("TenNhaCungCap", typeof(string)),
                            new DataColumn("DienThoai", typeof(string)),
                            new DataColumn("DiaChi", typeof(string))
                            });
                    var NhaCungCap = context.NhaCungCap.ToList();
                    if (NhaCungCap != null)
                    {
                        foreach (var p in NhaCungCap)
                            table.Rows.Add(p.ID, p.TenNhaCungCap, p.DienThoai, p.DiaChi);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhaCungCap");
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

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                cNhaCungCap lsp = new cNhaCungCap();
                                lsp.TenNhaCungCap = r["TenNhaCungCap"].ToString();
                                lsp.DienThoai = r["DienThoai"].ToString();
                                lsp.DiaChi = r["DiaChi"].ToString();
                                context.NhaCungCap.Add(lsp);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NhaCungCap_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            string keyword = txtTimKiem.Text.Trim();
            List<cNhaCungCap> kh = new List<cNhaCungCap>();
            if (keyword.ToLower() == "" || keyword.ToLower().GetType() != typeof(string))
            {
                MessageBox.Show("Từ khóa không được bỏ trống và phải là tên Nhà Cung Cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                kh = context.NhaCungCap
                .Where(d => d.TenNhaCungCap.Contains(keyword))
                .ToList();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = kh;
                txtTenHang.DataBindings.Clear();
                txtTenHang.DataBindings.Add("Text", bindingSource, "TenNhaCungCap", false, DataSourceUpdateMode.Never);
                txtSDT.DataBindings.Clear();
                txtSDT.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
                dataGridView.DataSource = bindingSource;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            NhaCungCap_Load(sender, EventArgs.Empty);
        }
    }
}
