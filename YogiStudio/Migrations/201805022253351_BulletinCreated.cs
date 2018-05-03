namespace YogiStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BulletinCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bulletins",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Message = c.String(),
                        CommentPosted = c.String(),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bulletins");
        }
    }
}
