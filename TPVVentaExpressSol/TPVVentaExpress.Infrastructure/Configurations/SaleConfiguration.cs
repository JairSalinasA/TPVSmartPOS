using System.Data.Entity.ModelConfiguration;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Infrastructure.Configurations
{
    public class SaleConfiguration : EntityTypeConfiguration<Sale>
    {
        public SaleConfiguration()
        {
            ToTable("Sales");
            HasKey(s => s.SaleId);
            Property(s => s.Date).IsRequired();
            Property(s => s.Total).IsRequired().HasPrecision(18, 2);
            HasRequired(s => s.Customer)
                .WithMany(c => c.CustomerSales)
                .HasForeignKey(s => s.CustomerId);
        }
    }

     
}
