namespace TechMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        birthday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhoneID = c.Int(nullable: false, identity: true),
                        brand = c.String(),
                        model = c.String(),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneID);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Available = c.Boolean(nullable: false),
                        PhoneID = c.Int(nullable: false),
                        SerialNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Phones", t => t.PhoneID, cascadeDelete: true)
                .Index(t => t.PhoneID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "PhoneID", "dbo.Phones");
            DropIndex("dbo.Stocks", new[] { "PhoneID" });
            DropTable("dbo.Stocks");
            DropTable("dbo.Phones");
            DropTable("dbo.Customers");
        }
    }
}
