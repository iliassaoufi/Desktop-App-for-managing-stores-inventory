using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProjetGestionStock
{
    public class Model_Gestion_Stock : DbContext
    {

        public Model_Gestion_Stock() : base("name=Model_Gestion_Stock") { }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<Fournisseur> Fournisseurs { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Revenu> Revenus { get; set; }


        [Table("Produit")]
        public class Produit
        {
            [Column("ID")]
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            [MaxLength(500), MinLength(2)]
            [Required]
            public string Name { get; set; }
            [Required]
            public decimal Price { get; set; }
            [Required]
            public int Quantity { get; set; }
            [Required]
            public bool State { get; set; }
            [Column("Expiration Date")]
            [Required]
            public DateTime ExpirationDate { get; set; }
            [Required]
            public byte[] image { get; set; }
            //---------------------------

            public ICollection<Commande> commandes { get; set; }
            public Produit() { commandes = new List<Commande>(); }
        }

        [Table("Fournisseur")]
        public class Fournisseur
        {
            [Column("ID")]
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            [MaxLength(200), MinLength(2)]
            public string Name { get; set; }
            [MaxLength(850), MinLength(2)]
            public string Adresse { get; set; }
            [MaxLength(20), MinLength(2)]
            public string Contact { get; set; }
            //--------------------------------------------
            public ICollection<Commande> commandes { get; set; }
            public Fournisseur() { commandes = new List<Commande>(); }

        }

        [Table("Commande")]
        public class Commande
        {
            [Column("ID")]
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            [ForeignKey("Produit")]
            public int ProduitId { get; set; }

            [ForeignKey("Fournisseur")]
            public int FournisseurId { get; set; }

            public DateTime Date_Demande { get; set; }

            [Required]
            public decimal Price { get; set; }
            [Required]
            public int Quantity { get; set; }
            [Required]
            public DateTime Date_Arrive { get; set; }

            //---------------------------------------------

            public virtual Produit Produit { get; set; }
            public virtual Fournisseur Fournisseur { get; set; }

        }


        [Table("Revenu")]
        public class Revenu
        {
            [Key]
            public DateTime date_jour { get; set; }
            [Required]
            public int Nbr_ventes { get; set; }
            [Required]
            public decimal Gain_jour { get; set; }
            [Required]
            public decimal Perte_jour { get; set; }

        }
    }


}