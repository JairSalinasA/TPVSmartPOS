using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetById(int customerId);
        IEnumerable<Customer> GetAll();
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int customerId);
    }

}
