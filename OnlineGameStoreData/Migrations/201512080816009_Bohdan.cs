namespace OnlineGameStoreData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bohdan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CommentEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Body = c.String(),
                        ParentId = c.Int(),
                        GameKey = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GameEntities", t => t.GameKey)
                .Index(t => t.GameKey);
            
            CreateTable(
                "dbo.GameEntities",
                c => new
                    {
                        Key = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Key);
            
            CreateTable(
                "dbo.GenreEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Genre = c.String(),
                        ParentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlatformTypeEntities",
                c => new
                    {
                        Type = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Type);
            
            CreateTable(
                "dbo.GenreEntityGameEntities",
                c => new
                    {
                        GenreEntity_Id = c.Int(nullable: false),
                        GameEntity_Key = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.GenreEntity_Id, t.GameEntity_Key })
                .ForeignKey("dbo.GenreEntities", t => t.GenreEntity_Id, cascadeDelete: true)
                .ForeignKey("dbo.GameEntities", t => t.GameEntity_Key, cascadeDelete: true)
                .Index(t => t.GenreEntity_Id)
                .Index(t => t.GameEntity_Key);
            
            CreateTable(
                "dbo.PlatformTypeEntityGameEntities",
                c => new
                    {
                        PlatformTypeEntity_Type = c.String(nullable: false, maxLength: 128),
                        GameEntity_Key = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.PlatformTypeEntity_Type, t.GameEntity_Key })
                .ForeignKey("dbo.PlatformTypeEntities", t => t.PlatformTypeEntity_Type, cascadeDelete: true)
                .ForeignKey("dbo.GameEntities", t => t.GameEntity_Key, cascadeDelete: true)
                .Index(t => t.PlatformTypeEntity_Type)
                .Index(t => t.GameEntity_Key);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlatformTypeEntityGameEntities", "GameEntity_Key", "dbo.GameEntities");
            DropForeignKey("dbo.PlatformTypeEntityGameEntities", "PlatformTypeEntity_Type", "dbo.PlatformTypeEntities");
            DropForeignKey("dbo.GenreEntityGameEntities", "GameEntity_Key", "dbo.GameEntities");
            DropForeignKey("dbo.GenreEntityGameEntities", "GenreEntity_Id", "dbo.GenreEntities");
            DropForeignKey("dbo.CommentEntities", "GameKey", "dbo.GameEntities");
            DropIndex("dbo.PlatformTypeEntityGameEntities", new[] { "GameEntity_Key" });
            DropIndex("dbo.PlatformTypeEntityGameEntities", new[] { "PlatformTypeEntity_Type" });
            DropIndex("dbo.GenreEntityGameEntities", new[] { "GameEntity_Key" });
            DropIndex("dbo.GenreEntityGameEntities", new[] { "GenreEntity_Id" });
            DropIndex("dbo.CommentEntities", new[] { "GameKey" });
            DropTable("dbo.PlatformTypeEntityGameEntities");
            DropTable("dbo.GenreEntityGameEntities");
            DropTable("dbo.PlatformTypeEntities");
            DropTable("dbo.GenreEntities");
            DropTable("dbo.GameEntities");
            DropTable("dbo.CommentEntities");
        }
    }
}
