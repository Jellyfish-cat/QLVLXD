using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormsApp1.Data;
using ClosedXML.Excel;

namespace QLBH
{
    public partial class DanhMuc : Form
    {
        QLBHDbcontext context = new QLBHDbcontext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int ID; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa)

        public DanhMuc()
        {
            InitializeComponent();

        }
        public void LayDuLieu()
        {

        }
        public void LayDuLieu(string tukhoa)
        {

        }

        private void BatTat(bool giaTri)
        {
            txtTenDanhMuc.Enabled = giaTri;
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
        }

        private void DanhMuc_Load(object sender, EventArgs e)
        {
            dgvDanhMuc.AutoGenerateColumns = false;
            BatTat(false);
            List<cDanhMuc> lsp = new List<cDanhMuc>();
            lsp = context.DanhMuc.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;
            txtTenDanhMuc.DataBindings.Clear();
            txtTenDanhMuc.DataBindings.Add("Text", bindingSource, "TenDanhMuc", false, DataSourceUpdateMode.Never);
            dgvDanhMuc.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTat(true);
            txtTenDanhMuc.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTat(true);
            ID = Convert.ToInt32(dgvDanhMuc.CurrentRow.Cells["id1"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDanhMuc.Text))
                MessageBox.Show("Vui lòng nhập tên danh mục?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    cDanhMuc lsp = new cDanhMuc();
                    lsp.TenDanhMuc = txtTenDanhMuc.Text;
                    context.DanhMuc.Add(lsp);
                    context.SaveChanges();
                }
                else
                {
                    cDanhMuc lsp = context.DanhMuc.Find(id1);
                    if (lsp != null)
                    {
                        lsp.TenDanhMuc = txtTenDanhMuc.Text;
                        context.DanhMuc.Update(lsp);
                        context.SaveChanges();
                    }
                }
                DanhMuc_Load(sender, e);
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ID = Convert.ToInt32(dgvDanhMuc.CurrentRow.Cells["id1"].Value.ToString());
                cDanhMuc lsp = context.DanhMuc.Find(ID);
                if (lsp != null)
                {
                    context.DanhMuc.Remove(lsp);
                }
                context.SaveChanges();
                DanhMuc_Load(sender, e);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có muốn Thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DanhMuc_Load(sender, e);
        }



        private void txtTenDanhMuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "DanhMuc_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss").Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[2] {
                            new DataColumn("ID", typeof(int)),
                            new DataColumn("TenDanhMuc", typeof(string))
                            });
                    var DanhMuc = context.DanhMuc.ToList();
                    if (DanhMuc != null)
                    {
                        foreach (var p in DanhMuc)
                            table.Rows.Add(p.id, p.TenDanhMuc);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "DanhMuc");
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
                                cDanhMuc lsp = new cDanhMuc();
                                lsp.TenDanhMuc = r["TenDanhMuc"].ToString();
                                context.DanhMuc.Add(lsp);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DanhMuc_Load(sender, e);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDanhMuc.AutoGenerateColumns = false;
            List<cDanhMuc> lsp = new List<cDanhMuc>();
            string keyword = txtTimKiem.Text.Trim();
            if (keyword.ToLower() == "" || keyword.ToLower().GetType() != typeof(string))
            {
                MessageBox.Show("Từ khóa không được bỏ trống và phải là tên sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lsp = context.DanhMuc
                .Where(d => d.TenDanhMuc.Contains(keyword))
                .ToList();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = lsp;
                txtTenDanhMuc.DataBindings.Clear();
                txtTenDanhMuc.DataBindings.Add("Text", bindingSource, "TenDanhMuc", false, DataSourceUpdateMode.Never);
                dgvDanhMuc.DataSource = bindingSource;
            }
        }

        private void btnLoad_click(object sender, EventArgs e)
        {
            DanhMuc_Load(sender, e);
        }
    }
}