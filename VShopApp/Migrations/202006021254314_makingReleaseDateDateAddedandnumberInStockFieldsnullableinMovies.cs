namespace VShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makingReleaseDateDateAddedandnumberInStockFieldsnullableinMovies : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: true));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: true));
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
        }
    }
}
