using Xunit;
using TPVVentaExpress.Infrastructure.Repositories;
using TPVVentaExpress.Infrastructure.Data;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Tests.IntegrationTests
{
    public class ProductRepositoryTests
    {
        private readonly ProductRepository _repository;

        public ProductRepositoryTests()
        {
            var context = new ApplicationDbContext();
            _repository = new ProductRepository(context);
        }

        [Fact]
        public void GetProductById_ShouldReturnProduct_WhenProductExists()
        {
            // Arrange
            var productId = 1;
            var expectedProduct = new Product { ProductId = productId, Name = "Test Product" };

            // Act
            var product = _repository.GetById(productId);

            // Assert
            Assert.NotNull(product);
            Assert.Equal(expectedProduct.ProductId, product.ProductId);
        }

        // Agrega más pruebas aquí
    }
}

