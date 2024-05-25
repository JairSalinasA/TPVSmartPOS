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
                    Address = c.String(),
                    Phone = c.String(),
                })
                .PrimaryKey(t => t.CustomerId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Sales", new[] { "CustomerId" });
            DropTable("dbo.Customers");
            DropTable("dbo.Sales");
            DropTable("dbo.Products");
        }
    }
}
