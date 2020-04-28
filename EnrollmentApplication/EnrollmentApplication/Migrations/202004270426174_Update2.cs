namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollments", "Notes", c => c.String());
            AddColumn("dbo.Students", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Age");
            DropColumn("dbo.Enrollments", "Notes");
        }
    }
}
