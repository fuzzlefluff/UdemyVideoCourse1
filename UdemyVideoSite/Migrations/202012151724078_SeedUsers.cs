namespace UdemyVideoSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'06340863-3750-4e7f-9081-954ea7f5bc3a', N'admin@vidly.com', 0, N'AKMxn2NKMf2oHrPMZ2E/Rx4aCPGLqIhYC3TmsJ/92Vtdp4xtLXqY9B1nv8T54yp/0g==', N'c29c5a14-9817-449f-a853-52cd4bfa211d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f0802b14-6fa3-495b-a1a8-aead0ee8d2ec', N'guest@vidly.com', 0, N'ADyHjN2mbeZGRXG3K1dmbAf1kMkkWM6EhvU3fCmSB5kn209uqtZC/QcKK041YkmXGA==', N'10f205b9-9a27-4566-abbd-e87a6b21f848', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e64c16ec-e127-42b0-8cc5-29efc05ad9c3', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'06340863-3750-4e7f-9081-954ea7f5bc3a', N'e64c16ec-e127-42b0-8cc5-29efc05ad9c3')

");
        }
        
        public override void Down()
        {
        }
    }
}
