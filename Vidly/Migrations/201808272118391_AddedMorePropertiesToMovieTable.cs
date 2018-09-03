namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMorePropertiesToMovieTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String());
            AddColumn("dbo.Movies", "ReleasedDate", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.Movies", "Stock", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Stock");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "ReleasedDate");
            DropColumn("dbo.Movies", "Genre");
        }
    }
}
