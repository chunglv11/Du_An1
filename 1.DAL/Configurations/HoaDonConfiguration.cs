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
    public class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.Id);
            builder.Property(c => c.Id).HasDefaultValueSql("newid()");
            builder.Property(c => c.IdKh).IsRequired();
            builder.Property(c => c.IdNv).IsRequired();
            builder.Property(c => c.MaHD).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c => c.NgayTao).HasColumnType("Datetime").IsRequired();
            builder.Property(c => c.NgayThanhToan).HasColumnType("Datetime").IsRequired();
            builder.Property(c => c.NgayShip).HasColumnType("Datetime");
            builder.Property(c => c.TenNguoiShip).HasColumnType("nvarchar(50)");
            builder.Property(c => c.NgayNhan).HasColumnType("Datetime");
            builder.Property(c => c.TenNguoiNhan).HasColumnType("nvarchar(50)");
            builder.Property(c => c.Sdt).HasColumnType("nvarchar(20)");
            builder.Property(c => c.DiaChi).HasColumnType("nvarchar(200)");
            builder.Property(c => c.TongTien).HasColumnType("decimal(18,2)");
            builder.Property(c => c.TinhTrang).HasColumnType("int");
            builder.HasOne(x => x.KhachHang).WithMany().HasForeignKey(p => p.IdKh);
            builder.HasOne(x => x.NhanVien).WithMany().HasForeignKey(p => p.IdNv);
        }
    }
}
