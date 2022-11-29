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
    public class CuaHangConfiguration : IEntityTypeConfiguration<CuaHang>
    {
        public void Configure(EntityTypeBuilder<CuaHang> builder)
        {
            builder.ToTable("CuaHang");
            builder.HasKey(x => x.Id);
            builder.Property(c => c.Id).HasDefaultValueSql("newid()");
            builder.Property(c => c.MaCH).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c => c.TenCH).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.DiaChi).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.ThanhPho).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.QuocGia).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
