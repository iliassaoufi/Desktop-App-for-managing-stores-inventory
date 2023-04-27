namespace ProjetGestionStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class delete_table_commande_2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Commande", "FournisseurId", "dbo.Fournisseur");
            DropForeignKey("dbo.Commande", "ProduitId", "dbo.Produit");
            DropIndex("dbo.Commande", new[] { "ProduitId" });
            DropIndex("dbo.Commande", new[] { "FournisseurId" });
            DropTable("dbo.Commande");
        }

        public override void Down()
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
                .PrimaryKey(t => t.Date_Demande);

            CreateIndex("dbo.Commande", "FournisseurId");
            CreateIndex("dbo.Commande", "ProduitId");
            AddForeignKey("dbo.Commande", "ProduitId", "dbo.Produit", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Commande", "FournisseurId", "dbo.Fournisseur", "ID", cascadeDelete: true);
        }
    }
}
