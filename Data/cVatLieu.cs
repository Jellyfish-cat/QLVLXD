using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data
{
    internal class cVatLieu
    {
        public int id { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong {  get; set; }
        public int Gia { get; set; } 
        public string? MoTa {  get; set; }

        public int NhaCungCapId { get; set; }

        public int DanhMucId {  get; set; }
        public int HangSanXuatId {  get; set; }
        public string? HinhAnh {  get; set; }   

        public virtual cDanhMuc DanhMuc { get; set; } = null!;
        public virtual cHangSanXuat HangSanXuat { get; set; } = null!;
        public virtual cNhaCungCap NhaCungCap { get; set; } = null!;
        public virtual ICollection<cChiTietHoaDon> HoaDon_ChiTiet { get; set; } = new List<cChiTietHoaDon>();
        public virtual ICollection<cChiTietPhieuNhap> ChiTietPhieuNhap { get; set; } = new List<cChiTietPhieuNhap>();

    }
    [NotMapped]
    public class DanhSachSanPham
    {
        public int id1 { get; set; }
        public int HangSanXuatId { get; set; }
        public string TenHangSanXuat { get; set; } // Thêm
        public int DanhMucId { get; set; }
        public string TenDanhMuc { get; set; } // Thêm
        public string TenSanPham { get; set; }
        public int NhaCungCapId { get; set; }
        public string TenNhaCungCap { get; set; }
        public int Gia { get; set; }
        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }

    }
}
