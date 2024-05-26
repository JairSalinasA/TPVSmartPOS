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
                ProductId = 1,
                Name = "Product 1",
                Price = 50,
                Stock = 100,
                Description = "Description for Product 1"
            };

            var product2 = new Product
            {
                ProductId = 2,
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
                CustomerSales = new List<Sale>()
            };

            // Crear una venta
            var sale = new Sale
            {
                Date = DateTime.Now,
                Customer = customer,
                Total = 200,
                SaleDetails = new List<SaleDetail>()
            };

            // Crear detalles de venta
            var saleDetail1 = new SaleDetail
            {
                ProductId = 1,
                Quantity = 2,
                UnitPrice = 50
            };

            var saleDetail2 = new SaleDetail
            {
                ProductId = 2,
                Quantity = 1,
                UnitPrice = 100
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

            // Crear un usuario base para el sistema de inicio de sesión
            var usuarioBase = new User
            {
                Username = "admin",
                Password = "admin123", // ¡Recuerda cambiar esto por una contraseña segura en un entorno real!
                Role = "Administrador"
            };

            context.Users.AddOrUpdate(u => u.Username, usuarioBase);
            context.SaveChanges();
        }
    }
}
