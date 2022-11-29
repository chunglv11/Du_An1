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
    public class KichCoConfiguration : IEntityTypeConfiguration<KichCo>
    {
        public void Configure(EntityTypeBuilder<KichCo> builder)
        {
            builder.ToTable("KichCo");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasDefaultValueSql("newid()");
            builder.Property(c => c.MaKc).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c => c.TenKc).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
