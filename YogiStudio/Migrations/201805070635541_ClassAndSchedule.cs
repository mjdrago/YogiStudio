namespace YogiStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClassAndSchedule : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                        ClassDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MasterSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassDetailId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        AppointmentLenghtInMinutes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassDetails", t => t.ClassDetailId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.ClassDetailId)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MasterSchedules", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.MasterSchedules", "ClassDetailId", "dbo.ClassDetails");
            DropIndex("dbo.MasterSchedules", new[] { "CustomerId" });
            DropIndex("dbo.MasterSchedules", new[] { "ClassDetailId" });
            DropTable("dbo.MasterSchedules");
            DropTable("dbo.ClassDetails");
        }
    }
}
