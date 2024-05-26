namespace TPVVentaExpress.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracionini : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.Customers");
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                        Role = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.UserId);
            
            AlterColumn("dbo.Customers", "Phone", c => c.String(maxLength: 15));
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddForeignKey("dbo.Sales", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.Customers");
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 10, scale: 2));
            AlterColumn("dbo.Customers", "Phone", c => c.String());
            DropTable("dbo.Users");
            AddForeignKey("dbo.Sales", "CustomerId", "dbo.Customers", "CustomerId");
        }
    }
}
