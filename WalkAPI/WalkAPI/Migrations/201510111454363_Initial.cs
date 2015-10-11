namespace WebServiceWalkingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Locations", "AudioInfo_ID", "dbo.Audios");
            RenameColumn(table: "dbo.Locations", name: "AudioInfo_ID", newName: "AudioInfo_AudioID");
            RenameIndex(table: "dbo.Locations", name: "IX_AudioInfo_ID", newName: "IX_AudioInfo_AudioID");
            DropPrimaryKey("dbo.Audios");
            DropPrimaryKey("dbo.Locations");
            DropPrimaryKey("dbo.Walks");
            AddColumn("dbo.Audios", "AudioID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Locations", "LocationID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Walks", "WalkID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Walks", "Name", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Audios", "AudioID");
            AddPrimaryKey("dbo.Locations", "LocationID");
            AddPrimaryKey("dbo.Walks", "WalkID");
            AddForeignKey("dbo.Locations", "AudioInfo_AudioID", "dbo.Audios", "AudioID");
            DropColumn("dbo.Audios", "ID");
            DropColumn("dbo.Locations", "ID");
            DropColumn("dbo.Walks", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Walks", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Locations", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Audios", "ID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Locations", "AudioInfo_AudioID", "dbo.Audios");
            DropPrimaryKey("dbo.Walks");
            DropPrimaryKey("dbo.Locations");
            DropPrimaryKey("dbo.Audios");
            AlterColumn("dbo.Walks", "Name", c => c.String());
            DropColumn("dbo.Walks", "WalkID");
            DropColumn("dbo.Locations", "LocationID");
            DropColumn("dbo.Audios", "AudioID");
            AddPrimaryKey("dbo.Walks", "ID");
            AddPrimaryKey("dbo.Locations", "ID");
            AddPrimaryKey("dbo.Audios", "ID");
            RenameIndex(table: "dbo.Locations", name: "IX_AudioInfo_AudioID", newName: "IX_AudioInfo_ID");
            RenameColumn(table: "dbo.Locations", name: "AudioInfo_AudioID", newName: "AudioInfo_ID");
            AddForeignKey("dbo.Locations", "AudioInfo_ID", "dbo.Audios", "ID");
        }
    }
}
