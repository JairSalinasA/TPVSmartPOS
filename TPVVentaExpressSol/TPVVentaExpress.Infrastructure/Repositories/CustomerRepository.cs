using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TPVVentaExpress.Domain.Entities;
using TPVVentaExpress.Domain.Interfaces;
using TPVVentaExpress.Infrastructure.Data;

namespace TPVVentaExpress.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Customer GetById(int customerId)
        {
            return _context.Customers.Include(c => c.CustomerSales).FirstOrDefault(c => c.CustomerId == customerId);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }
    }
}
