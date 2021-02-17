namespace Drugstore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MedicinalSubstance_Added_new_OTM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MedicinalSubstances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Drugs", "MedicinalSubstanceId", c => c.Int(nullable: false));
            CreateIndex("dbo.Drugs", "MedicinalSubstanceId");
            AddForeignKey("dbo.Drugs", "MedicinalSubstanceId", "dbo.MedicinalSubstances", "Id", cascadeDelete: true);
            DropColumn("dbo.Drugs", "MedicinalSubstance");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Drugs", "MedicinalSubstance", c => c.String());
            DropForeignKey("dbo.Drugs", "MedicinalSubstanceId", "dbo.MedicinalSubstances");
            DropIndex("dbo.Drugs", new[] { "MedicinalSubstanceId" });
            DropColumn("dbo.Drugs", "MedicinalSubstanceId");
            DropTable("dbo.MedicinalSubstances");
        }
    }
}
