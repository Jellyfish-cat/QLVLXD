using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data
{
    internal class cPhieuNhap
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public int NhaCungCapID { get; set; }
        public int HangSanXuatID { get; set; }
        public DateTime NgayLap { get; set; }
        public string? GhiChuPhieuNhap { get; set; }

        public virtual ObservableCollectionListSource<cChiTietPhieuNhap> ChiTietPhieuNhap { get; } = new();
        public virtual cNhaCungCap NhaCungCap { get; set; } = null!;
        public virtual cHangSanXuat HangSanXuat { get; set; } = null!;
        public virtual cNhanVien NhanVien { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachPhieuNhap
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public string TenNhanVien { get; set; } // Thêm
        public int NhaCungCapID { get; set; }
        public string TenNhaCungCap { get; set; } // Thêm
        public int HangSanXuatID { get; set; }
        public string TenHangSanXuat { get; set; } // Thêm
        public DateTime NgayLap { get; set; }
        public string? GhiChuPhieuNhap { get; set; }
        public string? XemChiTiet { get; set; } // Thêm
        
    }

}
