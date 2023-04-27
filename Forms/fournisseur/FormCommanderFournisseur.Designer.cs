namespace ProjetGestionStock
{
    partial class FormCommanderFournisseur
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
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxArriveAnnee = new System.Windows.Forms.TextBox();
            this.textBoxArriveMois = new System.Windows.Forms.TextBox();
            this.textBoxArriveJour = new System.Windows.Forms.TextBox();
            this.comboBoxfounisseur = new System.Windows.Forms.ComboBox();
            this.comboBoxProduit = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAnnuler);
            this.panel1.Controls.Add(this.buttonValider);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.textBoxArriveAnnee);
            this.panel1.Controls.Add(this.textBoxArriveMois);
            this.panel1.Controls.Add(this.textBoxArriveJour);
            this.panel1.Controls.Add(this.comboBoxfounisseur);
            this.panel1.Controls.Add(this.comboBoxProduit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxQuantite);
            this.panel1.Controls.Add(this.textBoxPrix);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 634);
            this.panel1.TabIndex = 0;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.FlatAppearance.BorderSize = 2;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonAnnuler.Location = new System.Drawing.Point(610, 522);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(150, 39);
            this.buttonAnnuler.TabIndex = 16;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.FlatAppearance.BorderSize = 2;
            this.buttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.buttonValider.Location = new System.Drawing.Point(448, 522);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(150, 39);
            this.buttonValider.TabIndex = 17;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "* la date d’arrivé ";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel10.Location = new System.Drawing.Point(286, 451);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 2);
            this.panel10.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel6.Location = new System.Drawing.Point(180, 451);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 2);
            this.panel6.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel4.Location = new System.Drawing.Point(74, 451);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 2);
            this.panel4.TabIndex = 14;
            // 
            // textBoxArriveAnnee
            // 
            this.textBoxArriveAnnee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxArriveAnnee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArriveAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxArriveAnnee.Location = new System.Drawing.Point(286, 418);
            this.textBoxArriveAnnee.Name = "textBoxArriveAnnee";
            this.textBoxArriveAnnee.Size = new System.Drawing.Size(100, 20);
            this.textBoxArriveAnnee.TabIndex = 7;
            this.textBoxArriveAnnee.Text = "Année";
            this.textBoxArriveAnnee.Enter += new System.EventHandler(this.textBoxArriveAnnee_Enter);
            // 
            // textBoxArriveMois
            // 
            this.textBoxArriveMois.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxArriveMois.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArriveMois.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxArriveMois.Location = new System.Drawing.Point(180, 418);
            this.textBoxArriveMois.Name = "textBoxArriveMois";
            this.textBoxArriveMois.Size = new System.Drawing.Size(100, 20);
            this.textBoxArriveMois.TabIndex = 8;
            this.textBoxArriveMois.Text = "mois";
            this.textBoxArriveMois.Enter += new System.EventHandler(this.textBoxArriveMois_Enter);
            // 
            // textBoxArriveJour
            // 
            this.textBoxArriveJour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxArriveJour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArriveJour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxArriveJour.Location = new System.Drawing.Point(74, 418);
            this.textBoxArriveJour.Name = "textBoxArriveJour";
            this.textBoxArriveJour.Size = new System.Drawing.Size(100, 20);
            this.textBoxArriveJour.TabIndex = 10;
            this.textBoxArriveJour.Text = "Jour";
            this.textBoxArriveJour.Enter += new System.EventHandler(this.textBoxArriveJour_Enter);
            // 
            // comboBoxfounisseur
            // 
            this.comboBoxfounisseur.AllowDrop = true;
            this.comboBoxfounisseur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxfounisseur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxfounisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxfounisseur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxfounisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxfounisseur.FormattingEnabled = true;
            this.comboBoxfounisseur.Location = new System.Drawing.Point(450, 189);
            this.comboBoxfounisseur.Name = "comboBoxfounisseur";
            this.comboBoxfounisseur.Size = new System.Drawing.Size(310, 29);
            this.comboBoxfounisseur.Sorted = true;
            this.comboBoxfounisseur.TabIndex = 6;
            this.comboBoxfounisseur.Text = "précise le fournisseur";
            // 
            // comboBoxProduit
            // 
            this.comboBoxProduit.AllowDrop = true;
            this.comboBoxProduit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxProduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProduit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxProduit.FormattingEnabled = true;
            this.comboBoxProduit.Location = new System.Drawing.Point(76, 189);
            this.comboBoxProduit.Name = "comboBoxProduit";
            this.comboBoxProduit.Size = new System.Drawing.Size(310, 29);
            this.comboBoxProduit.Sorted = true;
            this.comboBoxProduit.TabIndex = 6;
            this.comboBoxProduit.Text = "précise le produit";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel3.Location = new System.Drawing.Point(76, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 2);
            this.panel3.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel7.Location = new System.Drawing.Point(450, 225);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(310, 2);
            this.panel7.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel5.Location = new System.Drawing.Point(450, 341);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 2);
            this.panel5.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel2.Location = new System.Drawing.Point(76, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 2);
            this.panel2.TabIndex = 5;
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuantite.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxQuantite.Location = new System.Drawing.Point(76, 307);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(310, 20);
            this.textBoxQuantite.TabIndex = 4;
            this.textBoxQuantite.Text = "la quantité";
            this.textBoxQuantite.Enter += new System.EventHandler(this.textBoxQuantite_Enter);
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrix.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPrix.Location = new System.Drawing.Point(450, 308);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(310, 20);
            this.textBoxPrix.TabIndex = 4;
            this.textBoxPrix.Text = "le prix";
            this.textBoxPrix.Enter += new System.EventHandler(this.textBoxPrix_Enter);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 149);
            this.label1.TabIndex = 1;
            this.label1.Text = "Commande chez un fournisseur";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCommanderFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 634);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCommanderFournisseur";
            this.Text = "FormCommanderFournisseur";
            this.Load += new System.EventHandler(this.FormCommanderFournisseur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.ComboBox comboBoxProduit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxArriveAnnee;
        private System.Windows.Forms.TextBox textBoxArriveMois;
        private System.Windows.Forms.TextBox textBoxArriveJour;
        private System.Windows.Forms.ComboBox comboBoxfounisseur;
        private System.Windows.Forms.Panel panel7;
    }
}