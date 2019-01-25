namespace BlissRecruitmentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedKeyColumn : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Choices");
            AddColumn("dbo.Choices", "id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Choices", "choice", c => c.String());
            AddPrimaryKey("dbo.Choices", "id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Choices");
            AlterColumn("dbo.Choices", "choice", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Choices", "id");
            AddPrimaryKey("dbo.Choices", "choice");
        }
    }
}
