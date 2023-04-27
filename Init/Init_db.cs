using ProjetGestionStock.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionStock.Init
{
    class Init_db
    {
        FournisseurController f = new FournisseurController();

        ProduitController p = new ProduitController();

        StatistiqueController r = new StatistiqueController();

        public Init_db()
        {

        }
        private bool check_Db_empty()
        {
            using (var db = new Model_Gestion_Stock())
            {
                //  var p = db.Produits.FirstOrDefault();

                if (true)

                    return true;
                else

                    MessageBox.Show("non vide");
                return false;

            }
        }

        public void uploadDb()
        {
            if (check_Db_empty())
            {
                this.UploalProduct();
                this.UploalFourn();
                this.UploalCommande();
                this.UploalRevenu();
            }

        }
        private void UploalProduct()
        {

            p.ajouterProduit("NŒUD MULES À TALONS",
                "90,20",
                "20",
                "15-9-2021",
                Image.FromFile(System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Init\img\2.jpg")
                );
            p.ajouterProduit("CUIR ",
                "1090,20",
                "0",
                "5-7-2023",
                Image.FromFile(System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Init\img\1.jpg")
                );
            p.ajouterProduit("RACCOURCI TOP",
               "120",
               "50",
               "4-11-2022",
               Image.FromFile(System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Init\img\3.jpg")
               );

            p.ajouterProduit("LONGUE ÉCHARPE",
               "90,20",
               "12",
               "27-3-2021",
               Image.FromFile(System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Init\img\4.jpg")
               );
            p.ajouterProduit("PLAQUÉES CRÉOLES",
               "900,99",
               "5",
               "4-4-2031",
               Image.FromFile(System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Init\img\5.jpg")
               );
            p.ajouterProduit("PORTÉ SUR L’ÉPAULE SAC",
              "230,20",
              "0",
              "15-9-2022",
              Image.FromFile(System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Init\img\6.jpg")
              );
            p.ajouterProduit("MASQUE POUR LE VISAGE",
              "50,20",
              "100",
              "1-1-2021",
              Image.FromFile(System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Init\img\7.jpg")
              );
        }
        private void UploalFourn()
        {

            f.AddFournisseur("Accessorize", "Agadire - Didouche Mourad La Rue Mourad ", "+230 548 59 72 3052");
            f.AddFournisseur("Zara", "Casa - Agadire - Didouche Mourad La Rue Mourad  ", "+212 23 45 68");
            f.AddFournisseur("diamantine", "Fes - Agadire - Didouche Mourad La Rue Mourad ", "+44 203 372 3052");

        }
        private void UploalCommande()
        {

            f.commander(1, 2, "40", "50", "03/01/2021");
            f.commander(3, 1, "10", "30", "25/02/2021");
            f.commander(4, 3, "60", "25", "12/03/2021");
            f.commander(1, 2, "800", "5", "06/03/2021");
        }
        public void UploalRevenu()
        {

            r.setInfoRevrnu("250", "58000", "10500", "60", "18/02/2019");
            r.setInfoRevrnu("360", "82000", "3000", "103", "18/02/2020");
            r.setInfoRevrnu("105", "12000", "8000", "23", "18/12/2020");
            r.setInfoRevrnu("30", "8300", "1200", "3", "10/01/2021");
            r.setInfoRevrnu("15", "6200", "1800", "8", "17/02/2021");
            r.setInfoRevrnu("20", "7200", "1800", "5", "18/02/2021");

        }
    }

}
