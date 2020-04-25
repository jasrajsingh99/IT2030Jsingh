namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "InstructorName", c => c.String());
            AlterColumn("dbo.Courses", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Enrollments", "Grade", c => c.String(nullable: false));
            AlterColumn("dbo.Enrollments", "AssignedCampus", c => c.String(nullable: false));
            AlterColumn("dbo.Enrollments", "EnrollmentSemester", c => c.String(nullable: false));
            AlterColumn("dbo.Enrollments", "EnrollmentYear", c => c.String(nullable: false, maxLength: 3000));
            AlterColumn("dbo.Students", "firstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "lastName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "lastName", c => c.String());
            AlterColumn("dbo.Students", "firstName", c => c.String());
            AlterColumn("dbo.Enrollments", "EnrollmentYear", c => c.Int(nullable: false));
            AlterColumn("dbo.Enrollments", "EnrollmentSemester", c => c.String());
            AlterColumn("dbo.Enrollments", "AssignedCampus", c => c.String());
            AlterColumn("dbo.Enrollments", "Grade", c => c.Double(nullable: false));
            AlterColumn("dbo.Courses", "Title", c => c.String());
            DropColumn("dbo.Courses", "InstructorName");
        }
    }
}
