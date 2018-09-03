namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateToGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes (Name) Values ('Comedy')");
            Sql("INSERT INTO GenreTypes (Name) Values ('Action')");
            Sql("INSERT INTO GenreTypes (Name) Values ('Drama')");
            Sql("INSERT INTO GenreTypes (Name) Values ('Animation')");
        }
        
        public override void Down()
        {
        }
    }
}
