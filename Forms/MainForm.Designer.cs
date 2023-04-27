namespace ProjetGestionStock
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panelFournisseur = new System.Windows.Forms.Panel();
            this.buttonListeCommande = new System.Windows.Forms.Button();
            this.buttonCommander = new System.Windows.Forms.Button();
            this.buttonListeFournisseur = new System.Windows.Forms.Button();
            this.buttonFournisseur = new System.Windows.Forms.Button();
            this.panelGestioProduits = new System.Windows.Forms.Panel();
            this.buttonControleJour = new System.Windows.Forms.Button();
            this.buttonProduitsDestocker = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonListeProduits = new System.Windows.Forms.Button();
            this.buttonGestionProduit = new System.Windows.Forms.Button();
            this.buttonStatistique = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.NavbarPanel = new System.Windows.Forms.Panel();
            this.labelChildTitle = new System.Windows.Forms.Label();
            this.pictureBoxChildIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimaze = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftPanel.SuspendLayout();
            this.panelFournisseur.SuspendLayout();
            this.panelGestioProduits.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.NavbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChildIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.childFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.AutoScroll = true;
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(99)))), ((int)(((byte)(143)))));
            this.leftPanel.Controls.Add(this.panelFournisseur);
            this.leftPanel.Controls.Add(this.buttonFournisseur);
            this.leftPanel.Controls.Add(this.panelGestioProduits);
            this.leftPanel.Controls.Add(this.buttonGestionProduit);
            this.leftPanel.Controls.Add(this.buttonStatistique);
            this.leftPanel.Controls.Add(this.panelLogo);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(250, 700);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelFournisseur
            // 
            this.panelFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.panelFournisseur.Controls.Add(this.buttonListeCommande);
            this.panelFournisseur.Controls.Add(this.buttonCommander);
            this.panelFournisseur.Controls.Add(this.buttonListeFournisseur);
            this.panelFournisseur.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFournisseur.Location = new System.Drawing.Point(0, 459);
            this.panelFournisseur.Name = "panelFournisseur";
            this.panelFournisseur.Size = new System.Drawing.Size(250, 120);
            this.panelFournisseur.TabIndex = 5;
            // 
            // buttonListeCommande
            // 
            this.buttonListeCommande.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListeCommande.FlatAppearance.BorderSize = 0;
            this.buttonListeCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListeCommande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonListeCommande.Location = new System.Drawing.Point(0, 80);
            this.buttonListeCommande.Name = "buttonListeCommande";
            this.buttonListeCommande.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonListeCommande.Size = new System.Drawing.Size(250, 40);
            this.buttonListeCommande.TabIndex = 3;
            this.buttonListeCommande.Text = "liste des commande";
            this.buttonListeCommande.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListeCommande.UseVisualStyleBackColor = true;
            this.buttonListeCommande.Click += new System.EventHandler(this.buttonListeCommande_Click);
            // 
            // buttonCommander
            // 
            this.buttonCommander.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCommander.FlatAppearance.BorderSize = 0;
            this.buttonCommander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCommander.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCommander.Location = new System.Drawing.Point(0, 40);
            this.buttonCommander.Name = "buttonCommander";
            this.buttonCommander.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonCommander.Size = new System.Drawing.Size(250, 40);
            this.buttonCommander.TabIndex = 2;
            this.buttonCommander.Text = "Commander";
            this.buttonCommander.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCommander.UseVisualStyleBackColor = true;
            this.buttonCommander.Click += new System.EventHandler(this.buttonCommander_Click);
            // 
            // buttonListeFournisseur
            // 
            this.buttonListeFournisseur.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListeFournisseur.FlatAppearance.BorderSize = 0;
            this.buttonListeFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListeFournisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonListeFournisseur.Location = new System.Drawing.Point(0, 0);
            this.buttonListeFournisseur.Name = "buttonListeFournisseur";
            this.buttonListeFournisseur.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonListeFournisseur.Size = new System.Drawing.Size(250, 40);
            this.buttonListeFournisseur.TabIndex = 1;
            this.buttonListeFournisseur.Text = "liste fournisseur";
            this.buttonListeFournisseur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListeFournisseur.UseVisualStyleBackColor = true;
            this.buttonListeFournisseur.Click += new System.EventHandler(this.buttonListeFournisseur_Click);
            // 
            // buttonFournisseur
            // 
            this.buttonFournisseur.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFournisseur.FlatAppearance.BorderSize = 0;
            this.buttonFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFournisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonFournisseur.Image = global::ProjetGestionStock.Properties.Resources.user;
            this.buttonFournisseur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFournisseur.Location = new System.Drawing.Point(0, 409);
            this.buttonFournisseur.Name = "buttonFournisseur";
            this.buttonFournisseur.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.buttonFournisseur.Size = new System.Drawing.Size(250, 50);
            this.buttonFournisseur.TabIndex = 4;
            this.buttonFournisseur.Text = "fournisseur";
            this.buttonFournisseur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFournisseur.UseVisualStyleBackColor = true;
            this.buttonFournisseur.Click += new System.EventHandler(this.buttonFournisseur_Click);
            // 
            // panelGestioProduits
            // 
            this.panelGestioProduits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.panelGestioProduits.Controls.Add(this.buttonControleJour);
            this.panelGestioProduits.Controls.Add(this.buttonProduitsDestocker);
            this.panelGestioProduits.Controls.Add(this.buttonAddProduct);
            this.panelGestioProduits.Controls.Add(this.buttonListeProduits);
            this.panelGestioProduits.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGestioProduits.Location = new System.Drawing.Point(0, 249);
            this.panelGestioProduits.Name = "panelGestioProduits";
            this.panelGestioProduits.Size = new System.Drawing.Size(250, 160);
            this.panelGestioProduits.TabIndex = 3;
            // 
            // buttonControleJour
            // 
            this.buttonControleJour.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonControleJour.FlatAppearance.BorderSize = 0;
            this.buttonControleJour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonControleJour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonControleJour.Location = new System.Drawing.Point(0, 120);
            this.buttonControleJour.Name = "buttonControleJour";
            this.buttonControleJour.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonControleJour.Size = new System.Drawing.Size(250, 40);
            this.buttonControleJour.TabIndex = 3;
            this.buttonControleJour.Text = "Contrôle de jour";
            this.buttonControleJour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonControleJour.UseVisualStyleBackColor = true;
            this.buttonControleJour.Click += new System.EventHandler(this.buttonControleJour_Click);
            // 
            // buttonProduitsDestocker
            // 
            this.buttonProduitsDestocker.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProduitsDestocker.FlatAppearance.BorderSize = 0;
            this.buttonProduitsDestocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduitsDestocker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonProduitsDestocker.Location = new System.Drawing.Point(0, 80);
            this.buttonProduitsDestocker.Name = "buttonProduitsDestocker";
            this.buttonProduitsDestocker.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonProduitsDestocker.Size = new System.Drawing.Size(250, 40);
            this.buttonProduitsDestocker.TabIndex = 2;
            this.buttonProduitsDestocker.Text = "produits à destocker";
            this.buttonProduitsDestocker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProduitsDestocker.UseVisualStyleBackColor = true;
            this.buttonProduitsDestocker.Click += new System.EventHandler(this.buttonProduitsDestocker_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddProduct.FlatAppearance.BorderSize = 0;
            this.buttonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAddProduct.Location = new System.Drawing.Point(0, 40);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAddProduct.Size = new System.Drawing.Size(250, 40);
            this.buttonAddProduct.TabIndex = 1;
            this.buttonAddProduct.Text = "ajouter produits";
            this.buttonAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonListeProduits
            // 
            this.buttonListeProduits.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListeProduits.FlatAppearance.BorderSize = 0;
            this.buttonListeProduits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListeProduits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonListeProduits.Location = new System.Drawing.Point(0, 0);
            this.buttonListeProduits.Name = "buttonListeProduits";
            this.buttonListeProduits.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonListeProduits.Size = new System.Drawing.Size(250, 40);
            this.buttonListeProduits.TabIndex = 0;
            this.buttonListeProduits.Text = "liste produits";
            this.buttonListeProduits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListeProduits.UseVisualStyleBackColor = true;
            this.buttonListeProduits.Click += new System.EventHandler(this.buttonListeProduits_Click);
            // 
            // buttonGestionProduit
            // 
            this.buttonGestionProduit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGestionProduit.FlatAppearance.BorderSize = 0;
            this.buttonGestionProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonGestionProduit.Image = global::ProjetGestionStock.Properties.Resources.box;
            this.buttonGestionProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGestionProduit.Location = new System.Drawing.Point(0, 199);
            this.buttonGestionProduit.Name = "buttonGestionProduit";
            this.buttonGestionProduit.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.buttonGestionProduit.Size = new System.Drawing.Size(250, 50);
            this.buttonGestionProduit.TabIndex = 2;
            this.buttonGestionProduit.Text = "produits";
            this.buttonGestionProduit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGestionProduit.UseVisualStyleBackColor = true;
            this.buttonGestionProduit.Click += new System.EventHandler(this.buttonGestionProduit_Click);
            // 
            // buttonStatistique
            // 
            this.buttonStatistique.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStatistique.FlatAppearance.BorderSize = 0;
            this.buttonStatistique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonStatistique.Image = global::ProjetGestionStock.Properties.Resources.bar_chart;
            this.buttonStatistique.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStatistique.Location = new System.Drawing.Point(0, 149);
            this.buttonStatistique.Name = "buttonStatistique";
            this.buttonStatistique.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.buttonStatistique.Size = new System.Drawing.Size(250, 50);
            this.buttonStatistique.TabIndex = 1;
            this.buttonStatistique.Text = "Statistiques";
            this.buttonStatistique.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistique.UseVisualStyleBackColor = true;
            this.buttonStatistique.Click += new System.EventHandler(this.buttonStatistique_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 149);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ProjetGestionStock.Properties.Resources.creatoor2;
            this.pictureBoxLogo.Location = new System.Drawing.Point(19, 19);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(183, 110);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // NavbarPanel
            // 
            this.NavbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.NavbarPanel.Controls.Add(this.labelChildTitle);
            this.NavbarPanel.Controls.Add(this.pictureBoxChildIcon);
            this.NavbarPanel.Controls.Add(this.pictureBoxMinimaze);
            this.NavbarPanel.Controls.Add(this.pictureBoxClose);
            this.NavbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavbarPanel.Location = new System.Drawing.Point(250, 0);
            this.NavbarPanel.Name = "NavbarPanel";
            this.NavbarPanel.Size = new System.Drawing.Size(850, 66);
            this.NavbarPanel.TabIndex = 1;
            this.NavbarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavbarPanel_MouseDown);
            // 
            // labelChildTitle
            // 
            this.labelChildTitle.AutoSize = true;
            this.labelChildTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChildTitle.ForeColor = System.Drawing.Color.White;
            this.labelChildTitle.Location = new System.Drawing.Point(69, 23);
            this.labelChildTitle.Name = "labelChildTitle";
            this.labelChildTitle.Size = new System.Drawing.Size(52, 20);
            this.labelChildTitle.TabIndex = 1;
            this.labelChildTitle.Text = "Home";
            this.labelChildTitle.Click += new System.EventHandler(this.labelChildTitle_Click);
            // 
            // pictureBoxChildIcon
            // 
            this.pictureBoxChildIcon.Image = global::ProjetGestionStock.Properties.Resources.home;
            this.pictureBoxChildIcon.Location = new System.Drawing.Point(29, 19);
            this.pictureBoxChildIcon.Name = "pictureBoxChildIcon";
            this.pictureBoxChildIcon.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxChildIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChildIcon.TabIndex = 0;
            this.pictureBoxChildIcon.TabStop = false;
            this.pictureBoxChildIcon.Click += new System.EventHandler(this.pictureBoxMinimaze_Click);
            // 
            // pictureBoxMinimaze
            // 
            this.pictureBoxMinimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimaze.Image = global::ProjetGestionStock.Properties.Resources.moins_2_;
            this.pictureBoxMinimaze.Location = new System.Drawing.Point(791, 3);
            this.pictureBoxMinimaze.Name = "pictureBoxMinimaze";
            this.pictureBoxMinimaze.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimaze.TabIndex = 0;
            this.pictureBoxMinimaze.TabStop = false;
            this.pictureBoxMinimaze.Click += new System.EventHandler(this.pictureBoxMinimaze_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = global::ProjetGestionStock.Properties.Resources.erreur;
            this.pictureBoxClose.Location = new System.Drawing.Point(822, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // childFormPanel
            // 
            this.childFormPanel.AutoScroll = true;
            this.childFormPanel.BackColor = System.Drawing.Color.White;
            this.childFormPanel.Controls.Add(this.pictureBox1);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(250, 66);
            this.childFormPanel.Margin = new System.Windows.Forms.Padding(0);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(850, 634);
            this.childFormPanel.TabIndex = 2;
            this.childFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.childFormPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ProjetGestionStock.Properties.Resources.creatoore_psd;
            this.pictureBox1.Location = new System.Drawing.Point(190, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.NavbarPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.leftPanel.ResumeLayout(false);
            this.panelFournisseur.ResumeLayout(false);
            this.panelGestioProduits.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.NavbarPanel.ResumeLayout(false);
            this.NavbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChildIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.childFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel NavbarPanel;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimaze;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonStatistique;
        private System.Windows.Forms.Panel panelGestioProduits;
        private System.Windows.Forms.Button buttonProduitsDestocker;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonListeProduits;
        private System.Windows.Forms.Button buttonGestionProduit;
        private System.Windows.Forms.Panel panelFournisseur;
        private System.Windows.Forms.Button buttonListeCommande;
        private System.Windows.Forms.Button buttonCommander;
        private System.Windows.Forms.Button buttonListeFournisseur;
        private System.Windows.Forms.Button buttonFournisseur;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelChildTitle;
        private System.Windows.Forms.PictureBox pictureBoxChildIcon;
        private System.Windows.Forms.Button buttonControleJour;
    }
}