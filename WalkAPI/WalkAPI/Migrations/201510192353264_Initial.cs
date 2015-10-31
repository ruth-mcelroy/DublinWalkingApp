namespace WalkAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Locations", "AudioInfo_AudioID");
            DropColumn("dbo.Locations", "WalkInfo_WalkID");
        }
        
        public override void Down()
        {

        }
    }
}
