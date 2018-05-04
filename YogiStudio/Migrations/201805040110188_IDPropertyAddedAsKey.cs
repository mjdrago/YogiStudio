namespace YogiStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IDPropertyAddedAsKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Bulletins");
            AddColumn("dbo.Bulletins", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Bulletins", "Name", c => c.String());
            AddPrimaryKey("dbo.Bulletins", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Bulletins");
            AlterColumn("dbo.Bulletins", "Name", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Bulletins", "ID");
            AddPrimaryKey("dbo.Bulletins", "Name");
        }
    }
}
