namespace MVCReviewSiteProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "rating", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "rating");
        }
    }
}
