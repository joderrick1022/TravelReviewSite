namespace TravelReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Location : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Location");
        }
    }
}
