namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollments", "Notes", c => c.String());
            AddColumn("dbo.Courses", "InstructorName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Enrollments", "Notes");
            DropColumn("dbo.Courses", "InstructorName");
        }
    }
}
