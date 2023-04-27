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
    public partial class FormFournisseur_item : Form
    {
        private int id;

        //-----------
        public static int initX = 0;
        public static int initY = 0;
        public static int height = 0;
        public static int width = 0;
        public static int nrb_creation = 0;
        //-------------------------
        public FormFournisseur_item(int id, string nom, string adresse, string contact)
        {
            this.id = id;
            nrb_creation++;
            //-------------------
            InitializeComponent();
            location();
            //-----------------------------
            this.labelNom.Text = nom; 
            this.labelAdresse.Text = adresse; 
            this.labelContact.Text = contact; 
        }
        private void location()
        {
            this.Location = new System.Drawing.Point(initX + width, initY + height);
            width += 400;
            if ((nrb_creation % 2) == 0)
            {
                height += 300;
                width = 0;
            }
        }
        private void buttonVoirPlus_Click(object sender, EventArgs e)
        {
            new FormOneFournisseur(id).Show();
        }
    }
}
