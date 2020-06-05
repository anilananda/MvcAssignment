namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class afterModifyOrderTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "product_ProductId", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "product_ProductId" });
            RenameColumn(table: "dbo.Orders", name: "product_ProductId", newName: "ProductId");
            DropPrimaryKey("dbo.Orders");
            AddColumn("dbo.Orders", "Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Orders", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "name", c => c.String());
            AlterColumn("dbo.Orders", "Address", c => c.String());
            AlterColumn("dbo.Orders", "ProductId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Orders", "Id");
            CreateIndex("dbo.Orders", "ProductId");
            AddForeignKey("dbo.Orders", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
            DropColumn("dbo.Orders", "OrderId");
            DropColumn("dbo.Orders", "Customer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Customer", c => c.String());
            AddColumn("dbo.Orders", "OrderId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Orders", "ProductId", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "ProductId" });
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "ProductId", c => c.Int());
            AlterColumn("dbo.Orders", "Address", c => c.String(maxLength: 350));
            DropColumn("dbo.Orders", "name");
            DropColumn("dbo.Orders", "Quantity");
            DropColumn("dbo.Orders", "Id");
            AddPrimaryKey("dbo.Orders", "OrderId");
            RenameColumn(table: "dbo.Orders", name: "ProductId", newName: "product_ProductId");
            CreateIndex("dbo.Orders", "product_ProductId");
            AddForeignKey("dbo.Orders", "product_ProductId", "dbo.Products", "ProductId");
        }
    }
}
