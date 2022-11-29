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
    public class NsxConfiguration : IEntityTypeConfiguration<Nsx>
    {
        public void Configure(EntityTypeBuilder<Nsx> builder)
        {
            builder.ToTable("Nsx");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasDefaultValueSql("newid()");
            builder.Property(c => c.MaNsx).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c => c.TenNsx).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
