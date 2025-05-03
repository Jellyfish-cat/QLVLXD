using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data
{
    internal class cChiTietHoaDon
    {
        public int ID { get; set; }
        public int DonHangID { get; set; }
        public int SanPhamID { get; set; }
        public int SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }
        public virtual cDonHang DonHang { get; set; } = null!;
        public virtual cVatLieu SanPham { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachHoaDon_ChiTiet
    {
        public int ID { get; set; }
        public int DonHangID { get; set; }
        public int SanPhamID { get; set; }
        public string TenSanPham { get; set; } // Thêm
        public int SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }
        public int ThanhTien { get; set; } // Thêm
    }
}
