using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TPVVentaExpress.Domain.Entities;
using TPVVentaExpress.Domain.ValueObjects;
using TPVVentaExpress.Infrastructure.Configurations;

namespace TPVVentaExpress.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<User> User { get; set; }
        public ApplicationDbContext() : base("ApplicationDbContext")
        {
        }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new SaleConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration()); 
            modelBuilder.ComplexType<Address>();
            base.OnModelCreating(modelBuilder);
        }

        public class TPVVentaExpressDbContextFactory : IDbContextFactory<ApplicationDbContext>
        {
            public ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }
        }
    }
}

