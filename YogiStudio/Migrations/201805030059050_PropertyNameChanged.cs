namespace YogiStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertyNameChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bulletins", "Comment", c => c.String());
            DropColumn("dbo.Bulletins", "CommentPosted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bulletins", "CommentPosted", c => c.String());
            DropColumn("dbo.Bulletins", "Comment");
        }
    }
}
