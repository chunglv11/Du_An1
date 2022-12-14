using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.Id);
            builder.Property(c => c.Id).HasDefaultValueSql("newid()");
            builder.Property(c => c.IdCh).IsRequired();
            builder.Property(c => c.IdCv).IsRequired();
            builder.Property(c => c.MaNv).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c => c.HoTenNv).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(c => c.NgaySinh).HasColumnType("Datetime").IsRequired();
            builder.Property(c => c.GioiTinh).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(c => c.DiaChi).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(c => c.CCCD).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(c => c.Sdt).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(c => c.Anh).HasColumnType("nvarchar(300)").IsRequired();
            builder.Property(c => c.Email).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.MatKhau).HasColumnType("nvarchar(50)");
            builder.Property(c => c.TrangThai).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.CuaHang).WithMany().HasForeignKey(p => p.IdCh);
            builder.HasOne(x => x.ChucVu).WithMany().HasForeignKey(p => p.IdCv);
        }
    }
}
