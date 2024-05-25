using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Domain.Interfaces
{
    public interface ISaleRepository
    {
        Sale GetById(int saleId);
        IEnumerable<Sale> GetAll();
        void Add(Sale sale);
        void Update(Sale sale);
        void Delete(int saleId);
    }

}
