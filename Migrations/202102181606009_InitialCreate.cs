namespace ProjetGestionStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fournisseur",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 200),
                        Adresse = c.String(maxLength: 850),
                        Contact = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Produit",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        State = c.Boolean(nullable: false),
                        ExpirationDate = c.DateTime(name: "Expiration Date", nullable: false),
                        image = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Revenu_jour",
                c => new
                    {
                        date_jour = c.DateTime(nullable: false),
                        Nbr_ventes = c.Int(nullable: false),
                        Gain_jour = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Perte_jour = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.date_jour);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Revenu_jour");
            DropTable("dbo.Produit");
            DropTable("dbo.Fournisseur");
        }
    }
}
