namespace ProjetGestionStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class add_table_commande : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Revenu_jour", newName: "Revenu");
            CreateTable(
                "dbo.Commande",
                c => new
                {
                    Id_Produit = c.Int(nullable: false),
                    Id_Fournisseur = c.Int(nullable: false),
                    Date_Demande = c.DateTime(nullable: false),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Quantity = c.Int(nullable: false),
                    Date_Arrive = c.DateTime(nullable: false),
                    fourn_Id = c.Int(),
                    prod_Id = c.Int(),
                })
                .PrimaryKey(t => new { t.Id_Produit, t.Id_Fournisseur, t.Date_Demande })
                .ForeignKey("dbo.Fournisseur", t => t.fourn_Id)
                .ForeignKey("dbo.Produit", t => t.prod_Id)
                .Index(t => t.fourn_Id)
                .Index(t => t.prod_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Commande", "prod_Id", "dbo.Produit");
            DropForeignKey("dbo.Commande", "fourn_Id", "dbo.Fournisseur");
            DropIndex("dbo.Commande", new[] { "prod_Id" });
            DropIndex("dbo.Commande", new[] { "fourn_Id" });
            DropTable("dbo.Commande");
            RenameTable(name: "dbo.Revenu", newName: "Revenu_jour");
        }
    }
}
