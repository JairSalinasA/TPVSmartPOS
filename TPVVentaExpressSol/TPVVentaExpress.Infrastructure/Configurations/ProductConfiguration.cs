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
            Property(p => p.Description).HasMaxLength(500); // Definir una longitud máxima para la descripción
            Property(p => p.Price).HasPrecision(10, 2); // Definir precisión y escala para el precio
            //Property(p => p.ManufacturingDate).HasColumnType("datetime2"); // Definir el tipo de columna para la fecha de fabricación
            //Property(p => p.ExpiryDate).HasColumnType("datetime2"); // Definir el tipo de columna para la fecha de vencimiento
                                                                    // Otras configuraciones si es necesario
        }
    }
}
