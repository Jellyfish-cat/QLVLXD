using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data
{
    internal class cNhaCungCap
    {
        public int ID { get; set; }
        public string TenNhaCungCap { get; set; }
        public string DienThoai {  get; set; }
        public string DiaChi {  get; set; }
        public virtual ObservableCollectionListSource<cVatLieu> VatLieu { get; } = new();
        public virtual ObservableCollectionListSource<cPhieuNhap> PhieuNhap { get; } = new();
    }
}
