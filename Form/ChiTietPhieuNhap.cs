using DocumentFormat.OpenXml.Office2010.Excel;
using QLBH;
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
using WinFormsApp1.Reports;

namespace WinFormsApp1
{
    public partial class ChiTietPhieuNhap : Form
    {
        QLBHDbcontext context = new QLBHDbcontext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        BindingList<DanhSachPhieuNhap_ChiTiet> phieuNhap_ChiTiet = new BindingList<DanhSachPhieuNhap_ChiTiet>();
        public ChiTietPhieuNhap()
        {
            InitializeComponent();
        }
        public ChiTietPhieuNhap(int maPhieuNhap = 0)
        {
            InitializeComponent();
            id = maPhieuNhap;
        }
        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }
        public void LayNhaCungCapVaoComboBox()
        {
            cboNhaCungCap.DataSource = context.NhaCungCap.ToList();
            cboNhaCungCap.ValueMember = "ID";
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
        }
        public void LaySanPhamVaoComboBox()
        {
            cboSanPham.DataSource = context.VatLieu.ToList();
            cboSanPham.ValueMember = "ID";
            cboSanPham.DisplayMember = "TenSanPham";
        }
        public void LayHangSanXuatVaoComboBox()
        {
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
        }
        public void BatTatChucNang()
        {
            if (id == 0 && dataGridView.Rows.Count == 0) // Thêm
            {
                // Xóa trắng các trường
                cboNhaCungCap.Text = "";
                cboNhanVien.Text = "";
                cboSanPham.Text = "";
                cboHangSanXuat.Text = "";
                numSoLuongNhap.Value = 1;
                txtTimKiem.Text = "";
            }
            // Nút lưu và xóa chỉ sáng khi có sản phẩm
            btnLuuPhieuNhap.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }
        private void ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            LayNhanVienVaoComboBox();
            LayHangSanXuatVaoComboBox();
            LayNhaCungCapVaoComboBox();
            LaySanPhamVaoComboBox();
            dataGridView.AutoGenerateColumns = false;
            if (id != 0) // Đã tồn tại chi tiết
            {
                var phieunhap = context.PhieuNhap.Where(r => r.ID == id).SingleOrDefault();
                cboNhanVien.SelectedValue = phieunhap.NhanVienID;
                cboNhaCungCap.SelectedValue = phieunhap.NhaCungCapID;
                txtGhiChuHoaDon.Text = phieunhap.GhiChuPhieuNhap;
                var pn = context.ChiTietPhieuNhap.Where(r => r.PhieuNhapID == id).Select(r => new DanhSachPhieuNhap_ChiTiet
                {
                    ID = r.ID,
                    PhieuNhapID = r.PhieuNhapID,
                    SanPhamID = r.SanPhamID,
                    TenSanPham = r.SanPham.TenSanPham,
                    SoLuongNhap = r.SoLuongNhap,
                    HangSanXuatID = r.HangSanXuatID,
                    TenHangSanXuat = r.HangSanXuat.TenHangSanXuat
                }).ToList();
                phieuNhap_ChiTiet = new BindingList<DanhSachPhieuNhap_ChiTiet>(pn);
            }
            dataGridView.DataSource = phieuNhap_ChiTiet;
            BatTatChucNang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSanPham = Convert.ToInt32(dataGridView.CurrentRow.Cells["SanPhamID"].Value.ToString());
            var chiTiet = phieuNhap_ChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
            if (chiTiet != null)
            {
                phieuNhap_ChiTiet.Remove(chiTiet);
            }
            BatTatChucNang();
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
                MessageBox.Show("Vui lòng chọn nhân viên lập Phiếu Nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else if (string.IsNullOrWhiteSpace(cboNhaCungCap.Text))
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id != 0) // Đã tồn tại chi tiết thì chỉ cập nhật
                {
                    cPhieuNhap hd = context.PhieuNhap.Find(id);
                    if (hd != null)
                    {
                        hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
                        hd.HangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue.ToString());
                        hd.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue.ToString());
                        hd.GhiChuPhieuNhap = txtGhiChuHoaDon.Text;
                        context.PhieuNhap.Update(hd);
                        // Xóa chi tiết cũ
                        var old = context.ChiTietPhieuNhap.Where(r => r.PhieuNhapID == id).ToList();
                        context.ChiTietPhieuNhap.RemoveRange(old);
                        // Thêm lại chi tiết mới
                        foreach (var item in phieuNhap_ChiTiet.ToList())
                        {
                            cChiTietPhieuNhap ct = new cChiTietPhieuNhap();
                            ct.PhieuNhapID = id;
                            ct.SanPhamID = item.SanPhamID;
                            ct.SoLuongNhap = item.SoLuongNhap;
                            ct.HangSanXuatID = item.HangSanXuatID;
                            context.ChiTietPhieuNhap.Add(ct);
                        }
                        context.SaveChanges();
                    }
                }
                else // Thêm mới
                {
                    cPhieuNhap hd = new cPhieuNhap();
                    hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
                    hd.HangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue.ToString());
                    hd.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue.ToString());
                    hd.NgayLap = DateTime.Now;
                    hd.GhiChuPhieuNhap = txtGhiChuHoaDon.Text;
                    context.PhieuNhap.Add(hd);
                    context.SaveChanges();
                    // Thêm chi tiết
                    foreach (var item in phieuNhap_ChiTiet.ToList())
                    {
                        cChiTietPhieuNhap ct = new cChiTietPhieuNhap();
                        ct.PhieuNhapID = hd.ID;
                        ct.SanPhamID = item.SanPhamID;
                        ct.SoLuongNhap = item.SoLuongNhap;
                        ct.HangSanXuatID = item.HangSanXuatID;
                        context.ChiTietPhieuNhap.Add(ct);
                    }
                    context.SaveChanges();
                }
                MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            InPhieuNhap inp = new InPhieuNhap(id);
            inp.ShowDialog();
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSanPham.Text))
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuongNhap.Value <= 0)
                MessageBox.Show("Số lượng nhập phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboHangSanXuat.Text))
                MessageBox.Show("Vui lòng chọn hãng sản xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            {
                int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue.ToString());
                var chiTiet = phieuNhap_ChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
                // Nếu đã tồn tại sản phẩm thì cập nhật thông tin
                if (chiTiet != null)
                {
                    chiTiet.SoLuongNhap = Convert.ToInt16(numSoLuongNhap.Value);
                    dataGridView.Refresh();
                }
                else // Nếu chưa có sản phẩm thì thêm vào
                {
                    // Nếu chưa có sản phẩm nào
                    DanhSachPhieuNhap_ChiTiet ct = new DanhSachPhieuNhap_ChiTiet
                    {
                        ID = 0,
                        PhieuNhapID = id,
                        SanPhamID = maSanPham,
                        TenSanPham = cboSanPham.Text,
                        HangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue.ToString()),
                        TenHangSanXuat = cboHangSanXuat.Text,
                        SoLuongNhap = Convert.ToInt16(numSoLuongNhap.Value)

                    };
                    phieuNhap_ChiTiet.Add(ct);
                }
                BatTatChucNang();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có muốn Thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhap_Load(sender, e);
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            using (SanPham sp = new SanPham())
            {
                sp.ShowDialog();
            }
        }

        private void btnthemnhacungcap_Click(object sender, EventArgs e)
        {
            using (NhaCungCap sp = new NhaCungCap())
            {
                sp.ShowDialog();
            }
        }
    }
}
