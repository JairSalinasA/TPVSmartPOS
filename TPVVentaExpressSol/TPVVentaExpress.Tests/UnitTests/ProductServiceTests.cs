using Xunit;
using TPVVentaExpress.Domain.Entities; 
using Moq;
using System.Collections.Generic;
using System.Linq;  // Asegúrate de incluir esto para usar el método de extensión Count
using TPVVentaExpress.Application.Services;
using TPVVentaExpress.Domain.Interfaces;

namespace TPVVentaExpress.Tests.UnitTests
{
    public class ProductServiceTests
    {
        [Fact]
        public void GetProductById_ShouldReturnProduct_WhenProductExists()
        {
            // Configuración
            var productId = 1;
            var mockRepo = new Mock<IProductRepository>();
            mockRepo.Setup(repo => repo.GetById(It.IsAny<int>()))
                    .Returns((int id) => new Product { ProductId = id, Name = "Test Product" });

            var service = new ProductService(mockRepo.Object);

            // Acción
            var product = service.GetProductById(productId);

            // Aserciones
            Assert.NotNull(product);
            Assert.Equal(productId, product.ProductId);
        }

        [Fact]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            // Configuración
            var mockRepo = new Mock<IProductRepository>();
            mockRepo.Setup(repo => repo.GetAll())
                    .Returns(new List<Product> { new Product { ProductId = 1, Name = "Producto 1" }, new Product { ProductId = 2, Name = "Producto 2" } });

            var service = new ProductService(mockRepo.Object);

            // Acción
            var products = service.GetAllProducts();

            // Aserciones
            Assert.NotNull(products);
            Assert.Equal(2, products.Count());
        }
    }
}
