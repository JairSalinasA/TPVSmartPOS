using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace TPVVentaExpress.Infrastructure.Data
{
    public class TPVVentaExpressDbContextFactory : IDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
