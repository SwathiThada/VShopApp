namespace VShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatingMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Set Identity_Insert Movies On");
            Sql("Insert into Movies(Id, Name, GenreId, ReleaseDate, DateAdded, NumberInStock) " +
                "Values (1, 'Thappad',2, '2020-01-01', '2020-02-02', 5)");
            Sql("Insert into Movies(Id, Name, GenreId, ReleaseDate, DateAdded, NumberInStock) " +
                "Values (2, 'Jaanu',4,'2020-02-02','2020-03-03' , 7)");
            Sql("Insert into Movies(Id, Name, GenreId, ReleaseDate, DateAdded, NumberInStock) " +
                "Values (3, 'Krish',3, '2020-04-04','2020-05-05', 6)");
        }
        
        public override void Down()
        {
        }
    }
}
