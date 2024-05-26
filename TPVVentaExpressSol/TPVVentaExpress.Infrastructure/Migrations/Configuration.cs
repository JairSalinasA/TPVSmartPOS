using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using TPVVentaExpress.Domain.Entities;
using TPVVentaExpress.Domain.ValueObjects;
using TPVVentaExpress.Infrastructure.Data;

namespace TPVVentaExpress.Infrastructure.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            // Crear un cliente
            var customer = new Customer
            {
                Name = "Ejemplo Customer",
                Address = new Address("123 Ejemplo St", "Ejemplo City", "Ejemplo State", "12345"),
                Phone = "123-456-7890"
            };

            // Crear una venta
            var sale = new Sale
            {
                Date = DateTime.Now,
                Total = 100, // Ejemplo de total de venta
                Customer = customer
            };

            // Crear detalles de venta
            var saleDetail1 = new SaleDetail
            {
                ProductId = 1, // ID del producto asociado
                Quantity = 2, // Cantidad comprada
                UnitPrice = 50 // Precio unitario
            };

            var saleDetail2 = new SaleDetail
            {
                ProductId = 2, // ID del producto asociado
                Quantity = 1, // Cantidad comprada
                UnitPrice = 100 // Precio unitario
            };

            // Agregar detalles de venta a la venta
            sale.SaleDetails = new List<SaleDetail> { saleDetail1, saleDetail2 };

            // Agregar la venta al cliente
            customer.CustomerSales = new List<Sale> { sale };

            // Agregar el cliente, la venta y los detalles de venta al contexto
            context.Customers.AddOrUpdate(c => c.Name, customer);

            // Guardar cambios en la base de datos
            context.SaveChanges();
        }


    }
}
