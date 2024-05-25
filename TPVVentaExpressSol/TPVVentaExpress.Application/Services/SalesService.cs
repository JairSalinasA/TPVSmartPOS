using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVVentaExpress.Application.Interfaces;
using TPVVentaExpress.Domain.Entities;
using TPVVentaExpress.Domain.Interfaces;

namespace TPVVentaExpress.Application.Services
{
    public class SalesService : ISalesService
    {
        private readonly ISaleRepository _saleRepository;

        public SalesService(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        public Sale GetSaleById(int saleId)
        {
            return _saleRepository.GetById(saleId);
        }

        public IEnumerable<Sale> GetAllSales()
        {
            return _saleRepository.GetAll();
        }

        public void AddSale(Sale sale)
        {
            _saleRepository.Add(sale);
        }

        public void UpdateSale(Sale sale)
        {
            _saleRepository.Update(sale);
        }

        public void DeleteSale(int saleId)
        {
            _saleRepository.Delete(saleId);
        }
    }

}
