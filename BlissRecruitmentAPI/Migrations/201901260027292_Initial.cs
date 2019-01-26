namespace BlissRecruitmentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        question = c.String(),
                        image_url = c.String(),
                        thumb_url = c.String(),
                        published_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Choices",
                c => new
                    {
                        questionId = c.Int(nullable: false),
                        choice = c.String(nullable: false, maxLength: 128),
                        votes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.questionId, t.choice })
                .ForeignKey("dbo.Questions", t => t.questionId, cascadeDelete: true)
                .Index(t => t.questionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Choices", "questionId", "dbo.Questions");
            DropIndex("dbo.Choices", new[] { "questionId" });
            DropTable("dbo.Choices");
            DropTable("dbo.Questions");
        }
    }
}
