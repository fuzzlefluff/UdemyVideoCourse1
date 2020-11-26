namespace UdemyVideoSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id,Name) VALUES (1,'No Genre')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (2,'Action')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (3,'Comedy')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (4,'Family')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (5,'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
