using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Infrastructure.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.CustomerId);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.OwnsOne(c => c.Address, a =>
            {
                a.Property(ad => ad.Street).HasMaxLength(200);
                a.Property(ad => ad.City).HasMaxLength(100);
                a.Property(ad => ad.PostalCode).HasMaxLength(20);
            });
        }
    }

}
