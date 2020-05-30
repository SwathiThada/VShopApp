namespace VShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatingGenres : DbMigration
    {
        public override void Up()
        {
            Sql("Set Identity_Insert Genres ON");
            Sql("Insert into Genres(Id, Name) Values(1,'Comedy')");
            Sql("Insert into Genres(Id, Name) Values(2,'Action')");
            Sql("Insert into Genres(Id, Name) Values(3,'Fiction')");
            Sql("Insert into Genres(Id, Name) Values(4,'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
