namespace AlisPark.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xxxx : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tables", "OpeningTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tables", "OpeningTime");
        }
    }
}
