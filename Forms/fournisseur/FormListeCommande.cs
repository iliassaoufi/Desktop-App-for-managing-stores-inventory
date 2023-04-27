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
    public partial class FormListeCommande : Form
    {
        public FormListeCommande()
        {
            InitializeComponent();
        }
        private void FormListeCommande_Load(object sender, EventArgs e)
        {
            FormListeCommande_item.table_H = 0;
            FormListeCommande_item.i = 0;
            //----------
            implement();
            //----------
            if (FormListeCommande_item.i < 6)
            {
                this.panel7.Size = new System.Drawing.Size(850, 50);
            }
        }

        private void implement()
        {
            FournisseurController f = new FournisseurController();
            ProduitController p = new ProduitController();

            string nbrCommande = f.getNbrCommande().ToString();
            string prixTotale = f.getPrixTotalCommande();
            this.labelNbrCommande.Text = nbrCommande;
            this.labelPrixTotal.Text = prixTotale;

            //-----------------------implementer le Tableau des commande-------------------------
            string NumCommande;
            string NomProduit;
            string Prix;
            string fournisseur;
            foreach (Commande com in f.getAllCommande())
            {
                NumCommande = "" + com.Id;
                NomProduit = p.getById(com.ProduitId).Name;
                Prix = (com.Price * com.Quantity).ToString();
                fournisseur = f.getById(com.FournisseurId).Name;
                new FormListeCommande_item(this, NumCommande, NomProduit, Prix, fournisseur);
            }






        }
    }
    public partial class FormListeCommande_item : Form
    {
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public static int table_H = 0, i = 1;

        public FormListeCommande_item(FormListeCommande f, string NumCommande, string NomProduit, string Prix, string fournisseur)
        {
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            // this.panel7.SuspendLayout();
            RowBuilder(NumCommande, NomProduit, Prix, fournisseur);
            f.Controls.Add(this.panel7);
            f.AutoScroll = true;
            f.AutoSize = true;
            // this.panel7.ResumeLayout(false);
        }
        private void RowBuilder(string NumCommande, string NomProduit, string Prix, string fournisseur)
        {
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(73, 390 + table_H);
            this.panel7.Name = "Lawrance Polo";
            this.panel7.Size = new System.Drawing.Size(702, 45);
            this.panel7.TabIndex = 1;
            table_H += (45 + 6);

            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(526, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 45);
            this.label9.TabIndex = 3;
            this.label9.Text = fournisseur;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(351, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 45);
            this.label10.TabIndex = 2;
            this.label10.Text = Prix;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(175, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 45);
            this.label11.TabIndex = 1;
            this.label11.Text = NomProduit;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 45);
            this.label12.TabIndex = 0;
            this.label12.Text = NumCommande;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            i++;
        }
    }

}
