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
    public class MauSacConfiguration : IEntityTypeConfiguration<MauSac>
    {
        public void Configure(EntityTypeBuilder<MauSac> builder)
        {
            builder.ToTable("MauSac");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasDefaultValueSql("newid()");
            builder.Property(c => c.MaMs).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c => c.TenMs).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
