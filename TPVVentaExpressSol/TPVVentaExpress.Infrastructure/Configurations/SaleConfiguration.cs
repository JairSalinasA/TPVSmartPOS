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

            // Relación con la entidad Customer
            HasRequired(s => s.Customer)
                .WithMany(c => c.CustomerSales)
                .HasForeignKey(s => s.CustomerId)
                .WillCascadeOnDelete(false); // Opcional: desactivar eliminación en cascada
        }
    }

    public class SaleDetailConfiguration : EntityTypeConfiguration<SaleDetail>
    {
        public SaleDetailConfiguration()
        {
            // Definir la configuración para la entidad SaleDetail
            HasKey(sd => sd.SaleDetailId);
            // Definir relaciones y otras configuraciones si es necesario

            // Relación con la entidad Sale
            HasRequired(sd => sd.Sale)
                .WithMany(s => s.SaleDetails)
                .HasForeignKey(sd => sd.SaleId)
                .WillCascadeOnDelete(true); // Opcional: activar eliminación en cascada
        }
    }
}
