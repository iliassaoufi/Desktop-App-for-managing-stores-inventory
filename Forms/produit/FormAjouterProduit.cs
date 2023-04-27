using ProjetGestionStock.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionStock
{
    public partial class FormAjouterProduit : Form
    {
        private Image productImg = global::ProjetGestionStock.Properties.Resources.livraison;

        public FormAjouterProduit()
        {
            InitializeComponent();
            customisation();
        }

        private void customisation()
        {

        }

        #region custom form
        private void textBoxNom_Enter(object sender, EventArgs e)
        {
            this.textBoxNom.Text = "";
            /*
            if (this.textBoxNom.Text == "Nom")
                this.textBoxNom.Text = "";
            this.textBoxNom.ForeColor = Color.FromArgb(64,64,64) ;
            */
        }

        private void textBoxNom_Leave(object sender, EventArgs e)
        {

            /*
            if (this.textBoxNom.Text == "")
                this.textBoxNom.Text = "Nom";
            this.textBoxNom.ForeColor = Color.FromArgb(178, 186, 187);
            */
        }

        private void textBoxPrix_Enter(object sender, EventArgs e)
        {
            this.textBoxPrix.Text = "";
        }

        private void textBoxPrix_Leave(object sender, EventArgs e)
        {

        }



        private void textBoxQuantity_Enter(object sender, EventArgs e)
        {
            this.textBoxQuantity.Text = "";
        }

        private void textBoxJour_Enter(object sender, EventArgs e)
        {
            this.textBoxJour.Text = "";
        }

        private void textBoxJour_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxMois_Enter(object sender, EventArgs e)
        {
            this.textBoxMois.Text = "";
        }

        private void textBoxMois_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxAnnee_Enter(object sender, EventArgs e)
        {
            this.textBoxAnnee.Text = "";
        }

        private void textBoxAnnee_Leave(object sender, EventArgs e)
        {

        }
        #endregion
        private void buttonUplaod_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            String imgURL;
            opnfd.Filter = "Image Files (*.png;*.jpg;*.jpeg;.*.gif;)|*.png;*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                imgURL = opnfd.FileName;
                this.productImg = Image.FromFile(imgURL);
                pictureBoxProduit.Image = this.productImg;
            }
        }


        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            textBoxNom.Text = "Nom";
            textBoxPrix.Text = "prix";
            textBoxQuantity.Text = "Quantité";
            textBoxJour.Text = "Jour";
            textBoxMois.Text = "Mois";
            textBoxAnnee.Text = "Année";
            pictureBoxProduit.Image = global::ProjetGestionStock.Properties.Resources.livraison;
        }
        private void buttonValider_Click(object sender, EventArgs e)
        {
            AjouterProduct();
        }
        private void AjouterProduct()
        {
            string date = textBoxJour.Text + "/" + textBoxMois.Text + "/" + textBoxAnnee.Text;
            var p = new ProduitController();
            p.ajouterProduit(
                 textBoxNom.Text,
                 textBoxPrix.Text,
                 textBoxQuantity.Text,
                 date,
                 this.productImg
                 );
        }


    }
}

