using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data
{
    internal class cChiTietPhieuNhap
    {
            public int ID { get; set; }
            public int PhieuNhapID { get; set; }
            public int SanPhamID { get; set; }
            public int HangSanXuatID { get; set; }
            public int SoLuongNhap { get; set; }
            public virtual cPhieuNhap PhieuNhap { get; set; } = null!;
            public virtual cVatLieu SanPham { get; set; } = null!;
            public virtual cHangSanXuat HangSanXuat { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachPhieuNhap_ChiTiet
    {
        public int ID { get; set; }
        public int PhieuNhapID { get; set; }
        public int SanPhamID { get; set; }
        public int HangSanXuatID { get; set; }
        public string TenHangSanXuat { get; set; } // Thêm
        public string TenSanPham { get; set; } // Thêm
        public int SoLuongNhap { get; set; }

    }
}
