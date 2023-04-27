namespace ProjetGestionStock
{
    partial class FormListeProduits
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
            this.panel = new System.Windows.Forms.Panel();
            this.panelFiltrer = new System.Windows.Forms.Panel();
            this.buttonFiltreNonDispo = new System.Windows.Forms.Button();
            this.buttonFiltreDisponible = new System.Windows.Forms.Button();
            this.buttonFiltreTout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonFiltrer = new System.Windows.Forms.Button();
            this.labelEreurre = new System.Windows.Forms.Label();
            this.pictureBoxEreurre = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonRecherche = new System.Windows.Forms.Button();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.panelFiltrer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEreurre)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.AutoSize = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.panelFiltrer);
            this.panel.Controls.Add(this.button2);
            this.panel.Controls.Add(this.panel1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(850, 634);
            this.panel.TabIndex = 0;
            this.panel.Click += new System.EventHandler(this.panel_Click);
            this.panel.MouseEnter += new System.EventHandler(this.panel_Click);
            // 
            // panelFiltrer
            // 
            this.panelFiltrer.AllowDrop = true;
            this.panelFiltrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panelFiltrer.Controls.Add(this.buttonFiltreNonDispo);
            this.panelFiltrer.Controls.Add(this.buttonFiltreDisponible);
            this.panelFiltrer.Controls.Add(this.buttonFiltreTout);
            this.panelFiltrer.Location = new System.Drawing.Point(633, 59);
            this.panelFiltrer.Name = "panelFiltrer";
            this.panelFiltrer.Size = new System.Drawing.Size(172, 120);
            this.panelFiltrer.TabIndex = 2;
            // 
            // buttonFiltreNonDispo
            // 
            this.buttonFiltreNonDispo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFiltreNonDispo.FlatAppearance.BorderSize = 0;
            this.buttonFiltreNonDispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltreNonDispo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltreNonDispo.ForeColor = System.Drawing.Color.White;
            this.buttonFiltreNonDispo.Location = new System.Drawing.Point(0, 80);
            this.buttonFiltreNonDispo.Name = "buttonFiltreNonDispo";
            this.buttonFiltreNonDispo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonFiltreNonDispo.Size = new System.Drawing.Size(172, 40);
            this.buttonFiltreNonDispo.TabIndex = 2;
            this.buttonFiltreNonDispo.Text = "Non Disponiple";
            this.buttonFiltreNonDispo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFiltreNonDispo.UseVisualStyleBackColor = true;
            this.buttonFiltreNonDispo.Click += new System.EventHandler(this.buttonFiltreNonDispo_Click);
            // 
            // buttonFiltreDisponible
            // 
            this.buttonFiltreDisponible.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFiltreDisponible.FlatAppearance.BorderSize = 0;
            this.buttonFiltreDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltreDisponible.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltreDisponible.ForeColor = System.Drawing.Color.White;
            this.buttonFiltreDisponible.Location = new System.Drawing.Point(0, 40);
            this.buttonFiltreDisponible.Name = "buttonFiltreDisponible";
            this.buttonFiltreDisponible.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonFiltreDisponible.Size = new System.Drawing.Size(172, 40);
            this.buttonFiltreDisponible.TabIndex = 1;
            this.buttonFiltreDisponible.Text = "Disponible";
            this.buttonFiltreDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFiltreDisponible.UseVisualStyleBackColor = true;
            this.buttonFiltreDisponible.Click += new System.EventHandler(this.buttonFiltreDisponible_Click);
            // 
            // buttonFiltreTout
            // 
            this.buttonFiltreTout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFiltreTout.FlatAppearance.BorderSize = 0;
            this.buttonFiltreTout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltreTout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltreTout.ForeColor = System.Drawing.Color.White;
            this.buttonFiltreTout.Location = new System.Drawing.Point(0, 0);
            this.buttonFiltreTout.Name = "buttonFiltreTout";
            this.buttonFiltreTout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonFiltreTout.Size = new System.Drawing.Size(172, 40);
            this.buttonFiltreTout.TabIndex = 0;
            this.buttonFiltreTout.Text = "Tout";
            this.buttonFiltreTout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFiltreTout.UseVisualStyleBackColor = true;
            this.buttonFiltreTout.Click += new System.EventHandler(this.buttonFiltreTout_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 584);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.buttonFiltrer);
            this.panel2.Controls.Add(this.labelEreurre);
            this.panel2.Controls.Add(this.pictureBoxEreurre);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonRecherche);
            this.panel2.Controls.Add(this.textBoxRecherche);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 60);
            this.panel2.TabIndex = 1;
            // 
            // buttonFiltrer
            // 
            this.buttonFiltrer.FlatAppearance.BorderSize = 0;
            this.buttonFiltrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltrer.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonFiltrer.ForeColor = System.Drawing.Color.White;
            this.buttonFiltrer.Image = global::ProjetGestionStock.Properties.Resources.chercher1;
            this.buttonFiltrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFiltrer.Location = new System.Drawing.Point(633, 12);
            this.buttonFiltrer.Name = "buttonFiltrer";
            this.buttonFiltrer.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonFiltrer.Size = new System.Drawing.Size(172, 32);
            this.buttonFiltrer.TabIndex = 5;
            this.buttonFiltrer.Text = "Filtrer";
            this.buttonFiltrer.UseVisualStyleBackColor = true;
            this.buttonFiltrer.Click += new System.EventHandler(this.buttonFiltrer_Click);
            this.buttonFiltrer.MouseEnter += new System.EventHandler(this.buttonFiltrer_MouseEnter);
            // 
            // labelEreurre
            // 
            this.labelEreurre.AutoSize = true;
            this.labelEreurre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelEreurre.Location = new System.Drawing.Point(425, 21);
            this.labelEreurre.Name = "labelEreurre";
            this.labelEreurre.Size = new System.Drawing.Size(151, 17);
            this.labelEreurre.TabIndex = 4;
            this.labelEreurre.Text = "Ce produit n\'exist pas ";
            this.labelEreurre.UseWaitCursor = true;
            this.labelEreurre.Visible = false;
            // 
            // pictureBoxEreurre
            // 
            this.pictureBoxEreurre.Image = global::ProjetGestionStock.Properties.Resources.exclamation;
            this.pictureBoxEreurre.Location = new System.Drawing.Point(393, 16);
            this.pictureBoxEreurre.Name = "pictureBoxEreurre";
            this.pictureBoxEreurre.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxEreurre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEreurre.TabIndex = 3;
            this.pictureBoxEreurre.TabStop = false;
            this.pictureBoxEreurre.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(166)))), ((int)(((byte)(204)))));
            this.panel3.Location = new System.Drawing.Point(123, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 2);
            this.panel3.TabIndex = 2;
            // 
            // buttonRecherche
            // 
            this.buttonRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.buttonRecherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRecherche.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(166)))), ((int)(((byte)(204)))));
            this.buttonRecherche.FlatAppearance.BorderSize = 2;
            this.buttonRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecherche.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecherche.ForeColor = System.Drawing.Color.White;
            this.buttonRecherche.Location = new System.Drawing.Point(27, 9);
            this.buttonRecherche.Name = "buttonRecherche";
            this.buttonRecherche.Size = new System.Drawing.Size(96, 32);
            this.buttonRecherche.TabIndex = 1;
            this.buttonRecherche.Text = "Rechercher";
            this.buttonRecherche.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRecherche.UseVisualStyleBackColor = false;
            this.buttonRecherche.Click += new System.EventHandler(this.buttonRecherche_Click);
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.textBoxRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRecherche.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxRecherche.ForeColor = System.Drawing.Color.White;
            this.textBoxRecherche.Location = new System.Drawing.Point(129, 17);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(234, 17);
            this.textBoxRecherche.TabIndex = 0;
            // 
            // FormListeProduits
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(850, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormListeProduits";
            this.Text = "FormListeProduits";
            this.Load += new System.EventHandler(this.FormListeProduits_Load);
            this.panel.ResumeLayout(false);
            this.panelFiltrer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEreurre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonRecherche;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.Label labelEreurre;
        private System.Windows.Forms.PictureBox pictureBoxEreurre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonFiltrer;
        private System.Windows.Forms.Panel panelFiltrer;
        private System.Windows.Forms.Button buttonFiltreDisponible;
        private System.Windows.Forms.Button buttonFiltreTout;
        private System.Windows.Forms.Button buttonFiltreNonDispo;
    }
}