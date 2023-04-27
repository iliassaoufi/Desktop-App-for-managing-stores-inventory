namespace ProjetGestionStock
{
    partial class FormAjouterProduit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonUplaod = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxAnnee = new System.Windows.Forms.TextBox();
            this.textBoxMois = new System.Windows.Forms.TextBox();
            this.textBoxJour = new System.Windows.Forms.TextBox();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.pictureBoxProduit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.textBoxQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonAnnuler);
            this.panel1.Controls.Add(this.buttonValider);
            this.panel1.Controls.Add(this.buttonUplaod);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxAnnee);
            this.panel1.Controls.Add(this.textBoxMois);
            this.panel1.Controls.Add(this.textBoxJour);
            this.panel1.Controls.Add(this.textBoxPrix);
            this.panel1.Controls.Add(this.textBoxNom);
            this.panel1.Controls.Add(this.pictureBoxProduit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 634);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel4.Location = new System.Drawing.Point(88, 373);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 2);
            this.panel4.TabIndex = 7;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxQuantity.Location = new System.Drawing.Point(88, 340);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(310, 20);
            this.textBoxQuantity.TabIndex = 6;
            this.textBoxQuantity.Text = "Quntité";
            this.textBoxQuantity.Enter += new System.EventHandler(this.textBoxQuantity_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "* La date d\'expiration ";
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.FlatAppearance.BorderSize = 2;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonAnnuler.Location = new System.Drawing.Point(250, 497);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(150, 39);
            this.buttonAnnuler.TabIndex = 4;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.FlatAppearance.BorderSize = 2;
            this.buttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.buttonValider.Location = new System.Drawing.Point(88, 497);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(150, 39);
            this.buttonValider.TabIndex = 4;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonUplaod
            // 
            this.buttonUplaod.FlatAppearance.BorderSize = 2;
            this.buttonUplaod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUplaod.ForeColor = System.Drawing.Color.Gray;
            this.buttonUplaod.Location = new System.Drawing.Point(457, 371);
            this.buttonUplaod.Name = "buttonUplaod";
            this.buttonUplaod.Size = new System.Drawing.Size(312, 39);
            this.buttonUplaod.TabIndex = 4;
            this.buttonUplaod.Text = "Uplaod image";
            this.buttonUplaod.UseVisualStyleBackColor = true;
            this.buttonUplaod.Click += new System.EventHandler(this.buttonUplaod_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel7.Location = new System.Drawing.Point(300, 434);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 2);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel8.Location = new System.Drawing.Point(194, 434);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 2);
            this.panel8.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel6.Location = new System.Drawing.Point(194, 434);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 2);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel5.Location = new System.Drawing.Point(88, 434);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 2);
            this.panel5.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel3.Location = new System.Drawing.Point(90, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 2);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel2.Location = new System.Drawing.Point(90, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 2);
            this.panel2.TabIndex = 3;
            // 
            // textBoxAnnee
            // 
            this.textBoxAnnee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAnnee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxAnnee.Location = new System.Drawing.Point(300, 409);
            this.textBoxAnnee.Name = "textBoxAnnee";
            this.textBoxAnnee.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnnee.TabIndex = 2;
            this.textBoxAnnee.Text = "Année";
            this.textBoxAnnee.Enter += new System.EventHandler(this.textBoxAnnee_Enter);
            this.textBoxAnnee.Leave += new System.EventHandler(this.textBoxAnnee_Leave);
            // 
            // textBoxMois
            // 
            this.textBoxMois.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMois.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMois.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMois.Location = new System.Drawing.Point(194, 409);
            this.textBoxMois.Name = "textBoxMois";
            this.textBoxMois.Size = new System.Drawing.Size(100, 20);
            this.textBoxMois.TabIndex = 2;
            this.textBoxMois.Text = "Mois";
            this.textBoxMois.Enter += new System.EventHandler(this.textBoxMois_Enter);
            this.textBoxMois.Leave += new System.EventHandler(this.textBoxMois_Leave);
            // 
            // textBoxJour
            // 
            this.textBoxJour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxJour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxJour.Location = new System.Drawing.Point(88, 409);
            this.textBoxJour.Name = "textBoxJour";
            this.textBoxJour.Size = new System.Drawing.Size(100, 20);
            this.textBoxJour.TabIndex = 2;
            this.textBoxJour.Text = "Jour";
            this.textBoxJour.Enter += new System.EventHandler(this.textBoxJour_Enter);
            this.textBoxJour.Leave += new System.EventHandler(this.textBoxJour_Leave);
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrix.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPrix.Location = new System.Drawing.Point(90, 250);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(310, 20);
            this.textBoxPrix.TabIndex = 2;
            this.textBoxPrix.Text = "Prix";
            this.textBoxPrix.Enter += new System.EventHandler(this.textBoxPrix_Enter);
            this.textBoxPrix.Leave += new System.EventHandler(this.textBoxPrix_Leave);
            // 
            // textBoxNom
            // 
            this.textBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNom.Location = new System.Drawing.Point(90, 152);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(310, 20);
            this.textBoxNom.TabIndex = 2;
            this.textBoxNom.Text = "Nom";
            this.textBoxNom.Enter += new System.EventHandler(this.textBoxNom_Enter);
            this.textBoxNom.Leave += new System.EventHandler(this.textBoxNom_Leave);
            // 
            // pictureBoxProduit
            // 
            this.pictureBoxProduit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProduit.Image = global::ProjetGestionStock.Properties.Resources.livraison;
            this.pictureBoxProduit.Location = new System.Drawing.Point(457, 152);
            this.pictureBoxProduit.Name = "pictureBoxProduit";
            this.pictureBoxProduit.Size = new System.Drawing.Size(312, 194);
            this.pictureBoxProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProduit.TabIndex = 1;
            this.pictureBoxProduit.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 149);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter Un Produit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 634);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAjouterProduit";
            this.Text = "FormAjouterProduit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxProduit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxAnnee;
        private System.Windows.Forms.TextBox textBoxMois;
        private System.Windows.Forms.TextBox textBoxJour;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.Button buttonUplaod;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxQuantity;
    }
}