using Xunit;
using TPVVentaExpress.Infrastructure.Repositories;
using TPVVentaExpress.Infrastructure.Data;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Tests.IntegrationTests
{
    public class SalesRepositoryTests
    {
        private readonly SaleRepository _repository;

        public SalesRepositoryTests()
        {
            var context = new ApplicationDbContext();
            _repository = new SaleRepository(context);
        }

        [Fact]
        public void GetSaleById_ShouldReturnSale_WhenSaleExists()
        {
            // Arrange
            var saleId = 1;
            var expectedSale = new Sale { SaleId = saleId, Total = 100.00M };

            // Act
            var sale = _repository.GetById(saleId);

            // Assert
            Assert.NotNull(sale);
            Assert.Equal(expectedSale.SaleId, sale.SaleId);
        }

        // Agrega más pruebas aquí
    }
}
