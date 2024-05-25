using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVVentaExpress.Domain.Entities;
using TPVVentaExpress.Domain.Interfaces;

namespace TPVVentaExpress.Domain.Services
{
    public class ProductDomainService
    {
        private readonly IProductRepository _productRepository;

        public ProductDomainService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            // Lógica para añadir un nuevo producto
            // Podría incluir validaciones adicionales, envío de notificaciones, etc.
            _productRepository.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            // Lógica para actualizar la información de un producto
            // Podría incluir validaciones adicionales
            _productRepository.Update(product);
        }

        public Product GetProductDetails(int productId)
        {
            // Lógica para obtener los detalles de un producto específico
            return _productRepository.GetById(productId);
        }

        public void DeleteProduct(int productId)
        {
            // Lógica para eliminar un producto
            _productRepository.Delete(productId);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            // Lógica para obtener todos los productos
            return _productRepository.GetAll();
        }

        public void AdjustStock(int productId, int quantity)
        {
            // Lógica para ajustar el stock de un producto
            var product = _productRepository.GetById(productId);
            if (product != null)
            {
                product.Stock += quantity;
                _productRepository.Update(product);
            }
        }
    }

}
