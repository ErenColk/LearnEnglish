namespace LearnEnglish.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EnglishWords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Word = c.String(),
                        Sentence = c.String(),
                        TurkishWord_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TurkishWords", t => t.TurkishWord_Id)
                .Index(t => t.TurkishWord_Id);
            
            CreateTable(
                "dbo.TurkishWords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Word = c.String(),
                        Sentence = c.String(),
                        Pronunciation = c.String(),
                        EnglishWordId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EnglishWords", t => t.EnglishWordId)
                .Index(t => t.EnglishWordId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EnglishWords", "TurkishWord_Id", "dbo.TurkishWords");
            DropForeignKey("dbo.TurkishWords", "EnglishWordId", "dbo.EnglishWords");
            DropIndex("dbo.TurkishWords", new[] { "EnglishWordId" });
            DropIndex("dbo.EnglishWords", new[] { "TurkishWord_Id" });
            DropTable("dbo.TurkishWords");
            DropTable("dbo.EnglishWords");
        }
    }
}
