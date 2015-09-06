namespace WebServiceWalkingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Audios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        File = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Stop_Latitude = c.Double(nullable: false),
                        Stop_Longitude = c.Double(nullable: false),
                        Stop_Altitude = c.Double(nullable: false),
                        Stop_HorizontalAccuracy = c.Double(nullable: false),
                        Stop_VerticalAccuracy = c.Double(nullable: false),
                        Stop_Speed = c.Double(nullable: false),
                        Stop_Course = c.Double(nullable: false),
                        Order = c.Int(nullable: false),
                        AudioInfo_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Audios", t => t.AudioInfo_ID)
                .Index(t => t.AudioInfo_ID);
            
            CreateTable(
                "dbo.Walks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locations", "AudioInfo_ID", "dbo.Audios");
            DropIndex("dbo.Locations", new[] { "AudioInfo_ID" });
            DropTable("dbo.Walks");
            DropTable("dbo.Locations");
            DropTable("dbo.Audios");
        }
    }
}
