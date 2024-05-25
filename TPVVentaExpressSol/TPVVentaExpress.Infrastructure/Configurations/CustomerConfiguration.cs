using System.Data.Entity.ModelConfiguration;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Infrastructure.Configurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            // Definir la configuración para la entidad Customer
            HasKey(c => c.CustomerId);
            Property(c => c.Name).HasMaxLength(100).IsRequired();
            // Otras configuraciones si es necesario
        }
    }
}
