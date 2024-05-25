using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Infrastructure.Configurations
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(s => s.SaleId);
            builder.Property(s => s.Date).IsRequired();
            builder.HasMany(s => s.SaleDetails)
                   .WithOne()
                   .HasForeignKey(sd => sd.SaleId);
        }
    }

}
