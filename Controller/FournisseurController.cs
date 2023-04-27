using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetGestionStock.Model_Gestion_Stock;

namespace ProjetGestionStock.Controller
{
    class FournisseurController
    {
        public FournisseurController() { }

        public void AddFournisseur(string name, string addesse, string contact)
        {
            using (var db = new Model_Gestion_Stock())
            {
                Fournisseur f = new Fournisseur()
                {
                    Name = name,
                    Adresse = addesse,
                    Contact = contact

                };

                db.Fournisseurs.Add(f);
                db.SaveChanges();
            }
        }

        public List<Fournisseur> getAllFourn()
        {
            using (var db = new Model_Gestion_Stock())
            {
                var listFourn = from f in db.Fournisseurs select f;

                return listFourn.ToList();
            }
        }
        public List<string> getAllFournName()
        {
            using (var db = new Model_Gestion_Stock())
            {
                var listFourn = from f in db.Fournisseurs select f.Name;

                return listFourn.ToList();
            }
        }

        public Fournisseur getById(int id)
        {
            using (var db = new Model_Gestion_Stock())
            {
                Fournisseur four = db.Fournisseurs.FirstOrDefault(f => f.Id == id);
                return (Fournisseur)four;
            }
        }
        public Fournisseur getByName(string name)
        {
            using (var db = new Model_Gestion_Stock())
            {
                Fournisseur four = db.Fournisseurs.FirstOrDefault(f => f.Name.Equals(name));
                return (Fournisseur)four;
            }
        }
        public int getNbrCommande()
        {
            using (var db = new Model_Gestion_Stock())
            {
                int nbr = db.Commandes.Count();
                return nbr;
            }
        }
        public string jour_NbrCommande(DateTime date)
        {
            using (var db = new Model_Gestion_Stock())
            {

                var nbrComm = from r in db.Commandes
                              where r.Date_Demande.Year == date.Year &&
                                    r.Date_Demande.Month == date.Month &&
                                    r.Date_Demande.Day == date.Day
                              select r;
                return nbrComm.Count().ToString();
            }
        }
        public string mois_NbrCommande(DateTime date)
        {
            using (var db = new Model_Gestion_Stock())
            {

                var nbrComm = from r in db.Commandes
                              where r.Date_Demande.Year == date.Year &&
                                    r.Date_Demande.Month == date.Month
                              select r;
                return nbrComm.Count().ToString();
            }
        }
        public string getPrixTotalCommande()
        {
            using (var db = new Model_Gestion_Stock())
            {
                try
                {
                    decimal prix = db.Commandes.Sum(c => c.Price * c.Quantity);
                    return prix.ToString();
                }
                catch (Exception e)
                {
                }
                return "0,0";

            }
        }

        internal void AddFournisseur()
        {
            throw new NotImplementedException();
        }

        public void commander(int prodId, int fournId, string prix, string quantity, string date)
        {
            using (var db = new Model_Gestion_Stock())
            {
                bool b = false;
                try
                {
                    Commande c = new Commande
                    {
                        ProduitId = prodId,
                        FournisseurId = fournId,
                        Price = Convert.ToDecimal(prix),
                        Quantity = Convert.ToInt32(quantity),
                        Date_Demande = DateTime.Now,
                        Date_Arrive = Convert.ToDateTime(date),

                    };

                    db.Commandes.Add(c);
                    db.SaveChanges();
                    b = true;
                }
                catch (Exception e)
                {
                }
                if (b)
                    MessageBox.Show("le commande est ajouté !");
                else
                    MessageBox.Show("le commande n'est pas ajouté !");


            }
        }
        public List<Commande> getAllCommande()
        {
            using (var db = new Model_Gestion_Stock())
            {
                var listCommand = from c in db.Commandes select c;

                return listCommand.ToList();
            }
        }



    }
}
