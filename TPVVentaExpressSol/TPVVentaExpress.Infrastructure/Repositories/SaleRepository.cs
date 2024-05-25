using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TPVVentaExpress.Domain.Entities;
using TPVVentaExpress.Domain.Interfaces;
using TPVVentaExpress.Infrastructure.Data;

namespace TPVVentaExpress.Infrastructure.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly ApplicationDbContext _context;

        public SaleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Sale GetById(int saleId)
        {
            return _context.Sales.Include(s => s.SaleDetails).FirstOrDefault(s => s.SaleId == saleId);
        }

        public IEnumerable<Sale> GetAll()
        {
            return _context.Sales.Include(s => s.SaleDetails).ToList();
        }

        public void Add(Sale sale)
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();
        }

        public void Update(Sale sale)
        {
            _context.Entry(sale).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int saleId)
        {
            var sale = _context.Sales.Find(saleId);
            if (sale != null)
            {
                _context.Sales.Remove(sale);
                _context.SaveChanges();
            }
        }
    }
}
