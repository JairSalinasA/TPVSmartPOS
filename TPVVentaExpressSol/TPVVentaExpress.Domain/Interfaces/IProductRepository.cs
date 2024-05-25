using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Domain.Interfaces
{
    public interface IProductRepository
    {
        Product GetById(int productId);
        IEnumerable<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
    }

}
