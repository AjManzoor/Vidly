namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBirthdayValues : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers SET Birthday = 2/2/1990 WHERE Name = 'John Smith'");
        }
        
        public override void Down()
        {
        }
    }
}
