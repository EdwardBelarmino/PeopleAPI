namespace PeopleAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Age", c => c.Int());
            AlterColumn("dbo.People", "Number", c => c.Int());
            AlterColumn("dbo.People", "Temperature", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Temperature", c => c.Int(nullable: false));
            AlterColumn("dbo.People", "Number", c => c.Int(nullable: false));
            AlterColumn("dbo.People", "Age", c => c.Int(nullable: false));
        }
    }
}
