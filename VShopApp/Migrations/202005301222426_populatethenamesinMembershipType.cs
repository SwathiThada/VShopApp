namespace VShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatethenamesinMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes Set Name = 'PayAsUGo' Where Id = 1");
            Sql("UPDATE MembershipTypes Set Name = 'Monthly' Where Id = 2");
            Sql("UPDATE MembershipTypes Set Name = 'Quarterly' Where Id = 3");
            Sql("UPDATE MembershipTypes Set Name = 'Yearly' Where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
