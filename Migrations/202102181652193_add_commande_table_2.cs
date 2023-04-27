namespace ProjetGestionStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_commande_table_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commande",
                c => new
                    {
                        ProduitId = c.Int(nullable: false),
                        FournisseurId = c.Int(nullable: false),
                        Date_Demande = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        Date_Arrive = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Date_Demande)
                .ForeignKey("dbo.Fournisseur", t => t.FournisseurId, cascadeDelete: true)
                .ForeignKey("dbo.Produit", t => t.ProduitId, cascadeDelete: true)
                .Index(t => t.ProduitId)
                .Index(t => t.FournisseurId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Commande", "ProduitId", "dbo.Produit");
            DropForeignKey("dbo.Commande", "FournisseurId", "dbo.Fournisseur");
            DropIndex("dbo.Commande", new[] { "FournisseurId" });
            DropIndex("dbo.Commande", new[] { "ProduitId" });
            DropTable("dbo.Commande");
        }
    }
}
