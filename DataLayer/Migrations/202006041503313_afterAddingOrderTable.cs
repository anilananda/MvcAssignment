namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class afterAddingOrderTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        Customer = c.String(),
                        Address = c.String(maxLength: 350),
                        Email = c.String(),
                        product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Products", t => t.product_ProductId)
                .Index(t => t.product_ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "product_ProductId", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "product_ProductId" });
            DropTable("dbo.Orders");
        }
    }
}
