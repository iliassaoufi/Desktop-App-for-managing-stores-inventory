using ProjetGestionStock.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetGestionStock.Model_Gestion_Stock;

namespace ProjetGestionStock
{
    public partial class FormListeProduits : Form
    {
        private ProduitController p = new ProduitController();
        private int filtre;
        MainForm parentForm;
        public FormListeProduits(MainForm parentForm, int filtre = 1)
        {
            this.filtre = filtre;
            this.parentForm = parentForm;
            InitializeComponent();
        }
        private void customisation()
        {
            panelFiltrer.Visible = false;
            // initialisation de la class FormProduit_Item
            FormProduit_Item.initX = 70;
            FormProduit_Item.initY = 90;
            FormProduit_Item.width = 0;
            FormProduit_Item.height = 0;
            FormProduit_Item.nrb_creation = 0;
        }
        private void FormListeProduits_Load(object sender, EventArgs e)
        {
            customisation();
            afficherListProducts();
        }

        private void afficherProduct(int id, String nomProduit, Image img)
        {
            FormProduit_Item FormProduct = new FormProduit_Item(id, nomProduit, img);
            FormProduct.TopLevel = false;
            panel.Controls.Add(FormProduct);
            FormProduct.BringToFront();
            FormProduct.Show();
            FormProduct.labelQuantite.Visible = false;
            //FormProduct.labelQuantite.BringToFront();
        }

        #region Filtre
        private void buttonFiltrer_Click(object sender, EventArgs e)
        {
            if (panelFiltrer.Visible == false)
            {
                this.panelFiltrer.Location = new System.Drawing.Point(633, 59);
                panelFiltrer.Visible = true;
                panelFiltrer.BringToFront();
            }
            else
            {
                panelFiltrer.Visible = false;
            }

        }

        private void buttonFiltrer_MouseEnter(object sender, EventArgs e)
        {
            if (panelFiltrer.Visible == false)
            {
                this.panelFiltrer.Location = new System.Drawing.Point(633, 59);
                panelFiltrer.Visible = true;
                panelFiltrer.BringToFront();
            }
        }

        private void panel_Click(object sender, EventArgs e)
        {
            panelFiltrer.Visible = false;
        }

        private void buttonFiltreTout_Click(object sender, EventArgs e)
        {
            this.parentForm.openChildForm(new FormListeProduits(this.parentForm, 1));
        }

        private void buttonFiltreDisponible_Click(object sender, EventArgs e)
        {
            this.parentForm.openChildForm(new FormListeProduits(this.parentForm, 2));
        }

        private void buttonFiltreNonDispo_Click(object sender, EventArgs e)
        {
            this.parentForm.openChildForm(new FormListeProduits(this.parentForm, 3));
        }
        #endregion

        private void buttonRecherche_Click(object sender, EventArgs e)
        {

            string Nom_Produit = this.textBoxRecherche.Text;
            Produit prod = p.getByName(Nom_Produit);
            Boolean produit_Existe = (prod != null) ? true : false;




            if (produit_Existe)
            {
                new FormOneProduct(prod.Id).Show();
                produit_Existe = true;
                this.labelEreurre.Visible = false;
                this.pictureBoxEreurre.Visible = false;
            }
            else
            {
                this.labelEreurre.Visible = true;
                this.pictureBoxEreurre.Visible = true;
            }
        }





        private void afficherListProducts()
        {


            int id = 1;
            String nomProduit = "Lawrance Polo";
            Image img = ProjetGestionStock.Properties.Resources.img1;
            if (this.filtre == 1)
            {
                foreach (Produit prod in p.getAllProduct())
                {
                    afficherProduct(prod.Id, prod.Name, (Bitmap)((new ImageConverter()).ConvertFrom(prod.image)));
                    this.AutoScroll = true;
                    this.ResumeLayout(false);
                }

            }
            if (this.filtre == 2)
            {

                foreach (Produit prod in p.getDispoProduct())
                {
                    afficherProduct(prod.Id, prod.Name, (Bitmap)((new ImageConverter()).ConvertFrom(prod.image)));
                    this.AutoScroll = true;
                    this.ResumeLayout(false);
                }

            }
            if (this.filtre == 3)
            {


                foreach (Produit prod in p.getNonDispoProduct())
                {
                    afficherProduct(prod.Id, prod.Name, (Bitmap)((new ImageConverter()).ConvertFrom(prod.image)));
                    this.AutoScroll = true;
                    this.ResumeLayout(false);
                }

            }

        }


    }



}
