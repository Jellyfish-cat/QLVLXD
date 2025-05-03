using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data
{
    internal class cDanhMuc
    {
        public int id { get ; set; }
        public string TenDanhMuc { get; set; }

        public virtual ObservableCollectionListSource<cVatLieu> SanPham { get; } = new();

    }
}
