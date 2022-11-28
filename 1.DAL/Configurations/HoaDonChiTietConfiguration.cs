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
    public class HoaDonChiTietConfiguration : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(x => new { x.IdHoaDon, x.IdChiTietSp });
            builder.Property(c => c.SoLuong).HasColumnType("int").IsRequired();
            builder.Property(c => c.DonGia).HasColumnType("decimal(9,3)").IsRequired();
            builder.HasOne(x => x.HoaDon).WithMany().HasForeignKey(p => p.IdHoaDon);
            builder.HasOne(x => x.ChiTietSp).WithMany().HasForeignKey(p => p.IdChiTietSp);
        }
    }
}
