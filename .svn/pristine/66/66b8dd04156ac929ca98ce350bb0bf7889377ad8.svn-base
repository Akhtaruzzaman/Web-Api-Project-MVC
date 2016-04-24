namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderNo = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderItemId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ItemName = c.String(),
                        Quantity = c.Int(nullable: false),
                        Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderItemId)
                .ForeignKey("dbo.Orders", t => t.OrderId)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
        }
    }
}
