using System.Data.Entity.ModelConfiguration;
using TPVVentaExpress.Domain.Entities;

public class CustomerConfiguration : EntityTypeConfiguration<Customer>
{
    public CustomerConfiguration()
    {
        // Definir la configuración para la entidad Customer
        ToTable("Customers");
        HasKey(c => c.CustomerId);
        Property(c => c.Name).IsRequired().HasMaxLength(100); 
        Property(c => c.Phone).HasMaxLength(15);

        // Mapear las propiedades de Address a sus columnas correspondientes
        Property(c => c.Address.Street).HasColumnName("StreetColumn");
        Property(c => c.Address.City).HasColumnName("CityColumn");
        Property(c => c.Address.State).HasColumnName("StateColumn");
        Property(c => c.Address.PostalCode).HasColumnName("PostalCodeColumn");
         
    }
}
