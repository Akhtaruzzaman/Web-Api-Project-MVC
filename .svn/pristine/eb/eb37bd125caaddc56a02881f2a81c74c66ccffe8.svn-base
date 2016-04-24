namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.OrderDetails", "OrderId");
            AddForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders", "OrderId");
        }
    }
}
