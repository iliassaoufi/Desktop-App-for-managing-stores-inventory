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

namespace ProjetGestionStock
{
    public partial class FormCommanderFournisseur : Form
    {
        ProduitController p = new ProduitController();
        FournisseurController f = new FournisseurController();
        public FormCommanderFournisseur()
        {
            InitializeComponent();
        }
        private void FormCommanderFournisseur_Load(object sender, EventArgs e)
        {
            RemplircomboBox();
        }
        private void RemplircomboBox()
        {


            List<String> produits = p.getAllProductName();
            this.comboBoxProduit.Items.AddRange(produits.ToArray());


            List<String> fourn = f.getAllFournName();
            this.comboBoxfounisseur.Items.AddRange(fourn.ToArray());
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.comboBoxProduit.Text = "précise le produit";
            this.comboBoxfounisseur.Text = "précise le fournisseur";
            this.textBoxQuantite.Text = "la quantité";
            this.textBoxPrix.Text = "le prix";

            //date arrive
            this.textBoxArriveJour.Text = "Jour";
            this.textBoxArriveMois.Text = "Mois";
            this.textBoxArriveAnnee.Text = "Année";
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            AjouterCommande();
        }
        private void AjouterCommande()
        {

            string date = this.textBoxArriveJour.Text + "/" + this.textBoxArriveMois.Text + "/" + this.textBoxArriveAnnee.Text;
            if (p.getByName(this.comboBoxProduit.Text) != null && f.getByName(this.comboBoxfounisseur.Text) != null)
            {
                int prodId = p.getByName(this.comboBoxProduit.Text).Id;
                int fournId = f.getByName(this.comboBoxfounisseur.Text).Id;
                f.commander(prodId,
                    fournId,
                    this.textBoxPrix.Text,
                    this.textBoxQuantite.Text,
                    date
                     );
            }
        }


        private void textBoxQuantite_Enter(object sender, EventArgs e)
        {
            this.textBoxQuantite.Text = "";
        }

        private void textBoxPrix_Enter(object sender, EventArgs e)
        {
            this.textBoxPrix.Text = "";
        }

        private void textBoxArriveJour_Enter(object sender, EventArgs e)
        {
            this.textBoxArriveJour.Text = "";
        }

        private void textBoxArriveMois_Enter(object sender, EventArgs e)
        {
            this.textBoxArriveMois.Text = "";
        }

        private void textBoxArriveAnnee_Enter(object sender, EventArgs e)
        {
            this.textBoxArriveAnnee.Text = "";
        }


    }
}
