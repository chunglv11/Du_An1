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
    public class ChucVuConfiguration : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.ToTable("ChucVu");
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.MaCV).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c=>c.TenCV).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
