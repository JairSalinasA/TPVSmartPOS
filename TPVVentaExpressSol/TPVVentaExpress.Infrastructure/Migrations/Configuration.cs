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
            // Crear productos
            var product1 = new Product
            {
                ProductId = 1, // Asegúrate de que el ProductId coincide con los detalles de ventas
                Name = "Product 1",
                Price = 50,
                Stock = 100,
                Description = "Description for Product 1"
            };

            var product2 = new Product
            {
                ProductId = 2, // Asegúrate de que el ProductId coincide con los detalles de ventas
                Name = "Product 2",
                Price = 100,
                Stock = 50,
                Description = "Description for Product 2"
            };

            // Agregar productos al contexto
            context.Products.AddOrUpdate(p => p.ProductId, product1, product2);

            // Guardar cambios para asegurarse de que los productos existen antes de crear las ventas
            context.SaveChanges();

            // Crear un cliente
            var customer = new Customer
            {
                Name = "Ejemplo Customer",
                Address = new Address("123 Ejemplo St", "Ejemplo City", "Ejemplo State", "12345"),
                Phone = "123-456-7890",
                CustomerSales = new List<Sale>() // Asegúrate de que la propiedad se llama 'Sales'
            };

            // Crear una venta
            var sale = new Sale
            {
                Date = DateTime.Now,
                Customer = customer,
                Total = 200, // Ejemplo de total de venta
                SaleDetails = new List<SaleDetail>()
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
            sale.SaleDetails.Add(saleDetail1);
            sale.SaleDetails.Add(saleDetail2);

            // Agregar la venta al cliente
            customer.CustomerSales.Add(sale);

            // Agregar el cliente, la venta y los detalles de venta al contexto
            context.Customers.AddOrUpdate(c => c.Name, customer);

            // Guardar cambios en la base de datos
            context.SaveChanges();
        }




    }
}
