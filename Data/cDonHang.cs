using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data
{


    internal class cDonHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public int KhachHangID { get; set; }
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }

        public virtual ObservableCollectionListSource<cChiTietHoaDon> HoaDon_ChiTiet { get; } = new();
        public virtual cKhachHang KhachHang { get; set; } = null!;
        public virtual cNhanVien NhanVien { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachHoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public string HoVaTenNhanVien { get; set; } // Thêm
        public int KhachHangID { get; set; }
        public string HoVaTenKhachHang { get; set; } // Thêm
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public string? XemChiTiet { get; set; } // Thêm
        public double? TongTienHoaDon { get; set; } // Thêm
    }
}
