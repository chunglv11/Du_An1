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
    public class ChiTietSpConfiguration : IEntityTypeConfiguration<ChiTietSp>
    {
        public void Configure(EntityTypeBuilder<ChiTietSp> builder)
        {
            builder.ToTable("ChiTietSp");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.IdSp).IsRequired();
            builder.Property(c => c.IdNsx).IsRequired();
            builder.Property(c => c.IdMauSac).IsRequired();
            builder.Property(c => c.IdDongSp).IsRequired();
            builder.Property(c => c.IdKichCo).IsRequired();
            builder.Property(c => c.MoTa).HasColumnType("nvarchar(300)").IsRequired();
            builder.Property(c => c.SoLuongTon).HasColumnType("int").IsRequired();
            builder.Property(c => c.GiaNhap).HasColumnType("decimal(9,3)").IsRequired();
            builder.Property(c => c.GiaBan).HasColumnType("decimal(9,3)").IsRequired();
            builder.Property(c => c.TinhTrang).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.SanPham).WithMany().HasForeignKey(p => p.IdSp);
            builder.HasOne(x => x.MauSac).WithMany().HasForeignKey(p => p.IdMauSac);
            builder.HasOne(x => x.DongSp).WithMany().HasForeignKey(p => p.IdDongSp);
            builder.HasOne(x => x.KichCo).WithMany().HasForeignKey(p => p.IdKichCo);
            builder.HasOne(x => x.Nsx).WithMany().HasForeignKey(p => p.IdNsx);
        }
    }
}
