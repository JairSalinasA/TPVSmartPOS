using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVVentaExpress.Domain.Entities;
using TPVVentaExpress.Domain.Interfaces;

namespace TPVVentaExpress.Domain.Services
{
    public class SaleDomainService
    {
        private readonly IProductRepository _productRepository;
        private readonly ISaleRepository _saleRepository;

        public SaleDomainService(IProductRepository productRepository, ISaleRepository saleRepository)
        {
            _productRepository = productRepository;
            _saleRepository = saleRepository;
        }

        public void CreateSale(Sale sale)
        {
            // Lógica para crear una venta
            // Validar inventario, calcular total, etc.
            foreach (var detail in sale.SaleDetails)
            {
                var product = _productRepository.GetById(detail.ProductId);
                if (product == null || product.Stock < detail.Quantity)
                {
                    throw new Exception("Stock insuficiente o producto no encontrado");
                }
                product.Stock -= detail.Quantity;
                _productRepository.Update(product);
            }

            sale.Total = sale.SaleDetails.Sum(d => d.Quantity * d.UnitPrice);
            _saleRepository.Add(sale);
        }
    }


}
