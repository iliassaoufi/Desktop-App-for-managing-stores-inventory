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
    public partial class FormListeFournisseur : Form
    {
        public FormListeFournisseur()
        {
            InitializeComponent();
        }
        private void FormListeFournisseur_Load(object sender, EventArgs e)
        {
            customisation();
            AfficherListFournisseur();
        }
        private void customisation()
        {
            FormFournisseur_item.initX = 35;
            FormFournisseur_item.initY = 75;
            FormFournisseur_item.width = 0;
            FormFournisseur_item.height = 0;
            FormFournisseur_item.nrb_creation = 0;
        }
        private void afficherFour(int id, string nom, string adresse, string contact)
        {
            FormFournisseur_item FormProduct = new FormFournisseur_item(id, nom, adresse, contact);
            FormProduct.TopLevel = false;
            panel.Controls.Add(FormProduct);
            FormProduct.BringToFront();
            FormProduct.Show();
        }
        private void AfficherListFournisseur()
        {

            var f = new FournisseurController();
            foreach (Fournisseur fourn in f.getAllFourn())
            {
                afficherFour(fourn.Id, fourn.Name, fourn.Adresse, fourn.Contact);
                this.AutoScroll = true;
                this.ResumeLayout(false);
            }
            /*
            int id =1 ;
            string nom = " iliass El AOUFI ";
            string adresse = " fes , zohour , 23";
            string contact = "+2126-23972198";
            for (int i = 0; i < 5; i++)
            {
                afficherFour(id , nom , adresse , contact);
                this.AutoScroll = true;
                this.ResumeLayout(false);
            }
            */
        }


    }
}
