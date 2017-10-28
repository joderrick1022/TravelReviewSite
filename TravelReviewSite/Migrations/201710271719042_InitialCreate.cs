namespace TravelReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Pros = c.String(),
                        Cons = c.String(),
                        Cost = c.Double(nullable: false),
                        IsRecommended = c.Boolean(nullable: false),
                        CatagoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CatagoryID, cascadeDelete: true)
                .Index(t => t.CatagoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "CatagoryID", "dbo.Categories");
            DropIndex("dbo.Reviews", new[] { "CatagoryID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Categories");
        }
    }
}
