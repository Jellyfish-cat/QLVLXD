using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.AccessControl;
using System.Data;
using ClosedXML.Excel;
using WinFormsApp1.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations.Schema;
using DocumentFormat.OpenXml.Office2010.Excel;
using QLBH;
using WinFormsApp1.Data;
using QuanLiBanhang.Froms;
using WinFormsApp1;

namespace QLBH
{
    public partial class SanPham : Form
    {
        QLBHDbcontext context = new QLBHDbcontext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int ID; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa)
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");

        public SanPham()
        {
            InitializeComponent();

        }
        public void LayDuLieu()
        {


        }
        public void LayDuLieu(string tukhoa)
        {



        }
        private void BatTat(bool giatri)
        {

            numGia.Enabled = giatri;
            txtMoTa.Enabled = giatri;
            txtTenSanPham.Enabled = giatri;
            cboTenDanhMuc.Enabled = giatri;
            numSoLuong.Enabled = giatri;
            cboNhaCungCap.Enabled = giatri;
            btnHuy.Enabled = giatri;
            btnLuu.Enabled = giatri;

            btnThem.Enabled = !giatri;
            btnSua.Enabled = !giatri;
            btnThoat.Enabled = !giatri;
            btnXoa.Enabled = !giatri;
            cboHangSanXuat.Enabled = giatri;
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTat(true);
            cboHangSanXuat.Text = "";
            cboTenDanhMuc.Text = "";
            cboHangSanXuat.Text = "";
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            numSoLuong.Value = 0;
            numGia.Value = 0;
            picHinhAnh.Image = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
                MessageBox.Show("Vui lòng nhập tên sản phẩm?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboNhaCungCap.Text))
                MessageBox.Show("Vui lòng chọn Nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboHangSanXuat.Text))
                MessageBox.Show("Vui lòng chọn hãng sản xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboTenDanhMuc.Text))
                MessageBox.Show("Vui lòng chọn danh mục.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numGia.Value <= 0)
                MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (xuLyThem)
                {
                    cVatLieu sp = new cVatLieu();
                    sp.MoTa = txtMoTa.Text;
                    sp.Gia = Convert.ToInt32(numGia.Value);
                    sp.SoLuong = Convert.ToInt32(numSoLuong.Value);
                    sp.HinhAnh = picHinhAnh.ImageLocation;
                    sp.DanhMucId = Convert.ToInt32(cboTenDanhMuc.SelectedValue);
                    sp.HangSanXuatId = Convert.ToInt32(cboHangSanXuat.SelectedValue);
                    sp.NhaCungCapId = Convert.ToInt32(cboNhaCungCap.SelectedValue);
                    sp.TenSanPham = txtTenSanPham.Text;
                    context.VatLieu.Add(sp);
                    context.SaveChanges();

                }
                else
                {
                    cVatLieu lsp = context.VatLieu.Find(ID);
                    if (lsp != null)
                    {
                        lsp.TenSanPham = txtTenSanPham.Text;
                        lsp.Gia = Convert.ToInt32(numGia.Value);
                        lsp.SoLuong = Convert.ToInt32(numSoLuong.Value);
                        lsp.MoTa = txtMoTa.Text;
                        lsp.DanhMucId = Convert.ToInt32(cboTenDanhMuc.SelectedValue);
                        lsp.HangSanXuatId = Convert.ToInt32(cboHangSanXuat.SelectedValue);
                        lsp.NhaCungCapId = Convert.ToInt32(cboNhaCungCap.SelectedValue);
                        context.VatLieu.Update(lsp);
                        context.SaveChanges();
                    }
                }
                SanPham_Load(sender, e);
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTat(true);
            ID = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["id1"].Value.ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SanPham_Load(sender, e);
            txtTenSanPham.Focus();
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
            saveFileDialog.FileName = "SanPham_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss").Replace("/", "_") + ".xlsx"; if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[12] {
                            new DataColumn("id", typeof(int)),
                            new DataColumn("TenSanPham", typeof(string)),
                            new DataColumn("TenDanhMuc", typeof(string)),
                            new DataColumn("TenHangSanXuat", typeof(string)),
                            new DataColumn("TenNhaCungCap", typeof(string)),
                            new DataColumn("MoTa", typeof(string)),
                            new DataColumn("Gia", typeof(int)),
                            new DataColumn("SoLuong", typeof(int)),
                            new DataColumn("HinhAnh", typeof(string)),
                            new DataColumn("DanhMucId", typeof(int)),
                            new DataColumn("HangSanXuatId", typeof(int)),
                            new DataColumn("NhaCungCapId", typeof(int))
                            });
                    var VatLieu = context.VatLieu.ToList();
                    if (VatLieu != null)
                    {
                        foreach (var p in VatLieu)
                        {
                            table.Rows.Add(p.id, p.TenSanPham, p.DanhMuc.TenDanhMuc, p.HangSanXuat.TenHangSanXuat, p.NhaCungCap.TenNhaCungCap, p.MoTa, p.Gia, p.SoLuong, p.HinhAnh
                                ,p.DanhMucId,p.HangSanXuatId,p.NhaCungCapId);
                        }
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "SanPham");
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
        public void LayLoaiSanPhamVaoComboBox()
        {
            cboTenDanhMuc.ValueMember = "id";
            cboTenDanhMuc.DisplayMember = "TenDanhMuc";
            cboTenDanhMuc.DataSource = context.DanhMuc.ToList();

        }
        public void LayHangSanXuatVaoComboBox()
        {
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();

        }
        public void LayNhaCungCapVaoComboBox()
        {
            cboNhaCungCap.ValueMember = "ID";
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.DataSource = context.NhaCungCap.ToList();

        }
        public void SanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.AutoGenerateColumns = false;
            BatTat(false);
            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();
            LayNhaCungCapVaoComboBox();
            dgvSanPham.AutoGenerateColumns = false;
            List<DanhSachSanPham> sp = new List<DanhSachSanPham>();
            sp = context.VatLieu.Select(r => new DanhSachSanPham
            {
                id1 = r.id,
                DanhMucId = r.DanhMucId,
                TenDanhMuc = r.DanhMuc.TenDanhMuc,
                HangSanXuatId = r.HangSanXuatId,
                TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                NhaCungCapId = r.NhaCungCapId,
                TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                TenSanPham = r.TenSanPham,
                SoLuong = r.SoLuong,
                Gia = r.Gia,
                HinhAnh = r.HinhAnh
            }).ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;
            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);
            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("Text", bindingSource, "TenHangSanXuat", false, DataSourceUpdateMode.Never);
            cboNhaCungCap.DataBindings.Clear();
            cboNhaCungCap.DataBindings.Add("Text", bindingSource, "TenNhaCungCap", false, DataSourceUpdateMode.Never);
            numGia.DataBindings.Clear();
            numGia.DataBindings.Add("Value", bindingSource, "Gia", false, DataSourceUpdateMode.Never);
            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);
            cboTenDanhMuc.DataBindings.Clear();
            cboTenDanhMuc.DataBindings.Add("Text", bindingSource, "TenDanhMuc", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                // Kiểm tra xem e.Value có phải là null không
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    e.Value = Path.Combine(imagesFolder, e.Value.ToString());
                }
                else
                {
                    // Nếu e.Value là null, có thể gán giá trị mặc định hoặc bỏ qua
                    e.Value = "gach-men.jpg";  // Gán giá trị mặc định nếu không có hình ảnh
                }
            };
            picHinhAnh.DataBindings.Add(hinhAnh);
            dgvSanPham.DataSource = bindingSource;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSanPham.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    Image image = Image.FromFile(Path.Combine(imagesFolder, e.Value.ToString()));
                    image = new Bitmap(image, 24, 24);
                    e.Value = image;
                }
                else
                {
                    // Nếu e.Value là null, có thể gán giá trị mặc định hoặc bỏ qua
                    e.Value = "";  // Gán giá trị mặc định nếu không có hình ảnh
                }

            }

        }

        private int GetID()
        {
            return ID;
        }

        private void btnDoiHinhAnh_Click(object sender, EventArgs e, int iD)
        {

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
                                cVatLieu lsp = new cVatLieu();
                                lsp.TenSanPham = r["TenSanPham"].ToString();
                                lsp.DanhMucId = Convert.ToInt32(r["DanhMucId"]);
                                lsp.HangSanXuatId = Convert.ToInt32(r["HangSanXuatId"]);
                                lsp.NhaCungCapId = Convert.ToInt32(r["NhaCungCapId"]);
                                lsp.Gia = Convert.ToInt32(r["Gia"]);
                                lsp.SoLuong = Convert.ToInt32(r["SoLuong"]);
                                lsp.MoTa = r["MoTa"].ToString();
                                lsp.HinhAnh = r["HinhAnh"].ToString();
                                context.VatLieu.Add(lsp);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SanPham_Load(sender, e);
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

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ID = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["id1"].Value.ToString());
                cVatLieu lsp = context.VatLieu.Find(ID);
                if (lsp != null)
                {
                    context.VatLieu.Remove(lsp);
                }
                context.SaveChanges();
                SanPham_Load(sender, e);
            }
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            if (picHinhAnh.Image != null)
            {
                picHinhAnh.Image.Dispose(); // Giải phóng tài nguyên
                picHinhAnh.Image = null;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string fileSavePath = Path.Combine(imagesFolder, fileName.GenerateSlug() + ext);
                if (picHinhAnh.Image != null)
                {
                    picHinhAnh.Image.Dispose(); // Giải phóng file ảnh đang bị giữ
                    picHinhAnh.Image = null;
                }
                File.Copy(openFileDialog.FileName, fileSavePath, true);
                ID = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["id1"].Value.ToString());
                cVatLieu sp = context.VatLieu.Find(ID);
                sp.HinhAnh = fileName.GenerateSlug() + ext;
                context.VatLieu.Update(sp);
                context.SaveChanges();
                SanPham_Load(sender, e);
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvSanPham.AutoGenerateColumns = false;
            string keyword = txtTimKiem.Text.Trim();
            List<DanhSachSanPham> vl = new List<DanhSachSanPham>();

            if (keyword.ToLower() == "" || keyword.ToLower().GetType() != typeof(string))
            {
                MessageBox.Show("Từ khóa không được bỏ trống và phải là tên sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radVatLieu.Checked == true)
                {
                    vl = context.VatLieu
                        .Where(d => d.TenSanPham.Contains(keyword)).Select(r => new DanhSachSanPham
                        {
                            id1 = r.id,
                            DanhMucId = r.DanhMucId,
                            TenDanhMuc = r.DanhMuc.TenDanhMuc,
                            HangSanXuatId = r.HangSanXuatId,
                            TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                            TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                            TenSanPham = r.TenSanPham,
                            SoLuong = r.SoLuong,
                            Gia = r.Gia,
                            HinhAnh = r.HinhAnh
                        }).ToList();

                }
                else if (radDanhMuc.Checked == true)
                {
                    vl = context.VatLieu
                        .Where(d => d.DanhMuc.TenDanhMuc.Contains(keyword)).Select(r => new DanhSachSanPham
                        {
                            id1 = r.id,
                            DanhMucId = r.DanhMucId,
                            TenDanhMuc = r.DanhMuc.TenDanhMuc,
                            HangSanXuatId = r.HangSanXuatId,
                            TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                            TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                            TenSanPham = r.TenSanPham,
                            SoLuong = r.SoLuong,
                            Gia = r.Gia,
                            HinhAnh = r.HinhAnh
                        }).ToList();


                }
                else if (radNhaCungCap.Checked == true)
                {
                    vl = context.VatLieu
                        .Where(d => d.NhaCungCap.TenNhaCungCap.Contains(keyword)).Select(r => new DanhSachSanPham
                        {
                            id1 = r.id,
                            DanhMucId = r.DanhMucId,
                            TenDanhMuc = r.DanhMuc.TenDanhMuc,
                            HangSanXuatId = r.HangSanXuatId,
                            TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                            TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                            TenSanPham = r.TenSanPham,
                            SoLuong = r.SoLuong,
                            Gia = r.Gia,
                            HinhAnh = r.HinhAnh
                        }).ToList();

                }
                else if (radHangSanXuat.Checked == true)
                {
                    vl = context.VatLieu
                        .Where(d => d.HangSanXuat.TenHangSanXuat.Contains(keyword)).Select(r => new DanhSachSanPham
                        {
                            id1 = r.id,
                            DanhMucId = r.DanhMucId,
                            TenDanhMuc = r.DanhMuc.TenDanhMuc,
                            HangSanXuatId = r.HangSanXuatId,
                            TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                            TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                            TenSanPham = r.TenSanPham,
                            SoLuong = r.SoLuong,
                            Gia = r.Gia,
                            HinhAnh = r.HinhAnh
                        }).ToList();

                }
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = vl;
                txtTenSanPham.DataBindings.Clear();
                txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);
                txtMoTa.DataBindings.Clear();
                txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);
                cboHangSanXuat.DataBindings.Clear();
                cboHangSanXuat.DataBindings.Add("Text", bindingSource, "HangSanXuatId", false, DataSourceUpdateMode.Never);
                numGia.DataBindings.Clear();
                numGia.DataBindings.Add("Value", bindingSource, "Gia", false, DataSourceUpdateMode.Never);
                numSoLuong.DataBindings.Clear();
                numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);
                cboTenDanhMuc.DataBindings.Clear();
                cboTenDanhMuc.DataBindings.Add("Text", bindingSource, "DanhMucId", false, DataSourceUpdateMode.Never);
                cboNhaCungCap.DataBindings.Clear();
                cboNhaCungCap.DataBindings.Add("Text", bindingSource, "NhaCungCapId", false, DataSourceUpdateMode.Never);

                picHinhAnh.DataBindings.Clear();
                Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
                hinhAnh.Format += (s, e) =>
                {
                    // Kiểm tra xem e.Value có phải là null không
                    if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.Value = Path.Combine(imagesFolder, e.Value.ToString());
                    }
                    else
                    {
                        // Nếu e.Value là null, có thể gán giá trị mặc định hoặc bỏ qua
                        e.Value = "gach-men.jpg";  // Gán giá trị mặc định nếu không có hình ảnh
                    }
                };
                picHinhAnh.DataBindings.Add(hinhAnh);
                dgvSanPham.DataSource = bindingSource;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SanPham_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnthemdanhmuc_Click(object sender, EventArgs e)
        {
            using (DanhMuc sp = new DanhMuc())
            {
                sp.ShowDialog();
            }
        }

        private void btnthemhang_Click(object sender, EventArgs e)
        {
            using (HangSanXuat sp = new HangSanXuat())
            {
                sp.ShowDialog();
            }
        }
        private void btnthemnha_Click(object sender, EventArgs e)
        {
            using (NhaCungCap sp = new NhaCungCap())
            {
                sp.ShowDialog();
            }
        }
    }

}
