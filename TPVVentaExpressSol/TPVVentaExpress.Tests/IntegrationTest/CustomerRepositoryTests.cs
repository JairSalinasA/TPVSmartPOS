using Xunit;
using TPVVentaExpress.Infrastructure.Repositories;
using TPVVentaExpress.Infrastructure.Data;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Tests.IntegrationTests
{
    public class CustomerRepositoryTests
    {
        private readonly CustomerRepository _repository;

        public CustomerRepositoryTests()
        {
            var context = new ApplicationDbContext();
            _repository = new CustomerRepository(context);
        }

        [Fact]
        public void GetCustomerById_ShouldReturnCustomer_WhenCustomerExists()
        {
            // Arrange
            var customerId = 1;
            var expectedCustomer = new Customer { CustomerId = customerId, Name = "John Doe" };

            // Act
            var customer = _repository.GetById(customerId);

            // Assert
            Assert.NotNull(customer);
            Assert.Equal(expectedCustomer.CustomerId, customer.CustomerId);
        }

        // Agrega más pruebas aquí
    }
}
