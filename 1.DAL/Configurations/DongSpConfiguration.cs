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
    public class DongSpConfiguration : IEntityTypeConfiguration<DongSp>
    {
        public void Configure(EntityTypeBuilder<DongSp> builder)
        {
            builder.ToTable("DongSp");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.MaDsp).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c => c.TenDsp).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
