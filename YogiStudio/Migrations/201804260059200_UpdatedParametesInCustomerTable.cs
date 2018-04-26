namespace YogiStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedParametesInCustomerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false, maxLength: 8000, unicode: false));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false, maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            DropColumn("dbo.Customers", "DateOfBirth");
        }
    }
}
