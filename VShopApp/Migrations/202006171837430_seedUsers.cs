namespace VShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4482b03e-6589-4428-bacc-c3f96bd12aea', N'guest@vshop.com', 0, N'ACc6/gm9H5izk3Zqf4zxSGOTGMg0U3eVP3Q4wkbTyT6dFmc6IcABQNYLpZU8YZxOHw==', N'6d3a3701-9033-415e-bc49-f342c85a7b86', NULL, 0, 0, NULL, 1, 0, N'guest@vshop.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5f4e0b1e-8088-4cd0-a856-169493e63f34', N'admin1@vshop.com', 0, N'ALK+avGDSbCfVgnsaXsem+Z8B5R2seQKIAJG4+EgM7yH62d/PKLFzsyHnWbmn49Y9g==', N'2cc95cbb-aa49-4aad-ad26-5c8bd4290fe0', NULL, 0, 0, NULL, 1, 0, N'admin1@vshop.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bc2bc330-e60b-44b5-814e-3ff28504ad24', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5f4e0b1e-8088-4cd0-a856-169493e63f34', N'bc2bc330-e60b-44b5-814e-3ff28504ad24')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
