using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Infrastructure.Configurations
{
    public class SaleDetailConfiguration : EntityTypeConfiguration<SaleDetail>
    {
        public SaleDetailConfiguration()
        {
            ToTable("SaleDetails");
            HasKey(sd => sd.SaleDetailId);
            Property(sd => sd.Quantity).IsRequired();
            Property(sd => sd.UnitPrice).IsRequired().HasPrecision(18, 2);
            HasRequired(sd => sd.Sale)
                .WithMany(s => s.SaleDetails)
                .HasForeignKey(sd => sd.SaleId);
            HasRequired(sd => sd.Product)
                .WithMany(p => p.SaleDetails)
                .HasForeignKey(sd => sd.ProductId);
        }
    }
}
