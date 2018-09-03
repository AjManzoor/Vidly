namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipName : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET Name = 'Pay as You Go' WHERE id = 1");
            Sql("Update MembershipTypes SET Name = 'Monthly' WHERE id = 2");
            Sql("Update MembershipTypes SET Name = 'Yearly' WHERE id = 3");
            Sql("Update MembershipTypes SET Name = 'Premium' WHERE id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
