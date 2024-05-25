using System.Data.Entity.ModelConfiguration;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Infrastructure.Configurations
{
    public class SaleConfiguration : EntityTypeConfiguration<Sale>
    {
        public SaleConfiguration()
        {
            // Definir la configuración para la entidad Sale
            HasKey(s => s.SaleId);
            // Definir relaciones y otras configuraciones si es necesario
        }
    }
}
