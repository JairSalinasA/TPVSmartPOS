using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVVentaExpress.Infrastructure.Data
{
    public class TPVVentaExpressDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("YourConnectionStringHere");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }

}
