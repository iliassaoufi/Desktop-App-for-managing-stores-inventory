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
    public partial class FormProduit_Item : Form
    {
        private int id;
        
        //-----------
        public static int initX =0 ;
        public static int initY =0 ;
        public static int height = 0 ;
        public static int width = 0;
        public static int nrb_creation=0; 
        //---------------

        public FormProduit_Item(int id, string titre , Image img , int quantite = 0 )
        {
            this.id = id;
                       
            nrb_creation++;
            //-------------------------------------------
            InitializeComponent();
            location();
            this.FormBorderStyle = FormBorderStyle.None;
            //------------------------
            this.labelTitre.Text = titre;
            this.pictureBox.Image = img;
            this.labelQuantite.Text = Convert.ToString(quantite);
        }
        private void location()
        {
            this.Location = new System.Drawing.Point(initX + width, initY + height);
            width += 250;   
            if ((nrb_creation%3)==0)
            {
                height += 300;
                width = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormOneProduct(id).Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
