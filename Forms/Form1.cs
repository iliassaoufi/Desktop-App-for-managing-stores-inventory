using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ProjetGestionStock
{
    public partial class Form1 : Form
    {
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
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {          

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "Nom d'utilisateur")
                textBoxUserName.Text = "";
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Mot de passe")
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
            }
               
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
                textBoxUserName.Text = "Nom d'utilisateur";
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.Text = "Mot de passe";
            }
               
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUserName.Text =="iliass" && textBoxPassword.Text=="1234")
            {
                (new MainForm()).Show();
                this.Hide();
            }
            else
            {
                labelErreure.Visible = true;
                labelErreure.Text = "le nom ou le mot de passe invalide";
                pictureBoxErreure.Visible = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelErreure_Click(object sender, EventArgs e)
        {

        }
    }
}
