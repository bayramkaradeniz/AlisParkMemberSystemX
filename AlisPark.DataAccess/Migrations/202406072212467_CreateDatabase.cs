namespace AlisPark.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.CompanyUsers",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        CompanyAdminUsername = c.String(maxLength: 30, unicode: false),
                        CompanyAdminPassword = c.String(maxLength: 30, unicode: false),
                        CompanyAdminPhone = c.String(maxLength: 30, unicode: false),
                        CompanyAdminMail = c.String(),
                        AdminFullName = c.String(),
                        BalanceIncreaseRateForVipMember = c.Decimal(precision: 18, scale: 2),
                        BalanceIncreaseRateForMember = c.Decimal(precision: 18, scale: 2),
                        CurrentWorker = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.LogEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Timestamp = c.DateTime(nullable: false),
                        Description = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Member",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        MemberName = c.String(maxLength: 30, unicode: false),
                        MemberSurname = c.String(maxLength: 30, unicode: false),
                        MemberPhone = c.String(maxLength: 20, unicode: false),
                        MemberMail = c.String(),
                        CategoryId = c.Int(nullable: false),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MemberId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderName = c.String(),
                        Description = c.String(),
                        CategoryId = c.Int(nullable: false),
                        CategoryName = c.String(),
                        CategoryDescription = c.String(),
                        ProductStock = c.Int(nullable: false),
                        OrderAmount = c.Int(nullable: false),
                        OrderPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDate = c.DateTime(nullable: false),
                        TableId = c.Int(nullable: false),
                        Delivered = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Tables", t => t.TableId, cascadeDelete: true)
                .Index(t => t.TableId);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TableNumber = c.Int(nullable: false),
                        TableName = c.String(),
                        IsOccupied = c.Boolean(nullable: false),
                        OpeningTime = c.DateTime(),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TableEvents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventTime = c.DateTime(nullable: false),
                        EventDescription = c.String(),
                        OpeningTime = c.DateTime(nullable: false),
                        ClosingTime = c.DateTime(),
                        Duration = c.String(),
                        TableId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tables", t => t.TableId, cascadeDelete: true)
                .Index(t => t.TableId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        StockWarningSent = c.Boolean(nullable: false),
                        ProductDescription = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StockAmount = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.TableCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PriceForHour = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        WorkerId = c.Int(nullable: false, identity: true),
                        WorkerUserName = c.String(maxLength: 50, unicode: false),
                        WorkerPassword = c.String(),
                        WorkerPhone = c.String(),
                    })
                .PrimaryKey(t => t.WorkerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "TableId", "dbo.Tables");
            DropForeignKey("dbo.TableEvents", "TableId", "dbo.Tables");
            DropIndex("dbo.TableEvents", new[] { "TableId" });
            DropIndex("dbo.Orders", new[] { "TableId" });
            DropTable("dbo.Workers");
            DropTable("dbo.TableCategories");
            DropTable("dbo.Products");
            DropTable("dbo.TableEvents");
            DropTable("dbo.Tables");
            DropTable("dbo.Orders");
            DropTable("dbo.Member");
            DropTable("dbo.LogEntries");
            DropTable("dbo.CompanyUsers");
            DropTable("dbo.Category");
        }
    }
}
