namespace VShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Delete From Movies");
        }
        
        public override void Down()
        {
        }
    }
}
