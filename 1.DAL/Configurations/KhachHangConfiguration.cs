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
    public class KhachHangConfiguration : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(x => x.Id);
            builder.Property(c => c.MaKH).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c => c.HoTenKH).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(c => c.Sdt).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(c => c.DiaChi).HasColumnType("nvarchar(200)").IsRequired();
        }
    }
}
