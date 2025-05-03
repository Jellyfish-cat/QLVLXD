using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WinFormsApp1.Data
{
    internal class QLBHDbcontext : DbContext
    {
        public DbSet<cDanhMuc> DanhMuc { get; set; }
        public DbSet<cHangSanXuat> HangSanXuat { get; set; }
        public DbSet<cVatLieu> VatLieu { get; set; }
        public DbSet<cNhanVien> NhanVien { get; set; }
        public DbSet<cKhachHang> KhachHang { get; set; }
        public DbSet<cDonHang> DonHang { get; set; }
        public DbSet<cChiTietHoaDon> HoaDon_ChiTiet { get; set; }
        public DbSet<cNhaCungCap> NhaCungCap { get; set; }
        public DbSet<cPhieuNhap> PhieuNhap { get; set; }
        public DbSet<cChiTietPhieuNhap> ChiTietPhieuNhap  { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLBHConnection"].ConnectionString);
        }

    }
}
