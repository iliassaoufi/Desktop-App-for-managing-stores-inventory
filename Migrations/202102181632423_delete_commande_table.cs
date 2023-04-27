namespace ProjetGestionStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delete_commande_table : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Commande", "fourn_Id", "dbo.Fournisseur");
            DropForeignKey("dbo.Commande", "prod_Id", "dbo.Produit");
            DropIndex("dbo.Commande", new[] { "fourn_Id" });
            DropIndex("dbo.Commande", new[] { "prod_Id" });
            DropTable("dbo.Commande");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => new { t.Id_Produit, t.Id_Fournisseur, t.Date_Demande });
            
            CreateIndex("dbo.Commande", "prod_Id");
            CreateIndex("dbo.Commande", "fourn_Id");
            AddForeignKey("dbo.Commande", "prod_Id", "dbo.Produit", "ID");
            AddForeignKey("dbo.Commande", "fourn_Id", "dbo.Fournisseur", "ID");
        }
    }
}
