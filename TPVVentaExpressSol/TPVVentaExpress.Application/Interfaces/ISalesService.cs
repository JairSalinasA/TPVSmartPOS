using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Application.Interfaces
{
    public interface ISalesService
    {
        Sale GetSaleById(int saleId);
        IEnumerable<Sale> GetAllSales();
        void AddSale(Sale sale);
        void UpdateSale(Sale sale);
        void DeleteSale(int saleId);
    }

}
