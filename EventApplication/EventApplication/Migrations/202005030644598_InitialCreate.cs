namespace EventApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 150),
                        StartDate = c.DateTime(nullable: false),
                        StartTime = c.String(),
                        EndDate = c.DateTime(nullable: false),
                        EndTime = c.String(),
                        Location = c.String(),
                        OrganizerName = c.String(),
                        Number = c.String(),
                        MaxTickets = c.Int(nullable: false),
                        TicketsAvailable = c.Int(nullable: false),
                        EventType_EventTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.EventId)
                .ForeignKey("dbo.EventTypes", t => t.EventType_EventTypeId)
                .Index(t => t.EventType_EventTypeId);
            
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        EventTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.EventTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "EventType_EventTypeId", "dbo.EventTypes");
            DropIndex("dbo.Events", new[] { "EventType_EventTypeId" });
            DropTable("dbo.EventTypes");
            DropTable("dbo.Events");
        }
    }
}
