namespace Drugstore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Precursor_AddnewTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Precursors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameList = c.Int(nullable: false),
                        CountInRecipe = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PrecursorDrugs",
                c => new
                    {
                        Precursor_Id = c.Int(nullable: false),
                        Drug_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Precursor_Id, t.Drug_Id })
                .ForeignKey("dbo.Precursors", t => t.Precursor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Drugs", t => t.Drug_Id, cascadeDelete: true)
                .Index(t => t.Precursor_Id)
                .Index(t => t.Drug_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrecursorDrugs", "Drug_Id", "dbo.Drugs");
            DropForeignKey("dbo.PrecursorDrugs", "Precursor_Id", "dbo.Precursors");
            DropIndex("dbo.PrecursorDrugs", new[] { "Drug_Id" });
            DropIndex("dbo.PrecursorDrugs", new[] { "Precursor_Id" });
            DropTable("dbo.PrecursorDrugs");
            DropTable("dbo.Precursors");
        }
    }
}
