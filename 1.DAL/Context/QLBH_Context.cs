using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _1.DAL.Entities;
using _1.DAL.Configurations;
using System.Reflection;

namespace _1.DAL.Context
{
    public class QLBH_Context:DbContext
    {
        public QLBH_Context()
        {

        }
        public QLBH_Context(DbContextOptions<QLBH_Context> dbContextOptions) : base(dbContextOptions)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=NGUYENQUANGDUNG\SQLEXPRESS;Initial Catalog=DuAn_1;Persist Security Info=True;User ID=lala;Password=123");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply cac config cho từng class 1
            modelBuilder.ApplyConfiguration(new CuaHangConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietSpConfiguration());
            modelBuilder.ApplyConfiguration(new ChucVuConfiguration());
            modelBuilder.ApplyConfiguration(new DongSpConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonChiTietConfiguration());
            modelBuilder.ApplyConfiguration(new KichCoConfiguration());
            modelBuilder.ApplyConfiguration(new KhachHangConfiguration());
            modelBuilder.ApplyConfiguration(new MauSacConfiguration());
            modelBuilder.ApplyConfiguration(new NsxConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new SanPhamConfiguration());
            // Apply cac config cho cac model
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Phương thức này sẽ áp dụng tất cả các config hiện có
        }
        public DbSet<CuaHang> cuaHangs { get; set; }
        public DbSet<ChiTietSp> chiTietSps { get; set; }
        public DbSet<ChucVu> chucVus { get; set; }
        public DbSet<DongSp> dongSps { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<HoaDonChiTiet> hoaDonChiTiets { get; set; }
        public DbSet<KichCo> kichCos { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<MauSac> mauSacs { get; set; }
        public DbSet<Nsx> Nsxes { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<SanPham> sanPhams { get; set; }
    }
}
