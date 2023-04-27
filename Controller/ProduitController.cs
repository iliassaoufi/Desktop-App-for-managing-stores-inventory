using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetGestionStock.Model_Gestion_Stock;

namespace ProjetGestionStock.Controller
{
    class ProduitController
    {
        public ProduitController() { }

        public void ajouterProduit(string name, string prix, string quantity, string date, Image img)
        {
            using (var db = new Model_Gestion_Stock())
            {
                bool b = false;
                try
                {
                    Produit p = new Produit
                    {
                        Name = name,
                        Price = Convert.ToDecimal(prix),
                        Quantity = Convert.ToInt32(quantity),
                        ExpirationDate = Convert.ToDateTime(date),
                        State = Convert.ToInt32(quantity) > 0 ? true : false,
                        image = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]))
                    };

                    db.Produits.Add(p);
                    db.SaveChanges();
                    b = true;
                }
                catch (Exception e)
                {
                }
                if (b)
                    MessageBox.Show("le produit est ajouté !");
                else
                    MessageBox.Show("le produit n'est pas ajouté !");


            }
        }
        public List<Produit> getAllProduct()
        {
            using (var db = new Model_Gestion_Stock())
            {
                var listProd = from p in db.Produits select p;
                return listProd.ToList();
            }
        }
        public List<string> getAllProductName()
        {
            using (var db = new Model_Gestion_Stock())
            {
                var listProd = from p in db.Produits select p.Name;
                return listProd.ToList();
            }
        }
        public List<Produit> getDispoProduct()
        {
            using (var db = new Model_Gestion_Stock())
            {
                var listProd = from p in db.Produits
                               where p.State == true
                               select p;
                return listProd.ToList();
            }
        }
        public List<Produit> getNonDispoProduct()
        {
            using (var db = new Model_Gestion_Stock())
            {
                var listProd = from p in db.Produits
                               where p.State == false
                               select p;
                return listProd.ToList();
            }
        }
        public List<Produit> getProductDestocker()
        {
            using (var db = new Model_Gestion_Stock())
            {
                var listProd = from p in db.Produits
                               where DateTime.Compare(p.ExpirationDate, DateTime.Now) < 0 && p.Quantity > 0
                               select p;
                return listProd.ToList();
            }
        }
        public Produit getById(int id)
        {
            using (var db = new Model_Gestion_Stock())
            {
                Produit prod = db.Produits.FirstOrDefault(p => p.Id == id);
                return (Produit)prod;
            }
        }
        public Produit getByName(string name)
        {
            using (var db = new Model_Gestion_Stock())
            {
                Produit prod = db.Produits.FirstOrDefault(p => p.Name.Equals(name));
                return (Produit)prod;
            }
        }


    }
}


/*
  var img = Image.FromFile(imgURL);
ImageData = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));
pictureBoxProduit.Image = (Bitmap)((new ImageConverter()).ConvertFrom(ImageData));
*/