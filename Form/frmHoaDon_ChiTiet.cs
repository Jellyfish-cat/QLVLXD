
using Microsoft.VisualBasic.Devices;
using QLBH;
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
using WinFormsApp1.Reports;

namespace QuanLiBanhang.Froms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        QLBHDbcontext context = new QLBHDbcontext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();
        BindingList<cVatLieu> sanPham = new BindingList<cVatLieu>();
        int soluonghientai;
        int[] soluongbandau = new int[short.MaxValue];
        bool daluu = false;
        public frmHoaDon_ChiTiet()
        {
            InitializeComponent();
        }
        public frmHoaDon_ChiTiet(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }


        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }
        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
        }
        public void LaySanPhamVaoComboBox()
        {
            cboSanPham.DataSource = context.VatLieu.ToList();
            cboSanPham.ValueMember = "ID";
            cboSanPham.DisplayMember = "TenSanPham";
        }
        public void BatTatChucNang()
        {
            if (id == 0 && dataGridView.Rows.Count == 0) // Thêm
            {
                // Xóa trắng các trường
                cboKhachHang.Text = "";
                cboNhanVien.Text = "";
                cboSanPham.Text = "";
                numSoLuongBan.Value = 1;
                numDonGiaBan.Value = 0;
                txtTimKiem.Text = "";
            }
            // Nút lưu và xóa chỉ sáng khi có sản phẩm
            btnLuuHoaDon.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();
            LaySanPhamVaoComboBox();
            dataGridView.AutoGenerateColumns = false;
            if (id != 0)
            {
                var hoaDon = context.DonHang.Where(r => r.ID == id).SingleOrDefault();
                cboNhanVien.SelectedValue = hoaDon.NhanVienID;
                cboKhachHang.SelectedValue = hoaDon.KhachHangID;
                txtGhiChuHoaDon.Text = hoaDon.GhiChuHoaDon;
                var ct = context.HoaDon_ChiTiet.Where(r => r.DonHangID == id).Select(r => new DanhSachHoaDon_ChiTiet
                {
                    ID = r.ID,
                    DonHangID = r.DonHangID,
                    SanPhamID = r.SanPhamID,
                    TenSanPham = r.SanPham.TenSanPham,
                    SoLuongBan = r.SoLuongBan,
                    DonGiaBan = r.DonGiaBan,
                    ThanhTien = Convert.ToInt32(r.SoLuongBan * r.DonGiaBan)
                }).ToList();
                hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(ct);
            }
            numSoLuongBan.DataBindings.Clear();
            numSoLuongBan.DataBindings.Add("Value", hoaDonChiTiet, "SoLuongBan", false, DataSourceUpdateMode.Never);
            cboSanPham.DataBindings.Clear();
            cboSanPham.DataBindings.Add("Text", hoaDonChiTiet, "TenSanPham", false, DataSourceUpdateMode.Never);
            numDonGiaBan.DataBindings.Clear();
            numDonGiaBan.DataBindings.Add("Value", hoaDonChiTiet, "DonGiaBan", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = hoaDonChiTiet;
            int index = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["SoLuongBan"].Value != null)
                {
                    soluongbandau[index] = Convert.ToInt32(row.Cells["SoLuongBan"].Value);
                    index++;
                }
            }
            BatTatChucNang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSanPham = Convert.ToInt32(dataGridView.CurrentRow.Cells["SanPhamID"].Value.ToString());
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
            var sp = context.VatLieu.Find(maSanPham);
            if (chiTiet != null)
            {
                sp.SoLuong += Convert.ToInt32(numSoLuongBan.Value);
                context.SaveChanges();
                SanPham spp = new SanPham();
                spp.SanPham_Load(sender, e);
                var sanPham = context.VatLieu.Find(maSanPham);
                numTonKho.Value = sanPham.SoLuong;
                hoaDonChiTiet.Remove(chiTiet);
            }
            BatTatChucNang();

        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
                MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboKhachHang.Text))
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id != 0) // Đã tồn tại chi tiết thì chỉ cập nhật
                {
                    cDonHang hd = context.DonHang.Find(id);
                    if (hd != null)
                    {
                        hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
                        hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue.ToString());
                        hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                        context.DonHang.Update(hd);
                        // Xóa chi tiết cũ
                        var old = context.HoaDon_ChiTiet.Where(r => r.DonHangID == id).ToList();
                        context.HoaDon_ChiTiet.RemoveRange(old);
                        // Thêm lại chi tiết mới
                        foreach (var item in hoaDonChiTiet.ToList())
                        {
                            cChiTietHoaDon ct = new cChiTietHoaDon();
                            ct.DonHangID = id;
                            ct.SanPhamID = item.SanPhamID;
                            ct.SoLuongBan = item.SoLuongBan;
                            ct.DonGiaBan = item.DonGiaBan;
                            context.HoaDon_ChiTiet.Add(ct);
                        }
                        context.SaveChanges();
                    }
                }
                else // Thêm mới
                {
                    cDonHang hd = new cDonHang();
                    hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
                    hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue.ToString());
                    hd.NgayLap = DateTime.Now;
                    hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                    context.DonHang.Add(hd);
                    context.SaveChanges();
                    // Thêm chi tiết
                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        cChiTietHoaDon ct = new cChiTietHoaDon();
                        ct.DonHangID = hd.ID;
                        ct.SanPhamID = item.SanPhamID;
                        ct.SoLuongBan = item.SoLuongBan;
                        ct.DonGiaBan = item.DonGiaBan;
                        context.HoaDon_ChiTiet.Add(ct);
                        id = ct.DonHangID;
                    }
                    context.SaveChanges();
                }
                daluu = true;
                MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            HoaDon hoaDon = new HoaDon();
            hoaDon.frmHoaDon_Load(sender, EventArgs.Empty);
        }
        private void XuatFile(string filePath)
        {

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            InHoaDon inhd = new InHoaDon(id);
            inhd.ShowDialog();
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue.ToString());
            var sanPham = context.VatLieu.Find(maSanPham);
            numDonGiaBan.Value = (decimal)sanPham.Gia;
            numTonKho.Value = sanPham.SoLuong;
            soluonghientai = (int)numSoLuongBan.Value;
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSanPham.Text))
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuongBan.Value <= 0)
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGiaBan.Value <= 0)
                MessageBox.Show("Đơn giá bán sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numTonKho.Value < numSoLuongBan.Value)
                MessageBox.Show("số lượng bán sản phẩm không được lớn hơn tồn kho.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue.ToString());
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
                var sp = context.VatLieu.FirstOrDefault(v => v.id == maSanPham);



                // Nếu đã tồn tại sản phẩm thì cập nhật thông tin
                if (chiTiet != null)
                {
                    chiTiet.SoLuongBan = Convert.ToInt16(numSoLuongBan.Value);
                    chiTiet.DonGiaBan = Convert.ToInt32(numDonGiaBan.Value);
                    chiTiet.ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value);

                    if (soluonghientai > (int)numSoLuongBan.Value)
                    {
                        sp.SoLuong += Convert.ToInt32(soluonghientai - numSoLuongBan.Value);
                        context.SaveChanges();
                        SanPham spp = new SanPham();
                        spp.SanPham_Load(sender, e);
                        var sanPham = context.VatLieu.Find(maSanPham);
                        numTonKho.Value = sanPham.SoLuong;
                    }
                    else if (soluonghientai < (int)numSoLuongBan.Value)
                    {
                        sp.SoLuong -= Convert.ToInt32(numSoLuongBan.Value - soluonghientai);
                        context.SaveChanges();
                        SanPham spp = new SanPham();
                        spp.SanPham_Load(sender, e);
                        var sanPham = context.VatLieu.Find(maSanPham);
                        numTonKho.Value = sanPham.SoLuong;
                    }
                    soluonghientai = (int)numSoLuongBan.Value;
                    dataGridView.Refresh();
                }
                else // Nếu chưa có sản phẩm thì thêm vào
                {
                    // Nếu chưa có sản phẩm nào
                    DanhSachHoaDon_ChiTiet ct = new DanhSachHoaDon_ChiTiet
                    {
                        ID = 0,
                        DonHangID = id,
                        SanPhamID = maSanPham,
                        TenSanPham = cboSanPham.Text,
                        SoLuongBan = Convert.ToInt16(numSoLuongBan.Value),
                        DonGiaBan = Convert.ToInt32(numDonGiaBan.Value),
                        ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value)
                    };
                    sp.SoLuong -= Convert.ToInt32(numSoLuongBan.Value);
                    context.SaveChanges();
                    SanPham spp = new SanPham();
                    spp.SanPham_Load(sender, e);
                    var sanPham = context.VatLieu.Find(maSanPham);
                    numTonKho.Value = sanPham.SoLuong;
                    hoaDonChiTiet.Add(ct);

                }
                BatTatChucNang();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có muốn Thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                var danhsach = context.VatLieu.ToList();
                foreach (var i in danhsach)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if ((int)row.Cells["SanPhamID"].Value == i.id)
                        {
                            var soluongtra = (int)row.Cells["SoLuongBan"].Value;
                            i.SoLuong += Convert.ToInt32(soluongtra);
                            context.SaveChanges();
                        }
                    }
                }
                hoaDonChiTiet.Clear();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHoaDon_ChiTiet_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            string keyword = txtTimKiem.Text.Trim();
            List<DanhSachHoaDon_ChiTiet> cthd = new List<DanhSachHoaDon_ChiTiet>();
            if (keyword.ToLower() == "" || keyword.ToLower().GetType() != typeof(string))
            {
                MessageBox.Show("Từ khóa không được bỏ trống và phải là tên sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cthd = context.HoaDon_ChiTiet.Where(r => r.SanPham.TenSanPham.Contains(keyword)).Select(r => new DanhSachHoaDon_ChiTiet
                {
                    ID = r.ID,
                    DonHangID = r.DonHangID,
                    SanPhamID = r.SanPhamID,
                    TenSanPham = r.SanPham.TenSanPham,
                    SoLuongBan = r.SoLuongBan,
                    DonGiaBan = r.DonGiaBan,
                    ThanhTien = Convert.ToInt32(r.SoLuongBan * r.DonGiaBan)
                }).ToList();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = cthd;

                dataGridView.DataSource = bindingSource;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnPhongCach_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanHang bh = new BanHang(id);
            bh.ShowDialog();
            this.Close();
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numSoLuongBan_ValueChanged(object sender, EventArgs e)
        {
            daluu = false;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                int sanPhamId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["SanPhamId"].Value);
                var sp = context.VatLieu.Find(sanPhamId);
                numTonKho.Value = sp.SoLuong;
                soluonghientai = (int)numSoLuongBan.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
