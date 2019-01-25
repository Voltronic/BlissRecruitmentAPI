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
                        choice = c.String(nullable: false, maxLength: 128),
                        votes = c.Int(nullable: false),
                        Question_id = c.Int(),
                    })
                .PrimaryKey(t => t.choice)
                .ForeignKey("dbo.Questions", t => t.Question_id)
                .Index(t => t.Question_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Choices", "Question_id", "dbo.Questions");
            DropIndex("dbo.Choices", new[] { "Question_id" });
            DropTable("dbo.Choices");
            DropTable("dbo.Questions");
        }
    }
}
