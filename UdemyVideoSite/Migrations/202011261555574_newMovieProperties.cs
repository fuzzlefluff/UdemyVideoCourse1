namespace UdemyVideoSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMovieProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Movies", "DateAdded", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Movies", "Stock", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "Birthdate", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.String());
            DropColumn("dbo.Movies", "Stock");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
