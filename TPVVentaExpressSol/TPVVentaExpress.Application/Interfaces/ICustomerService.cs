using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Application.Interfaces
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int customerId);
        IEnumerable<Customer> GetAllCustomers();
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int customerId);
    }

}
