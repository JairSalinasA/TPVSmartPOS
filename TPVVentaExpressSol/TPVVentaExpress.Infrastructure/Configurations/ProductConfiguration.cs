using System.Data.Entity.ModelConfiguration;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Infrastructure.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            // Definir la configuración para la entidad Product
            HasKey(p => p.ProductId);
            Property(p => p.Name).HasMaxLength(100).IsRequired();
            // Otras configuraciones si es necesario
        }
    }
}
