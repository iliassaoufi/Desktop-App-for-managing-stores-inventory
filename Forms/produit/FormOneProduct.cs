using ProjetGestionStock.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionStock
{


    public partial class FormOneProduct : Form
    {

        private int id;
        public FormOneProduct(int id)
        {
            InitializeComponent();
            //------
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //-------------------
            this.id = id;
        }
        private void FormOneProduct_Load(object sender, EventArgs e)
        {
            AfficherProduit();
        }

        private void AfficherProduit()
        {
            var p = new ProduitController();
            var prod = p.getById(this.id);
            //----------------
            string Nom_Produit = prod.Name;
            string Prix = prod.Price.ToString();
            string Quantite = prod.Quantity.ToString();
            string date_Expiration = prod.ExpirationDate.ToString("MM-dd-yyyy");
            Boolean Disponible = prod.State;
            Image img = (Bitmap)((new ImageConverter()).ConvertFrom(prod.image));

            this.labelProductTitle.Text = Nom_Produit;
            this.labelProductPrice.Text = Prix;
            this.labelProductQuantity.Text = Quantite;
            this.labelProductDate.Text = date_Expiration;
            this.pictureBoxProductImage.Image = img;
            if (Disponible)
            {
                this.labelDisponible.Text = "Disponible";
                this.labelDisponible.ForeColor = Color.FromArgb(25, 111, 61);
            }
            else
            {
                this.labelDisponible.Text = "Non Disponible";
                this.labelDisponible.ForeColor = Color.FromArgb(192, 57, 43);
            }
        }

        #region autre 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

    }
}
