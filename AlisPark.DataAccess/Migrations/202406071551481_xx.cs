namespace AlisPark.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xx : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TableEvents", "Duration", c => c.Time(precision: 7));
            AlterColumn("dbo.TableEvents", "ClosingTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TableEvents", "ClosingTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.TableEvents", "Duration");
        }
    }
}
