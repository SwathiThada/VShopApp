namespace VShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatemovies : DbMigration
    {
        public override void Up()
        {
            Sql("Set Identity_Insert Movies ON");
            Sql("Insert into Movies(Id,Name,GenreId,ReleaseDate,DateAdded,NumberInStock) Values (1, 'Thappad',2, 01/01/2020, 01/03/2020, 5)");
            Sql("Insert into Movies(Id,Name,GenreId,ReleaseDate,DateAdded,NumberInStock) Values (2, 'Jaanu',4, 10/11/2019, 01/01/2020, 6)");
            Sql("Insert into Movies(Id,Name,GenreId,ReleaseDate,DateAdded,NumberInStock) Values (3, 'F2',1, 04/15/2018, 07/07/2018, 3)");
        }
        
        public override void Down()
        {
        }
    }
}
