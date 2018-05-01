namespace YogiStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePaymentAndPackageTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Packages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PackageType = c.String(),
                        PackageCost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DatePurchased = c.DateTime(nullable: false),
                        DatePaymentReceived = c.DateTime(nullable: false),
                        PurchaseTotal = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Payments");
            DropTable("dbo.Packages");
        }
    }
}
