namespace CompileError.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAll : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                        LoyalityPoint = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Code = c.String(),
                        Name = c.String(),
                        ReorderLevel = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PurchasedProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PurchaseId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        ManufactureDate = c.String(),
                        ExpireDate = c.String(),
                        Quantity = c.Double(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        Mrp = c.Double(nullable: false),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductModels", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Purchases", t => t.PurchaseId, cascadeDelete: true)
                .Index(t => t.PurchaseId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BillNo = c.String(),
                        SupplierId = c.Int(nullable: false),
                        Date = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        Date = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalesDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductCode = c.String(),
                        Quantity = c.Int(nullable: false),
                        MRP = c.Double(nullable: false),
                        TotalMRP = c.Double(nullable: false),
                        SaleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sales", t => t.SaleId, cascadeDelete: true)
                .Index(t => t.SaleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesDetails", "SaleId", "dbo.Sales");
            DropForeignKey("dbo.PurchasedProducts", "PurchaseId", "dbo.Purchases");
            DropForeignKey("dbo.PurchasedProducts", "ProductId", "dbo.ProductModels");
            DropIndex("dbo.SalesDetails", new[] { "SaleId" });
            DropIndex("dbo.PurchasedProducts", new[] { "ProductId" });
            DropIndex("dbo.PurchasedProducts", new[] { "PurchaseId" });
            DropTable("dbo.SalesDetails");
            DropTable("dbo.Sales");
            DropTable("dbo.Purchases");
            DropTable("dbo.PurchasedProducts");
            DropTable("dbo.ProductModels");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
        }
    }
}
