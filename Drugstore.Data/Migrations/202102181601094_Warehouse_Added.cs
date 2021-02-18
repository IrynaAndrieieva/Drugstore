namespace Drugstore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Warehouse_Added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Conditions = c.String(),
                        NumberShelf = c.Int(nullable: false),
                        MedicinalSubstanceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MedicinalSubstances", "WarehouseId", c => c.Int(nullable: true, identity: false));
            CreateIndex("dbo.MedicinalSubstances", "WarehouseId");
            AddForeignKey("dbo.MedicinalSubstances", "WarehouseId", "dbo.Warehouses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MedicinalSubstances", "WarehouseId", "dbo.Warehouses");
            DropIndex("dbo.MedicinalSubstances", new[] { "WarehouseId" });
            DropColumn("dbo.MedicinalSubstances", "WarehouseId");
            DropTable("dbo.Warehouses");
        }
    }
}
