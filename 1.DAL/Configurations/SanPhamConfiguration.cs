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
    public class SanPhamConfiguration : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.MaSp).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c => c.TenSp).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
