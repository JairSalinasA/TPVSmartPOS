using System.Data.Entity.ModelConfiguration;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Infrastructure.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("Products");
            HasKey(p => p.ProductId);
            Property(p => p.Name).IsRequired().HasMaxLength(100);
            Property(p => p.Price).IsRequired().HasPrecision(18, 2);
            Property(p => p.Stock).IsRequired();
            Property(p => p.Description).HasMaxLength(500);
        }
    }
}
