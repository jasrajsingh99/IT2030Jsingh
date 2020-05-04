namespace EventApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventTypes", "EventName", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.EventTypes", "TypeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EventTypes", "TypeName", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.EventTypes", "EventName");
        }
    }
}
