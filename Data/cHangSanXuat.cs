using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data
{
    internal class cHangSanXuat
    {
        public int ID { get; set; }
        public string TenHangSanXuat { get; set; }
        public virtual ObservableCollectionListSource<cVatLieu> VatLieu { get; } = new();
        public virtual ICollection<cChiTietPhieuNhap> ChiTietPhieuNhap { get; set; } = new List<cChiTietPhieuNhap>();
        public virtual ICollection<cPhieuNhap> PhieuNhap { get; set; } = new List<cPhieuNhap>();

    }
}
