using System;
using System.Data.Entity.Migrations;

namespace TPVVentaExpress.Infrastructure.Migrations
{
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                {
                    ProductId = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 100),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Stock = c.Int(nullable: false),
                    Description = c.String(maxLength: 500),
                })
                .PrimaryKey(t => t.ProductId);

            CreateTable(
                "dbo.Sales",
                c => new
                {
                    SaleId = c.Int(nullable: false, identity: true),
                    Date = c.DateTime(nullable: false),
                    CustomerId = c.Int(nullable: false),
                    Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.SaleId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);

            CreateTable(
                "dbo.Customers",
                c => new
                {
                    CustomerId = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 100),
                    Street = c.String(maxLength: 200),
                    City = c.String(maxLength: 200),
                    State = c.String(maxLength: 200),
                    PostalCode = c.String(maxLength: 20),
                    Phone = c.String(maxLength: 15),
                })
                .PrimaryKey(t => t.CustomerId);

            CreateTable(
                "dbo.SaleDetails",
                c => new
                {
                    SaleDetailId = c.Int(nullable: false, identity: true),
                    SaleId = c.Int(nullable: false),
                    ProductId = c.Int(nullable: false),
                    Quantity = c.Int(nullable: false),
                    UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.SaleDetailId)
                .ForeignKey("dbo.Sales", t => t.SaleId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.SaleId)
                .Index(t => t.ProductId);

            CreateTable(
                "dbo.Usuarios",
                c => new
                {
                    UsuarioId = c.Int(nullable: false, identity: true),
                    NombreUsuario = c.String(nullable: false, maxLength: 50),
                    Contraseña = c.String(nullable: false, maxLength: 100),
                    Rol = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.UsuarioId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.SaleDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SaleDetails", "SaleId", "dbo.Sales");
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.Customers");
            DropIndex("dbo.SaleDetails", new[] { "ProductId" });
            DropIndex("dbo.SaleDetails", new[] { "SaleId" });
            DropIndex("dbo.Sales", new[] { "CustomerId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.SaleDetails");
            DropTable("dbo.Customers");
            DropTable("dbo.Sales");
            DropTable("dbo.Products");
        }
    }
}
