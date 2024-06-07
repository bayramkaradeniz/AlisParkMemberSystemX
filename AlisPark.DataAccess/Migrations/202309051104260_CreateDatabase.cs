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
                        AdminFullName = c.String(),
                        BalanceIncreaseRateForVipMember = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BalanceIncreaseRateForMember = c.Decimal(nullable: false, precision: 18, scale: 2),
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
                        CategoryId = c.Int(nullable: false),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MemberId);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        WorkerId = c.Int(nullable: false, identity: true),
                        WorkerUserName = c.String(maxLength: 50, unicode: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.WorkerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Workers");
            DropTable("dbo.Member");
            DropTable("dbo.LogEntries");
            DropTable("dbo.CompanyUsers");
            DropTable("dbo.Category");
        }
    }
}
