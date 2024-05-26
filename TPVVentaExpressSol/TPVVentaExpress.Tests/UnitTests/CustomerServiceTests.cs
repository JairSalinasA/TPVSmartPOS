using Xunit;
using TPVVentaExpress.Domain.Entities;
using Moq;
using System.Collections.Generic;
using TPVVentaExpress.Domain.Interfaces;
using TPVVentaExpress.Application.Services;
using System.Linq;

namespace TPVVentaExpress.Tests.UnitTests
{
    public class CustomerServiceTests
    {
        [Fact]
        public void GetCustomerById_ShouldReturnCustomer_WhenCustomerExists()
        {
            // Arrange
            var customerId = 1;
            var mockRepo = new Mock<ICustomerRepository>();
            mockRepo.Setup(repo => repo.GetById(customerId))
                    .Returns(new Customer { CustomerId = customerId, Name = "John Doe" });

            var service = new CustomerService(mockRepo.Object);

            // Act
            var customer = service.GetCustomerById(customerId);

            // Assert
            Assert.NotNull(customer);
            Assert.Equal(customerId, customer.CustomerId);
        }

        [Fact]
        public void GetAllCustomers_ShouldReturnAllCustomers()
        {
            // Arrange
            var mockRepo = new Mock<ICustomerRepository>();
            mockRepo.Setup(repo => repo.GetAll())
                    .Returns(new List<Customer> { new Customer { CustomerId = 1, Name = "John Doe" }, new Customer { CustomerId = 2, Name = "Jane Smith" } });

            var service = new CustomerService(mockRepo.Object);

            // Act
            var customers = service.GetAllCustomers();

            // Assert
            Assert.NotNull(customers);
            Assert.Equal(2, customers.Count());
        }
    }
}
