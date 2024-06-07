namespace AlisPark.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xxx : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TableEvents", "Duration", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TableEvents", "Duration", c => c.Time(precision: 7));
        }
    }
}
