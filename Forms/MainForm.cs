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
using ProjetGestionStock.Init;

namespace ProjetGestionStock
{
    public partial class MainForm : Form
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
        private Panel leftBorderPanel;
        private Button currentBtn;
        public MainForm()
        {
            InitializeComponent();
            customizeDesing();
            //---------
            var db = new Init_db();
            db.uploadDb();
        }

        private void customizeDesing()
        {
            panelGestioProduits.Visible = false;
            panelFournisseur.Visible = false;
            //-----------------------
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //-------------------------
            leftBorderPanel = new Panel();
            leftBorderPanel.Size = new Size(7, 50);
            leftPanel.Controls.Add(leftBorderPanel);
            leftBorderPanel.Visible = false;
            //-----------------------------
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }



        private void activeButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                disableBtn();
                //----------
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(36, 54, 66);
                currentBtn.Padding = new Padding(17, 0, 30, 0);
                //---
                leftBorderPanel.BackColor = Color.FromArgb(192, 57, 43);
                leftBorderPanel.Location = new Point(0, currentBtn.Location.Y);
                leftBorderPanel.Visible = true;
                leftBorderPanel.BringToFront();
                //---------------
                pictureBoxChildIcon.Image = currentBtn.Image;
                labelChildTitle.Text = currentBtn.Text;

            }
        }
        private void disableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(33, 97, 140);
                currentBtn.Padding = new Padding(10, 0, 30, 0);

            }
        }


        #region >> Sub Menus Panel

        private void hideSubMenu()
        {
            if (panelGestioProduits.Visible == true)
                panelGestioProduits.Visible = false;
            if (panelFournisseur.Visible == true)
                panelFournisseur.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void buttonGestionProduit_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGestioProduits);
            activeButton(sender);
        }

        private void buttonFournisseur_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFournisseur);
            activeButton(sender);
        }
        #endregion


        //----------------------------------
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //------------------------------------------
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void childFormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            disableBtn();
            leftBorderPanel.Visible = false;
            pictureBoxChildIcon.Image = global::ProjetGestionStock.Properties.Resources.home;
            labelChildTitle.Text = "Home";

        }

        private void labelChildTitle_Click(object sender, EventArgs e)
        {

        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void NavbarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void buttonStatistique_Click(object sender, EventArgs e)
        {
            openChildForm(new FormStatistique());
            hideSubMenu();
            activeButton(sender);
        }
        private void buttonListeProduits_Click(object sender, EventArgs e)
        {

            openChildForm(new FormListeProduits(this));

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAjouterProduit());
        }

        private void buttonProduitsDestocker_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListeProduitsDestocker());
        }

        private void buttonControleJour_Click(object sender, EventArgs e)
        {
            openChildForm(new FormControleJour());
        }

        private void buttonListeFournisseur_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListeFournisseur());
        }

        private void buttonCommander_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCommanderFournisseur());
        }

        private void buttonListeCommande_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListeCommande());
        }


    }
}
