namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "State", c => c.String(maxLength: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "State", c => c.String());
        }
    }
}
