using ProjetGestionStock.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetGestionStock.Model_Gestion_Stock;

namespace ProjetGestionStock
{
    public partial class FormListeProduitsDestocker : Form
    {
        public FormListeProduitsDestocker()
        {
            InitializeComponent();

        }
        private void customisation()
        {
            // initialisation de la class FormProduit_Item
            FormProduit_Item.initX = 70;
            FormProduit_Item.initY = 140;
            FormProduit_Item.width = 0;
            FormProduit_Item.height = 0;
            FormProduit_Item.nrb_creation = 0;
        }

        private void afficherProduct(int id, String nomProduit, Image img, int quantite)
        {
            FormProduit_Item FormProduct = new FormProduit_Item(id, nomProduit, img, quantite);
            FormProduct.TopLevel = false;
            panel.Controls.Add(FormProduct);
            FormProduct.BringToFront();
            FormProduct.Show();
            FormProduct.labelQuantite.Visible = true;
            FormProduct.labelQuantite.BringToFront();
        }


        private void FormListeProduitsDestocker_Load(object sender, EventArgs e)
        {
            customisation();
            afficherProduitsDestocker();
        }
        private void afficherProduitsDestocker()
        {
            var p = new ProduitController();
            foreach (Produit prod in p.getProductDestocker())
            {
                afficherProduct(prod.Id, prod.Name, (Bitmap)((new ImageConverter()).ConvertFrom(prod.image)), prod.Quantity);
                this.AutoScroll = true;
                this.ResumeLayout(false);
            }

        }
    }
}
