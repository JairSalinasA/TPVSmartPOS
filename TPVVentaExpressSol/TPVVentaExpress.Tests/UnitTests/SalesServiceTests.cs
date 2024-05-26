using Xunit;
using TPVVentaExpress.Domain.Entities;
using TPVVentaExpress.Application.Services;
using TPVVentaExpress.Domain.Interfaces;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace TPVVentaExpress.Tests.UnitTests
{
    public class SalesServiceTests
    {
        [Fact]
        public void GetSaleById_ShouldReturnSale_WhenSaleExists()
        {
            // Arrange
            var saleId = 1;
            var mockRepo = new Mock<ISaleRepository>();
            mockRepo.Setup(repo => repo.GetById(saleId))
                    .Returns(new Sale { SaleId = saleId, Total = 100.00M });

            var service = new SalesService(mockRepo.Object);

            // Act
            var sale = service.GetSaleById(saleId);

            // Assert
            Assert.NotNull(sale);
            Assert.Equal(saleId, sale.SaleId);
        }

        [Fact]
        public void GetAllSales_ShouldReturnAllSales()
        {
            // Arrange
            var mockRepo = new Mock<ISaleRepository>();
            mockRepo.Setup(repo => repo.GetAll())
                    .Returns(new List<Sale> { new Sale { SaleId = 1, Total = 100.00M }, new Sale { SaleId = 2, Total = 200.00M } });

            var service = new SalesService(mockRepo.Object);

            // Act
            var sales = service.GetAllSales();

            // Assert
            Assert.NotNull(sales);
            Assert.Equal(2, sales.Count()); // Usar Count() del espacio de nombres System.Linq
        }
    }
}
