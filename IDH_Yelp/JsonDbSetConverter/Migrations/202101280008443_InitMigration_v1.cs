namespace JsonDbSetConverter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration_v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attributes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusinessAcceptsCreditCards = c.String(),
                        BikeParking = c.String(),
                        GoodForKids = c.String(),
                        BusinessParking = c.String(),
                        ByAppointmentOnly = c.String(),
                        RestaurantsPriceRange2 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Business",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        business_id = c.String(),
                        name = c.String(),
                        address = c.String(),
                        city = c.String(),
                        state = c.String(),
                        postal_code = c.String(),
                        latitude = c.Double(nullable: false),
                        longitude = c.Double(nullable: false),
                        stars = c.Double(nullable: false),
                        review_count = c.Int(nullable: false),
                        is_open = c.Int(nullable: false),
                        categories = c.String(),
                        attributes_Id = c.Int(),
                        hours_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Attributes", t => t.attributes_Id)
                .ForeignKey("dbo.Hours", t => t.hours_Id)
                .Index(t => t.attributes_Id)
                .Index(t => t.hours_Id);
            
            CreateTable(
                "dbo.Hours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Monday = c.String(),
                        Tuesday = c.String(),
                        Wednesday = c.String(),
                        Thursday = c.String(),
                        Friday = c.String(),
                        Saturday = c.String(),
                        Sunday = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CheckIn",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        business_id = c.String(),
                        date = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Review",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        review_id = c.String(),
                        user_id = c.String(),
                        business_id = c.String(),
                        stars = c.Double(nullable: false),
                        useful = c.Int(nullable: false),
                        funny = c.Int(nullable: false),
                        cool = c.Int(nullable: false),
                        text = c.String(),
                        date = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tip",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        user_id = c.String(),
                        business_id = c.String(),
                        text = c.String(),
                        date = c.String(),
                        compliment_count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        user_id = c.String(),
                        name = c.String(),
                        review_count = c.Int(nullable: false),
                        yelping_since = c.String(),
                        useful = c.Int(nullable: false),
                        funny = c.Int(nullable: false),
                        cool = c.Int(nullable: false),
                        elite = c.String(),
                        friends = c.String(),
                        fans = c.Int(nullable: false),
                        average_stars = c.Double(nullable: false),
                        compliment_hot = c.Int(nullable: false),
                        compliment_more = c.Int(nullable: false),
                        compliment_profile = c.Int(nullable: false),
                        compliment_cute = c.Int(nullable: false),
                        compliment_list = c.Int(nullable: false),
                        compliment_note = c.Int(nullable: false),
                        compliment_plain = c.Int(nullable: false),
                        compliment_cool = c.Int(nullable: false),
                        compliment_funny = c.Int(nullable: false),
                        compliment_writer = c.Int(nullable: false),
                        compliment_photos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Business", "hours_Id", "dbo.Hours");
            DropForeignKey("dbo.Business", "attributes_Id", "dbo.Attributes");
            DropIndex("dbo.Business", new[] { "hours_Id" });
            DropIndex("dbo.Business", new[] { "attributes_Id" });
            DropTable("dbo.User");
            DropTable("dbo.Tip");
            DropTable("dbo.Review");
            DropTable("dbo.CheckIn");
            DropTable("dbo.Hours");
            DropTable("dbo.Business");
            DropTable("dbo.Attributes");
        }
    }
}
